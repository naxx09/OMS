Imports System.ComponentModel
Imports System.Net.Mail
Public Class AddAdoptionForm
    Private DB As New DBAccess
    Public faemail As String
    Public moemail As String

    Private childstatus As String

    Private Sub RefreshForm()
        AdoptionIDTextBox.Clear()
        ChildIDTextBox.Clear()
        SupervisorIDTextBox.Clear()
        CFnameTextBox.Clear()
        CMnameTextBox.Clear()
        LNameTextBox.Clear()
        DateTimePicker1.Value = Nothing
        SNameTextBox.Clear()
        SPositonTextBox.Clear()
        FatherIDTextBox.Clear()
        FFnameTextBox.Clear()
        FLnameTextBox.Clear()
        FPhoneTextBox.Clear()
        FAgeTextBox.Clear()
        MotherIDTextBox.Clear()
        MFNameTextBox.Clear()
        MLNameTextBox.Clear()
        MPhoneTextBox.Clear()
        MageTextBox.Clear()
        FatherEmailTextBox.Clear()
        MotherEmailTextBox.Clear()
    End Sub
    Private Sub applicaitonDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ApplicaitonDataGridView.CellClick
        RefreshForm()
        Dim ParentINT As Integer
        EmailButton.Enabled = True
        Try
            AdoptionIDTextBox.Text = ApplicaitonDataGridView.Item(0, e.RowIndex).Value
            ChildIDTextBox.Text = ApplicaitonDataGridView.Item(1, e.RowIndex).Value
            SupervisorIDTextBox.Text = ApplicaitonDataGridView.Item(2, e.RowIndex).Value
            ParentINT = ApplicaitonDataGridView.Item(3, e.RowIndex).Value

            readonlyappfield(True)
            'enable

            DB.AddParam("@ChildID", ChildIDTextBox.Text)
            DB.ExecuteQuery("Select*FROM children Where Child_Id Like?")
            childstatus = DB.DBDataTable(0) !child_ID
            If DB.Exception <> String.Empty Then
                MessageBox.Show("OMS cannot connect with server right now. Please contact with administrator.", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If
            CFnameTextBox.Text = DB.DBDataTable(0) !firstname
            CMnameTextBox.Text = DB.DBDataTable(0) !middlename
            LNameTextBox.Text = DB.DBDataTable(0) !lastname
            DateTimePicker1.Value = DB.DBDataTable(0) !DOB

            DB.DBDataTable.Clear()



            DB.AddParam("@employeeid", SupervisorIDTextBox.Text)
            DB.ExecuteQuery("Select * FROM employee Where Employee_ID=?")
            If DB.Exception <> String.Empty Then
                MessageBox.Show("OMS cannot connect with server right now. Please contact with administrator.", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub

            End If

            SNameTextBox.Text = DB.DBDataTable(0) !firstname & ". " & DB.DBDataTable(0) !lastname
            SPositonTextBox.Text = DB.DBDataTable(0) !position

            DB.AddParam("@parient", ParentINT)
            DB.ExecuteQuery("Select * FROM relation Where relation_ID=?")
            Dim fatherid As Integer
            Dim motherid As Integer
            fatherid = DB.DBDataTable(0) !Father_ID
            motherid = DB.DBDataTable(0) !Mother_ID
            faemail = fatherid
            moemail = motherid

            DB.AddParam("@fatherid", fatherid)
            DB.ExecuteQuery("Select * FROM member Where member_ID=?")
            FatherIDTextBox.Text = DB.DBDataTable(0) !member_id
            FFnameTextBox.Text = DB.DBDataTable(0) !firstname
            FLnameTextBox.Text = DB.DBDataTable(0) !lastname
            FPhoneTextBox.Text = DB.DBDataTable(0) !phone
            FatherEmailTextBox.Text = DB.DBDataTable(0) !email
            Dim fbirthday As DateTime
            fbirthday = DB.DBDataTable(0) !DOB
            FAgeTextBox.Text = DateDiff(DateInterval.Year, fbirthday, Now)


            DB.AddParam("@motherid", motherid)
            DB.ExecuteQuery("Select * FROM member Where member_ID=?")
            MotherIDTextBox.Text = DB.DBDataTable(0) !member_id
            MFNameTextBox.Text = DB.DBDataTable(0) !firstname
            MLNameTextBox.Text = DB.DBDataTable(0) !lastname
            MPhoneTextBox.Text = DB.DBDataTable(0) !phone
            MotherEmailTextBox.Text = DB.DBDataTable(0) !email

            Dim mbirthday As DateTime
            mbirthday = DB.DBDataTable(0) !DOB
            MageTextBox.Text = DateDiff(DateInterval.Year, mbirthday, Now)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub NewAdoption_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplicaitonDataGridView.ReadOnly = True
        EmailButton.Enabled = False
        readonlyappfield(False)
        DB.ExecuteQuery("SELECT * FROM adoption")
        If DB.Exception <> String.Empty Then
            MessageBox.Show("OMS cannot connect with server right now. Please contact with administrator.", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub

        End If
        ApplicaitonDataGridView.DataSource = DB.DBDataTable
    End Sub



    Private Sub readonlyappfield(Switch As Boolean)
        AdoptionIDTextBox.ReadOnly = Switch
        ChildIDTextBox.ReadOnly = Switch
        SupervisorIDTextBox.ReadOnly = Switch
        FatherIDTextBox.ReadOnly = Switch
        MotherIDTextBox.ReadOnly = Switch
        CFnameTextBox.ReadOnly = Switch
        CMnameTextBox.ReadOnly = Switch
        LNameTextBox.ReadOnly = Switch
        LNameTextBox.ReadOnly = Switch
        FFnameTextBox.ReadOnly = Switch
        FLnameTextBox.ReadOnly = Switch
        FAgeTextBox.ReadOnly = Switch
        FPhoneTextBox.ReadOnly = Switch
        MFNameTextBox.ReadOnly = Switch
        MLNameTextBox.ReadOnly = Switch
        MageTextBox.ReadOnly = Switch
        MPhoneTextBox.ReadOnly = Switch
        SNameTextBox.ReadOnly = Switch
        SPositonTextBox.ReadOnly = Switch
        FatherEmailTextBox.ReadOnly = Switch
        MotherEmailTextBox.ReadOnly = Switch
    End Sub

    Private Sub CreateSaveButton_Click(sender As Object, e As EventArgs) Handles CreateSaveButton.Click

        If CreateSaveButton.Text = "&Create" Then
            'Edit mode
            clearappfield()
            EmailButton.Enabled = True
            readonlyappfield(True)
            AdoptionIDTextBox.ReadOnly = True
            ChildIDTextBox.ReadOnly = False
            SupervisorIDTextBox.ReadOnly = False
            FatherIDTextBox.ReadOnly = False
            MotherIDTextBox.ReadOnly = False


            CreateSaveButton.Text = "&Save"
        Else

            DB.AddParam("@fatherID", FatherIDTextBox.Text)
            DB.ExecuteQuery("Select * FROM relation Where father_ID=?")
            If DB.RecordCount = 0 Then

                DB.AddParam("@fatherID", FatherIDTextBox.Text)
                DB.AddParam("@motherID", MotherIDTextBox.Text)

                DB.ExecuteQuery("INSERT INTO relation (father_ID, mother_ID) values (?,?)")
            Else
            End If


            If DB.Exception <> String.Empty Then
                MessageBox.Show("OMS cannot connect with server right now. Please contact with administrator.", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            Else
                DB.AddParam("@fatherID", FatherIDTextBox.Text)
                DB.ExecuteQuery("Select * FROM relation Where father_ID=?")
                Dim relationID As Integer
                relationID = DB.DBDataTable(0) !relation_ID

                DB.AddParam("@childID", ChildIDTextBox.Text)
                DB.AddParam("@supervisorID", SupervisorIDTextBox.Text)
                DB.AddParam("@relaitonID", relationID)
                DB.AddParam("@date", DateDateTimePicker.Value.Date)
                ', parents_I""D
                DB.ExecuteQuery("INSERT INTO adoption ( child_ID, Employee_ID,parents_ID, date) values (?,?,?,?)")

                ' DB.AddParam("@childid", childstatus)
                'DB.ExecuteQuery("update children set status=1 Where child_ID=?")


                If DB.Exception <> String.Empty Then
                    MessageBox.Show("OMS cannot connect with server right now. Please contact with administrator.", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Sub
                Else
                    MessageBox.Show("Adoption is updated successfully.")

                    readonlyappfield(True)
                    CreateSaveButton.Text = "&Create"
                    'save mode
                End If
            End If

        End If
    End Sub
    Private Sub clearappfield()
        AdoptionIDTextBox.Clear()

        ChildIDTextBox.Clear()
        SupervisorIDTextBox.Clear()
        FatherIDTextBox.Clear()
        MotherIDTextBox.Clear()
        CFnameTextBox.Clear()
        CMnameTextBox.Clear()
        LNameTextBox.Clear()
        LNameTextBox.Clear()
        FFnameTextBox.Clear()
        FLnameTextBox.Clear()
        FAgeTextBox.Clear()
        FPhoneTextBox.Clear()
        MFNameTextBox.Clear()
        MLNameTextBox.Clear()
        MageTextBox.Clear()
        MPhoneTextBox.Clear()
        SNameTextBox.Clear()
        SPositonTextBox.Clear()

    End Sub

    Private Sub sendemail(EmailAddress As String)

        Dim UserName As String = "orphanage635@gmail.com"
        Dim mail As MailMessage = New MailMessage

        mail.From = New MailAddress(UserName)
        mail.To.Add(New MailAddress(EmailAddress))
        mail.Subject = "Adoption Comfirmation"
        mail.Body = "Congratulation! Your adoption process has completed. "

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

        'orphanage635@gmail.com
        'password: initpass

    End Sub

    Private Sub ChildIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles ChildIDTextBox.TextChanged
        Try
            DB.AddParam("@Child_ID", ChildIDTextBox.Text)
            DB.ExecuteQuery("Select * FROM children Where Child_ID Like?")
            childstatus = DB.DBDataTable(0) !child_ID
            CFnameTextBox.Text = DB.DBDataTable(0) !firstname
            CMnameTextBox.Text = DB.DBDataTable(0) !middlename
            LNameTextBox.Text = DB.DBDataTable(0) !lastname
            DateTimePicker1.Value = DB.DBDataTable(0) !DOB
        Catch ex As Exception
            ChildIDTextBox.Clear()
            CFnameTextBox.Clear()
            CMnameTextBox.Clear()
            LNameTextBox.Clear()
            DateTimePicker1.Value = Nothing
        End Try
    End Sub

    Private Sub FatherIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles FatherIDTextBox.TextChanged
        Try
            DB.AddParam("@Member_ID", FatherIDTextBox.Text)
            DB.ExecuteQuery("Select * FROM member Where Member_ID = ?")
            FatherIDTextBox.Text = DB.DBDataTable(0) !member_id
            FFnameTextBox.Text = DB.DBDataTable(0) !firstname
            FLnameTextBox.Text = DB.DBDataTable(0) !lastname
            FPhoneTextBox.Text = DB.DBDataTable(0) !phone
            FatherEmailTextBox.Text = DB.DBDataTable(0) !email
            Dim fbirthday As DateTime
            fbirthday = DB.DBDataTable(0) !DOB
            FAgeTextBox.Text = DateDiff(DateInterval.Year, fbirthday, Now)
        Catch ex As Exception
            FatherIDTextBox.Clear()
            FFnameTextBox.Clear()
            FLnameTextBox.Clear()
            FPhoneTextBox.Clear()
            FAgeTextBox.Clear()
            FatherEmailTextBox.Clear()
        End Try
    End Sub

    Private Sub MotherIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles MotherIDTextBox.TextChanged
        Try
            DB.AddParam("@Member_ID", MotherIDTextBox.Text)
            DB.ExecuteQuery("Select * FROM member Where Member_ID=?")
            MotherIDTextBox.Text = DB.DBDataTable(0) !member_id
            MFNameTextBox.Text = DB.DBDataTable(0) !firstname
            MLNameTextBox.Text = DB.DBDataTable(0) !lastname
            MPhoneTextBox.Text = DB.DBDataTable(0) !phone
            MotherEmailTextBox.Text = DB.DBDataTable(0) !email
            Dim mbirthday As DateTime
            mbirthday = DB.DBDataTable(0) !DOB
            MageTextBox.Text = DateDiff(DateInterval.Year, mbirthday, Now)

        Catch ex As Exception
            MotherIDTextBox.Clear()
            MFNameTextBox.Clear()
            MLNameTextBox.Clear()
            MPhoneTextBox.Clear()
            MageTextBox.Clear()
            MotherEmailTextBox.Clear()
        End Try
    End Sub

    Private Sub SupervisorIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles SupervisorIDTextBox.TextChanged
        Try
            DB.AddParam("@Employee_ID", SupervisorIDTextBox.Text)
            DB.ExecuteQuery("Select * FROM employee Where Employee_ID = ?")
            SPositonTextBox.Text = DB.DBDataTable(0) !position
            SNameTextBox.Text = DB.DBDataTable(0) !firstname & "" & DB.DBDataTable(0) !lastname
        Catch ex As Exception
            SupervisorIDTextBox.Clear()
            SPositonTextBox.Clear()
            SNameTextBox.Clear()
        End Try
    End Sub



    Private Sub EmailButton_Click(sender As Object, e As EventArgs) Handles EmailButton.Click
        Try
            sendemail(FatherEmailTextBox.Text.ToString)
            sendemail(MotherEmailTextBox.Text.ToString)
        Catch ex As Exception
            MessageBox.Show("OMS cannot send email to parents. Please contact with administrator", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End Try

        DB.AddParam("@Child_ID", childstatus)
        DB.ExecuteQuery("update children set status = 1 where Child_ID=?")
        If DB.Exception <> String.Empty Then
            MessageBox.Show("OMS cannot connect with server right now. Please contact with administrator.", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        Else
            MessageBox.Show("Children status updated successfully.")
        End If

    End Sub
    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        ApplicaitonDataGridView.ReadOnly = True
        EmailButton.Enabled = False
        readonlyappfield(True)
        DB.ExecuteQuery("SELECT * FROM adoption")
        If DB.Exception <> String.Empty Then
            MessageBox.Show("OMS cannot connect with server right now. Please contact with administrator.", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        ApplicaitonDataGridView.DataSource = DB.DBDataTable

    End Sub
End Class