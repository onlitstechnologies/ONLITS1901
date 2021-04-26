<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.LlbClickMe = New System.Windows.Forms.LinkLabel()
        Me.LstNames = New System.Windows.Forms.ListBox()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.TxtListCount = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LlbClickMe
        '
        Me.LlbClickMe.AutoSize = True
        Me.LlbClickMe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LlbClickMe.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LlbClickMe.Location = New System.Drawing.Point(698, 71)
        Me.LlbClickMe.Name = "LlbClickMe"
        Me.LlbClickMe.Size = New System.Drawing.Size(72, 20)
        Me.LlbClickMe.TabIndex = 0
        Me.LlbClickMe.TabStop = True
        Me.LlbClickMe.Text = "Click Me!"
        '
        'LstNames
        '
        Me.LstNames.FormattingEnabled = True
        Me.LstNames.Items.AddRange(New Object() {"Neha", "Prince", "Aman", "Banty", "Waseem"})
        Me.LstNames.Location = New System.Drawing.Point(99, 142)
        Me.LstNames.Name = "LstNames"
        Me.LstNames.Size = New System.Drawing.Size(120, 69)
        Me.LstNames.TabIndex = 1
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(334, 168)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(100, 20)
        Me.TxtName.TabIndex = 2
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(334, 231)
        Me.MaskedTextBox1.Mask = "00/00/0000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBox1.TabIndex = 3
        Me.MaskedTextBox1.ValidatingType = GetType(Date)
        '
        'TxtListCount
        '
        Me.TxtListCount.Location = New System.Drawing.Point(119, 241)
        Me.TxtListCount.Name = "TxtListCount"
        Me.TxtListCount.Size = New System.Drawing.Size(100, 20)
        Me.TxtListCount.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 244)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "List Count"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtListCount)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.LstNames)
        Me.Controls.Add(Me.LlbClickMe)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LlbClickMe As LinkLabel
    Friend WithEvents LstNames As ListBox
    Friend WithEvents TxtName As TextBox
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents TxtListCount As TextBox
    Friend WithEvents Label1 As Label
End Class
