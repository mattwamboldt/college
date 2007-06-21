Imports System.Windows.Forms
Imports System.Drawing

Public Class frmEditor
    Dim isDirty As Boolean
    Dim currentFile As String
    Dim compareExtension As String

    '================Enables Form Components===============
    Private Sub ActivateForm()
        rtxtData.Enabled = True
        tmBold.Enabled = True
        tmCopy.Enabled = True
        tmCut.Enabled = True
        tmiEdit.Enabled = True
        tmItalic.Enabled = True
        tmPaste.Enabled = True
        tmUnderline.Enabled = True
        fmiSaveAs.Enabled = True
        rtxtData.Focus()
        ssSelection.Text = "Line 1, Character 0"
        ssDateTime.Text = CStr(System.DateTime.Now)
        tDate.Enabled = True

    End Sub
    '========================================================

    '==================Closes Form===========================
    Private Sub CloseEditor(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fmiExit.Click
        If isDirty = True Then
            DisplayMessage()
        End If
        Close()
    End Sub
    '========================================================

    '==================Changes Font==========================
    Private Sub emiFont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles emiFont.Click, dlgFont.Apply
        If sender.Equals(emiFont) Then
            dlgFont.ShowDialog()
            rtxtData.SelectionFont() = dlgFont.Font()
        ElseIf sender.Equals(dlgFont) Then
            rtxtData.SelectionFont() = dlgFont.Font()
        End If
    End Sub
    '==========================================================

    '==================Changes Colour==========================
    Private Sub ChangeColour(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles emiColour.Click
        'changes colour
        rtxtData.SelectionColor() = dlgColour.Color()
    End Sub
    '===========================================================

    ''=================Printing functions========================
    Private Sub PreviewPrint(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fmiPrintPreview.Click
        dlgPrintPreview.ShowDialog()

    End Sub

    Private Sub BeginPrinting(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fmiPrint.Click, tmPrint.Click
        Dim printRes As DialogResult = dlgPrint.ShowDialog()
        If printRes <> Windows.Forms.DialogResult.Cancel Then
            prntDoc.Print()
        End If
    End Sub

    Private Sub PageSetup(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fmiPageSetup.Click
        dlgPageSetup.ShowDialog()
        prntDoc.DefaultPageSettings = dlgPageSetup.PageSettings()
    End Sub

    Private Sub prntDoc_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles prntDoc.PrintPage
    End Sub

    '=============================================================

    '================changes buttons based on style===============

    Private Sub rtxtData_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rtxtData.SelectionChanged
        If rtxtData.SelectionLength = 0 Then
            ssSelection.Text = "Line " + CStr(rtxtData.GetLineFromCharIndex(rtxtData.SelectionStart) + 1) + ", Character " + CStr(rtxtData.SelectionStart)
            singleSelect()
        Else
            ssSelection.Text = "Selection Start: Line " + CStr(rtxtData.GetLineFromCharIndex(rtxtData.SelectionStart) + 1) + ", Character " + CStr(rtxtData.SelectionStart) + " " + "Selection End: Line " + CStr(rtxtData.GetLineFromCharIndex(rtxtData.SelectionStart + rtxtData.SelectionLength) + 1) + ", Character " + CStr(rtxtData.SelectionStart + rtxtData.SelectionLength)
            tmBold.Checked = CheckStyle(rtxtData.SelectedRtf, FontStyle.Bold)
            tmItalic.Checked = CheckStyle(rtxtData.SelectedRtf, FontStyle.Italic)
            tmUnderline.Checked = CheckStyle(rtxtData.SelectedRtf, FontStyle.Underline)
        End If
    End Sub
    '========================================================

    '===========Controls save need===========================
    Private Sub rtxtData_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rtxtData.TextChanged
        isDirty = True
        ssSelection.Text = "Line " + CStr(rtxtData.GetLineFromCharIndex(rtxtData.SelectionStart) + 1) + ", Character " + CStr(rtxtData.SelectionStart)
        tmPrint.Enabled = True
        fmiPageSetup.Enabled = True
        fmiPrint.Enabled = True
        fmiPrintPreview.Enabled = True
        tmSave.Enabled = True
        If currentFile <> "" Then
            fmiSave.Enabled = True
        End If
    End Sub
    '========================================================

    '=============Opens a file===========
    Private Sub LoadData()
        compareExtension = currentFile.ToLower()
        If compareExtension.EndsWith("rtf") Or compareExtension.EndsWith("htxt") Then
            rtxtData.LoadFile(currentFile, RichTextBoxStreamType.RichText)
        Else
            rtxtData.LoadFile(currentFile, RichTextBoxStreamType.PlainText)
        End If
        tmSave.Enabled = False
        fmiSave.Enabled = False
        isDirty = False
        Me.Text = "Heroless Text Editor - " + currentFile
    End Sub

    Private Sub OpenFile(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fmiOpen.Click, tmOpen.Click
        dlgOpen.ShowDialog()
        currentFile = dlgOpen.FileName
        If currentFile <> "" And rtxtData.Enabled = False Then
            ActivateForm()
            LoadData()
        ElseIf currentFile <> "" Then
            LoadData()
        End If
        

    End Sub
    '===================================

    '===========Saves File==============
    Private Sub SaveData(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fmiSave.Click, fmiSaveAs.Click, tmSave.Click
        If currentFile = "" Or sender.Equals(fmiSaveAs) Then
            dlgSave.ShowDialog()
            currentFile = dlgSave.FileName
        End If
        If currentFile <> "" Then
            compareExtension = currentFile.ToLower()
            If compareExtension.EndsWith("rtf") Or compareExtension.EndsWith("htxt") Then
                rtxtData.SaveFile(currentFile, RichTextBoxStreamType.RichText)
            Else
                rtxtData.SaveFile(currentFile, RichTextBoxStreamType.PlainText)
            End If
            tmSave.Enabled = False
            fmiSave.Enabled = False
            Me.Text = "Heroless Text Editor - " + currentFile
        End If

    End Sub
    '=================================

    '============Opens About==========
    Private Sub AboutOpen(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hmiAbout.Click, tmAbout.Click
        frmAbout.Show()
    End Sub
    '=================================

    '===============Changes the font styles with buttons========
    Private Sub FontStyleChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmBold.Click, tmUnderline.Click, tmItalic.Click, cmsBold.Click, cmsUnderline.Click, cmsItalic.Click
        Dim sLength As Integer = rtxtData.SelectionLength
        Dim sStart As Integer = rtxtData.SelectionStart
	Dim currentFont As System.Drawing.Font = rtxtData.SelectionFont
	Dim currentStyle As System.Drawing.FontStyle = currentFont.Style

        With sender
            If .Equals(tmBold) Or .Equals(cmsBold) Then
                If sLength = 0 Then
                    currentStyle = currentStyle Xor FontStyle.Bold
                    rtxtData.SelectionFont = New Font(currentFont.FontFamily, currentFont.Size, currentStyle)
                Else
                    rtxtData.SelectedRtf = ChangeStyle(rtxtData.SelectedRtf, FontStyle.Bold, CheckStyle(rtxtData.SelectedRtf, FontStyle.Bold))
                End If
            ElseIf .Equals(tmUnderline) Or .Equals(cmsUnderline) Then
                If sLength = 0 Then
                    currentStyle = currentStyle Xor FontStyle.Underline
                    rtxtData.SelectionFont = New Font(currentFont.FontFamily, currentFont.Size, currentStyle)
                Else
                    rtxtData.SelectedRtf = ChangeStyle(rtxtData.SelectedRtf, FontStyle.Underline, CheckStyle(rtxtData.SelectedRtf, FontStyle.Underline))
                End If
            ElseIf .Equals(tmItalic) Or .Equals(cmsItalic) Then
                If sLength = 0 Then
                    currentStyle = currentStyle Xor FontStyle.Italic
                    rtxtData.SelectionFont = New Font(currentFont.FontFamily, currentFont.Size, currentStyle)
                Else
                    rtxtData.SelectedRtf = ChangeStyle(rtxtData.SelectedRtf, FontStyle.Italic, CheckStyle(rtxtData.SelectedRtf, FontStyle.Italic))
                End If
            End If
        End With
        singleSelect()
        rtxtData.Select(sStart, sLength)
    End Sub
    '============================================================

    '=====online function modified to change font styles=====
    Private Function ChangeStyle(ByVal st As String, ByVal style As FontStyle, ByVal isOne As Boolean) As String
        Dim rtb As New RichTextBox

        rtb.SelectedRtf = st
	Dim currentStyle As System.Drawing.FontStyle = rtb.SelectionFont.Style

        'modification to original function to allow return to
        'regular style by program
        If isOne = True Then
            For i As Integer = 0 To rtb.Text.Length - 1
                rtb.SelectionStart = i
                rtb.SelectionLength = 1
                currentStyle = currentStyle Xor style
                rtb.SelectionFont = New Font(rtb.SelectionFont, currentStyle)
            Next
        Else
            For i As Integer = 0 To rtb.Text.Length - 1
                rtb.SelectionStart = i
                rtb.SelectionLength = 1
                rtb.SelectionFont = New Font(rtb.SelectionFont, rtb.SelectionFont.Style Or style)
            Next
        End If

        rtb.SelectionStart = 0
        rtb.SelectionLength = rtb.Text.Length
        st = rtb.SelectedRtf
        rtb.Dispose()
        Return st
    End Function
    '===============================================================

    '=====function to check state of selected text======
    Private Function CheckStyle(ByVal st As String, ByVal style As FontStyle) As Boolean
        Dim rtb As New RichTextBox
        Dim bCheck As Boolean = True
        Dim loopcount As Integer = 0
        Dim fsCheck As FontStyle

        rtb.SelectedRtf = st

        If style = FontStyle.Bold Then
            bCheck = True
            Do Until loopcount = rtb.Text.Length - 1
                rtb.SelectionStart = loopcount
                rtb.SelectionLength = 1
                fsCheck = rtb.SelectionFont.Style
                If CInt(fsCheck) = 1 Or CInt(fsCheck) Mod 2 = 1 Then
                    bCheck = True
                Else
                    bCheck = False
                    Exit Do
                End If
                loopcount += 1
            Loop
        ElseIf style = FontStyle.Italic Then
            bCheck = True
            Do Until loopcount = rtb.Text.Length
                rtb.SelectionStart = loopcount
                rtb.SelectionLength = 1
                fsCheck = rtb.SelectionFont.Style
                Select Case CInt(fsCheck)
                    Case 2, 3, 6, 7, 10, 11, 14, 15
                        bCheck = True
                    Case Else
                        bCheck = False
                        Exit Do
                End Select
                loopcount += 1
            Loop
        ElseIf style = FontStyle.Underline Then
            bCheck = False
            Do Until loopcount = rtb.Text.Length
                rtb.SelectionStart = loopcount
                rtb.SelectionLength = 1
                fsCheck = rtb.SelectionFont.Style
                Select Case CInt(fsCheck)
                    Case 4, 5, 6, 7, 12, 13, 14, 15
                        bCheck = True
                    Case Else
                        bCheck = False
                        Exit Do
                End Select
                loopcount += 1
            Loop
        End If
        rtb.Dispose()
        Return bCheck
    End Function
    '============================================================================

    '===============Enables form or starts new document==========================
    Private Sub fmiNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fmiNew.Click, tmNew.Click
        If rtxtData.Enabled = True And isDirty = True Then
            DisplayMessage()
            RestartForm()
        ElseIf rtxtData.Enabled = True Then
            RestartForm()
        Else
            ActivateForm()
        End If
        Me.Text = "Heroless Text Editor - Untitled1.htxt"

    End Sub
    '============================================================================

    '========The context menu to manipulate the text=============
    Private Sub TextManipulate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsUndo.Click, cmsCopy.Click, cmsCut.Click, cmsDelete.Click, cmsPaste.Click, cmsRedo.Click, tmCut.Click, tmCopy.Click, tmPaste.Click
        With sender
            If .Equals(cmsUndo) Then
                rtxtData.Undo()
            ElseIf .Equals(cmsRedo) Then
                rtxtData.Redo()
            ElseIf .Equals(cmsCut) Or .Equals(tmCut) Then
                rtxtData.Cut()
            ElseIf .Equals(cmsCopy) Or .Equals(tmCopy) Then
                rtxtData.Copy()
            ElseIf .Equals(cmsPaste) Or .Equals(tmPaste) Then
                rtxtData.Paste()
            ElseIf .Equals(cmsDelete) Then
                rtxtData.SelectedRtf = ""
            End If
        End With
    End Sub
    '==============================================================

    '=========Shows dialog to save or not====
    Private Sub DisplayMessage()
        Dim dlgResult As DialogResult = MessageBox.Show("Your file has changed." + vbNewLine + "Would you like to save?", "Heroless Editor.", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dlgResult = 6 Then
            SaveData(fmiSave, System.EventArgs.Empty)
        End If
        isDirty = False
    End Sub
    '==========================================

    '============Restarts the form=============
    Private Sub RestartForm()
        rtxtData.Clear()
        tmSave.Enabled = False
        tmPrint.Enabled = False
        fmiSave.Enabled = False
        fmiPrint.Enabled = False
        fmiPageSetup.Enabled = False
        fmiPrintPreview.Enabled = False
    End Sub
    '===========================================

    '=============Updates Time==================
    Private Sub tDate_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tDate.Tick
        ssDateTime.Text = CStr(System.DateTime.Now)
    End Sub
    '===========================================

    '==========changes single selection=========
    Private Sub singleSelect()
        Select Case CInt(rtxtData.SelectionFont.Style())
            Case 1
                tmBold.Checked = True
                tmItalic.Checked = False
                tmUnderline.Checked = False
            Case 2
                tmBold.Checked = False
                tmItalic.Checked = True
                tmUnderline.Checked = False
            Case 3
                tmBold.Checked = True
                tmItalic.Checked = True
                tmUnderline.Checked = False
            Case 4
                tmBold.Checked = False
                tmItalic.Checked = False
                tmUnderline.Checked = True
            Case 5
                tmBold.Checked = True
                tmItalic.Checked = False
                tmUnderline.Checked = True
            Case 6
                tmBold.Checked = False
                tmItalic.Checked = True
                tmUnderline.Checked = True
            Case 7, 9, 10, 11, 12, 13, 14, 15
                tmBold.Checked = True
                tmItalic.Checked = True
                tmUnderline.Checked = True
            Case Else
                tmBold.Checked = False
                tmItalic.Checked = False
                tmUnderline.Checked = False
        End Select
    End Sub
    '==========================================
End Class
