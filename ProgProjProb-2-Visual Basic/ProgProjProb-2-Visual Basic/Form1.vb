Public Class frmBill
    'this program represents a billing report
    'a user can selecct items and then program computes total bill amount

    Dim bloWorkCost, nutEvaluationCost, nutJournalsCost As Double
    Dim totalBill As Double

    'set visible property of all three group boxes to false
    ' a group box should only become visible after corresponding check box is checked
    Private Sub chkBloodWork_CheckedChanged(sender As Object, e As EventArgs) Handles chkBloodWork.CheckedChanged
        If chkBloodWork.Checked = True Then
            grpBloodWork.Visible = True
        Else
            grpBloodWork.Visible = False
        End If
    End Sub

    Private Sub nutEvaluation_CheckedChanged(sender As Object, e As EventArgs) Handles chkNutEvaluation.CheckedChanged
        If chkNutEvaluation.Checked = True Then
            grpNutEvaluation.Visible = True
        Else
            grpNutEvaluation.Visible = False
        End If
    End Sub

    Private Sub chkNutJournals_CheckedChanged(sender As Object, e As EventArgs) Handles chkNutJournals.CheckedChanged
        If chkNutJournals.Checked = True Then
            grpNutJournals.Visible = True
        Else
            grpNutJournals.Visible = False
        End If

    End Sub
    'blood work options
    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        If chkBloodWork.Checked = True Then
            If radBasic.Checked = True Then
                bloWorkCost = 79.99
            ElseIf radCholesterol.Checked = True Then
                bloWorkCost = 129.99
            ElseIf radCholSugar.Checked = True Then
                bloWorkCost = 179.99
            ElseIf radAllFour.Checked = True Then
                bloWorkCost = 229.99
            End If
            totalBill += bloWorkCost
        End If
        'nutritional evaluation options
        If chkNutEvaluation.Checked = True Then
            If radBronze.Checked = True Then
                nutEvaluationCost = 199.99
            ElseIf radSilver.Checked = True Then
                nutEvaluationCost = 299.99
            ElseIf radGold.Checked = True Then
                nutEvaluationCost = 399.99
            End If
            totalBill += nutEvaluationCost
        End If
        'nutritional journal opitons
        If chkNutJournals.Checked = True Then
            If radIntake.Checked = True Then
                nutJournalsCost = 9.99
            ElseIf radBoth.Checked = True Then
                nutJournalsCost = 14.99
            End If
            totalBill += nutJournalsCost
        End If

        txtTotalBill.Text = totalBill.ToString("C") 'display total bill
    End Sub
End Class
