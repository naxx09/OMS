
Imports System.IO
Imports System.ComponentModel

Public Class AddChildForm
    Private DB As New DBAccess
    Friend Sub RefreshForm()
        SUPComboBox.Text = String.Empty
        SNameTextBox.Clear()
        FNTextBox.Clear()
        MNTextBox.Clear()
        LNTextBox.Clear()
        DOBDateTimePicker.Value = DateTime.Now
        StateComboBox.SelectedItem = "--Please select state--"
        With CityComboBox
            .Items.Clear()
            .Items.Add("--Please select city--")
            .SelectedItem = "--Please select city--"
        End With
        medicalRichTextBox.Clear()
        PictureBox1.Image = Nothing
        BioFTextBox.Clear()
        BioMTextBox.Clear()
        BloodTComboBox.SelectedItem = "--Please select Type--"
        EduComboBox.SelectedItem = "--Please select Status--"
    End Sub

    Private Sub ChildApplicationvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'insert status combobox
        StatusComboBox.Items.Insert(0, "--Please select Status--")
        StatusComboBox.Items.Insert(1, "Registered")
        StatusComboBox.Items.Insert(2, "Adopted")
        StatusComboBox.Items.Insert(3, "Leaving")
        StatusComboBox.SelectedIndex = 0
        '--------------------
        StatusComboBox.Enabled = True

        SUPComboBox.Items.Add("5")

        StateComboBox.Items.Add("--Please select state--")
        StateComboBox.Items.Add("AN")
        StateComboBox.Items.Add("AP")
        StateComboBox.Items.Add("AR")
        StateComboBox.Items.Add("AS")
        StateComboBox.Items.Add("BR")
        StateComboBox.Items.Add("CG")
        StateComboBox.Items.Add("CH")
        StateComboBox.Items.Add("DD")
        StateComboBox.Items.Add("DH")
        StateComboBox.Items.Add("DL")
        StateComboBox.Items.Add("GA")
        StateComboBox.Items.Add("GJ")
        StateComboBox.Items.Add("HR")
        StateComboBox.Items.Add("HP")
        StateComboBox.Items.Add("JK")
        StateComboBox.Items.Add("JH")
        StateComboBox.Items.Add("KA")
        StateComboBox.Items.Add("KL")
        StateComboBox.Items.Add("LD")
        StateComboBox.Items.Add("MP")
        StateComboBox.Items.Add("MH")
        StateComboBox.Items.Add("MN")
        StateComboBox.Items.Add("ML")
        StateComboBox.Items.Add("MZ")
        StateComboBox.Items.Add("NL")
        StateComboBox.Items.Add("OR")
        StateComboBox.Items.Add("PB")
        StateComboBox.Items.Add("PY")
        StateComboBox.Items.Add("RJ")
        StateComboBox.Items.Add("SK")
        StateComboBox.Items.Add("TN")
        StateComboBox.Items.Add("TR")
        StateComboBox.Items.Add("TS")
        StateComboBox.Items.Add("UK")
        StateComboBox.Items.Add("UP")
        StateComboBox.Items.Add("WB")
        If StateComboBox.Items.Count > 0 Then
            StateComboBox.SelectedIndex = 0    ' The first item has index 0 '
        End If

        CityComboBox.Items.Add("--Please select city--")
        If CityComboBox.Items.Count > 0 Then
            CityComboBox.SelectedIndex = 0    ' The first item has index 0 '
        End If

        '2. CHANG BOOLDY TYPE-----------------------
        BloodTComboBox.Items.Insert(0, "--Please select Blood Type--")
        BloodTComboBox.Items.Insert(1, "A+")
        BloodTComboBox.Items.Insert(2, "A-")
        BloodTComboBox.Items.Insert(3, "B+")
        BloodTComboBox.Items.Insert(4, "B-")
        BloodTComboBox.Items.Insert(5, "AB+")
        BloodTComboBox.Items.Insert(6, "AB-")
        BloodTComboBox.Items.Insert(7, "O+")
        BloodTComboBox.Items.Insert(8, "O-")

        ' insert blood combox
        BloodTComboBox.SelectedIndex = 0


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

        RefreshForm()
    End Sub
    Private Sub AddChildern()
        Dim radiobut As String = Nothing
        Dim ChildStatus As String = 0
        Dim ms As New MemoryStream

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

        If radiobut = String.Empty Then
            MessageBox.Show("Please select child gender", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            FRadioButton.Focus()
            Exit Sub
        ElseIf StatusComboBox.SelectedItem = "--Please select Status--" Or StatusComboBox.Text = String.Empty Or ChildStatus = String.Empty Then
            MessageBox.Show("Please select child status", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            StatusComboBox.Focus()
            Exit Sub
        Else

            DB.AddParam("@Employee_ID", SUPComboBox.SelectedItem)
            DB.AddParam("@firstname", FNTextBox.Text)
            DB.AddParam("@middlename", MNTextBox.Text)
            DB.AddParam("@lastname", LNTextBox.Text)
            DB.AddParam("@gender", radiobut)
            DB.AddParam("@DOB", DOBDateTimePicker.Value)
            DB.AddParam("@state", AddressForm.StateString)
            DB.AddParam("@city", AddressForm.CityString)
            DB.AddParam("@bio_father", BioFTextBox.Text)
            DB.AddParam("@bio_mother", BioMTextBox.Text)
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
            DB.AddParam("@medical_problems", medicalRichTextBox.Text)
            DB.AddParam("@education_level", EduComboBox.SelectedItem)
            DB.AddParam("@status", ChildStatus)

            DB.ExecuteQuery("INSERT INTO children(Employee_ID, firstname, middlename, lastname, gender, DOB,state,city, bio_father, bio_mother, photo, blood_type, medical_problems, education_level, status)VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)")

            If DB.Exception <> String.Empty Then
                MessageBox.Show("OMS cannot connect with server right now. Please contact with administrator.", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            Else
                MessageBox.Show("A new children is added successfully")
            End If

        End If
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        AddChildern()
    End Sub
    Private Sub BrowseButton_Click(sender As Object, e As EventArgs) Handles BrowseButton.Click
        Me.OpenFileDialog1.FileName = Nothing
        Me.OpenFileDialog1.ShowDialog()
        If Not Me.OpenFileDialog1.FileName = Nothing Then
            Me.PictureBox1.ImageLocation = Me.OpenFileDialog1.FileName

        End If
    End Sub

    Private Sub StateComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles StateComboBox.TextChanged
        If StateComboBox.Text = "AN" Then
            CityComboBox.Items.Add("PortBlair")

        ElseIf StateComboBox.Text = "AP" Then
            CityComboBox.Items.Clear()
            CityComboBox.Items.Add("Vishakapatnam")
            CityComboBox.Items.Add("Vijayawada")
            CityComboBox.Items.Add("Guntur")
            CityComboBox.Items.Add("Nellore")
            CityComboBox.Items.Add("Kurnool")
            CityComboBox.Items.Add("Rajahmundry")
            CityComboBox.Items.Add("Tirupati")
            CityComboBox.Items.Add("Kakinada")
            CityComboBox.Items.Add("Kadappa")
            CityComboBox.Items.Add("Anantpur")

        ElseIf StateComboBox.Text = "AR" Then
            CityComboBox.Items.Clear()
            CityComboBox.Items.Add("Itanagar")

        ElseIf StateComboBox.Text = "AS" Then
            CityComboBox.Items.Clear()
            CityComboBox.Items.Add("Guwahati")
            CityComboBox.Items.Add("Silchar")
            CityComboBox.Items.Add("Dibrugarh")
            CityComboBox.Items.Add("Jorhat")
            CityComboBox.Items.Add("Nagaon")
            CityComboBox.Items.Add("Tinsukia")
            CityComboBox.Items.Add("Tezpur")
            CityComboBox.Items.Add("Bongaigaon")
            CityComboBox.Items.Add("Karimganj")
            CityComboBox.Items.Add("Dispur")

        ElseIf StateComboBox.Text = "BR" Then
            CityComboBox.Items.Clear()
            CityComboBox.Items.Add("Patna")
            CityComboBox.Items.Add("Gaya")
            CityComboBox.Items.Add("Bhagalpur")
            CityComboBox.Items.Add("Muzaffarpur")
            CityComboBox.Items.Add("Purnia")
            CityComboBox.Items.Add("Darbhanga")
            CityComboBox.Items.Add("Bihar")
            CityComboBox.Items.Add("Ara")
            CityComboBox.Items.Add("Begusarai")

        ElseIf StateComboBox.Text = "CG" Then
            CityComboBox.Items.Clear()
            CityComboBox.Items.Add("Chandigarh")

        ElseIf StateComboBox.Text = "CH" Then
            CityComboBox.Items.Clear()
            CityComboBox.Items.Add("Raipur")
            CityComboBox.Items.Add("Bhilai")
            CityComboBox.Items.Add("Bilaspur")
            CityComboBox.Items.Add("Korba")
            CityComboBox.Items.Add("Raj Nadagaon")
            CityComboBox.Items.Add("Raigarh")
            CityComboBox.Items.Add("Jagdaipur")
            CityComboBox.Items.Add("Ambikapur")
            CityComboBox.Items.Add("Dhamtari")

        ElseIf StateComboBox.Text = "DD" Then
            CityComboBox.Items.Clear()
            CityComboBox.Items.Add("Dadra")
            CityComboBox.Items.Add("Masat")
            CityComboBox.Items.Add("Naroli")
            CityComboBox.Items.Add("Samaravarni")
            CityComboBox.Items.Add("Silvassa")

        ElseIf StateComboBox.Text = "DH" Then
            CityComboBox.Items.Clear()
            CityComboBox.Items.Add("Daman")
            CityComboBox.Items.Add("Dadhel")
            CityComboBox.Items.Add("Diu")
            CityComboBox.Items.Add("Kachigam")

        ElseIf StateComboBox.Text = "DL" Then
            CityComboBox.Items.Clear()
            CityComboBox.Items.Add("Delhi")
            CityComboBox.Items.Add("Jaffarpur kalan")
            CityComboBox.Items.Add("Qutabgarh")
            CityComboBox.Items.Add("Ujwa")

        ElseIf StateComboBox.Text = "GA" Then
            CityComboBox.Items.Clear()
            CityComboBox.Items.Add("Panaji")
            CityComboBox.Items.Add("Madgaon")
            CityComboBox.Items.Add("Mormugao")

        ElseIf StateComboBox.Text = "GJ" Then
            CityComboBox.Items.Clear()
            CityComboBox.Items.Add("Gandhinagar")
            CityComboBox.Items.Add("Ahmedabad")
            CityComboBox.Items.Add("Surat")
            CityComboBox.Items.Add("Vadodara")
            CityComboBox.Items.Add("Rajkot")
            CityComboBox.Items.Add("Bhavnagar")
            CityComboBox.Items.Add("Jamnagar")
            CityComboBox.Items.Add("Junagadh")
            CityComboBox.Items.Add("Anand")
            CityComboBox.Items.Add("Navsari")
            CityComboBox.Items.Add("Surendranagar")
            CityComboBox.Items.Add("Morvi")

        ElseIf StateComboBox.Text = "HR" Then
            CityComboBox.Items.Clear()
            CityComboBox.Items.Add("Faridabad")
            CityComboBox.Items.Add("Gurgaon")
            CityComboBox.Items.Add("Panipat")
            CityComboBox.Items.Add("Yamunanagar")
            CityComboBox.Items.Add("Rohtak")
            CityComboBox.Items.Add("Hisar")
            CityComboBox.Items.Add("Karnal")
            CityComboBox.Items.Add("Sonipat")
            CityComboBox.Items.Add("Panchkula")
            CityComboBox.Items.Add("Ambala Sadar")

        ElseIf StateComboBox.Text = "HP" Then
            CityComboBox.Items.Clear()
            CityComboBox.Items.Add("Baddi")
            CityComboBox.Items.Add("Chamba")
            CityComboBox.Items.Add("Dharmasala")
            CityComboBox.Items.Add("Kullu")
            CityComboBox.Items.Add("Mandi")
            CityComboBox.Items.Add("Nahan")
            CityComboBox.Items.Add("Paonta Sahib")
            CityComboBox.Items.Add("Shimla")
            CityComboBox.Items.Add("Solan")
            CityComboBox.Items.Add("Sundarnagar")

        ElseIf StateComboBox.Text = "JK" Then
            CityComboBox.Items.Clear()
            CityComboBox.Items.Add("Srinagar")
            CityComboBox.Items.Add("Jammu")
            CityComboBox.Items.Add("Anantnag")
            CityComboBox.Items.Add("Udhampur")
            CityComboBox.Items.Add("Baramula")
            CityComboBox.Items.Add("Sopore")
            CityComboBox.Items.Add("Kathua")
            CityComboBox.Items.Add("Bandipura")
            CityComboBox.Items.Add("Leh")

        ElseIf StateComboBox.Text = "JH" Then
            CityComboBox.Items.Clear()
            CityComboBox.Items.Add("Jamshedpur")
            CityComboBox.Items.Add("Dhanbad")
            CityComboBox.Items.Add("Ranchi")
            CityComboBox.Items.Add("Bokaro Steel City")
            CityComboBox.Items.Add("Deoghar")
            CityComboBox.Items.Add("Phusro")
            CityComboBox.Items.Add("Hazaribag")
            CityComboBox.Items.Add("Giridih")
            CityComboBox.Items.Add("Ramgarh Cantonmnet")
            CityComboBox.Items.Add("Medininagar")
            CityComboBox.Items.Add("Chirkunda")

        ElseIf StateComboBox.Text = "KA" Then
            CityComboBox.Items.Clear()
            CityComboBox.Items.Add("Bengaluru")
            CityComboBox.Items.Add("Mysore")
            CityComboBox.Items.Add("Hubli-Dharwar")
            CityComboBox.Items.Add("Mangalore")
            CityComboBox.Items.Add("Gulbarga")
            CityComboBox.Items.Add("Belgaum")
            CityComboBox.Items.Add("Davanagere")
            CityComboBox.Items.Add("Bellary")
            CityComboBox.Items.Add("Bijapur")
            CityComboBox.Items.Add("Shimoga")
            CityComboBox.Items.Add("Tumkur")

        ElseIf StateComboBox.Text = "KL" Then
            CityComboBox.Items.Clear()
            CityComboBox.Items.Add("Kochi")
            CityComboBox.Items.Add("Kozhikode")
            CityComboBox.Items.Add("Thrissur")
            CityComboBox.Items.Add("Malappuram")
            CityComboBox.Items.Add("Thiruvanathapuram")
            CityComboBox.Items.Add("Kannur")
            CityComboBox.Items.Add("Kollam")
            CityComboBox.Items.Add("Cherthala")
            CityComboBox.Items.Add("Kayamkulam")
            CityComboBox.Items.Add("Kottayam")

        ElseIf StateComboBox.Text = "LD" Then
            CityComboBox.Items.Clear()
            CityComboBox.Items.Add("Amini")
            CityComboBox.Items.Add("Andrott")
            CityComboBox.Items.Add("Kavaratti")
            CityComboBox.Items.Add("Minicoy")

        ElseIf StateComboBox.Text = "MP" Then
            CityComboBox.Items.Clear()
            CityComboBox.Items.Add("Indore")
            CityComboBox.Items.Add("Bhopal")
            CityComboBox.Items.Add("Jabalpur")
            CityComboBox.Items.Add("Gwalior")
            CityComboBox.Items.Add("Ujjain")
            CityComboBox.Items.Add("Sagar")
            CityComboBox.Items.Add("Dewas")
            CityComboBox.Items.Add("Satna")
            CityComboBox.Items.Add("Ratlam")
            CityComboBox.Items.Add("Rewa")

        ElseIf StateComboBox.Text = "MH" Then
            CityComboBox.Items.Clear()
            CityComboBox.Items.Add("Mumbai")
            CityComboBox.Items.Add("Pune")
            CityComboBox.Items.Add("Nagpur")
            CityComboBox.Items.Add("Nashik")
            CityComboBox.Items.Add("Vasai-Virar")
            CityComboBox.Items.Add("Aurangabad")
            CityComboBox.Items.Add("Solapur")
            CityComboBox.Items.Add("Bhiwandi")
            CityComboBox.Items.Add("Amaravati")

        ElseIf StateComboBox.Text = "MN" Then
            CityComboBox.Items.Clear()
            CityComboBox.Items.Add("Imphal")
            CityComboBox.Items.Add("Kakching")
            CityComboBox.Items.Add("Mayang Imphal")
            CityComboBox.Items.Add("Thoubal")
            CityComboBox.Items.Add("Ukhrul")

        ElseIf StateComboBox.Text = "ML" Then
            CityComboBox.Items.Clear()
            CityComboBox.Items.Add("Jowai")
            CityComboBox.Items.Add("Nongston")
            CityComboBox.Items.Add("Shillong")
            CityComboBox.Items.Add("Tura")
            CityComboBox.Items.Add("Williamnagar")

        ElseIf StateComboBox.Text = "MZ" Then
            CityComboBox.Items.Clear()
            CityComboBox.Items.Add("Aizawl")
            CityComboBox.Items.Add("Champhai")
            CityComboBox.Items.Add("Kolasib")
            CityComboBox.Items.Add("Lawngtlai")
            CityComboBox.Items.Add("Lunglei")
            CityComboBox.Items.Add("Saiha")
            CityComboBox.Items.Add("Serchhip")

        ElseIf StateComboBox.Text = "NL" Then
            CityComboBox.Items.Clear()
            CityComboBox.Items.Add("Chumukedima")
            CityComboBox.Items.Add("Dimapur")
            CityComboBox.Items.Add("Kohima")
            CityComboBox.Items.Add("Mokokchung")
            CityComboBox.Items.Add("Mon")
            CityComboBox.Items.Add("Tuensang")
            CityComboBox.Items.Add("Wokha")
            CityComboBox.Items.Add("Zunheboto")

        ElseIf StateComboBox.Text = "OR" Then
            CityComboBox.Items.Clear()
            CityComboBox.Items.Add("Bhubaneshwar")
            CityComboBox.Items.Add("Cuttack")
            CityComboBox.Items.Add("Raurkela")
            CityComboBox.Items.Add("Brahmapur")
            CityComboBox.Items.Add("Sambalpur")
            CityComboBox.Items.Add("Puri")
            CityComboBox.Items.Add("Baleshwar")
            CityComboBox.Items.Add("Bhadrak")
            CityComboBox.Items.Add("Baripada")

        ElseIf StateComboBox.Text = "PB" Then
            CityComboBox.Items.Clear()
            CityComboBox.Items.Add("Ludhiana")
            CityComboBox.Items.Add("Amristar")
            CityComboBox.Items.Add("Jalandhar")
            CityComboBox.Items.Add("Patiala")
            CityComboBox.Items.Add("Bathinda")
            CityComboBox.Items.Add("S.A.S. Nagar")
            CityComboBox.Items.Add("Hoshiarpur")
            CityComboBox.Items.Add("Moga")
            CityComboBox.Items.Add("Pathankot")
            CityComboBox.Items.Add("Batala")

        ElseIf StateComboBox.Text = "PY" Then
            CityComboBox.Items.Clear()
            CityComboBox.Items.Add("Karaikal")
            CityComboBox.Items.Add("Mahe")
            CityComboBox.Items.Add("Puducherry")
            CityComboBox.Items.Add("Yanam")

        ElseIf StateComboBox.Text = "RJ" Then
            CityComboBox.Items.Clear()
            CityComboBox.Items.Add("Jaipur")
            CityComboBox.Items.Add("Jodhpur")
            CityComboBox.Items.Add("Kota")
            CityComboBox.Items.Add("Bikaner")
            CityComboBox.Items.Add("Ajmer")
            CityComboBox.Items.Add("Udaipur")
            CityComboBox.Items.Add("Bhilwara")
            CityComboBox.Items.Add("Alwar")
            CityComboBox.Items.Add("Bharatpur")

        ElseIf StateComboBox.Text = "SK" Then
            CityComboBox.Items.Clear()
            CityComboBox.Items.Add("Gangtok")
            CityComboBox.Items.Add("Jorethang")
            CityComboBox.Items.Add("Namchi")
            CityComboBox.Items.Add("Rangpo")

        ElseIf StateComboBox.Text = "TN" Then
            CityComboBox.Items.Clear()
            CityComboBox.Items.Add("Chennai")
            CityComboBox.Items.Add("Coimbatore")
            CityComboBox.Items.Add("Madurai")
            CityComboBox.Items.Add("Tiruchirapalli")
            CityComboBox.Items.Add("Tiruppur")
            CityComboBox.Items.Add("Salem")
            CityComboBox.Items.Add("Erode")
            CityComboBox.Items.Add("Tirunelveli")
            CityComboBox.Items.Add("Vellore")
            CityComboBox.Items.Add("Thoothukudi")

        ElseIf StateComboBox.Text = "TR" Then
            CityComboBox.Items.Clear()
            CityComboBox.Items.Add("Agartala")
            CityComboBox.Items.Add("Belonia")
            CityComboBox.Items.Add("Bishalgarh")
            CityComboBox.Items.Add("Dharmanagar")
            CityComboBox.Items.Add("Kailashahar")
            CityComboBox.Items.Add("Teliamura")
            CityComboBox.Items.Add("Udaipur")

        ElseIf StateComboBox.Text = "TS" Then
            CityComboBox.Items.Clear()
            CityComboBox.Items.Add("Hyderabad")
            CityComboBox.Items.Add("Warangal")
            CityComboBox.Items.Add("Nizamabad")
            CityComboBox.Items.Add("Karimnagar")
            CityComboBox.Items.Add("Khammam")
            CityComboBox.Items.Add("Ramagundam")
            CityComboBox.Items.Add("Mahbubnagar")
            CityComboBox.Items.Add("Mancherial")
            CityComboBox.Items.Add("Nalgonda")
            CityComboBox.Items.Add("Adilabad")

        ElseIf StateComboBox.Text = "UK" Then
            CityComboBox.Items.Clear()
            CityComboBox.Items.Add("Dehra Dun")
            CityComboBox.Items.Add("Haridwar")
            CityComboBox.Items.Add("Roorkee")
            CityComboBox.Items.Add("Haldwani")
            CityComboBox.Items.Add("Rudrapur")
            CityComboBox.Items.Add("Kashipur")
            CityComboBox.Items.Add("Rishikesh")
            CityComboBox.Items.Add("Pithoragarh")
            CityComboBox.Items.Add("Ramnagar")
            CityComboBox.Items.Add("Kichha")
            CityComboBox.Items.Add("Manglaur")
            CityComboBox.Items.Add("Jaspur")

        ElseIf StateComboBox.Text = "UP" Then
            CityComboBox.Items.Clear()
            CityComboBox.Items.Add("Kanpur")
            CityComboBox.Items.Add("Lucknow")
            CityComboBox.Items.Add("Ghaziabad")
            CityComboBox.Items.Add("Agra")
            CityComboBox.Items.Add("Varanasi")
            CityComboBox.Items.Add("Meerut")
            CityComboBox.Items.Add("Allahabad")
            CityComboBox.Items.Add("Bareilly")
            CityComboBox.Items.Add("Aligarh")
            CityComboBox.Items.Add("Moradabad")

        ElseIf StateComboBox.Text = "WB" Then
            CityComboBox.Items.Clear()
            CityComboBox.Items.Add("Kolkata")
            CityComboBox.Items.Add("Asansol")
            CityComboBox.Items.Add("Shiliguri")
            CityComboBox.Items.Add("Durgapur")
            CityComboBox.Items.Add("Bardhaman")
            CityComboBox.Items.Add("Ingraj Bazar")
            CityComboBox.Items.Add("Baharampur")
            CityComboBox.Items.Add("Habra")
            CityComboBox.Items.Add("Kharagpur")
            CityComboBox.Items.Add("Santipur")

        End If


    End Sub

    Private Sub AddChildForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        RefreshForm()
    End Sub
End Class