Imports System.ComponentModel
Imports System.Text.RegularExpressions

Public Class AddressForm
    'save address string
    Public AddressString As String
    Public StateString As String
    Public CityString As String
    Private SkipFormClosing As Boolean
    Private Sub RefreshForm()
        AddressString = String.Empty
        StateString = String.Empty
        CityString = String.Empty
        Address1TextBox.Clear()
        Address1TextBox.Border.BackColor = Nothing
        EmployeeStateComboBox.SelectedItem = "--Please select state--"
        SkipFormClosing = False
        With EmployeeCityComboBox
            .Items.Clear()
            .Items.Add("--Please select city--")
            .SelectedItem = "--Please select city--"
        End With
        Address1TextBox.Focus()
    End Sub
    Private Sub AddressForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        Address1TextBox.Border.BackColor = Nothing
        SkipFormClosing = False

        'Adds the items in the Employee State combo box
        EmployeeStateComboBox.Items.Add("--Please select state--")
        EmployeeStateComboBox.Items.Add("AN")
        EmployeeStateComboBox.Items.Add("AP")
        EmployeeStateComboBox.Items.Add("AR")
        EmployeeStateComboBox.Items.Add("AS")
        EmployeeStateComboBox.Items.Add("BR")
        EmployeeStateComboBox.Items.Add("CG")
        EmployeeStateComboBox.Items.Add("CH")
        EmployeeStateComboBox.Items.Add("DD")
        EmployeeStateComboBox.Items.Add("DH")
        EmployeeStateComboBox.Items.Add("DL")
        EmployeeStateComboBox.Items.Add("GA")
        EmployeeStateComboBox.Items.Add("GJ")
        EmployeeStateComboBox.Items.Add("HR")
        EmployeeStateComboBox.Items.Add("HP")
        EmployeeStateComboBox.Items.Add("JK")
        EmployeeStateComboBox.Items.Add("JH")
        EmployeeStateComboBox.Items.Add("KA")
        EmployeeStateComboBox.Items.Add("KL")
        EmployeeStateComboBox.Items.Add("LD")
        EmployeeStateComboBox.Items.Add("MP")
        EmployeeStateComboBox.Items.Add("MH")
        EmployeeStateComboBox.Items.Add("MN")
        EmployeeStateComboBox.Items.Add("ML")
        EmployeeStateComboBox.Items.Add("MZ")
        EmployeeStateComboBox.Items.Add("NL")
        EmployeeStateComboBox.Items.Add("OR")
        EmployeeStateComboBox.Items.Add("PB")
        EmployeeStateComboBox.Items.Add("PY")
        EmployeeStateComboBox.Items.Add("RJ")
        EmployeeStateComboBox.Items.Add("SK")
        EmployeeStateComboBox.Items.Add("TN")
        EmployeeStateComboBox.Items.Add("TR")
        EmployeeStateComboBox.Items.Add("TS")
        EmployeeStateComboBox.Items.Add("UK")
        EmployeeStateComboBox.Items.Add("UP")
        EmployeeStateComboBox.Items.Add("WB")

        If EmployeeStateComboBox.Items.Count > 0 Then
            EmployeeStateComboBox.SelectedIndex = 0    ' The first item has index 0 '
        End If
        EmployeeCityComboBox.Items.Add("--Please select city--")
        If EmployeeCityComboBox.Items.Count > 0 Then
            EmployeeCityComboBox.SelectedIndex = 0    ' The first item has index 0 '
        End If

        'edit mode
        If AddressString <> String.Empty Then
            Address1TextBox.Enabled = True
            Address1TextBox.Text = AddressString
            EmployeeStateComboBox.Text = StateString
            EmployeeCityComboBox.Text = CityString
        End If
    End Sub
    Private Sub EmployeeStateComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles EmployeeStateComboBox.SelectedValueChanged

        'Adding all the items in the city combo box according to the conditions of the state combo box

        If EmployeeStateComboBox.SelectedItem = "AN" Then
            EmployeeCityComboBox.Items.Add("PortBlair")
            EmployeeCityComboBox.SelectedItem = "--Please select city--"

        ElseIf EmployeeStateComboBox.SelectedItem = "AP" Then
            EmployeeCityComboBox.Items.Clear()
            EmployeeCityComboBox.Items.Add("--Please select city--")
            EmployeeCityComboBox.Items.Add("Vishakapatnam")
            EmployeeCityComboBox.Items.Add("Vijayawada")
            EmployeeCityComboBox.Items.Add("Guntur")
            EmployeeCityComboBox.Items.Add("Nellore")
            EmployeeCityComboBox.Items.Add("Kurnool")
            EmployeeCityComboBox.Items.Add("Rajahmundry")
            EmployeeCityComboBox.Items.Add("Tirupati")
            EmployeeCityComboBox.Items.Add("Kakinada")
            EmployeeCityComboBox.Items.Add("Kadappa")
            EmployeeCityComboBox.Items.Add("Anantpur")
            EmployeeCityComboBox.SelectedItem = "--Please select city--"

        ElseIf EmployeeStateComboBox.SelectedItem = "AR" Then
            EmployeeCityComboBox.Items.Clear()
            EmployeeCityComboBox.Items.Add("--Please select city--")
            EmployeeCityComboBox.Items.Add("Itanagar")
            EmployeeCityComboBox.SelectedItem = "--Please select city--"

        ElseIf EmployeeStateComboBox.SelectedItem = "AS" Then
            EmployeeCityComboBox.Items.Clear()
            EmployeeCityComboBox.Items.Add("--Please select city--")
            EmployeeCityComboBox.Items.Add("Guwahati")
            EmployeeCityComboBox.Items.Add("Silchar")
            EmployeeCityComboBox.Items.Add("Dibrugarh")
            EmployeeCityComboBox.Items.Add("Jorhat")
            EmployeeCityComboBox.Items.Add("Nagaon")
            EmployeeCityComboBox.Items.Add("Tinsukia")
            EmployeeCityComboBox.Items.Add("Tezpur")
            EmployeeCityComboBox.Items.Add("Bongaigaon")
            EmployeeCityComboBox.Items.Add("Karimganj")
            EmployeeCityComboBox.Items.Add("Dispur")
            EmployeeCityComboBox.SelectedItem = "--Please select city--"

        ElseIf EmployeeStateComboBox.SelectedItem = "BR" Then
            EmployeeCityComboBox.Items.Clear()
            EmployeeCityComboBox.Items.Add("--Please select city--")
            EmployeeCityComboBox.Items.Add("Patna")
            EmployeeCityComboBox.Items.Add("Gaya")
            EmployeeCityComboBox.Items.Add("Bhagalpur")
            EmployeeCityComboBox.Items.Add("Muzaffarpur")
            EmployeeCityComboBox.Items.Add("Purnia")
            EmployeeCityComboBox.Items.Add("Darbhanga")
            EmployeeCityComboBox.Items.Add("Bihar")
            EmployeeCityComboBox.Items.Add("Ara")
            EmployeeCityComboBox.Items.Add("Begusarai")
            EmployeeCityComboBox.SelectedItem = "--Please select city--"

        ElseIf EmployeeStateComboBox.SelectedItem = "CG" Then
            EmployeeCityComboBox.Items.Clear()
            EmployeeCityComboBox.Items.Add("--Please select city--")
            EmployeeCityComboBox.Items.Add("Chandigarh")
            EmployeeCityComboBox.SelectedItem = "--Please select city--"

        ElseIf EmployeeStateComboBox.SelectedItem = "CH" Then
            EmployeeCityComboBox.Items.Clear()
            EmployeeCityComboBox.Items.Add("--Please select city--")
            EmployeeCityComboBox.Items.Add("Raipur")
            EmployeeCityComboBox.Items.Add("Bhilai")
            EmployeeCityComboBox.Items.Add("Bilaspur")
            EmployeeCityComboBox.Items.Add("Korba")
            EmployeeCityComboBox.Items.Add("Raj Nadagaon")
            EmployeeCityComboBox.Items.Add("Raigarh")
            EmployeeCityComboBox.Items.Add("Jagdaipur")
            EmployeeCityComboBox.Items.Add("Ambikapur")
            EmployeeCityComboBox.Items.Add("Dhamtari")
            EmployeeCityComboBox.SelectedItem = "--Please select city--"

        ElseIf EmployeeStateComboBox.SelectedItem = "DD" Then
            EmployeeCityComboBox.Items.Clear()
            EmployeeCityComboBox.Items.Add("--Please select city--")
            EmployeeCityComboBox.Items.Add("Dadra")
            EmployeeCityComboBox.Items.Add("Masat")
            EmployeeCityComboBox.Items.Add("Naroli")
            EmployeeCityComboBox.Items.Add("Samaravarni")
            EmployeeCityComboBox.Items.Add("Silvassa")
            EmployeeCityComboBox.SelectedItem = "--Please select city--"

        ElseIf EmployeeStateComboBox.SelectedItem = "DH" Then
            EmployeeCityComboBox.Items.Clear()
            EmployeeCityComboBox.Items.Add("--Please select city--")
            EmployeeCityComboBox.Items.Add("Daman")
            EmployeeCityComboBox.Items.Add("Dadhel")
            EmployeeCityComboBox.Items.Add("Diu")
            EmployeeCityComboBox.Items.Add("Kachigam")
            EmployeeCityComboBox.SelectedItem = "--Please select city--"

        ElseIf EmployeeStateComboBox.SelectedItem = "DL" Then
            EmployeeCityComboBox.Items.Clear()
            EmployeeCityComboBox.Items.Add("--Please select city--")
            EmployeeCityComboBox.Items.Add("Delhi")
            EmployeeCityComboBox.Items.Add("Jaffarpur kalan")
            EmployeeCityComboBox.Items.Add("Qutabgarh")
            EmployeeCityComboBox.Items.Add("Ujwa")
            EmployeeCityComboBox.SelectedItem = "--Please select city--"

        ElseIf EmployeeStateComboBox.SelectedItem = "GA" Then
            EmployeeCityComboBox.Items.Clear()
            EmployeeCityComboBox.Items.Add("--Please select city--")
            EmployeeCityComboBox.Items.Add("Panaji")
            EmployeeCityComboBox.Items.Add("Madgaon")
            EmployeeCityComboBox.Items.Add("Mormugao")
            EmployeeCityComboBox.SelectedItem = "--Please select city--"

        ElseIf EmployeeStateComboBox.SelectedItem = "GJ" Then
            EmployeeCityComboBox.Items.Clear()
            EmployeeCityComboBox.Items.Add("--Please select city--")
            EmployeeCityComboBox.Items.Add("Gandhinagar")
            EmployeeCityComboBox.Items.Add("Ahmedabad")
            EmployeeCityComboBox.Items.Add("Surat")
            EmployeeCityComboBox.Items.Add("Vadodara")
            EmployeeCityComboBox.Items.Add("Rajkot")
            EmployeeCityComboBox.Items.Add("Bhavnagar")
            EmployeeCityComboBox.Items.Add("Jamnagar")
            EmployeeCityComboBox.Items.Add("Junagadh")
            EmployeeCityComboBox.Items.Add("Anand")
            EmployeeCityComboBox.Items.Add("Navsari")
            EmployeeCityComboBox.Items.Add("Surendranagar")
            EmployeeCityComboBox.Items.Add("Morvi")
            EmployeeCityComboBox.SelectedItem = "--Please select city--"

        ElseIf EmployeeStateComboBox.SelectedItem = "HR" Then
            EmployeeCityComboBox.Items.Clear()
            EmployeeCityComboBox.Items.Add("--Please select city--")
            EmployeeCityComboBox.Items.Add("Faridabad")
            EmployeeCityComboBox.Items.Add("Gurgaon")
            EmployeeCityComboBox.Items.Add("Panipat")
            EmployeeCityComboBox.Items.Add("Yamunanagar")
            EmployeeCityComboBox.Items.Add("Rohtak")
            EmployeeCityComboBox.Items.Add("Hisar")
            EmployeeCityComboBox.Items.Add("Karnal")
            EmployeeCityComboBox.Items.Add("Sonipat")
            EmployeeCityComboBox.Items.Add("Panchkula")
            EmployeeCityComboBox.Items.Add("Ambala Sadar")
            EmployeeCityComboBox.SelectedItem = "--Please select city--"

        ElseIf EmployeeStateComboBox.SelectedItem = "HP" Then
            EmployeeCityComboBox.Items.Clear()
            EmployeeCityComboBox.Items.Add("--Please select city--")
            EmployeeCityComboBox.Items.Add("Baddi")
            EmployeeCityComboBox.Items.Add("Chamba")
            EmployeeCityComboBox.Items.Add("Dharmasala")
            EmployeeCityComboBox.Items.Add("Kullu")
            EmployeeCityComboBox.Items.Add("Mandi")
            EmployeeCityComboBox.Items.Add("Nahan")
            EmployeeCityComboBox.Items.Add("Paonta Sahib")
            EmployeeCityComboBox.Items.Add("Shimla")
            EmployeeCityComboBox.Items.Add("Solan")
            EmployeeCityComboBox.Items.Add("Sundarnagar")
            EmployeeCityComboBox.SelectedItem = "--Please select city--"

        ElseIf EmployeeStateComboBox.SelectedItem = "JK" Then
            EmployeeCityComboBox.Items.Clear()
            EmployeeCityComboBox.Items.Add("--Please select city--")
            EmployeeCityComboBox.Items.Add("Srinagar")
            EmployeeCityComboBox.Items.Add("Jammu")
            EmployeeCityComboBox.Items.Add("Anantnag")
            EmployeeCityComboBox.Items.Add("Udhampur")
            EmployeeCityComboBox.Items.Add("Baramula")
            EmployeeCityComboBox.Items.Add("Sopore")
            EmployeeCityComboBox.Items.Add("Kathua")
            EmployeeCityComboBox.Items.Add("Bandipura")
            EmployeeCityComboBox.Items.Add("Leh")
            EmployeeCityComboBox.SelectedItem = "--Please select city--"

        ElseIf EmployeeStateComboBox.SelectedItem = "JH" Then
            EmployeeCityComboBox.Items.Clear()
            EmployeeCityComboBox.Items.Add("--Please select city--")
            EmployeeCityComboBox.Items.Add("Jamshedpur")
            EmployeeCityComboBox.Items.Add("Dhanbad")
            EmployeeCityComboBox.Items.Add("Ranchi")
            EmployeeCityComboBox.Items.Add("Bokaro Steel City")
            EmployeeCityComboBox.Items.Add("Deoghar")
            EmployeeCityComboBox.Items.Add("Phusro")
            EmployeeCityComboBox.Items.Add("Hazaribag")
            EmployeeCityComboBox.Items.Add("Giridih")
            EmployeeCityComboBox.Items.Add("Ramgarh Cantonmnet")
            EmployeeCityComboBox.Items.Add("Medininagar")
            EmployeeCityComboBox.Items.Add("Chirkunda")
            EmployeeCityComboBox.SelectedItem = "--Please select city--"

        ElseIf EmployeeStateComboBox.SelectedItem = "KA" Then
            EmployeeCityComboBox.Items.Clear()
            EmployeeCityComboBox.Items.Add("--Please select city--")
            EmployeeCityComboBox.Items.Add("Bengaluru")
            EmployeeCityComboBox.Items.Add("Mysore")
            EmployeeCityComboBox.Items.Add("Hubli-Dharwar")
            EmployeeCityComboBox.Items.Add("Mangalore")
            EmployeeCityComboBox.Items.Add("Gulbarga")
            EmployeeCityComboBox.Items.Add("Belgaum")
            EmployeeCityComboBox.Items.Add("Davanagere")
            EmployeeCityComboBox.Items.Add("Bellary")
            EmployeeCityComboBox.Items.Add("Bijapur")
            EmployeeCityComboBox.Items.Add("Shimoga")
            EmployeeCityComboBox.Items.Add("Tumkur")
            EmployeeCityComboBox.SelectedItem = "--Please select city--"

        ElseIf EmployeeStateComboBox.SelectedItem = "KL" Then
            EmployeeCityComboBox.Items.Clear()
            EmployeeCityComboBox.Items.Add("--Please select city--")
            EmployeeCityComboBox.Items.Add("Kochi")
            EmployeeCityComboBox.Items.Add("Kozhikode")
            EmployeeCityComboBox.Items.Add("Thrissur")
            EmployeeCityComboBox.Items.Add("Malappuram")
            EmployeeCityComboBox.Items.Add("Thiruvanathapuram")
            EmployeeCityComboBox.Items.Add("Kannur")
            EmployeeCityComboBox.Items.Add("Kollam")
            EmployeeCityComboBox.Items.Add("Cherthala")
            EmployeeCityComboBox.Items.Add("Kayamkulam")
            EmployeeCityComboBox.Items.Add("Kottayam")
            EmployeeCityComboBox.SelectedItem = "--Please select city--"

        ElseIf EmployeeStateComboBox.SelectedItem = "LD" Then
            EmployeeCityComboBox.Items.Clear()
            EmployeeCityComboBox.Items.Add("--Please select city--")
            EmployeeCityComboBox.Items.Add("Amini")
            EmployeeCityComboBox.Items.Add("Andrott")
            EmployeeCityComboBox.Items.Add("Kavaratti")
            EmployeeCityComboBox.Items.Add("Minicoy")
            EmployeeCityComboBox.SelectedItem = "--Please select city--"

        ElseIf EmployeeStateComboBox.SelectedItem = "MP" Then
            EmployeeCityComboBox.Items.Clear()
            EmployeeCityComboBox.Items.Add("--Please select city--")
            EmployeeCityComboBox.Items.Add("Indore")
            EmployeeCityComboBox.Items.Add("Bhopal")
            EmployeeCityComboBox.Items.Add("Jabalpur")
            EmployeeCityComboBox.Items.Add("Gwalior")
            EmployeeCityComboBox.Items.Add("Ujjain")
            EmployeeCityComboBox.Items.Add("Sagar")
            EmployeeCityComboBox.Items.Add("Dewas")
            EmployeeCityComboBox.Items.Add("Satna")
            EmployeeCityComboBox.Items.Add("Ratlam")
            EmployeeCityComboBox.Items.Add("Rewa")
            EmployeeCityComboBox.SelectedItem = "--Please select city--"

        ElseIf EmployeeStateComboBox.SelectedItem = "MH" Then
            EmployeeCityComboBox.Items.Clear()
            EmployeeCityComboBox.Items.Add("--Please select city--")
            EmployeeCityComboBox.Items.Add("Mumbai")
            EmployeeCityComboBox.Items.Add("Pune")
            EmployeeCityComboBox.Items.Add("Nagpur")
            EmployeeCityComboBox.Items.Add("Nashik")
            EmployeeCityComboBox.Items.Add("Vasai-Virar")
            EmployeeCityComboBox.Items.Add("Aurangabad")
            EmployeeCityComboBox.Items.Add("Solapur")
            EmployeeCityComboBox.Items.Add("Bhiwandi")
            EmployeeCityComboBox.Items.Add("Amaravati")
            EmployeeCityComboBox.SelectedItem = "--Please select city--"

        ElseIf EmployeeStateComboBox.SelectedItem = "MN" Then
            EmployeeCityComboBox.Items.Clear()
            EmployeeCityComboBox.Items.Add("--Please select city--")
            EmployeeCityComboBox.Items.Add("Imphal")
            EmployeeCityComboBox.Items.Add("Kakching")
            EmployeeCityComboBox.Items.Add("Mayang Imphal")
            EmployeeCityComboBox.Items.Add("Thoubal")
            EmployeeCityComboBox.Items.Add("Ukhrul")
            EmployeeCityComboBox.SelectedItem = "--Please select city--"

        ElseIf EmployeeStateComboBox.SelectedItem = "ML" Then
            EmployeeCityComboBox.Items.Clear()
            EmployeeCityComboBox.Items.Add("--Please select city--")
            EmployeeCityComboBox.Items.Add("Jowai")
            EmployeeCityComboBox.Items.Add("Nongston")
            EmployeeCityComboBox.Items.Add("Shillong")
            EmployeeCityComboBox.Items.Add("Tura")
            EmployeeCityComboBox.Items.Add("Williamnagar")
            EmployeeCityComboBox.SelectedItem = "--Please select city--"

        ElseIf EmployeeStateComboBox.SelectedItem = "MZ" Then
            EmployeeCityComboBox.Items.Clear()
            EmployeeCityComboBox.Items.Add("--Please select city--")
            EmployeeCityComboBox.Items.Add("Aizawl")
            EmployeeCityComboBox.Items.Add("Champhai")
            EmployeeCityComboBox.Items.Add("Kolasib")
            EmployeeCityComboBox.Items.Add("Lawngtlai")
            EmployeeCityComboBox.Items.Add("Lunglei")
            EmployeeCityComboBox.Items.Add("Saiha")
            EmployeeCityComboBox.Items.Add("Serchhip")
            EmployeeCityComboBox.SelectedItem = "--Please select city--"

        ElseIf EmployeeStateComboBox.SelectedItem = "NL" Then
            EmployeeCityComboBox.Items.Clear()
            EmployeeCityComboBox.Items.Add("--Please select city--")
            EmployeeCityComboBox.Items.Add("Chumukedima")
            EmployeeCityComboBox.Items.Add("Dimapur")
            EmployeeCityComboBox.Items.Add("Kohima")
            EmployeeCityComboBox.Items.Add("Mokokchung")
            EmployeeCityComboBox.Items.Add("Mon")
            EmployeeCityComboBox.Items.Add("Tuensang")
            EmployeeCityComboBox.Items.Add("Wokha")
            EmployeeCityComboBox.Items.Add("Zunheboto")
            EmployeeCityComboBox.SelectedItem = "--Please select city--"

        ElseIf EmployeeStateComboBox.SelectedItem = "OR" Then
            EmployeeCityComboBox.Items.Clear()
            EmployeeCityComboBox.Items.Add("--Please select city--")
            EmployeeCityComboBox.Items.Add("Bhubaneshwar")
            EmployeeCityComboBox.Items.Add("Cuttack")
            EmployeeCityComboBox.Items.Add("Raurkela")
            EmployeeCityComboBox.Items.Add("Brahmapur")
            EmployeeCityComboBox.Items.Add("Sambalpur")
            EmployeeCityComboBox.Items.Add("Puri")
            EmployeeCityComboBox.Items.Add("Baleshwar")
            EmployeeCityComboBox.Items.Add("Bhadrak")
            EmployeeCityComboBox.Items.Add("Baripada")
            EmployeeCityComboBox.SelectedItem = "--Please select city--"

        ElseIf EmployeeStateComboBox.SelectedItem = "PB" Then
            EmployeeCityComboBox.Items.Clear()
            EmployeeCityComboBox.Items.Add("--Please select city--")
            EmployeeCityComboBox.Items.Add("Ludhiana")
            EmployeeCityComboBox.Items.Add("Amristar")
            EmployeeCityComboBox.Items.Add("Jalandhar")
            EmployeeCityComboBox.Items.Add("Patiala")
            EmployeeCityComboBox.Items.Add("Bathinda")
            EmployeeCityComboBox.Items.Add("S.A.S. Nagar")
            EmployeeCityComboBox.Items.Add("Hoshiarpur")
            EmployeeCityComboBox.Items.Add("Moga")
            EmployeeCityComboBox.Items.Add("Pathankot")
            EmployeeCityComboBox.Items.Add("Batala")
            EmployeeCityComboBox.SelectedItem = "--Please select city--"

        ElseIf EmployeeStateComboBox.SelectedItem = "PY" Then
            EmployeeCityComboBox.Items.Clear()
            EmployeeCityComboBox.Items.Add("--Please select city--")
            EmployeeCityComboBox.Items.Add("Karaikal")
            EmployeeCityComboBox.Items.Add("Mahe")
            EmployeeCityComboBox.Items.Add("Puducherry")
            EmployeeCityComboBox.Items.Add("Yanam")
            EmployeeCityComboBox.SelectedItem = "--Please select city--"

        ElseIf EmployeeStateComboBox.SelectedItem = "RJ" Then
            EmployeeCityComboBox.Items.Clear()
            EmployeeCityComboBox.Items.Add("--Please select city--")
            EmployeeCityComboBox.Items.Add("Jaipur")
            EmployeeCityComboBox.Items.Add("Jodhpur")
            EmployeeCityComboBox.Items.Add("Kota")
            EmployeeCityComboBox.Items.Add("Bikaner")
            EmployeeCityComboBox.Items.Add("Ajmer")
            EmployeeCityComboBox.Items.Add("Udaipur")
            EmployeeCityComboBox.Items.Add("Bhilwara")
            EmployeeCityComboBox.Items.Add("Alwar")
            EmployeeCityComboBox.Items.Add("Bharatpur")
            EmployeeCityComboBox.SelectedItem = "--Please select city--"

        ElseIf EmployeeStateComboBox.SelectedItem = "SK" Then
            EmployeeCityComboBox.Items.Clear()
            EmployeeCityComboBox.Items.Add("--Please select city--")
            EmployeeCityComboBox.Items.Add("Gangtok")
            EmployeeCityComboBox.Items.Add("Jorethang")
            EmployeeCityComboBox.Items.Add("Namchi")
            EmployeeCityComboBox.Items.Add("Rangpo")
            EmployeeCityComboBox.SelectedItem = "--Please select city--"

        ElseIf EmployeeStateComboBox.SelectedItem = "TN" Then
            EmployeeCityComboBox.Items.Clear()
            EmployeeCityComboBox.Items.Add("--Please select city--")
            EmployeeCityComboBox.Items.Add("Chennai")
            EmployeeCityComboBox.Items.Add("Coimbatore")
            EmployeeCityComboBox.Items.Add("Madurai")
            EmployeeCityComboBox.Items.Add("Tiruchirapalli")
            EmployeeCityComboBox.Items.Add("Tiruppur")
            EmployeeCityComboBox.Items.Add("Salem")
            EmployeeCityComboBox.Items.Add("Erode")
            EmployeeCityComboBox.Items.Add("Tirunelveli")
            EmployeeCityComboBox.Items.Add("Vellore")
            EmployeeCityComboBox.Items.Add("Thoothukudi")
            EmployeeCityComboBox.SelectedItem = "--Please select city--"

        ElseIf EmployeeStateComboBox.SelectedItem = "TR" Then
            EmployeeCityComboBox.Items.Clear()
            EmployeeCityComboBox.Items.Add("--Please select city--")
            EmployeeCityComboBox.Items.Add("Agartala")
            EmployeeCityComboBox.Items.Add("Belonia")
            EmployeeCityComboBox.Items.Add("Bishalgarh")
            EmployeeCityComboBox.Items.Add("Dharmanagar")
            EmployeeCityComboBox.Items.Add("Kailashahar")
            EmployeeCityComboBox.Items.Add("Teliamura")
            EmployeeCityComboBox.Items.Add("Udaipur")
            EmployeeCityComboBox.SelectedItem = "--Please select city--"

        ElseIf EmployeeStateComboBox.SelectedItem = "TS" Then
            EmployeeCityComboBox.Items.Clear()
            EmployeeCityComboBox.Items.Add("--Please select city--")
            EmployeeCityComboBox.Items.Add("Hyderabad")
            EmployeeCityComboBox.Items.Add("Warangal")
            EmployeeCityComboBox.Items.Add("Nizamabad")
            EmployeeCityComboBox.Items.Add("Karimnagar")
            EmployeeCityComboBox.Items.Add("Khammam")
            EmployeeCityComboBox.Items.Add("Ramagundam")
            EmployeeCityComboBox.Items.Add("Mahbubnagar")
            EmployeeCityComboBox.Items.Add("Mancherial")
            EmployeeCityComboBox.Items.Add("Nalgonda")
            EmployeeCityComboBox.Items.Add("Adilabad")
            EmployeeCityComboBox.SelectedItem = "--Please select city--"

        ElseIf EmployeeStateComboBox.SelectedItem = "UK" Then
            EmployeeCityComboBox.Items.Clear()
            EmployeeCityComboBox.Items.Add("--Please select city--")
            EmployeeCityComboBox.Items.Add("Dehra Dun")
            EmployeeCityComboBox.Items.Add("Haridwar")
            EmployeeCityComboBox.Items.Add("Roorkee")
            EmployeeCityComboBox.Items.Add("Haldwani")
            EmployeeCityComboBox.Items.Add("Rudrapur")
            EmployeeCityComboBox.Items.Add("Kashipur")
            EmployeeCityComboBox.Items.Add("Rishikesh")
            EmployeeCityComboBox.Items.Add("Pithoragarh")
            EmployeeCityComboBox.Items.Add("Ramnagar")
            EmployeeCityComboBox.Items.Add("Kichha")
            EmployeeCityComboBox.Items.Add("Manglaur")
            EmployeeCityComboBox.Items.Add("Jaspur")
            EmployeeCityComboBox.SelectedItem = "--Please select city--"

        ElseIf EmployeeStateComboBox.SelectedItem = "UP" Then
            EmployeeCityComboBox.Items.Clear()
            EmployeeCityComboBox.Items.Add("--Please select city--")
            EmployeeCityComboBox.Items.Add("Kanpur")
            EmployeeCityComboBox.Items.Add("Lucknow")
            EmployeeCityComboBox.Items.Add("Ghaziabad")
            EmployeeCityComboBox.Items.Add("Agra")
            EmployeeCityComboBox.Items.Add("Varanasi")
            EmployeeCityComboBox.Items.Add("Meerut")
            EmployeeCityComboBox.Items.Add("Allahabad")
            EmployeeCityComboBox.Items.Add("Bareilly")
            EmployeeCityComboBox.Items.Add("Aligarh")
            EmployeeCityComboBox.Items.Add("Moradabad")
            EmployeeCityComboBox.SelectedItem = "--Please select city--"

        ElseIf EmployeeStateComboBox.SelectedItem = "WB" Then
            EmployeeCityComboBox.Items.Clear()
            EmployeeCityComboBox.Items.Add("--Please select city--")
            EmployeeCityComboBox.Items.Add("Kolkata")
            EmployeeCityComboBox.Items.Add("Asansol")
            EmployeeCityComboBox.Items.Add("Shiliguri")
            EmployeeCityComboBox.Items.Add("Durgapur")
            EmployeeCityComboBox.Items.Add("Bardhaman")
            EmployeeCityComboBox.Items.Add("Ingraj Bazar")
            EmployeeCityComboBox.Items.Add("Baharampur")
            EmployeeCityComboBox.Items.Add("Habra")
            EmployeeCityComboBox.Items.Add("Kharagpur")
            EmployeeCityComboBox.Items.Add("Santipur")
            EmployeeCityComboBox.SelectedItem = "--Please select city--"

        End If

    End Sub
    'Using Regular Expression Function to validate Address
    Function ValidateAddress(add) As Boolean
        Dim address As New Regex("\d+[ ](?:[A-Za-z0-9.-]+[ ]?)+(?:Avenue|Lane|Road|Boulevard|Drive|Street|Ave|Dr|Rd|Blvd|Ln|St)\.?")

        ' Check the match.
        If address.IsMatch(add) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub AddAddress()
        If Address1TextBox.Text <> String.Empty Then
            If ValidateAddress(Address1TextBox.Text) = True Then
                If EmployeeStateComboBox.SelectedItem.ToString() <> "--Please select state--" Or EmployeeStateComboBox.Text <> String.Empty Then
                    If EmployeeCityComboBox.SelectedIndex.ToString() <> "--Please select city--" Or EmployeeCityComboBox.Text <> String.Empty Then
                        'get address string
                        AddressString = Address1TextBox.Text
                        StateString = EmployeeStateComboBox.Text
                        CityString = EmployeeCityComboBox.Text
                        Me.SkipFormClosing = True
                        MessageBox.Show("Address is added successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Else
                        MessageBox.Show("Please select city.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Please select state.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Street is not valid. Please check again." & vbNewLine & "There is hint to tell you the format rule.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                With Address1TextBox
                    .Focus()
                    .Border.BackColor = Color.Red
                End With
            End If
        Else
            MessageBox.Show("Please input street.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            With Address1TextBox
                .Focus()
                .Border.BackColor = Color.Red
            End With
        End If
    End Sub

    Private Sub SumbitButton_Click(sender As Object, e As EventArgs) Handles SumbitButton.Click
        AddAddress()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        RefreshForm()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

    Private Sub AddressForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        StreetLabel.Visible = True
        LabelX6.Visible = True
        Address1TextBox.Visible = True
        If SkipFormClosing = True Then
            Exit Sub
        End If
        Select Case MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Case DialogResult.Yes
                RefreshForm()
            Case DialogResult.No
                e.Cancel = True 'cancel the form closing event
        End Select
    End Sub
End Class