'Project: Orphanage Information System
'Programmer: Nagappraveen Nagarajh
'Date: 10/10/16
'Class:	Login Class
'Description: This class contains all the properties of login class
'It also includes the business logic 
'It also contains the private and public variables / constants   

Imports System.Drawing.Imaging
Imports System.IO
Imports System.Text
Public Class LoginForm
    Dim ResourceFilePathPrefix As String
    Private rand As New Random()

    Private DB As New DBAccess
    Private Const encryptionKey As String = "6eT#fUJ7@Pu@2q4cR2tACHuHEmURAh+f"

    Private Sub RefreshForm()
        LoginUserNameTextBox.Clear()
        LoginUserNameTextBox.Border.BackColor = Nothing
        LoginPasswordTextBox.Clear()
        LoginPasswordTextBox.Border.BackColor = Nothing
        LoginCaptchaTextBox.Clear()
        LoginCaptchaTextBox.Border.BackColor = Nothing
        PictureBox1.Image.Dispose()
        code = ""
        CreateImage()
    End Sub

    'loads the login form
    Public Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load progress bar
        Dim i As Integer = 0
        While i <= 20
            SplashScreen.ShowBar(i)
            i += 1
            Threading.Thread.Sleep(20)
        End While

        CreateImage()
        DB.ExecuteQuery("select * from employee")
        'checks for exception
        If DB.Exception <> String.Empty Then
            MessageBox.Show("OMS cannot connect with server right now. Please contact with administrator.", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        If Debugger.IsAttached() Then
            'In Debugging mode  
            ResourceFilePathPrefix = Path.GetFullPath(Application.StartupPath & "\Resources")
        Else
            'In Published mode  
            ResourceFilePathPrefix = Application.StartupPath & "\Resources\"
        End If
    End Sub
    Private Sub LoginSubmitButton_Click(sender As Object, e As EventArgs) Handles LoginSubmitButton.Click
        LoginFunction() 'calls the add customer method
    End Sub
    Private Sub LoginFunction()

        'validates the username and password of the login form

        If LoginUserNameTextBox.Text = String.Empty Then
            MessageBox.Show("Please enter your name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            LoginUserNameTextBox.Focus()
            LoginUserNameTextBox.Border.BackColor = Color.Red
        ElseIf LoginPasswordTextBox.Text = String.Empty Then
            MessageBox.Show("Please enter your password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            LoginPasswordTextBox.Focus()
            LoginPasswordTextBox.Border.BackColor = Color.Red
        ElseIf LoginCaptchaTextBox.Text = String.Empty Then
            MessageBox.Show("Please enter captcha.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            LoginCaptchaTextBox.Focus()
            LoginCaptchaTextBox.Border.BackColor = Color.Red
        ElseIf LoginCaptchaTextBox.Text = code.ToString() = False Then
            MessageBox.Show("Incorrect captcha.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            LoginCaptchaTextBox.Focus()
            LoginCaptchaTextBox.Border.BackColor = Color.Red
        Else
            DB.AddParam("@username", LoginUserNameTextBox.Text)
            'Verif password
            Dim s3d As New Simple3Des(encryptionKey)
            Dim EncrypString As String
            EncrypString = s3d.EncryptData(LoginPasswordTextBox.Text)
            DB.AddParam("@password", EncrypString)
            DB.ExecuteQuery("SELECT * FROM employee WHERE username = ? AND password = ?")
            LoginCaptchaTextBox.Text = code.ToString()

            If DB.Exception <> String.Empty Then
                MessageBox.Show("OMS cannot connect with server right now. Please contact with administrator.", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            Else

                If DB.RecordCount = 0 Then
                    MessageBox.Show("Wrong user name or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Try
                        WelcomeForm.EmpFname = DB.DBDataTable(0) !firstname
                        WelcomeForm.EmpLname = DB.DBDataTable(0) !lastname
                    Catch ex As Exception

                    End Try
                    'validating the radio buttons according to the selection made

                    Dim aDatarow As DataRow = DB.DBDataTable.Rows(0)

                    If aDatarow("supervisor_ID") = 101 Then
                        MainForm.ManagerMode()
                        MainForm.Show()
                        RefreshForm()
                    ElseIf aDatarow("supervisor_ID") = 201 Then
                        MainForm.ManagerMode()
                        MainForm.Show()
                        RefreshForm()
                    ElseIf aDatarow("supervisor_ID") = 301 Then
                        MainForm.AccountMode()
                        MainForm.Show()
                        RefreshForm()
                    ElseIf aDatarow("supervisor_ID") = 302 Then
                        MainForm.AdoptionMode()
                        MainForm.Show()
                        RefreshForm()
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub LoginCancelButton_Click(sender As Object, e As EventArgs) Handles LoginCancelButton.Click
        Me.Close() 'closes the program
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        ForgotPasswordForm.Show()
    End Sub
    Private Sub SignUpButtonItem_Click(sender As Object, e As EventArgs) Handles SignUpButtonItem.Click
        SignUpForm.ShowDialog()
    End Sub

    Private Sub LoginRefreshButton_Click(sender As Object, e As EventArgs) Handles LoginRefreshButton.Click
        PictureBox1.Image.Dispose()
        code = ""
        CreateImage()
        LoginCaptchaTextBox.Focus()
        LoginCaptchaTextBox.Clear()
    End Sub

    Private Sub CreateImage()
        Dim code As String = GetRandomText()
        Dim bitmap As New Bitmap(200, 50, PixelFormat.Format32bppArgb)
        Dim g As Graphics = Graphics.FromImage(bitmap)
        Dim pen As New Pen(Color.Yellow)
        Dim rect As New Rectangle(0, 0, 200, 50)
        Dim b As New SolidBrush(Color.Black)
        Dim White As New SolidBrush(Color.White)
        Dim counter As Integer = 0


        g.DrawRectangle(pen, rect)
        g.FillRectangle(b, rect)
        For i As Integer = 0 To code.Length - 1
            g.DrawString(code(i).ToString(), New Font("Georgia", 10 + rand.[Next](14, 18)), White, New PointF(10 + counter, 10))
            counter += 20
        Next
        DrawRandomLines(g)

        If File.Exists(ResourceFilePathPrefix & "tempimage.bmp") Then
            Try
                File.Delete(ResourceFilePathPrefix & "tempimage.bmp")
                bitmap.Save(ResourceFilePathPrefix & "tempimage.bmp")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            bitmap.Save(ResourceFilePathPrefix & "tempimage.bmp")
        End If
        g.Dispose()
        bitmap.Dispose()
        PictureBox1.Image = Image.FromFile(ResourceFilePathPrefix & "tempimage.bmp")
    End Sub
    Private Function GetRandomPoints() As Point()
        Dim points As Point() = {New Point(rand.[Next](10, 150), rand.[Next](10, 150)), New Point(rand.[Next](10, 100), rand.[Next](10, 100))}
        Return points
    End Function
    Private code As String
    Private Function GetRandomText() As String
        Dim randomText As New StringBuilder()
        If [String].IsNullOrEmpty(code) Then
            Dim alphabets As String = "abcdefghijklmnopqrstuvwxyz1234567890"
            Dim r As New Random()
            For j As Integer = 0 To 5
                randomText.Append(alphabets(r.[Next](alphabets.Length)))
            Next
            code = randomText.ToString()
        End If
        Return code
    End Function

    Private Sub DrawRandomLines(ByVal g As Graphics)
        Dim green As New SolidBrush(Color.Green)
        'For Creating Lines on The Captcha
        For i As Integer = 0 To 19
            g.DrawLines(New Pen(green, 2), GetRandomPoints())
        Next
    End Sub
End Class
