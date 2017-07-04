Imports System.ComponentModel

Public Class AddSpendForm
    Private DB As New DBAccess
    Private Sub RefreshForm()
        SAmountTextBox.Clear()
        SAmountTextBox.Border.BackColor = Nothing
        SupervisorIDComboBox.SelectedItem = "--Please select Education Level--"
        SpendReasonRichTextBox.Clear()
        SpendDateTimePicker.Value = DateTime.Today
    End Sub
    Private Sub AddSpend()
        If SAmountTextBox.Text = String.Empty Then
            MessageBox.Show("Please input amount of spend.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            With SAmountTextBox
                .Focus()
                .Border.BackColor = Color.Red
            End With
        ElseIf SupervisorIDComboBox.SelectedItem = "--Please select Education Level--" Then
            MessageBox.Show("Please select supervisor ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            SupervisorIDComboBox.Focus()
        ElseIf SpendReasonRichTextBox.Text = String.Empty Then
            MessageBox.Show("Please input supervisor ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            With SpendReasonRichTextBox
                .Focus()
            End With
        Else
            DB.AddParam("@cardtype", "debit")
            DB.AddParam("@description", SpendReasonRichTextBox.Text)
            DB.AddParam("@amount", SAmountTextBox.Text)
            DB.AddParam("@employeeid", SupervisorIDComboBox.SelectedItem.ToString)
            DB.AddParam("@spenddate", SpendDateTimePicker.Value.Date)
            DB.AddParam("@receiveaccount", "9457783788831245")

            DB.ExecuteQuery("INSERT INTO accounts(card_type, description, amount, employee_ID, date, receive_account )
 VALUES(?,?,?,?,?,?)")

            If DB.Exception <> String.Empty Then
                MessageBox.Show(DB.Exception)
                Exit Sub
            End If
            MessageBox.Show("A new spend record is added successfully")
        End If
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        AddSpend()
    End Sub

    Private Sub AddSpendForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        RefreshForm()

        SupervisorIDComboBox.Items.Add("--Please select Supervisor ID--")
        SupervisorIDComboBox.Items.Add("5")
        SupervisorIDComboBox.Items.Add("47")
        SupervisorIDComboBox.Items.Add("48")
        SupervisorIDComboBox.SelectedItem = "--Please select Supervisor ID--"
    End Sub

    Private Sub AddSpendForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        RefreshForm()
    End Sub
End Class