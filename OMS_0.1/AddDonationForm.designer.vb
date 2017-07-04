<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddDonationForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PositionTextBox = New System.Windows.Forms.TextBox()
        Me.SnameTextBox = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DLNameTextBox = New System.Windows.Forms.TextBox()
        Me.DFNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.SuperTooltip1 = New DevComponents.DotNetBar.SuperTooltip()
        Me.RefreshButton = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.DonorIDTextBox = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.SupervisorTextBox = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.GroupPanel3 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AmountTextBox = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.DescriptionRichTextBox = New DevComponents.DotNetBar.Controls.RichTextBoxEx()
        Me.DonateDateTimePicker = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.SubmitButton = New DevComponents.DotNetBar.ButtonX()
        Me.ResetButton = New DevComponents.DotNetBar.ButtonX()
        Me.DonateDataGridView = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.GroupPanel1.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        Me.GroupPanel3.SuspendLayout()
        CType(Me.DonateDateTimePicker, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DonateDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PositionTextBox
        '
        Me.PositionTextBox.Enabled = False
        Me.PositionTextBox.Location = New System.Drawing.Point(91, 60)
        Me.PositionTextBox.Name = "PositionTextBox"
        Me.PositionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PositionTextBox.TabIndex = 20
        '
        'SnameTextBox
        '
        Me.SnameTextBox.Enabled = False
        Me.SnameTextBox.Location = New System.Drawing.Point(91, 100)
        Me.SnameTextBox.Name = "SnameTextBox"
        Me.SnameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SnameTextBox.TabIndex = 21
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(34, 63)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(47, 13)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Position:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(44, 103)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(38, 13)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(7, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Supervisor ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(13, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Donor ID:"
        '
        'DLNameTextBox
        '
        Me.DLNameTextBox.Enabled = False
        Me.DLNameTextBox.Location = New System.Drawing.Point(84, 100)
        Me.DLNameTextBox.Name = "DLNameTextBox"
        Me.DLNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DLNameTextBox.TabIndex = 11
        '
        'DFNameTextBox
        '
        Me.DFNameTextBox.Enabled = False
        Me.DFNameTextBox.Location = New System.Drawing.Point(84, 63)
        Me.DFNameTextBox.Name = "DFNameTextBox"
        Me.DFNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DFNameTextBox.TabIndex = 10
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(13, 63)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(60, 13)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "First Name:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Location = New System.Drawing.Point(13, 103)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(61, 13)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Last Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(18, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Description:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(27, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Edit Date:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(35, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Amount:"
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
        'RefreshButton
        '
        Me.RefreshButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.RefreshButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.RefreshButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.RefreshButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefreshButton.Image = Global.OMS.My.Resources.Resources.ic_refresh_black_24dp_2x
        Me.RefreshButton.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.RefreshButton.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.RefreshButton.Location = New System.Drawing.Point(880, 145)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(25, 25)
        Me.RefreshButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SuperTooltip1.SetSuperTooltip(Me.RefreshButton, New DevComponents.DotNetBar.SuperTooltipInfo("", "", "Refresh database", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray, False, False, New System.Drawing.Size(0, 0)))
        Me.RefreshButton.TabIndex = 8
        '
        'GroupPanel1
        '
        Me.GroupPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.Label16)
        Me.GroupPanel1.Controls.Add(Me.DonorIDTextBox)
        Me.GroupPanel1.Controls.Add(Me.Label3)
        Me.GroupPanel1.Controls.Add(Me.Label15)
        Me.GroupPanel1.Controls.Add(Me.DFNameTextBox)
        Me.GroupPanel1.Controls.Add(Me.DLNameTextBox)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Location = New System.Drawing.Point(31, 12)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(220, 158)
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
        Me.GroupPanel1.Text = "Donor Information"
        '
        'DonorIDTextBox
        '
        '
        '
        '
        Me.DonorIDTextBox.Border.Class = "TextBoxBorder"
        Me.DonorIDTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DonorIDTextBox.ButtonCustom.Tooltip = ""
        Me.DonorIDTextBox.ButtonCustom2.Tooltip = ""
        Me.DonorIDTextBox.Location = New System.Drawing.Point(84, 18)
        Me.DonorIDTextBox.Name = "DonorIDTextBox"
        Me.DonorIDTextBox.PreventEnterBeep = True
        Me.DonorIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DonorIDTextBox.TabIndex = 1
        '
        'GroupPanel2
        '
        Me.GroupPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.SupervisorTextBox)
        Me.GroupPanel2.Controls.Add(Me.Label4)
        Me.GroupPanel2.Controls.Add(Me.PositionTextBox)
        Me.GroupPanel2.Controls.Add(Me.Label13)
        Me.GroupPanel2.Controls.Add(Me.Label14)
        Me.GroupPanel2.Controls.Add(Me.SnameTextBox)
        Me.GroupPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel2.Location = New System.Drawing.Point(263, 12)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(238, 158)
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
        Me.GroupPanel2.TabIndex = 23
        Me.GroupPanel2.Text = "Supervisor Information"
        '
        'SupervisorTextBox
        '
        '
        '
        '
        Me.SupervisorTextBox.Border.Class = "TextBoxBorder"
        Me.SupervisorTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.SupervisorTextBox.ButtonCustom.Tooltip = ""
        Me.SupervisorTextBox.ButtonCustom2.Tooltip = ""
        Me.SupervisorTextBox.Location = New System.Drawing.Point(91, 18)
        Me.SupervisorTextBox.Name = "SupervisorTextBox"
        Me.SupervisorTextBox.PreventEnterBeep = True
        Me.SupervisorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SupervisorTextBox.TabIndex = 2
        '
        'GroupPanel3
        '
        Me.GroupPanel3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupPanel3.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel3.Controls.Add(Me.Label1)
        Me.GroupPanel3.Controls.Add(Me.AmountTextBox)
        Me.GroupPanel3.Controls.Add(Me.DescriptionRichTextBox)
        Me.GroupPanel3.Controls.Add(Me.DonateDateTimePicker)
        Me.GroupPanel3.Controls.Add(Me.Label7)
        Me.GroupPanel3.Controls.Add(Me.Label2)
        Me.GroupPanel3.Controls.Add(Me.Label5)
        Me.GroupPanel3.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel3.Location = New System.Drawing.Point(515, 12)
        Me.GroupPanel3.Name = "GroupPanel3"
        Me.GroupPanel3.Size = New System.Drawing.Size(349, 158)
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
        Me.GroupPanel3.Text = "Donation Information"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(88, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "$"
        '
        'AmountTextBox
        '
        '
        '
        '
        Me.AmountTextBox.Border.Class = "TextBoxBorder"
        Me.AmountTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.AmountTextBox.ButtonCustom.Tooltip = ""
        Me.AmountTextBox.ButtonCustom2.Tooltip = ""
        Me.AmountTextBox.Location = New System.Drawing.Point(103, 7)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.PreventEnterBeep = True
        Me.AmountTextBox.Size = New System.Drawing.Size(117, 20)
        Me.AmountTextBox.TabIndex = 3
        '
        'DescriptionRichTextBox
        '
        '
        '
        '
        Me.DescriptionRichTextBox.BackgroundStyle.Class = "RichTextBoxBorder"
        Me.DescriptionRichTextBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DescriptionRichTextBox.Location = New System.Drawing.Point(87, 67)
        Me.DescriptionRichTextBox.Name = "DescriptionRichTextBox"
        Me.DescriptionRichTextBox.Rtf = "{\rtf1\ansi\ansicpg936\deff0\deflang1033\deflangfe2052{\fonttbl{\f0\fnil\fcharset" &
    "0 Microsoft Sans Serif;}}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "\viewkind4\uc1\pard\lang2052\f0\fs17\par" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.DescriptionRichTextBox.Size = New System.Drawing.Size(200, 53)
        Me.DescriptionRichTextBox.TabIndex = 5
        '
        'DonateDateTimePicker
        '
        '
        '
        '
        Me.DonateDateTimePicker.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.DonateDateTimePicker.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DonateDateTimePicker.ButtonClear.Tooltip = ""
        Me.DonateDateTimePicker.ButtonCustom.Tooltip = ""
        Me.DonateDateTimePicker.ButtonCustom2.Tooltip = ""
        Me.DonateDateTimePicker.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.DonateDateTimePicker.ButtonDropDown.Tooltip = ""
        Me.DonateDateTimePicker.ButtonDropDown.Visible = True
        Me.DonateDateTimePicker.ButtonFreeText.Tooltip = ""
        Me.DonateDateTimePicker.IsPopupCalendarOpen = False
        Me.DonateDateTimePicker.Location = New System.Drawing.Point(87, 33)
        '
        '
        '
        Me.DonateDateTimePicker.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.DonateDateTimePicker.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DonateDateTimePicker.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.DonateDateTimePicker.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.DonateDateTimePicker.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.DonateDateTimePicker.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.DonateDateTimePicker.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.DonateDateTimePicker.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.DonateDateTimePicker.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.DonateDateTimePicker.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.DonateDateTimePicker.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DonateDateTimePicker.MonthCalendar.DisplayMonth = New Date(2016, 11, 1, 0, 0, 0, 0)
        Me.DonateDateTimePicker.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.DonateDateTimePicker.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.DonateDateTimePicker.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.DonateDateTimePicker.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.DonateDateTimePicker.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.DonateDateTimePicker.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DonateDateTimePicker.MonthCalendar.TodayButtonVisible = True
        Me.DonateDateTimePicker.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.DonateDateTimePicker.Name = "DonateDateTimePicker"
        Me.DonateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DonateDateTimePicker.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.DonateDateTimePicker.TabIndex = 4
        '
        'SubmitButton
        '
        Me.SubmitButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.SubmitButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.SubmitButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.SubmitButton.Location = New System.Drawing.Point(880, 20)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(75, 56)
        Me.SubmitButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SubmitButton.TabIndex = 6
        Me.SubmitButton.Text = "&Add new donation record"
        '
        'ResetButton
        '
        Me.ResetButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ResetButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ResetButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ResetButton.Location = New System.Drawing.Point(880, 105)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(64, 25)
        Me.ResetButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ResetButton.TabIndex = 7
        Me.ResetButton.Text = "&Clear"
        '
        'DonateDataGridView
        '
        Me.DonateDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DonateDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DonateDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DonateDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.DonateDataGridView.EnableHeadersVisualStyles = False
        Me.DonateDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DonateDataGridView.Location = New System.Drawing.Point(12, 176)
        Me.DonateDataGridView.Name = "DonateDataGridView"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DonateDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DonateDataGridView.Size = New System.Drawing.Size(951, 279)
        Me.DonateDataGridView.TabIndex = 24
        '
        'AddDonationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(975, 467)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.SubmitButton)
        Me.Controls.Add(Me.RefreshButton)
        Me.Controls.Add(Me.DonateDataGridView)
        Me.Controls.Add(Me.GroupPanel3)
        Me.Controls.Add(Me.GroupPanel2)
        Me.Controls.Add(Me.GroupPanel1)
        Me.DoubleBuffered = True
        Me.Name = "AddDonationForm"
        Me.Text = "New Donation"
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel2.PerformLayout()
        Me.GroupPanel3.ResumeLayout(False)
        Me.GroupPanel3.PerformLayout()
        CType(Me.DonateDateTimePicker, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DonateDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PositionTextBox As TextBox
    Friend WithEvents SnameTextBox As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DLNameTextBox As TextBox
    Friend WithEvents DFNameTextBox As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents SuperTooltip1 As DevComponents.DotNetBar.SuperTooltip
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GroupPanel3 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents DescriptionRichTextBox As DevComponents.DotNetBar.Controls.RichTextBoxEx
    Friend WithEvents DonateDateTimePicker As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents RefreshButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents SubmitButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ResetButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents DonateDataGridView As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents DonorIDTextBox As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents SupervisorTextBox As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents AmountTextBox As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label1 As Label
End Class
