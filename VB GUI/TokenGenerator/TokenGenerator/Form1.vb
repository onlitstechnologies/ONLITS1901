Public Class Form1
    Private Sub BtnSR_Click(sender As Object, e As EventArgs) Handles BtnSR.Click
        PpdCommon.Document = PrdSR
        If (PpdCommon.ShowDialog() = 1) Then

        End If
    End Sub

    Private Sub PrdSR_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrdSR.PrintPage
        e.Graphics.DrawString("SR", New Font("Arial", 20), Brushes.Black, New Point(50, 50))
        e.Graphics.DrawRectangle(Pens.Black, 20, 20, 200, 300)
    End Sub
End Class
