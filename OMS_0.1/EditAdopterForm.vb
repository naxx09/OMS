Imports System.ComponentModel

Public Class EditAdopterForm
    Private DB As New DBAccess


    Private Sub Adopter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clear()
        GenderComboBox.Items.Clear()
        MarriageComboBox.Items.Clear()


        GenderComboBox.Items.Insert(0, "Select")
        GenderComboBox.Items.Insert(1, "M")
        GenderComboBox.Items.Insert(2, "F")
        GenderComboBox.Items.Insert(3, "O")
        GenderComboBox.SelectedItem = "Select"
        'insert statuscombox 
        MarriageComboBox.Items.Insert(0, "Select")
        MarriageComboBox.Items.Insert(1, "Y")
        MarriageComboBox.Items.Insert(2, "N")
        MarriageComboBox.SelectedItem = "Select"

        If AdopterReport.AdopterTextBox.Text <> "" Then

            EditsaveButton.Enabled = True
            EnableFields(True)
            enablebox(False)
            AdopterTextBox.ReadOnly = True
            '  Dim childid As String
            AdopterTextBox.Text = AdopterReport.AdopterTextBox.Text
            DB.AddParam("@adopterID", AdopterTextBox.Text)
            DB.ExecuteQuery("Select * FROM member Where Member_ID Like?")
            'take ID from report from
            If DB.Exception <> String.Empty Then
                MessageBox.Show("OMS cannot connect with server right now. Please contact with administrator.", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub

            End If

            EmployeeIdTextBox.Text = DB.DBDataTable(0) !employee_id
            FNameTextBox.Text = DB.DBDataTable(0) !firstname
            LNameTextBox.Text = DB.DBDataTable(0) !lastname
            GenderComboBox.SelectedItem = DB.DBDataTable(0) !gender
            DateTimePicker1.Value = DB.DBDataTable(0) !DOB
            AddressForm.AddressString = DB.DBDataTable(0) !address

            AddressForm.CityString = DB.DBDataTable(0) !city
            EmailTextBox.Text = DB.DBDataTable(0) !email
            AddressForm.StateString = DB.DBDataTable(0) !state
            PhoneTextBox.Text = DB.DBDataTable(0) !phone
            IncomeTextBox.Text = DB.DBDataTable(0) !income

            MarriageComboBox.SelectedItem = DB.DBDataTable(0) !marriage

            If DB.DBDataTable(0) !criminal_history = "Y" Then
                CheckBox1.Checked = True
            Else
                CheckBox1.Checked = False
            End If

        Else

            EnableFields(False)
            enablebox(True)

        End If
    End Sub
    Private Sub Addadopter()
        Dim criminalHis As String
        If CheckBox1.Checked = True Then
            criminalHis = "Y"
        Else
            criminalHis = "N"
        End If
        If AddressForm.AddressString = String.Empty Or AddressForm.StateString = String.Empty Or AddressForm.CityString = String.Empty Then
            MessageBox.Show("Address is not valid. Please Click 'Add Address' button to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            AddressButton.Focus()
        Else
            DB.AddParam("@member_type", "adopter")
            DB.AddParam("@Employee_id", EmployeeIdTextBox.Text)
            DB.AddParam("@firstname", FNameTextBox.Text)
            DB.AddParam("@lastname", LNameTextBox.Text)
            DB.AddParam("@gender", GenderComboBox.SelectedItem)
            DB.AddParam("@DOB", DateTimePicker1.Value)
            DB.AddParam("@address", AddressForm.AddressString)
            DB.AddParam("@city", AddressForm.StateString)
            DB.AddParam("@state", AddressForm.CityString)
            DB.AddParam("@phone", PhoneTextBox.Text)
            DB.AddParam("@income", IncomeTextBox.Text)
            DB.AddParam("@email", EmailTextBox.Text)
            DB.AddParam("@marriage", MarriageComboBox.SelectedItem)
            DB.AddParam("@criminal", criminalHis)

            DB.ExecuteQuery("INSERT INTO member(member_type, Employee_id, firstname, lastname, gender, DOB, address, city, state, phone, income, email, marriage, criminal_history) VALUES(?,?,?,?,?,?,?,?,?,?,?,?,?,?)")

            If DB.Exception <> String.Empty Then
                MessageBox.Show(DB.Exception)
                MessageBox.Show("OMS cannot connect with server right now. Please contact with administrator.", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub

            End If
            MessageBox.Show("A new adopter is added successfully")
            Me.Close()
        End If
    End Sub
    Private Sub EditsaveButton_Click(sender As Object, e As EventArgs) Handles EditsaveButton.Click


        Dim criminalHis As String
        If CheckBox1.Checked = True Then
            criminalHis = "Y"
        Else
            criminalHis = "N"
        End If
        If EditsaveButton.Text = "&Edit" Then
            'Edit mode
            EnableFields(False)
            enablebox(True)

            EditsaveButton.Text = "&Update"
        Else
            If AddressForm.AddressString = String.Empty Or AddressForm.StateString = String.Empty Or AddressForm.CityString = String.Empty Then
                MessageBox.Show("Address is not valid. Please Click 'Add Address' button to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                AddressButton.Focus()
            Else
                DB.AddParam("@employee_id", EmployeeIdTextBox.Text)
                DB.AddParam("@firstname", FNameTextBox.Text)
                DB.AddParam("@lastname", LNameTextBox.Text)
                DB.AddParam("@gender", GenderComboBox.SelectedItem)
                DB.AddParam("@DOB", DateTimePicker1.Value.Date)
                DB.AddParam("@address", AddressForm.AddressString)
                DB.AddParam("@city", AddressForm.CityString)
                DB.AddParam("@state", AddressForm.StateString)
                DB.AddParam("@phone", PhoneTextBox.Text)
                DB.AddParam("@income", IncomeTextBox.Text)
                DB.AddParam("@email", EmailTextBox.Text)
                DB.AddParam("@marriage", MarriageComboBox.SelectedItem)
                DB.AddParam("@criminal_history", criminalHis)

                DB.AddParam("@Member_id", AdopterTextBox.Text)
                DB.ExecuteQuery("update member set employee_id = ?, firstname = ?, lastname = ?, gender = ?, DOB = ?, address = ?, city = ?, state = ?, phone = ?, income = ?, email = ?, marriage = ?, criminal_history = ? where Member_id = ?")
                If DB.Exception <> String.Empty Then
                    MessageBox.Show(DB.Exception)
                    MessageBox.Show("OMS cannot connect with server right now. Please contact with administrator.", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Sub
                Else
                    MessageBox.Show("adopter is updated successfully.")

                    EnableFields(True)
                    enablebox(False)
                    EditsaveButton.Text = "&Edit"
                    'save mode
                End If
            End If
        End If
    End Sub
    Friend Sub EnableFields(Switch As Boolean)
        EmployeeIdTextBox.ReadOnly = Switch
        FNameTextBox.ReadOnly = Switch
        LNameTextBox.ReadOnly = Switch
        PhoneTextBox.ReadOnly = Switch
        IncomeTextBox.ReadOnly = Switch
        EmailTextBox.ReadOnly = Switch
    End Sub

    Friend Sub enablebox(switch As Boolean)

        GenderComboBox.Enabled = switch
        MarriageComboBox.Enabled = switch
        DateTimePicker1.Enabled = switch
        AddressButton.Enabled = switch
        CheckBox1.Enabled = switch
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        GenderComboBox.Items.Clear()

        MarriageComboBox.Items.Clear()
        EditsaveButton.Text = "&Edit"
        'saveButton.Visible = True
        'EditsaveButton.Visible = True
        clear()
        DB.ExecuteQuery("select * from member where member_type= 'adopter' ")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            MessageBox.Show("OMS cannot connect with server right now. Please contact with administrator.", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub

        End If
        AdopterReport.AdopterDataGridView.DataSource = DB.DBDataTable

        AdopterReport.EditButton.Enabled = False
        Me.Close()
    End Sub

    Private Sub saveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Addadopter()
        EnableFields(True)
        DB.ExecuteQuery("SELECT * FROM member Where member_type= 'adopter' ")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            MessageBox.Show("OMS cannot connect with server right now. Please contact with administrator.", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        AdopterReport.AdopterDataGridView.DataSource = DB.DBDataTable
    End Sub

    Friend Sub clear()
        AdopterTextBox.Clear()
        EmployeeIdTextBox.Clear()
        FNameTextBox.Clear()
        LNameTextBox.Clear()
        GenderComboBox.ResetText()
        DateTimePicker1.Value = DateTime.Now
        PhoneTextBox.Clear()
        IncomeTextBox.Clear()
        EmailTextBox.Clear()
        MarriageComboBox.ResetText()
        CheckBox1.Checked = False
    End Sub

    Private Sub AddressButton_Click(sender As Object, e As EventArgs) Handles AddressButton.Click
        AddressForm.ShowDialog()
    End Sub

    Private Sub EditAdopterForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        EnableFields(True)
        enablebox(False)
        EditsaveButton.Text = "&Edit"
    End Sub
End Class