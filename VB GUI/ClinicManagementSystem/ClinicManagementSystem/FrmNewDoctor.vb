Imports System.IO
Imports System.Data.SqlClient
Public Class FrmNewDoctor
    Private Sub FrmNewDoctor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = FrmMDI

        TxtDateOfJoining.Text = Today.Date()

        '--Populating Specialization combobox
        CboSpecialization.Items.Add("General Physician")
        CboSpecialization.Items.Add("Opthomologist")
        CboSpecialization.Items.Add("Cardiologist")
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub LlbBrowse_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LlbBrowse.LinkClicked
        Dim ofd As New OpenFileDialog()
        ofd.ShowDialog()
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        Dim con As New SqlConnection("Server=(localdb)\mssqllocaldb;Database=Clinic")
        Dim cmd As New SqlCommand()
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "INSERT INTO Doctor VALUES('D001','Prince Kumar','M','1985-06-07')"
        cmd.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Data inserted successfully!")
    End Sub
End Class