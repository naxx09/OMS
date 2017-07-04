Imports System.ComponentModel
Imports System.Text.RegularExpressions
Public Class EditDonorForm
    Private DB As New DBAccess
    Private Sub RefreshForm()
        SupervisorTextBox.Clear()
        SupervisorTextBox.Border.BackColor = Nothing
        FNTextBox.Clear()
        FNTextBox.Border.BackColor = Nothing
        LNTextBox.Clear()
        LNTextBox.Border.BackColor = Nothing
        GenderComboBox.SelectedItem = "Select"
        DOBDateTimePicker.Value = DateTime.Now
        PhoneTextBox.Text = String.Empty
        EmailTextBox.Clear()
        EmailTextBox.Border.BackColor = Nothing
        ANTextBox.Text = Nothing
    End Sub

    'Using Regular Expression Function to validate Email address
    Public Function validateEmail(emailAddress) As Boolean
        ' Dim email As New Regex("^(?<user>[^@]+)@(?<host>.+)$")
        Dim email As New Regex("([\w-+]+(?:\.[\w-+]+)*@(?:[\w-]+\.)+[a-zA-Z]{2,7})")
        ' Check the match.
        If email.IsMatch(emailAddress) Then
            Return True
        Else
            Return False
        End If
    End Function

    'Using Regular Expression Function to validate Firstname and Lastname
    Function ValidateFLname(ByVal user As String,
Optional ByVal minLength As Integer = 1) As Boolean
        Dim username As New Regex("[A-Za-z0-9]")
        ' Check the length.
        If Len(user) < minLength Then Return False

        ' Check the match.
        If username.IsMatch(user) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub EditDonor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshForm()

        DonorIDTextBox.ReadOnly = True

        EnableFields(False)
        DB.AddParam("@MemberID", DonorReport.DonorIDTextBox.Text)
        DB.ExecuteQuery("Select * FROM member WHERE member_ID = ?")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If

        DonorIDTextBox.Text = DB.DBDataTable(0) !Member_ID

        SupervisorTextBox.Text = DB.DBDataTable(0) !Employee_ID
        FNTextBox.Text = DB.DBDataTable(0) !firstname
        LNTextBox.Text = DB.DBDataTable(0) !lastname
        GenderComboBox.Text = DB.DBDataTable(0) !gender
        DOBDateTimePicker.Value = DB.DBDataTable(0) !DOB
        AddressForm.AddressString = DB.DBDataTable(0) !address
        AddressForm.CityString = DB.DBDataTable(0) !city
        AddressForm.StateString = DB.DBDataTable(0) !state
        PhoneTextBox.Text = DB.DBDataTable(0) !phone
        EmailTextBox.Text = DB.DBDataTable(0) !email
        ANTextBox.Text = DB.DBDataTable(0) !account_number


    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click

        If EditButton.Text = "&Edit" Then
            EnableFields(True)
            EditButton.Text = "&Save"
        Else
            If SupervisorTextBox.Text = String.Empty Then
                MessageBox.Show("Please enter supervisor ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                With SupervisorTextBox
                    .Focus()
                    .Border.BackColor = Color.Red
                End With
            ElseIf FNTextBox.Text = String.Empty Then
                MessageBox.Show("Please enter donor's first name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                With FNTextBox
                    .Focus()
                    .Border.BackColor = Color.Red
                End With
            ElseIf ValidateFLname(FNTextBox.Text) = False Then
                MessageBox.Show("First name is not valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                With FNTextBox
                    .Focus()
                    .Border.BackColor = Color.Red
                End With
            ElseIf LNTextBox.Text = String.Empty Then
                MessageBox.Show("Please enter donor's last name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                With LNTextBox
                    .Focus()
                    .Border.BackColor = Color.Red
                End With
            ElseIf ValidateFLname(LNTextBox.Text) = False Then
                MessageBox.Show("Last name is not valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                With LNTextBox
                    .Focus()
                    .Border.BackColor = Color.Red
                End With
            ElseIf GenderComboBox.SelectedItem = "Select" Or GenderComboBox.Text = String.Empty Then
                MessageBox.Show("Please select donor's gender.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                GenderComboBox.Focus()
            ElseIf DOBDateTimePicker.Value = DateTime.Now Then
                MessageBox.Show("Date of birth is not valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                DOBDateTimePicker.Focus()
            ElseIf AddressForm.AddressString = String.Empty Or AddressForm.StateString = String.Empty Or AddressForm.CityString = String.Empty Then
                MessageBox.Show("Address is not valid. Please Click 'Add Address' button to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                AddressButton.Focus()
            ElseIf PhoneTextBox.Text.Length < 10 Then
                MessageBox.Show("Please enter donor's phone number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                PhoneTextBox.Focus()
            ElseIf EmailTextBox.Text = String.Empty Then
                MessageBox.Show("Please enter donor's email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                With EmailTextBox
                    .Focus()
                    .Border.BackColor = Color.Red
                End With
            ElseIf validateEmail(EmailTextBox.Text) = False Then
                MessageBox.Show("Email address is not valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                With EmailTextBox
                    .Focus()
                    .Border.BackColor = Color.Red
                End With
            ElseIf ANTextBox.Text = String.Empty Then
                MessageBox.Show("Please enter account number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ANTextBox.Focus()
            Else

                    DB.AddParam("@Employee_ID", SupervisorTextBox.Text)
                DB.AddParam("@firstname", FNTextBox.Text)
                DB.AddParam("@lastname", LNTextBox.Text)
                DB.AddParam("@gender", GenderComboBox.Text)
                DB.AddParam("@DOB", DOBDateTimePicker.Value.Date)
                DB.AddParam("@address", AddressForm.AddressString)
                DB.AddParam("@city", AddressForm.CityString)
                DB.AddParam("@state", AddressForm.StateString)
                DB.AddParam("@phone", PhoneTextBox.Text)
                DB.AddParam("@email", EmailTextBox.Text)
                DB.AddParam("@account_number", ANTextBox.Text)


                DB.AddParam("@member_ID", DonorIDTextBox.Text)
                DB.ExecuteQuery("UPDATE member SET Employee_ID = ?, firstname = ?, lastname= ? , gender = ?, DOB = ?, address = ?, city  = ?, state = ?, phone = ?, email = ?, account_number = ? WHERE member_ID = ?")
                If DB.Exception <> String.Empty Then
                    MessageBox.Show(DB.Exception)
                    Exit Sub
                Else
                    MessageBox.Show("Donor is updated successfully.")

                    EnableFields(False)
                    EditButton.Text = "&Edit"

                End If
            End If
        End If

    End Sub

    Private Sub EnableFields(Switch As Boolean)

        SupervisorTextBox.Enabled = Switch
        FNTextBox.Enabled = Switch
        LNTextBox.Enabled = Switch
        GenderComboBox.Enabled = Switch
        AddressButton.Enabled = Switch
        PhoneTextBox.Enabled = Switch
        EmailTextBox.Enabled = Switch
        ANTextBox.Enabled = Switch
        DOBDateTimePicker.Enabled = Switch
    End Sub
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        RefreshForm()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub AddressButton_Click(sender As Object, e As EventArgs) Handles AddressButton.Click
        AddressForm.ShowDialog()
    End Sub

    Private Sub EditDonorForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        EnableFields(False)
        EditButton.Text = "&Edit"
    End Sub
End Class