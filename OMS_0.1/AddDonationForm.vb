Public Class AddDonationForm
    Private DB As New DBAccess
    Private memberstatus As String
    Private Sub clearappfield()
        DonorIDTextBox.Clear()
        SupervisorTextBox.Clear()
        DFNameTextBox.Clear()
        DLNameTextBox.Clear()
        SnameTextBox.Clear()
        PositionTextBox.Clear()
        AmountTextBox.Clear()
        DescriptionRichTextBox.Clear()
    End Sub
    Private Sub RefreshTable()
        DonateDataGridView.ReadOnly = True
        DB.ExecuteQuery("SELECT * from accounts WHERE card_type = 'credit'")
        If DB.Exception <> String.Empty Then
            MessageBox.Show("OMS cannot connect with server right now. Please contact with administrator.", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        DonateDataGridView.DataSource = DB.DBDataTable

    End Sub
    Private Sub DonateDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DonateDataGridView.CellClick

        DonorIDTextBox.Text = DonateDataGridView.Item(1, e.RowIndex).Value
        SupervisorTextBox.Text = DonateDataGridView.Item(2, e.RowIndex).Value


        readonlyappfield(True)
        'enable

        DB.AddParam("@DonorID", DonorIDTextBox.Text)
        DB.ExecuteQuery("Select*FROM member Where member_Id Like?")
        memberstatus = DB.DBDataTable(0) !member_ID
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub

        End If
        DFNameTextBox.Text = DB.DBDataTable(0) !firstname
        DLNameTextBox.Text = DB.DBDataTable(0) !lastname

        DB.DBDataTable.Clear()



        DB.AddParam("@employeeid", SupervisorTextBox.Text)
        DB.ExecuteQuery("Select * FROM employee Where Employee_ID=?")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub

        End If

        SnameTextBox.Text = DB.DBDataTable(0) !firstname & ". " & DB.DBDataTable(0) !lastname
        PositionTextBox.Text = DB.DBDataTable(0) !position


    End Sub
    Private Sub NewDonation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DonateDataGridView.ReadOnly = True
        DB.ExecuteQuery("SELECT * from accounts WHERE card_type = 'credit'")
        If DB.Exception <> String.Empty Then
            MessageBox.Show("OMS cannot connect with server right now. Please contact with administrator.", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        DonateDataGridView.DataSource = DB.DBDataTable
    End Sub
    Private Sub readonlyappfield(Switch As Boolean)
        DonorIDTextBox.ReadOnly = Switch
        SupervisorTextBox.ReadOnly = Switch
        DFNameTextBox.ReadOnly = Switch
        DLNameTextBox.ReadOnly = Switch
        SnameTextBox.ReadOnly = Switch
        PositionTextBox.ReadOnly = Switch
    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click

        If SubmitButton.Text = "&Add new donation record" Then
            'Edit mode

            clearappfield()

            readonlyappfield(True)
            DonorIDTextBox.ReadOnly = False
            SupervisorTextBox.ReadOnly = False

            SubmitButton.Text = "Save and &Submit"
        Else
            If DonorIDTextBox.Text = String.Empty Or DFNameTextBox.Text = String.Empty Or DLNameTextBox.Text = String.Empty Then
                MessageBox.Show("Donor ID is not volid. Please check again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                With DonorIDTextBox
                    .Focus()
                    .Border.BackColor = Color.Red
                End With
            ElseIf SupervisorTextBox.Text = String.Empty Or PositionTextBox.Text = String.Empty Or SnameTextBox.Text = String.Empty Then
                MessageBox.Show("Supervisor ID is not volid. Please check again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                With SupervisorTextBox
                    .Focus()
                    .Border.BackColor = Color.Red
                End With
            ElseIf AmountTextBox.Text = String.Empty Then
                MessageBox.Show("Please input amount of donation.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                With AmountTextBox
                    .Focus()
                    .Border.BackColor = Color.Red
                End With
            ElseIf DescriptionRichTextBox.Text = String.Empty Then
                MessageBox.Show("Please input donation description.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                DescriptionRichTextBox.Focus()
            Else
                DB.AddParam("@Member_ID", DonorIDTextBox.Text)
                DB.AddParam("@Employee_ID", SupervisorTextBox.Text)
                DB.AddParam("@card_type", "credit")
                DB.AddParam("@amount", AmountTextBox.Text)
                DB.AddParam("@date", DonateDateTimePicker.Value)
                DB.AddParam("@description", DescriptionRichTextBox.Text)
                DB.AddParam("@receive_account", "9457783788831245")

                DB.ExecuteQuery("INSERT INTO accounts(Member_ID, Employee_ID, card_type, amount, date, description, receive_account) values(?,?,?,?,?,?,?)")

                If DB.Exception <> String.Empty Then
                    MessageBox.Show("OMS cannot connect with server right now. Please contact with administrator.", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Sub
                Else
                    MessageBox.Show("This donation record has been saved.")
                    RefreshTable()
                    readonlyappfield(False)
                    SubmitButton.Text = "&Add new donation record"
                End If
            End If
        End If
    End Sub

    Private Sub donorIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles DonorIDTextBox.TextChanged
        Try
            DB.AddParam("@donorID", DonorIDTextBox.Text)
            DB.ExecuteQuery("Select*FROM member Where member_Id Like?")
            memberstatus = DB.DBDataTable(0) !member_ID
            DFNameTextBox.Text = DB.DBDataTable(0) !firstname
            DLNameTextBox.Text = DB.DBDataTable(0) !lastname

        Catch ex As Exception
            DFNameTextBox.Clear()
            DLNameTextBox.Clear()
        End Try
    End Sub

    Private Sub SupervisorTextBox_TextChanged(sender As Object, e As EventArgs) Handles SupervisorTextBox.TextChanged
        Try
            DB.AddParam("@employeeid", SupervisorTextBox.Text)
            DB.ExecuteQuery("Select * FROM employee Where Employee_ID=?")
            PositionTextBox.Text = DB.DBDataTable(0) !position
            SnameTextBox.Text = DB.DBDataTable(0) !firstname & "" & DB.DBDataTable(0) !lastname
        Catch ex As Exception
            PositionTextBox.Clear()
            SnameTextBox.Clear()
        End Try
    End Sub
    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        clearappfield()
    End Sub

    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        RefreshTable()
    End Sub
End Class