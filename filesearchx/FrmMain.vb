'Option Strict On
Imports System.IO

'Imports System.ComponentModel
Imports System.Threading
Imports Syncfusion.Windows.Forms

Public Class FrmMain

    Dim lowestdate As DateTime = Nothing
    Dim _threadSearch As Thread

    Partial Public Class FrmMain
        Inherits Form
    End Class

    ReadOnly _ad As String = AppDomain.CurrentDomain.BaseDirectory
    ReadOnly _regtemp As String = _ad & "regtemp\"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        MTxtExt.Mask = ".AAAAAAAA"
        CmbFileFolder.SelectedIndex = 0
        TxtSearchPath.Text = "Y:\VS\"
        DTStart.Format = DateTimePickerFormat.Custom
        DTStart.CustomFormat = "MM/dd/yyyy"
        DTStop.Format = DateTimePickerFormat.Custom
        DTStop.CustomFormat = "MM/dd/yyyy"
        If Directory.Exists(_regtemp) = False Then
            Directory.CreateDirectory(_regtemp)
        End If
        Cleanregtemp()

    End Sub

    Public Sub SearchFiles(Optional ByVal searchstr As String = "*", Optional ByVal ext As String = ".*",
                         Optional ByVal dir As String = "C:\", Optional ByVal startdate As DateTime = Nothing,
                         Optional ByVal stopdate As DateTime = Nothing, Optional ByVal content As String = "", Optional cmb As Integer = 0)


        Dim i = 0

        'Target Directory
        Dim directory = dir

        'Searches directory and it's subdirectories for all files, which "*" stands for
        'Say for example you only want to search for jpeg files... then change "*" to "*.jpg"

        Dim so As SearchOption
        If ChkSub.Checked = True Then
            so = SearchOption.AllDirectories
        Else
            so = SearchOption.TopDirectoryOnly
        End If

        If cmb = 0 Then

#Region "Search Files"

            On Error Resume Next
            For Each filename As String In IO.Directory.GetFiles(directory, "*" & searchstr & "*" & ext, so)
                ' Try

                'The next line of code gets only file extensions from searched directories and subdirectories
                Dim fName As String = Path.GetExtension(filename)

                If fName = ".suo" Then

                    'Skips to next iteration of Loop, ignoring files with .suo extension
                    Continue For
                Else
                    If fName = ".ini" Then

                        'Skips to next iteration of Loop, ignoring files with .ini extension
                        Continue For
                    Else
                        LstResults.BeginUpdate()

                        If startdate = lowestdate Then

                            If content <> "" Then
                                'Try
                                Dim f As String = File.ReadAllText(filename)
                                If f.Contains(content) Then
                                    i = i + 1
                                    LstResults.Items.Add(Convert.ToString(filename))

                                End If

                                'Catch ex As Exception
                                'End Try
                            Else
                                'try
                                i = i + 1
                                LstResults.Items.Add(Convert.ToString(filename))
                                'catch

                                'end Try
                            End If
                        Else
                            'Try
                            ' If ChkUseDate.Checked = True Then
                            Dim strLastModified As String
                            strLastModified = File.GetLastWriteTime(filename).ToShortDateString()
                            Dim questionableDate As Date = strLastModified
                            Dim fromDate As Date = startdate.ToShortDateString()
                            Dim toDate As Date = stopdate.ToShortDateString()

                            If (fromDate <= questionableDate) AndAlso (questionableDate <= toDate) Then
                                If content <> "" Then
                                    'Try
                                    Dim f As String = File.ReadAllText(filename)
                                    If f.Contains(content) Then
                                        i = i + 1
                                        LstResults.Items.Add(Convert.ToString(filename))

                                    End If

                                    'Catch ex As Exception
                                    'End Try
                                Else
                                    'Try
                                    i = i + 1
                                    LstResults.Items.Add(Convert.ToString(filename))
                                    'catch
                                    'end Try
                                End If
                            End If
                            'catch
                            'End Try
                        End If

                        'Your code here above count function
                        'The below counter only displays the final count after all files have been processed

                    End If

                End If
                'Catch ex As Exception

                'End Try
            Next
            'If TabresultA.r Then
            '    TabresultA.Show()
            '    TabresultA.Focus()

