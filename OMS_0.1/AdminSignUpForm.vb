﻿'Project: Orphanage Information System
'Programmer: Nagappraveen Nagarajh
'Date: 10/10/16
'Class:	Employee Class
'Description: This class contains all the properties of employee class
'It contains the encyrption code for the password text box
'It also includes the business logic 
'It also contains the private and public variables / constants   
Imports System.Text.RegularExpressions
Public Class AdminSignUpForm
    Private DB As New DBAccess
    Private Const encryptionKey As String = "6eT#fUJ7@Pu@2q4cR2tACHuHEmURAh+f"
    Private EmployeeSupervisorID As String


    Private Sub RefreshForm()
        EmployeeUserNameTextBox.Clear()
        EmployeeUserNameTextBox.Border.BackColor = Nothing
        EmployeePasswordTextBox.Clear()
        EmployeePasswordTextBox.Border.BackColor = Nothing
        EmployeeSupervisorID = String.Empty
        EmployeePositionComboBox.Text = String.Empty
        EmployeeFirstNameTextBox.Clear()
        EmployeeFirstNameTextBox.Border.BackColor = Nothing
        EmployeeLastNameTextBox.Clear()
        EmployeeLastNameTextBox.Border.BackColor = Nothing
        EmployeePhoneTextBox.Text = String.Empty
        EmployeeEmailTextBox.Clear()
        EmployeeEmailTextBox.Border.BackColor = Nothing
        EmployeeSalaryTextBox.Clear()
        EmployeeSalaryTextBox.Border.BackColor = Nothing
        EmployeeDOBDateTimePicker.Value = DateTime.Now
        EmployeeErrorProvider.Clear()

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

    'Using Regular Expression Function to validate Username
    Function ValidateUsername(ByVal user As String,
    Optional ByVal minLength As Integer = 4) As Boolean
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
    'Using Regular Expression Function to validate Firstname and Lastname
    Function ValidateFLname(ByVal user As String, Optional ByVal minLength As Integer = 1) As Boolean
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

    'Using Regular Expression Function to validate Salary
    Function ValidateSalary(ByVal sal As String,
    Optional ByVal minLength As Integer = 4) As Boolean
        Dim salary As New Regex("[0-9]")

        ' Check the length.
        If Len(sal) < minLength Then Return False

        ' Check the match.
        If salary.IsMatch(sal) Then
            Return True
        Else
            Return False
        End If
    End Function

    'Using Regular Expression Function to validate Password
    Function ValidatePassword(ByVal pwd As String,
        Optional ByVal minLength As Integer = 8,
        Optional ByVal numUpper As Integer = 2,
        Optional ByVal numLower As Integer = 2,
        Optional ByVal numNumbers As Integer = 2,
        Optional ByVal numSpecial As Integer = 2) As Boolean

        Dim upper As New Regex("[A-Z]")
        Dim lower As New Regex("[a-z]")
        Dim number As New Regex("[0-9]")
        ' Special is "none of the above".
        Dim special As New Regex("[^a-zA-Z0-9]")

        ' Check the length.
        If Len(pwd) < minLength Then Return False
        ' Check for minimum number of occurrences.
        If upper.Matches(pwd).Count < numUpper Then Return False
        If lower.Matches(pwd).Count < numLower Then Return False
        If number.Matches(pwd).Count < numNumbers Then Return False
        If special.Matches(pwd).Count < numSpecial Then Return False

        ' Passed all checks.
        Return True
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Loads the form
        RefreshForm()

        'Adds the items in the Supervisor ID combo box

        'EmployeeSupervisorIDComboBox.Items.Add("--Please select option--")
        'EmployeeSupervisorIDComboBox.Items.Add("101")
        'EmployeeSupervisorIDComboBox.Items.Add("201")
        'EmployeeSupervisorIDComboBox.Items.Add("301")
        'EmployeeSupervisorIDComboBox.Items.Add("302")
        'EmployeeSupervisorIDComboBox.Items.Add("303")
        'If EmployeeSupervisorIDComboBox.Items.Count > 0 Then
        '    EmployeeSupervisorIDComboBox.SelectedIndex = 0    ' The first item has index 0 '
        'End If

        'Adds the items in the Employee Position combo box

        EmployeePositionComboBox.Items.Add("--Please select position--")
        EmployeePositionComboBox.Items.Add("CEO")
        EmployeePositionComboBox.Items.Add("Manager")
        EmployeePositionComboBox.Items.Add("Employee - Accounts")
        EmployeePositionComboBox.Items.Add("Employee - Adoption")
        If EmployeePositionComboBox.Items.Count > 0 Then
            EmployeePositionComboBox.SelectedIndex = 0    ' The first item has index 0 '
        End If



        'loads the employee table from the bis635c2g3 database

        DB.ExecuteQuery("select * from employee")

        'checks for exception
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
    End Sub

    'Replace EmployeeSupervisorIDComboBox
    Private Sub EmployeePositionComboBox_TextChanged(sender As Object, e As EventArgs) Handles EmployeePositionComboBox.TextChanged
        Select Case EmployeePositionComboBox.Text
            Case "CEO"
                EmployeeSupervisorID = "101"
            Case "Manager"
                EmployeeSupervisorID = "201"
            Case "Employee - Accounts"
                EmployeeSupervisorID = "301"
            Case "Employee - Adoption"
                EmployeeSupervisorID = "302"
        End Select
    End Sub

    Private Sub AddCustomer()
        'Performing all the validations of the employee form

        If EmployeeUserNameTextBox.Text = String.Empty Then
            Me.EmployeeErrorProvider.SetError(Me.EmployeeUserNameTextBox, "Please enter your username.")
            With EmployeeUserNameTextBox
                .Focus()
                .Border.BackColor = Color.Red
            End With

        ElseIf ValidateUsername(EmployeeUserNameTextBox.Text) = False Then
            MessageBox.Show("Username is not valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            With EmployeeUserNameTextBox
                .Focus()
                .Border.BackColor = Color.Red
            End With

        ElseIf EmployeePasswordTextBox.Text = String.Empty Then
            Me.EmployeeErrorProvider.SetError(Me.EmployeePasswordTextBox, "Please enter your password.")
            With EmployeePasswordTextBox
                .Focus()
                .Border.BackColor = Color.Red
            End With
        ElseIf ValidatePassword(EmployeePasswordTextBox.Text) = False Then
            MessageBox.Show("Password is not valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            With EmployeePasswordTextBox
                .Focus()
                .Border.BackColor = Color.Red
            End With

            'ElseIf EmployeeSupervisorIDComboBox.SelectedItem.ToString() = "--Please select option--" Then
            '    Me.EmployeeErrorProvider.SetError(Me.EmployeeSupervisorIDComboBox, "Please select option.")
            '    EmployeeSupervisorIDComboBox.Focus()

        ElseIf EmployeePositionComboBox.SelectedItem.ToString() = "--Please select position--" Then
            Me.EmployeeErrorProvider.SetError(Me.EmployeePositionComboBox, "Please select position.")
            EmployeePositionComboBox.Focus()

        ElseIf EmployeeFirstNameTextBox.Text = String.Empty Then
            Me.EmployeeErrorProvider.SetError(Me.EmployeeFirstNameTextBox, "Please enter your first name.")
            EmployeeFirstNameTextBox.Focus()
            With EmployeeFirstNameTextBox
                .Focus()
                .Border.BackColor = Color.Red
            End With

        ElseIf ValidateFLname(EmployeeFirstNameTextBox.Text) = False Then
            MessageBox.Show("First name is not valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            With EmployeeFirstNameTextBox
                .Focus()
                .Border.BackColor = Color.Red
            End With

        ElseIf EmployeeLastNameTextBox.Text = String.Empty Then
            Me.EmployeeErrorProvider.SetError(Me.EmployeeLastNameTextBox, "Please enter your last name.")
            With EmployeeLastNameTextBox
                .Focus()
                .Border.BackColor = Color.Red
            End With

        ElseIf ValidateFLname(EmployeeLastNameTextBox.Text) = False Then
            MessageBox.Show("Lastname is not valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            EmployeeLastNameTextBox.Focus()
            With EmployeeLastNameTextBox
                .Focus()
                .Border.BackColor = Color.Red
            End With

            'in AddressForm
        ElseIf AddressForm.AddressString = String.Empty Or AddressForm.StateString = String.Empty Or AddressForm.CityString = String.Empty Then
            MessageBox.Show("Address is not valid. Please Click 'Add Address' button to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            AddressButton.Focus()

        ElseIf EmployeePhoneTextBox.Text = String.Empty Then
            Me.EmployeeErrorProvider.SetError(Me.EmployeePhoneTextBox, "Please enter your phone number.")
            EmployeePhoneTextBox.Focus()
        ElseIf EmployeePhoneTextBox.Text.Length < 10 Then
            MessageBox.Show("Phone Number is not valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            EmployeePhoneTextBox.Focus()

        ElseIf EmployeeEmailTextBox.Text = String.Empty Then
            Me.EmployeeErrorProvider.SetError(Me.EmployeeEmailTextBox, "Please enter your email address.")
            With EmployeeEmailTextBox
                .Focus()
                .Border.BackColor = Color.Red
            End With

        ElseIf validateEmail(EmployeeEmailTextBox.Text) = False Then
            MessageBox.Show("Email is not valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            With EmployeeEmailTextBox
                .Focus()
                .Border.BackColor = Color.Red
            End With

        ElseIf EmployeeSalaryTextBox.Text = String.Empty Then
            Me.EmployeeErrorProvider.SetError(Me.EmployeeSalaryTextBox, "Please enter your salary.")
            With EmployeeSalaryTextBox
                .Focus()
                .Border.BackColor = Color.Red
            End With

        ElseIf ValidateSalary(EmployeeSalaryTextBox.Text) = False Then
            MessageBox.Show("Salary is not valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            With EmployeeSalaryTextBox
                .Focus()
                .Border.BackColor = Color.Red
            End With
        ElseIf EmployeeDOBDateTimePicker.Value = DateTime.Now Then
            MessageBox.Show("Date of birth is not valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            EmployeeDOBDateTimePicker.Focus()
        Else

            'gets the input data from the user

            DB.AddParam("@username", EmployeeUserNameTextBox.Text)
            'Encryption password
            Dim s3d As New Simple3Des(encryptionKey)
            Dim EncrypString As String
            EncrypString = s3d.EncryptData(EmployeePasswordTextBox.Text)
            DB.AddParam("@password", EncrypString)

            DB.AddParam("@supervisor_ID", EmployeeSupervisorID)
            DB.AddParam("@position", EmployeePositionComboBox.Text)
            DB.AddParam("@firstname", EmployeeFirstNameTextBox.Text)
            DB.AddParam("@lastname", EmployeeLastNameTextBox.Text)
            DB.AddParam("@DOB", EmployeeDOBDateTimePicker.Value)
            DB.AddParam("@address", AddressForm.AddressString)
            DB.AddParam("@phone", EmployeePhoneTextBox.Text)
            DB.AddParam("@date_hired", EmployeeDateHiredDateTimePicker.Value)
            DB.AddParam("@email", (EmployeeEmailTextBox.Text))
            DB.AddParam("@state", AddressForm.StateString)
            DB.AddParam("@city", AddressForm.CityString)
            DB.AddParam("@salary", EmployeeSalaryTextBox.Text)


            'adds the data into the database

            DB.ExecuteQuery("INSERT INTO employee (username, password, supervisor_ID, position, firstname, lastname, 
        DOB, address, phone, date_hired, email, state, city, salary) VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?,?)")


            If DB.Exception <> String.Empty Then
                MessageBox.Show(DB.Exception)
                Exit Sub
            End If

            MessageBox.Show("A new employee is added sucessfully.")
        End If
    End Sub
    Private Sub EmployeeSaveButton_Click(sender As Object, e As EventArgs) Handles EmployeeSaveButton.Click
        AddCustomer() 'calls the AddCustomer method
    End Sub

    Private Sub EmployeeCancelButton_Click_1(sender As Object, e As EventArgs) 
        Me.Close() 'close the program
    End Sub

    Private Sub AddressButton_Click(sender As Object, e As EventArgs) Handles AddressButton.Click
        AddressForm.ShowDialog()
    End Sub

    Private Sub SignUpForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        RefreshForm()
    End Sub
End Class
