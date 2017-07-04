Public Class WelcomeForm
    Public EmpFname As String
    Public EmpLname As String

    Private Sub WelcomeForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        EmpNameLabel.Text = "Welcome" & vbCrLf & " " & vbCrLf & EmpFname & " " & EmpLname
    End Sub
End Class