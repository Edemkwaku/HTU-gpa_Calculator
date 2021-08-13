Public Class Level100_ResulDetails
    Private Sub minimize_Click_1(sender As Object, e As EventArgs) Handles minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Application.Exit()
    End Sub

    Private Sub Level1CGPA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblFirstCGPA.Text = gpa1
        lblSecondCGPA.Text = gpa2

        lblFirstCreditHour.Text = crH1
        secondCreditHour.Text = crH2

        lblCGPA.Text = Val(lblFirstCGPA.Text) + Val(lblSecondCGPA.Text)
        lblCreditHour.Text = Val(lblFirstCreditHour.Text) + Val(secondCreditHour.Text)

        Dim tgpa As Double
        'Dim lblTTgpa, lblCredit As Double

        'Double.TryParse(lblCGPA.Text, lblTTgpa)
        'Double.TryParse(lblCreditHour.Text, lblCredit)

        'tgpa = lblTTgpa / lblCredit

        tgpa = lblCreditHour.Text / lblCGPA.Text
        lblGPA.Text = tgpa.ToString("N2")

        'tgpa
    End Sub
End Class