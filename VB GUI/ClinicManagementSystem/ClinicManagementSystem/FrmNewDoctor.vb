Imports System.IO
Imports System.Data.SqlClient

Public Class FrmNewDoctor
    Dim con As New SqlConnection("Server=(localdb)\mssqllocaldb;Database=Clinic")
    Dim cmd As New SqlCommand()
    Dim dr As SqlDataReader
    Private Sub FrmNewDoctor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = FrmMDI

        TxtDateOfJoining.Text = Today.Date()

        '--Populating Specialization combobox
        CboSpecialization.Items.Add("General Physician")
        CboSpecialization.Items.Add("Opthomologist")
        CboSpecialization.Items.Add("Cardiologist")

        GenerateDoctorId()

    End Sub

    Private Sub GenerateDoctorId()
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SELECT doctor_id FROM Doctor"
        dr = cmd.ExecuteReader()
        While (dr.Read())
            TxtDoctorId.Text = dr("doctor_id")
            MessageBox.Show("Pause...")
        End While
        dr.Close()
        con.Close()

        'TxtDoctorId.Text = TxtDoctorId.Text + 1
    End Sub


    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub LlbBrowse_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LlbBrowse.LinkClicked
        Dim ofd As New OpenFileDialog()
        ofd.ShowDialog()
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "INSERT INTO Doctor VALUES('" & TxtDoctorId.Text & "','" & TxtName.Text & "','M','1985-06-07')"
        cmd.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Data inserted successfully!")
    End Sub
End Class