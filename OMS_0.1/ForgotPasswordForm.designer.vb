<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgotPasswordForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ForgotPasswordForm))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.UpdateButton = New DevComponents.DotNetBar.ButtonX()
        Me.CancelButton = New DevComponents.DotNetBar.ButtonX()
        Me.UsernameTextBox = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.NewPasswordTextBox = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ConfirmNewPasswordTextBox = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.SuperTooltip1 = New DevComponents.DotNetBar.SuperTooltip()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.VerifCodeTextBox = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.SendVerifCodeButton = New DevComponents.DotNetBar.ButtonX()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "New Password:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Confirm Password:"
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.Location = New System.Drawing.Point(65, 26)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(63, 15)
        Me.UsernameLabel.TabIndex = 8
        Me.UsernameLabel.Text = "Username:"
        '
        'UpdateButton
        '
        Me.UpdateButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.UpdateButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.UpdateButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateButton.Location = New System.Drawing.Point(79, 180)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(87, 27)
        Me.UpdateButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.UpdateButton.TabIndex = 4
        Me.UpdateButton.Text = "&Reset"
        '
        'CancelButton
        '
        Me.CancelButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.CancelButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.CancelButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelButton.Location = New System.Drawing.Point(202, 180)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(87, 27)
        Me.CancelButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CancelButton.TabIndex = 5
        Me.CancelButton.Text = "&Back"
        '
        'UsernameTextBox
        '
        '
        '
        '
        Me.UsernameTextBox.Border.Class = "TextBoxBorder"
        Me.UsernameTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.UsernameTextBox.ButtonCustom.Tooltip = ""
        Me.UsernameTextBox.ButtonCustom2.Tooltip = ""
        Me.UsernameTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameTextBox.Location = New System.Drawing.Point(149, 24)
        Me.UsernameTextBox.MaxLength = 20
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.PreventEnterBeep = True
        Me.UsernameTextBox.Size = New System.Drawing.Size(160, 23)
        Me.UsernameTextBox.TabIndex = 1
        '
        'NewPasswordTextBox
        '
        '
        '
        '
        Me.NewPasswordTextBox.Border.Class = "TextBoxBorder"
        Me.NewPasswordTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.NewPasswordTextBox.ButtonCustom.Tooltip = ""
        Me.NewPasswordTextBox.ButtonCustom2.Tooltip = ""
        Me.NewPasswordTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewPasswordTextBox.Location = New System.Drawing.Point(149, 91)
        Me.NewPasswordTextBox.MaxLength = 20
        Me.NewPasswordTextBox.Name = "NewPasswordTextBox"
        Me.NewPasswordTextBox.PreventEnterBeep = True
        Me.NewPasswordTextBox.Size = New System.Drawing.Size(160, 23)
        Me.NewPasswordTextBox.TabIndex = 2
        '
        'ConfirmNewPasswordTextBox
        '
        '
        '
        '
        Me.ConfirmNewPasswordTextBox.Border.Class = "TextBoxBorder"
        Me.ConfirmNewPasswordTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ConfirmNewPasswordTextBox.ButtonCustom.Tooltip = ""
        Me.ConfirmNewPasswordTextBox.ButtonCustom2.Tooltip = ""
        Me.ConfirmNewPasswordTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfirmNewPasswordTextBox.Location = New System.Drawing.Point(149, 130)
        Me.ConfirmNewPasswordTextBox.MaxLength = 20
        Me.ConfirmNewPasswordTextBox.Name = "ConfirmNewPasswordTextBox"
        Me.ConfirmNewPasswordTextBox.PreventEnterBeep = True
        Me.ConfirmNewPasswordTextBox.Size = New System.Drawing.Size(160, 23)
        Me.ConfirmNewPasswordTextBox.TabIndex = 3
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
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Image = Global.OMS.My.Resources.Resources.ic_help_outline_black_18dp_1x
        Me.LabelX2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.LabelX2.Location = New System.Drawing.Point(327, 90)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.SingleLineColor = System.Drawing.Color.Transparent
        Me.LabelX2.Size = New System.Drawing.Size(21, 21)
        Me.SuperTooltip1.SetSuperTooltip(Me.LabelX2, New DevComponents.DotNetBar.SuperTooltipInfo("", "", resources.GetString("LabelX2.SuperTooltip"), Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray, False, False, New System.Drawing.Size(0, 0)))
        Me.LabelX2.TabIndex = 41
        '
        'VerifCodeTextBox
        '
        '
        '
        '
        Me.VerifCodeTextBox.Border.Class = "TextBoxBorder"
        Me.VerifCodeTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.VerifCodeTextBox.ButtonCustom.Tooltip = ""
        Me.VerifCodeTextBox.ButtonCustom2.Tooltip = ""
        Me.VerifCodeTextBox.Location = New System.Drawing.Point(149, 55)
        Me.VerifCodeTextBox.MaxLength = 6
        Me.VerifCodeTextBox.Name = "VerifCodeTextBox"
        Me.VerifCodeTextBox.PreventEnterBeep = True
        Me.VerifCodeTextBox.Size = New System.Drawing.Size(78, 23)
        Me.VerifCodeTextBox.TabIndex = 42
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(35, 53)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(93, 23)
        Me.LabelX1.TabIndex = 43
        Me.LabelX1.Text = "6-digit Codes:"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'SendVerifCodeButton
        '
        Me.SendVerifCodeButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.SendVerifCodeButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.SendVerifCodeButton.Location = New System.Drawing.Point(263, 55)
        Me.SendVerifCodeButton.Name = "SendVerifCodeButton"
        Me.SendVerifCodeButton.Size = New System.Drawing.Size(85, 23)
        Me.SendVerifCodeButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SendVerifCodeButton.TabIndex = 44
        Me.SendVerifCodeButton.Text = "Get verif codes"
        '
        'ForgotPasswordForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 236)
        Me.Controls.Add(Me.SendVerifCodeButton)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.VerifCodeTextBox)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.ConfirmNewPasswordTextBox)
        Me.Controls.Add(Me.NewPasswordTextBox)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ForgotPasswordForm"
        Me.Text = "Reset Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents UpdateButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents CancelButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents UsernameTextBox As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents NewPasswordTextBox As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ConfirmNewPasswordTextBox As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents SuperTooltip1 As DevComponents.DotNetBar.SuperTooltip
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents VerifCodeTextBox As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents SendVerifCodeButton As DevComponents.DotNetBar.ButtonX
End Class
