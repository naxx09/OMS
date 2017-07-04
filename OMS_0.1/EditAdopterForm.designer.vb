<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditAdopterForm
    Inherits DevComponents.DotNetBar.Office2007Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditAdopterForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AdopterTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.IncomeTextBox = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.MarriageComboBox = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.EmployeeIdTextBox = New System.Windows.Forms.TextBox()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.SuperTooltip1 = New DevComponents.DotNetBar.SuperTooltip()
        Me.EditsaveButton = New DevComponents.DotNetBar.ButtonX()
        Me.SaveButton = New DevComponents.DotNetBar.ButtonX()
        Me.CancelButton = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.DateTimePicker1 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.AddressButton = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.GenderComboBox = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupPanel3 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.DateTimePicker1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(59, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Adopter ID:"
        '
        'AdopterTextBox
        '
        Me.AdopterTextBox.Enabled = False
        Me.AdopterTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdopterTextBox.Location = New System.Drawing.Point(156, 28)
        Me.AdopterTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.AdopterTextBox.Name = "AdopterTextBox"
        Me.AdopterTextBox.Size = New System.Drawing.Size(132, 27)
        Me.AdopterTextBox.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(55, 97)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 20)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Email:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(48, 37)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 20)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Phone:"
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.Location = New System.Drawing.Point(115, 33)
        Me.PhoneTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(132, 27)
        Me.PhoneTextBox.TabIndex = 18
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(116, 94)
        Me.EmailTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(132, 27)
        Me.EmailTextBox.TabIndex = 19
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(332, 37)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 20)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Income/year:"
        '
        'IncomeTextBox
        '
        Me.IncomeTextBox.Location = New System.Drawing.Point(441, 33)
        Me.IncomeTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.IncomeTextBox.Name = "IncomeTextBox"
        Me.IncomeTextBox.Size = New System.Drawing.Size(160, 27)
        Me.IncomeTextBox.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(357, 91)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 20)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Marriage:"
        '
        'MarriageComboBox
        '
        Me.MarriageComboBox.DisplayMember = "Text"
        Me.MarriageComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.MarriageComboBox.FormattingEnabled = True
        Me.MarriageComboBox.ItemHeight = 21
        Me.MarriageComboBox.Location = New System.Drawing.Point(441, 89)
        Me.MarriageComboBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MarriageComboBox.Name = "MarriageComboBox"
        Me.MarriageComboBox.Size = New System.Drawing.Size(160, 27)
        Me.MarriageComboBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.MarriageComboBox.TabIndex = 37
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(52, 149)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(137, 24)
        Me.CheckBox1.TabIndex = 27
        Me.CheckBox1.Text = "Criminal History"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(459, 32)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(97, 20)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Employee ID:"
        '
        'EmployeeIdTextBox
        '
        Me.EmployeeIdTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeIdTextBox.Location = New System.Drawing.Point(568, 28)
        Me.EmployeeIdTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.EmployeeIdTextBox.Name = "EmployeeIdTextBox"
        Me.EmployeeIdTextBox.Size = New System.Drawing.Size(132, 27)
        Me.EmployeeIdTextBox.TabIndex = 33
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
        'EditsaveButton
        '
        Me.EditsaveButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.EditsaveButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.EditsaveButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditsaveButton.Location = New System.Drawing.Point(821, 32)
        Me.EditsaveButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.EditsaveButton.Name = "EditsaveButton"
        Me.EditsaveButton.Size = New System.Drawing.Size(100, 28)
        Me.EditsaveButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.EditsaveButton.TabIndex = 38
        Me.EditsaveButton.Text = "&Edit"
        '
        'SaveButton
        '
        Me.SaveButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.SaveButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.SaveButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.Location = New System.Drawing.Point(821, 82)
        Me.SaveButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(100, 28)
        Me.SaveButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SaveButton.TabIndex = 0
        Me.SaveButton.Text = "&Save"
        '
        'CancelButton
        '
        Me.CancelButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.CancelButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.CancelButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelButton.Location = New System.Drawing.Point(821, 148)
        Me.CancelButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(100, 28)
        Me.CancelButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CancelButton.TabIndex = 39
        Me.CancelButton.Text = "&Exit"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.DateTimePicker1)
        Me.GroupPanel1.Controls.Add(Me.AddressButton)
        Me.GroupPanel1.Controls.Add(Me.LabelX1)
        Me.GroupPanel1.Controls.Add(Me.GenderComboBox)
        Me.GroupPanel1.Controls.Add(Me.Label2)
        Me.GroupPanel1.Controls.Add(Me.FNameTextBox)
        Me.GroupPanel1.Controls.Add(Me.Label3)
        Me.GroupPanel1.Controls.Add(Me.LNameTextBox)
        Me.GroupPanel1.Controls.Add(Me.Label4)
        Me.GroupPanel1.Controls.Add(Me.Label5)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel1.Location = New System.Drawing.Point(37, 82)
        Me.GroupPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(731, 228)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 35
        Me.GroupPanel1.Text = "Basic Information"
        '
        'DateTimePicker1
        '
        '
        '
        '
        Me.DateTimePicker1.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.DateTimePicker1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateTimePicker1.ButtonClear.Tooltip = ""
        Me.DateTimePicker1.ButtonCustom.Tooltip = ""
        Me.DateTimePicker1.ButtonCustom2.Tooltip = ""
        Me.DateTimePicker1.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.DateTimePicker1.ButtonDropDown.Tooltip = ""
        Me.DateTimePicker1.ButtonDropDown.Visible = True
        Me.DateTimePicker1.ButtonFreeText.Tooltip = ""
        Me.DateTimePicker1.IsPopupCalendarOpen = False
        Me.DateTimePicker1.Location = New System.Drawing.Point(408, 96)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        '
        '
        '
        Me.DateTimePicker1.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.DateTimePicker1.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateTimePicker1.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.DateTimePicker1.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.DateTimePicker1.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.DateTimePicker1.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.DateTimePicker1.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.DateTimePicker1.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.DateTimePicker1.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.DateTimePicker1.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.DateTimePicker1.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateTimePicker1.MonthCalendar.DisplayMonth = New Date(2016, 11, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.DateTimePicker1.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.DateTimePicker1.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.DateTimePicker1.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.DateTimePicker1.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.DateTimePicker1.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateTimePicker1.MonthCalendar.TodayButtonVisible = True
        Me.DateTimePicker1.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(267, 27)
        Me.DateTimePicker1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.DateTimePicker1.TabIndex = 45
        '
        'AddressButton
        '
        Me.AddressButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.AddressButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.AddressButton.Location = New System.Drawing.Point(115, 154)
        Me.AddressButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.AddressButton.Name = "AddressButton"
        Me.AddressButton.Size = New System.Drawing.Size(100, 28)
        Me.AddressButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.AddressButton.TabIndex = 44
        Me.AddressButton.Text = "&Add Address"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(36, 154)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(71, 28)
        Me.LabelX1.TabIndex = 43
        Me.LabelX1.Text = "Address:"
        '
        'GenderComboBox
        '
        Me.GenderComboBox.DisplayMember = "Text"
        Me.GenderComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.GenderComboBox.FormattingEnabled = True
        Me.GenderComboBox.ItemHeight = 21
        Me.GenderComboBox.Location = New System.Drawing.Point(115, 96)
        Me.GenderComboBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GenderComboBox.Name = "GenderComboBox"
        Me.GenderComboBox.Size = New System.Drawing.Size(160, 27)
        Me.GenderComboBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.GenderComboBox.TabIndex = 42
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(17, 32)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 20)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "First Name:"
        '
        'FNameTextBox
        '
        Me.FNameTextBox.Location = New System.Drawing.Point(115, 28)
        Me.FNameTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.FNameTextBox.Name = "FNameTextBox"
        Me.FNameTextBox.Size = New System.Drawing.Size(132, 27)
        Me.FNameTextBox.TabIndex = 36
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(312, 32)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 20)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Last Name:"
        '
        'LNameTextBox
        '
        Me.LNameTextBox.Location = New System.Drawing.Point(408, 28)
        Me.LNameTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LNameTextBox.Name = "LNameTextBox"
        Me.LNameTextBox.Size = New System.Drawing.Size(132, 27)
        Me.LNameTextBox.TabIndex = 38
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(43, 96)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 20)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Gender:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(299, 103)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 20)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Date of Birth:"
        '
        'GroupPanel3
        '
        Me.GroupPanel3.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel3.Controls.Add(Me.MarriageComboBox)
        Me.GroupPanel3.Controls.Add(Me.IncomeTextBox)
        Me.GroupPanel3.Controls.Add(Me.CheckBox1)
        Me.GroupPanel3.Controls.Add(Me.Label11)
        Me.GroupPanel3.Controls.Add(Me.EmailTextBox)
        Me.GroupPanel3.Controls.Add(Me.Label7)
        Me.GroupPanel3.Controls.Add(Me.Label12)
        Me.GroupPanel3.Controls.Add(Me.Label8)
        Me.GroupPanel3.Controls.Add(Me.PhoneTextBox)
        Me.GroupPanel3.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel3.Location = New System.Drawing.Point(37, 330)
        Me.GroupPanel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupPanel3.Name = "GroupPanel3"
        Me.GroupPanel3.Size = New System.Drawing.Size(731, 217)
        '
        '
        '
        Me.GroupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel3.Style.BackColorGradientAngle = 90
        Me.GroupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderBottomWidth = 1
        Me.GroupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderLeftWidth = 1
        Me.GroupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderRightWidth = 1
        Me.GroupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderTopWidth = 1
        Me.GroupPanel3.Style.CornerDiameter = 4
        Me.GroupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel3.TabIndex = 0
        Me.GroupPanel3.Text = "Additional Information"
        '
        'EditAdopterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 561)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.GroupPanel3)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.EditsaveButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.EmployeeIdTextBox)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.AdopterTextBox)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(967, 608)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(967, 608)
        Me.Name = "EditAdopterForm"
        Me.Text = "Adopter"
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        CType(Me.DateTimePicker1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel3.ResumeLayout(False)
        Me.GroupPanel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents AdopterTextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents IncomeTextBox As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents EmployeeIdTextBox As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents MarriageComboBox As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents SuperTooltip1 As DevComponents.DotNetBar.SuperTooltip
    Friend WithEvents EditsaveButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents SaveButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents CancelButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GenderComboBox As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label2 As Label
    Friend WithEvents FNameTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents LNameTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupPanel3 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents AddressButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents DateTimePicker1 As DevComponents.Editors.DateTimeAdv.DateTimeInput
End Class
