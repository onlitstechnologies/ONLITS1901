<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNewPatient
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
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.LlbBrowse = New System.Windows.Forms.LinkLabel()
        Me.PicPhoto = New System.Windows.Forms.PictureBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtContactNo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DtpDateOfBirth = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RdbFemale = New System.Windows.Forms.RadioButton()
        Me.RdbMale = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtDateOfRegistration = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtPatientId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PicPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(231, 316)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(75, 23)
        Me.BtnClose.TabIndex = 47
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnReset
        '
        Me.BtnReset.Location = New System.Drawing.Point(136, 316)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(75, 23)
        Me.BtnReset.TabIndex = 46
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'BtnSubmit
        '
        Me.BtnSubmit.Location = New System.Drawing.Point(38, 316)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.BtnSubmit.TabIndex = 45
        Me.BtnSubmit.Text = "Submit"
        Me.BtnSubmit.UseVisualStyleBackColor = True
        '
        'LlbBrowse
        '
        Me.LlbBrowse.AutoSize = True
        Me.LlbBrowse.Location = New System.Drawing.Point(652, 200)
        Me.LlbBrowse.Name = "LlbBrowse"
        Me.LlbBrowse.Size = New System.Drawing.Size(42, 13)
        Me.LlbBrowse.TabIndex = 44
        Me.LlbBrowse.TabStop = True
        Me.LlbBrowse.Text = "Browse"
        '
        'PicPhoto
        '
        Me.PicPhoto.Location = New System.Drawing.Point(624, 80)
        Me.PicPhoto.Name = "PicPhoto"
        Me.PicPhoto.Size = New System.Drawing.Size(112, 108)
        Me.PicPhoto.TabIndex = 43
        Me.PicPhoto.TabStop = False
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(122, 237)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(198, 20)
        Me.TxtEmail.TabIndex = 38
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(35, 240)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Email"
        '
        'TxtContactNo
        '
        Me.TxtContactNo.Location = New System.Drawing.Point(122, 197)
        Me.TxtContactNo.Name = "TxtContactNo"
        Me.TxtContactNo.Size = New System.Drawing.Size(100, 20)
        Me.TxtContactNo.TabIndex = 36
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Mobile No"
        '
        'DtpDateOfBirth
        '
        Me.DtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDateOfBirth.Location = New System.Drawing.Point(122, 157)
        Me.DtpDateOfBirth.Name = "DtpDateOfBirth"
        Me.DtpDateOfBirth.Size = New System.Drawing.Size(111, 20)
        Me.DtpDateOfBirth.TabIndex = 34
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Date of Birth"
        '
        'RdbFemale
        '
        Me.RdbFemale.AutoSize = True
        Me.RdbFemale.Location = New System.Drawing.Point(193, 122)
        Me.RdbFemale.Name = "RdbFemale"
        Me.RdbFemale.Size = New System.Drawing.Size(59, 17)
        Me.RdbFemale.TabIndex = 32
        Me.RdbFemale.Text = "Female"
        Me.RdbFemale.UseVisualStyleBackColor = True
        '
        'RdbMale
        '
        Me.RdbMale.AutoSize = True
        Me.RdbMale.Checked = True
        Me.RdbMale.Location = New System.Drawing.Point(122, 122)
        Me.RdbMale.Name = "RdbMale"
        Me.RdbMale.Size = New System.Drawing.Size(48, 17)
        Me.RdbMale.TabIndex = 31
        Me.RdbMale.TabStop = True
        Me.RdbMale.Text = "Male"
        Me.RdbMale.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Gender"
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(122, 77)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(198, 20)
        Me.TxtName.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Name"
        '
        'TxtDateOfRegistration
        '
        Me.TxtDateOfRegistration.Location = New System.Drawing.Point(666, 32)
        Me.TxtDateOfRegistration.Name = "TxtDateOfRegistration"
        Me.TxtDateOfRegistration.ReadOnly = True
        Me.TxtDateOfRegistration.Size = New System.Drawing.Size(100, 20)
        Me.TxtDateOfRegistration.TabIndex = 27
        Me.TxtDateOfRegistration.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(550, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Date of Registration"
        '
        'TxtPatientId
        '
        Me.TxtPatientId.Location = New System.Drawing.Point(122, 32)
        Me.TxtPatientId.Name = "TxtPatientId"
        Me.TxtPatientId.ReadOnly = True
        Me.TxtPatientId.Size = New System.Drawing.Size(100, 20)
        Me.TxtPatientId.TabIndex = 25
        Me.TxtPatientId.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Patient Id"
        '
        'FrmNewPatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 391)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.LlbBrowse)
        Me.Controls.Add(Me.PicPhoto)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtContactNo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DtpDateOfBirth)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.RdbFemale)
        Me.Controls.Add(Me.RdbMale)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtDateOfRegistration)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtPatientId)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmNewPatient"
        Me.Text = "New Patient"
        CType(Me.PicPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnReset As Button
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents LlbBrowse As LinkLabel
    Friend WithEvents PicPhoto As PictureBox
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtContactNo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DtpDateOfBirth As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents RdbFemale As RadioButton
    Friend WithEvents RdbMale As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtDateOfRegistration As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtPatientId As TextBox
    Friend WithEvents Label1 As Label
End Class
