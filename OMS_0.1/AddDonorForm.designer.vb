<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddDonorForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddDonorForm))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.AddressButton = New DevComponents.DotNetBar.ButtonX()
        Me.SubmitButton = New DevComponents.DotNetBar.ButtonX()
        Me.ClearButton = New DevComponents.DotNetBar.ButtonX()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.SuperTooltip1 = New DevComponents.DotNetBar.SuperTooltip()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.SupervisorTextBox = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.FNTextBox = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.EmailTextBox = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LNTextBox = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.PhoneTextBox = New DevComponents.DotNetBar.Controls.MaskedTextBoxAdv()
        Me.GenderComboBox = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.DOBDateTimePicker = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.ANTextBox = New DevComponents.DotNetBar.Controls.MaskedTextBoxAdv()
        CType(Me.DOBDateTimePicker, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(35, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 15)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Last Name:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 15)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "First Name: "
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(346, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 15)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Phone:"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 15)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Supervisor:"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(63, 172)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 15)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "DOB:"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(338, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 15)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "Address:"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(349, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 15)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "Email:"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 15)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Gender:"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(292, 135)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(102, 15)
        Me.Label12.TabIndex = 84
        Me.Label12.Text = "Account Number:"
        '
        'AddressButton
        '
        Me.AddressButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.AddressButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.AddressButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.AddressButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressButton.Location = New System.Drawing.Point(404, 24)
        Me.AddressButton.Name = "AddressButton"
        Me.AddressButton.Size = New System.Drawing.Size(75, 23)
        Me.AddressButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.AddressButton.TabIndex = 6
        Me.AddressButton.Text = "&Add Address"
        '
        'SubmitButton
        '
        Me.SubmitButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.SubmitButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.SubmitButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.SubmitButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubmitButton.Location = New System.Drawing.Point(366, 210)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(75, 23)
        Me.SubmitButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SubmitButton.TabIndex = 10
        Me.SubmitButton.Text = "&Submit"
        '
        'ClearButton
        '
        Me.ClearButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ClearButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ClearButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ClearButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(105, 210)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ClearButton.TabIndex = 20
        Me.ClearButton.Text = "&Clear"
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007VistaGlass
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(154, Byte), Integer)))
        '
        'SuperTooltip1
        '
        Me.SuperTooltip1.DefaultTooltipSettings = New DevComponents.DotNetBar.SuperTooltipInfo("", "", "", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray)
        '
        'LabelX3
        '
        Me.LabelX3.Anchor = System.Windows.Forms.AnchorStyles.Top
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Image = Global.OMS.My.Resources.Resources.ic_help_outline_black_18dp_1x
        Me.LabelX3.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.LabelX3.Location = New System.Drawing.Point(249, 62)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.SingleLineColor = System.Drawing.Color.Transparent
        Me.LabelX3.Size = New System.Drawing.Size(18, 18)
        Me.SuperTooltip1.SetSuperTooltip(Me.LabelX3, New DevComponents.DotNetBar.SuperTooltipInfo("Required", "", "First name can contain letters (A-Z and a-z) and number (0-9), with a minimum of " &
            "1 characters, and a maximum of 30 characters.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray, True, False, New System.Drawing.Size(0, 0)))
        Me.LabelX3.TabIndex = 109
        '
        'LabelX4
        '
        Me.LabelX4.Anchor = System.Windows.Forms.AnchorStyles.Top
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.Image = Global.OMS.My.Resources.Resources.ic_help_outline_black_18dp_1x
        Me.LabelX4.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.LabelX4.Location = New System.Drawing.Point(249, 101)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.SingleLineColor = System.Drawing.Color.Transparent
        Me.LabelX4.Size = New System.Drawing.Size(18, 18)
        Me.SuperTooltip1.SetSuperTooltip(Me.LabelX4, New DevComponents.DotNetBar.SuperTooltipInfo("Required", "", "Last name can contain letters (A-Z and a-z) and number (0-9), with a minimum of 1" &
            " characters, and a maximum of 30 characters.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray, True, False, New System.Drawing.Size(0, 0)))
        Me.LabelX4.TabIndex = 110
        '
        'LabelX6
        '
        Me.LabelX6.Anchor = System.Windows.Forms.AnchorStyles.Top
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX6.Image = Global.OMS.My.Resources.Resources.ic_help_outline_black_18dp_1x
        Me.LabelX6.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.LabelX6.Location = New System.Drawing.Point(498, 60)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.SingleLineColor = System.Drawing.Color.Transparent
        Me.LabelX6.Size = New System.Drawing.Size(18, 18)
        Me.SuperTooltip1.SetSuperTooltip(Me.LabelX6, New DevComponents.DotNetBar.SuperTooltipInfo("Required", "", "Format: (xxx)xxx-xxxx" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Example: (123)456-7890", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray, True, False, New System.Drawing.Size(0, 0)))
        Me.LabelX6.TabIndex = 112
        '
        'LabelX5
        '
        Me.LabelX5.Anchor = System.Windows.Forms.AnchorStyles.Top
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.Image = Global.OMS.My.Resources.Resources.ic_help_outline_black_18dp_1x
        Me.LabelX5.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.LabelX5.Location = New System.Drawing.Point(541, 97)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.SingleLineColor = System.Drawing.Color.Transparent
        Me.LabelX5.Size = New System.Drawing.Size(18, 18)
        Me.SuperTooltip1.SetSuperTooltip(Me.LabelX5, New DevComponents.DotNetBar.SuperTooltipInfo("Required", "", "example@company.xyz", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray, True, False, New System.Drawing.Size(0, 0)))
        Me.LabelX5.TabIndex = 113
        '
        'SupervisorTextBox
        '
        Me.SupervisorTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        '
        '
        '
        Me.SupervisorTextBox.Border.Class = "TextBoxBorder"
        Me.SupervisorTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.SupervisorTextBox.ButtonCustom.Tooltip = ""
        Me.SupervisorTextBox.ButtonCustom2.Tooltip = ""
        Me.SupervisorTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SupervisorTextBox.Location = New System.Drawing.Point(102, 25)
        Me.SupervisorTextBox.Name = "SupervisorTextBox"
        Me.SupervisorTextBox.PreventEnterBeep = True
        Me.SupervisorTextBox.Size = New System.Drawing.Size(141, 23)
        Me.SupervisorTextBox.TabIndex = 1
        '
        'FNTextBox
        '
        Me.FNTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        '
        '
        '
        Me.FNTextBox.Border.Class = "TextBoxBorder"
        Me.FNTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.FNTextBox.ButtonCustom.Tooltip = ""
        Me.FNTextBox.ButtonCustom2.Tooltip = ""
        Me.FNTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FNTextBox.Location = New System.Drawing.Point(102, 60)
        Me.FNTextBox.MaxLength = 30
        Me.FNTextBox.Name = "FNTextBox"
        Me.FNTextBox.PreventEnterBeep = True
        Me.FNTextBox.Size = New System.Drawing.Size(141, 23)
        Me.FNTextBox.TabIndex = 2
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        '
        '
        '
        Me.EmailTextBox.Border.Class = "TextBoxBorder"
        Me.EmailTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.EmailTextBox.ButtonCustom.Tooltip = ""
        Me.EmailTextBox.ButtonCustom2.Tooltip = ""
        Me.EmailTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTextBox.Location = New System.Drawing.Point(395, 96)
        Me.EmailTextBox.MaxLength = 50
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.PreventEnterBeep = True
        Me.EmailTextBox.Size = New System.Drawing.Size(141, 23)
        Me.EmailTextBox.TabIndex = 8
        Me.EmailTextBox.WatermarkText = "example@company.xyz"
        '
        'LNTextBox
        '
        Me.LNTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        '
        '
        '
        Me.LNTextBox.Border.Class = "TextBoxBorder"
        Me.LNTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LNTextBox.ButtonCustom.Tooltip = ""
        Me.LNTextBox.ButtonCustom2.Tooltip = ""
        Me.LNTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNTextBox.Location = New System.Drawing.Point(102, 97)
        Me.LNTextBox.MaxLength = 30
        Me.LNTextBox.Name = "LNTextBox"
        Me.LNTextBox.PreventEnterBeep = True
        Me.LNTextBox.Size = New System.Drawing.Size(141, 23)
        Me.LNTextBox.TabIndex = 3
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        '
        '
        '
        Me.PhoneTextBox.BackgroundStyle.Class = "TextBoxBorder"
        Me.PhoneTextBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.PhoneTextBox.ButtonClear.Tooltip = ""
        Me.PhoneTextBox.ButtonClear.Visible = True
        Me.PhoneTextBox.ButtonCustom.Tooltip = ""
        Me.PhoneTextBox.ButtonCustom2.Tooltip = ""
        Me.PhoneTextBox.ButtonDropDown.Tooltip = ""
        Me.PhoneTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneTextBox.Location = New System.Drawing.Point(395, 61)
        Me.PhoneTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.PhoneTextBox.Mask = "(999)000-0000"
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(98, 17)
        Me.PhoneTextBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PhoneTextBox.TabIndex = 7
        Me.PhoneTextBox.Text = ""
        '
        'GenderComboBox
        '
        Me.GenderComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GenderComboBox.DisplayMember = "Text"
        Me.GenderComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.GenderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GenderComboBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenderComboBox.FormattingEnabled = True
        Me.GenderComboBox.ItemHeight = 17
        Me.GenderComboBox.Location = New System.Drawing.Point(102, 135)
        Me.GenderComboBox.Name = "GenderComboBox"
        Me.GenderComboBox.Size = New System.Drawing.Size(94, 23)
        Me.GenderComboBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.GenderComboBox.TabIndex = 4
        '
        'DOBDateTimePicker
        '
        Me.DOBDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Top
        '
        '
        '
        Me.DOBDateTimePicker.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.DOBDateTimePicker.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DOBDateTimePicker.ButtonClear.Tooltip = ""
        Me.DOBDateTimePicker.ButtonCustom.Tooltip = ""
        Me.DOBDateTimePicker.ButtonCustom2.Tooltip = ""
        Me.DOBDateTimePicker.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.DOBDateTimePicker.ButtonDropDown.Tooltip = ""
        Me.DOBDateTimePicker.ButtonDropDown.Visible = True
        Me.DOBDateTimePicker.ButtonFreeText.Tooltip = ""
        Me.DOBDateTimePicker.IsPopupCalendarOpen = False
        Me.DOBDateTimePicker.Location = New System.Drawing.Point(103, 173)
        '
        '
        '
        Me.DOBDateTimePicker.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.DOBDateTimePicker.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DOBDateTimePicker.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.DOBDateTimePicker.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.DOBDateTimePicker.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.DOBDateTimePicker.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.DOBDateTimePicker.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.DOBDateTimePicker.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.DOBDateTimePicker.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.DOBDateTimePicker.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.DOBDateTimePicker.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DOBDateTimePicker.MonthCalendar.DisplayMonth = New Date(2016, 11, 1, 0, 0, 0, 0)
        Me.DOBDateTimePicker.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.DOBDateTimePicker.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.DOBDateTimePicker.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.DOBDateTimePicker.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.DOBDateTimePicker.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.DOBDateTimePicker.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DOBDateTimePicker.MonthCalendar.TodayButtonVisible = True
        Me.DOBDateTimePicker.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.DOBDateTimePicker.Name = "DOBDateTimePicker"
        Me.DOBDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DOBDateTimePicker.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.DOBDateTimePicker.TabIndex = 5
        '
        'ANTextBox
        '
        Me.ANTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        '
        '
        '
        Me.ANTextBox.BackgroundStyle.Class = "TextBoxBorder"
        Me.ANTextBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ANTextBox.ButtonClear.Tooltip = ""
        Me.ANTextBox.ButtonClear.Visible = True
        Me.ANTextBox.ButtonCustom.Tooltip = ""
        Me.ANTextBox.ButtonCustom2.Tooltip = ""
        Me.ANTextBox.ButtonDropDown.Tooltip = ""
        Me.ANTextBox.Location = New System.Drawing.Point(395, 134)
        Me.ANTextBox.Mask = "0000-0000-0000-0000"
        Me.ANTextBox.Name = "ANTextBox"
        Me.ANTextBox.Size = New System.Drawing.Size(129, 19)
        Me.ANTextBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ANTextBox.TabIndex = 114
        Me.ANTextBox.Text = ""
        '
        'AddDonorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 257)
        Me.Controls.Add(Me.ANTextBox)
        Me.Controls.Add(Me.DOBDateTimePicker)
        Me.Controls.Add(Me.LabelX5)
        Me.Controls.Add(Me.LabelX6)
        Me.Controls.Add(Me.GenderComboBox)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.PhoneTextBox)
        Me.Controls.Add(Me.LNTextBox)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.FNTextBox)
        Me.Controls.Add(Me.SupervisorTextBox)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.SubmitButton)
        Me.Controls.Add(Me.AddressButton)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddDonorForm"
        Me.Text = "New Donor"
        CType(Me.DOBDateTimePicker, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents AddressButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents SubmitButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ClearButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents SuperTooltip1 As DevComponents.DotNetBar.SuperTooltip
    Friend WithEvents SupervisorTextBox As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents FNTextBox As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents EmailTextBox As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LNTextBox As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents PhoneTextBox As DevComponents.DotNetBar.Controls.MaskedTextBoxAdv
    Private WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Private WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GenderComboBox As DevComponents.DotNetBar.Controls.ComboBoxEx
    Private WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Private WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents DOBDateTimePicker As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents ANTextBox As DevComponents.DotNetBar.Controls.MaskedTextBoxAdv
End Class
