Public Class FrmEMICalculator
    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles BtnCalculate.Click
        Dim p, r, t, emi, iemi, pemi, ob, cb As Single

        p = TxtPrincipal.Text
        r = TxtInterestRate.Text
        t = TxtTenure.Text

        emi = Math.Round(Pmt(r / 100 / 12, t * 12, -p), 2)

        LblEMI.Text = emi

        LblTotalPrincipal.Text = TxtPrincipal.Text
        LblTotalAmountPayable.Text = emi * t * 12
        LblTotalInterest.Text = LblTotalAmountPayable.Text - TxtPrincipal.Text


        '------------ Working with datagridview ------------------
        ob = p
        For i As Integer = 0 To t * 12 - 1
            DgvAmortizationSchedule.Rows.Add()          'Adding rows to datagridview
            DgvAmortizationSchedule.Item("Month", i).Value = i + 1      'Assigining value to Month column
            DgvAmortizationSchedule.Item("OpeningBalance", i).Value = ob
            DgvAmortizationSchedule.Item("EMI", i).Value = emi
            iemi = Math.Round(IPmt(r / 100 / 12, i + 1, t * 12, -p), 2)
            DgvAmortizationSchedule.Item("InterestPaid", i).Value = iemi
            'pemi = PPmt(r / 100 / 12, i + 1, t * 12, -p)
            pemi = Math.Round(emi - iemi, 2)
            DgvAmortizationSchedule.Item("PrincipalPaid", i).Value = pemi
            cb = Math.Round(ob - pemi, 2)
            DgvAmortizationSchedule.Item("ClosingBalance", i).Value = cb
            ob = cb
        Next
    End Sub
End Class
