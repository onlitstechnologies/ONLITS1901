Public Class Form1
    Private Sub LlbClickMe_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LlbClickMe.LinkClicked
        MessageBox.Show("Great you have clicked me!")
    End Sub

    Private Sub LlbClickMe_MouseHover(sender As Object, e As EventArgs) Handles LlbClickMe.MouseHover
        LlbClickMe.LinkColor = Color.Gray
    End Sub

    Private Sub LlbClickMe_MouseLeave(sender As Object, e As EventArgs) Handles LlbClickMe.MouseLeave
        LlbClickMe.LinkColor = Color.Blue
    End Sub

    Private Sub LstNames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstNames.SelectedIndexChanged
        TxtName.Text = LstNames.SelectedItem
        'MessageBox.Show(LstNames.SelectedIndex)            OOP
        MsgBox(LstNames.SelectedIndex)                      'POP
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LstNames.Items.Add("John")
        LstNames.Items.Add("Rahul")

        TxtListCount.Text = LstNames.Items.Count
    End Sub
End Class
