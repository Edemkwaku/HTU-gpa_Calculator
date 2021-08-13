Public Class ResultDetail

    Private Sub ResultDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim firstYearTotalCreditHour As Double = crH1 + crH2
        Dim firstYearTotalCgpa As Double = cgpa1 + cgpa2

        Dim secondYearTotalCreditHour As Double = crH3 + crH4
        Dim secondYearTotalCgpa As Double = cgpa3 + cgpa4

        lblFirstCGPA.Text = firstYearTotalCgpa
        lblSecondCGPA.Text = secondYearTotalCgpa

        lblCGPA.Text = Val(lblFirstCGPA.Text) + Val(lblSecondCGPA.Text)
        lblCreditHour.Text = Val(firstYearTotalCreditHour) + Val(secondYearTotalCreditHour)

        lblFirstCreditHour.Text = firstYearTotalCreditHour
        secondCreditHour.Text = secondYearTotalCreditHour


     
        Dim tgpa As Double
        'Dim lblTTgpa, lblCredit As Double

        'Double.TryParse(lblCGPA.Text, lblTTgpa)
        'Double.TryParse(lblCreditHour.Text, lblCredit)

        'tgpa = lblTTgpa / lblCredit

        tgpa = lblCGPA.Text / lblCreditHour.Text
        lblGPA.Text = tgpa.ToString("N2")

        'tgpa
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Application.Exit()
    End Sub

    Private Sub minimize_Click(sender As Object, e As EventArgs) Handles minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class