


Public Class frmEditorProg

    Private strCurrentFIle As String
    Dim intCheckPrint As Integer




    Private Sub NewToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NewToolStripMenuItem.Click

        If rtbEditor.Modified Then
            Dim intMessage As Integer
            intMessage = MessageBox.Show("The current document has not" & _
                     " been saved, would you like to " & _
                     "continue without saving?", "Unsaved Document", _
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If intMessage = Windows.Forms.DialogResult.Yes Then
                rtbEditor.Clear()
            Else
                Exit Sub
            End If
        Else
            rtbEditor.Clear()
        End If

        strCurrentFIle = ""
        Me.Text = "Editor: New Document"


    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OpenToolStripMenuItem.Click

        If rtbEditor.Modified Then

            Dim answer As Integer
            answer = MessageBox.Show("The current document has not" & _
                     " been saved, would you like to continue " & _
                     "without saving?", "Unsaved Document", _
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If answer = Windows.Forms.DialogResult.No Then
                Exit Sub
            Else
                OpenFile()
            End If
        Else
            OpenFile()
        End If



    End Sub


    Private Sub OpenFile()

        ofdEditor.Title = "RTE - Open File"
        ofdEditor.DefaultExt = "rtf"
        ofdEditor.Filter = "Rich Text Files|*.rtf|" & _
                                 "Text Files|*.txt|HTML Files|" & _
                                 "*.htm|All Files|*.*"
        ofdEditor.FilterIndex = 1
        ofdEditor.ShowDialog()

        If ofdEditor.FileName = "" Then Exit Sub

        Dim strExt As String
        strExt = System.IO.Path.GetExtension(ofdEditor.FileName)
        strExt = strExt.ToUpper()

        Select Case strExt
            Case ".RTF"
                rtbEditor.LoadFile(ofdEditor.FileName, RichTextBoxStreamType.RichText)
            Case Else
                Dim txtReader As System.IO.StreamReader
                txtReader = New System.IO.StreamReader(ofdEditor.FileName)
                rtbEditor.Text = txtReader.ReadToEnd
                txtReader.Close()
                txtReader = Nothing
                rtbEditor.SelectionStart = 0
                rtbEditor.SelectionLength = 0
        End Select

        strCurrentFIle = ofdEditor.FileName
        rtbEditor.Modified = False
        Me.Text = "Editor: " & strCurrentFIle.ToString()

    End Sub


    Private Sub SaveToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SaveToolStripMenuItem.Click


        If strCurrentFIle = "" Then
            SaveAsToolStripMenuItem_Click(Me, e)
            Exit Sub
        End If

        Dim strExt As String
        strExt = System.IO.Path.GetExtension(strCurrentFIle)
        strExt = strExt.ToUpper()

        Select Case strExt
            Case ".RTF"
                rtbEditor.SaveFile(strCurrentFIle)
            Case Else
                ' to save as plain text
                Dim txtWriter As System.IO.StreamWriter
                txtWriter = New System.IO.StreamWriter(strCurrentFIle)
                txtWriter.Write(rtbEditor.Text)
                txtWriter.Close()
                txtWriter = Nothing
                rtbEditor.SelectionStart = 0
                rtbEditor.SelectionLength = 0
                rtbEditor.Modified = False
        End Select

        Me.Text = "Editor: " & strCurrentFIle.ToString()


    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SaveAsToolStripMenuItem.Click


        sfdEditor.Title = "RTE - Save File"
        sfdEditor.DefaultExt = "rtf"
        sfdEditor.Filter = "Rich Text Files|*.rtf|" & _
                                 "Text Files|*.txt|HTML Files" & _
                                 "|*.htm|All Files|*.*"
        sfdEditor.FilterIndex = 1
        sfdEditor.ShowDialog()

        If sfdEditor.FileName = "" Then Exit Sub

        Dim strExt As String
        strExt = System.IO.Path.GetExtension(sfdEditor.FileName)
        strExt = strExt.ToUpper()

        Select Case strExt
            Case ".RTF"
                rtbEditor.SaveFile(sfdEditor.FileName, _
                       RichTextBoxStreamType.RichText)
            Case Else
                Dim txtWriter As System.IO.StreamWriter
                txtWriter = New System.IO.StreamWriter(sfdEditor.FileName)
                txtWriter.Write(rtbEditor.Text)
                txtWriter.Close()
                txtWriter = Nothing
                rtbEditor.SelectionStart = 0
                rtbEditor.SelectionLength = 0
        End Select

        strCurrentFIle = sfdEditor.FileName
        rtbEditor.Modified = False
        Me.Text = "Editor: " & strCurrentFIle.ToString()


    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click

        If rtbEditor.Modified Then

            Dim answer As Integer
            answer = MessageBox.Show("The current document has not been" & _
                     " saved, would you like to continue without saving?", _
                     "Unsaved Document", MessageBoxButtons.YesNo, _
                     MessageBoxIcon.Question)

            If answer = Windows.Forms.DialogResult.No Then
                Exit Sub
            Else
                Application.Exit()
            End If
        Else
            Application.Exit()
        End If


    End Sub

    Private Sub prnEditor_BeginPrint(sender As Object, e As System.Drawing.Printing.PrintEventArgs) Handles prnEditor.BeginPrint


        intcheckPrint = 0

    End Sub

    Private Sub prnEditor_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles prnEditor.PrintPage

        intCheckPrint = rtbEditor.Print(intCheckPrint, rtbEditor.TextLength, e)

        ' Look for more pages
        If intCheckPrint < rtbEditor.TextLength Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
        End If


       

    End Sub

    Private Sub PrintPreviewToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PrintPreviewToolStripMenuItem.Click

        Try
            prnPreviewEditor.Document = prnEditor
            prnPreviewEditor.ShowDialog()

        Catch ex As Exception

            MsgBox(ex.ToString)


        End Try





    End Sub

   

    Private Sub PrintToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs) Handles PrintToolStripMenuItem.Click

        prnDialogEditor.Document = prnEditor
        If prnDialogEditor.ShowDialog() = Windows.Forms.DialogResult.OK Then
            prnEditor.Print()
        End If


    End Sub

    Private Sub PageSetupToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PageSetupToolStripMenuItem.Click


        psDialogEditor.Document = prnEditor
        psDialogEditor.ShowDialog()

    End Sub
End Class
