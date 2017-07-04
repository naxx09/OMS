<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUpForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignUpForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.EmployeeErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.EmployeeSaveButton = New DevComponents.DotNetBar.ButtonX()
        Me.EmployeeCancelButton = New DevComponents.DotNetBar.ButtonX()
        Me.UserNameTooltip = New DevComponents.DotNetBar.SuperTooltip()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
        Me.EmployeeEmailTextBox = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.EmployeePhoneTextBox = New DevComponents.DotNetBar.Controls.MaskedTextBoxAdv()
        Me.AddressButton = New DevComponents.DotNetBar.ButtonX()
        Me.EmployeeUserNameTextBox = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.EmployeePasswordTextBox = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.EmployeeFirstNameTextBox = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.EmployeeLastNameTextBox = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.EmployeePositionComboBox = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.EmployeeDateHiredDateTimePicker = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.EmployeeDOBDateTimePicker = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        CType(Me.EmployeeErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeDateHiredDateTimePicker, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeDOBDateTimePicker, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "First Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(366, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "DOB"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(356, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Phone"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(363, 117)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Email"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(37, 114)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 15)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Position"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(22, 208)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 15)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Last Name"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(33, 262)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 15)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Address"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(334, 80)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 15)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Date Hired"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(25, 73)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 15)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Password"
        '
        'EmployeeErrorProvider
        '
        Me.EmployeeErrorProvider.ContainerControl = Me
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007VistaGlass
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(154, Byte), Integer)))
        '
        'EmployeeSaveButton
        '
        Me.EmployeeSaveButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.EmployeeSaveButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.EmployeeSaveButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeSaveButton.Location = New System.Drawing.Point(369, 262)
        Me.EmployeeSaveButton.Name = "EmployeeSaveButton"
        Me.EmployeeSaveButton.Size = New System.Drawing.Size(87, 27)
        Me.EmployeeSaveButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.EmployeeSaveButton.TabIndex = 12
        Me.EmployeeSaveButton.Text = "&Save"
        '
        'EmployeeCancelButton
        '
        Me.EmployeeCancelButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.EmployeeCancelButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.EmployeeCancelButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeCancelButton.Location = New System.Drawing.Point(553, 262)
        Me.EmployeeCancelButton.Name = "EmployeeCancelButton"
        Me.EmployeeCancelButton.Size = New System.Drawing.Size(87, 27)
        Me.EmployeeCancelButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.EmployeeCancelButton.TabIndex = 13
        Me.EmployeeCancelButton.Text = "&Cancel"
        '
        'UserNameTooltip
        '
        Me.UserNameTooltip.DefaultTooltipSettings = New DevComponents.DotNetBar.SuperTooltipInfo("", "", "", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray)
        Me.UserNameTooltip.HoverDelayMultiplier = 1
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
        Me.LabelX1.Location = New System.Drawing.Point(296, 32)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.SingleLineColor = System.Drawing.Color.Transparent
        Me.LabelX1.Size = New System.Drawing.Size(21, 21)
        Me.UserNameTooltip.SetSuperTooltip(Me.LabelX1, New DevComponents.DotNetBar.SuperTooltipInfo("Required", "", "Usernames can contain letters (A-Z and a-z) and number (0-9), with a minimum of 4" &
            " characters, and a maximum of 20 characters.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray, True, False, New System.Drawing.Size(0, 0)))
        Me.LabelX1.TabIndex = 39
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
        Me.LabelX2.Location = New System.Drawing.Point(296, 75)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.SingleLineColor = System.Drawing.Color.Transparent
        Me.LabelX2.Size = New System.Drawing.Size(21, 21)
        Me.UserNameTooltip.SetSuperTooltip(Me.LabelX2, New DevComponents.DotNetBar.SuperTooltipInfo("Required", "", resources.GetString("LabelX2.SuperTooltip"), Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray, True, False, New System.Drawing.Size(0, 0)))
        Me.LabelX2.TabIndex = 40
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.Image = Global.OMS.My.Resources.Resources.ic_help_outline_black_18dp_1x
        Me.LabelX5.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.LabelX5.Location = New System.Drawing.Point(296, 157)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.SingleLineColor = System.Drawing.Color.Transparent
        Me.LabelX5.Size = New System.Drawing.Size(21, 21)
        Me.UserNameTooltip.SetSuperTooltip(Me.LabelX5, New DevComponents.DotNetBar.SuperTooltipInfo("Required", "", "First name can contain letters (A-Z and a-z) and number (0-9), with a minimum of " &
            "1 characters, and a maximum of 30 characters.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray, True, False, New System.Drawing.Size(0, 0)))
        Me.LabelX5.TabIndex = 43
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
        Me.LabelX7.Location = New System.Drawing.Point(296, 204)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.SingleLineColor = System.Drawing.Color.Transparent
        Me.LabelX7.Size = New System.Drawing.Size(21, 21)
        Me.UserNameTooltip.SetSuperTooltip(Me.LabelX7, New DevComponents.DotNetBar.SuperTooltipInfo("Required", "", "Last name can contain letters (A-Z and a-z) and number (0-9), with a minimum of 1" &
            " characters, and a maximum of 30 characters.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray, True, False, New System.Drawing.Size(0, 0)))
        Me.LabelX7.TabIndex = 44
        '
        'LabelX9
        '
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX9.Image = Global.OMS.My.Resources.Resources.ic_help_outline_black_18dp_1x
        Me.LabelX9.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.LabelX9.Location = New System.Drawing.Point(554, 39)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.SingleLineColor = System.Drawing.Color.Transparent
        Me.LabelX9.Size = New System.Drawing.Size(21, 21)
        Me.UserNameTooltip.SetSuperTooltip(Me.LabelX9, New DevComponents.DotNetBar.SuperTooltipInfo("Required", "", "Format: (xxx)xxx-xxxx" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Example: (123)456-7890", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray, True, False, New System.Drawing.Size(0, 0)))
        Me.LabelX9.TabIndex = 46
        '
        'LabelX10
        '
        '
        '
        '
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX10.Image = Global.OMS.My.Resources.Resources.ic_help_outline_black_18dp_1x
        Me.LabelX10.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.LabelX10.Location = New System.Drawing.Point(604, 117)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.SingleLineColor = System.Drawing.Color.Transparent
        Me.LabelX10.Size = New System.Drawing.Size(21, 21)
        Me.UserNameTooltip.SetSuperTooltip(Me.LabelX10, New DevComponents.DotNetBar.SuperTooltipInfo("Required", "", "example@company.xyz", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray, True, False, New System.Drawing.Size(0, 0)))
        Me.LabelX10.TabIndex = 47
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
        Me.EmployeeEmailTextBox.Location = New System.Drawing.Point(422, 117)
        Me.EmployeeEmailTextBox.Name = "EmployeeEmailTextBox"
        Me.EmployeeEmailTextBox.PreventEnterBeep = True
        Me.EmployeeEmailTextBox.Size = New System.Drawing.Size(162, 23)
        Me.EmployeeEmailTextBox.TabIndex = 9
        Me.EmployeeEmailTextBox.WatermarkText = "example@company.xyz"
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
        Me.EmployeePhoneTextBox.Location = New System.Drawing.Point(422, 38)
        Me.EmployeePhoneTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.EmployeePhoneTextBox.Mask = "(999)000-0000"
        Me.EmployeePhoneTextBox.Name = "EmployeePhoneTextBox"
        Me.EmployeePhoneTextBox.Size = New System.Drawing.Size(114, 20)
        Me.EmployeePhoneTextBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.EmployeePhoneTextBox.TabIndex = 7
        Me.EmployeePhoneTextBox.Text = ""
        '
        'AddressButton
        '
        Me.AddressButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.AddressButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.AddressButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressButton.Location = New System.Drawing.Point(110, 252)
        Me.AddressButton.Margin = New System.Windows.Forms.Padding(2)
        Me.AddressButton.Name = "AddressButton"
        Me.AddressButton.Size = New System.Drawing.Size(85, 37)
        Me.AddressButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.AddressButton.TabIndex = 6
        Me.AddressButton.Text = "Add Address"
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
        Me.EmployeeUserNameTextBox.Location = New System.Drawing.Point(110, 32)
        Me.EmployeeUserNameTextBox.Name = "EmployeeUserNameTextBox"
        Me.EmployeeUserNameTextBox.PreventEnterBeep = True
        Me.EmployeeUserNameTextBox.Size = New System.Drawing.Size(162, 23)
        Me.EmployeeUserNameTextBox.TabIndex = 1
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
        Me.EmployeePasswordTextBox.Location = New System.Drawing.Point(110, 73)
        Me.EmployeePasswordTextBox.Name = "EmployeePasswordTextBox"
        Me.EmployeePasswordTextBox.PreventEnterBeep = True
        Me.EmployeePasswordTextBox.Size = New System.Drawing.Size(162, 23)
        Me.EmployeePasswordTextBox.TabIndex = 2
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
        Me.EmployeeFirstNameTextBox.Location = New System.Drawing.Point(110, 159)
        Me.EmployeeFirstNameTextBox.Name = "EmployeeFirstNameTextBox"
        Me.EmployeeFirstNameTextBox.PreventEnterBeep = True
        Me.EmployeeFirstNameTextBox.Size = New System.Drawing.Size(162, 23)
        Me.EmployeeFirstNameTextBox.TabIndex = 4
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
        Me.EmployeeLastNameTextBox.Location = New System.Drawing.Point(110, 204)
        Me.EmployeeLastNameTextBox.Name = "EmployeeLastNameTextBox"
        Me.EmployeeLastNameTextBox.PreventEnterBeep = True
        Me.EmployeeLastNameTextBox.Size = New System.Drawing.Size(162, 23)
        Me.EmployeeLastNameTextBox.TabIndex = 5
        '
        'EmployeePositionComboBox
        '
        Me.EmployeePositionComboBox.DisplayMember = "Text"
        Me.EmployeePositionComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.EmployeePositionComboBox.FormattingEnabled = True
        Me.EmployeePositionComboBox.ItemHeight = 17
        Me.EmployeePositionComboBox.Location = New System.Drawing.Point(110, 114)
        Me.EmployeePositionComboBox.Name = "EmployeePositionComboBox"
        Me.EmployeePositionComboBox.Size = New System.Drawing.Size(162, 23)
        Me.EmployeePositionComboBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.EmployeePositionComboBox.TabIndex = 3
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
        Me.EmployeeDateHiredDateTimePicker.Location = New System.Drawing.Point(422, 75)
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
        Me.EmployeeDateHiredDateTimePicker.Size = New System.Drawing.Size(200, 23)
        Me.EmployeeDateHiredDateTimePicker.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.EmployeeDateHiredDateTimePicker.TabIndex = 8
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
        Me.EmployeeDOBDateTimePicker.Location = New System.Drawing.Point(422, 158)
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
        Me.EmployeeDOBDateTimePicker.Size = New System.Drawing.Size(200, 23)
        Me.EmployeeDOBDateTimePicker.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.EmployeeDOBDateTimePicker.TabIndex = 11
        '
        'SignUpForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 312)
        Me.Controls.Add(Me.EmployeeDOBDateTimePicker)
        Me.Controls.Add(Me.EmployeeDateHiredDateTimePicker)
        Me.Controls.Add(Me.EmployeePositionComboBox)
        Me.Controls.Add(Me.EmployeeLastNameTextBox)
        Me.Controls.Add(Me.EmployeeFirstNameTextBox)
        Me.Controls.Add(Me.EmployeePasswordTextBox)
        Me.Controls.Add(Me.EmployeeUserNameTextBox)
        Me.Controls.Add(Me.AddressButton)
        Me.Controls.Add(Me.EmployeePhoneTextBox)
        Me.Controls.Add(Me.EmployeeEmailTextBox)
        Me.Controls.Add(Me.LabelX10)
        Me.Controls.Add(Me.LabelX9)
        Me.Controls.Add(Me.LabelX7)
        Me.Controls.Add(Me.LabelX5)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.EmployeeCancelButton)
        Me.Controls.Add(Me.EmployeeSaveButton)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(686, 351)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(686, 351)
        Me.Name = "SignUpForm"
        Me.Text = "Sign Up"
        CType(Me.EmployeeErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeDateHiredDateTimePicker, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeDOBDateTimePicker, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents EmployeeErrorProvider As ErrorProvider
    Friend WithEvents EmployeeCancelButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents EmployeeSaveButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents UserNameTooltip As DevComponents.DotNetBar.SuperTooltip
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents EmployeeEmailTextBox As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents EmployeePhoneTextBox As DevComponents.DotNetBar.Controls.MaskedTextBoxAdv
    Friend WithEvents AddressButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents EmployeeLastNameTextBox As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents EmployeeFirstNameTextBox As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents EmployeePasswordTextBox As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents EmployeeUserNameTextBox As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents EmployeePositionComboBox As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents EmployeeDOBDateTimePicker As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents EmployeeDateHiredDateTimePicker As DevComponents.Editors.DateTimeAdv.DateTimeInput
End Class
