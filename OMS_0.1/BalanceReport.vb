Public Class BalanceReport
    Private DB As New DBAccess
    Private Sub BalanceReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ALDataGridView.ReadOnly = True
        DB.ExecuteQuery("SELECT date, card_type as account_type, sum(amount) as Total FROM accounts group by date")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
        ALDataGridView.DataSource = DB.DBDataTable

        'Balance
        DB.ExecuteQuery("select sum((Select Sum(amount) as Total_Spend from accounts where card_type = 'credit') - 
(Select Sum(amount) as Total_Donation from accounts where card_type = 'debit')) as 'Total' ")
        TotalDonationTextBox.Text = DB.DBDataTable(0) !Total
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub

        End If
        DB.ExecuteQuery("Select Sum(amount) as Total_Donation from accounts where card_type = 'credit'")
        TotalSpendTextBox.Text = DB.DBDataTable(0) !Total_Donation
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub

        End If
        DB.ExecuteQuery("Select Sum(amount) as Total_Spend from accounts where card_type = 'debit'")
        TotalBalanceTextBox.Text = DB.DBDataTable(0) !Total_Spend
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
    End Sub


    ' Private Sub Balance(Balance As String)
    '
    '    DB.AddParam("@Balance", Balance & "%")
    '   DB.ExecuteQuery("Select Sum(amount) from accounts where card_type = 'debit' ")
    'If DB.Exception <> String.Empty Then
    '        MessageBox.Show(DB.Exception)
    'Exit Sub
    'End If
    '    ALDataGridView.DataSource = DB.DBDataTable
    'End Sub

    'Private Sub DonationTextBox_TextChanged(sender As Object, e As EventArgs)
    '    SumDonation(DonationTextBox.Text)
    'End Sub


    'Private Sub DonationTextBox_TextChanged(sender As Object, e As EventArgs) Handles DonationTextBox.TextChanged (donation As INT)
    '
    '   DB.AddParam("@donation", Donation & "%")
    '  DonationTextBox.Text = ("Select Sum(amount) from accounts where card_type = 'debit' ".ToString)
    '
    '
    'If DB.Exception <> String.Empty Then
    '       MessageBox.Show(DB.Exception)
    'Exit Sub
    'End If
    'End Sub

    '   Private Sub ALDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles ALDateTimePicker.ValueChanged
    '       Dim date_str As String = ALDateTimePicker.Value
    '      Dim date_str_2 As String = DB.DBDataTable(0)!date
    '     DB.ExecuteQuery(" )
    '    MsgBox(date_str_2)
    '
    '   ALDataGridView.DataSource = DB.DBDataTable
    'End Sub



End Class