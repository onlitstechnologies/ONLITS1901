<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMDI
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
        Me.DoctorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewDoctorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditDoctorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewPatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditPatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AppointmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewAppointmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditAppointmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterToolStripMenuItem, Me.TransactionToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(813, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DoctorToolStripMenuItem, Me.PatientToolStripMenuItem, Me.BedToolStripMenuItem})
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.MasterToolStripMenuItem.Text = "Master"
        '
        'DoctorToolStripMenuItem
        '
        Me.DoctorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewDoctorToolStripMenuItem, Me.EditDoctorToolStripMenuItem})
        Me.DoctorToolStripMenuItem.Name = "DoctorToolStripMenuItem"
        Me.DoctorToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.DoctorToolStripMenuItem.Text = "Doctor"
        '
        'NewDoctorToolStripMenuItem
        '
        Me.NewDoctorToolStripMenuItem.Name = "NewDoctorToolStripMenuItem"
        Me.NewDoctorToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.NewDoctorToolStripMenuItem.Text = "New Doctor"
        '
        'EditDoctorToolStripMenuItem
        '
        Me.EditDoctorToolStripMenuItem.Name = "EditDoctorToolStripMenuItem"
        Me.EditDoctorToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.EditDoctorToolStripMenuItem.Text = "Edit Doctor"
        '
        'PatientToolStripMenuItem
        '
        Me.PatientToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewPatientToolStripMenuItem, Me.EditPatientToolStripMenuItem})
        Me.PatientToolStripMenuItem.Name = "PatientToolStripMenuItem"
        Me.PatientToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.PatientToolStripMenuItem.Text = "Patient"
        '
        'NewPatientToolStripMenuItem
        '
        Me.NewPatientToolStripMenuItem.Name = "NewPatientToolStripMenuItem"
        Me.NewPatientToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.NewPatientToolStripMenuItem.Text = "New Patient"
        '
        'EditPatientToolStripMenuItem
        '
        Me.EditPatientToolStripMenuItem.Name = "EditPatientToolStripMenuItem"
        Me.EditPatientToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.EditPatientToolStripMenuItem.Text = "Edit Patient"
        '
        'BedToolStripMenuItem
        '
        Me.BedToolStripMenuItem.Name = "BedToolStripMenuItem"
        Me.BedToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.BedToolStripMenuItem.Text = "Bed"
        '
        'TransactionToolStripMenuItem
        '
        Me.TransactionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AppointmentToolStripMenuItem})
        Me.TransactionToolStripMenuItem.Name = "TransactionToolStripMenuItem"
        Me.TransactionToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.TransactionToolStripMenuItem.Text = "Transaction"
        '
        'AppointmentToolStripMenuItem
        '
        Me.AppointmentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewAppointmentToolStripMenuItem, Me.EditAppointmentToolStripMenuItem})
        Me.AppointmentToolStripMenuItem.Name = "AppointmentToolStripMenuItem"
        Me.AppointmentToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.AppointmentToolStripMenuItem.Text = "Appointment"
        '
        'NewAppointmentToolStripMenuItem
        '
        Me.NewAppointmentToolStripMenuItem.Name = "NewAppointmentToolStripMenuItem"
        Me.NewAppointmentToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.NewAppointmentToolStripMenuItem.Text = "New Appointment"
        '
        'EditAppointmentToolStripMenuItem
        '
        Me.EditAppointmentToolStripMenuItem.Name = "EditAppointmentToolStripMenuItem"
        Me.EditAppointmentToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.EditAppointmentToolStripMenuItem.Text = "Edit Appointment"
        '
        'FrmMDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(813, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmMDI"
        Me.Text = "Clinic Management System v1.0"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DoctorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewDoctorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditDoctorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PatientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewPatientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditPatientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransactionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AppointmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewAppointmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditAppointmentToolStripMenuItem As ToolStripMenuItem
End Class