#End Region

        Else

#Region "Search Dirs"

            On Error Resume Next
            For Each filename As String In IO.Directory.GetDirectories(directory, "*" & searchstr & "*", so)
                'Try
                If startdate = lowestdate Then
                    'try

                    i = i + 1
                    LstResults.Items.Add(Convert.ToString(filename))

                    'Catch ex As Exception

                    'End Try
                Else
                    'try
                    Dim strLastModified As String
                    strLastModified = File.GetLastWriteTime(filename).ToShortDateString()
                    Dim questionableDate As Date = strLastModified
                    Dim fromDate As Date = startdate
                    Dim toDate As Date = stopdate

                    If (fromDate <= questionableDate) AndAlso (questionableDate <= toDate) Then
                        'try

                        i = i + 1
                        LstResults.Items.Add(Convert.ToString(filename))
                        'Catch ex As Exception

                        'End Try
                    End If
                    'catch
                    'end Try

                End If

                'Your code here above count function
                'The below counter only displays the final count after all files have been processed
                'Catch
                'End Try
            Next

        End If
        LstResults.EndUpdate()
        TabResultsA.Controls.Add(Me.LstResults)
        TabResultsA.Update()
        TabResultsA.Refresh()
        TabControlA.SelectedTab = TabResultsA
        TabResultsA.Focus()

        'MsgBox(LstResults.Items.Count)

#End Region

    End Sub

    Public Sub ChooseSave(a As Control)
        Dim thetextbox As TextBox
        If a.Name.Contains("Diff") Then
            thetextbox = TxtRegPath

            Dim ofDialog As New SaveFileDialog
            ofDialog.DefaultExt = ".reg"
            ofDialog.InitialDirectory = "C:\"

            ofDialog.AddExtension = True
            ofDialog.RestoreDirectory = True
            ofDialog.Filter = "reg files (*.reg)|*.reg|All files (*.*)|*.*"
            ofDialog.FilterIndex = 1

            If ofDialog.ShowDialog() = DialogResult.OK And ofDialog.FileName <> "" And ofDialog.FileName <> Nothing And ofDialog.FileName IsNot Nothing Then

                thetextbox.Text = ofDialog.FileName

            End If
        End If
    End Sub

    Public Sub ChooseFile(a As Control)
        Dim thetextbox As TextBox
        If a.Name.Contains("Diff1") Then
            thetextbox = TxtRegDiff1
            GoTo Start
        ElseIf a.Name.Contains("Diff2") Then
            thetextbox = TxtRegDiff2
            GoTo Start
        Else
            GoTo EndIt
        End If

Start:
        Dim ofDialog As New OpenFileDialog
        ofDialog.DefaultExt = ".reg"
        ofDialog.InitialDirectory = _ad
        ofDialog.CheckFileExists = True

        If ofDialog.ShowDialog() = DialogResult.OK Then
            thetextbox.Text = ofDialog.FileName
            GoTo EndIt
        Else
            GoTo EndIt
        End If

