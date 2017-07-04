Public Class AdopterReport

    Private DB As New DBAccess
    Private Sub Adopterreport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AdopterDataGridView.ReadOnly = True
        DB.ExecuteQuery("SELECT * FROM member Where member_type= 'adopter' ")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub

        End If
        AdopterDataGridView.DataSource = DB.DBDataTable

        AdopterTextBox.ReadOnly = True
        FullNameTextBox.ReadOnly = True
        EditButton.Enabled = False
        DeleteButton.Enabled = False
    End Sub
    Private Sub Searchmemberid(employee As String)
        FirstNTextBox.Clear()
        LastNTextBox.Clear()
        DB.AddParam("@memberid", employee & "%")
        DB.ExecuteQuery("SELECT * FROM member WHERE Member_ID LIKE ? And member_type= 'adopter'")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
        AdopterDataGridView.DataSource = DB.DBDataTable
    End Sub

    Private Sub MemberIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles MemberIDTextBox.TextChanged
        Searchmemberid(MemberIDTextBox.Text)
    End Sub
    Private Sub FirstNTextBox_TextChanged(sender As Object, e As EventArgs) Handles FirstNTextBox.TextChanged
        MemberIDTextBox.Clear()
        LastNTextBox.Clear()
        DB.AddParam("@memberF", FirstNTextBox.Text & "%")
        DB.ExecuteQuery("SELECT * FROM member WHERE firstname LIKE ? And member_type= 'adopter' ")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
        AdopterDataGridView.DataSource = DB.DBDataTable

    End Sub
    Private Sub LastNTextBox_TextChanged(sender As Object, e As EventArgs) Handles LastNTextBox.TextChanged
        MemberIDTextBox.Clear()
        FirstNTextBox.Clear()
        DB.AddParam("@memberF", LastNTextBox.Text & "%")
        DB.ExecuteQuery("SELECT * FROM member WHERE lastname LIKE ? And member_type= 'adopter' ")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
        AdopterDataGridView.DataSource = DB.DBDataTable
    End Sub

    Private Sub AdopterDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles AdopterDataGridView.CellClick
        If e.ColumnIndex < 0 Or e.RowIndex < 0 Then
            Exit Sub

        End If
        AdopterTextBox.Text = AdopterDataGridView.Item(0, e.RowIndex).Value
        FullNameTextBox.Text = AdopterDataGridView.Item(3, e.RowIndex).Value & " " & AdopterDataGridView.Item(4, e.RowIndex).Value
        EditButton.Enabled = True
        DeleteButton.Enabled = True
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        AdopterTextBox.Clear()
        FullNameTextBox.Clear()

        '  Adopter.clear()
        EditAdopterForm.EnableFields(False)

        'Adopter.EditsaveButton.Text = "&Save"
        EditAdopterForm.EditsaveButton.Visible = False

        EditAdopterForm.SaveButton.Visible = True
        EditAdopterForm.ShowDialog()

    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        EditAdopterForm.SaveButton.Visible = False
        EditAdopterForm.EditsaveButton.Visible = True

        EditAdopterForm.EnableFields(True)

        EditAdopterForm.ShowDialog()
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Deleteadopter()
        DB.ExecuteQuery("SELECT * FROM member Where member_type= 'adopter' ")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub

        End If
        AdopterDataGridView.DataSource = DB.DBDataTable

    End Sub
    Private Sub Deleteadopter()
        If MessageBox.Show("You are going to delete the selected Adopter. If you select Yes, It will be removed from database. So be a paytion!", "Delete Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
            Exit Sub


        End If
        DB.AddParam("@adopterID", AdopterTextBox.Text)
        DB.ExecuteQuery("DELETE FROM member WHERE Member_ID = ? ")

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub

        End If
        MessageBox.Show("The record has been deleted from the database.", "Delete Completion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        '  SuperviorTextBox.Clear()
        ' FirstNTextBox.Clear()
        'LastNTextBox.Clear()
        'ChildTextBox.Clear()
        'FullNameTextBox.Clear()


        'RefreshDataGridView()

    End Sub

    Private Sub ExportButton_Click(sender As Object, e As EventArgs) Handles ExportButton.Click
        CircularProgress1.IsRunning = True

        Select Case MessageBox.Show("Do you want to export Adopter table into an Excel document? It maybe take a few minutes.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Case DialogResult.Yes
                Dim ExportToExcel As New ExportToExcel
                ExportToExcel.DcExcel(AdopterDataGridView)
                CircularProgress1.IsRunning = False
            Case DialogResult.No
                CircularProgress1.IsRunning = False
        End Select
    End Sub

    Private Sub Export2Button_Click(sender As Object, e As EventArgs) Handles Export2Button.Click
        CircularProgress2.IsRunning = True
        Dim ExportToPDF As New ExportToPDF
        ExportToPDF.PDFTitle = "Adopter Report"
        ExportToPDF.ExportToPDF(AdopterDataGridView)
        CircularProgress2.IsRunning = False
    End Sub
End Class