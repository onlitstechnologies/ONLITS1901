<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEMICalculator
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.BtnCalculate = New System.Windows.Forms.Button()
        Me.TxtInterestRate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTenure = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtPrincipal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LblTotalAmountPayable = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LblTotalInterest = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LblTotalPrincipal = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LblEMI = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DgvAmortizationSchedule = New System.Windows.Forms.DataGridView()
        Me.Month = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OpeningBalance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InterestPaid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrincipalPaid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClosingBalance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DgvAmortizationSchedule, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnReset)
        Me.GroupBox1.Controls.Add(Me.BtnCalculate)
        Me.GroupBox1.Controls.Add(Me.TxtInterestRate)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtTenure)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtPrincipal)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(353, 163)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "EMI Calculation"
        '
        'BtnReset
        '
        Me.BtnReset.Location = New System.Drawing.Point(256, 57)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(75, 23)
        Me.BtnReset.TabIndex = 7
        Me.BtnReset.Text = "&Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'BtnCalculate
        '
        Me.BtnCalculate.Location = New System.Drawing.Point(256, 26)
        Me.BtnCalculate.Name = "BtnCalculate"
        Me.BtnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.BtnCalculate.TabIndex = 6
        Me.BtnCalculate.Text = "&Calculate"
        Me.BtnCalculate.UseVisualStyleBackColor = True
        '
        'TxtInterestRate
        '
        Me.TxtInterestRate.Location = New System.Drawing.Point(96, 126)
        Me.TxtInterestRate.Name = "TxtInterestRate"
        Me.TxtInterestRate.Size = New System.Drawing.Size(100, 20)
        Me.TxtInterestRate.TabIndex = 5
        Me.TxtInterestRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Interest Rate"
        '
        'TxtTenure
        '
        Me.TxtTenure.Location = New System.Drawing.Point(96, 77)
        Me.TxtTenure.Name = "TxtTenure"
        Me.TxtTenure.Size = New System.Drawing.Size(100, 20)
        Me.TxtTenure.TabIndex = 3
        Me.TxtTenure.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tenure"
        '
        'TxtPrincipal
        '
        Me.TxtPrincipal.Location = New System.Drawing.Point(96, 28)
        Me.TxtPrincipal.Name = "TxtPrincipal"
        Me.TxtPrincipal.Size = New System.Drawing.Size(100, 20)
        Me.TxtPrincipal.TabIndex = 1
        Me.TxtPrincipal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Principal"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LblTotalAmountPayable)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.LblTotalInterest)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.LblTotalPrincipal)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.LblEMI)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(408, 29)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(243, 163)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "EMI Details"
        '
        'LblTotalAmountPayable
        '
        Me.LblTotalAmountPayable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalAmountPayable.Location = New System.Drawing.Point(164, 112)
        Me.LblTotalAmountPayable.Name = "LblTotalAmountPayable"
        Me.LblTotalAmountPayable.Size = New System.Drawing.Size(70, 13)
        Me.LblTotalAmountPayable.TabIndex = 8
        Me.LblTotalAmountPayable.Text = "0"
        Me.LblTotalAmountPayable.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(21, 112)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(111, 13)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Total Amount Payable"
        '
        'LblTotalInterest
        '
        Me.LblTotalInterest.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalInterest.Location = New System.Drawing.Point(164, 85)
        Me.LblTotalInterest.Name = "LblTotalInterest"
        Me.LblTotalInterest.Size = New System.Drawing.Size(70, 13)
        Me.LblTotalInterest.TabIndex = 6
        Me.LblTotalInterest.Text = "0"
        Me.LblTotalInterest.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(21, 85)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Total Interest"
        '
        'LblTotalPrincipal
        '
        Me.LblTotalPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalPrincipal.Location = New System.Drawing.Point(164, 63)
        Me.LblTotalPrincipal.Name = "LblTotalPrincipal"
        Me.LblTotalPrincipal.Size = New System.Drawing.Size(70, 13)
        Me.LblTotalPrincipal.TabIndex = 4
        Me.LblTotalPrincipal.Text = "0"
        Me.LblTotalPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Total Principal"
        '
        'LblEMI
        '
        Me.LblEMI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEMI.ForeColor = System.Drawing.Color.Red
        Me.LblEMI.Location = New System.Drawing.Point(164, 36)
        Me.LblEMI.Name = "LblEMI"
        Me.LblEMI.Size = New System.Drawing.Size(70, 13)
        Me.LblEMI.TabIndex = 2
        Me.LblEMI.Text = "0"
        Me.LblEMI.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "EMI"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DgvAmortizationSchedule)
        Me.GroupBox3.Location = New System.Drawing.Point(31, 218)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(620, 309)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Amortization Schedule"
        '
        'DgvAmortizationSchedule
        '
        Me.DgvAmortizationSchedule.AllowUserToAddRows = False
        Me.DgvAmortizationSchedule.AllowUserToDeleteRows = False
        Me.DgvAmortizationSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvAmortizationSchedule.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Month, Me.OpeningBalance, Me.EMI, Me.InterestPaid, Me.PrincipalPaid, Me.ClosingBalance})
        Me.DgvAmortizationSchedule.Location = New System.Drawing.Point(15, 24)
        Me.DgvAmortizationSchedule.MultiSelect = False
        Me.DgvAmortizationSchedule.Name = "DgvAmortizationSchedule"
        Me.DgvAmortizationSchedule.ReadOnly = True
        Me.DgvAmortizationSchedule.RowHeadersVisible = False
        Me.DgvAmortizationSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvAmortizationSchedule.Size = New System.Drawing.Size(593, 269)
        Me.DgvAmortizationSchedule.TabIndex = 0
        '
        'Month
        '
        Me.Month.HeaderText = "Month"
        Me.Month.Name = "Month"
        Me.Month.ReadOnly = True
        '
        'OpeningBalance
        '
        Me.OpeningBalance.HeaderText = "Opening Balance"
        Me.OpeningBalance.Name = "OpeningBalance"
        Me.OpeningBalance.ReadOnly = True
        '
        'EMI
        '
        Me.EMI.HeaderText = "EMI"
        Me.EMI.Name = "EMI"
        Me.EMI.ReadOnly = True
        '
        'InterestPaid
        '
        Me.InterestPaid.HeaderText = "Interest Paid"
        Me.InterestPaid.Name = "InterestPaid"
        Me.InterestPaid.ReadOnly = True
        '
        'PrincipalPaid
        '
        Me.PrincipalPaid.HeaderText = "Principal Paid"
        Me.PrincipalPaid.Name = "PrincipalPaid"
        Me.PrincipalPaid.ReadOnly = True
        '
        'ClosingBalance
        '
        Me.ClosingBalance.HeaderText = "Closing Balance"
        Me.ClosingBalance.Name = "ClosingBalance"
        Me.ClosingBalance.ReadOnly = True
        '
        'FrmEMICalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 550)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmEMICalculator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EMI Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DgvAmortizationSchedule, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TxtPrincipal As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnReset As Button
    Friend WithEvents BtnCalculate As Button
    Friend WithEvents TxtInterestRate As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtTenure As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DgvAmortizationSchedule As DataGridView
    Friend WithEvents LblTotalAmountPayable As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents LblTotalInterest As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents LblTotalPrincipal As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LblEMI As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Month As DataGridViewTextBoxColumn
    Friend WithEvents OpeningBalance As DataGridViewTextBoxColumn
    Friend WithEvents EMI As DataGridViewTextBoxColumn
    Friend WithEvents InterestPaid As DataGridViewTextBoxColumn
    Friend WithEvents PrincipalPaid As DataGridViewTextBoxColumn
    Friend WithEvents ClosingBalance As DataGridViewTextBoxColumn
End Class
