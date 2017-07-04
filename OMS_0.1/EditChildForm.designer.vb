<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditChildForm
    Inherits DevComponents.DotNetBar.OfficeForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditChildForm))
        Me.LNTextBox = New System.Windows.Forms.TextBox()
        Me.MNTextBox = New System.Windows.Forms.TextBox()
        Me.FNTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BioMTextBox = New System.Windows.Forms.TextBox()
        Me.BioFTextBox = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ChildIDTextBox = New System.Windows.Forms.TextBox()
        Me.MedicalRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.StatusComboBox = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.EduComboBox = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.BloodTComboBox = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.SuperTooltip1 = New DevComponents.DotNetBar.SuperTooltip()
        Me.AddressButton = New DevComponents.DotNetBar.ButtonX()
        Me.SupervisorNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.BrowseButton = New DevComponents.DotNetBar.ButtonX()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.EditSaveButton = New DevComponents.DotNetBar.ButtonX()
        Me.BackButton = New DevComponents.DotNetBar.ButtonX()
        Me.DeleteButton = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.DOBDateTimePicker = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.OtherRadioButton = New System.Windows.Forms.RadioButton()
        Me.FRadioButton = New System.Windows.Forms.RadioButton()
        Me.MRadioButton = New System.Windows.Forms.RadioButton()
        Me.GenderLabel = New DevComponents.DotNetBar.LabelX()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SupervisorComboBox = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.DOBDateTimePicker, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LNTextBox
        '
        Me.LNTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNTextBox.Location = New System.Drawing.Point(123, 205)
        Me.LNTextBox.Name = "LNTextBox"
        Me.LNTextBox.Size = New System.Drawing.Size(119, 23)
        Me.LNTextBox.TabIndex = 5
        '
        'MNTextBox
        '
        Me.MNTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MNTextBox.Location = New System.Drawing.Point(123, 168)
        Me.MNTextBox.Name = "MNTextBox"
        Me.MNTextBox.Size = New System.Drawing.Size(119, 23)
        Me.MNTextBox.TabIndex = 4
        '
        'FNTextBox
        '
        Me.FNTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FNTextBox.Location = New System.Drawing.Point(123, 130)
        Me.FNTextBox.Name = "FNTextBox"
        Me.FNTextBox.Size = New System.Drawing.Size(119, 23)
        Me.FNTextBox.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(49, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 15)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Last Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(49, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 15)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "First Name: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(49, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 15)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Mid Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 15)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Supervisor ID:"
        '
        'BioMTextBox
        '
        Me.BioMTextBox.Location = New System.Drawing.Point(395, 47)
        Me.BioMTextBox.Name = "BioMTextBox"
        Me.BioMTextBox.Size = New System.Drawing.Size(134, 23)
        Me.BioMTextBox.TabIndex = 13
        '
        'BioFTextBox
        '
        Me.BioFTextBox.Location = New System.Drawing.Point(395, 14)
        Me.BioFTextBox.Name = "BioFTextBox"
        Me.BioFTextBox.Size = New System.Drawing.Size(134, 23)
        Me.BioFTextBox.TabIndex = 12
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(339, 163)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(42, 15)
        Me.Label14.TabIndex = 40
        Me.Label14.Text = "Status:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(295, 127)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(93, 15)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "Education Level:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(7, 138)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 15)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "Medical Issue:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(318, 89)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 15)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "Blood Type:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(321, 50)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 15)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Bio-Father:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(318, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 15)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Bio-Mother:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(12, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 15)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Date of Birth:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(56, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 15)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "Child ID:"
        '
        'ChildIDTextBox
        '
        Me.ChildIDTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChildIDTextBox.Location = New System.Drawing.Point(123, 21)
        Me.ChildIDTextBox.Name = "ChildIDTextBox"
        Me.ChildIDTextBox.Size = New System.Drawing.Size(119, 23)
        Me.ChildIDTextBox.TabIndex = 0
        '
        'MedicalRichTextBox
        '
        Me.MedicalRichTextBox.Location = New System.Drawing.Point(97, 127)
        Me.MedicalRichTextBox.Name = "MedicalRichTextBox"
        Me.MedicalRichTextBox.Size = New System.Drawing.Size(192, 91)
        Me.MedicalRichTextBox.TabIndex = 11
        Me.MedicalRichTextBox.Text = ""
        '
        'StatusComboBox
        '
        Me.StatusComboBox.DisplayMember = "Text"
        Me.StatusComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.StatusComboBox.FormattingEnabled = True
        Me.StatusComboBox.ItemHeight = 17
        Me.StatusComboBox.Location = New System.Drawing.Point(395, 161)
        Me.StatusComboBox.Name = "StatusComboBox"
        Me.StatusComboBox.Size = New System.Drawing.Size(134, 23)
        Me.StatusComboBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.StatusComboBox.TabIndex = 16
        '
        'EduComboBox
        '
        Me.EduComboBox.DisplayMember = "Text"
        Me.EduComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.EduComboBox.FormattingEnabled = True
        Me.EduComboBox.ItemHeight = 17
        Me.EduComboBox.Location = New System.Drawing.Point(395, 125)
        Me.EduComboBox.Name = "EduComboBox"
        Me.EduComboBox.Size = New System.Drawing.Size(134, 23)
        Me.EduComboBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.EduComboBox.TabIndex = 15
        '
        'BloodTComboBox
        '
        Me.BloodTComboBox.DisplayMember = "Text"
        Me.BloodTComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.BloodTComboBox.FormattingEnabled = True
        Me.BloodTComboBox.ItemHeight = 17
        Me.BloodTComboBox.Location = New System.Drawing.Point(395, 89)
        Me.BloodTComboBox.Name = "BloodTComboBox"
        Me.BloodTComboBox.Size = New System.Drawing.Size(134, 23)
        Me.BloodTComboBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BloodTComboBox.TabIndex = 14
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
        'AddressButton
        '
        Me.AddressButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.AddressButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.AddressButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressButton.Location = New System.Drawing.Point(123, 77)
        Me.AddressButton.Margin = New System.Windows.Forms.Padding(2)
        Me.AddressButton.Name = "AddressButton"
        Me.AddressButton.Size = New System.Drawing.Size(73, 32)
        Me.AddressButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SuperTooltip1.SetSuperTooltip(Me.AddressButton, New DevComponents.DotNetBar.SuperTooltipInfo("", "", "Edit or add location information." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Clicking this button will open a new window.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray, False, False, New System.Drawing.Size(0, 0)))
        Me.AddressButton.TabIndex = 10
        Me.AddressButton.Text = "Add Address"
        '
        'SupervisorNameTextBox
        '
        Me.SupervisorNameTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SupervisorNameTextBox.Location = New System.Drawing.Point(123, 97)
        Me.SupervisorNameTextBox.Name = "SupervisorNameTextBox"
        Me.SupervisorNameTextBox.Size = New System.Drawing.Size(119, 23)
        Me.SupervisorNameTextBox.TabIndex = 2
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(16, 100)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(100, 15)
        Me.Label15.TabIndex = 66
        Me.Label15.Text = "Supervisor Name:"
        '
        'BrowseButton
        '
        Me.BrowseButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BrowseButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BrowseButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrowseButton.Location = New System.Drawing.Point(469, 72)
        Me.BrowseButton.Name = "BrowseButton"
        Me.BrowseButton.Size = New System.Drawing.Size(75, 23)
        Me.BrowseButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BrowseButton.TabIndex = 70
        Me.BrowseButton.Text = "&Browse"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(323, 72)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Size = New System.Drawing.Size(138, 146)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 69
        Me.PictureBox1.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(279, 72)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(42, 15)
        Me.Label16.TabIndex = 68
        Me.Label16.Text = "Photo:"
        '
        'EditSaveButton
        '
        Me.EditSaveButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.EditSaveButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.EditSaveButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditSaveButton.Location = New System.Drawing.Point(138, 506)
        Me.EditSaveButton.Name = "EditSaveButton"
        Me.EditSaveButton.Size = New System.Drawing.Size(75, 23)
        Me.EditSaveButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.EditSaveButton.TabIndex = 17
        Me.EditSaveButton.Text = "&Edit"
        '
        'BackButton
        '
        Me.BackButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BackButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BackButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackButton.Location = New System.Drawing.Point(276, 506)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(75, 23)
        Me.BackButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BackButton.TabIndex = 18
        Me.BackButton.Text = "&Back"
        '
        'DeleteButton
        '
        Me.DeleteButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.DeleteButton.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground
        Me.DeleteButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteButton.Location = New System.Drawing.Point(410, 506)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(75, 23)
        Me.DeleteButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.DeleteButton.TabIndex = 0
        Me.DeleteButton.Text = "&Delete"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.DOBDateTimePicker)
        Me.GroupPanel1.Controls.Add(Me.AddressButton)
        Me.GroupPanel1.Controls.Add(Me.Label8)
        Me.GroupPanel1.Controls.Add(Me.OtherRadioButton)
        Me.GroupPanel1.Controls.Add(Me.FRadioButton)
        Me.GroupPanel1.Controls.Add(Me.MRadioButton)
        Me.GroupPanel1.Controls.Add(Me.GenderLabel)
        Me.GroupPanel1.Controls.Add(Me.StatusComboBox)
        Me.GroupPanel1.Controls.Add(Me.Label6)
        Me.GroupPanel1.Controls.Add(Me.EduComboBox)
        Me.GroupPanel1.Controls.Add(Me.BioMTextBox)
        Me.GroupPanel1.Controls.Add(Me.BloodTComboBox)
        Me.GroupPanel1.Controls.Add(Me.BioFTextBox)
        Me.GroupPanel1.Controls.Add(Me.Label14)
        Me.GroupPanel1.Controls.Add(Me.MedicalRichTextBox)
        Me.GroupPanel1.Controls.Add(Me.Label13)
        Me.GroupPanel1.Controls.Add(Me.Label5)
        Me.GroupPanel1.Controls.Add(Me.Label10)
        Me.GroupPanel1.Controls.Add(Me.Label12)
        Me.GroupPanel1.Controls.Add(Me.Label11)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel1.Location = New System.Drawing.Point(12, 240)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(545, 251)
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
        Me.GroupPanel1.TabIndex = 73
        Me.GroupPanel1.Text = "Basic Information"
        '
        'DOBDateTimePicker
        '
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
        Me.DOBDateTimePicker.Location = New System.Drawing.Point(97, 19)
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
        Me.DOBDateTimePicker.Size = New System.Drawing.Size(200, 23)
        Me.DOBDateTimePicker.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.DOBDateTimePicker.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(36, 89)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 15)
        Me.Label8.TabIndex = 75
        Me.Label8.Text = "Address:"
        '
        'OtherRadioButton
        '
        Me.OtherRadioButton.AutoSize = True
        Me.OtherRadioButton.BackColor = System.Drawing.Color.Transparent
        Me.OtherRadioButton.Location = New System.Drawing.Point(174, 51)
        Me.OtherRadioButton.Name = "OtherRadioButton"
        Me.OtherRadioButton.Size = New System.Drawing.Size(55, 19)
        Me.OtherRadioButton.TabIndex = 9
        Me.OtherRadioButton.TabStop = True
        Me.OtherRadioButton.Text = "Other"
        Me.OtherRadioButton.UseVisualStyleBackColor = False
        '
        'FRadioButton
        '
        Me.FRadioButton.AutoSize = True
        Me.FRadioButton.BackColor = System.Drawing.Color.Transparent
        Me.FRadioButton.Location = New System.Drawing.Point(137, 51)
        Me.FRadioButton.Name = "FRadioButton"
        Me.FRadioButton.Size = New System.Drawing.Size(31, 19)
        Me.FRadioButton.TabIndex = 8
        Me.FRadioButton.TabStop = True
        Me.FRadioButton.Text = "F"
        Me.FRadioButton.UseVisualStyleBackColor = False
        '
        'MRadioButton
        '
        Me.MRadioButton.AutoSize = True
        Me.MRadioButton.BackColor = System.Drawing.Color.Transparent
        Me.MRadioButton.Location = New System.Drawing.Point(97, 51)
        Me.MRadioButton.Name = "MRadioButton"
        Me.MRadioButton.Size = New System.Drawing.Size(36, 19)
        Me.MRadioButton.TabIndex = 7
        Me.MRadioButton.TabStop = True
        Me.MRadioButton.Text = "M"
        Me.MRadioButton.UseVisualStyleBackColor = False
        '
        'GenderLabel
        '
        Me.GenderLabel.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.GenderLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GenderLabel.Location = New System.Drawing.Point(43, 47)
        Me.GenderLabel.Name = "GenderLabel"
        Me.GenderLabel.Size = New System.Drawing.Size(44, 23)
        Me.GenderLabel.TabIndex = 70
        Me.GenderLabel.Text = "Gender:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'SupervisorComboBox
        '
        Me.SupervisorComboBox.DisplayMember = "Text"
        Me.SupervisorComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.SupervisorComboBox.FormattingEnabled = True
        Me.SupervisorComboBox.ItemHeight = 17
        Me.SupervisorComboBox.Location = New System.Drawing.Point(123, 61)
        Me.SupervisorComboBox.Name = "SupervisorComboBox"
        Me.SupervisorComboBox.Size = New System.Drawing.Size(121, 23)
        Me.SupervisorComboBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SupervisorComboBox.TabIndex = 76
        '
        'EditChildForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 545)
        Me.Controls.Add(Me.SupervisorComboBox)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.EditSaveButton)
        Me.Controls.Add(Me.BrowseButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.SupervisorNameTextBox)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.ChildIDTextBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LNTextBox)
        Me.Controls.Add(Me.MNTextBox)
        Me.Controls.Add(Me.FNTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(585, 584)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(585, 584)
        Me.Name = "EditChildForm"
        Me.Text = "Edit Child Information"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        CType(Me.DOBDateTimePicker, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LNTextBox As TextBox
    Friend WithEvents MNTextBox As TextBox
    Friend WithEvents FNTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BioMTextBox As TextBox
    Friend WithEvents BioFTextBox As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ChildIDTextBox As TextBox
    Friend WithEvents MedicalRichTextBox As RichTextBox
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents SuperTooltip1 As DevComponents.DotNetBar.SuperTooltip
    Friend WithEvents SupervisorNameTextBox As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents BrowseButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label16 As Label
    Friend WithEvents StatusComboBox As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents EduComboBox As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents BloodTComboBox As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents EditSaveButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BackButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents DeleteButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents OtherRadioButton As RadioButton
    Friend WithEvents FRadioButton As RadioButton
    Friend WithEvents MRadioButton As RadioButton
    Friend WithEvents GenderLabel As DevComponents.DotNetBar.LabelX
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents AddressButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label8 As Label
    Friend WithEvents DOBDateTimePicker As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents SupervisorComboBox As DevComponents.DotNetBar.Controls.ComboBoxEx
End Class
