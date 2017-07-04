<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditAccountForm
    Inherits DevComponents.DotNetBar.Office2007Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditAccountForm))
        Me.EmployeeErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EmployeeIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.EditSaveButton = New DevComponents.DotNetBar.ButtonX()
        Me.EmployeeCancelButton = New DevComponents.DotNetBar.ButtonX()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.SuperTooltip1 = New DevComponents.DotNetBar.SuperTooltip()
        Me.EmployeeEmailTextBox = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.EmployeeSalaryTextBox = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.EmployeePhoneTextBox = New DevComponents.DotNetBar.Controls.MaskedTextBoxAdv()
        Me.AddressButton = New DevComponents.DotNetBar.ButtonX()
        Me.EmployeeLastNameTextBox = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.EmployeeFirstNameTextBox = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.EmployeePasswordTextBox = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.EmployeeUserNameTextBox = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.EmployeePositionComboBox = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.EmployeeDateHiredDateTimePicker = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.EmployeeDOBDateTimePicker = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        CType(Me.EmployeeErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeDateHiredDateTimePicker, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeDOBDateTimePicker, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EmployeeErrorProvider
        '
        Me.EmployeeErrorProvider.ContainerControl = Me
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(26, 83)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 15)
        Me.Label15.TabIndex = 61
        Me.Label15.Text = "Password"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(288, 83)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 15)
        Me.Label14.TabIndex = 60
        Me.Label14.Text = "Date Hired"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(36, 243)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 15)
        Me.Label13.TabIndex = 59
        Me.Label13.Text = "Address"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(22, 200)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 15)
        Me.Label12.TabIndex = 58
        Me.Label12.Text = "Last Name"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(35, 120)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 15)
        Me.Label11.TabIndex = 57
        Me.Label11.Text = "Position"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(312, 151)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 15)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "Salary"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(315, 117)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 15)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Email"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(310, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 15)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Phone"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(317, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 15)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "DOB"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 15)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "First Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 15)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Username"
        '
        'EmployeeIDTextBox
        '
        Me.EmployeeIDTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeIDTextBox.Location = New System.Drawing.Point(100, 7)
        Me.EmployeeIDTextBox.Name = "EmployeeIDTextBox"
        Me.EmployeeIDTextBox.Size = New System.Drawing.Size(139, 23)
        Me.EmployeeIDTextBox.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 15)
        Me.Label10.TabIndex = 98
        Me.Label10.Text = "Employee ID"
        '
        'EditSaveButton
        '
        Me.EditSaveButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.EditSaveButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.EditSaveButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditSaveButton.Location = New System.Drawing.Point(313, 243)
        Me.EditSaveButton.Name = "EditSaveButton"
        Me.EditSaveButton.Size = New System.Drawing.Size(75, 23)
        Me.EditSaveButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SuperTooltip1.SetSuperTooltip(Me.EditSaveButton, New DevComponents.DotNetBar.SuperTooltipInfo("", "", "", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray))
        Me.EditSaveButton.TabIndex = 13
        Me.EditSaveButton.Text = "&Edit"
        '
        'EmployeeCancelButton
        '
        Me.EmployeeCancelButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.EmployeeCancelButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.EmployeeCancelButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeCancelButton.Location = New System.Drawing.Point(472, 244)
        Me.EmployeeCancelButton.Name = "EmployeeCancelButton"
        Me.EmployeeCancelButton.Size = New System.Drawing.Size(75, 23)
        Me.EmployeeCancelButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.EmployeeCancelButton.TabIndex = 0
        Me.EmployeeCancelButton.Text = "&Exit"
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007VistaGlass
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(154, Byte), Integer)))
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Image = Global.OMS.My.Resources.Resources.ic_help_outline_black_18dp_1x
        Me.LabelX1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.LabelX1.Location = New System.Drawing.Point(256, 41)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.SingleLineColor = System.Drawing.Color.Transparent
        Me.LabelX1.Size = New System.Drawing.Size(18, 18)
        Me.SuperTooltip1.SetSuperTooltip(Me.LabelX1, New DevComponents.DotNetBar.SuperTooltipInfo("Required", "", "Usernames can contain letters (A-Z and a-z) and number (0-9), with a minimum of 4" &
            " characters, and a maximum of 20 characters.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray, True, False, New System.Drawing.Size(0, 0)))
        Me.LabelX1.TabIndex = 99
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Image = Global.OMS.My.Resources.Resources.ic_help_outline_black_18dp_1x
        Me.LabelX2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.LabelX2.Location = New System.Drawing.Point(256, 80)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.SingleLineColor = System.Drawing.Color.Transparent
        Me.LabelX2.Size = New System.Drawing.Size(18, 18)
        Me.SuperTooltip1.SetSuperTooltip(Me.LabelX2, New DevComponents.DotNetBar.SuperTooltipInfo("Required", "", resources.GetString("LabelX2.SuperTooltip"), Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray, True, False, New System.Drawing.Size(0, 0)))
        Me.LabelX2.TabIndex = 100
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Image = Global.OMS.My.Resources.Resources.ic_help_outline_black_18dp_1x
        Me.LabelX3.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.LabelX3.Location = New System.Drawing.Point(256, 156)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.SingleLineColor = System.Drawing.Color.Transparent
        Me.LabelX3.Size = New System.Drawing.Size(18, 18)
        Me.SuperTooltip1.SetSuperTooltip(Me.LabelX3, New DevComponents.DotNetBar.SuperTooltipInfo("Required", "", "First name can contain letters (A-Z and a-z) and number (0-9), with a minimum of " &
            "1 characters, and a maximum of 30 characters.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray, True, False, New System.Drawing.Size(0, 0)))
        Me.LabelX3.TabIndex = 101
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.Image = Global.OMS.My.Resources.Resources.ic_help_outline_black_18dp_1x
        Me.LabelX4.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.LabelX4.Location = New System.Drawing.Point(256, 197)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.SingleLineColor = System.Drawing.Color.Transparent
        Me.LabelX4.Size = New System.Drawing.Size(18, 18)
        Me.SuperTooltip1.SetSuperTooltip(Me.LabelX4, New DevComponents.DotNetBar.SuperTooltipInfo("Required", "", "Last name can contain letters (A-Z and a-z) and number (0-9), with a minimum of 1" &
            " characters, and a maximum of 30 characters.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray, True, False, New System.Drawing.Size(0, 0)))
        Me.LabelX4.TabIndex = 102
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX6.Image = Global.OMS.My.Resources.Resources.ic_help_outline_black_18dp_1x
        Me.LabelX6.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.LabelX6.Location = New System.Drawing.Point(472, 44)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.SingleLineColor = System.Drawing.Color.Transparent
        Me.LabelX6.Size = New System.Drawing.Size(18, 18)
        Me.SuperTooltip1.SetSuperTooltip(Me.LabelX6, New DevComponents.DotNetBar.SuperTooltipInfo("Required", "", "Format: (xxx)xxx-xxxx" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Example: (123)456-7890", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray, True, False, New System.Drawing.Size(0, 0)))
        Me.LabelX6.TabIndex = 104
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX7.Image = Global.OMS.My.Resources.Resources.ic_help_outline_black_18dp_1x
        Me.LabelX7.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.LabelX7.Location = New System.Drawing.Point(524, 117)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.SingleLineColor = System.Drawing.Color.Transparent
        Me.LabelX7.Size = New System.Drawing.Size(18, 18)
        Me.SuperTooltip1.SetSuperTooltip(Me.LabelX7, New DevComponents.DotNetBar.SuperTooltipInfo("Required", "", "example@company.xyz", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray, True, False, New System.Drawing.Size(0, 0)))
        Me.LabelX7.TabIndex = 105
        '
        'LabelX8
        '
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX8.Image = Global.OMS.My.Resources.Resources.ic_help_outline_black_18dp_1x
        Me.LabelX8.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.LabelX8.Location = New System.Drawing.Point(524, 151)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.SingleLineColor = System.Drawing.Color.Transparent
        Me.LabelX8.Size = New System.Drawing.Size(18, 18)
        Me.SuperTooltip1.SetSuperTooltip(Me.LabelX8, New DevComponents.DotNetBar.SuperTooltipInfo("Required", "", "Salary can contain number (0-9) only, with a minimum of 8 characters, and a maxim" &
            "um of 10 characters.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray, True, False, New System.Drawing.Size(0, 0)))
        Me.LabelX8.TabIndex = 106
        '
        'SuperTooltip1
        '
        Me.SuperTooltip1.DefaultTooltipSettings = New DevComponents.DotNetBar.SuperTooltipInfo("", "", "", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray)
        '
        'EmployeeEmailTextBox
        '
        '
        '
        '
        Me.EmployeeEmailTextBox.Border.Class = "TextBoxBorder"
        Me.EmployeeEmailTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.EmployeeEmailTextBox.ButtonCustom.Tooltip = ""
        Me.EmployeeEmailTextBox.ButtonCustom2.Tooltip = ""
        Me.EmployeeEmailTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeEmailTextBox.Location = New System.Drawing.Point(368, 117)
        Me.EmployeeEmailTextBox.MaxLength = 50
        Me.EmployeeEmailTextBox.Name = "EmployeeEmailTextBox"
        Me.EmployeeEmailTextBox.PreventEnterBeep = True
        Me.EmployeeEmailTextBox.Size = New System.Drawing.Size(139, 23)
        Me.EmployeeEmailTextBox.TabIndex = 10
        Me.EmployeeEmailTextBox.WatermarkText = "example@company.xyz"
        '
        'EmployeeSalaryTextBox
        '
        '
        '
        '
        Me.EmployeeSalaryTextBox.Border.Class = "TextBoxBorder"
        Me.EmployeeSalaryTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.EmployeeSalaryTextBox.ButtonCustom.Tooltip = ""
        Me.EmployeeSalaryTextBox.ButtonCustom2.Tooltip = ""
        Me.EmployeeSalaryTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeSalaryTextBox.Location = New System.Drawing.Point(369, 151)
        Me.EmployeeSalaryTextBox.MaxLength = 10
        Me.EmployeeSalaryTextBox.Name = "EmployeeSalaryTextBox"
        Me.EmployeeSalaryTextBox.PreventEnterBeep = True
        Me.EmployeeSalaryTextBox.Size = New System.Drawing.Size(139, 23)
        Me.EmployeeSalaryTextBox.TabIndex = 11
        '
        'EmployeePhoneTextBox
        '
        '
        '
        '
        Me.EmployeePhoneTextBox.BackgroundStyle.Class = "TextBoxBorder"
        Me.EmployeePhoneTextBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.EmployeePhoneTextBox.ButtonClear.Tooltip = ""
        Me.EmployeePhoneTextBox.ButtonClear.Visible = True
        Me.EmployeePhoneTextBox.ButtonCustom.Tooltip = ""
        Me.EmployeePhoneTextBox.ButtonCustom2.Tooltip = ""
        Me.EmployeePhoneTextBox.ButtonDropDown.Tooltip = ""
        Me.EmployeePhoneTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeePhoneTextBox.Location = New System.Drawing.Point(370, 44)
        Me.EmployeePhoneTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.EmployeePhoneTextBox.Mask = "(999)000-0000"
        Me.EmployeePhoneTextBox.Name = "EmployeePhoneTextBox"
        Me.EmployeePhoneTextBox.Size = New System.Drawing.Size(98, 17)
        Me.EmployeePhoneTextBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.EmployeePhoneTextBox.TabIndex = 8
        Me.EmployeePhoneTextBox.Text = ""
        '
        'AddressButton
        '
        Me.AddressButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.AddressButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.AddressButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressButton.Location = New System.Drawing.Point(120, 234)
        Me.AddressButton.Margin = New System.Windows.Forms.Padding(2)
        Me.AddressButton.Name = "AddressButton"
        Me.AddressButton.Size = New System.Drawing.Size(73, 32)
        Me.AddressButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SuperTooltip1.SetSuperTooltip(Me.AddressButton, New DevComponents.DotNetBar.SuperTooltipInfo("", "", "Edit or add location information." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Clicking this button will open a new window.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray, False, False, New System.Drawing.Size(0, 0)))
        Me.AddressButton.TabIndex = 7
        Me.AddressButton.Text = "Add Address"
        '
        'EmployeeLastNameTextBox
        '
        '
        '
        '
        Me.EmployeeLastNameTextBox.Border.Class = "TextBoxBorder"
        Me.EmployeeLastNameTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.EmployeeLastNameTextBox.ButtonCustom.Tooltip = ""
        Me.EmployeeLastNameTextBox.ButtonCustom2.Tooltip = ""
        Me.EmployeeLastNameTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeLastNameTextBox.Location = New System.Drawing.Point(100, 197)
        Me.EmployeeLastNameTextBox.MaxLength = 30
        Me.EmployeeLastNameTextBox.Name = "EmployeeLastNameTextBox"
        Me.EmployeeLastNameTextBox.PreventEnterBeep = True
        Me.EmployeeLastNameTextBox.Size = New System.Drawing.Size(139, 23)
        Me.EmployeeLastNameTextBox.TabIndex = 6
        '
        'EmployeeFirstNameTextBox
        '
        '
        '
        '
        Me.EmployeeFirstNameTextBox.Border.Class = "TextBoxBorder"
        Me.EmployeeFirstNameTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.EmployeeFirstNameTextBox.ButtonCustom.Tooltip = ""
        Me.EmployeeFirstNameTextBox.ButtonCustom2.Tooltip = ""
        Me.EmployeeFirstNameTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeFirstNameTextBox.Location = New System.Drawing.Point(100, 158)
        Me.EmployeeFirstNameTextBox.MaxLength = 30
        Me.EmployeeFirstNameTextBox.Name = "EmployeeFirstNameTextBox"
        Me.EmployeeFirstNameTextBox.PreventEnterBeep = True
        Me.EmployeeFirstNameTextBox.Size = New System.Drawing.Size(139, 23)
        Me.EmployeeFirstNameTextBox.TabIndex = 5
        '
        'EmployeePasswordTextBox
        '
        '
        '
        '
        Me.EmployeePasswordTextBox.Border.Class = "TextBoxBorder"
        Me.EmployeePasswordTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.EmployeePasswordTextBox.ButtonCustom.Tooltip = ""
        Me.EmployeePasswordTextBox.ButtonCustom2.Tooltip = ""
        Me.EmployeePasswordTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeePasswordTextBox.Location = New System.Drawing.Point(100, 83)
        Me.EmployeePasswordTextBox.MaxLength = 20
        Me.EmployeePasswordTextBox.Name = "EmployeePasswordTextBox"
        Me.EmployeePasswordTextBox.PreventEnterBeep = True
        Me.EmployeePasswordTextBox.Size = New System.Drawing.Size(139, 23)
        Me.EmployeePasswordTextBox.TabIndex = 2
        '
        'EmployeeUserNameTextBox
        '
        '
        '
        '
        Me.EmployeeUserNameTextBox.Border.Class = "TextBoxBorder"
        Me.EmployeeUserNameTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.EmployeeUserNameTextBox.ButtonCustom.Tooltip = ""
        Me.EmployeeUserNameTextBox.ButtonCustom2.Tooltip = ""
        Me.EmployeeUserNameTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeUserNameTextBox.Location = New System.Drawing.Point(100, 44)
        Me.EmployeeUserNameTextBox.MaxLength = 20
        Me.EmployeeUserNameTextBox.Name = "EmployeeUserNameTextBox"
        Me.EmployeeUserNameTextBox.PreventEnterBeep = True
        Me.EmployeeUserNameTextBox.Size = New System.Drawing.Size(139, 23)
        Me.EmployeeUserNameTextBox.TabIndex = 1
        '
        'EmployeePositionComboBox
        '
        Me.EmployeePositionComboBox.DisplayMember = "Text"
        Me.EmployeePositionComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.EmployeePositionComboBox.FormattingEnabled = True
        Me.EmployeePositionComboBox.ItemHeight = 17
        Me.EmployeePositionComboBox.Location = New System.Drawing.Point(100, 117)
        Me.EmployeePositionComboBox.Name = "EmployeePositionComboBox"
        Me.EmployeePositionComboBox.Size = New System.Drawing.Size(139, 23)
        Me.EmployeePositionComboBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.EmployeePositionComboBox.TabIndex = 107
        '
        'EmployeeDateHiredDateTimePicker
        '
        '
        '
        '
        Me.EmployeeDateHiredDateTimePicker.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.EmployeeDateHiredDateTimePicker.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.EmployeeDateHiredDateTimePicker.ButtonClear.Tooltip = ""
        Me.EmployeeDateHiredDateTimePicker.ButtonCustom.Tooltip = ""
        Me.EmployeeDateHiredDateTimePicker.ButtonCustom2.Tooltip = ""
        Me.EmployeeDateHiredDateTimePicker.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.EmployeeDateHiredDateTimePicker.ButtonDropDown.Tooltip = ""
        Me.EmployeeDateHiredDateTimePicker.ButtonDropDown.Visible = True
        Me.EmployeeDateHiredDateTimePicker.ButtonFreeText.Tooltip = ""
        Me.EmployeeDateHiredDateTimePicker.IsPopupCalendarOpen = False
        Me.EmployeeDateHiredDateTimePicker.Location = New System.Drawing.Point(368, 78)
        '
        '
        '
        Me.EmployeeDateHiredDateTimePicker.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.EmployeeDateHiredDateTimePicker.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.EmployeeDateHiredDateTimePicker.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.EmployeeDateHiredDateTimePicker.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.EmployeeDateHiredDateTimePicker.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.EmployeeDateHiredDateTimePicker.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.EmployeeDateHiredDateTimePicker.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.EmployeeDateHiredDateTimePicker.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.EmployeeDateHiredDateTimePicker.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.EmployeeDateHiredDateTimePicker.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.EmployeeDateHiredDateTimePicker.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.EmployeeDateHiredDateTimePicker.MonthCalendar.DisplayMonth = New Date(2016, 11, 1, 0, 0, 0, 0)
        Me.EmployeeDateHiredDateTimePicker.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.EmployeeDateHiredDateTimePicker.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.EmployeeDateHiredDateTimePicker.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.EmployeeDateHiredDateTimePicker.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.EmployeeDateHiredDateTimePicker.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.EmployeeDateHiredDateTimePicker.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.EmployeeDateHiredDateTimePicker.MonthCalendar.TodayButtonVisible = True
        Me.EmployeeDateHiredDateTimePicker.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.EmployeeDateHiredDateTimePicker.Name = "EmployeeDateHiredDateTimePicker"
        Me.EmployeeDateHiredDateTimePicker.Size = New System.Drawing.Size(194, 20)
        Me.EmployeeDateHiredDateTimePicker.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.EmployeeDateHiredDateTimePicker.TabIndex = 108
        '
        'EmployeeDOBDateTimePicker
        '
        '
        '
        '
        Me.EmployeeDOBDateTimePicker.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.EmployeeDOBDateTimePicker.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.EmployeeDOBDateTimePicker.ButtonClear.Tooltip = ""
        Me.EmployeeDOBDateTimePicker.ButtonCustom.Tooltip = ""
        Me.EmployeeDOBDateTimePicker.ButtonCustom2.Tooltip = ""
        Me.EmployeeDOBDateTimePicker.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.EmployeeDOBDateTimePicker.ButtonDropDown.Tooltip = ""
        Me.EmployeeDOBDateTimePicker.ButtonDropDown.Visible = True
        Me.EmployeeDOBDateTimePicker.ButtonFreeText.Tooltip = ""
        Me.EmployeeDOBDateTimePicker.IsPopupCalendarOpen = False
        Me.EmployeeDOBDateTimePicker.Location = New System.Drawing.Point(368, 192)
        '
        '
        '
        Me.EmployeeDOBDateTimePicker.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.EmployeeDOBDateTimePicker.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.EmployeeDOBDateTimePicker.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.EmployeeDOBDateTimePicker.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.EmployeeDOBDateTimePicker.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.EmployeeDOBDateTimePicker.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.EmployeeDOBDateTimePicker.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.EmployeeDOBDateTimePicker.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.EmployeeDOBDateTimePicker.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.EmployeeDOBDateTimePicker.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.EmployeeDOBDateTimePicker.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.EmployeeDOBDateTimePicker.MonthCalendar.DisplayMonth = New Date(2016, 11, 1, 0, 0, 0, 0)
        Me.EmployeeDOBDateTimePicker.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.EmployeeDOBDateTimePicker.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.EmployeeDOBDateTimePicker.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.EmployeeDOBDateTimePicker.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.EmployeeDOBDateTimePicker.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.EmployeeDOBDateTimePicker.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.EmployeeDOBDateTimePicker.MonthCalendar.TodayButtonVisible = True
        Me.EmployeeDOBDateTimePicker.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.EmployeeDOBDateTimePicker.Name = "EmployeeDOBDateTimePicker"
        Me.EmployeeDOBDateTimePicker.Size = New System.Drawing.Size(194, 20)
        Me.EmployeeDOBDateTimePicker.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.EmployeeDOBDateTimePicker.TabIndex = 109
        '
        'EditAccountForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(574, 289)
        Me.Controls.Add(Me.EmployeeDOBDateTimePicker)
        Me.Controls.Add(Me.EmployeeDateHiredDateTimePicker)
        Me.Controls.Add(Me.EmployeePositionComboBox)
        Me.Controls.Add(Me.EmployeeLastNameTextBox)
        Me.Controls.Add(Me.EmployeeFirstNameTextBox)
        Me.Controls.Add(Me.EmployeePasswordTextBox)
        Me.Controls.Add(Me.EmployeeUserNameTextBox)
        Me.Controls.Add(Me.AddressButton)
        Me.Controls.Add(Me.EmployeePhoneTextBox)
        Me.Controls.Add(Me.EmployeeSalaryTextBox)
        Me.Controls.Add(Me.EmployeeEmailTextBox)
        Me.Controls.Add(Me.LabelX8)
        Me.Controls.Add(Me.LabelX7)
        Me.Controls.Add(Me.LabelX6)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.EmployeeCancelButton)
        Me.Controls.Add(Me.EditSaveButton)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.EmployeeIDTextBox)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(590, 328)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(590, 328)
        Me.Name = "EditAccountForm"
        Me.Text = "Edit Account"
        CType(Me.EmployeeErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeDateHiredDateTimePicker, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeDOBDateTimePicker, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EmployeeErrorProvider As ErrorProvider
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents EmployeeIDTextBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Private WithEvents EmployeeCancelButton As DevComponents.DotNetBar.ButtonX
    Private WithEvents EditSaveButton As DevComponents.DotNetBar.ButtonX
    Private WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Private WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Private WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Private WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Private WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Private WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Private WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Private WithEvents EmployeeSalaryTextBox As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents EmployeeEmailTextBox As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents SuperTooltip1 As DevComponents.DotNetBar.SuperTooltip
    Friend WithEvents EmployeePhoneTextBox As DevComponents.DotNetBar.Controls.MaskedTextBoxAdv
    Friend WithEvents AddressButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents EmployeeLastNameTextBox As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents EmployeeFirstNameTextBox As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents EmployeePasswordTextBox As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents EmployeeUserNameTextBox As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents EmployeePositionComboBox As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents EmployeeDateHiredDateTimePicker As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents EmployeeDOBDateTimePicker As DevComponents.Editors.DateTimeAdv.DateTimeInput
End Class
