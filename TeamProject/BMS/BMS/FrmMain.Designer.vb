<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BranchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewBranchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditBranchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewAccountTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditAccountTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterToolStripMenuItem, Me.TransactionToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserToolStripMenuItem, Me.BranchToolStripMenuItem, Me.AccountTypeToolStripMenuItem, Me.CustomerToolStripMenuItem})
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.MasterToolStripMenuItem.Text = "Master"
        '
        'TransactionToolStripMenuItem
        '
        Me.TransactionToolStripMenuItem.Name = "TransactionToolStripMenuItem"
        Me.TransactionToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.TransactionToolStripMenuItem.Text = "Transaction"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'BranchToolStripMenuItem
        '
        Me.BranchToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewBranchToolStripMenuItem, Me.EditBranchToolStripMenuItem})
        Me.BranchToolStripMenuItem.Name = "BranchToolStripMenuItem"
        Me.BranchToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BranchToolStripMenuItem.Text = "Branch"
        '
        'NewBranchToolStripMenuItem
        '
        Me.NewBranchToolStripMenuItem.Name = "NewBranchToolStripMenuItem"
        Me.NewBranchToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NewBranchToolStripMenuItem.Text = "New Branch"
        '
        'EditBranchToolStripMenuItem
        '
        Me.EditBranchToolStripMenuItem.Name = "EditBranchToolStripMenuItem"
        Me.EditBranchToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EditBranchToolStripMenuItem.Text = "Edit Branch"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewUserToolStripMenuItem, Me.EditUserToolStripMenuItem})
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.UserToolStripMenuItem.Text = "User"
        '
        'NewUserToolStripMenuItem
        '
        Me.NewUserToolStripMenuItem.Name = "NewUserToolStripMenuItem"
        Me.NewUserToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NewUserToolStripMenuItem.Text = "New User"
        '
        'EditUserToolStripMenuItem
        '
        Me.EditUserToolStripMenuItem.Name = "EditUserToolStripMenuItem"
        Me.EditUserToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EditUserToolStripMenuItem.Text = "Edit User"
        '
        'AccountTypeToolStripMenuItem
        '
        Me.AccountTypeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewAccountTypeToolStripMenuItem, Me.EditAccountTypeToolStripMenuItem})
        Me.AccountTypeToolStripMenuItem.Name = "AccountTypeToolStripMenuItem"
        Me.AccountTypeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AccountTypeToolStripMenuItem.Text = "Account Type"
        '
        'NewAccountTypeToolStripMenuItem
        '
        Me.NewAccountTypeToolStripMenuItem.Name = "NewAccountTypeToolStripMenuItem"
        Me.NewAccountTypeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NewAccountTypeToolStripMenuItem.Text = "New Account Type"
        '
        'EditAccountTypeToolStripMenuItem
        '
        Me.EditAccountTypeToolStripMenuItem.Name = "EditAccountTypeToolStripMenuItem"
        Me.EditAccountTypeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EditAccountTypeToolStripMenuItem.Text = "Edit Account Type"
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewCustomerToolStripMenuItem, Me.EditCustomerToolStripMenuItem})
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CustomerToolStripMenuItem.Text = "Customer"
        '
        'NewCustomerToolStripMenuItem
        '
        Me.NewCustomerToolStripMenuItem.Name = "NewCustomerToolStripMenuItem"
        Me.NewCustomerToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NewCustomerToolStripMenuItem.Text = "New Customer"
        '
        'EditCustomerToolStripMenuItem
        '
        Me.EditCustomerToolStripMenuItem.Name = "EditCustomerToolStripMenuItem"
        Me.EditCustomerToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EditCustomerToolStripMenuItem.Text = "Edit Customer"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Bank Management System v1.0"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BranchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewBranchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditBranchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccountTypeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewAccountTypeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditAccountTypeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewCustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditCustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransactionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
End Class
