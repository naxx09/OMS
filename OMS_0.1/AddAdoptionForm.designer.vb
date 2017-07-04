<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddAdoptionForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.MPhoneTextBox = New System.Windows.Forms.TextBox()
        Me.FPhoneTextBox = New System.Windows.Forms.TextBox()
        Me.MageTextBox = New System.Windows.Forms.TextBox()
        Me.FAgeTextBox = New System.Windows.Forms.TextBox()
        Me.MLNameTextBox = New System.Windows.Forms.TextBox()
        Me.FLnameTextBox = New System.Windows.Forms.TextBox()
        Me.MFNameTextBox = New System.Windows.Forms.TextBox()
        Me.FFnameTextBox = New System.Windows.Forms.TextBox()
        Me.MotherIDTextBox = New System.Windows.Forms.TextBox()
        Me.FatherIDTextBox = New System.Windows.Forms.TextBox()
        Me.SPositonTextBox = New System.Windows.Forms.TextBox()
        Me.SNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.AdoptionIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.CreateSaveButton = New DevComponents.DotNetBar.ButtonX()
        Me.EmailButton = New DevComponents.DotNetBar.ButtonX()
        Me.ApplicaitonDataGridView = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.DateTimePicker1 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ChildIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.LNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.CMnameTextBox = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.CFnameTextBox = New System.Windows.Forms.TextBox()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.FatherEmailTextBox = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.GroupPanel3 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.MotherEmailTextBox = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.GroupPanel4 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SupervisorIDTextBox = New System.Windows.Forms.TextBox()
        Me.DateDateTimePicker = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.SuperTooltip1 = New DevComponents.DotNetBar.SuperTooltip()
        Me.RefreshButton = New DevComponents.DotNetBar.ButtonX()
        CType(Me.ApplicaitonDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.DateTimePicker1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel2.SuspendLayout()
        Me.GroupPanel3.SuspendLayout()
        Me.GroupPanel4.SuspendLayout()
        CType(Me.DateDateTimePicker, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(81, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Adoption ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(32, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Father ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(29, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Mother ID:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(26, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "First Name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(26, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "First Name:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(26, 95)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Last Name:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(25, 100)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Last Name:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(57, 138)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Age:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(57, 139)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 13)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Age:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(5, 174)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 13)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Phone Number:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(5, 175)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 13)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Phone Number:"
        '
        'MPhoneTextBox
        '
        Me.MPhoneTextBox.Location = New System.Drawing.Point(88, 172)
        Me.MPhoneTextBox.Name = "MPhoneTextBox"
        Me.MPhoneTextBox.Size = New System.Drawing.Size(116, 20)
        Me.MPhoneTextBox.TabIndex = 12
        '
        'FPhoneTextBox
        '
        Me.FPhoneTextBox.Location = New System.Drawing.Point(92, 171)
        Me.FPhoneTextBox.Name = "FPhoneTextBox"
        Me.FPhoneTextBox.Size = New System.Drawing.Size(116, 20)
        Me.FPhoneTextBox.TabIndex = 12
        '
        'MageTextBox
        '
        Me.MageTextBox.Location = New System.Drawing.Point(88, 136)
        Me.MageTextBox.Name = "MageTextBox"
        Me.MageTextBox.Size = New System.Drawing.Size(116, 20)
        Me.MageTextBox.TabIndex = 12
        '
        'FAgeTextBox
        '
        Me.FAgeTextBox.Location = New System.Drawing.Point(92, 135)
        Me.FAgeTextBox.Name = "FAgeTextBox"
        Me.FAgeTextBox.Size = New System.Drawing.Size(116, 20)
        Me.FAgeTextBox.TabIndex = 12
        '
        'MLNameTextBox
        '
        Me.MLNameTextBox.Location = New System.Drawing.Point(88, 97)
        Me.MLNameTextBox.Name = "MLNameTextBox"
        Me.MLNameTextBox.Size = New System.Drawing.Size(116, 20)
        Me.MLNameTextBox.TabIndex = 12
        '
        'FLnameTextBox
        '
        Me.FLnameTextBox.Location = New System.Drawing.Point(92, 92)
        Me.FLnameTextBox.Name = "FLnameTextBox"
        Me.FLnameTextBox.Size = New System.Drawing.Size(116, 20)
        Me.FLnameTextBox.TabIndex = 12
        '
        'MFNameTextBox
        '
        Me.MFNameTextBox.Location = New System.Drawing.Point(88, 53)
        Me.MFNameTextBox.Name = "MFNameTextBox"
        Me.MFNameTextBox.Size = New System.Drawing.Size(116, 20)
        Me.MFNameTextBox.TabIndex = 12
        '
        'FFnameTextBox
        '
        Me.FFnameTextBox.Location = New System.Drawing.Point(92, 52)
        Me.FFnameTextBox.Name = "FFnameTextBox"
        Me.FFnameTextBox.Size = New System.Drawing.Size(116, 20)
        Me.FFnameTextBox.TabIndex = 12
        '
        'MotherIDTextBox
        '
        Me.MotherIDTextBox.Location = New System.Drawing.Point(88, 17)
        Me.MotherIDTextBox.Name = "MotherIDTextBox"
        Me.MotherIDTextBox.Size = New System.Drawing.Size(116, 20)
        Me.MotherIDTextBox.TabIndex = 12
        '
        'FatherIDTextBox
        '
        Me.FatherIDTextBox.Location = New System.Drawing.Point(92, 16)
        Me.FatherIDTextBox.Name = "FatherIDTextBox"
        Me.FatherIDTextBox.Size = New System.Drawing.Size(116, 20)
        Me.FatherIDTextBox.TabIndex = 12
        '
        'SPositonTextBox
        '
        Me.SPositonTextBox.Location = New System.Drawing.Point(87, 90)
        Me.SPositonTextBox.Name = "SPositonTextBox"
        Me.SPositonTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SPositonTextBox.TabIndex = 12
        '
        'SNameTextBox
        '
        Me.SNameTextBox.Location = New System.Drawing.Point(87, 55)
        Me.SNameTextBox.Name = "SNameTextBox"
        Me.SNameTextBox.Size = New System.Drawing.Size(181, 20)
        Me.SNameTextBox.TabIndex = 12
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(36, 93)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 13)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Postion:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(43, 58)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(38, 13)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Name:"
        '
        'AdoptionIDTextBox
        '
        Me.AdoptionIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.AdoptionIDTextBox.Location = New System.Drawing.Point(163, 31)
        Me.AdoptionIDTextBox.Name = "AdoptionIDTextBox"
        Me.AdoptionIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AdoptionIDTextBox.TabIndex = 12
        '
        'Label20
        '
        Me.Label20.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(107, 65)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(33, 13)
        Me.Label20.TabIndex = 16
        Me.Label20.Text = "Date:"
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007VistaGlass
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(154, Byte), Integer)))
        '
        'CreateSaveButton
        '
        Me.CreateSaveButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.CreateSaveButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CreateSaveButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.CreateSaveButton.Location = New System.Drawing.Point(89, 95)
        Me.CreateSaveButton.Margin = New System.Windows.Forms.Padding(2)
        Me.CreateSaveButton.Name = "CreateSaveButton"
        Me.CreateSaveButton.Size = New System.Drawing.Size(74, 19)
        Me.CreateSaveButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CreateSaveButton.TabIndex = 20
        Me.CreateSaveButton.Text = "&Create"
        '
        'EmailButton
        '
        Me.EmailButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.EmailButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.EmailButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.EmailButton.Location = New System.Drawing.Point(189, 94)
        Me.EmailButton.Margin = New System.Windows.Forms.Padding(2)
        Me.EmailButton.Name = "EmailButton"
        Me.EmailButton.Size = New System.Drawing.Size(90, 19)
        Me.EmailButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.EmailButton.TabIndex = 0
        Me.EmailButton.Text = "&Email Adopter"
        '
        'ApplicaitonDataGridView
        '
        Me.ApplicaitonDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ApplicaitonDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.ApplicaitonDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ApplicaitonDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.ApplicaitonDataGridView.EnableHeadersVisualStyles = False
        Me.ApplicaitonDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ApplicaitonDataGridView.Location = New System.Drawing.Point(390, 10)
        Me.ApplicaitonDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.ApplicaitonDataGridView.Name = "ApplicaitonDataGridView"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ApplicaitonDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.ApplicaitonDataGridView.RowTemplate.Height = 24
        Me.ApplicaitonDataGridView.Size = New System.Drawing.Size(452, 198)
        Me.ApplicaitonDataGridView.TabIndex = 21
        '
        'GroupPanel1
        '
        Me.GroupPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.DateTimePicker1)
        Me.GroupPanel1.Controls.Add(Me.Label19)
        Me.GroupPanel1.Controls.Add(Me.ChildIDTextBox)
        Me.GroupPanel1.Controls.Add(Me.Label16)
        Me.GroupPanel1.Controls.Add(Me.Label15)
        Me.GroupPanel1.Controls.Add(Me.LNameTextBox)
        Me.GroupPanel1.Controls.Add(Me.Label18)
        Me.GroupPanel1.Controls.Add(Me.CMnameTextBox)
        Me.GroupPanel1.Controls.Add(Me.Label17)
        Me.GroupPanel1.Controls.Add(Me.CFnameTextBox)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Location = New System.Drawing.Point(39, 145)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(298, 212)
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
        Me.GroupPanel1.TabIndex = 22
        Me.GroupPanel1.Text = "Children Information"
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
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.IsPopupCalendarOpen = False
        Me.DateTimePicker1.Location = New System.Drawing.Point(87, 164)
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
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.DateTimePicker1.TabIndex = 24
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Location = New System.Drawing.Point(28, 9)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(44, 13)
        Me.Label19.TabIndex = 13
        Me.Label19.Text = "Child ID"
        '
        'ChildIDTextBox
        '
        Me.ChildIDTextBox.Location = New System.Drawing.Point(87, 6)
        Me.ChildIDTextBox.Name = "ChildIDTextBox"
        Me.ChildIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ChildIDTextBox.TabIndex = 14
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Location = New System.Drawing.Point(20, 124)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(61, 13)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Last Name:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(19, 44)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(60, 13)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "First Name:"
        '
        'LNameTextBox
        '
        Me.LNameTextBox.Location = New System.Drawing.Point(87, 121)
        Me.LNameTextBox.Name = "LNameTextBox"
        Me.LNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LNameTextBox.TabIndex = 12
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Location = New System.Drawing.Point(12, 164)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(69, 13)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Date of Birth:"
        '
        'CMnameTextBox
        '
        Me.CMnameTextBox.Location = New System.Drawing.Point(87, 81)
        Me.CMnameTextBox.Name = "CMnameTextBox"
        Me.CMnameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CMnameTextBox.TabIndex = 12
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Location = New System.Drawing.Point(9, 84)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 13)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Middle Name:"
        '
        'CFnameTextBox
        '
        Me.CFnameTextBox.Location = New System.Drawing.Point(87, 44)
        Me.CFnameTextBox.Name = "CFnameTextBox"
        Me.CFnameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CFnameTextBox.TabIndex = 12
        '
        'GroupPanel2
        '
        Me.GroupPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.FatherEmailTextBox)
        Me.GroupPanel2.Controls.Add(Me.Label2)
        Me.GroupPanel2.Controls.Add(Me.Label7)
        Me.GroupPanel2.Controls.Add(Me.FPhoneTextBox)
        Me.GroupPanel2.Controls.Add(Me.Label21)
        Me.GroupPanel2.Controls.Add(Me.Label5)
        Me.GroupPanel2.Controls.Add(Me.Label9)
        Me.GroupPanel2.Controls.Add(Me.FAgeTextBox)
        Me.GroupPanel2.Controls.Add(Me.Label11)
        Me.GroupPanel2.Controls.Add(Me.FatherIDTextBox)
        Me.GroupPanel2.Controls.Add(Me.FLnameTextBox)
        Me.GroupPanel2.Controls.Add(Me.FFnameTextBox)
        Me.GroupPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel2.Location = New System.Drawing.Point(379, 244)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(226, 259)
        '
        '
        '
        Me.GroupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel2.Style.BackColorGradientAngle = 90
        Me.GroupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderBottomWidth = 1
        Me.GroupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderLeftWidth = 1
        Me.GroupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderRightWidth = 1
        Me.GroupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderTopWidth = 1
        Me.GroupPanel2.Style.CornerDiameter = 4
        Me.GroupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel2.TabIndex = 0
        Me.GroupPanel2.Text = "Father Information"
        '
        'FatherEmailTextBox
        '
        Me.FatherEmailTextBox.Location = New System.Drawing.Point(92, 204)
        Me.FatherEmailTextBox.Name = "FatherEmailTextBox"
        Me.FatherEmailTextBox.Size = New System.Drawing.Size(116, 20)
        Me.FatherEmailTextBox.TabIndex = 16
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Location = New System.Drawing.Point(51, 207)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(35, 13)
        Me.Label21.TabIndex = 13
        Me.Label21.Text = "Email:"
        '
        'GroupPanel3
        '
        Me.GroupPanel3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupPanel3.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel3.Controls.Add(Me.MotherEmailTextBox)
        Me.GroupPanel3.Controls.Add(Me.Label22)
        Me.GroupPanel3.Controls.Add(Me.MPhoneTextBox)
        Me.GroupPanel3.Controls.Add(Me.Label3)
        Me.GroupPanel3.Controls.Add(Me.MageTextBox)
        Me.GroupPanel3.Controls.Add(Me.Label6)
        Me.GroupPanel3.Controls.Add(Me.MLNameTextBox)
        Me.GroupPanel3.Controls.Add(Me.Label10)
        Me.GroupPanel3.Controls.Add(Me.MFNameTextBox)
        Me.GroupPanel3.Controls.Add(Me.Label12)
        Me.GroupPanel3.Controls.Add(Me.MotherIDTextBox)
        Me.GroupPanel3.Controls.Add(Me.Label8)
        Me.GroupPanel3.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel3.Location = New System.Drawing.Point(611, 244)
        Me.GroupPanel3.Name = "GroupPanel3"
        Me.GroupPanel3.Size = New System.Drawing.Size(231, 259)
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
        Me.GroupPanel3.Text = "Mother Information"
        '
        'MotherEmailTextBox
        '
        Me.MotherEmailTextBox.Location = New System.Drawing.Point(88, 204)
        Me.MotherEmailTextBox.Name = "MotherEmailTextBox"
        Me.MotherEmailTextBox.Size = New System.Drawing.Size(116, 20)
        Me.MotherEmailTextBox.TabIndex = 15
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Location = New System.Drawing.Point(47, 207)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(35, 13)
        Me.Label22.TabIndex = 14
        Me.Label22.Text = "Email:"
        '
        'GroupPanel4
        '
        Me.GroupPanel4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupPanel4.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel4.Controls.Add(Me.Label4)
        Me.GroupPanel4.Controls.Add(Me.SupervisorIDTextBox)
        Me.GroupPanel4.Controls.Add(Me.Label13)
        Me.GroupPanel4.Controls.Add(Me.SPositonTextBox)
        Me.GroupPanel4.Controls.Add(Me.Label14)
        Me.GroupPanel4.Controls.Add(Me.SNameTextBox)
        Me.GroupPanel4.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel4.Location = New System.Drawing.Point(39, 369)
        Me.GroupPanel4.Name = "GroupPanel4"
        Me.GroupPanel4.Size = New System.Drawing.Size(298, 134)
        '
        '
        '
        Me.GroupPanel4.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel4.Style.BackColorGradientAngle = 90
        Me.GroupPanel4.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel4.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderBottomWidth = 1
        Me.GroupPanel4.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel4.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderLeftWidth = 1
        Me.GroupPanel4.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderRightWidth = 1
        Me.GroupPanel4.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderTopWidth = 1
        Me.GroupPanel4.Style.CornerDiameter = 4
        Me.GroupPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel4.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel4.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel4.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel4.TabIndex = 0
        Me.GroupPanel4.Text = "Supervisor Information"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(11, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Supervisor ID:"
        '
        'SupervisorIDTextBox
        '
        Me.SupervisorIDTextBox.Location = New System.Drawing.Point(87, 18)
        Me.SupervisorIDTextBox.Name = "SupervisorIDTextBox"
        Me.SupervisorIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SupervisorIDTextBox.TabIndex = 14
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Top
        '
        '
        '
        Me.DateDateTimePicker.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.DateDateTimePicker.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateDateTimePicker.ButtonClear.Tooltip = ""
        Me.DateDateTimePicker.ButtonCustom.Tooltip = ""
        Me.DateDateTimePicker.ButtonCustom2.Tooltip = ""
        Me.DateDateTimePicker.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.DateDateTimePicker.ButtonDropDown.Tooltip = ""
        Me.DateDateTimePicker.ButtonDropDown.Visible = True
        Me.DateDateTimePicker.ButtonFreeText.Tooltip = ""
        Me.DateDateTimePicker.IsPopupCalendarOpen = False
        Me.DateDateTimePicker.Location = New System.Drawing.Point(163, 63)
        '
        '
        '
        Me.DateDateTimePicker.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.DateDateTimePicker.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateDateTimePicker.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.DateDateTimePicker.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.DateDateTimePicker.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.DateDateTimePicker.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.DateDateTimePicker.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.DateDateTimePicker.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.DateDateTimePicker.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.DateDateTimePicker.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.DateDateTimePicker.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateDateTimePicker.MonthCalendar.DisplayMonth = New Date(2016, 11, 1, 0, 0, 0, 0)
        Me.DateDateTimePicker.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.DateDateTimePicker.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.DateDateTimePicker.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.DateDateTimePicker.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.DateDateTimePicker.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.DateDateTimePicker.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateDateTimePicker.MonthCalendar.TodayButtonVisible = True
        Me.DateDateTimePicker.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DateDateTimePicker.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.DateDateTimePicker.TabIndex = 23
        '
        'SuperTooltip1
        '
        Me.SuperTooltip1.DefaultTooltipSettings = New DevComponents.DotNetBar.SuperTooltipInfo("", "", "", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray)
        '
        'RefreshButton
        '
        Me.RefreshButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.RefreshButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.RefreshButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.RefreshButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefreshButton.Image = Global.OMS.My.Resources.Resources.ic_refresh_black_24dp_2x
        Me.RefreshButton.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.RefreshButton.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.RefreshButton.Location = New System.Drawing.Point(817, 213)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(25, 25)
        Me.RefreshButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SuperTooltip1.SetSuperTooltip(Me.RefreshButton, New DevComponents.DotNetBar.SuperTooltipInfo("", "", "Refresh Database", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray, False, False, New System.Drawing.Size(0, 0)))
        Me.RefreshButton.TabIndex = 1003
        '
        'AddAdoptionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(905, 515)
        Me.Controls.Add(Me.RefreshButton)
        Me.Controls.Add(Me.DateDateTimePicker)
        Me.Controls.Add(Me.GroupPanel4)
        Me.Controls.Add(Me.GroupPanel2)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.GroupPanel3)
        Me.Controls.Add(Me.ApplicaitonDataGridView)
        Me.Controls.Add(Me.EmailButton)
        Me.Controls.Add(Me.CreateSaveButton)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.AdoptionIDTextBox)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "AddAdoptionForm"
        Me.Text = "NewAdoption"
        CType(Me.ApplicaitonDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        CType(Me.DateTimePicker1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel2.PerformLayout()
        Me.GroupPanel3.ResumeLayout(False)
        Me.GroupPanel3.PerformLayout()
        Me.GroupPanel4.ResumeLayout(False)
        Me.GroupPanel4.PerformLayout()
        CType(Me.DateDateTimePicker, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents MPhoneTextBox As TextBox
    Friend WithEvents FPhoneTextBox As TextBox
    Friend WithEvents MageTextBox As TextBox
    Friend WithEvents FAgeTextBox As TextBox
    Friend WithEvents MLNameTextBox As TextBox
    Friend WithEvents FLnameTextBox As TextBox
    Friend WithEvents MFNameTextBox As TextBox
    Friend WithEvents FFnameTextBox As TextBox
    Friend WithEvents MotherIDTextBox As TextBox
    Friend WithEvents FatherIDTextBox As TextBox
    Friend WithEvents SPositonTextBox As TextBox
    Friend WithEvents SNameTextBox As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents AdoptionIDTextBox As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents ApplicaitonDataGridView As DevComponents.DotNetBar.Controls.DataGridViewX
    Private WithEvents CreateSaveButton As DevComponents.DotNetBar.ButtonX
    Private WithEvents EmailButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Label19 As Label
    Friend WithEvents ChildIDTextBox As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents LNameTextBox As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents CMnameTextBox As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents CFnameTextBox As TextBox
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GroupPanel3 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GroupPanel4 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents DateDateTimePicker As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents DateTimePicker1 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents SuperTooltip1 As DevComponents.DotNetBar.SuperTooltip
    Friend WithEvents RefreshButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label4 As Label
    Friend WithEvents SupervisorIDTextBox As TextBox
    Friend WithEvents FatherEmailTextBox As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents MotherEmailTextBox As TextBox
    Friend WithEvents Label22 As Label
End Class
