<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddressForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddressForm))
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.StreetLabel = New DevComponents.DotNetBar.LabelX()
        Me.CityLabel = New DevComponents.DotNetBar.LabelX()
        Me.StateLabel = New DevComponents.DotNetBar.LabelX()
        Me.EmployeeCityComboBox = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.EmployeeStateComboBox = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.CancelButton = New DevComponents.DotNetBar.ButtonX()
        Me.SumbitButton = New DevComponents.DotNetBar.ButtonX()
        Me.ClearButton = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.SuperTooltip1 = New DevComponents.DotNetBar.SuperTooltip()
        Me.Address1TextBox = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.SuspendLayout()
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007VistaGlass
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(154, Byte), Integer)))
        '
        'StreetLabel
        '
        '
        '
        '
        Me.StreetLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.StreetLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StreetLabel.Location = New System.Drawing.Point(66, 22)
        Me.StreetLabel.Name = "StreetLabel"
        Me.StreetLabel.Size = New System.Drawing.Size(56, 23)
        Me.StreetLabel.TabIndex = 0
        Me.StreetLabel.Text = "Street:"
        '
        'CityLabel
        '
        '
        '
        '
        Me.CityLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CityLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CityLabel.Location = New System.Drawing.Point(66, 93)
        Me.CityLabel.Name = "CityLabel"
        Me.CityLabel.Size = New System.Drawing.Size(56, 23)
        Me.CityLabel.TabIndex = 2
        Me.CityLabel.Text = "City:"
        '
        'StateLabel
        '
        '
        '
        '
        Me.StateLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.StateLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StateLabel.Location = New System.Drawing.Point(66, 56)
        Me.StateLabel.Name = "StateLabel"
        Me.StateLabel.Size = New System.Drawing.Size(56, 23)
        Me.StateLabel.TabIndex = 3
        Me.StateLabel.Text = "State:"
        '
        'EmployeeCityComboBox
        '
        Me.EmployeeCityComboBox.DisplayMember = "Text"
        Me.EmployeeCityComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.EmployeeCityComboBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeCityComboBox.FormattingEnabled = True
        Me.EmployeeCityComboBox.ItemHeight = 17
        Me.EmployeeCityComboBox.Location = New System.Drawing.Point(128, 96)
        Me.EmployeeCityComboBox.Name = "EmployeeCityComboBox"
        Me.EmployeeCityComboBox.Size = New System.Drawing.Size(151, 23)
        Me.EmployeeCityComboBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.EmployeeCityComboBox.TabIndex = 3
        '
        'EmployeeStateComboBox
        '
        Me.EmployeeStateComboBox.DisplayMember = "Text"
        Me.EmployeeStateComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.EmployeeStateComboBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeStateComboBox.FormattingEnabled = True
        Me.EmployeeStateComboBox.ItemHeight = 17
        Me.EmployeeStateComboBox.Location = New System.Drawing.Point(128, 59)
        Me.EmployeeStateComboBox.Name = "EmployeeStateComboBox"
        Me.EmployeeStateComboBox.Size = New System.Drawing.Size(151, 23)
        Me.EmployeeStateComboBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.EmployeeStateComboBox.TabIndex = 2
        '
        'CancelButton
        '
        Me.CancelButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.CancelButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.CancelButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelButton.Location = New System.Drawing.Point(268, 140)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CancelButton.TabIndex = 0
        Me.CancelButton.Text = "&Back"
        '
        'SumbitButton
        '
        Me.SumbitButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.SumbitButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.SumbitButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SumbitButton.Location = New System.Drawing.Point(29, 140)
        Me.SumbitButton.Name = "SumbitButton"
        Me.SumbitButton.Size = New System.Drawing.Size(75, 23)
        Me.SumbitButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SumbitButton.TabIndex = 4
        Me.SumbitButton.Text = "&Submit"
        '
        'ClearButton
        '
        Me.ClearButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ClearButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ClearButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(148, 140)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ClearButton.TabIndex = 0
        Me.ClearButton.Text = "&Clear"
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
        Me.LabelX6.Location = New System.Drawing.Point(284, 24)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.SingleLineColor = System.Drawing.Color.Transparent
        Me.LabelX6.Size = New System.Drawing.Size(18, 18)
        Me.SuperTooltip1.SetSuperTooltip(Me.LabelX6, New DevComponents.DotNetBar.SuperTooltipInfo("", "", "Example: 123 Example Rd" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Please use following key words only:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Avenue / Lane / Ro" &
            "ad / Boulevard / Drive / Street / Ave / Dr / Rd / Blvd / Ln / St.", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray, False, False, New System.Drawing.Size(0, 0)))
        Me.LabelX6.TabIndex = 45
        '
        'SuperTooltip1
        '
        Me.SuperTooltip1.DefaultTooltipSettings = New DevComponents.DotNetBar.SuperTooltipInfo("", "", "", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray)
        Me.SuperTooltip1.HoverDelayMultiplier = 1
        '
        'Address1TextBox
        '
        '
        '
        '
        Me.Address1TextBox.Border.Class = "TextBoxBorder"
        Me.Address1TextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Address1TextBox.ButtonCustom.Tooltip = ""
        Me.Address1TextBox.ButtonCustom2.Tooltip = ""
        Me.Address1TextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Address1TextBox.Location = New System.Drawing.Point(127, 24)
        Me.Address1TextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Address1TextBox.Name = "Address1TextBox"
        Me.Address1TextBox.PreventEnterBeep = True
        Me.Address1TextBox.Size = New System.Drawing.Size(142, 23)
        Me.Address1TextBox.TabIndex = 1
        Me.Address1TextBox.WatermarkText = "123 Example Rd"
        '
        'AddressForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 180)
        Me.Controls.Add(Me.Address1TextBox)
        Me.Controls.Add(Me.LabelX6)
        Me.Controls.Add(Me.SumbitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.EmployeeStateComboBox)
        Me.Controls.Add(Me.EmployeeCityComboBox)
        Me.Controls.Add(Me.StateLabel)
        Me.Controls.Add(Me.CityLabel)
        Me.Controls.Add(Me.StreetLabel)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(386, 219)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(386, 219)
        Me.Name = "AddressForm"
        Me.Text = "Edit Address"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents StreetLabel As DevComponents.DotNetBar.LabelX
    Friend WithEvents CityLabel As DevComponents.DotNetBar.LabelX
    Friend WithEvents StateLabel As DevComponents.DotNetBar.LabelX
    Friend WithEvents EmployeeCityComboBox As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents EmployeeStateComboBox As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents CancelButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents SumbitButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ClearButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents SuperTooltip1 As DevComponents.DotNetBar.SuperTooltip
    Friend WithEvents Address1TextBox As DevComponents.DotNetBar.Controls.TextBoxX
End Class
