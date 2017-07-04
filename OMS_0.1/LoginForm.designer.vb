<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.LoginRefreshButton = New DevComponents.DotNetBar.ButtonX()
        Me.LoginSubmitButton = New DevComponents.DotNetBar.ButtonX()
        Me.LoginCancelButton = New DevComponents.DotNetBar.ButtonX()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Bar1 = New DevComponents.DotNetBar.Bar()
        Me.SignUpButtonItem = New DevComponents.DotNetBar.ButtonItem()
        Me.LoginUserNameTextBox = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LoginPasswordTextBox = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LoginCaptchaTextBox = New DevComponents.DotNetBar.Controls.TextBoxX()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(140, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please login"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(68, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Username:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(71, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Password:"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.DisabledLinkColor = System.Drawing.Color.DimGray
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.ForeColor = System.Drawing.Color.DarkCyan
        Me.LinkLabel1.LinkColor = System.Drawing.Color.DarkCyan
        Me.LinkLabel1.Location = New System.Drawing.Point(162, 196)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(92, 13)
        Me.LinkLabel1.TabIndex = 7
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Forgot Password?"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(51, 318)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 15)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Enter Captcha:"
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007VistaGlass
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(154, Byte), Integer)))
        '
        'LoginRefreshButton
        '
        Me.LoginRefreshButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.LoginRefreshButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.LoginRefreshButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginRefreshButton.Location = New System.Drawing.Point(295, 312)
        Me.LoginRefreshButton.Margin = New System.Windows.Forms.Padding(2)
        Me.LoginRefreshButton.Name = "LoginRefreshButton"
        Me.LoginRefreshButton.Size = New System.Drawing.Size(87, 24)
        Me.LoginRefreshButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.LoginRefreshButton.TabIndex = 6
        Me.LoginRefreshButton.Text = "&Refresh"
        '
        'LoginSubmitButton
        '
        Me.LoginSubmitButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.LoginSubmitButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.LoginSubmitButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginSubmitButton.Location = New System.Drawing.Point(77, 375)
        Me.LoginSubmitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.LoginSubmitButton.Name = "LoginSubmitButton"
        Me.LoginSubmitButton.Size = New System.Drawing.Size(89, 36)
        Me.LoginSubmitButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.LoginSubmitButton.TabIndex = 4
        Me.LoginSubmitButton.Text = "&Login"
        '
        'LoginCancelButton
        '
        Me.LoginCancelButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.LoginCancelButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.LoginCancelButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginCancelButton.Location = New System.Drawing.Point(262, 375)
        Me.LoginCancelButton.Margin = New System.Windows.Forms.Padding(2)
        Me.LoginCancelButton.Name = "LoginCancelButton"
        Me.LoginCancelButton.Size = New System.Drawing.Size(87, 36)
        Me.LoginCancelButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.LoginCancelButton.TabIndex = 5
        Me.LoginCancelButton.Text = "&Cancel"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(126, 228)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(159, 58)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Bar1
        '
        Me.Bar1.AntiAlias = True
        Me.Bar1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SignUpButtonItem})
        Me.Bar1.Location = New System.Drawing.Point(3, 2)
        Me.Bar1.Name = "Bar1"
        Me.Bar1.Size = New System.Drawing.Size(430, 25)
        Me.Bar1.Stretch = True
        Me.Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bar1.TabIndex = 21
        Me.Bar1.TabStop = False
        Me.Bar1.Text = "Bar1"
        '
        'SignUpButtonItem
        '
        Me.SignUpButtonItem.Name = "SignUpButtonItem"
        Me.SignUpButtonItem.Text = "Sign Up"
        '
        'LoginUserNameTextBox
        '
        '
        '
        '
        Me.LoginUserNameTextBox.Border.Class = "TextBoxBorder"
        Me.LoginUserNameTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LoginUserNameTextBox.ButtonCustom.Tooltip = ""
        Me.LoginUserNameTextBox.ButtonCustom2.Tooltip = ""
        Me.LoginUserNameTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginUserNameTextBox.Location = New System.Drawing.Point(156, 121)
        Me.LoginUserNameTextBox.Name = "LoginUserNameTextBox"
        Me.LoginUserNameTextBox.PreventEnterBeep = True
        Me.LoginUserNameTextBox.Size = New System.Drawing.Size(117, 23)
        Me.LoginUserNameTextBox.TabIndex = 1
        '
        'LoginPasswordTextBox
        '
        '
        '
        '
        Me.LoginPasswordTextBox.Border.Class = "TextBoxBorder"
        Me.LoginPasswordTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LoginPasswordTextBox.ButtonCustom.Tooltip = ""
        Me.LoginPasswordTextBox.ButtonCustom2.Tooltip = ""
        Me.LoginPasswordTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginPasswordTextBox.Location = New System.Drawing.Point(156, 172)
        Me.LoginPasswordTextBox.Name = "LoginPasswordTextBox"
        Me.LoginPasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.LoginPasswordTextBox.PreventEnterBeep = True
        Me.LoginPasswordTextBox.Size = New System.Drawing.Size(117, 23)
        Me.LoginPasswordTextBox.TabIndex = 2
        '
        'LoginCaptchaTextBox
        '
        '
        '
        '
        Me.LoginCaptchaTextBox.Border.Class = "TextBoxBorder"
        Me.LoginCaptchaTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LoginCaptchaTextBox.ButtonCustom.Tooltip = ""
        Me.LoginCaptchaTextBox.ButtonCustom2.Tooltip = ""
        Me.LoginCaptchaTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginCaptchaTextBox.Location = New System.Drawing.Point(156, 313)
        Me.LoginCaptchaTextBox.Name = "LoginCaptchaTextBox"
        Me.LoginCaptchaTextBox.PreventEnterBeep = True
        Me.LoginCaptchaTextBox.Size = New System.Drawing.Size(117, 23)
        Me.LoginCaptchaTextBox.TabIndex = 3
        Me.LoginCaptchaTextBox.WatermarkText = "in above image"
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 473)
        Me.Controls.Add(Me.LoginCaptchaTextBox)
        Me.Controls.Add(Me.LoginPasswordTextBox)
        Me.Controls.Add(Me.LoginUserNameTextBox)
        Me.Controls.Add(Me.Bar1)
        Me.Controls.Add(Me.LoginSubmitButton)
        Me.Controls.Add(Me.LoginCancelButton)
        Me.Controls.Add(Me.LoginRefreshButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(452, 512)
        Me.MinimumSize = New System.Drawing.Size(452, 512)
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Please Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Private WithEvents LoginSubmitButton As DevComponents.DotNetBar.ButtonX
    Private WithEvents LoginCancelButton As DevComponents.DotNetBar.ButtonX
    Private WithEvents LoginRefreshButton As DevComponents.DotNetBar.ButtonX
    Private WithEvents Bar1 As DevComponents.DotNetBar.Bar
    Private WithEvents SignUpButtonItem As DevComponents.DotNetBar.ButtonItem
    Private WithEvents LoginPasswordTextBox As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents LoginUserNameTextBox As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LoginCaptchaTextBox As DevComponents.DotNetBar.Controls.TextBoxX
    'Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
