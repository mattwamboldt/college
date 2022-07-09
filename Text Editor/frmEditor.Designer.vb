<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditor))
        Me.mnsMain = New System.Windows.Forms.MenuStrip()
        Me.tmiFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.fmiNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.fmiOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.fmiSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.fmiSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.fmiPrintPreview = New System.Windows.Forms.ToolStripMenuItem()
        Me.fmiPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.fmiPageSetup = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.fmiExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmiEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.emiUndo = New System.Windows.Forms.ToolStripMenuItem()
        Me.emiRedo = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.emiCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.emiCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.emiPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.emiDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.emiSelectAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnselectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.emiFont = New System.Windows.Forms.ToolStripMenuItem()
        Me.emiColour = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmiHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.hmiAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.rtxtData = New System.Windows.Forms.RichTextBox()
        Me.cmsTextEdit = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsUndo = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsRedo = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmsCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsBold = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsItalic = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsUnderline = New System.Windows.Forms.ToolStripMenuItem()
        Me.dlgColour = New System.Windows.Forms.ColorDialog()
        Me.dlgOpen = New System.Windows.Forms.OpenFileDialog()
        Me.dlgSave = New System.Windows.Forms.SaveFileDialog()
        Me.dlgFont = New System.Windows.Forms.FontDialog()
        Me.dlgPrint = New System.Windows.Forms.PrintDialog()
        Me.prntDoc = New System.Drawing.Printing.PrintDocument()
        Me.dlgPrintPreview = New System.Windows.Forms.PrintPreviewDialog()
        Me.dlgPageSetup = New System.Windows.Forms.PageSetupDialog()
        Me.tsMenu = New System.Windows.Forms.ToolStrip()
        Me.tmNew = New System.Windows.Forms.ToolStripButton()
        Me.tmOpen = New System.Windows.Forms.ToolStripButton()
        Me.tmSave = New System.Windows.Forms.ToolStripButton()
        Me.tmPrint = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.tmCut = New System.Windows.Forms.ToolStripButton()
        Me.tmCopy = New System.Windows.Forms.ToolStripButton()
        Me.tmPaste = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tmBold = New System.Windows.Forms.ToolStripButton()
        Me.tmItalic = New System.Windows.Forms.ToolStripButton()
        Me.tmUnderline = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tmAbout = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ssMain = New System.Windows.Forms.StatusStrip()
        Me.ssSelection = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ssDateTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tDate = New System.Windows.Forms.Timer(Me.components)
        Me.mnsMain.SuspendLayout()
        Me.cmsTextEdit.SuspendLayout()
        Me.tsMenu.SuspendLayout()
        Me.ssMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnsMain
        '
        Me.mnsMain.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.mnsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tmiFile, Me.tmiEdit, Me.tmiHelp})
        Me.mnsMain.Location = New System.Drawing.Point(0, 0)
        Me.mnsMain.Name = "mnsMain"
        Me.mnsMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.mnsMain.Size = New System.Drawing.Size(792, 24)
        Me.mnsMain.TabIndex = 0
        Me.mnsMain.Text = "MenuStrip1"
        '
        'tmiFile
        '
        Me.tmiFile.BackColor = System.Drawing.SystemColors.Control
        Me.tmiFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tmiFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fmiNew, Me.fmiOpen, Me.fmiSave, Me.fmiSaveAs, Me.ToolStripSeparator1, Me.fmiPrintPreview, Me.fmiPrint, Me.fmiPageSetup, Me.ToolStripSeparator2, Me.fmiExit})
        Me.tmiFile.Name = "tmiFile"
        Me.tmiFile.Size = New System.Drawing.Size(37, 20)
        Me.tmiFile.Text = "&File"
        '
        'fmiNew
        '
        Me.fmiNew.Name = "fmiNew"
        Me.fmiNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.fmiNew.Size = New System.Drawing.Size(195, 22)
        Me.fmiNew.Text = "&New"
        '
        'fmiOpen
        '
        Me.fmiOpen.Name = "fmiOpen"
        Me.fmiOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.fmiOpen.Size = New System.Drawing.Size(195, 22)
        Me.fmiOpen.Text = "&Open..."
        '
        'fmiSave
        '
        Me.fmiSave.Enabled = False
        Me.fmiSave.Name = "fmiSave"
        Me.fmiSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.fmiSave.Size = New System.Drawing.Size(195, 22)
        Me.fmiSave.Text = "&Save"
        '
        'fmiSaveAs
        '
        Me.fmiSaveAs.Enabled = False
        Me.fmiSaveAs.Name = "fmiSaveAs"
        Me.fmiSaveAs.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.fmiSaveAs.Size = New System.Drawing.Size(195, 22)
        Me.fmiSaveAs.Text = "Save &As..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(192, 6)
        '
        'fmiPrintPreview
        '
        Me.fmiPrintPreview.Enabled = False
        Me.fmiPrintPreview.Name = "fmiPrintPreview"
        Me.fmiPrintPreview.Size = New System.Drawing.Size(195, 22)
        Me.fmiPrintPreview.Text = "Print Pre&view"
        '
        'fmiPrint
        '
        Me.fmiPrint.Enabled = False
        Me.fmiPrint.Name = "fmiPrint"
        Me.fmiPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.fmiPrint.Size = New System.Drawing.Size(195, 22)
        Me.fmiPrint.Text = "&Print"
        '
        'fmiPageSetup
        '
        Me.fmiPageSetup.Enabled = False
        Me.fmiPageSetup.Name = "fmiPageSetup"
        Me.fmiPageSetup.Size = New System.Drawing.Size(195, 22)
        Me.fmiPageSetup.Text = "Page Setup"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(192, 6)
        '
        'fmiExit
        '
        Me.fmiExit.Name = "fmiExit"
        Me.fmiExit.Size = New System.Drawing.Size(195, 22)
        Me.fmiExit.Text = "E&xit"
        '
        'tmiEdit
        '
        Me.tmiEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tmiEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.emiUndo, Me.emiRedo, Me.ToolStripSeparator7, Me.emiCut, Me.emiCopy, Me.emiPaste, Me.emiDelete, Me.ToolStripSeparator8, Me.emiSelectAll, Me.UnselectToolStripMenuItem, Me.ToolStripSeparator9, Me.emiFont, Me.emiColour})
        Me.tmiEdit.Enabled = False
        Me.tmiEdit.Name = "tmiEdit"
        Me.tmiEdit.Size = New System.Drawing.Size(39, 20)
        Me.tmiEdit.Text = "&Edit"
        Me.tmiEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'emiUndo
        '
        Me.emiUndo.Name = "emiUndo"
        Me.emiUndo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.emiUndo.Size = New System.Drawing.Size(193, 22)
        Me.emiUndo.Text = "&Undo"
        '
        'emiRedo
        '
        Me.emiRedo.Name = "emiRedo"
        Me.emiRedo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.emiRedo.Size = New System.Drawing.Size(193, 22)
        Me.emiRedo.Text = "&Redo"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(190, 6)
        '
        'emiCut
        '
        Me.emiCut.Name = "emiCut"
        Me.emiCut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.emiCut.Size = New System.Drawing.Size(193, 22)
        Me.emiCut.Text = "Cu&t"
        '
        'emiCopy
        '
        Me.emiCopy.Name = "emiCopy"
        Me.emiCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.emiCopy.Size = New System.Drawing.Size(193, 22)
        Me.emiCopy.Text = "&Copy"
        '
        'emiPaste
        '
        Me.emiPaste.Name = "emiPaste"
        Me.emiPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.emiPaste.Size = New System.Drawing.Size(193, 22)
        Me.emiPaste.Text = "&Paste"
        '
        'emiDelete
        '
        Me.emiDelete.Name = "emiDelete"
        Me.emiDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.emiDelete.Size = New System.Drawing.Size(193, 22)
        Me.emiDelete.Text = "&Delete"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(190, 6)
        '
        'emiSelectAll
        '
        Me.emiSelectAll.Name = "emiSelectAll"
        Me.emiSelectAll.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.emiSelectAll.Size = New System.Drawing.Size(193, 22)
        Me.emiSelectAll.Text = "Select &All"
        '
        'UnselectToolStripMenuItem
        '
        Me.UnselectToolStripMenuItem.Name = "UnselectToolStripMenuItem"
        Me.UnselectToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.UnselectToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.UnselectToolStripMenuItem.Text = "Un&select"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(190, 6)
        '
        'emiFont
        '
        Me.emiFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.emiFont.Name = "emiFont"
        Me.emiFont.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.emiFont.Size = New System.Drawing.Size(193, 22)
        Me.emiFont.Text = "&Font..."
        '
        'emiColour
        '
        Me.emiColour.Name = "emiColour"
        Me.emiColour.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.emiColour.Size = New System.Drawing.Size(193, 22)
        Me.emiColour.Text = "Co&lour..."
        '
        'tmiHelp
        '
        Me.tmiHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.hmiAbout})
        Me.tmiHelp.Name = "tmiHelp"
        Me.tmiHelp.Size = New System.Drawing.Size(44, 20)
        Me.tmiHelp.Text = "&Help"
        '
        'hmiAbout
        '
        Me.hmiAbout.Name = "hmiAbout"
        Me.hmiAbout.Size = New System.Drawing.Size(107, 22)
        Me.hmiAbout.Text = "&About"
        '
        'rtxtData
        '
        Me.rtxtData.AcceptsTab = True
        Me.rtxtData.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.rtxtData.ContextMenuStrip = Me.cmsTextEdit
        Me.rtxtData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtxtData.EnableAutoDragDrop = True
        Me.rtxtData.Enabled = False
        Me.rtxtData.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxtData.Location = New System.Drawing.Point(0, 49)
        Me.rtxtData.Name = "rtxtData"
        Me.rtxtData.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.rtxtData.ShowSelectionMargin = True
        Me.rtxtData.Size = New System.Drawing.Size(792, 502)
        Me.rtxtData.TabIndex = 1
        Me.rtxtData.Text = ""
        '
        'cmsTextEdit
        '
        Me.cmsTextEdit.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsUndo, Me.cmsRedo, Me.ToolStripSeparator6, Me.cmsCut, Me.cmsCopy, Me.cmsPaste, Me.cmsDelete, Me.cmsBold, Me.cmsItalic, Me.cmsUnderline})
        Me.cmsTextEdit.Name = "cmsTextEdit"
        Me.cmsTextEdit.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.cmsTextEdit.ShowItemToolTips = False
        Me.cmsTextEdit.Size = New System.Drawing.Size(110, 208)
        '
        'cmsUndo
        '
        Me.cmsUndo.Name = "cmsUndo"
        Me.cmsUndo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.cmsUndo.ShowShortcutKeys = False
        Me.cmsUndo.Size = New System.Drawing.Size(109, 22)
        Me.cmsUndo.Text = "&Undo"
        '
        'cmsRedo
        '
        Me.cmsRedo.Name = "cmsRedo"
        Me.cmsRedo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.cmsRedo.ShowShortcutKeys = False
        Me.cmsRedo.Size = New System.Drawing.Size(109, 22)
        Me.cmsRedo.Text = "&Redo"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(106, 6)
        '
        'cmsCut
        '
        Me.cmsCut.Name = "cmsCut"
        Me.cmsCut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.cmsCut.ShowShortcutKeys = False
        Me.cmsCut.Size = New System.Drawing.Size(109, 22)
        Me.cmsCut.Text = "Cu&t"
        '
        'cmsCopy
        '
        Me.cmsCopy.Name = "cmsCopy"
        Me.cmsCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.cmsCopy.ShowShortcutKeys = False
        Me.cmsCopy.Size = New System.Drawing.Size(109, 22)
        Me.cmsCopy.Text = "&Copy"
        '
        'cmsPaste
        '
        Me.cmsPaste.Name = "cmsPaste"
        Me.cmsPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.cmsPaste.ShowShortcutKeys = False
        Me.cmsPaste.Size = New System.Drawing.Size(109, 22)
        Me.cmsPaste.Text = "&Paste"
        '
        'cmsDelete
        '
        Me.cmsDelete.Name = "cmsDelete"
        Me.cmsDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.cmsDelete.ShowShortcutKeys = False
        Me.cmsDelete.Size = New System.Drawing.Size(109, 22)
        Me.cmsDelete.Text = "&Delete"
        '
        'cmsBold
        '
        Me.cmsBold.Name = "cmsBold"
        Me.cmsBold.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.cmsBold.Size = New System.Drawing.Size(109, 22)
        Me.cmsBold.Visible = False
        '
        'cmsItalic
        '
        Me.cmsItalic.Name = "cmsItalic"
        Me.cmsItalic.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.cmsItalic.Size = New System.Drawing.Size(109, 22)
        Me.cmsItalic.Visible = False
        '
        'cmsUnderline
        '
        Me.cmsUnderline.Name = "cmsUnderline"
        Me.cmsUnderline.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.cmsUnderline.Size = New System.Drawing.Size(109, 22)
        Me.cmsUnderline.Visible = False
        '
        'dlgColour
        '
        Me.dlgColour.AnyColor = True
        Me.dlgColour.FullOpen = True
        '
        'dlgOpen
        '
        Me.dlgOpen.DefaultExt = "rtf"
        Me.dlgOpen.Filter = "Hero's Text (.htxt)|*.htxt|Rich Text(.rtf)|*.rtf|Plain Text(.txt)|*.txt|All files" &
    "|*.*"
        Me.dlgOpen.Title = "Open"
        '
        'dlgSave
        '
        Me.dlgSave.DefaultExt = "htxt"
        Me.dlgSave.FileName = "Untitled1.htxt"
        Me.dlgSave.Filter = "Hero's Text (.htxt)|*.htxt|Rich Text(.rtf)|*.rtf|Plain Text(.txt)|*.txt"
        Me.dlgSave.Title = "Save As..."
        '
        'dlgFont
        '
        Me.dlgFont.AllowVerticalFonts = False
        Me.dlgFont.FontMustExist = True
        Me.dlgFont.ShowApply = True
        '
        'dlgPrint
        '
        Me.dlgPrint.AllowCurrentPage = True
        Me.dlgPrint.AllowSelection = True
        Me.dlgPrint.AllowSomePages = True
        Me.dlgPrint.Document = Me.prntDoc
        Me.dlgPrint.UseEXDialog = True
        '
        'prntDoc
        '
        Me.prntDoc.DocumentName = ""
        '
        'dlgPrintPreview
        '
        Me.dlgPrintPreview.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.dlgPrintPreview.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.dlgPrintPreview.ClientSize = New System.Drawing.Size(400, 300)
        Me.dlgPrintPreview.Document = Me.prntDoc
        Me.dlgPrintPreview.Enabled = True
        Me.dlgPrintPreview.Icon = CType(resources.GetObject("dlgPrintPreview.Icon"), System.Drawing.Icon)
        Me.dlgPrintPreview.Name = "dlgPrintPreview"
        Me.dlgPrintPreview.UseAntiAlias = True
        Me.dlgPrintPreview.Visible = False
        '
        'dlgPageSetup
        '
        Me.dlgPageSetup.Document = Me.prntDoc
        Me.dlgPageSetup.EnableMetric = True
        '
        'tsMenu
        '
        Me.tsMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tmNew, Me.tmOpen, Me.tmSave, Me.tmPrint, Me.toolStripSeparator, Me.tmCut, Me.tmCopy, Me.tmPaste, Me.toolStripSeparator3, Me.tmBold, Me.tmItalic, Me.tmUnderline, Me.ToolStripSeparator5, Me.tmAbout, Me.ToolStripSeparator4})
        Me.tsMenu.Location = New System.Drawing.Point(0, 24)
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsMenu.Size = New System.Drawing.Size(792, 25)
        Me.tsMenu.Stretch = True
        Me.tsMenu.TabIndex = 3
        '
        'tmNew
        '
        Me.tmNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tmNew.Image = Global.TextEditor.My.Resources.Resources.icons8_add_file_32
        Me.tmNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tmNew.Name = "tmNew"
        Me.tmNew.Size = New System.Drawing.Size(23, 22)
        Me.tmNew.Text = "&New"
        '
        'tmOpen
        '
        Me.tmOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tmOpen.Image = Global.TextEditor.My.Resources.Resources.icons8_folder_24
        Me.tmOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tmOpen.Name = "tmOpen"
        Me.tmOpen.Size = New System.Drawing.Size(23, 22)
        Me.tmOpen.Text = "&Open"
        '
        'tmSave
        '
        Me.tmSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tmSave.Enabled = False
        Me.tmSave.Image = Global.TextEditor.My.Resources.Resources.icons8_save_32
        Me.tmSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tmSave.Name = "tmSave"
        Me.tmSave.Size = New System.Drawing.Size(23, 22)
        Me.tmSave.Text = "&Save"
        '
        'tmPrint
        '
        Me.tmPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tmPrint.Enabled = False
        Me.tmPrint.Image = Global.TextEditor.My.Resources.Resources.icons8_printer_32
        Me.tmPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tmPrint.Name = "tmPrint"
        Me.tmPrint.Size = New System.Drawing.Size(23, 22)
        Me.tmPrint.Text = "&Print"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'tmCut
        '
        Me.tmCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tmCut.Enabled = False
        Me.tmCut.Image = Global.TextEditor.My.Resources.Resources.icons8_cut_30
        Me.tmCut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tmCut.Name = "tmCut"
        Me.tmCut.Size = New System.Drawing.Size(23, 22)
        Me.tmCut.Text = "C&ut"
        '
        'tmCopy
        '
        Me.tmCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tmCopy.Enabled = False
        Me.tmCopy.Image = Global.TextEditor.My.Resources.Resources.icons8_copy_32
        Me.tmCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tmCopy.Name = "tmCopy"
        Me.tmCopy.Size = New System.Drawing.Size(23, 22)
        Me.tmCopy.Text = "&Copy"
        '
        'tmPaste
        '
        Me.tmPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tmPaste.Enabled = False
        Me.tmPaste.Image = Global.TextEditor.My.Resources.Resources.icons8_paste_32
        Me.tmPaste.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tmPaste.Name = "tmPaste"
        Me.tmPaste.Size = New System.Drawing.Size(23, 22)
        Me.tmPaste.Text = "&Paste"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'tmBold
        '
        Me.tmBold.CheckOnClick = True
        Me.tmBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tmBold.Enabled = False
        Me.tmBold.Image = Global.TextEditor.My.Resources.Resources.icons8_bold_50
        Me.tmBold.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tmBold.Name = "tmBold"
        Me.tmBold.Size = New System.Drawing.Size(23, 22)
        Me.tmBold.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'tmItalic
        '
        Me.tmItalic.CheckOnClick = True
        Me.tmItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tmItalic.Enabled = False
        Me.tmItalic.Image = Global.TextEditor.My.Resources.Resources.icons8_italic_24
        Me.tmItalic.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tmItalic.Name = "tmItalic"
        Me.tmItalic.Size = New System.Drawing.Size(23, 22)
        Me.tmItalic.Text = "ToolStripButton3"
        '
        'tmUnderline
        '
        Me.tmUnderline.CheckOnClick = True
        Me.tmUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tmUnderline.Enabled = False
        Me.tmUnderline.Image = Global.TextEditor.My.Resources.Resources.icons8_underline_50
        Me.tmUnderline.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tmUnderline.Name = "tmUnderline"
        Me.tmUnderline.Size = New System.Drawing.Size(23, 22)
        Me.tmUnderline.Text = "ToolStripButton2"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'tmAbout
        '
        Me.tmAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tmAbout.Image = Global.TextEditor.My.Resources.Resources.icons8_help_24
        Me.tmAbout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tmAbout.Name = "tmAbout"
        Me.tmAbout.Size = New System.Drawing.Size(23, 22)
        Me.tmAbout.Text = "He&lp"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ssMain
        '
        Me.ssMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.ssMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ssSelection, Me.ssDateTime})
        Me.ssMain.Location = New System.Drawing.Point(0, 551)
        Me.ssMain.Name = "ssMain"
        Me.ssMain.Size = New System.Drawing.Size(792, 22)
        Me.ssMain.TabIndex = 5
        '
        'ssSelection
        '
        Me.ssSelection.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ssSelection.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.ssSelection.Name = "ssSelection"
        Me.ssSelection.Size = New System.Drawing.Size(388, 17)
        Me.ssSelection.Spring = True
        Me.ssSelection.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ssDateTime
        '
        Me.ssDateTime.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ssDateTime.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.ssDateTime.Name = "ssDateTime"
        Me.ssDateTime.Size = New System.Drawing.Size(388, 17)
        Me.ssDateTime.Spring = True
        Me.ssDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tDate
        '
        Me.tDate.Interval = 1000
        '
        'frmEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(792, 573)
        Me.Controls.Add(Me.rtxtData)
        Me.Controls.Add(Me.ssMain)
        Me.Controls.Add(Me.tsMenu)
        Me.Controls.Add(Me.mnsMain)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mnsMain
        Me.Name = "frmEditor"
        Me.Text = "Heroless Text Editor"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mnsMain.ResumeLayout(False)
        Me.mnsMain.PerformLayout()
        Me.cmsTextEdit.ResumeLayout(False)
        Me.tsMenu.ResumeLayout(False)
        Me.tsMenu.PerformLayout()
        Me.ssMain.ResumeLayout(False)
        Me.ssMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnsMain As System.Windows.Forms.MenuStrip
    Friend WithEvents tmiFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents fmiNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents fmiOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents fmiSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents fmiSaveAs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmiEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmiHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents fmiPrintPreview As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents fmiPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents fmiExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents emiFont As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents emiColour As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rtxtData As System.Windows.Forms.RichTextBox
    Friend WithEvents dlgColour As System.Windows.Forms.ColorDialog
    Friend WithEvents dlgOpen As System.Windows.Forms.OpenFileDialog
    Friend WithEvents dlgSave As System.Windows.Forms.SaveFileDialog
    Friend WithEvents dlgFont As System.Windows.Forms.FontDialog
    Friend WithEvents dlgPrint As System.Windows.Forms.PrintDialog
    Friend WithEvents prntDoc As System.Drawing.Printing.PrintDocument
    Friend WithEvents dlgPrintPreview As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents fmiPageSetup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dlgPageSetup As System.Windows.Forms.PageSetupDialog
    Friend WithEvents hmiAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents tmNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents tmOpen As System.Windows.Forms.ToolStripButton
    Friend WithEvents tmSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents tmPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tmCut As System.Windows.Forms.ToolStripButton
    Friend WithEvents tmCopy As System.Windows.Forms.ToolStripButton
    Friend WithEvents tmPaste As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tmAbout As System.Windows.Forms.ToolStripButton
    Friend WithEvents tmBold As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tmItalic As System.Windows.Forms.ToolStripButton
    Friend WithEvents tmUnderline As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmsTextEdit As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmsCut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsPaste As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsUndo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsRedo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmsDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents emiUndo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents emiRedo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents emiCut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents emiCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents emiPaste As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents emiDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents emiSelectAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UnselectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ssMain As System.Windows.Forms.StatusStrip
    Friend WithEvents ssSelection As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ssDateTime As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tDate As System.Windows.Forms.Timer
    Friend WithEvents cmsBold As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsItalic As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsUnderline As System.Windows.Forms.ToolStripMenuItem

End Class
