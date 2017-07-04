Imports System.Text.RegularExpressions

Public Class AddDonorForm
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


    Private Sub AddDonorForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        GenderComboBox.Items.Clear()
        GenderComboBox.Items.Insert(0, "Select")
        GenderComboBox.Items.Insert(1, "M")
        GenderComboBox.Items.Insert(2, "F")
        GenderComboBox.Items.Insert(3, "O")
        GenderComboBox.SelectedItem = "Select"

    End Sub
    Private Sub AddDonor()
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
                DB.AddParam("@membertype", "donor")
            DB.AddParam("@employeeid", SupervisorTextBox.Text)
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

            DB.ExecuteQuery("INSERT INTO member(member_type, Employee_ID, firstname, lastname, gender, DOB, address, city, state, phone, email, account_number) VALUES(?,?,?,?,?,?,?,?,?,?,?,?)")

            If DB.Exception <> String.Empty Then
                MessageBox.Show("OMS cannot connect with server right now. Please contact with administrator.", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            Else
                MessageBox.Show("A new donor is added successfully")

            End If
        End If
    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        AddDonor()
    End Sub

    Private Sub AddressButton_Click(sender As Object, e As EventArgs) Handles AddressButton.Click
        AddressForm.ShowDialog()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        RefreshForm()
    End Sub
End Class

