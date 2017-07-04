Public Class ChildrenReport

    Private DB As New DBAccess
    Private Sub RefreshForm()
        SuperviorTextBox.Clear()
        FirstNTextBox.Clear()
        LastNTextBox.Clear()
        ChildTextBox.Clear()
        FullNameTextBox.Clear()
    End Sub
    Private Sub Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChildrenDataGridView.ReadOnly = True
        RefreshForm()

        DB.ExecuteQuery("SELECT * FROM children")
        If DB.Exception <> String.Empty Then
            MessageBox.Show("OMS cannot connect with server right now. Please contact with administrator.", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        ChildrenDataGridView.DataSource = DB.DBDataTable

        ChildTextBox.ReadOnly = True
        FullNameTextBox.ReadOnly = True

        DetailButton.Enabled = False
    End Sub
    Private Sub SuperviorTextBox_TextChanged(sender As Object, e As EventArgs) Handles SuperviorTextBox.TextChanged
        DB.AddParam("@employeeid", SuperviorTextBox.Text & "%")
        DB.ExecuteQuery("SELECT * FROM children WHERE Employee_ID LIKE ?")
        If DB.Exception <> String.Empty Then
            MessageBox.Show("OMS cannot connect with server right now. Please contact with administrator.", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        ChildrenDataGridView.DataSource = DB.DBDataTable
        FirstNTextBox.Clear()
        LastNTextBox.Clear()
    End Sub


    Private Sub SearchchildFL(firstname As String, lastname As String)
        DB.AddParam("@firstname", firstname & "%")
        DB.AddParam("@lastname", lastname & "%")
        DB.ExecuteQuery("SELECT * FROM children WHERE firstname like ? and lastname like ? ")
        If DB.Exception <> String.Empty Then
            MessageBox.Show("OMS cannot connect with server right now. Please contact with administrator.", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        ChildrenDataGridView.DataSource = DB.DBDataTable
    End Sub

    Private Sub FirstNTextBox_TextChanged(sender As Object, e As EventArgs) Handles FirstNTextBox.TextChanged
        SearchchildFL(FirstNTextBox.Text, LastNTextBox.Text)
    End Sub
    Private Sub ChildrenDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ChildrenDataGridView.CellClick
        If e.ColumnIndex < 0 Or e.RowIndex < 0 Then
            Exit Sub

        End If
        ChildTextBox.Text = ChildrenDataGridView.Item(0, e.RowIndex).Value
        FullNameTextBox.Text = ChildrenDataGridView.Item(2, e.RowIndex).Value & "." & ChildrenDataGridView.Item(3, e.RowIndex).Value & "." & ChildrenDataGridView.Item(4, e.RowIndex).Value

        DetailButton.Enabled = True

    End Sub

    Private Sub RefreshDataGridView()
        DB.ExecuteQuery("SELECT* FROM children")

        If DB.Exception <> String.Empty Then
            MessageBox.Show("OMS cannot connect with server right now. Please contact with administrator.", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        ChildrenDataGridView.DataSource = DB.DBDataTable

    End Sub
    Private Sub DetailButton_Click(sender As Object, e As EventArgs) Handles DetailButton.Click
        EditChildForm.ShowDialog()
    End Sub
    Private Sub LastNTextBox_TextChanged(sender As Object, e As EventArgs) Handles LastNTextBox.TextChanged
        SearchchildFL(FirstNTextBox.Text, LastNTextBox.Text)
    End Sub

    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        ChildrenDataGridView.ReadOnly = True
        DB.ExecuteQuery("SELECT * FROM children")
        If DB.Exception <> String.Empty Then
            MessageBox.Show("OMS cannot connect with server right now. Please contact with administrator.", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        ChildrenDataGridView.DataSource = DB.DBDataTable
    End Sub

    Private Sub ExportButton_Click(sender As Object, e As EventArgs) Handles ExportButton.Click
        CircularProgress1.IsRunning = True

        Select Case MessageBox.Show("Do you want to export Children table into an Excel document? It maybe take a few minutes.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Case DialogResult.Yes
                Dim ExportToExcel As New ExportToExcel
                ExportToExcel.DcExcel(ChildrenDataGridView)
                CircularProgress1.IsRunning = False
            Case DialogResult.No
                CircularProgress1.IsRunning = False
        End Select
    End Sub

    Private Sub Export2Button_Click(sender As Object, e As EventArgs) Handles Export2Button.Click
        CircularProgress2.IsRunning = True
        Dim ExportToPDF As New ExportToPDF
        ExportToPDF.PDFTitle = "Children Report"
        ExportToPDF.ExportToPDF(ChildrenDataGridView)
        CircularProgress2.IsRunning = False
    End Sub
End Class