<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    'Inherits System.Windows.Forms.Form
    Inherits DevComponents.DotNetBar.Office2007RibbonForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.MainRibbonControl = New DevComponents.DotNetBar.RibbonControl()
        Me.AdoptionRibbonPanel = New DevComponents.DotNetBar.RibbonPanel()
        Me.ReportRibbonBar = New DevComponents.DotNetBar.RibbonBar()
        Me.ChildrenReportButtonItem = New DevComponents.DotNetBar.ButtonItem()
        Me.AdopterReportButtonItem = New DevComponents.DotNetBar.ButtonItem()
        Me.ChildrenRibbonBar = New DevComponents.DotNetBar.RibbonBar()
        Me.ChildrenButtonItem = New DevComponents.DotNetBar.ButtonItem()
        Me.AdoptionRibbonBar = New DevComponents.DotNetBar.RibbonBar()
        Me.ApplicationButtonItem = New DevComponents.DotNetBar.ButtonItem()
        Me.AccountRibbonPanel = New DevComponents.DotNetBar.RibbonPanel()
        Me.RibbonBar10 = New DevComponents.DotNetBar.RibbonBar()
        Me.DonorReportButtonItem = New DevComponents.DotNetBar.ButtonItem()
        Me.BalanceButtonItem = New DevComponents.DotNetBar.ButtonItem()
        Me.FinanceRibbonBar = New DevComponents.DotNetBar.RibbonBar()
        Me.NewSpendButtonItem = New DevComponents.DotNetBar.ButtonItem()
        Me.AccountRibbonBar = New DevComponents.DotNetBar.RibbonBar()
        Me.AddDonorButtonItem = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem3 = New DevComponents.DotNetBar.ButtonItem()
        Me.ManagerRibbonPanel = New DevComponents.DotNetBar.RibbonPanel()
        Me.RibbonBar6 = New DevComponents.DotNetBar.RibbonBar()
        Me.ButtonItem2 = New DevComponents.DotNetBar.ButtonItem()
        Me.SignUpButtonItem = New DevComponents.DotNetBar.ButtonItem()
        Me.AccountRibbonTabItem = New DevComponents.DotNetBar.RibbonTabItem()
        Me.AdoptionRibbonTabItem = New DevComponents.DotNetBar.RibbonTabItem()
        Me.ExpansionRibbonTabItem = New DevComponents.DotNetBar.RibbonTabItem()
        Me.ApplicationButton1 = New DevComponents.DotNetBar.ApplicationButton()
        Me.ItemContainer1 = New DevComponents.DotNetBar.ItemContainer()
        Me.ItemContainer2 = New DevComponents.DotNetBar.ItemContainer()
        Me.ItemContainer3 = New DevComponents.DotNetBar.ItemContainer()
        Me.ButtonItem5 = New DevComponents.DotNetBar.ButtonItem()
        Me.LogOffButtonItem = New DevComponents.DotNetBar.ButtonItem()
        Me.CloseButtonItem = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem()
        Me.QatCustomizeItem1 = New DevComponents.DotNetBar.QatCustomizeItem()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.MainRibbonControl.SuspendLayout()
        Me.AdoptionRibbonPanel.SuspendLayout()
        Me.AccountRibbonPanel.SuspendLayout()
        Me.ManagerRibbonPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainRibbonControl
        '
        '
        '
        '
        Me.MainRibbonControl.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MainRibbonControl.CaptionVisible = True
        Me.MainRibbonControl.Controls.Add(Me.AdoptionRibbonPanel)
        Me.MainRibbonControl.Controls.Add(Me.AccountRibbonPanel)
        Me.MainRibbonControl.Controls.Add(Me.ManagerRibbonPanel)
        Me.MainRibbonControl.Dock = System.Windows.Forms.DockStyle.Top
        Me.MainRibbonControl.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.AccountRibbonTabItem, Me.AdoptionRibbonTabItem, Me.ExpansionRibbonTabItem})
        Me.MainRibbonControl.KeyTipsFont = New System.Drawing.Font("Tahoma", 7.0!)
        Me.MainRibbonControl.Location = New System.Drawing.Point(5, 1)
        Me.MainRibbonControl.Name = "MainRibbonControl"
        Me.MainRibbonControl.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.MainRibbonControl.QuickToolbarItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ApplicationButton1, Me.ButtonItem1, Me.QatCustomizeItem1})
        Me.MainRibbonControl.RibbonStripFont = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainRibbonControl.Size = New System.Drawing.Size(772, 146)
        Me.MainRibbonControl.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.MainRibbonControl.SystemText.MaximizeRibbonText = "&Maximize the Ribbon"
        Me.MainRibbonControl.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon"
        Me.MainRibbonControl.SystemText.QatAddItemText = "&Add to Quick Access Toolbar"
        Me.MainRibbonControl.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>"
        Me.MainRibbonControl.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar..."
        Me.MainRibbonControl.SystemText.QatDialogAddButton = "&Add >>"
        Me.MainRibbonControl.SystemText.QatDialogCancelButton = "Cancel"
        Me.MainRibbonControl.SystemText.QatDialogCaption = "Customize Quick Access Toolbar"
        Me.MainRibbonControl.SystemText.QatDialogCategoriesLabel = "&Choose commands from:"
        Me.MainRibbonControl.SystemText.QatDialogOkButton = "OK"
        Me.MainRibbonControl.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon"
        Me.MainRibbonControl.SystemText.QatDialogRemoveButton = "&Remove"
        Me.MainRibbonControl.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon"
        Me.MainRibbonControl.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon"
        Me.MainRibbonControl.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar"
        Me.MainRibbonControl.TabGroupHeight = 14
        Me.MainRibbonControl.TabIndex = 0
        Me.MainRibbonControl.Text = "RibbonControl1"
        '
        'AdoptionRibbonPanel
        '
        Me.AdoptionRibbonPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.AdoptionRibbonPanel.Controls.Add(Me.ReportRibbonBar)
        Me.AdoptionRibbonPanel.Controls.Add(Me.ChildrenRibbonBar)
        Me.AdoptionRibbonPanel.Controls.Add(Me.AdoptionRibbonBar)
        Me.AdoptionRibbonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AdoptionRibbonPanel.Location = New System.Drawing.Point(0, 56)
        Me.AdoptionRibbonPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.AdoptionRibbonPanel.Name = "AdoptionRibbonPanel"
        Me.AdoptionRibbonPanel.Padding = New System.Windows.Forms.Padding(2, 0, 2, 3)
        Me.AdoptionRibbonPanel.Size = New System.Drawing.Size(772, 87)
        '
        '
        '
        Me.AdoptionRibbonPanel.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.AdoptionRibbonPanel.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.AdoptionRibbonPanel.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.AdoptionRibbonPanel.TabIndex = 5
        '
        'ReportRibbonBar
        '
        Me.ReportRibbonBar.AutoOverflowEnabled = True
        '
        '
        '
        Me.ReportRibbonBar.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.ReportRibbonBar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReportRibbonBar.ContainerControlProcessDialogKey = True
        Me.ReportRibbonBar.Dock = System.Windows.Forms.DockStyle.Left
        Me.ReportRibbonBar.DragDropSupport = True
        Me.ReportRibbonBar.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ChildrenReportButtonItem, Me.AdopterReportButtonItem})
        Me.ReportRibbonBar.Location = New System.Drawing.Point(177, 0)
        Me.ReportRibbonBar.Name = "ReportRibbonBar"
        Me.ReportRibbonBar.Size = New System.Drawing.Size(231, 84)
        Me.ReportRibbonBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ReportRibbonBar.TabIndex = 2
        Me.ReportRibbonBar.Text = "Report"
        '
        '
        '
        Me.ReportRibbonBar.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.ReportRibbonBar.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ChildrenReportButtonItem
        '
        Me.ChildrenReportButtonItem.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ChildrenReportButtonItem.Image = Global.OMS.My.Resources.Resources.ic_child_care_black_18dp_2x
        Me.ChildrenReportButtonItem.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium
        Me.ChildrenReportButtonItem.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ChildrenReportButtonItem.Name = "ChildrenReportButtonItem"
        Me.ChildrenReportButtonItem.SubItemsExpandWidth = 14
        Me.ChildrenReportButtonItem.Text = "Children Report"
        '
        'AdopterReportButtonItem
        '
        Me.AdopterReportButtonItem.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.AdopterReportButtonItem.Image = Global.OMS.My.Resources.Resources.adoption
        Me.AdopterReportButtonItem.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium
        Me.AdopterReportButtonItem.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.AdopterReportButtonItem.Name = "AdopterReportButtonItem"
        Me.AdopterReportButtonItem.SubItemsExpandWidth = 14
        Me.AdopterReportButtonItem.Text = "Adopter Report"
        '
        'ChildrenRibbonBar
        '
        Me.ChildrenRibbonBar.AutoOverflowEnabled = True
        '
        '
        '
        Me.ChildrenRibbonBar.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.ChildrenRibbonBar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ChildrenRibbonBar.ContainerControlProcessDialogKey = True
        Me.ChildrenRibbonBar.Dock = System.Windows.Forms.DockStyle.Left
        Me.ChildrenRibbonBar.DragDropSupport = True
        Me.ChildrenRibbonBar.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ChildrenButtonItem})
        Me.ChildrenRibbonBar.Location = New System.Drawing.Point(77, 0)
        Me.ChildrenRibbonBar.Name = "ChildrenRibbonBar"
        Me.ChildrenRibbonBar.Size = New System.Drawing.Size(100, 84)
        Me.ChildrenRibbonBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ChildrenRibbonBar.TabIndex = 1
        Me.ChildrenRibbonBar.Text = "Children"
        '
        '
        '
        Me.ChildrenRibbonBar.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.ChildrenRibbonBar.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ChildrenButtonItem
        '
        Me.ChildrenButtonItem.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ChildrenButtonItem.Image = Global.OMS.My.Resources.Resources.ic_add_black_18dp_2x
        Me.ChildrenButtonItem.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium
        Me.ChildrenButtonItem.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ChildrenButtonItem.Name = "ChildrenButtonItem"
        Me.ChildrenButtonItem.SubItemsExpandWidth = 14
        Me.ChildrenButtonItem.Text = "Add Children"
        '
        'AdoptionRibbonBar
        '
        Me.AdoptionRibbonBar.AutoOverflowEnabled = True
        '
        '
        '
        Me.AdoptionRibbonBar.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.AdoptionRibbonBar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.AdoptionRibbonBar.ContainerControlProcessDialogKey = True
        Me.AdoptionRibbonBar.Dock = System.Windows.Forms.DockStyle.Left
        Me.AdoptionRibbonBar.DragDropSupport = True
        Me.AdoptionRibbonBar.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ApplicationButtonItem})
        Me.AdoptionRibbonBar.Location = New System.Drawing.Point(2, 0)
        Me.AdoptionRibbonBar.Margin = New System.Windows.Forms.Padding(2)
        Me.AdoptionRibbonBar.Name = "AdoptionRibbonBar"
        Me.AdoptionRibbonBar.Size = New System.Drawing.Size(75, 84)
        Me.AdoptionRibbonBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.AdoptionRibbonBar.TabIndex = 0
        Me.AdoptionRibbonBar.Text = "Adoption"
        '
        '
        '
        Me.AdoptionRibbonBar.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.AdoptionRibbonBar.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ApplicationButtonItem
        '
        Me.ApplicationButtonItem.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ApplicationButtonItem.Image = Global.OMS.My.Resources.Resources.ic_account_box_black_18dp_2x
        Me.ApplicationButtonItem.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium
        Me.ApplicationButtonItem.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ApplicationButtonItem.Name = "ApplicationButtonItem"
        Me.ApplicationButtonItem.SubItemsExpandWidth = 14
        Me.ApplicationButtonItem.Text = "Add Adoption Application"
        '
        'AccountRibbonPanel
        '
        Me.AccountRibbonPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.AccountRibbonPanel.Controls.Add(Me.RibbonBar10)
        Me.AccountRibbonPanel.Controls.Add(Me.FinanceRibbonBar)
        Me.AccountRibbonPanel.Controls.Add(Me.AccountRibbonBar)
        Me.AccountRibbonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AccountRibbonPanel.Location = New System.Drawing.Point(0, 56)
        Me.AccountRibbonPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.AccountRibbonPanel.Name = "AccountRibbonPanel"
        Me.AccountRibbonPanel.Padding = New System.Windows.Forms.Padding(2, 0, 2, 3)
        Me.AccountRibbonPanel.Size = New System.Drawing.Size(772, 87)
        '
        '
        '
        Me.AccountRibbonPanel.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.AccountRibbonPanel.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.AccountRibbonPanel.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.AccountRibbonPanel.TabIndex = 4
        Me.AccountRibbonPanel.Visible = False
        '
        'RibbonBar10
        '
        Me.RibbonBar10.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar10.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar10.ContainerControlProcessDialogKey = True
        Me.RibbonBar10.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar10.DragDropSupport = True
        Me.RibbonBar10.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.DonorReportButtonItem, Me.BalanceButtonItem})
        Me.RibbonBar10.Location = New System.Drawing.Point(364, 0)
        Me.RibbonBar10.Name = "RibbonBar10"
        Me.RibbonBar10.Size = New System.Drawing.Size(141, 84)
        Me.RibbonBar10.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar10.TabIndex = 2
        Me.RibbonBar10.Text = "Report"
        '
        '
        '
        Me.RibbonBar10.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar10.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'DonorReportButtonItem
        '
        Me.DonorReportButtonItem.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.DonorReportButtonItem.Image = Global.OMS.My.Resources.Resources.donation1
        Me.DonorReportButtonItem.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium
        Me.DonorReportButtonItem.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.DonorReportButtonItem.Name = "DonorReportButtonItem"
        Me.DonorReportButtonItem.SubItemsExpandWidth = 14
        Me.DonorReportButtonItem.Text = "Donor Report"
        '
        'BalanceButtonItem
        '
        Me.BalanceButtonItem.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.BalanceButtonItem.Image = Global.OMS.My.Resources.Resources.balance3
        Me.BalanceButtonItem.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium
        Me.BalanceButtonItem.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.BalanceButtonItem.Name = "BalanceButtonItem"
        Me.BalanceButtonItem.SubItemsExpandWidth = 14
        Me.BalanceButtonItem.Text = "Balance Report"
        '
        'FinanceRibbonBar
        '
        Me.FinanceRibbonBar.AutoOverflowEnabled = True
        '
        '
        '
        Me.FinanceRibbonBar.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.FinanceRibbonBar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.FinanceRibbonBar.ContainerControlProcessDialogKey = True
        Me.FinanceRibbonBar.Dock = System.Windows.Forms.DockStyle.Left
        Me.FinanceRibbonBar.DragDropSupport = True
        Me.FinanceRibbonBar.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.NewSpendButtonItem})
        Me.FinanceRibbonBar.Location = New System.Drawing.Point(159, 0)
        Me.FinanceRibbonBar.Name = "FinanceRibbonBar"
        Me.FinanceRibbonBar.Size = New System.Drawing.Size(205, 84)
        Me.FinanceRibbonBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.FinanceRibbonBar.TabIndex = 1
        Me.FinanceRibbonBar.Text = "Finance"
        '
        '
        '
        Me.FinanceRibbonBar.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.FinanceRibbonBar.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'NewSpendButtonItem
        '
        Me.NewSpendButtonItem.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.NewSpendButtonItem.Image = Global.OMS.My.Resources.Resources.spend2
        Me.NewSpendButtonItem.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium
        Me.NewSpendButtonItem.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.NewSpendButtonItem.Name = "NewSpendButtonItem"
        Me.NewSpendButtonItem.SubItemsExpandWidth = 14
        Me.NewSpendButtonItem.Text = "Add Spend"
        '
        'AccountRibbonBar
        '
        Me.AccountRibbonBar.AutoOverflowEnabled = True
        '
        '
        '
        Me.AccountRibbonBar.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.AccountRibbonBar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.AccountRibbonBar.ContainerControlProcessDialogKey = True
        Me.AccountRibbonBar.Dock = System.Windows.Forms.DockStyle.Left
        Me.AccountRibbonBar.DragDropSupport = True
        Me.AccountRibbonBar.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.AddDonorButtonItem, Me.ButtonItem3})
        Me.AccountRibbonBar.Location = New System.Drawing.Point(2, 0)
        Me.AccountRibbonBar.Margin = New System.Windows.Forms.Padding(2)
        Me.AccountRibbonBar.Name = "AccountRibbonBar"
        Me.AccountRibbonBar.Size = New System.Drawing.Size(157, 84)
        Me.AccountRibbonBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.AccountRibbonBar.TabIndex = 0
        Me.AccountRibbonBar.Text = "Donor && Donation"
        '
        '
        '
        Me.AccountRibbonBar.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.AccountRibbonBar.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'AddDonorButtonItem
        '
        Me.AddDonorButtonItem.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.AddDonorButtonItem.Image = Global.OMS.My.Resources.Resources.ic_add_black_18dp_2x
        Me.AddDonorButtonItem.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium
        Me.AddDonorButtonItem.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.AddDonorButtonItem.Name = "AddDonorButtonItem"
        Me.AddDonorButtonItem.SubItemsExpandWidth = 14
        Me.AddDonorButtonItem.Text = "Add Donor"
        '
        'ButtonItem3
        '
        Me.ButtonItem3.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem3.Image = Global.OMS.My.Resources.Resources.donation1
        Me.ButtonItem3.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium
        Me.ButtonItem3.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem3.Name = "ButtonItem3"
        Me.ButtonItem3.SubItemsExpandWidth = 14
        Me.ButtonItem3.Text = "Add Donation"
        '
        'ManagerRibbonPanel
        '
        Me.ManagerRibbonPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ManagerRibbonPanel.Controls.Add(Me.RibbonBar6)
        Me.ManagerRibbonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ManagerRibbonPanel.Location = New System.Drawing.Point(0, 56)
        Me.ManagerRibbonPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.ManagerRibbonPanel.Name = "ManagerRibbonPanel"
        Me.ManagerRibbonPanel.Padding = New System.Windows.Forms.Padding(2, 0, 2, 3)
        Me.ManagerRibbonPanel.Size = New System.Drawing.Size(772, 87)
        '
        '
        '
        Me.ManagerRibbonPanel.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.ManagerRibbonPanel.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.ManagerRibbonPanel.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ManagerRibbonPanel.TabIndex = 3
        Me.ManagerRibbonPanel.Visible = False
        '
        'RibbonBar6
        '
        Me.RibbonBar6.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar6.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar6.ContainerControlProcessDialogKey = True
        Me.RibbonBar6.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar6.DragDropSupport = True
        Me.RibbonBar6.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem2, Me.SignUpButtonItem})
        Me.RibbonBar6.Location = New System.Drawing.Point(2, 0)
        Me.RibbonBar6.Name = "RibbonBar6"
        Me.RibbonBar6.Size = New System.Drawing.Size(183, 84)
        Me.RibbonBar6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar6.TabIndex = 7
        Me.RibbonBar6.Text = "Employee Management"
        '
        '
        '
        Me.RibbonBar6.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar6.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ButtonItem2
        '
        Me.ButtonItem2.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem2.Image = Global.OMS.My.Resources.Resources.ic_search_black_24dp_2x
        Me.ButtonItem2.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium
        Me.ButtonItem2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem2.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center
        Me.ButtonItem2.Name = "ButtonItem2"
        Me.ButtonItem2.SubItemsExpandWidth = 14
        Me.ButtonItem2.Text = "Search Employee"
        '
        'SignUpButtonItem
        '
        Me.SignUpButtonItem.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.SignUpButtonItem.Image = Global.OMS.My.Resources.Resources.employee
        Me.SignUpButtonItem.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium
        Me.SignUpButtonItem.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.SignUpButtonItem.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center
        Me.SignUpButtonItem.Name = "SignUpButtonItem"
        Me.SignUpButtonItem.SubItemsExpandWidth = 14
        Me.SignUpButtonItem.Text = "Register Account"
        '
        'AccountRibbonTabItem
        '
        Me.AccountRibbonTabItem.Name = "AccountRibbonTabItem"
        Me.AccountRibbonTabItem.Panel = Me.AccountRibbonPanel
        Me.AccountRibbonTabItem.Text = "Accounting"
        '
        'AdoptionRibbonTabItem
        '
        Me.AdoptionRibbonTabItem.Checked = True
        Me.AdoptionRibbonTabItem.Name = "AdoptionRibbonTabItem"
        Me.AdoptionRibbonTabItem.Panel = Me.AdoptionRibbonPanel
        Me.AdoptionRibbonTabItem.Text = "Adoption"
        '
        'ExpansionRibbonTabItem
        '
        Me.ExpansionRibbonTabItem.Name = "ExpansionRibbonTabItem"
        Me.ExpansionRibbonTabItem.Panel = Me.ManagerRibbonPanel
        Me.ExpansionRibbonTabItem.Text = "Expansion"
        '
        'ApplicationButton1
        '
        Me.ApplicationButton1.AutoExpandOnClick = True
        Me.ApplicationButton1.CanCustomize = False
        Me.ApplicationButton1.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image
        Me.ApplicationButton1.Image = Global.OMS.My.Resources.Resources.icon_65_wt_no_word
        Me.ApplicationButton1.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium
        Me.ApplicationButton1.ImagePaddingHorizontal = 2
        Me.ApplicationButton1.ImagePaddingVertical = 2
        Me.ApplicationButton1.Name = "ApplicationButton1"
        Me.ApplicationButton1.ShowSubItems = False
        Me.ApplicationButton1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ItemContainer1})
        Me.ApplicationButton1.Text = "Start"
        '
        'ItemContainer1
        '
        '
        '
        '
        Me.ItemContainer1.BackgroundStyle.Class = "RibbonFileMenuContainer"
        Me.ItemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.ItemContainer1.Name = "ItemContainer1"
        Me.ItemContainer1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ItemContainer2})
        '
        '
        '
        Me.ItemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ItemContainer2
        '
        '
        '
        '
        Me.ItemContainer2.BackgroundStyle.Class = "RibbonFileMenuTwoColumnContainer"
        Me.ItemContainer2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer2.ItemSpacing = 0
        Me.ItemContainer2.Name = "ItemContainer2"
        Me.ItemContainer2.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ItemContainer3})
        '
        '
        '
        Me.ItemContainer2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ItemContainer3
        '
        '
        '
        '
        Me.ItemContainer3.BackgroundStyle.Class = "RibbonFileMenuColumnOneContainer"
        Me.ItemContainer3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer3.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.ItemContainer3.MinimumSize = New System.Drawing.Size(120, 0)
        Me.ItemContainer3.Name = "ItemContainer3"
        Me.ItemContainer3.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem5, Me.LogOffButtonItem, Me.CloseButtonItem})
        '
        '
        '
        Me.ItemContainer3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ButtonItem5
        '
        Me.ButtonItem5.Name = "ButtonItem5"
        Me.ButtonItem5.Text = "Search Employee"
        '
        'LogOffButtonItem
        '
        Me.LogOffButtonItem.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.LogOffButtonItem.Name = "LogOffButtonItem"
        Me.LogOffButtonItem.SubItemsExpandWidth = 24
        Me.LogOffButtonItem.Text = "Log Off"
        '
        'CloseButtonItem
        '
        Me.CloseButtonItem.BeginGroup = True
        Me.CloseButtonItem.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.CloseButtonItem.Name = "CloseButtonItem"
        Me.CloseButtonItem.SubItemsExpandWidth = 24
        Me.CloseButtonItem.Text = "&Close"
        '
        'ButtonItem1
        '
        Me.ButtonItem1.Name = "ButtonItem1"
        '
        'QatCustomizeItem1
        '
        Me.QatCustomizeItem1.Name = "QatCustomizeItem1"
        Me.QatCustomizeItem1.PopupType = DevComponents.DotNetBar.ePopupType.Container
        Me.QatCustomizeItem1.Visible = False
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007VistaGlass
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(154, Byte), Integer)))
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScrollMinSize = New System.Drawing.Size(1, 1)
        Me.ClientSize = New System.Drawing.Size(782, 583)
        Me.Controls.Add(Me.MainRibbonControl)
        Me.EnableGlass = False
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MinimumSize = New System.Drawing.Size(782, 584)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Orphanage Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MainRibbonControl.ResumeLayout(False)
        Me.MainRibbonControl.PerformLayout()
        Me.AdoptionRibbonPanel.ResumeLayout(False)
        Me.AccountRibbonPanel.ResumeLayout(False)
        Me.ManagerRibbonPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents QatCustomizeItem1 As DevComponents.DotNetBar.QatCustomizeItem
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Private WithEvents MainRibbonControl As DevComponents.DotNetBar.RibbonControl
    Private WithEvents ApplicationButton1 As DevComponents.DotNetBar.ApplicationButton
    Private WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
    Private WithEvents ItemContainer1 As DevComponents.DotNetBar.ItemContainer
    Private WithEvents ItemContainer2 As DevComponents.DotNetBar.ItemContainer
    Private WithEvents ItemContainer3 As DevComponents.DotNetBar.ItemContainer
    Private WithEvents LogOffButtonItem As DevComponents.DotNetBar.ButtonItem
    Private WithEvents CloseButtonItem As DevComponents.DotNetBar.ButtonItem
    Private WithEvents ManagerRibbonPanel As DevComponents.DotNetBar.RibbonPanel
    Private WithEvents ExpansionRibbonTabItem As DevComponents.DotNetBar.RibbonTabItem
    Private WithEvents AdoptionRibbonPanel As DevComponents.DotNetBar.RibbonPanel
    Private WithEvents AdoptionRibbonBar As DevComponents.DotNetBar.RibbonBar
    Private WithEvents AccountRibbonPanel As DevComponents.DotNetBar.RibbonPanel
    Private WithEvents AccountRibbonBar As DevComponents.DotNetBar.RibbonBar
    Private WithEvents AccountRibbonTabItem As DevComponents.DotNetBar.RibbonTabItem
    Private WithEvents AdoptionRibbonTabItem As DevComponents.DotNetBar.RibbonTabItem
    Private WithEvents FinanceRibbonBar As DevComponents.DotNetBar.RibbonBar
    Private WithEvents AddDonorButtonItem As DevComponents.DotNetBar.ButtonItem
    Private WithEvents ButtonItem3 As DevComponents.DotNetBar.ButtonItem
    Private WithEvents NewSpendButtonItem As DevComponents.DotNetBar.ButtonItem
    Private WithEvents RibbonBar6 As DevComponents.DotNetBar.RibbonBar
    Private WithEvents ButtonItem2 As DevComponents.DotNetBar.ButtonItem
    Private WithEvents ButtonItem5 As DevComponents.DotNetBar.ButtonItem
    Private WithEvents ReportRibbonBar As DevComponents.DotNetBar.RibbonBar
    Private WithEvents ChildrenReportButtonItem As DevComponents.DotNetBar.ButtonItem
    Private WithEvents AdopterReportButtonItem As DevComponents.DotNetBar.ButtonItem
    Private WithEvents ChildrenRibbonBar As DevComponents.DotNetBar.RibbonBar
    Private WithEvents ChildrenButtonItem As DevComponents.DotNetBar.ButtonItem
    Private WithEvents ApplicationButtonItem As DevComponents.DotNetBar.ButtonItem
    Private WithEvents RibbonBar10 As DevComponents.DotNetBar.RibbonBar
    Private WithEvents DonorReportButtonItem As DevComponents.DotNetBar.ButtonItem
    Private WithEvents BalanceButtonItem As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents SignUpButtonItem As DevComponents.DotNetBar.ButtonItem
End Class
