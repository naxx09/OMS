Public Class ExportToExcel
    'source: http://www.cnblogs.com/tonygz/p/3196224.html
    Public Sub DcExcel(ByVal DGV As DataGridView)
        Dim wapp As New Microsoft.Office.Interop.Excel.Application
        Dim wsheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim wbook As Microsoft.Office.Interop.Excel.Workbook

        On Error Resume Next

        'display preview

        wapp.Visible = True
        wbook = wapp.Workbooks.Add()
        wsheet = wbook.ActiveSheet

        Dim iX As Integer
        Dim iY As Integer
        Dim iC As Integer

        For iC = 0 To DGV.Columns.Count - 1
            wsheet.Cells(1, iC + 1).Value = DGV.Columns(iC).HeaderText
            wsheet.Cells(1, iC + 1).Font.Bold = True
            wsheet.Cells(1, iC + 1).Font.Size = 14

        Next

        wsheet.Rows(2).select()
        For iX = 0 To DGV.Rows.Count - 1
            For iY = 0 To DGV.Columns.Count - 1
                wsheet.Cells(iX + 2, iY + 1).value = DGV(iY, iX).Value.ToString
            Next
        Next
        'determine if saving excel file

        'Dim myval As Long
        'Dim mystr As String
        'myval = MessageBox.Show("Would you like to save this file?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ''determine
        'Dim myvals As DialogResult
        'If myvals = DialogResult.OK Then

        'End If

        'If myval = vbYes Then
        '    mystr = InputBox("Please input file name.", "Prompt")
        '    If Len(mystr) = 0 Then
        '        MsgBox("File name cannot be empty.", 64, "Error")
        '        Exit Sub
        '    End If

        '    wsheet.SaveAs(System.Windows.Forms.Application.StartupPath & mystr & ".xls")
        '    MsgBox("File saved successfully! File address：" & System.Windows.Forms.Application.StartupPath & mystr & ".xls", 64, "Success")
        '    wapp.Quit()
        'End If
    End Sub

    'way 1, very very slow.

    'Try
    'Dim xlApp As Application
    'Dim xlWorkBook As Workbook
    'Dim xlWorkSheet As Worksheet
    'Dim misValue As Object = Reflection.Missing.Value
    'Dim i As Integer
    'Dim j As Integer

    '        xlApp = New Application
    '        xlWorkBook = xlApp.Workbooks.Add(misValue)
    '        xlWorkSheet = xlWorkBook.Sheets("sheet1")


    '        For i = 0 To DBDataGridView.RowCount - 2
    'For j = 0 To DBDataGridView.ColumnCount - 1
    'For k As Integer = 1 To DBDataGridView.Columns.Count
    '                    xlWorkSheet.Cells(1, k) = DBDataGridView.Columns(k - 1).HeaderText
    '                    xlWorkSheet.Cells(i + 2, j + 1) = DBDataGridView(j, i).Value.ToString()
    '                Next
    'Next
    'Next

    '        xlWorkSheet.SaveAs("U:\vbexcel.xlsx")
    '        xlWorkBook.Close()
    '        xlApp.Quit()

    '        releaseObject(xlApp)
    '        releaseObject(xlWorkBook)
    '        releaseObject(xlWorkSheet)

    '        MsgBox("You can find the file U:\vbexcel.xlsx")

    '    Catch ex As Exception
    '        MessageBox.Show("Error")
    '        Exit Sub
    'End Try



End Class
