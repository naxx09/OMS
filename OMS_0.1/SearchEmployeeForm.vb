Public Class SearchEmployeeForm
    Private DB As New DBAccess

    Public Sub RefreshDataGridView()
        DB.ExecuteQuery("select * from employee order by Employee_ID")
        EmployeeIDTextBox.Clear()
        EmployeeNameTextBox.Clear()
        FirstNameTextBox.Clear()
        LastNameTextBox.Clear()
        EditButton.Enabled = False
        If DB.Exception <> String.Empty Then
            MessageBox.Show("OMS cannot connect with server right now. Please contact with administrator.", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        DBDataGridView.DataSource = DB.DBDataTable
    End Sub
    Private Sub SearchForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBDataGridView.ReadOnly = True
        EditButton.Enabled = False
        RefreshDataGridView()
    End Sub

    'clear textbox
    Private Sub FirstNameTextBox_GotFocus(sender As Object, e As EventArgs) Handles FirstNameTextBox.GotFocus
        LastNameTextBox.Clear()
    End Sub
    Private Sub LastNameTextBox_GotFocus(sender As Object, e As EventArgs) Handles LastNameTextBox.GotFocus
        FirstNameTextBox.Clear()
    End Sub
    'type in first name and search
    Private Sub FirstNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles FirstNameTextBox.TextChanged
        DB.AddParam("@firstname", FirstNameTextBox.Text & "%")
        DB.ExecuteQuery("select * from employee where firstname like ?")

        If DB.Exception <> String.Empty Then
            MessageBox.Show("OMS cannot connect with server right now. Please contact with administrator.", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        DBDataGridView.DataSource = DB.DBDataTable
    End Sub
    'type in last name and search
    Private Sub LastNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles LastNameTextBox.TextChanged
        DB.AddParam("@lastname", LastNameTextBox.Text & "%")
        DB.ExecuteQuery("select * from employee where lastname like ?")

        If DB.Exception <> String.Empty Then
            MessageBox.Show("OMS cannot connect with server right now. Please contact with administrator.", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        DBDataGridView.DataSource = DB.DBDataTable
    End Sub
    'select cell
    Private Sub DBDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DBDataGridView.CellClick
        If e.ColumnIndex < 0 Or e.RowIndex < 0 Then
            Exit Sub
        End If

        EmployeeIDTextBox.Text = DBDataGridView.Item(0, e.RowIndex).Value
        EmployeeNameTextBox.Text = DBDataGridView.Item(6, e.RowIndex).Value & " " & DBDataGridView.Item(5, e.RowIndex).Value
        EditButton.Enabled = True
    End Sub


    Private Sub DBDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DBDataGridView.CellDoubleClick
        If e.ColumnIndex < 0 Or e.RowIndex < 0 Then
            Exit Sub
        End If
        EmployeeIDTextBox.Text = DBDataGridView.Item(0, e.RowIndex).Value
        EmployeeNameTextBox.Text = DBDataGridView(6, e.RowIndex).Value & " " & DBDataGridView(5, e.RowIndex).Value
        EditAccountForm.Show()
    End Sub


    Private Sub BackButton_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub DBDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs)

    End Sub
    Private Sub releaseObject(ByVal obj As Object)
        Try
            Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
    Private Sub ExportButton_Click(sender As Object, e As EventArgs) Handles ExportButton.Click
        'circularprogress control. source: http://www.vbforums.com/showthread.php?671821-DotNetBar-Circular-Progress-Bar-Marquee
        CircularProgress1.IsRunning = True

        Select Case MessageBox.Show("Do you want to export Employee table into an Excel document? It maybe take a few minutes.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Case DialogResult.Yes
                Dim ExportToExcel As New ExportToExcel
                ExportToExcel.DcExcel(DBDataGridView)
                CircularProgress1.IsRunning = False
            Case DialogResult.No
                CircularProgress1.IsRunning = False
        End Select
    End Sub

    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        RefreshDataGridView()
    End Sub

    Private Sub Export2Button_Click(sender As Object, e As EventArgs) Handles Export2Button.Click
        CircularProgress2.IsRunning = True
        Dim ExportToPDF As New ExportToPDF
        ExportToPDF.PDFTitle = "Employee Report"
        ExportToPDF.ExportToPDF(DBDataGridView)
        CircularProgress2.IsRunning = False

    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        EditAccountForm.Show()
    End Sub
End Class
