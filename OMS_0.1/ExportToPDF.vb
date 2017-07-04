Imports System.IO
Imports System.Data
Imports System.Reflection
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Public Class ExportToPDF
    Private myStream As Stream
    Private SaveFileDialog1 As New SaveFileDialog()
    Public PDFTitle As String

    Public Sub ExportToPDF(ByVal DGV As DataGridView)
        SaveFileDialog1.Filter = "PDF (*.pdf)|*.pdf"
        SaveFileDialog1.CreatePrompt = True
        SaveFileDialog1.RestoreDirectory = True

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            myStream = SaveFileDialog1.OpenFile()
            If (myStream IsNot Nothing) Then
                ' Code to write the stream goes here.
                myStream.Close()
            End If
        End If


        Dim Paragraph As New Paragraph ' declaration for new paragraph
        Dim PdfFile As New Document(PageSize.A4, 40, 40, 40, 20) ' set pdf page size
        PdfFile.AddTitle(PDFTitle) ' set our pdf title
        Dim Write As PdfWriter = PdfWriter.GetInstance(PdfFile, New FileStream(SaveFileDialog1.FileName, FileMode.Create))
        PdfFile.Open()

        ' declaration font type
        Dim pTitle As New Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 14, iTextSharp.text.Font.BOLD, BaseColor.BLACK)
        Dim pTable As New Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)

        ' insert title into pdf file
        Paragraph = New Paragraph(New Chunk(PDFTitle, pTitle))
        Paragraph.Alignment = Element.ALIGN_CENTER
        Paragraph.SpacingAfter = 5.0F

        ' set and add page with current settings
        PdfFile.Add(Paragraph)

        ' create data into table
        Dim PdfTable As New PdfPTable(DGV.Columns.Count)
        ' setting width of table
        PdfTable.TotalWidth = 500.0F
        PdfTable.LockedWidth = True

        Dim widths(0 To DGV.Columns.Count - 1) As Single
        For i As Integer = 0 To DGV.Columns.Count - 1
            widths(i) = 1.0F
        Next

        PdfTable.SetWidths(widths)
        PdfTable.HorizontalAlignment = 0
        PdfTable.SpacingBefore = 5.0F

        ' declaration pdf cells
        Dim pdfcell As PdfPCell = New PdfPCell

        ' create pdf header
        For i As Integer = 0 To DGV.Columns.Count - 1

            pdfcell = New PdfPCell(New Phrase(New Chunk(DGV.Columns(i).HeaderText, pTable)))
            ' alignment header table
            pdfcell.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            ' add cells into pdf table
            PdfTable.AddCell(pdfcell)
        Next

        ' add data into pdf table
        For i As Integer = 0 To DGV.Rows.Count - 2

            For j As Integer = 0 To DGV.Columns.Count - 1
                pdfcell = New PdfPCell(New Phrase(DGV(j, i).Value.ToString(), pTable))
                PdfTable.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                PdfTable.AddCell(pdfcell)
            Next
        Next
        ' add pdf table into pdf document
        PdfFile.Add(PdfTable)
        PdfFile.Close() ' close all sessions

        ' show message if hasben exported
        MessageBox.Show("PDF format success exported !", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
