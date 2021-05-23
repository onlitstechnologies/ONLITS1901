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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BtnSR = New System.Windows.Forms.Button()
        Me.BtnBP = New System.Windows.Forms.Button()
        Me.PrdSR = New System.Drawing.Printing.PrintDocument()
        Me.PrdBP = New System.Drawing.Printing.PrintDocument()
        Me.PdgCommon = New System.Windows.Forms.PrintDialog()
        Me.PpdCommon = New System.Windows.Forms.PrintPreviewDialog()
        Me.SuspendLayout()
        '
        'BtnSR
        '
        Me.BtnSR.BackColor = System.Drawing.Color.Green
        Me.BtnSR.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSR.ForeColor = System.Drawing.Color.White
        Me.BtnSR.Location = New System.Drawing.Point(29, 27)
        Me.BtnSR.Name = "BtnSR"
        Me.BtnSR.Size = New System.Drawing.Size(210, 70)
        Me.BtnSR.TabIndex = 0
        Me.BtnSR.Text = "SR000"
        Me.BtnSR.UseVisualStyleBackColor = False
        '
        'BtnBP
        '
        Me.BtnBP.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnBP.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBP.ForeColor = System.Drawing.Color.White
        Me.BtnBP.Location = New System.Drawing.Point(245, 27)
        Me.BtnBP.Name = "BtnBP"
        Me.BtnBP.Size = New System.Drawing.Size(210, 70)
        Me.BtnBP.TabIndex = 1
        Me.BtnBP.Text = "BP000"
        Me.BtnBP.UseVisualStyleBackColor = False
        '
        'PrdSR
        '
        '
        'PdgCommon
        '
        Me.PdgCommon.UseEXDialog = True
        '
        'PpdCommon
        '
        Me.PpdCommon.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PpdCommon.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PpdCommon.ClientSize = New System.Drawing.Size(400, 300)
        Me.PpdCommon.Enabled = True
        Me.PpdCommon.Icon = CType(resources.GetObject("PpdCommon.Icon"), System.Drawing.Icon)
        Me.PpdCommon.Name = "PpdCommon"
        Me.PpdCommon.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 137)
        Me.Controls.Add(Me.BtnBP)
        Me.Controls.Add(Me.BtnSR)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Token Generator"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnSR As Button
    Friend WithEvents BtnBP As Button
    Friend WithEvents PrdSR As Printing.PrintDocument
    Friend WithEvents PrdBP As Printing.PrintDocument
    Friend WithEvents PdgCommon As PrintDialog
    Friend WithEvents PpdCommon As PrintPreviewDialog
End Class
