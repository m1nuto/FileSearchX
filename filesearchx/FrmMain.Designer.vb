Imports System.ComponentModel
Imports System.DirectoryServices
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()>
Partial Class FrmMain
    Inherits Form

    'Form overrides dispose to clean up the component list.
    <DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.DirectorySearcher1 = New System.DirectoryServices.DirectorySearcher()
        Me.errorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.CMLstResult = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RenameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FolderBrowser1 = New Syncfusion.Windows.Forms.FolderBrowser(Me.components)
        Me.SfToolTip1 = New Syncfusion.WinForms.Controls.SfToolTip(Me.components)
        Me.TabControlA = New Syncfusion.Windows.Forms.Tools.TabControlAdv()
        Me.TabSearchA = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ChkAnyExt = New System.Windows.Forms.CheckBox()
        Me.MTxtExt = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtFileContent = New System.Windows.Forms.TextBox()
        Me.LblExt = New System.Windows.Forms.Label()
        Me.LblFileName = New System.Windows.Forms.Label()
        Me.TxtFileName = New System.Windows.Forms.TextBox()
        Me.TxtAnyExt = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GboxSearchOp = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbFileFolder = New System.Windows.Forms.ComboBox()
        Me.ChkSub = New System.Windows.Forms.CheckBox()
        Me.ChkClrPrev = New System.Windows.Forms.CheckBox()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.BtnDirSelect = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtSearchPath = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ChkUseDate = New System.Windows.Forms.CheckBox()
        Me.DTStop = New System.Windows.Forms.DateTimePicker()
        Me.DTStart = New System.Windows.Forms.DateTimePicker()
        Me.LblDStop = New System.Windows.Forms.Label()
        Me.LblDStart = New System.Windows.Forms.Label()
        Me.TabResultsA = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
        Me.LstResults = New System.Windows.Forms.ListBox()
        Me.TabActionsA = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.LblMoveNewNotice = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnMoveDir = New System.Windows.Forms.Button()
        Me.ChkMoveNew = New System.Windows.Forms.CheckBox()
        Me.ChkMove = New System.Windows.Forms.CheckBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtRenameChange = New System.Windows.Forms.TextBox()
        Me.TxtRenameMatch = New System.Windows.Forms.TextBox()
        Me.ChkRename = New System.Windows.Forms.CheckBox()
        Me.TabRegistryA = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
        Me.BtnRegDiff2 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtRegDiff2 = New System.Windows.Forms.TextBox()
        Me.BtnDiff = New System.Windows.Forms.Button()
        Me.BtnRegDiff1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtRegDiff1 = New System.Windows.Forms.TextBox()
        Me.GrpKeys = New System.Windows.Forms.GroupBox()
        Me.ChkHKAll = New System.Windows.Forms.CheckBox()
        Me.ChkHKCC = New System.Windows.Forms.CheckBox()
        Me.ChkHKU = New System.Windows.Forms.CheckBox()
        Me.ChkHKCU = New System.Windows.Forms.CheckBox()
        Me.ChkHKLM = New System.Windows.Forms.CheckBox()
        Me.ChkHKCR = New System.Windows.Forms.CheckBox()
        Me.BtnExportReg = New System.Windows.Forms.Button()
        Me.BtnRegDir = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtRegPath = New System.Windows.Forms.TextBox()
        Me.TabExternalA = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
        Me.BtnProcessMonitor = New System.Windows.Forms.Button()
        Me.filebrowser1 = New Syncfusion.Windows.Forms.FolderBrowser(Me.components)
        CType(Me.errorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CMLstResult.SuspendLayout()
        CType(Me.TabControlA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlA.SuspendLayout()
        Me.TabSearchA.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GboxSearchOp.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabResultsA.SuspendLayout()
        Me.TabActionsA.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.TabRegistryA.SuspendLayout()
        Me.GrpKeys.SuspendLayout()
        Me.TabExternalA.SuspendLayout()
        Me.SuspendLayout()
        '
        'DirectorySearcher1
        '
        Me.DirectorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01")
        '
        'errorProvider1
        '
        Me.errorProvider1.ContainerControl = Me
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "SchFindFile"
        '
        'CMLstResult
        '
        Me.CMLstResult.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MoveToolStripMenuItem, Me.RemoveToolStripMenuItem, Me.RenameToolStripMenuItem, Me.ListToolStripMenuItem})
        Me.CMLstResult.Name = "CMLstResult"
        Me.CMLstResult.Size = New System.Drawing.Size(114, 92)
        '
        'MoveToolStripMenuItem
        '
        Me.MoveToolStripMenuItem.Name = "MoveToolStripMenuItem"
        Me.MoveToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.MoveToolStripMenuItem.Text = "Move"
        '
        'RemoveToolStripMenuItem
        '
        Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        Me.RemoveToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.RemoveToolStripMenuItem.Text = "Remove"
        '
        'RenameToolStripMenuItem
        '
        Me.RenameToolStripMenuItem.Name = "RenameToolStripMenuItem"
        Me.RenameToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.RenameToolStripMenuItem.Text = "Rename"
        '
        'ListToolStripMenuItem
        '
        Me.ListToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem})
        Me.ListToolStripMenuItem.Name = "ListToolStripMenuItem"
        Me.ListToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.ListToolStripMenuItem.Text = "List"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'TabControlA
        '
        Me.TabControlA.ActiveTabColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TabControlA.ActiveTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TabControlA.ActiveTabForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TabControlA.BeforeTouchSize = New System.Drawing.Size(584, 317)
        Me.TabControlA.CloseButtonBackColor = System.Drawing.Color.IndianRed
        Me.TabControlA.CloseButtonForeColor = System.Drawing.Color.Empty
        Me.TabControlA.CloseButtonHoverForeColor = System.Drawing.Color.Empty
        Me.TabControlA.CloseButtonPressedForeColor = System.Drawing.Color.Empty
        Me.TabControlA.Controls.Add(Me.TabSearchA)
        Me.TabControlA.Controls.Add(Me.TabResultsA)
        Me.TabControlA.Controls.Add(Me.TabActionsA)
        Me.TabControlA.Controls.Add(Me.TabRegistryA)
        Me.TabControlA.Controls.Add(Me.TabExternalA)
        Me.TabControlA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlA.FixedSingleBorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TabControlA.InactiveCloseButtonForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TabControlA.InActiveTabForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TabControlA.Location = New System.Drawing.Point(0, 0)
        Me.TabControlA.Name = "TabControlA"
        Me.TabControlA.SeparatorColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TabControlA.ShowSeparator = False
        Me.TabControlA.Size = New System.Drawing.Size(584, 317)
        Me.TabControlA.TabIndex = 38
        Me.TabControlA.TabPanelBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TabControlA.TabStyle = GetType(Syncfusion.Windows.Forms.Tools.TabRendererBlendDark)
        '
        'TabSearchA
        '
        Me.TabSearchA.Controls.Add(Me.Panel3)
        Me.TabSearchA.Controls.Add(Me.Panel2)
        Me.TabSearchA.Controls.Add(Me.Panel1)
        Me.TabSearchA.Image = Nothing
        Me.TabSearchA.ImageSize = New System.Drawing.Size(16, 16)
        Me.TabSearchA.Location = New System.Drawing.Point(1, 22)
        Me.TabSearchA.Name = "TabSearchA"
        Me.TabSearchA.ShowCloseButton = True
        Me.TabSearchA.Size = New System.Drawing.Size(581, 293)
        Me.TabSearchA.TabIndex = 1
        Me.TabSearchA.Text = "Search"
        Me.TabSearchA.ThemesEnabled = False
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.ChkAnyExt)
        Me.Panel3.Controls.Add(Me.MTxtExt)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.TxtFileContent)
        Me.Panel3.Controls.Add(Me.LblExt)
        Me.Panel3.Controls.Add(Me.LblFileName)
        Me.Panel3.Controls.Add(Me.TxtFileName)
        Me.Panel3.Controls.Add(Me.TxtAnyExt)
        Me.Panel3.Location = New System.Drawing.Point(-1, 127)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(582, 72)
        Me.Panel3.TabIndex = 60
        '
        'ChkAnyExt
        '
        Me.ChkAnyExt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkAnyExt.AutoSize = True
        Me.ChkAnyExt.Location = New System.Drawing.Point(501, 45)
        Me.ChkAnyExt.Margin = New System.Windows.Forms.Padding(2)
        Me.ChkAnyExt.Name = "ChkAnyExt"
        Me.ChkAnyExt.Size = New System.Drawing.Size(62, 17)
        Me.ChkAnyExt.TabIndex = 58
        Me.ChkAnyExt.Text = "Any Ext"
        Me.ChkAnyExt.UseVisualStyleBackColor = True
        '
        'MTxtExt
        '
        Me.MTxtExt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MTxtExt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MTxtExt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MTxtExt.Location = New System.Drawing.Point(500, 10)
        Me.MTxtExt.Margin = New System.Windows.Forms.Padding(2)
        Me.MTxtExt.Name = "MTxtExt"
        Me.MTxtExt.Size = New System.Drawing.Size(60, 20)
        Me.MTxtExt.TabIndex = 57
        Me.MTxtExt.Text = ".sln"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 44)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Content:"
        '
        'TxtFileContent
        '
        Me.TxtFileContent.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtFileContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TxtFileContent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtFileContent.Location = New System.Drawing.Point(76, 42)
        Me.TxtFileContent.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtFileContent.Name = "TxtFileContent"
        Me.TxtFileContent.Size = New System.Drawing.Size(380, 20)
        Me.TxtFileContent.TabIndex = 55
        '
        'LblExt
        '
        Me.LblExt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblExt.AutoSize = True
        Me.LblExt.Location = New System.Drawing.Point(470, 11)
        Me.LblExt.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblExt.Name = "LblExt"
        Me.LblExt.Size = New System.Drawing.Size(25, 13)
        Me.LblExt.TabIndex = 54
        Me.LblExt.Text = "Ext:"
        '
        'LblFileName
        '
        Me.LblFileName.AutoSize = True
        Me.LblFileName.Location = New System.Drawing.Point(15, 9)
        Me.LblFileName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblFileName.Name = "LblFileName"
        Me.LblFileName.Size = New System.Drawing.Size(57, 13)
        Me.LblFileName.TabIndex = 53
        Me.LblFileName.Text = "SearchStr:"
        '
        'TxtFileName
        '
        Me.TxtFileName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtFileName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TxtFileName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtFileName.Location = New System.Drawing.Point(76, 9)
        Me.TxtFileName.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtFileName.Name = "TxtFileName"
        Me.TxtFileName.Size = New System.Drawing.Size(380, 20)
        Me.TxtFileName.TabIndex = 52
        '
        'TxtAnyExt
        '
        Me.TxtAnyExt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtAnyExt.Enabled = False
        Me.TxtAnyExt.Location = New System.Drawing.Point(501, 10)
        Me.TxtAnyExt.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtAnyExt.Name = "TxtAnyExt"
        Me.TxtAnyExt.Size = New System.Drawing.Size(59, 20)
        Me.TxtAnyExt.TabIndex = 59
        Me.TxtAnyExt.Text = ".*"
        Me.TxtAnyExt.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.GboxSearchOp)
        Me.Panel2.Controls.Add(Me.BtnSearch)
        Me.Panel2.Controls.Add(Me.BtnDirSelect)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.TxtSearchPath)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(581, 95)
        Me.Panel2.TabIndex = 59
        '
        'GboxSearchOp
        '
        Me.GboxSearchOp.Controls.Add(Me.Label1)
        Me.GboxSearchOp.Controls.Add(Me.CmbFileFolder)
        Me.GboxSearchOp.Controls.Add(Me.ChkSub)
        Me.GboxSearchOp.Controls.Add(Me.ChkClrPrev)
        Me.GboxSearchOp.Location = New System.Drawing.Point(75, 7)
        Me.GboxSearchOp.Name = "GboxSearchOp"
        Me.GboxSearchOp.Size = New System.Drawing.Size(380, 50)
        Me.GboxSearchOp.TabIndex = 64
        Me.GboxSearchOp.TabStop = False
        Me.GboxSearchOp.Text = "Options"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(219, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Files or Folders:"
        '
        'CmbFileFolder
        '
        Me.CmbFileFolder.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmbFileFolder.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CmbFileFolder.FormattingEnabled = True
        Me.CmbFileFolder.Items.AddRange(New Object() {"Search Files", "Search Folders"})
        Me.CmbFileFolder.Location = New System.Drawing.Point(222, 24)
        Me.CmbFileFolder.Margin = New System.Windows.Forms.Padding(2)
        Me.CmbFileFolder.Name = "CmbFileFolder"
        Me.CmbFileFolder.Size = New System.Drawing.Size(121, 21)
        Me.CmbFileFolder.TabIndex = 67
        '
        'ChkSub
        '
        Me.ChkSub.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkSub.AutoSize = True
        Me.ChkSub.Checked = True
        Me.ChkSub.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkSub.Location = New System.Drawing.Point(36, 14)
        Me.ChkSub.Margin = New System.Windows.Forms.Padding(2)
        Me.ChkSub.Name = "ChkSub"
        Me.ChkSub.Size = New System.Drawing.Size(130, 17)
        Me.ChkSub.TabIndex = 66
        Me.ChkSub.Text = "Search Subdirectories"
        Me.ChkSub.UseVisualStyleBackColor = True
        '
        'ChkClrPrev
        '
        Me.ChkClrPrev.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkClrPrev.AutoSize = True
        Me.ChkClrPrev.Checked = True
        Me.ChkClrPrev.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkClrPrev.Location = New System.Drawing.Point(36, 29)
        Me.ChkClrPrev.Margin = New System.Windows.Forms.Padding(2)
        Me.ChkClrPrev.Name = "ChkClrPrev"
        Me.ChkClrPrev.Size = New System.Drawing.Size(131, 17)
        Me.ChkClrPrev.TabIndex = 65
        Me.ChkClrPrev.Text = "Clear Previous Search"
        Me.ChkClrPrev.UseVisualStyleBackColor = True
        '
        'BtnSearch
        '
        Me.BtnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSearch.Location = New System.Drawing.Point(495, 21)
        Me.BtnSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(64, 25)
        Me.BtnSearch.TabIndex = 61
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'BtnDirSelect
        '
        Me.BtnDirSelect.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDirSelect.Location = New System.Drawing.Point(495, 59)
        Me.BtnDirSelect.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnDirSelect.Name = "BtnDirSelect"
        Me.BtnDirSelect.Size = New System.Drawing.Size(64, 25)
        Me.BtnDirSelect.TabIndex = 60
        Me.BtnDirSelect.Text = "Select Dir"
        Me.BtnDirSelect.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 65)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "SearchDir:"
        '
        'TxtSearchPath
        '
        Me.TxtSearchPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSearchPath.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TxtSearchPath.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtSearchPath.Location = New System.Drawing.Point(75, 62)
        Me.TxtSearchPath.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtSearchPath.Name = "TxtSearchPath"
        Me.TxtSearchPath.Size = New System.Drawing.Size(380, 20)
        Me.TxtSearchPath.TabIndex = 58
        Me.TxtSearchPath.Text = "Y:\VS\"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.ChkUseDate)
        Me.Panel1.Controls.Add(Me.DTStop)
        Me.Panel1.Controls.Add(Me.DTStart)
        Me.Panel1.Controls.Add(Me.LblDStop)
        Me.Panel1.Controls.Add(Me.LblDStart)
        Me.Panel1.Location = New System.Drawing.Point(0, 231)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(581, 64)
        Me.Panel1.TabIndex = 58
        '
        'ChkUseDate
        '
        Me.ChkUseDate.AutoSize = True
        Me.ChkUseDate.Location = New System.Drawing.Point(17, 27)
        Me.ChkUseDate.Margin = New System.Windows.Forms.Padding(2)
        Me.ChkUseDate.Name = "ChkUseDate"
        Me.ChkUseDate.Size = New System.Drawing.Size(76, 17)
        Me.ChkUseDate.TabIndex = 61
        Me.ChkUseDate.Text = "Use Dates"
        Me.ChkUseDate.UseVisualStyleBackColor = True
        '
        'DTStop
        '
        Me.DTStop.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DTStop.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DTStop.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DTStop.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DTStop.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DTStop.Location = New System.Drawing.Point(298, 24)
        Me.DTStop.Margin = New System.Windows.Forms.Padding(2)
        Me.DTStop.Name = "DTStop"
        Me.DTStop.Size = New System.Drawing.Size(121, 20)
        Me.DTStop.TabIndex = 59
        Me.DTStop.Visible = False
        '
        'DTStart
        '
        Me.DTStart.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DTStart.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DTStart.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DTStart.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DTStart.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DTStart.CustomFormat = "MM/dd/YY"
        Me.DTStart.Location = New System.Drawing.Point(112, 24)
        Me.DTStart.Margin = New System.Windows.Forms.Padding(2)
        Me.DTStart.Name = "DTStart"
        Me.DTStart.Size = New System.Drawing.Size(121, 20)
        Me.DTStart.TabIndex = 58
        Me.DTStart.Visible = False
        '
        'LblDStop
        '
        Me.LblDStop.AutoSize = True
        Me.LblDStop.Location = New System.Drawing.Point(294, 10)
        Me.LblDStop.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblDStop.Name = "LblDStop"
        Me.LblDStop.Size = New System.Drawing.Size(55, 13)
        Me.LblDStop.TabIndex = 57
        Me.LblDStop.Text = "DateStop:"
        Me.LblDStop.Visible = False
        '
        'LblDStart
        '
        Me.LblDStart.AutoSize = True
        Me.LblDStart.Location = New System.Drawing.Point(108, 10)
        Me.LblDStart.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblDStart.Name = "LblDStart"
        Me.LblDStart.Size = New System.Drawing.Size(55, 13)
        Me.LblDStart.TabIndex = 56
        Me.LblDStart.Text = "DateStart:"
        Me.LblDStart.Visible = False
        '
        'TabResultsA
        '
        Me.TabResultsA.Controls.Add(Me.LstResults)
        Me.TabResultsA.Image = Nothing
        Me.TabResultsA.ImageSize = New System.Drawing.Size(16, 16)
        Me.TabResultsA.Location = New System.Drawing.Point(1, 22)
        Me.TabResultsA.Name = "TabResultsA"
        Me.TabResultsA.ShowCloseButton = True
        Me.TabResultsA.Size = New System.Drawing.Size(581, 293)
        Me.TabResultsA.TabIndex = 2
        Me.TabResultsA.Text = "Results"
        Me.TabResultsA.ThemesEnabled = False
        '
        'LstResults
        '
        Me.LstResults.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LstResults.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.LstResults.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LstResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstResults.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LstResults.FormattingEnabled = True
        Me.LstResults.HorizontalScrollbar = True
        Me.errorProvider1.SetIconAlignment(Me.LstResults, System.Windows.Forms.ErrorIconAlignment.TopLeft)
        Me.LstResults.Location = New System.Drawing.Point(0, 0)
        Me.LstResults.Margin = New System.Windows.Forms.Padding(2)
        Me.LstResults.MultiColumn = True
        Me.LstResults.Name = "LstResults"
        Me.LstResults.ScrollAlwaysVisible = True
        Me.LstResults.Size = New System.Drawing.Size(581, 293)
        Me.LstResults.TabIndex = 1
        Me.LstResults.UseWaitCursor = True
        '
        'TabActionsA
        '
        Me.TabActionsA.Controls.Add(Me.Panel6)
        Me.TabActionsA.Controls.Add(Me.Panel4)
        Me.TabActionsA.Image = Nothing
        Me.TabActionsA.ImageSize = New System.Drawing.Size(16, 16)
        Me.TabActionsA.Location = New System.Drawing.Point(1, 22)
        Me.TabActionsA.Name = "TabActionsA"
        Me.TabActionsA.ShowCloseButton = True
        Me.TabActionsA.Size = New System.Drawing.Size(581, 293)
        Me.TabActionsA.TabIndex = 3
        Me.TabActionsA.Text = "Actions"
        Me.TabActionsA.ThemesEnabled = False
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.LblMoveNewNotice)
        Me.Panel6.Controls.Add(Me.TextBox1)
        Me.Panel6.Controls.Add(Me.Label5)
        Me.Panel6.Controls.Add(Me.BtnMoveDir)
        Me.Panel6.Controls.Add(Me.ChkMoveNew)
        Me.Panel6.Controls.Add(Me.ChkMove)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 170)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(581, 123)
        Me.Panel6.TabIndex = 42
        '
        'LblMoveNewNotice
        '
        Me.LblMoveNewNotice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblMoveNewNotice.AutoSize = True
        Me.LblMoveNewNotice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LblMoveNewNotice.Location = New System.Drawing.Point(270, 16)
        Me.LblMoveNewNotice.Name = "LblMoveNewNotice"
        Me.LblMoveNewNotice.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblMoveNewNotice.Size = New System.Drawing.Size(207, 13)
        Me.LblMoveNewNotice.TabIndex = 46
        Me.LblMoveNewNotice.Text = "Don't forget to complete the directory entry"
        Me.LblMoveNewNotice.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(122, 85)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(438, 20)
        Me.TextBox1.TabIndex = 45
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 13)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Move to Directory:"
        '
        'BtnMoveDir
        '
        Me.BtnMoveDir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMoveDir.Location = New System.Drawing.Point(495, 10)
        Me.BtnMoveDir.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnMoveDir.Name = "BtnMoveDir"
        Me.BtnMoveDir.Size = New System.Drawing.Size(64, 25)
        Me.BtnMoveDir.TabIndex = 43
        Me.BtnMoveDir.Text = "Select Dir"
        Me.BtnMoveDir.UseVisualStyleBackColor = True
        '
        'ChkMoveNew
        '
        Me.ChkMoveNew.AutoSize = True
        Me.ChkMoveNew.Location = New System.Drawing.Point(161, 15)
        Me.ChkMoveNew.Name = "ChkMoveNew"
        Me.ChkMoveNew.Size = New System.Drawing.Size(93, 17)
        Me.ChkMoveNew.TabIndex = 42
        Me.ChkMoveNew.Text = "New Directory"
        Me.ChkMoveNew.UseVisualStyleBackColor = True
        '
        'ChkMove
        '
        Me.ChkMove.AutoSize = True
        Me.ChkMove.Location = New System.Drawing.Point(21, 15)
        Me.ChkMove.Name = "ChkMove"
        Me.ChkMove.Size = New System.Drawing.Size(134, 17)
        Me.ChkMove.TabIndex = 41
        Me.ChkMove.Text = "Move Files to Directory"
        Me.ChkMove.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.TxtRenameChange)
        Me.Panel4.Controls.Add(Me.TxtRenameMatch)
        Me.Panel4.Controls.Add(Me.ChkRename)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(581, 100)
        Me.Panel4.TabIndex = 41
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 13)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Replacement String:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "String to Match:"
        '
        'TxtRenameChange
        '
        Me.TxtRenameChange.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtRenameChange.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtRenameChange.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TxtRenameChange.Location = New System.Drawing.Point(130, 71)
        Me.TxtRenameChange.Name = "TxtRenameChange"
        Me.TxtRenameChange.Size = New System.Drawing.Size(429, 20)
        Me.TxtRenameChange.TabIndex = 37
        '
        'TxtRenameMatch
        '
        Me.TxtRenameMatch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtRenameMatch.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtRenameMatch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TxtRenameMatch.Location = New System.Drawing.Point(130, 38)
        Me.TxtRenameMatch.Name = "TxtRenameMatch"
        Me.TxtRenameMatch.Size = New System.Drawing.Size(429, 20)
        Me.TxtRenameMatch.TabIndex = 36
        '
        'ChkRename
        '
        Me.ChkRename.AutoSize = True
        Me.ChkRename.Location = New System.Drawing.Point(21, 12)
        Me.ChkRename.Name = "ChkRename"
        Me.ChkRename.Size = New System.Drawing.Size(206, 17)
        Me.ChkRename.TabIndex = 35
        Me.ChkRename.Text = "Match String in Filename and Rename"
        Me.ChkRename.UseVisualStyleBackColor = True
        '
        'TabRegistryA
        '
        Me.TabRegistryA.Controls.Add(Me.BtnRegDiff2)
        Me.TabRegistryA.Controls.Add(Me.Label9)
        Me.TabRegistryA.Controls.Add(Me.TxtRegDiff2)
        Me.TabRegistryA.Controls.Add(Me.BtnDiff)
        Me.TabRegistryA.Controls.Add(Me.BtnRegDiff1)
        Me.TabRegistryA.Controls.Add(Me.Label8)
        Me.TabRegistryA.Controls.Add(Me.TxtRegDiff1)
        Me.TabRegistryA.Controls.Add(Me.GrpKeys)
        Me.TabRegistryA.Controls.Add(Me.BtnExportReg)
        Me.TabRegistryA.Controls.Add(Me.BtnRegDir)
        Me.TabRegistryA.Controls.Add(Me.Label7)
        Me.TabRegistryA.Controls.Add(Me.TxtRegPath)
        Me.TabRegistryA.Image = Nothing
        Me.TabRegistryA.ImageSize = New System.Drawing.Size(16, 16)
        Me.TabRegistryA.Location = New System.Drawing.Point(1, 22)
        Me.TabRegistryA.Name = "TabRegistryA"
        Me.TabRegistryA.ShowCloseButton = True
        Me.TabRegistryA.Size = New System.Drawing.Size(581, 293)
        Me.TabRegistryA.TabIndex = 4
        Me.TabRegistryA.Text = "Registry"
        Me.TabRegistryA.ThemesEnabled = False
        '
        'BtnRegDiff2
        '
        Me.BtnRegDiff2.Location = New System.Drawing.Point(388, 246)
        Me.BtnRegDiff2.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnRegDiff2.Name = "BtnRegDiff2"
        Me.BtnRegDiff2.Size = New System.Drawing.Size(64, 35)
        Me.BtnRegDiff2.TabIndex = 55
        Me.BtnRegDiff2.Text = "Select Reg File 1"
        Me.BtnRegDiff2.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(27, 239)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "Reg File 2:"
        '
        'TxtRegDiff2
        '
        Me.TxtRegDiff2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TxtRegDiff2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtRegDiff2.Location = New System.Drawing.Point(30, 254)
        Me.TxtRegDiff2.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtRegDiff2.Name = "TxtRegDiff2"
        Me.TxtRegDiff2.Size = New System.Drawing.Size(354, 20)
        Me.TxtRegDiff2.TabIndex = 53
        '
        'BtnDiff
        '
        Me.BtnDiff.Location = New System.Drawing.Point(464, 29)
        Me.BtnDiff.Name = "BtnDiff"
        Me.BtnDiff.Size = New System.Drawing.Size(86, 25)
        Me.BtnDiff.TabIndex = 52
        Me.BtnDiff.Text = "Reg Diff FIle"
        Me.BtnDiff.UseVisualStyleBackColor = True
        '
        'BtnRegDiff1
        '
        Me.BtnRegDiff1.Location = New System.Drawing.Point(388, 196)
        Me.BtnRegDiff1.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnRegDiff1.Name = "BtnRegDiff1"
        Me.BtnRegDiff1.Size = New System.Drawing.Size(64, 35)
        Me.BtnRegDiff1.TabIndex = 51
        Me.BtnRegDiff1.Text = "Select Reg File 1"
        Me.BtnRegDiff1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(27, 189)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Reg File 1:"
        '
        'TxtRegDiff1
        '
        Me.TxtRegDiff1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TxtRegDiff1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtRegDiff1.Location = New System.Drawing.Point(30, 204)
        Me.TxtRegDiff1.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtRegDiff1.Name = "TxtRegDiff1"
        Me.TxtRegDiff1.Size = New System.Drawing.Size(354, 20)
        Me.TxtRegDiff1.TabIndex = 49
        '
        'GrpKeys
        '
        Me.GrpKeys.Controls.Add(Me.ChkHKAll)
        Me.GrpKeys.Controls.Add(Me.ChkHKCC)
        Me.GrpKeys.Controls.Add(Me.ChkHKU)
        Me.GrpKeys.Controls.Add(Me.ChkHKCU)
        Me.GrpKeys.Controls.Add(Me.ChkHKLM)
        Me.GrpKeys.Controls.Add(Me.ChkHKCR)
        Me.GrpKeys.Location = New System.Drawing.Point(30, 10)
        Me.GrpKeys.Name = "GrpKeys"
        Me.GrpKeys.Size = New System.Drawing.Size(253, 100)
        Me.GrpKeys.TabIndex = 48
        Me.GrpKeys.TabStop = False
        Me.GrpKeys.Text = "Keys"
        '
        'ChkHKAll
        '
        Me.ChkHKAll.AutoSize = True
        Me.ChkHKAll.Location = New System.Drawing.Point(135, 68)
        Me.ChkHKAll.Name = "ChkHKAll"
        Me.ChkHKAll.Size = New System.Drawing.Size(37, 17)
        Me.ChkHKAll.TabIndex = 41
        Me.ChkHKAll.Text = "All"
        Me.ChkHKAll.UseVisualStyleBackColor = True
        '
        'ChkHKCC
        '
        Me.ChkHKCC.AutoSize = True
        Me.ChkHKCC.Location = New System.Drawing.Point(135, 42)
        Me.ChkHKCC.Name = "ChkHKCC"
        Me.ChkHKCC.Size = New System.Drawing.Size(111, 17)
        Me.ChkHKCC.TabIndex = 40
        Me.ChkHKCC.Text = "HKCurrent_Config"
        Me.ChkHKCC.UseVisualStyleBackColor = True
        '
        'ChkHKU
        '
        Me.ChkHKU.AutoSize = True
        Me.ChkHKU.Location = New System.Drawing.Point(135, 19)
        Me.ChkHKU.Name = "ChkHKU"
        Me.ChkHKU.Size = New System.Drawing.Size(68, 17)
        Me.ChkHKU.TabIndex = 39
        Me.ChkHKU.Text = "HKUsers"
        Me.ChkHKU.UseVisualStyleBackColor = True
        '
        'ChkHKCU
        '
        Me.ChkHKCU.AutoSize = True
        Me.ChkHKCU.Location = New System.Drawing.Point(15, 45)
        Me.ChkHKCU.Name = "ChkHKCU"
        Me.ChkHKCU.Size = New System.Drawing.Size(103, 17)
        Me.ChkHKCU.TabIndex = 38
        Me.ChkHKCU.Text = "HKCurrent_User"
        Me.ChkHKCU.UseVisualStyleBackColor = True
        '
        'ChkHKLM
        '
        Me.ChkHKLM.AutoSize = True
        Me.ChkHKLM.Location = New System.Drawing.Point(15, 68)
        Me.ChkHKLM.Name = "ChkHKLM"
        Me.ChkHKLM.Size = New System.Drawing.Size(114, 17)
        Me.ChkHKLM.TabIndex = 37
        Me.ChkHKLM.Text = "HKLocal_Machine"
        Me.ChkHKLM.UseVisualStyleBackColor = True
        '
        'ChkHKCR
        '
        Me.ChkHKCR.AutoSize = True
        Me.ChkHKCR.Location = New System.Drawing.Point(15, 19)
        Me.ChkHKCR.Name = "ChkHKCR"
        Me.ChkHKCR.Size = New System.Drawing.Size(106, 17)
        Me.ChkHKCR.TabIndex = 36
        Me.ChkHKCR.Text = "HKClasses_Root"
        Me.ChkHKCR.UseVisualStyleBackColor = True
        '
        'BtnExportReg
        '
        Me.BtnExportReg.Location = New System.Drawing.Point(464, 60)
        Me.BtnExportReg.Name = "BtnExportReg"
        Me.BtnExportReg.Size = New System.Drawing.Size(86, 25)
        Me.BtnExportReg.TabIndex = 47
        Me.BtnExportReg.Text = "Export Registry"
        Me.BtnExportReg.UseVisualStyleBackColor = True
        '
        'BtnRegDir
        '
        Me.BtnRegDir.Location = New System.Drawing.Point(388, 139)
        Me.BtnRegDir.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnRegDir.Name = "BtnRegDir"
        Me.BtnRegDir.Size = New System.Drawing.Size(64, 35)
        Me.BtnRegDir.TabIndex = 46
        Me.BtnRegDir.Text = "Select Save"
        Me.BtnRegDir.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(27, 132)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Save Location:"
        '
        'TxtRegPath
        '
        Me.TxtRegPath.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TxtRegPath.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtRegPath.Location = New System.Drawing.Point(30, 147)
        Me.TxtRegPath.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtRegPath.Name = "TxtRegPath"
        Me.TxtRegPath.Size = New System.Drawing.Size(354, 20)
        Me.TxtRegPath.TabIndex = 44
        Me.TxtRegPath.Text = "C:\test.reg"
        '
        'TabExternalA
        '
        Me.TabExternalA.Controls.Add(Me.BtnProcessMonitor)
        Me.TabExternalA.Image = Nothing
        Me.TabExternalA.ImageSize = New System.Drawing.Size(16, 16)
        Me.TabExternalA.Location = New System.Drawing.Point(1, 22)
        Me.TabExternalA.Name = "TabExternalA"
        Me.TabExternalA.ShowCloseButton = True
        Me.TabExternalA.Size = New System.Drawing.Size(581, 293)
        Me.TabExternalA.TabIndex = 5
        Me.TabExternalA.Text = "External Apps"
        Me.TabExternalA.ThemesEnabled = False
        '
        'BtnProcessMonitor
        '
        Me.BtnProcessMonitor.Location = New System.Drawing.Point(11, 14)
        Me.BtnProcessMonitor.Name = "BtnProcessMonitor"
        Me.BtnProcessMonitor.Size = New System.Drawing.Size(107, 23)
        Me.BtnProcessMonitor.TabIndex = 1
        Me.BtnProcessMonitor.Text = "Process Monitor"
        Me.BtnProcessMonitor.UseVisualStyleBackColor = True
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(584, 317)
        Me.Controls.Add(Me.TabControlA)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FileSearchX"
        CType(Me.errorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CMLstResult.ResumeLayout(False)
        CType(Me.TabControlA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlA.ResumeLayout(False)
        Me.TabSearchA.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GboxSearchOp.ResumeLayout(False)
        Me.GboxSearchOp.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabResultsA.ResumeLayout(False)
        Me.TabActionsA.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.TabRegistryA.ResumeLayout(False)
        Me.TabRegistryA.PerformLayout()
        Me.GrpKeys.ResumeLayout(False)
        Me.GrpKeys.PerformLayout()
        Me.TabExternalA.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DirectorySearcher1 As DirectorySearcher
    Friend WithEvents errorProvider1 As ErrorProvider
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents CMLstResult As ContextMenuStrip
    Friend WithEvents MoveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RenameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControlA As Syncfusion.Windows.Forms.Tools.TabControlAdv
    Friend WithEvents TabSearchA As Syncfusion.Windows.Forms.Tools.TabPageAdv
    Friend WithEvents TabResultsA As Syncfusion.Windows.Forms.Tools.TabPageAdv
    Friend WithEvents LstResults As ListBox
    Friend WithEvents TabActionsA As Syncfusion.Windows.Forms.Tools.TabPageAdv
    Friend WithEvents TabRegistryA As Syncfusion.Windows.Forms.Tools.TabPageAdv
    Friend WithEvents BtnRegDiff2 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtRegDiff2 As TextBox
    Friend WithEvents BtnDiff As Button
    Friend WithEvents BtnRegDiff1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtRegDiff1 As TextBox
    Friend WithEvents GrpKeys As GroupBox
    Friend WithEvents ChkHKAll As CheckBox
    Friend WithEvents ChkHKCC As CheckBox
    Friend WithEvents ChkHKU As CheckBox
    Friend WithEvents ChkHKCU As CheckBox
    Friend WithEvents ChkHKLM As CheckBox
    Friend WithEvents ChkHKCR As CheckBox
    Friend WithEvents BtnExportReg As Button
    Friend WithEvents BtnRegDir As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtRegPath As TextBox
    Friend WithEvents TabExternalA As Syncfusion.Windows.Forms.Tools.TabPageAdv
    Friend WithEvents BtnProcessMonitor As Button
    Friend WithEvents FolderBrowser1 As Syncfusion.Windows.Forms.FolderBrowser
    Friend WithEvents SfToolTip1 As Syncfusion.WinForms.Controls.SfToolTip
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ChkAnyExt As CheckBox
    Friend WithEvents MTxtExt As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtFileContent As TextBox
    Friend WithEvents LblExt As Label
    Friend WithEvents LblFileName As Label
    Friend WithEvents TxtFileName As TextBox
    Friend WithEvents TxtAnyExt As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnSearch As Button
    Friend WithEvents BtnDirSelect As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtSearchPath As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ChkUseDate As CheckBox
    Friend WithEvents DTStop As DateTimePicker
    Friend WithEvents DTStart As DateTimePicker
    Friend WithEvents LblDStop As Label
    Friend WithEvents LblDStart As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents LblMoveNewNotice As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnMoveDir As Button
    Friend WithEvents ChkMoveNew As CheckBox
    Friend WithEvents ChkMove As CheckBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtRenameChange As TextBox
    Friend WithEvents TxtRenameMatch As TextBox
    Friend WithEvents ChkRename As CheckBox
    Friend WithEvents GboxSearchOp As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CmbFileFolder As ComboBox
    Friend WithEvents ChkSub As CheckBox
    Friend WithEvents ChkClrPrev As CheckBox
    Friend WithEvents filebrowser1 As Syncfusion.Windows.Forms.FolderBrowser
End Class
