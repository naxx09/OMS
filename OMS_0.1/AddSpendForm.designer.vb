<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddSpendForm
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
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SaveButton = New DevComponents.DotNetBar.ButtonX()
        Me.SpendDateTimePicker = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.SpendReasonRichTextBox = New DevComponents.DotNetBar.Controls.RichTextBoxEx()
        Me.SAmountTextBox = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SupervisorIDComboBox = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        CType(Me.SpendDateTimePicker, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(113, 110)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(74, 13)
        Me.Label17.TabIndex = 59
        Me.Label17.Text = "Supervisor ID:"
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(107, 59)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 13)
        Me.Label18.TabIndex = 60
        Me.Label18.Text = "Spend Amount:"
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(390, 64)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(81, 13)
        Me.Label15.TabIndex = 61
        Me.Label15.Text = "Spend Reason:"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(129, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = "Edit Date:"
        '
        'SaveButton
        '
        Me.SaveButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.SaveButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.SaveButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.SaveButton.Location = New System.Drawing.Point(308, 230)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SaveButton.TabIndex = 5
        Me.SaveButton.Text = "&Save"
        '
        'SpendDateTimePicker
        '
        Me.SpendDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Top
        '
        '
        '
        Me.SpendDateTimePicker.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.SpendDateTimePicker.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.SpendDateTimePicker.ButtonClear.Tooltip = ""
        Me.SpendDateTimePicker.ButtonCustom.Tooltip = ""
        Me.SpendDateTimePicker.ButtonCustom2.Tooltip = ""
        Me.SpendDateTimePicker.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.SpendDateTimePicker.ButtonDropDown.Tooltip = ""
        Me.SpendDateTimePicker.ButtonDropDown.Visible = True
        Me.SpendDateTimePicker.ButtonFreeText.Tooltip = ""
        Me.SpendDateTimePicker.IsPopupCalendarOpen = False
        Me.SpendDateTimePicker.Location = New System.Drawing.Point(203, 170)
        '
        '
        '
        Me.SpendDateTimePicker.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.SpendDateTimePicker.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.SpendDateTimePicker.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.SpendDateTimePicker.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.SpendDateTimePicker.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.SpendDateTimePicker.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.SpendDateTimePicker.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.SpendDateTimePicker.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.SpendDateTimePicker.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.SpendDateTimePicker.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.SpendDateTimePicker.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.SpendDateTimePicker.MonthCalendar.DisplayMonth = New Date(2016, 11, 1, 0, 0, 0, 0)
        Me.SpendDateTimePicker.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.SpendDateTimePicker.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.SpendDateTimePicker.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.SpendDateTimePicker.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.SpendDateTimePicker.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.SpendDateTimePicker.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.SpendDateTimePicker.MonthCalendar.TodayButtonVisible = True
        Me.SpendDateTimePicker.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.SpendDateTimePicker.Name = "SpendDateTimePicker"
        Me.SpendDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.SpendDateTimePicker.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SpendDateTimePicker.TabIndex = 3
        '
        'SpendReasonRichTextBox
        '
        Me.SpendReasonRichTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        '
        '
        '
        Me.SpendReasonRichTextBox.BackgroundStyle.Class = "RichTextBoxBorder"
        Me.SpendReasonRichTextBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.SpendReasonRichTextBox.Location = New System.Drawing.Point(477, 57)
        Me.SpendReasonRichTextBox.Name = "SpendReasonRichTextBox"
        Me.SpendReasonRichTextBox.Rtf = "{\rtf1\ansi\ansicpg936\deff0\deflang1033\deflangfe2052{\fonttbl{\f0\fnil\fcharset" &
    "0 Microsoft Sans Serif;}}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "\viewkind4\uc1\pard\lang2052\f0\fs17\par" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.SpendReasonRichTextBox.Size = New System.Drawing.Size(174, 141)
        Me.SpendReasonRichTextBox.TabIndex = 4
        '
        'SAmountTextBox
        '
        Me.SAmountTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        '
        '
        '
        Me.SAmountTextBox.Border.Class = "TextBoxBorder"
        Me.SAmountTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.SAmountTextBox.ButtonCustom.Tooltip = ""
        Me.SAmountTextBox.ButtonCustom2.Tooltip = ""
        Me.SAmountTextBox.Location = New System.Drawing.Point(203, 57)
        Me.SAmountTextBox.Name = "SAmountTextBox"
        Me.SAmountTextBox.PreventEnterBeep = True
        Me.SAmountTextBox.Size = New System.Drawing.Size(165, 20)
        Me.SAmountTextBox.TabIndex = 1
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007VistaGlass
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(154, Byte), Integer)))
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(190, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "$"
        '
        'SupervisorIDComboBox
        '
        Me.SupervisorIDComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.SupervisorIDComboBox.DisplayMember = "Text"
        Me.SupervisorIDComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.SupervisorIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SupervisorIDComboBox.FormattingEnabled = True
        Me.SupervisorIDComboBox.ItemHeight = 14
        Me.SupervisorIDComboBox.Location = New System.Drawing.Point(203, 110)
        Me.SupervisorIDComboBox.Name = "SupervisorIDComboBox"
        Me.SupervisorIDComboBox.Size = New System.Drawing.Size(200, 20)
        Me.SupervisorIDComboBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SupervisorIDComboBox.TabIndex = 80
        '
        'AddSpendForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 309)
        Me.Controls.Add(Me.SupervisorIDComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SAmountTextBox)
        Me.Controls.Add(Me.SpendReasonRichTextBox)
        Me.Controls.Add(Me.SpendDateTimePicker)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label15)
        Me.DoubleBuffered = True
        Me.Name = "AddSpendForm"
        Me.Text = "New Spend"
        CType(Me.SpendDateTimePicker, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents SaveButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents SpendDateTimePicker As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents SpendReasonRichTextBox As DevComponents.DotNetBar.Controls.RichTextBoxEx
    Friend WithEvents SAmountTextBox As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents Label1 As Label
    Friend WithEvents SupervisorIDComboBox As DevComponents.DotNetBar.Controls.ComboBoxEx
End Class
