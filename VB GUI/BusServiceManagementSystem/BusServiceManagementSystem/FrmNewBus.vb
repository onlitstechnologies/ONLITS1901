Imports MySql.Data.MySqlClient
Public Class FrmNewBus
    Dim mysqlCon As New MySqlConnection("Server=localhost; Database=BSMS; uid=neha; pwd=neha")
    Dim mysqlCmd As New MySqlCommand()
    Dim mysqlDa As New MySqlDataAdapter()
    Dim ds As New DataSet()
    Dim dr As DataRow                       'Only reference of DataRow Class has been created
    Dim mysqlDr As MySqlDataReader          'Only reference of MySqlDataReader Class has been created
    Dim mysqlCb As New MySqlCommandBuilder(mysqlDa)
    Private Sub FrmNewBus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = FrmMain          'Setting this form a child of FrmMain

        TxtDateAdded.Text = Today.Date  'Setting current date to TxtDateAdded


        '--------------- Populating CboMake --------------
        mysqlCon.Open()
        mysqlCmd.Connection = mysqlCon
        mysqlCmd.CommandText = "SELECT Make FROM Make"
        mysqlDr = mysqlCmd.ExecuteReader()                  'Object of MySqlDataReader Class is created here
        While (mysqlDr.Read())
            CboMake.Items.Add(mysqlDr("Make"))
        End While
        mysqlDr.Close()
        mysqlCon.Close()

    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        mysqlCon.Open()
        mysqlCmd.Connection = mysqlCon
        mysqlCmd.CommandText = "SELECT * FROM Bus"
        mysqlDa.SelectCommand = mysqlCmd
        mysqlDa.Fill(ds, "Bus")
        dr = ds.Tables("Bus").NewRow()            'Oject of DataRow Class is create here
        dr("RegistrationNo") = TxtRegistrationNumber.Text
        dr("Make") = CboMake.Text
        dr("Model") = CboModel.Text
        ds.Tables("Bus").Rows.Add(dr)
        mysqlDa.Update(ds, "Bus")
        mysqlCon.Close()

        MessageBox.Show("Bus record created successfully!")
    End Sub

    Private Sub CboMake_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboMake.SelectedIndexChanged
        '--------------- Populating CboModel --------------
        CboModel.Items.Clear()
        mysqlCon.Open()
        mysqlCmd.Connection = mysqlCon
        mysqlCmd.CommandText = "SELECT Model FROM Model WHERE Make='" & CboMake.Text & "'"
        mysqlDr = mysqlCmd.ExecuteReader()
        While (mysqlDr.Read())
            CboModel.Items.Add(mysqlDr("Model"))
        End While
        mysqlDr.Close()
        mysqlCon.Close()
    End Sub
End Class