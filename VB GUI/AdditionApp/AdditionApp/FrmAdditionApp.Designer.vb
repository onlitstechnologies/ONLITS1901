<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdditionApp
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
        Me.LblAugend = New System.Windows.Forms.Label()
        Me.TxtAugend = New System.Windows.Forms.TextBox()
        Me.TxtAddend = New System.Windows.Forms.TextBox()
        Me.LblAddend = New System.Windows.Forms.Label()
        Me.TxtSum = New System.Windows.Forms.TextBox()
        Me.LblSum = New System.Windows.Forms.Label()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblAugend
        '
        Me.LblAugend.AutoSize = True
        Me.LblAugend.Location = New System.Drawing.Point(46, 28)
        Me.LblAugend.Name = "LblAugend"
        Me.LblAugend.Size = New System.Drawing.Size(44, 13)
        Me.LblAugend.TabIndex = 0
        Me.LblAugend.Text = "Augend"
        '
        'TxtAugend
        '
        Me.TxtAugend.Location = New System.Drawing.Point(122, 25)
        Me.TxtAugend.Name = "TxtAugend"
        Me.TxtAugend.Size = New System.Drawing.Size(100, 20)
        Me.TxtAugend.TabIndex = 1
        '
        'TxtAddend
        '
        Me.TxtAddend.Location = New System.Drawing.Point(122, 65)
        Me.TxtAddend.Name = "TxtAddend"
        Me.TxtAddend.Size = New System.Drawing.Size(100, 20)
        Me.TxtAddend.TabIndex = 3
        '
        'LblAddend
        '
        Me.LblAddend.AutoSize = True
        Me.LblAddend.Location = New System.Drawing.Point(46, 68)
        Me.LblAddend.Name = "LblAddend"
        Me.LblAddend.Size = New System.Drawing.Size(44, 13)
        Me.LblAddend.TabIndex = 2
        Me.LblAddend.Text = "Addend"
        '
        'TxtSum
        '
        Me.TxtSum.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSum.ForeColor = System.Drawing.Color.Red
        Me.TxtSum.Location = New System.Drawing.Point(122, 109)
        Me.TxtSum.Name = "TxtSum"
        Me.TxtSum.ReadOnly = True
        Me.TxtSum.Size = New System.Drawing.Size(100, 20)
        Me.TxtSum.TabIndex = 5
        Me.TxtSum.TabStop = False
        '
        'LblSum
        '
        Me.LblSum.AutoSize = True
        Me.LblSum.Location = New System.Drawing.Point(46, 112)
        Me.LblSum.Name = "LblSum"
        Me.LblSum.Size = New System.Drawing.Size(28, 13)
        Me.LblSum.TabIndex = 4
        Me.LblSum.Text = "Sum"
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(56, 152)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(75, 23)
        Me.BtnAdd.TabIndex = 6
        Me.BtnAdd.Text = "&Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnReset
        '
        Me.BtnReset.Location = New System.Drawing.Point(137, 152)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(75, 23)
        Me.BtnReset.TabIndex = 7
        Me.BtnReset.Text = "&Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'FrmAdditionApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(291, 221)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.TxtSum)
        Me.Controls.Add(Me.LblSum)
        Me.Controls.Add(Me.TxtAddend)
        Me.Controls.Add(Me.LblAddend)
        Me.Controls.Add(Me.TxtAugend)
        Me.Controls.Add(Me.LblAugend)
        Me.Name = "FrmAdditionApp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdditionApp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblAugend As Label
    Friend WithEvents TxtAugend As TextBox
    Friend WithEvents TxtAddend As TextBox
    Friend WithEvents LblAddend As Label
    Friend WithEvents TxtSum As TextBox
    Friend WithEvents LblSum As Label
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnReset As Button
End Class
