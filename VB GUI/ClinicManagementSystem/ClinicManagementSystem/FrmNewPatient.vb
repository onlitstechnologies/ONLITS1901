Imports System.Data.SqlClient
Public Class FrmNewPatient
    Dim con As New SqlConnection("Server=(localdb)\mssqllocaldb; Database=Clinic")
    Dim cmd As New SqlCommand()
    Dim dr As SqlDataReader
    Private Sub FrmNewPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = FrmMDI

        GeneratePatientId()
    End Sub

    Private Sub GeneratePatientId()
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SELECT patient_id FROM Patient"
        dr = cmd.ExecuteReader()
        While (dr.Read())
            TxtPatientId.Text = dr("patient_id")
        End While
        dr.Close()
        con.Close()

        If (TxtPatientId.Text = "") Then
            TxtPatientId.Text = "P001"
        Else
            TxtPatientId.Text = TxtPatientId.Text.Substring(1)

            TxtPatientId.Text += 1

            If (TxtPatientId.Text < 10) Then
                TxtPatientId.Text = "P00" & TxtPatientId.Text
            ElseIf (TxtPatientId.Text < 100) Then
                TxtPatientId.Text = "P0" & TxtPatientId.Text
            ElseIf (TxtPatientId.Text < 1000) Then
                TxtPatientId.Text = "P" & TxtPatientId.Text
            End If
        End If
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        Dim DT As New DataTable()
        Dim SqlDA As New SqlDataAdapter()
        Dim SqlCB As New SqlCommandBuilder(SqlDA)
        Dim DR As DataRow

        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SELECT * FROM Patient"
        SqlDA.SelectCommand = cmd
        SqlDA.Fill(DT)


        DR = DT.NewRow()                        'Initializing DR with a new row of DT
        DR("patient_id") = TxtPatientId.Text
        DR("patient_name") = TxtName.Text
        If (RdbMale.Checked) Then
            DR("gender") = "M"
        Else
            DR("gender") = "F"
        End If
        DR("date_of_birth") = DtpDateOfBirth.Value.Date

        DT.Rows.Add(DR)                         'Adding DR to DT

        SqlDA.Update(DT)

        con.Close()

        MessageBox.Show("Patient Registered Successfully...")

    End Sub
End Class