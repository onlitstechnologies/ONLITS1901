<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNewBus
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtRegistrationNumber = New System.Windows.Forms.TextBox()
        Me.TxtDateAdded = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CboMake = New System.Windows.Forms.ComboBox()
        Me.CboModel = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Registration Number"
        '
        'TxtRegistrationNumber
        '
        Me.TxtRegistrationNumber.Location = New System.Drawing.Point(193, 35)
        Me.TxtRegistrationNumber.Name = "TxtRegistrationNumber"
        Me.TxtRegistrationNumber.Size = New System.Drawing.Size(100, 20)
        Me.TxtRegistrationNumber.TabIndex = 1
        '
        'TxtDateAdded
        '
        Me.TxtDateAdded.Location = New System.Drawing.Point(634, 38)
        Me.TxtDateAdded.Name = "TxtDateAdded"
        Me.TxtDateAdded.ReadOnly = True
        Me.TxtDateAdded.Size = New System.Drawing.Size(100, 20)
        Me.TxtDateAdded.TabIndex = 3
        Me.TxtDateAdded.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(462, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Date Added"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Make"
        '
        'CboMake
        '
        Me.CboMake.FormattingEnabled = True
        Me.CboMake.Location = New System.Drawing.Point(193, 83)
        Me.CboMake.Name = "CboMake"
        Me.CboMake.Size = New System.Drawing.Size(121, 21)
        Me.CboMake.TabIndex = 5
        '
        'CboModel
        '
        Me.CboModel.FormattingEnabled = True
        Me.CboModel.Location = New System.Drawing.Point(193, 130)
        Me.CboModel.Name = "CboModel"
        Me.CboModel.Size = New System.Drawing.Size(121, 21)
        Me.CboModel.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Model"
        '
        'BtnSubmit
        '
        Me.BtnSubmit.Location = New System.Drawing.Point(24, 203)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.BtnSubmit.TabIndex = 8
        Me.BtnSubmit.Text = "&Submit"
        Me.BtnSubmit.UseVisualStyleBackColor = True
        '
        'FrmNewBus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 324)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.CboModel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CboMake)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtDateAdded)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtRegistrationNumber)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmNewBus"
        Me.Text = "New Bus"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtRegistrationNumber As TextBox
    Friend WithEvents TxtDateAdded As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CboMake As ComboBox
    Friend WithEvents CboModel As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnSubmit As Button
End Class
