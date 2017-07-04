Public Class DonorReport
    Private DB As New DBAccess
    Private Sub DonorReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DonorDataGridView.ReadOnly = True
        DB.ExecuteQuery("SELECT Employee_ID, member_id, firstname, lastname, gender, DOB, address, city, state, phone, email, account_number FROM member WHERE Member_Type = 'donor' ")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub

        End If
        DonorDataGridView.DataSource = DB.DBDataTable

        DonorIDTextBox.ReadOnly = True
        DonorIDTextBox.Clear()
        SupervisorTextBox.ReadOnly = True
        SupervisorTextBox.Clear()
        FNTextBox.Clear()
        LNTextBox.Clear()

        DeleteButton.Enabled = False
        EditButton.Enabled = False

    End Sub
    Private Sub SearchDonorFirstName(firstname As String)

        DB.AddParam("@firstname", firstname & "%")
        DB.ExecuteQuery("SELECT Employee_ID, member_id, firstname, lastname, gender, DOB, address, city, state, phone, email, account_number FROM member WHERE firstname LIKE ? And member_type= 'donor'")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
        DonorDataGridView.DataSource = DB.DBDataTable
    End Sub

    Private Sub FNTextBox_TextChanged(sender As Object, e As EventArgs) Handles FNTextBox.TextChanged
        LNTextBox.Clear()
        SearchDonorFirstName(FNTextBox.Text)
    End Sub
    Private Sub SearchDonorLastName(lastname As String)

        DB.AddParam("@lastname", lastname & "%")
        DB.ExecuteQuery("SELECT Employee_ID, member_id, firstname, lastname, gender, DOB, address, city, state, phone, email, account_number FROM member WHERE lastname LIKE ? And member_type= 'donor'")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
        DonorDataGridView.DataSource = DB.DBDataTable
    End Sub

    Private Sub LNTextBox_TextChanged(sender As Object, e As EventArgs) Handles LNTextBox.TextChanged
        FNTextBox.Clear()
        SearchDonorLastName(LNTextBox.Text)
    End Sub
    Private Sub DonorDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DonorDataGridView.CellClick
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then
            Exit Sub
        End If
        DonorIDTextBox.Text = DonorDataGridView(1, e.RowIndex).Value
        SupervisorTextBox.Text = DonorDataGridView(0, e.RowIndex).Value

        DeleteButton.Enabled = True
        EditButton.Enabled = True

    End Sub

    Private Sub DeleteDonor()
        If MessageBox.Show("You are going to delete the selected donor. If you select Yes, It will be removed from database. So be a paytion!", "Delete Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
            Exit Sub


        End If
        DB.AddParam("@memberID", DonorIDTextBox.Text)
        DB.ExecuteQuery("DELETE FROM member WHERE Member_Id = ? ")

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub

        End If
        MessageBox.Show("The record has been deleted from the database.", "Delete Completion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        SupervisorTextBox.Clear()
        FNTextBox.Clear()
        LNTextBox.Clear()
        DonorIDTextBox.Clear()

    End Sub

    Private Sub DonorDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DonorDataGridView.CellDoubleClick
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then
            Exit Sub
        End If
        DonorIDTextBox.Text = DonorDataGridView(1, e.RowIndex).Value
        SupervisorTextBox.Text = DonorDataGridView(0, e.RowIndex).Value

        EditDonorForm.ShowDialog()
    End Sub
    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        DeleteDonor()
        DB.ExecuteQuery("SELECT Employee_ID, member_id, firstname, lastname, gender, DOB, address, city, state, phone, email, account_number FROM member WHERE Member_Type = 'donor' ")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub

        End If
        DonorDataGridView.DataSource = DB.DBDataTable
    End Sub

    Private Sub ExportButton_Click(sender As Object, e As EventArgs) Handles ExportButton.Click
        CircularProgress1.IsRunning = True

        Select Case MessageBox.Show("Do you want to export Donor table into an Excel document? It maybe take a few minutes.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Case DialogResult.Yes
                Dim ExportToExcel As New ExportToExcel
                ExportToExcel.DcExcel(DonorDataGridView)
                CircularProgress1.IsRunning = False
            Case DialogResult.No
                CircularProgress1.IsRunning = False
        End Select
    End Sub

    Private Sub Export2Button_Click(sender As Object, e As EventArgs) Handles Export2Button.Click
        CircularProgress2.IsRunning = True
        Dim ExportToPDF As New ExportToPDF
        ExportToPDF.PDFTitle = "Donor Report"
        ExportToPDF.ExportToPDF(DonorDataGridView)
        CircularProgress2.IsRunning = False
    End Sub

    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        DonorDataGridView.ReadOnly = True
        DB.ExecuteQuery("SELECT Employee_ID, member_id, firstname, lastname, gender, DOB, address, city, state, phone, email, account_number FROM member WHERE Member_Type = 'donor'")
        If DB.Exception <> String.Empty Then
            MessageBox.Show("OMS cannot connect with server right now. Please contact with administrator.", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        DonorDataGridView.DataSource = DB.DBDataTable

    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        EditDonorForm.ShowDialog()
    End Sub
End Class