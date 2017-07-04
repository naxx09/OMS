Imports System.IO

Public Class EditChildForm
    Private DB As New DBAccess
    'Private Ereport As New Report
    Private Sub EditchildForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChildIDTextBox.ReadOnly = True
        '  Dim childid As String
        StatusComboBox.Items.Clear()
        BloodTComboBox.Items.Clear()
        AddChildForm.RefreshForm()
        EduComboBox.Items.Clear()
        PictureBox1.Image = Nothing
        SupervisorNameTextBox.ReadOnly = True

        'supervisor ID
        SupervisorComboBox.Items.Add("--Please select supervisor--")
        SupervisorComboBox.Items.Add("1")
        SupervisorComboBox.Items.Add("2")
        SupervisorComboBox.Items.Add("3")
        SupervisorComboBox.Items.Add("4")
        SupervisorComboBox.Items.Add("5")
        SupervisorComboBox.Items.Add("6")
        SupervisorComboBox.Items.Add("8")
        SupervisorComboBox.Items.Add("9")
        SupervisorComboBox.Items.Add("10")
        SupervisorComboBox.Items.Add("11")
        SupervisorComboBox.SelectedItem = "--Please select supervisor--"

        'take ID from report from
        ChildIDTextBox.Text = ChildrenReport.ChildTextBox.Text
        DB.AddParam("@Child_ID", ChildIDTextBox.Text)
        DB.ExecuteQuery("select * from children where Child_ID Like ?")

        'insert education combobox
        EduComboBox.Items.Add("--Please select Education Level--")
        EduComboBox.Items.Add("Kindergarten")
        EduComboBox.Items.Add("1st grade")
        EduComboBox.Items.Add("2st grade")
        EduComboBox.Items.Add("3st grade")
        EduComboBox.Items.Add("4st grade")
        EduComboBox.Items.Add("5st grade")
        EduComboBox.Items.Add("6st grade")
        EduComboBox.Items.Add("7st grade")
        EduComboBox.Items.Add("8st grade")
        EduComboBox.Items.Add("Freshman")
        EduComboBox.Items.Add("Sophomore")
        EduComboBox.Items.Add("Junior")
        EduComboBox.Items.Add("Senior")
        EduComboBox.SelectedItem = "--Please select Status--"

        'insert status combobox
        StatusComboBox.Items.Insert(0, "--Please select Status--")
        StatusComboBox.Items.Insert(1, "Registered")
        StatusComboBox.Items.Insert(2, "Adopted")
        StatusComboBox.Items.Insert(3, "Leaving")
        StatusComboBox.SelectedIndex = 0

        'insert blood combobox
        BloodTComboBox.Items.Insert(0, "--Please select Blood Type--")
        BloodTComboBox.Items.Insert(1, "A+")
        BloodTComboBox.Items.Insert(2, "A-")
        BloodTComboBox.Items.Insert(3, "B+")
        BloodTComboBox.Items.Insert(4, "B-")
        BloodTComboBox.Items.Insert(5, "AB+")
        BloodTComboBox.Items.Insert(6, "AB-")
        BloodTComboBox.Items.Insert(7, "O+")
        BloodTComboBox.Items.Insert(8, "O-")
        BloodTComboBox.SelectedIndex = 0

        If DB.Exception <> String.Empty Then
            MessageBox.Show("OMS cannot connect with server right now. Please contact with administrator.", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        'load image to picturebox
        Try
            Dim arrimage() As Byte = DB.DBDataTable(0)("photo")
            Dim mstream As New System.IO.MemoryStream(arrimage)
            If Not IsDBNull(DB.DBDataTable.Rows(0).Item("photo")) Then
                PictureBox1.Image = Image.FromStream(mstream)
            End If
        Catch ex As Exception
        End Try

        Try
            SupervisorComboBox.Text = DB.DBDataTable(0) !Employee_Id
            FNTextBox.Text = DB.DBDataTable(0) !firstname
            MNTextBox.Text = DB.DBDataTable(0) !middlename
            LNTextBox.Text = DB.DBDataTable(0) !lastname

            'display gender
            If DB.DBDataTable(0) !gender = "M" Then
                MRadioButton.Checked = True
            ElseIf DB.DBDataTable(0) !gender = "F" Then
                FRadioButton.Checked = True
            Else
                OtherRadioButton.Checked = True
            End If

            DOBDateTimePicker.Value = DB.DBDataTable(0) !DOB
            BioFTextBox.Text = DB.DBDataTable(0) !bio_father
            BioMTextBox.Text = DB.DBDataTable(0) !bio_mother
            AddressForm.StateString = DB.DBDataTable(0) !state
            AddressForm.CityString = DB.DBDataTable(0) !city
            BloodTComboBox.Text = DB.DBDataTable(0) !blood_type
            MedicalRichTextBox.Text = DB.DBDataTable(0) !medical_problems
            EduComboBox.Text = DB.DBDataTable(0) !education_level
            Dim sitem As Integer

            sitem = DB.DBDataTable(0) !status
            Select Case sitem
                Case 0
                    StatusComboBox.Text = "Registered"
                Case 1
                    StatusComboBox.Text = "Adopted"
            End Select

            EnableFields(True)
            comboboxfiled(False)


            DB.AddParam("@supervisorid", SupervisorComboBox.SelectedItem)
            DB.ExecuteQuery("select * from employee where Employee_ID = ?")

            SupervisorNameTextBox.Text = DB.DBDataTable(0)("firstname") & " " & DB.DBDataTable(0)("lastname")

        Catch ex As Exception
        End Try

    End Sub

    Private Sub DeleteCustomer()
        If MessageBox.Show("You are going to delete the selected child. If you select Yes, It will be removed from database. So be a paytion!", "Delete Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
            Exit Sub


        End If
        DB.AddParam("@Child_ID", ChildIDTextBox.Text)
        DB.ExecuteQuery("DELETE FROM children WHERE Child_Id = ? ")

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            MessageBox.Show("OMS cannot connect with server right now. Please contact with administrator.", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub

        End If
        MessageBox.Show("The record has been deleted from the database.", "Delete Completion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)


        DeleteButton.Enabled = False

        'RefreshDataGridView()

    End Sub
    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        DeleteCustomer()
    End Sub
    Private Sub EditSaveButton_Click(sender As Object, e As EventArgs) Handles EditSaveButton.Click
        Dim radiobut As String = Nothing
        Dim ChildStatus As String = 0
        Dim ms As New MemoryStream

        If EditSaveButton.Text = "&Edit" Then
            'Edit mode
            EnableFields(False)
            comboboxfiled(True)

            EditSaveButton.Text = "&Save"
        Else
            If MRadioButton.Checked = True Then
                radiobut = "M"
            ElseIf FRadioButton.Checked = True Then
                radiobut = "F"
            ElseIf OtherRadioButton.Checked = True Then
                radiobut = "O"
            Else
                radiobut = String.Empty
            End If

            If StatusComboBox.SelectedItem = "Registered" Then
                ChildStatus = 0
            ElseIf StatusComboBox.SelectedItem = "Adopted" Then
                ChildStatus = 1
            ElseIf StatusComboBox.SelectedItem = "Adopted" Then
                ChildStatus = 2
            Else
                ChildStatus = String.Empty
            End If

            If AddressForm.StateString = String.Empty Or AddressForm.CityString = String.Empty Then
                MessageBox.Show("Address is not valid. Please Click 'Add Address' button to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                AddressButton.Focus()
                Exit Sub

                'add gender
            ElseIf radiobut = String.Empty Then
                MessageBox.Show("Please select child gender", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                FRadioButton.Focus()
                Exit Sub
            ElseIf StatusComboBox.SelectedItem = "--Please select Status--" Or StatusComboBox.Text = String.Empty Or ChildStatus = String.Empty Then
                MessageBox.Show("Please select child status", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                StatusComboBox.Focus()
                Exit Sub
            Else

                DB.AddParam("@Employee_ID", SupervisorComboBox.SelectedItem)
                DB.AddParam("@firstname", FNTextBox.Text)
                DB.AddParam("@middlename", MNTextBox.Text)
                DB.AddParam("@lastname", LNTextBox.Text)
                DB.AddParam("@gender", radiobut)
                DB.AddParam("@DOB", DOBDateTimePicker.Value)
                DB.AddParam("@state", AddressForm.StateString)
                DB.AddParam("@city", AddressForm.CityString)
                DB.AddParam("@bio_father", BioFTextBox.Text)
                DB.AddParam("@bio_mother", BioMTextBox.Text)

                'update child photo
                Try
                    PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
                Catch ex As NullReferenceException
                Catch ex As Exception
                End Try
                Dim Buffer(CInt(ms.Length - 1)) As Byte
                ms.Position = 0
                ms.Read(Buffer, 0, CInt(ms.Length))
                ms.Close()
                Try
                    DB.AddParam("@photo", Buffer)

                Catch ex As Exception

                End Try
                DB.AddParam("@blood_type", BloodTComboBox.SelectedItem)
                DB.AddParam("@medical_problems", MedicalRichTextBox.Text)
                DB.AddParam("@education_level", EduComboBox.SelectedItem)
                DB.AddParam("@status", ChildStatus)

                DB.AddParam("@Child_ID", ChildIDTextBox.Text)

                DB.ExecuteQuery("UPDATE children SET Employee_ID = ?, firstname = ?, middlename = ?, lastname = ?, gender = ?, DOB = ?, state = ?, city = ?, bio_father = ?, bio_mother = ?, photo = ?, blood_type = ?, medical_problems = ?, education_level = ?, status = ? WHERE Child_ID = ?")
                If DB.Exception <> String.Empty Then
                    MessageBox.Show("OMS cannot connect with server right now. Please contact with administrator.", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Sub
                Else
                    MessageBox.Show("Children is updated successfully.")

                    EnableFields(True)
                    comboboxfiled(False)
                    EditSaveButton.Text = "&Edit"
                    'save mode
                End If
            End If
        End If
    End Sub
    Private Sub EnableFields(Switch As Boolean)
        FNTextBox.ReadOnly = Switch
        MNTextBox.ReadOnly = Switch
        LNTextBox.ReadOnly = Switch
        BioFTextBox.ReadOnly = Switch
        BioMTextBox.ReadOnly = Switch
    End Sub
    Private Sub comboboxfiled(cc As Boolean)
        SupervisorComboBox.Enabled = cc
        DOBDateTimePicker.Enabled = cc
        BloodTComboBox.Enabled = cc
        StatusComboBox.Enabled = cc
        EduComboBox.Enabled = cc
        BrowseButton.Enabled = cc
        DeleteButton.Enabled = cc
        AddressButton.Enabled = cc
        SupervisorNameTextBox.Enabled = cc
        FRadioButton.Enabled = cc
        MRadioButton.Enabled = cc
        OtherRadioButton.Enabled = cc
        MedicalRichTextBox.Enabled = cc

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        DB.ExecuteQuery("SELECT * FROM children")
        If DB.Exception <> String.Empty Then
            MessageBox.Show("OMS cannot connect with server right now. Please contact with administrator.", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub

        End If
        ChildrenReport.ChildrenDataGridView.DataSource = DB.DBDataTable

        EditSaveButton.Text = "&Edit"
        Me.Close()
    End Sub

    Private Sub BrowseButton_Click(sender As Object, e As EventArgs) Handles BrowseButton.Click
        Me.OpenFileDialog1.FileName = Nothing
        Me.OpenFileDialog1.ShowDialog()
        If Not Me.OpenFileDialog1.FileName = Nothing Then
            Me.PictureBox1.ImageLocation = Me.OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub AddressButton_Click(sender As Object, e As EventArgs) Handles AddressButton.Click
        AddressForm.StreetLabel.Visible = False
        AddressForm.LabelX6.Visible = False
        AddressForm.Address1TextBox.Visible = False
        AddressForm.AddressString = "123 Example St"
        AddressForm.ShowDialog()
    End Sub

    Private Sub SupervisorComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles SupervisorComboBox.SelectedValueChanged
        Try
            DB.AddParam("@Employee_ID", SupervisorComboBox.SelectedItem)
            DB.ExecuteQuery("select * from employee where Employee_ID = ?")
            SupervisorNameTextBox.Text = DB.DBDataTable(0)("firstname") & " " & DB.DBDataTable(0)("lastname")
        Catch ex As Exception
            MessageBox.Show("Supervisor is not found. Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SupervisorComboBox.Focus()
            Exit Sub
        End Try
    End Sub
End Class