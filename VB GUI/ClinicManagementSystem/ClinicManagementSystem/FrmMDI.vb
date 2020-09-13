Public Class FrmMDI
    Private Sub NewDoctorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewDoctorToolStripMenuItem.Click
        FrmNewDoctor.Show()
    End Sub

    Private Sub EditDoctorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditDoctorToolStripMenuItem.Click
        FrmEditDoctor.Show()
    End Sub

    Private Sub NewPatientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewPatientToolStripMenuItem.Click
        FrmNewPatient.Show()
    End Sub

    Private Sub EditPatientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditPatientToolStripMenuItem.Click
        FrmEditPatient.Show()
    End Sub

    Private Sub NewAppointmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewAppointmentToolStripMenuItem.Click
        FrmNewAppointment.Show()
    End Sub

    Private Sub EditAppointmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditAppointmentToolStripMenuItem.Click
        FrmEditAppointment.Show()
    End Sub
End Class
