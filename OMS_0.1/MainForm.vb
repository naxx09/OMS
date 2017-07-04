'By Jiashu Yang
'OMS 0.4.2
'2016-10-25

Public Class MainForm
    'load welcome page
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        With WelcomeForm
            .ControlBox = False
            .MinimizeBox = False
            .MaximizeBox = False
            .FormBorderStyle = FormBorderStyle.Fixed3D
            .MdiParent = Me
            'Control.Dock hide windows button (min, max, close)
            .Dock = DockStyle.Fill
            .Show()
        End With
        LoginForm.Hide()
    End Sub
    Public Sub AccountMode()
        With Me
            AccountRibbonTabItem.Visible = True
            AdoptionRibbonTabItem.Visible = False
            ExpansionRibbonTabItem.Visible = False
            ButtonItem5.Visible = False
            AccountRibbonTabItem.Select()
            AccountRibbonPanel.Focus()
            AccountRibbonBar.Focus()
        End With
    End Sub
    Public Sub AdoptionMode()
        With Me
            AccountRibbonTabItem.Visible = False
            AdoptionRibbonTabItem.Visible = True
            ExpansionRibbonTabItem.Visible = False
            ButtonItem5.Visible = False
            AdoptionRibbonTabItem.Select()
            AdoptionRibbonPanel.Focus()
            AdoptionRibbonBar.Focus()
        End With
    End Sub
    Public Sub ManagerMode()
        With Me
            AccountRibbonTabItem.Visible = True
            AdoptionRibbonTabItem.Visible = True
            ExpansionRibbonTabItem.Visible = True
            ButtonItem5.Visible = True
            AccountRibbonTabItem.Select()
            AccountRibbonPanel.Focus()
            AccountRibbonBar.Focus()
        End With
    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Select Case MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Case DialogResult.Yes
                LoginForm.Show()
            'nothing to do here the form is already closing
            Case DialogResult.No
                e.Cancel = True 'cancel the form closing event
                'minimize to tray/hide etc here 
        End Select
    End Sub

    Private Sub CloseButtonItem_Click(sender As Object, e As EventArgs) Handles CloseButtonItem.Click
        Me.Close()
    End Sub
    'Example for calling child form
    Private Sub LoginButtonItem_Click(sender As Object, e As EventArgs)
        Dim Login As New LoginForm
        Dim Warning As Integer = MessageBox.Show("Are you sure you want to open this form?" & vbNewLine & "Everything not saved will be lost.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Warning = DialogResult.No Then
            Return
        ElseIf Warning = DialogResult.Yes Then
            For Each child As Form In Me.MdiChildren
                child.Close()
            Next child
            With Login
                .AutoScroll = True
                .ControlBox = False
                .EnableGlass = False
                .MinimizeBox = False
                .MaximizeBox = False
                .FormBorderStyle = FormBorderStyle.Fixed3D
                .MdiParent = Me
                .Dock = DockStyle.Fill 'Control.Dock hide windows button (min, max, close)
                .ShowIcon = False
                .ShowInTaskbar = False
                .Text = String.Empty
                .Show()
            End With
        End If
    End Sub

    Private Sub LogOffButtonItem_Click(sender As Object, e As EventArgs) Handles LogOffButtonItem.Click
        Me.Close()
    End Sub
    Private Sub ButtonItem2_Click(sender As Object, e As EventArgs) Handles ButtonItem2.Click
        Dim Warning As Integer = MessageBox.Show("Are you sure you want to open this form?" & vbNewLine & "Everything not saved will be lost.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Warning = DialogResult.No Then
            Return
        ElseIf Warning = DialogResult.Yes Then
            For Each child As Form In Me.MdiChildren
                child.Close()
            Next child
            With SearchEmployeeForm
                .AutoScroll = True
                .ControlBox = False
                .EnableGlass = False
                .MinimizeBox = False
                .MaximizeBox = False
                .FormBorderStyle = FormBorderStyle.Fixed3D
                .MdiParent = Me
                .Dock = DockStyle.Fill 'Control.Dock hide windows button (min, max, close)
                .ShowIcon = False
                .ShowInTaskbar = False
                .Text = String.Empty
                .Show()
            End With
        End If
    End Sub

    Private Sub ButtonItem5_Click(sender As Object, e As EventArgs) Handles ButtonItem5.Click
        Dim Warning As Integer = MessageBox.Show("Are you sure you want to open this form?" & vbNewLine & "Everything not saved will be lost.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Warning = DialogResult.No Then
            Return
        ElseIf Warning = DialogResult.Yes Then
            For Each child As Form In Me.MdiChildren
                child.Close()
            Next child
            With SearchEmployeeForm
                .AutoScroll = True
                .ControlBox = False
                .EnableGlass = False
                .MinimizeBox = False
                .MaximizeBox = False
                .FormBorderStyle = FormBorderStyle.Fixed3D
                .MdiParent = Me
                .Dock = DockStyle.Fill 'Control.Dock hide windows button (min, max, close)
                .ShowIcon = False
                .ShowInTaskbar = False
                .Text = String.Empty
                .Show()
            End With
        End If
    End Sub

    Private Sub ApplicationButtonItem_Click(sender As Object, e As EventArgs) Handles ApplicationButtonItem.Click
        Dim Warning As Integer = MessageBox.Show("Are you sure you want to open this form?" & vbNewLine & "Everything not saved will be lost.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Warning = DialogResult.No Then
            Return
        ElseIf Warning = DialogResult.Yes Then
            For Each child As Form In Me.MdiChildren
                child.Close()
            Next child
            With AddAdoptionForm
                .AutoScroll = True
                .ControlBox = False
                .EnableGlass = False
                .MinimizeBox = False
                .MaximizeBox = False
                .FormBorderStyle = FormBorderStyle.Fixed3D
                .MdiParent = Me
                .Dock = DockStyle.Fill 'Control.Dock hide windows button (min, max, close)
                .ShowIcon = False
                .ShowInTaskbar = False
                .Text = String.Empty
                .Show()
            End With
        End If
    End Sub

    Private Sub ChildrenButtonItem_Click(sender As Object, e As EventArgs) Handles ChildrenButtonItem.Click
        Dim Warning As Integer = MessageBox.Show("Are you sure you want to open this form?" & vbNewLine & "Everything not saved will be lost.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Warning = DialogResult.No Then
            Return
        ElseIf Warning = DialogResult.Yes Then
            For Each child As Form In Me.MdiChildren
                child.Close()
            Next child
            With AddChildForm
                .AutoScroll = True
                .ControlBox = False
                .EnableGlass = False
                .MinimizeBox = False
                .MaximizeBox = False
                .FormBorderStyle = FormBorderStyle.Fixed3D
                .MdiParent = Me
                .Dock = DockStyle.Fill 'Control.Dock hide windows button (min, max, close)
                .ShowIcon = False
                .ShowInTaskbar = False
                .Text = String.Empty
                .Show()
            End With
        End If
    End Sub

    Private Sub ChildrenReportButtonItem_Click(sender As Object, e As EventArgs) Handles ChildrenReportButtonItem.Click
        Dim Warning As Integer = MessageBox.Show("Are you sure you want to open this form?" & vbNewLine & "Everything not saved will be lost.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Warning = DialogResult.No Then
            Return
        ElseIf Warning = DialogResult.Yes Then
            For Each child As Form In Me.MdiChildren
                child.Close()
            Next child
            With ChildrenReport
                .AutoScroll = True
                .ControlBox = False
                .EnableGlass = False
                .MinimizeBox = False
                .MaximizeBox = False
                .FormBorderStyle = FormBorderStyle.Fixed3D
                .MdiParent = Me
                .Dock = DockStyle.Fill 'Control.Dock hide windows button (min, max, close)
                .ShowIcon = False
                .ShowInTaskbar = False
                .Text = String.Empty
                .Show()
            End With
        End If
    End Sub

    Private Sub AdopterReportButtonItem_Click(sender As Object, e As EventArgs) Handles AdopterReportButtonItem.Click
        Dim Warning As Integer = MessageBox.Show("Are you sure you want to open this form?" & vbNewLine & "Everything not saved will be lost.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Warning = DialogResult.No Then
            Return
        ElseIf Warning = DialogResult.Yes Then
            For Each child As Form In Me.MdiChildren
                child.Close()
            Next child
            With AdopterReport
                .AutoScroll = True
                .ControlBox = False
                .EnableGlass = False
                .MinimizeBox = False
                .MaximizeBox = False
                .FormBorderStyle = FormBorderStyle.Fixed3D
                .MdiParent = Me
                .Dock = DockStyle.Fill 'Control.Dock hide windows button (min, max, close)
                .ShowIcon = False
                .ShowInTaskbar = False
                .Text = String.Empty
                .Show()
            End With
        End If
    End Sub

    Private Sub AddDonorButtonItem_Click(sender As Object, e As EventArgs) Handles AddDonorButtonItem.Click
        Dim Warning As Integer = MessageBox.Show("Are you sure you want to open this form?" & vbNewLine & "Everything not saved will be lost.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Warning = DialogResult.No Then
            Return
        ElseIf Warning = DialogResult.Yes Then
            For Each child As Form In Me.MdiChildren
                child.Close()
            Next child
            With AddDonorForm
                .AutoScroll = True
                .ControlBox = False
                .EnableGlass = False
                .MinimizeBox = False
                .MaximizeBox = False
                .FormBorderStyle = FormBorderStyle.Fixed3D
                .MdiParent = Me
                .Dock = DockStyle.Fill 'Control.Dock hide windows button (min, max, close)
                .ShowIcon = False
                .ShowInTaskbar = False
                .Text = String.Empty
                .Show()
            End With
        End If
    End Sub

    Private Sub DonorReportButtonItem_Click(sender As Object, e As EventArgs) Handles DonorReportButtonItem.Click
        Dim Warning As Integer = MessageBox.Show("Are you sure you want to open this form?" & vbNewLine & "Everything not saved will be lost.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Warning = DialogResult.No Then
            Return
        ElseIf Warning = DialogResult.Yes Then
            For Each child As Form In Me.MdiChildren
                child.Close()
            Next child
            With DonorReport
                .AutoScroll = True
                .ControlBox = False
                .EnableGlass = False
                .MinimizeBox = False
                .MaximizeBox = False
                .FormBorderStyle = FormBorderStyle.Fixed3D
                .MdiParent = Me
                .Dock = DockStyle.Fill 'Control.Dock hide windows button (min, max, close)
                .ShowIcon = False
                .ShowInTaskbar = False
                .Text = String.Empty
                .Show()
            End With
        End If
    End Sub

    Private Sub SignUpButtonItem_Click(sender As Object, e As EventArgs) Handles SignUpButtonItem.Click
        Dim Warning As Integer = MessageBox.Show("Are you sure you want to open this form?" & vbNewLine & "Everything not saved will be lost.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Warning = DialogResult.No Then
            Return
        ElseIf Warning = DialogResult.Yes Then
            For Each child As Form In Me.MdiChildren
                child.Close()
            Next child
            With AdminSignUpForm
                .AutoScroll = True
                .ControlBox = False
                .EnableGlass = False
                .MinimizeBox = False
                .MaximizeBox = False
                .FormBorderStyle = FormBorderStyle.Fixed3D
                .MdiParent = Me
                .Dock = DockStyle.Fill 'Control.Dock hide windows button (min, max, close)
                .ShowIcon = False
                .ShowInTaskbar = False
                .Text = String.Empty
                .Show()
            End With
        End If

    End Sub

    Private Sub NewSpendButtonItem_Click(sender As Object, e As EventArgs) Handles NewSpendButtonItem.Click
        Dim Warning As Integer = MessageBox.Show("Are you sure you want to open this form?" & vbNewLine & "Everything not saved will be lost.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Warning = DialogResult.No Then
            Return
        ElseIf Warning = DialogResult.Yes Then
            For Each child As Form In Me.MdiChildren
                child.Close()
            Next child
            With AddSpendForm
                .AutoScroll = True
                .ControlBox = False
                .EnableGlass = False
                .MinimizeBox = False
                .MaximizeBox = False
                .FormBorderStyle = FormBorderStyle.Fixed3D
                .MdiParent = Me
                .Dock = DockStyle.Fill 'Control.Dock hide windows button (min, max, close)
                .ShowIcon = False
                .ShowInTaskbar = False
                .Text = String.Empty
                .Show()
            End With
        End If

    End Sub

    Private Sub ButtonItem3_Click(sender As Object, e As EventArgs) Handles ButtonItem3.Click
        Dim Warning As Integer = MessageBox.Show("Are you sure you want to open this form?" & vbNewLine & "Everything not saved will be lost.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Warning = DialogResult.No Then
            Return
        ElseIf Warning = DialogResult.Yes Then
            For Each child As Form In Me.MdiChildren
                child.Close()
            Next child
            With AddDonationForm
                .AutoScroll = True
                .ControlBox = False
                .EnableGlass = False
                .MinimizeBox = False
                .MaximizeBox = False
                .FormBorderStyle = FormBorderStyle.Fixed3D
                .MdiParent = Me
                .Dock = DockStyle.Fill 'Control.Dock hide windows button (min, max, close)
                .ShowIcon = False
                .ShowInTaskbar = False
                .Text = String.Empty
                .Show()
            End With
        End If

    End Sub

    Private Sub BalanceButtonItem_Click(sender As Object, e As EventArgs) Handles BalanceButtonItem.Click
        Dim Warning As Integer = MessageBox.Show("Are you sure you want to open this form?" & vbNewLine & "Everything not saved will be lost.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Warning = DialogResult.No Then
            Return
        ElseIf Warning = DialogResult.Yes Then
            For Each child As Form In Me.MdiChildren
                child.Close()
            Next child
            With BalanceReport
                .AutoScroll = True
                .ControlBox = False
                .EnableGlass = False
                .MinimizeBox = False
                .MaximizeBox = False
                .FormBorderStyle = FormBorderStyle.Fixed3D
                .MdiParent = Me
                .Dock = DockStyle.Fill 'Control.Dock hide windows button (min, max, close)
                .ShowIcon = False
                .ShowInTaskbar = False
                .Text = String.Empty
                .Show()
            End With
        End If

    End Sub
End Class