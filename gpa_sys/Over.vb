Public Class Over
   

    Private Sub Over_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Y1_1st.Text = gpa1
        Y1_2nd.Text = gpa2
        Y2_1st.Text = gpa3
        Y2_2nd.Text = gpa4
        Y3_1st.Text = gpa5
        Y3_2nd.Text = gpa6

        Credit1.Text = crH1
        Credit2.Text = crH2
        Credit3.Text = crH3
        Credit4.Text = crH4
        Credit5.Text = crH5
        Credit6.Text = crH6


        totalGpa.Text = gpa1 + gpa2 + gpa3 + gpa4 + gpa5 + gpa6
        creditHour.Text = crH1 + crH2 + crH3 + crH4 + crH5 + crH6



        fnalGpa.Text = getTotal()
        classObtained()

    End Sub

    Private Function getTotal()
        Dim total, all As Double
        all = creditHour.Text / totalGpa.Text
        total = all.ToString("N2")
        Return total
    End Function

    Private Sub classObtained()
        If (Val(fnalGpa.Text) >= 4.0 And Val(fnalGpa.Text) <= 5.0) Then
            ClassGet.Text = "1ST CLASS"
        ElseIf (Val(fnalGpa.Text) >= 3.0 And Val(fnalGpa.Text) < 4.0) Then
            ClassGet.Text = "2ND CLASS UPPER"
        ElseIf (Val(fnalGpa.Text) >= 2.0 And Val(fnalGpa.Text) < 3.0) Then
            ClassGet.Text = "2ND CLASS LOWER"
        ElseIf (Val(fnalGpa.Text) >= 1.0 And Val(fnalGpa.Text) < 2.0) Then
            ClassGet.Text = "3RD CLASS"
        ElseIf (Val(fnalGpa.Text) = 1.0) Then
            ClassGet.Text = "PASS"

        ElseIf fnalGpa.Text = "NaN" Then

            ClassGet.Text = ""
        End If

    End Sub

    Private Sub btnCloseForm_Click(sender As Object, e As EventArgs) Handles btnCloseForm.Click
        Application.Exit()
    End Sub

   
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
        BackColor = Color.Red
    End Sub
End Class