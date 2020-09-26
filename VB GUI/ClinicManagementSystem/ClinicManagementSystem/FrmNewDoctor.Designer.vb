<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNewDoctor
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
        Me.TxtDoctorId = New System.Windows.Forms.TextBox()
        Me.TxtDateOfJoining = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RdbMale = New System.Windows.Forms.RadioButton()
        Me.RdbFemale = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TxtContactNo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CboQualification = New System.Windows.Forms.ComboBox()
        Me.CboSpecialization = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PicPhoto = New System.Windows.Forms.PictureBox()
        Me.LlbBrowse = New System.Windows.Forms.LinkLabel()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        CType(Me.PicPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Doctor Id"
        '
        'TxtDoctorId
        '
        Me.TxtDoctorId.Location = New System.Drawing.Point(122, 22)
        Me.TxtDoctorId.Name = "TxtDoctorId"
        Me.TxtDoctorId.ReadOnly = True
        Me.TxtDoctorId.Size = New System.Drawing.Size(100, 20)
        Me.TxtDoctorId.TabIndex = 1
        Me.TxtDoctorId.TabStop = False
        '
        'TxtDateOfJoining
        '
        Me.TxtDateOfJoining.Location = New System.Drawing.Point(666, 22)
        Me.TxtDateOfJoining.Name = "TxtDateOfJoining"
        Me.TxtDateOfJoining.ReadOnly = True
        Me.TxtDateOfJoining.Size = New System.Drawing.Size(100, 20)
        Me.TxtDateOfJoining.TabIndex = 3
        Me.TxtDateOfJoining.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(579, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Date of Joining"
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(122, 67)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(198, 20)
        Me.TxtName.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Gender"
        '
        'RdbMale
        '
        Me.RdbMale.AutoSize = True
        Me.RdbMale.Location = New System.Drawing.Point(122, 112)
        Me.RdbMale.Name = "RdbMale"
        Me.RdbMale.Size = New System.Drawing.Size(48, 17)
        Me.RdbMale.TabIndex = 7
        Me.RdbMale.TabStop = True
        Me.RdbMale.Text = "Male"
        Me.RdbMale.UseVisualStyleBackColor = True
        '
        'RdbFemale
        '
        Me.RdbFemale.AutoSize = True
        Me.RdbFemale.Location = New System.Drawing.Point(193, 112)
        Me.RdbFemale.Name = "RdbFemale"
        Me.RdbFemale.Size = New System.Drawing.Size(59, 17)
        Me.RdbFemale.TabIndex = 8
        Me.RdbFemale.TabStop = True
        Me.RdbFemale.Text = "Female"
        Me.RdbFemale.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Date of Birth"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(122, 147)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(111, 20)
        Me.DateTimePicker1.TabIndex = 10
        '
        'TxtContactNo
        '
        Me.TxtContactNo.Location = New System.Drawing.Point(122, 187)
        Me.TxtContactNo.Name = "TxtContactNo"
        Me.TxtContactNo.Size = New System.Drawing.Size(100, 20)
        Me.TxtContactNo.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Mobile No"
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(122, 227)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(198, 20)
        Me.TxtEmail.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(35, 230)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Email"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(35, 273)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Qualification"
        '
        'CboQualification
        '
        Me.CboQualification.FormattingEnabled = True
        Me.CboQualification.Items.AddRange(New Object() {"MBBS", "MD (Medicine)", "FRCS"})
        Me.CboQualification.Location = New System.Drawing.Point(122, 270)
        Me.CboQualification.Name = "CboQualification"
        Me.CboQualification.Size = New System.Drawing.Size(121, 21)
        Me.CboQualification.TabIndex = 16
        '
        'CboSpecialization
        '
        Me.CboSpecialization.FormattingEnabled = True
        Me.CboSpecialization.Location = New System.Drawing.Point(122, 312)
        Me.CboSpecialization.Name = "CboSpecialization"
        Me.CboSpecialization.Size = New System.Drawing.Size(121, 21)
        Me.CboSpecialization.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(35, 315)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Specialization"
        '
        'PicPhoto
        '
        Me.PicPhoto.Location = New System.Drawing.Point(624, 70)
        Me.PicPhoto.Name = "PicPhoto"
        Me.PicPhoto.Size = New System.Drawing.Size(112, 108)
        Me.PicPhoto.TabIndex = 19
        Me.PicPhoto.TabStop = False
        '
        'LlbBrowse
        '
        Me.LlbBrowse.AutoSize = True
        Me.LlbBrowse.Location = New System.Drawing.Point(652, 190)
        Me.LlbBrowse.Name = "LlbBrowse"
        Me.LlbBrowse.Size = New System.Drawing.Size(42, 13)
        Me.LlbBrowse.TabIndex = 20
        Me.LlbBrowse.TabStop = True
        Me.LlbBrowse.Text = "Browse"
        '
        'BtnSubmit
        '
        Me.BtnSubmit.Location = New System.Drawing.Point(38, 385)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.BtnSubmit.TabIndex = 21
        Me.BtnSubmit.Text = "Submit"
        Me.BtnSubmit.UseVisualStyleBackColor = True
        '
        'BtnReset
        '
        Me.BtnReset.Location = New System.Drawing.Point(136, 385)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(75, 23)
        Me.BtnReset.TabIndex = 22
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(231, 385)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(75, 23)
        Me.BtnClose.TabIndex = 23
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'FrmNewDoctor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.LlbBrowse)
        Me.Controls.Add(Me.PicPhoto)
        Me.Controls.Add(Me.CboSpecialization)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.CboQualification)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtContactNo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.RdbFemale)
        Me.Controls.Add(Me.RdbMale)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtDateOfJoining)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtDoctorId)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmNewDoctor"
        Me.Text = "New Doctor"
        CType(Me.PicPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtDoctorId As TextBox
    Friend WithEvents TxtDateOfJoining As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents RdbMale As RadioButton
    Friend WithEvents RdbFemale As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TxtContactNo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents CboQualification As ComboBox
    Friend WithEvents CboSpecialization As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents PicPhoto As PictureBox
    Friend WithEvents LlbBrowse As LinkLabel
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents BtnReset As Button
    Friend WithEvents BtnClose As Button
End Class
