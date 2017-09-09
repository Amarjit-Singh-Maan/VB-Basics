Public Class frmCaffeine
    Dim hours As Integer = 0

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'condition A
        'here we calculate number of hours required to reach 65mg
        Dim caffeineContent As Double = 130
        Do While caffeineContent >= 65
            caffeineContent = caffeineContent - 0.13 * caffeineContent '13 percent is eliminated hourly
            hours = hours + 1
        Loop
        txt65mg.Text = CStr(hours) & " hours"

        'condition B
        'here we calculate amount of caffeine in the body after 24 hours
        caffeineContent = 130 'reset value to 130mg
        For hours As Integer = 1 To 24
            caffeineContent = caffeineContent - 0.13 * caffeineContent
        Next
        txt24hours.Text = (caffeineContent).ToString("N") & " mg"

        'condition C
        'here we calculate amount of caffeine in the body after 24 hours
        'with added condition
        caffeineContent = 130 'reset value to 130mg
        For hours As Integer = 1 To 24
            caffeineContent -= 0.13 * caffeineContent
            caffeineContent += 130
        Next
        txtHourly.Text = (caffeineContent).ToString("N") & " mg"
    End Sub
End Class