EndIt:
    End Sub

    Public Sub ChooseFolder(a As Control)

        Dim fbDialog As New FolderBrowserDialog
        If fbDialog.ShowDialog() = DialogResult.OK And fbDialog.SelectedPath <> "" And fbDialog.SelectedPath <> Nothing And fbDialog.SelectedPath IsNot Nothing Then
            Dim thetextbox As Control

            If a.Name.Contains("Dir") = True Then
                thetextbox = TxtSearchPath
                thetextbox.Text = fbDialog.SelectedPath
            ElseIf a.Name.Contains("RegPath") Then
                thetextbox = TxtRegPath
                thetextbox.Text = fbDialog.SelectedPath
            End If
        End If
    End Sub

    Private Sub BtnDirSelect_Click(sender As Object, e As EventArgs) Handles BtnDirSelect.Click
        ChooseFolder(sender)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles ChkAnyExt.CheckedChanged
        If ChkAnyExt.Checked = True Then
            MTxtExt.Visible = False
            TxtAnyExt.Visible = True
        Else
            MTxtExt.Visible = True
            TxtAnyExt.Visible = False
        End If
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click

        If BtnSearch.Text = "Searching" Then
            _threadSearch.Abort()
            BtnSearch.Text = "Search"
        Else
            _threadSearch = New Thread(AddressOf SearchStart)
            'SearchStart()
            _threadSearch.Start()
            BtnSearch.Text = "Searching"
        End If

    End Sub

    Public Sub SearchStart()

        Dim dofile As String
        Dim doext As String
        Dim dostart As Date
        Dim dostop As Date
        Dim docontent As String
        Dim dodir As String

        If ChkClrPrev.Checked = True Then
            LstResults.Items.Clear()
        End If

        If TxtSearchPath.Text = "" Then
            dodir = "C:\"
        Else
            dodir = TxtSearchPath.Text
        End If

        If ChkUseDate.CheckState = False Then
            dostart = Nothing
            dostop = Nothing
        Else
            dostart = DTStart.Value.Date.ToString()
            dostop = DTStop.Value.Date.ToString()
        End If

        If TxtFileName.Text = "" Then
            dofile = "*"
        Else
            dofile = TxtFileName.Text
        End If

        If ChkAnyExt.Checked = True Then
            doext = TxtAnyExt.Text
        Else
            doext = MTxtExt.Text
        End If

        If TxtFileContent.Text = "" Then
            docontent = ""
        Else
            docontent = TxtFileContent.Text
        End If



        SearchFiles(dofile, doext, dodir, dostart, dostop, docontent)

        If LstResults.Items.Count > 0 Then

            'LstResults.Update()



        End If

        BtnSearch.Text = "Search"
    End Sub

    Private Sub ChkUseDate_CheckedChanged(sender As Object, e As EventArgs) Handles ChkUseDate.CheckedChanged 
        If ChkUseDate.Checked = True Then
            DTStop.Visible = True
            DTStart.Visible = True
            LblDStop.Visible = True
            LblDStart.Visible = True
        Else
            DTStop.Visible = False
            DTStart.Visible = False
            LblDStop.Visible = False
            LblDStart.Visible = False
        End If
    End Sub

    Private Sub LstResults_DoubleClick(sender As Object, e As EventArgs)  Handles LstResults.DoubleClick

        'Dim fp As String = Path.GetDirectoryName(LstResults.SelectedItem.ToString)
        Process.Start("C:\Windows\System32\Explorer.exe", "/select," & Chr(34) & LstResults.SelectedItem.ToString & Chr(34))
    End Sub

    Private Sub CmbFileFolder_SelectedIndexChanged(sender As Object, e As EventArgs) 
        If CmbFileFolder.SelectedIndex = 0 Then
            ChkAnyExt.Show()
            If ChkAnyExt.Checked = True Then
                TxtAnyExt.Show()
            Else
                MTxtExt.Show()
            End If
            LblExt.Show()
        Else
            ChkAnyExt.Hide()
            If ChkAnyExt.Checked = True Then
                TxtAnyExt.Hide()
            Else
                MTxtExt.Hide()
            End If
            LblExt.Hide()

        End If
    End Sub

    Private Sub ChkMoveNew_CheckedChanged(sender As Object, e As EventArgs) 
        If ChkMoveNew.Checked = True Then
            ChkMove.Visible = False
            BtnMoveDir.Text = "Select Root"
            LblMoveNewNotice.Visible = True
        Else
            ChkMove.Visible = True
            BtnMoveDir.Text = "Select Dir"
            LblMoveNewNotice.Visible = False
        End If
    End Sub

    Public Sub ExportAllReg(finaloutput As String)
        Dim reglist As New List(Of String)

        Dim ttlreg = 0
        If ChkHKAll.Checked = True Then
            Exportreg("\", finaloutput)
        Else
            For Each cntrl As CheckBox In GrpKeys.Controls
                If TypeOf cntrl Is CheckBox And cntrl.Checked = True And cntrl.Name.ToString.Contains("HK") Then
                    Dim hk As String = cntrl.Name.ToString.Replace("Chk", "")

                    Dim newfile As String = _regtemp & ttlreg & ".reg"
                    reglist.Add(newfile)

                    Exportreg(hk, newfile)
                    ttlreg = ttlreg + 1
                End If
            Next
            If reglist.Count = 1 Then
                If File.Exists(finaloutput) Then
                    File.Delete(finaloutput)
                End If
                File.Move(reglist(0), finaloutput)
            Else

                Dim i = 0

                Dim c As Integer = reglist.Count

                Dim input1 As String = Nothing
                Dim input2 As String

                Do Until i = c
                    While i = 0
                        input1 = reglist(i)
                        i = i + 1
                    End While
                    While i = 1
                        input2 = reglist(i)
                        If i + 1 = c Then
                            Mergereg(input1, input2, finaloutput)
                        Else
                            If File.Exists(_regtemp & "tempout.reg") Then
                                File.Delete(_regtemp & "tempout.reg")
                            End If

                            Mergereg(input1, input2)

                        End If
                        File.Delete(input1)
                        File.Delete(input2)
                        i = i + 1
                    End While
                    While i >= 2 And i < c
                        input1 = _regtemp & "temp.reg"
                        File.Move(_regtemp & "tempout.reg", input1)
                        input2 = reglist(i)
                        If i + 1 = c Then
                            Mergereg(input1, input2, finaloutput)
                        Else
                            Mergereg(input1, input2)

                        End If
                        File.Delete(input2)
                        File.Delete(input1)
                        i = i + 1
                    End While
                Loop

            End If
        End If

        Cleanregtemp()

    End Sub

    Public Sub Cleanregtemp()
        For Each deleteFile In Directory.GetFiles(_regtemp, "*.*", SearchOption.TopDirectoryOnly)
            Try
                File.Delete(deleteFile)
            Catch
            End Try
        Next
    End Sub

    Public Sub Mergereg(input1 As String, input2 As String, Optional outf As String = Chr(34) & "%basedir%" & "tempout.reg" & Chr(34))
        'Dim thefile As String = ""
        Dim p = New Process
        ' Redirect the output stream of the child process.
        p.StartInfo.UseShellExecute = False
        p.StartInfo.RedirectStandardOutput = True
        p.StartInfo.FileName = _ad & "regdiff.exe"
        p.StartInfo.Arguments = Chr(34) & input1 & Chr(34) & " " & Chr(34) & input2 & Chr(34) & " /merge " & outf.ToString.Replace("%basedir%", _regtemp)
        p.Start()
        ' ReSharper disable once UnusedVariable
        Dim output As String = p.StandardOutput.ReadToEnd
        p.WaitForExit()
    End Sub

    Private Sub BtnExportReg_Click(sender As Object, e As EventArgs) Handles BtnExportReg.Click
        Dim i = 0
        For Each cntrl As Control In GrpKeys.Controls

            If (cntrl.GetType() Is GetType(CheckBox)) And cntrl.Name.Contains("HK") = True And cntrl.Name.Contains("All") = False Then
                Dim chk = CType(cntrl, CheckBox)
                If chk.Checked = True Then
                    i = i + 1
                End If
            End If

        Next

        If i = 0 Then
            MsgBox("Please select a key Or keys to export.")
        Else

            Dim tp As String = TxtRegPath.Text

            If TxtRegPath.Text.Contains(".reg") = False Then
                If Directory.Exists(tp & "\") = True Then
                    tp = tp & "\"
                End If
                Dim randpath As String = tp & Guid.NewGuid().ToString & ".reg"
                tp = randpath

            End If

            If File.Exists(tp) Then
                Dim result As MsgBoxResult
                'Dim chc As Integer

                result = MsgBox("Overwrite Existing Reg File?", vbYesNo, "Start?")
                If result <> MsgBoxResult.Yes Then
                    TxtRegPath.Focus()
                    Exit Sub
                End If

            End If

            ExportAllReg(tp)

        End If
    End Sub

    Public Sub Exportreg(hKloc As String, exportLoc As String)
        'Dim tempdir As String = _ad
        'Dim thefile As String = ""
        Dim p = New Process
        ' Redirect the output stream of the child process.
        p.StartInfo.UseShellExecute = False
        p.StartInfo.RedirectStandardOutput = True
        p.StartInfo.FileName = Environment.ExpandEnvironmentVariables("%windir%\System32\reg.exe")
        p.StartInfo.Arguments = "EXPORT " & hKloc & " " & Chr(34) & exportLoc & Chr(34) & " /y"
        p.Start()
        ' ReSharper disable once UnusedVariable
        Dim output As String = p.StandardOutput.ReadToEnd
        p.WaitForExit()

        'Process.Start(, "export "Hkey_local_Machine\Software\mcafee C:\export.reg")
    End Sub

    Public Sub Checkall(a As CheckBox)
        If a Is ChkHKAll Then
            If ChkHKAll.Checked = True Then

                For Each cntrl As Control In GrpKeys.Controls

                    If (cntrl.GetType() Is GetType(CheckBox)) And cntrl.Name.Contains("HK") = True And cntrl.Name.Contains("All") = False Then
                        Dim chk = CType(cntrl, CheckBox)
                        chk.Checked = True
                    End If

                Next
                ChkHKAll.Checked = False

            End If
        ElseIf a.CheckState = CheckState.Checked And ChkHKAll.CheckState = CheckState.Checked Then

            ChkHKAll.Checked = False

        End If

    End Sub

    Private Sub BtnRegDir_Click(sender As Object, e As EventArgs) Handles BtnRegDir.Click
        ChooseSave(TxtRegPath)
    End Sub

    Private Sub RegCheckbox_Clicked(sender As Object, e As EventArgs) Handles ChkHKU.Click, ChkHKLM.Click, ChkHKCU.Click, ChkHKCR.Click, ChkHKCC.Click, ChkHKAll.Click 
        Checkall(sender)
    End Sub

    Private Sub BtnRegDiff1_Click(sender As Object, e As EventArgs) Handles BtnRegDiff1.click
        ChooseFile(sender)
    End Sub

    Private Sub BtnDiff_Click(sender As Object, e As EventArgs) Handles BtnDiff.click
        If File.Exists(TxtRegDiff1.Text) = False Then
            ChooseFile(TxtRegDiff1)
        Else

            If File.Exists(TxtRegDiff2.Text) = False Then
                ChooseFile(TxtRegDiff2)
            Else

                If File.Exists(TxtRegPath.Text) Then
                    Dim result As MsgBoxResult
                    'Dim chc As Integer

                    result = MsgBox("Overwrite Existing Reg File?", vbYesNo, "Start?")
                    If result <> MsgBoxResult.Yes Then
                        TxtRegPath.Focus()
                        Exit Sub
                    Else
                        Regdiff(TxtRegDiff1.Text, TxtRegDiff2.Text, TxtRegPath.Text)
                    End If
                Else
                    If TxtRegPath.Text = "" Then
                        ChooseSave(sender)
                    Else

                        Regdiff(TxtRegDiff1.Text, TxtRegDiff2.Text, TxtRegPath.Text)
                    End If
                End If

            End If

        End If

    End Sub

    Public Sub Regdiff(input1 As String, input2 As String, Optional outf As String = Chr(34) & "C:\" & "thediffs.reg" & Chr(34))
        'Dim thefile As String = ""
        Dim p = New Process
        ' Redirect the output stream of the child process.
        p.StartInfo.UseShellExecute = False
        p.StartInfo.RedirectStandardOutput = True
        p.StartInfo.FileName = _ad & "regdiff.exe"
        p.StartInfo.Arguments = Chr(34) & input1 & Chr(34) & " " & Chr(34) & input2 & Chr(34) & " /merge " & outf.ToString.Replace("%basedir%", _regtemp)
        p.Start()
        ' ReSharper disable once UnusedVariable
        Dim output As String = p.StandardOutput.ReadToEnd
        p.WaitForExit()
    End Sub

    Private Sub MTxtExt_Leave(sender As Object, e As EventArgs)  Handles MTxtExt.Leave 
        MTxtExt.Text = MTxtExt.Text.ToString.Replace(" ", "")
    End Sub

    Public Sub TabSearchA_Click(sender As Object, e As EventArgs) Handles TabSearchA.Click
        'Environment.Na
    End Sub

    Private Sub MoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MoveToolStripMenuItem.Click
        If LstResults.Items.Count > 0 And CmbFileFolder.SelectedItem = "Search Files" Then
            tabcontrola.SelectedTab = tabactionsa
            ChkMove.Checked = True
        Else
            MsgBox("Make sure you have some results and they are files.")
        End If
    End Sub

    Private Sub RenameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RenameToolStripMenuItem.Click
        If LstResults.Items.Count > 0 And CmbFileFolder.SelectedItem = "Search Files" Then
            tabcontrola.SelectedTab = tabactionsa
            ChkRename.Checked = True
        Else
            MsgBox("Make sure you have some results and they are files.")
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        If LstResults.Items.Count > 0 And CmbFileFolder.SelectedItem = "Search Files" Then
        Else
            MsgBox("Make sure you have some results.")
        End If
    End Sub

    Private Sub BtnProcessMonitor_Click(sender As Object, e As EventArgs) Handles BtnProcessMonitor.Click

        FolderBrowser1.StartLocation = FolderBrowserFolder.MyComputer
        FolderBrowser1.Description = "Look Around"
        FolderBrowser1.DirectoryPath.ToString()
        Process.start("tasmgr")
    End Sub
End Class

'Namespace TestRegExControls

'    Partial Public Class Form1
'        Inherits Form

'        Public Sub New()
'            InitializeComponent()
'        End Sub

'        Dim errorProvider1 As New ErrorProvider

'#Region "Handle Validations"

'        'Private Sub regExTextBox1_Validating(sender As Object, e As CancelEventArgs)
'        '    ' test the control for invalid input
'        '    If regExTextBox1.ValidateControl() = False Then
'        '        ' display error if user input is invalid
'        '        errorProvider1.SetError(regExTextBox1, "Invalid SSN (e.g., 123-22-3344)")
'        '    Else
'        '        ' set error message to nothing if control
'        '        ' passes validation
'        '        errorProvider1.SetError(regExTextBox1, "")
'        '    End If
'        'End Sub

'        'Private Sub regExTextBox2_Validating(sender As Object, e As CancelEventArgs)
'        '    ' test the control for invalid input
'        '    If regExTextBox2.ValidateControl() = False Then
'        '        ' display error if user input is invalid
'        '        errorProvider1.SetError(regExTextBox2, "Invalid Phone Number (e.g., 818-720-1234)")
'        '    Else
'        '        ' set error message to nothing if control
'        '        ' passes validation
'        '        errorProvider1.SetError(regExTextBox2, "")
'        '    End If
'        'End Sub

'        'Private Sub regExTextBox3_Validating(sender As Object, e As CancelEventArgs)
'        '    ' test the control for invalid input
'        '    If regExTextBox3.ValidateControl() = False Then
'        '        ' display error if user input is invalid
'        '        errorProvider1.SetError(regExTextBox3, "Invalid Email Address (e.g., pres@whitehouse.gov)")
'        '    Else
'        '        ' set error message to nothing if control
'        '        ' passes validation
'        '        errorProvider1.SetError(regExTextBox3, "")
'        '    End If
'        'End Sub

'        'Private Sub regExTextBox4_Validating(sender As Object, e As CancelEventArgs)
'        '    ' test the control for invalid input
'        '    If regExTextBox4.ValidateControl() = False Then
'        '        ' display error if user input is invalid
'        '        errorProvider1.SetError(regExTextBox4, "Invalid IP Address (e.g., 127.0.0.1)")
'        '    Else
'        '        ' set error message to nothing if control
'        '        ' passes validation
'        '        errorProvider1.SetError(regExTextBox4, "")
'        '    End If
'        'End Sub

'        'Private Sub regExTextBox5_Validating(sender As Object, e As CancelEventArgs)
'        '    ' test the control for invalid input
'        '    If regExTextBox5.ValidateControl() = False Then
'        '        ' display error if user input is invalid
'        '        errorProvider1.SetError(regExTextBox5, "Invalid State Abbreviation (e.g., AZ or GA)")
'        '    Else
'        '        ' set error message to nothing if control
'        '        ' passes validation
'        '        errorProvider1.SetError(regExTextBox5, "")
'        '    End If
'        'End Sub

'        'Private Function PerformFormValidation() As Boolean

'        '    ' check for errors to set return value
'        '    If regExTextBox1.ValidateControl() = False Then
'        '        Return False
'        '    End If

'        '    If regExTextBox2.ValidateControl() = False Then
'        '        Return False
'        '    End If

'        '    If regExTextBox3.ValidateControl() = False Then
'        '        Return False
'        '    End If

'        '    If regExTextBox4.ValidateControl() = False Then
'        '        Return False
'        '    End If

'        '    If regExTextBox5.ValidateControl() = False Then
'        '        Return False
'        '    End If

'        '    ' if it has not found an invalid control, return with true
'        '    Return True
'        'End Function

'#End Region

'        Private Sub btnExit_Click(sender As Object, e As EventArgs)
'            ' test the form before allowing the user to close it
'            Dim valResult As Boolean = PerformFormValidation()

'            If valResult = True Then
'                Application.[Exit]()
'            Else
'                MessageBox.Show("Fix errors on this page prior to closing form")
'            End If
'        End Sub

'        Private Sub btnValidate_Click(sender As Object, e As EventArgs)
'            ' test the form
'            Dim valResult As Boolean = PerformFormValidation()

'            If valResult = True Then
'                MessageBox.Show("All form fields are valid")
'            Else
'                MessageBox.Show("This form contains errors")
'            End If
'        End Sub

'        Private Sub Form1_Load(sender As Object, e As EventArgs)

'        End Sub
'    End Class
'End Namespace

'Namespace RegExControls
'    Partial Public Class RegExTextBox
'        Inherits TextBox

'#Region "Declarations"

'        Private mRegularExpression As String

'#End Region

'#Region "Properties"

'        Public Property Regular_Expression() As String
'            Get
'                Return mRegularExpression
'            End Get
'            Set
'                mRegularExpression = Value
'            End Set
'        End Property

'#End Region

'#Region "Constructor"

'        Public Sub New()
'            InitializeComponent()
'        End Sub

'#End Region

'#Region "Methods"

'        Protected Overrides Sub OnPaint(pe As PaintEventArgs)
'            ' TODO: Add custom paint code here

'            ' Calling the base class OnPaint
'            MyBase.OnPaint(pe)
'        End Sub

'        Public Function ValidateControl() As Boolean
'            Dim TextToValidate As String
'            Dim expression As Regex

'            Try
'                TextToValidate = Me.Text
'                expression = New Regex(Regular_Expression)
'            Catch
'                Return False
'            End Try

'            ' test text with expression
'            If expression.IsMatch(TextToValidate) Then
'                Return True
'            Else
'                ' no match
'                Return False
'            End If
'        End Function

'#End Region

'    End Class
'End Namespace