Imports System.Text.RegularExpressions
Imports System.Text
Imports System.Net.Mail


Public Class ForgotPasswordForm
    Private DB As New DBAccess
    Private CurrentRecord As Integer = 0
    Private Const encryptionKey As String = "6eT#fUJ7@Pu@2q4cR2tACHuHEmURAh+f"
    Private VerifCode As String
    Private Sub RefreshForm()
        UsernameTextBox.Clear()
        UsernameTextBox.Border.BackColor = Nothing
        NewPasswordTextBox.Clear()
        NewPasswordTextBox.Border.BackColor = Nothing
        ConfirmNewPasswordTextBox.Clear()
        ConfirmNewPasswordTextBox.Border.BackColor = Nothing
        VerifCodeTextBox.Clear()
        VerifCodeTextBox.Border.BackColor = Nothing
        VerifCode = String.Empty
    End Sub
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
    Private Function CreateRandomNum() As String
        Dim RandomNum As New StringBuilder()
        If String.IsNullOrEmpty(VerifCode) Then
            Dim NumList As String = "0123456789"
            Dim R As New Random()
            For j As Integer = 0 To 5
                RandomNum.Append(NumList(R.[Next](NumList.Length)))
            Next
            VerifCode = RandomNum.ToString()
        End If
        Return VerifCode
    End Function
    Private Sub SendVerifCodeviaEmail(Email As String)
        Dim UserName As String = "orphanage635@gmail.com"
        Dim mail As MailMessage = New MailMessage

        mail.From = New MailAddress(UserName)
        mail.To.Add(New MailAddress(Email))
        mail.Subject = "Reset OMS account's password [DO NOT REPLY]"
        mail.Body = "Verif Code is: " + VerifCode + " ." & vbCrLf &
            "If this reset password request is not issued by yourself, you may ignore it or contact administrator." & vbCrLf &
            "This email is sent by Orphanage Management System (OMS). Please do not reply."

        mail.IsBodyHtml = True

        Dim client As SmtpClient = New SmtpClient("smtp.gmail.com", 587)
        client.EnableSsl = True
        client.UseDefaultCredentials = False
        client.Credentials = New System.Net.NetworkCredential("orphanage635@gmail.com", "initpass")
        Try
            client.Send(mail)
        Catch ex As Exception
            MessageBox.Show("Sending email failed. Please Try again")
        End Try

    End Sub

    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    Private Sub ForgotPasswordForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshForm()
        VerifCodeTextBox.Enabled = False
        NewPasswordTextBox.Enabled = False
        ConfirmNewPasswordTextBox.Enabled = False
        NewPasswordTextBox.PasswordChar = "*"
        ConfirmNewPasswordTextBox.PasswordChar = "*"
    End Sub

    Private Sub UpdateRecord()
        If UsernameTextBox.Text = String.Empty Then
            MessageBox.Show("Please enter your username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            UsernameTextBox.Focus()
            Exit Sub
        Else

            DB.AddParam("@username", UsernameTextBox.Text)
            DB.ExecuteQuery("select * from employee where username = ?")
            If DB.Exception <> String.Empty Then
                MessageBox.Show("Employee ID is not found. Please check again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                UsernameTextBox.Focus()
                UsernameTextBox.Border.BackColor = Color.Red
                Exit Sub
            ElseIf VerifCodeTextBox.Text <> VerifCode Or VerifCodeTextBox.Text = String.Empty Then
                MessageBox.Show("Verif code is not valid. Please check again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                VerifCodeTextBox.Focus()
                VerifCodeTextBox.Border.BackColor = Color.Red
                Exit Sub

            ElseIf NewPasswordTextBox.Text = String.Empty Then
                MessageBox.Show("Please enter a new password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                NewPasswordTextBox.Focus()
                NewPasswordTextBox.Border.BackColor = Color.Red
                Exit Sub

            ElseIf ConfirmNewPasswordTextBox.Text = String.Empty Then
                MessageBox.Show("Please confirm password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ConfirmNewPasswordTextBox.Focus()
                ConfirmNewPasswordTextBox.Border.BackColor = Color.Red
                Exit Sub
            ElseIf (NewPasswordTextBox.Text <> ConfirmNewPasswordTextBox.Text) Then
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                NewPasswordTextBox.Focus()
                NewPasswordTextBox.Border.BackColor = Color.Red
                Exit Sub
            Else

                If ValidatePassword(NewPasswordTextBox.Text) = False Or ValidatePassword(ConfirmNewPasswordTextBox.Text) = False Then
                    MessageBox.Show("Passwords is not valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Else

                    'Encryption password
                    Dim s3d As New Simple3Des(encryptionKey)
                    Dim EncrypString As String
                    EncrypString = s3d.EncryptData(NewPasswordTextBox.Text)

                    DB.AddParam("@password", EncrypString)
                    DB.AddParam("@username", UsernameTextBox.Text)

                    DB.ExecuteQuery("UPDATE employee SET password = ? WHERE username = ?")

                    If NotEmpty(DB.Exception) Then

                        MessageBox.Show(DB.Exception)
                        Exit Sub
                    Else
                        MessageBox.Show("Your password is updated successfully.")
                    End If
                End If
            End If
        End If
        Close()
    End Sub
    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        UpdateRecord()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

    Private Sub NewPasswordTextBox_GotFocus(sender As Object, e As EventArgs) Handles NewPasswordTextBox.GotFocus
        NewPasswordTextBox.PasswordChar = Nothing
        ConfirmNewPasswordTextBox.PasswordChar = "*"
    End Sub

    Private Sub ConfirmNewPasswordTextBox_GotFocus(sender As Object, e As EventArgs) Handles ConfirmNewPasswordTextBox.GotFocus
        NewPasswordTextBox.PasswordChar = "*"
        ConfirmNewPasswordTextBox.PasswordChar = Nothing
    End Sub

    Private Sub UpdateButton_GotFocus(sender As Object, e As EventArgs) Handles UpdateButton.GotFocus
        NewPasswordTextBox.PasswordChar = "*"
        ConfirmNewPasswordTextBox.PasswordChar = "*"
    End Sub

    Private Sub CancelButton_GotFocus(sender As Object, e As EventArgs) Handles CancelButton.GotFocus
        NewPasswordTextBox.PasswordChar = "*"
        ConfirmNewPasswordTextBox.PasswordChar = "*"
    End Sub

    Private Sub SendVerifCodeButton_Click(sender As Object, e As EventArgs) Handles SendVerifCodeButton.Click
        Dim EmployeeEmail As String
        If UsernameTextBox.Text <> String.Empty Then
            CreateRandomNum()
            Try
                DB.AddParam("@username", UsernameTextBox.Text)
                DB.ExecuteQuery("select * from employee where username = ?")
                EmployeeEmail = DB.DBDataTable(0) !email
                SendVerifCodeviaEmail(EmployeeEmail)
            Catch ex As Exception
                MessageBox.Show("Username is not found. Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                UsernameTextBox.Focus()
                UsernameTextBox.Border.BackColor = Color.Red
                Exit Sub
            End Try
            MessageBox.Show("Verif code has been sent to your email. It may be take a while.")
            VerifCodeTextBox.Enabled = True
            NewPasswordTextBox.Enabled = True
            ConfirmNewPasswordTextBox.Enabled = True
        Else
            MessageBox.Show("Please type your employee ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            UsernameTextBox.Focus()
            UsernameTextBox.Border.BackColor = Color.Red
        End If
    End Sub
End Class