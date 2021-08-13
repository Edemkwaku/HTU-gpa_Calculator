Public Class Level300_2

    Dim ref1, ref2, ref3, ref4, ref5, ref6, ref7, ref8, ref9, ref10, ref11, ref12 As Integer

    Private Function TotalCredit() As Double
        Dim TotalCr As Double
        TotalCr = Val(TextBox10.Text) + Val(TextBox11.Text) + Val(TextBox12.Text) + Val(TextBox13.Text) + Val(TextBox14.Text) + Val(TextBox15.Text) + Val(TextBox16.Text) + Val(TextBox17.Text) + Val(CrH9.Text) + Val(CrH10.Text) + Val(CrH11.Text) + Val(CrH12.Text)
        Return TotalCr
    End Function


    Private Sub Level300_2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bbckground()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        ContiBtn()
    End Sub
    Private Sub ContiBtn()
        If ComboBox2.SelectedIndex >= 1 And ComboBox2.SelectedIndex <= 5 Then
            Me.GroupBox1.Height = 419
            Me.GroupBox1.Width = 831
            Me.Height = 471
            Me.Width = 850

        ElseIf ComboBox2.SelectedIndex > 5 And ComboBox2.SelectedIndex <= 7 Then
            Me.Width = 848
            Me.Height = 532
            Me.GroupBox1.Height = 481
            Me.GroupBox1.Width = 831
        ElseIf ComboBox2.SelectedIndex > 7 And ComboBox2.SelectedIndex <= 10 Then
            Me.Width = 848
            Me.Height = 627
            Me.GroupBox1.Height = 576
            Me.GroupBox1.Width = 831
        ElseIf ComboBox2.SelectedIndex > 10 And ComboBox2.SelectedIndex <= 12 Then
            Me.Width = 848
            Me.Height = 693
            Me.GroupBox1.Height = 642
            Me.GroupBox1.Width = 831
        Else
            Me.Width = 848
            Me.Height = 248
            Me.GroupBox1.Width = 829
            Me.GroupBox1.Height = 195

        End If


        If Me.ComboBox2.SelectedIndex = 1 Then
            Input1.Visible = True
            Input2.Visible = False
            Input3.Visible = False
            Input4.Visible = False
            Input5.Visible = False
            Input6.Visible = False
            Input7.Visible = False
            Input8.Visible = False
            Input9.Visible = False
            Input10.Visible = False
            Input11.Visible = False
            Input12.Visible = False

            TextBox18.Visible = True
            TextBox19.Visible = False
            TextBox20.Visible = False
            TextBox21.Visible = False
            TextBox22.Visible = False
            TextBox23.Visible = False
            TextBox24.Visible = False
            TextBox25.Visible = False
            Grade9.Visible = False
            Grade10.Visible = False
            Grade11.Visible = False
            Grade12.Visible = False

            TextBox10.Visible = True
            TextBox11.Visible = False
            TextBox12.Visible = False
            TextBox13.Visible = False
            TextBox14.Visible = False
            TextBox15.Visible = False
            TextBox16.Visible = False
            TextBox17.Visible = False
            CrH9.Visible = False
            CrH10.Visible = False
            CrH11.Visible = False
            CrH12.Visible = False

            'G*C textbox
            Label27.Visible = True
            Label28.Visible = False
            Label29.Visible = False
            Label30.Visible = False
            Label31.Visible = False
            Label32.Visible = False
            Label33.Visible = False
            Label34.Visible = False
            GpC9.Visible = False
            GpC10.Visible = False
            GpC11.Visible = False
            GpC12.Visible = False

            'Grade point textbox
            Label23.Visible = True
            Label16.Visible = False
            Label17.Visible = False
            Label18.Visible = False
            Label19.Visible = False
            Label20.Visible = False
            Label21.Visible = False
            Label22.Visible = False
            Gp9.Visible = False
            Gp10.Visible = False
            Gp11.Visible = False
            Gp12.Visible = False

        ElseIf ComboBox2.SelectedIndex = 2 Then
            Input1.Visible = True
            Input2.Visible = True
            Input3.Visible = False
            Input4.Visible = False
            Input5.Visible = False
            Input6.Visible = False
            Input7.Visible = False
            Input8.Visible = False
            Input9.Visible = False
            Input10.Visible = False
            Input11.Visible = False
            Input12.Visible = False

            TextBox18.Visible = True
            TextBox19.Visible = True
            TextBox20.Visible = False
            TextBox21.Visible = False
            TextBox22.Visible = False
            TextBox23.Visible = False
            TextBox24.Visible = False
            TextBox25.Visible = False
            Grade9.Visible = False
            Grade10.Visible = False
            Grade11.Visible = False
            Grade12.Visible = False

            TextBox10.Visible = True
            TextBox11.Visible = True
            TextBox12.Visible = False
            TextBox13.Visible = False
            TextBox14.Visible = False
            TextBox15.Visible = False
            TextBox16.Visible = False
            TextBox17.Visible = False
            CrH9.Visible = False
            CrH10.Visible = False
            CrH11.Visible = False
            CrH12.Visible = False

            'G*C textbox
            Label27.Visible = True
            Label28.Visible = True
            Label29.Visible = False
            Label30.Visible = False
            Label31.Visible = False
            Label32.Visible = False
            Label33.Visible = False
            Label34.Visible = False
            GpC9.Visible = False
            GpC10.Visible = False
            GpC11.Visible = False
            GpC12.Visible = False

            'Grade point textbox
            Label23.Visible = True
            Label16.Visible = True
            Label17.Visible = False
            Label18.Visible = False
            Label19.Visible = False
            Label20.Visible = False
            Label21.Visible = False
            Label22.Visible = False
            Gp9.Visible = False
            Gp10.Visible = False
            Gp11.Visible = False
            Gp12.Visible = False
        ElseIf ComboBox2.SelectedIndex = 3 Then
            Input1.Visible = True
            Input2.Visible = True
            Input3.Visible = True
            Input4.Visible = False
            Input5.Visible = False
            Input6.Visible = False
            Input7.Visible = False
            Input8.Visible = False
            Input9.Visible = False
            Input10.Visible = False
            Input11.Visible = False
            Input12.Visible = False


            TextBox18.Visible = True
            TextBox19.Visible = True
            TextBox20.Visible = True
            TextBox21.Visible = False
            TextBox22.Visible = False
            TextBox23.Visible = False
            TextBox24.Visible = False
            TextBox25.Visible = False
            Grade9.Visible = False
            Grade10.Visible = False
            Grade11.Visible = False
            Grade12.Visible = False

            TextBox10.Visible = True
            TextBox11.Visible = True
            TextBox12.Visible = True
            TextBox13.Visible = False
            TextBox14.Visible = False
            TextBox15.Visible = False
            TextBox16.Visible = False
            TextBox17.Visible = False
            CrH9.Visible = False
            CrH10.Visible = False
            CrH11.Visible = False
            CrH12.Visible = False

            Label27.Visible = True
            Label28.Visible = True
            Label29.Visible = True
            Label30.Visible = False
            Label31.Visible = False
            Label32.Visible = False
            Label33.Visible = False
            Label34.Visible = False
            GpC9.Visible = False
            GpC10.Visible = False
            GpC11.Visible = False
            GpC12.Visible = False

            'Grade point textbox
            Label23.Visible = True
            Label16.Visible = True
            Label17.Visible = True
            Label18.Visible = False
            Label19.Visible = False
            Label20.Visible = False
            Label21.Visible = False
            Label22.Visible = False
            Gp9.Visible = False
            Gp10.Visible = False
            Gp11.Visible = False
            Gp12.Visible = False
        ElseIf ComboBox2.SelectedIndex = 4 Then
            Input1.Visible = True
            Input2.Visible = True
            Input3.Visible = True
            Input4.Visible = True
            Input5.Visible = False
            Input6.Visible = False
            Input7.Visible = False
            Input8.Visible = False
            Input9.Visible = False
            Input10.Visible = False
            Input11.Visible = False
            Input12.Visible = False

            TextBox18.Visible = True
            TextBox19.Visible = True
            TextBox20.Visible = True
            TextBox21.Visible = True
            TextBox22.Visible = False
            TextBox23.Visible = False
            TextBox24.Visible = False
            TextBox25.Visible = False
            Grade9.Visible = False
            Grade10.Visible = False
            Grade11.Visible = False
            Grade12.Visible = False

            TextBox10.Visible = True
            TextBox11.Visible = True
            TextBox12.Visible = True
            TextBox13.Visible = True
            TextBox14.Visible = False
            TextBox15.Visible = False
            TextBox16.Visible = False
            TextBox17.Visible = False
            CrH9.Visible = False
            CrH10.Visible = False
            CrH11.Visible = False
            CrH12.Visible = False

            Label27.Visible = True
            Label28.Visible = True
            Label29.Visible = True
            Label30.Visible = True
            Label31.Visible = False
            Label32.Visible = False
            Label33.Visible = False
            Label34.Visible = False
            GpC9.Visible = False
            GpC10.Visible = False
            GpC11.Visible = False
            GpC12.Visible = False

            'Grade point textbox
            Label23.Visible = True
            Label16.Visible = True
            Label17.Visible = True
            Label18.Visible = True
            Label19.Visible = False
            Label20.Visible = False
            Label21.Visible = False
            Label22.Visible = False
            Gp9.Visible = False
            Gp10.Visible = False
            Gp11.Visible = False
            Gp12.Visible = False
        ElseIf ComboBox2.SelectedIndex = 5 Then
            Input1.Visible = True
            Input2.Visible = True
            Input3.Visible = True
            Input4.Visible = True
            Input5.Visible = True
            Input6.Visible = False
            Input7.Visible = False
            Input8.Visible = False
            Input9.Visible = False
            Input10.Visible = False
            Input11.Visible = False
            Input12.Visible = False

            TextBox18.Visible = True
            TextBox19.Visible = True
            TextBox20.Visible = True
            TextBox21.Visible = True
            TextBox22.Visible = True
            TextBox23.Visible = False
            TextBox24.Visible = False
            TextBox25.Visible = False
            Grade9.Visible = False
            Grade10.Visible = False
            Grade11.Visible = False
            Grade12.Visible = False

            TextBox10.Visible = True
            TextBox11.Visible = True
            TextBox12.Visible = True
            TextBox13.Visible = True
            TextBox14.Visible = True
            TextBox15.Visible = False
            TextBox16.Visible = False
            TextBox17.Visible = False
            CrH9.Visible = False
            CrH10.Visible = False
            CrH11.Visible = False
            CrH12.Visible = False

            Label27.Visible = True
            Label28.Visible = True
            Label29.Visible = True
            Label30.Visible = True
            Label31.Visible = True
            Label32.Visible = False
            Label33.Visible = False
            Label34.Visible = False
            GpC9.Visible = False
            GpC10.Visible = False
            GpC11.Visible = False
            GpC12.Visible = False

            'Grade point textbox
            Label23.Visible = True
            Label16.Visible = True
            Label17.Visible = True
            Label18.Visible = True
            Label19.Visible = True
            Label20.Visible = False
            Label21.Visible = False
            Label22.Visible = False
            Gp9.Visible = False
            Gp10.Visible = False
            Gp11.Visible = False
            Gp12.Visible = False
        ElseIf ComboBox2.SelectedIndex = 6 Then
            Input1.Visible = True
            Input2.Visible = True
            Input3.Visible = True
            Input4.Visible = True
            Input5.Visible = True
            Input6.Visible = True
            Input7.Visible = False
            Input8.Visible = False
            Input9.Visible = False
            Input10.Visible = False
            Input11.Visible = False
            Input12.Visible = False

            TextBox18.Visible = True
            TextBox19.Visible = True
            TextBox20.Visible = True
            TextBox21.Visible = True
            TextBox22.Visible = True
            TextBox23.Visible = True
            TextBox24.Visible = False
            TextBox25.Visible = False
            Grade9.Visible = True
            Grade10.Visible = False
            Grade11.Visible = False
            Grade12.Visible = False

            TextBox10.Visible = True
            TextBox11.Visible = True
            TextBox12.Visible = True
            TextBox13.Visible = True
            TextBox14.Visible = True
            TextBox15.Visible = True
            TextBox16.Visible = False
            TextBox17.Visible = False
            CrH9.Visible = False
            CrH10.Visible = False
            CrH11.Visible = False
            CrH12.Visible = False

            Label27.Visible = True
            Label28.Visible = True
            Label29.Visible = True
            Label30.Visible = True
            Label31.Visible = True
            Label32.Visible = True
            Label33.Visible = False
            Label34.Visible = False
            GpC9.Visible = False
            GpC10.Visible = False
            GpC11.Visible = False
            GpC12.Visible = False

            'Grade point textbox
            Label23.Visible = True
            Label16.Visible = True
            Label17.Visible = True
            Label18.Visible = True
            Label19.Visible = True
            Label20.Visible = True
            Label21.Visible = False
            Label22.Visible = False
            Gp9.Visible = False
            Gp10.Visible = False
            Gp11.Visible = False
            Gp12.Visible = False
        ElseIf ComboBox2.SelectedIndex = 7 Then
            Input1.Visible = True
            Input2.Visible = True
            Input3.Visible = True
            Input4.Visible = True
            Input5.Visible = True
            Input6.Visible = True
            Input7.Visible = True
            Input8.Visible = False
            Input9.Visible = False
            Input10.Visible = False
            Input11.Visible = False
            Input12.Visible = False

            TextBox18.Visible = True
            TextBox19.Visible = True
            TextBox20.Visible = True
            TextBox21.Visible = True
            TextBox22.Visible = True
            TextBox23.Visible = True
            TextBox24.Visible = True
            TextBox25.Visible = False
            Grade9.Visible = False
            Grade10.Visible = False
            Grade11.Visible = False
            Grade12.Visible = False

            TextBox10.Visible = True
            TextBox11.Visible = True
            TextBox12.Visible = True
            TextBox13.Visible = True
            TextBox14.Visible = True
            TextBox15.Visible = True
            TextBox16.Visible = True
            TextBox17.Visible = False
            CrH9.Visible = False
            CrH10.Visible = False
            CrH11.Visible = False
            CrH12.Visible = False

            Label27.Visible = True
            Label28.Visible = True
            Label29.Visible = True
            Label30.Visible = True
            Label31.Visible = True
            Label32.Visible = True
            Label33.Visible = True
            Label34.Visible = False
            GpC9.Visible = False
            GpC10.Visible = False
            GpC11.Visible = False
            GpC12.Visible = False

            'Grade point textbox
            Label23.Visible = True
            Label16.Visible = True
            Label17.Visible = True
            Label18.Visible = True
            Label19.Visible = True
            Label20.Visible = True
            Label21.Visible = True
            Label22.Visible = False
            Gp9.Visible = False
            Gp10.Visible = False
            Gp11.Visible = False
            Gp12.Visible = False
        ElseIf ComboBox2.SelectedIndex = 8 Then
            Input1.Visible = True
            Input2.Visible = True
            Input3.Visible = True
            Input4.Visible = True
            Input5.Visible = True
            Input6.Visible = True
            Input7.Visible = True
            Input8.Visible = True
            Input9.Visible = False
            Input10.Visible = False
            Input11.Visible = False
            Input12.Visible = False

            TextBox18.Visible = True
            TextBox19.Visible = True
            TextBox20.Visible = True
            TextBox21.Visible = True
            TextBox22.Visible = True
            TextBox23.Visible = True
            TextBox24.Visible = True
            TextBox25.Visible = True
            Grade9.Visible = False
            Grade10.Visible = False
            Grade11.Visible = False
            Grade12.Visible = False

            TextBox10.Visible = True
            TextBox11.Visible = True
            TextBox12.Visible = True
            TextBox13.Visible = True
            TextBox14.Visible = True
            TextBox15.Visible = True
            TextBox16.Visible = True
            TextBox17.Visible = True
            CrH9.Visible = False
            CrH10.Visible = False
            CrH11.Visible = False
            CrH12.Visible = False

            Label27.Visible = True
            Label28.Visible = True
            Label29.Visible = True
            Label30.Visible = True
            Label31.Visible = True
            Label32.Visible = True
            Label33.Visible = True
            Label34.Visible = True
            GpC9.Visible = False
            GpC10.Visible = False
            GpC11.Visible = False
            GpC12.Visible = False

            'Grade point textbox
            Label23.Visible = True
            Label16.Visible = True
            Label17.Visible = True
            Label18.Visible = True
            Label19.Visible = True
            Label20.Visible = True
            Label21.Visible = True
            Label22.Visible = True
            Gp9.Visible = False
            Gp10.Visible = False
            Gp11.Visible = False
            Gp12.Visible = False
        ElseIf ComboBox2.SelectedIndex = 9 Then
            Input1.Visible = True
            Input2.Visible = True
            Input3.Visible = True
            Input4.Visible = True
            Input5.Visible = True
            Input6.Visible = True
            Input7.Visible = True
            Input8.Visible = True
            Input9.Visible = True
            Input10.Visible = False
            Input11.Visible = False
            Input12.Visible = False

            TextBox18.Visible = True
            TextBox19.Visible = True
            TextBox20.Visible = True
            TextBox21.Visible = True
            TextBox22.Visible = True
            TextBox23.Visible = True
            TextBox24.Visible = True
            TextBox25.Visible = True
            Grade9.Visible = True
            Grade10.Visible = False
            Grade11.Visible = False
            Grade12.Visible = False

            TextBox10.Visible = True
            TextBox11.Visible = True
            TextBox12.Visible = True
            TextBox13.Visible = True
            TextBox14.Visible = True
            TextBox15.Visible = True
            TextBox16.Visible = True
            TextBox17.Visible = True
            CrH9.Visible = True
            CrH10.Visible = False
            CrH11.Visible = False
            CrH12.Visible = False

            Label27.Visible = True
            Label28.Visible = True
            Label29.Visible = True
            Label30.Visible = True
            Label31.Visible = True
            Label32.Visible = True
            Label33.Visible = True
            Label34.Visible = True
            GpC9.Visible = True
            GpC10.Visible = False
            GpC11.Visible = False
            GpC12.Visible = False


            'Grade point textbox
            Label23.Visible = True
            Label16.Visible = True
            Label17.Visible = True
            Label18.Visible = True
            Label19.Visible = True
            Label20.Visible = True
            Label21.Visible = True
            Label22.Visible = True
            Gp9.Visible = True
            Gp10.Visible = False
            Gp11.Visible = False
            Gp12.Visible = False
        ElseIf ComboBox2.SelectedIndex = 10 Then
            Input1.Visible = True
            Input2.Visible = True
            Input3.Visible = True
            Input4.Visible = True
            Input5.Visible = True
            Input6.Visible = True
            Input7.Visible = True
            Input8.Visible = True
            Input9.Visible = True
            Input10.Visible = True
            Input11.Visible = False
            Input12.Visible = False

            TextBox18.Visible = True
            TextBox19.Visible = True
            TextBox20.Visible = True
            TextBox21.Visible = True
            TextBox22.Visible = True
            TextBox23.Visible = True
            TextBox24.Visible = True
            TextBox25.Visible = True
            Grade9.Visible = True
            Grade10.Visible = True
            Grade11.Visible = False
            Grade12.Visible = False

            TextBox10.Visible = True
            TextBox11.Visible = True
            TextBox12.Visible = True
            TextBox13.Visible = True
            TextBox14.Visible = True
            TextBox15.Visible = True
            TextBox16.Visible = True
            TextBox17.Visible = True
            CrH9.Visible = True
            CrH10.Visible = True
            CrH11.Visible = False
            CrH12.Visible = False

            Label27.Visible = True
            Label28.Visible = True
            Label29.Visible = True
            Label30.Visible = True
            Label31.Visible = True
            Label32.Visible = True
            Label33.Visible = True
            Label34.Visible = True
            GpC9.Visible = True
            GpC10.Visible = True
            GpC11.Visible = False
            GpC12.Visible = False


            'Grade point textbox
            Label23.Visible = True
            Label16.Visible = True
            Label17.Visible = True
            Label18.Visible = True
            Label19.Visible = True
            Label20.Visible = True
            Label21.Visible = True
            Label22.Visible = True
            Gp9.Visible = True
            Gp10.Visible = True
            Gp11.Visible = False
            Gp12.Visible = False
        ElseIf ComboBox2.SelectedIndex = 11 Then
            Input1.Visible = True
            Input2.Visible = True
            Input3.Visible = True
            Input4.Visible = True
            Input5.Visible = True
            Input6.Visible = True
            Input7.Visible = True
            Input8.Visible = True
            Input9.Visible = True
            Input10.Visible = True
            Input11.Visible = True
            Input12.Visible = False

            TextBox18.Visible = True
            TextBox19.Visible = True
            TextBox20.Visible = True
            TextBox21.Visible = True
            TextBox22.Visible = True
            TextBox23.Visible = True
            TextBox24.Visible = True
            TextBox25.Visible = True
            Grade9.Visible = True
            Grade10.Visible = True
            Grade11.Visible = True
            Grade12.Visible = False

            TextBox10.Visible = True
            TextBox11.Visible = True
            TextBox12.Visible = True
            TextBox13.Visible = True
            TextBox14.Visible = True
            TextBox15.Visible = True
            TextBox16.Visible = True
            TextBox17.Visible = True
            CrH9.Visible = True
            CrH10.Visible = True
            CrH11.Visible = True
            CrH12.Visible = False

            Label27.Visible = True
            Label28.Visible = True
            Label29.Visible = True
            Label30.Visible = True
            Label31.Visible = True
            Label32.Visible = True
            Label33.Visible = True
            Label34.Visible = True
            GpC9.Visible = True
            GpC10.Visible = True
            GpC11.Visible = True
            GpC12.Visible = False

            'Grade point textbox
            Label23.Visible = True
            Label16.Visible = True
            Label17.Visible = True
            Label18.Visible = True
            Label19.Visible = True
            Label20.Visible = True
            Label21.Visible = True
            Label22.Visible = True
            Gp9.Visible = True
            Gp10.Visible = True
            Gp11.Visible = True
            Gp12.Visible = False
        ElseIf ComboBox2.SelectedIndex = 12 Then
            Input1.Visible = True
            Input2.Visible = True
            Input3.Visible = True
            Input4.Visible = True
            Input5.Visible = True
            Input6.Visible = True
            Input7.Visible = True
            Input8.Visible = True
            Input9.Visible = True
            Input10.Visible = True
            Input11.Visible = True
            Input12.Visible = True

            TextBox18.Visible = True
            TextBox19.Visible = True
            TextBox20.Visible = True
            TextBox21.Visible = True
            TextBox22.Visible = True
            TextBox23.Visible = True
            TextBox24.Visible = True
            TextBox25.Visible = True
            Grade9.Visible = True
            Grade10.Visible = True
            Grade11.Visible = True
            Grade12.Visible = True

            TextBox10.Visible = True
            TextBox11.Visible = True
            TextBox12.Visible = True
            TextBox13.Visible = True
            TextBox14.Visible = True
            TextBox15.Visible = True
            TextBox16.Visible = True
            TextBox17.Visible = True
            CrH9.Visible = True
            CrH10.Visible = True
            CrH11.Visible = True
            CrH12.Visible = True

            Label27.Visible = True
            Label28.Visible = True
            Label29.Visible = True
            Label30.Visible = True
            Label31.Visible = True
            Label32.Visible = True
            Label33.Visible = True
            Label34.Visible = True
            GpC9.Visible = True
            GpC10.Visible = True
            GpC11.Visible = True
            GpC12.Visible = True

            'Grade point textbox
            Label23.Visible = True
            Label16.Visible = True
            Label17.Visible = True
            Label18.Visible = True
            Label19.Visible = True
            Label20.Visible = True
            Label21.Visible = True
            Label22.Visible = True
            Gp9.Visible = True
            Gp10.Visible = True
            Gp11.Visible = True
            Gp12.Visible = True
        End If
    End Sub
    Sub Empty()
        class_Obtained.Text = " "
        Gross_gpa.Text = ""
        gpa.Text = ""
        total_CreditHour.Text = ""
        Label27.Text = ""
        Label28.Text = ""
        Label29.Text = ""
        Label30.Text = ""
        Label31.Text = ""
        Label32.Text = ""
        Label33.Text = ""
        Label34.Text = ""
        Label16.Text = ""
        Label17.Text = ""
        Label18.Text = ""
        Label19.Text = ""
        Label20.Text = ""
        Label21.Text = ""
        Label22.Text = ""
        Label23.Text = ""

        ResitList.SelectedIndex = 0
        TextBox18.SelectedIndex = 0
        TextBox19.SelectedIndex = 0
        TextBox20.SelectedIndex = 0
        TextBox21.SelectedIndex = 0
        TextBox22.SelectedIndex = 0
        TextBox23.SelectedIndex = 0
        TextBox24.SelectedIndex = 0
        TextBox25.SelectedIndex = 0
        TextBox10.SelectedIndex = 0
        TextBox11.SelectedIndex = 0
        TextBox12.SelectedIndex = 0
        TextBox13.SelectedIndex = 0
        TextBox14.SelectedIndex = 0
        TextBox15.SelectedIndex = 0
        TextBox16.SelectedIndex = 0
        TextBox17.SelectedIndex = 0
        TextBox18.SelectedIndex = 0
        Input1.Text = ""
        Input2.Text = ""
        Input3.Text = ""
        Input4.Text = ""
        Input5.Text = ""
        Input6.Text = ""
        Input7.Text = ""
        Input8.Text = ""
        resit.Text = ""
        Input9.Text = ""
        Input10.Text = ""
        Input11.Text = ""
        Input12.Text = ""
        Grade9.Text = ""
        Grade10.Text = ""
        Grade11.Text = ""
        Grade12.Text = ""
        CrH9.Text = ""
        CrH10.Text = ""
        CrH11.Text = ""
        CrH12.Text = ""
        GpC9.Text = ""
        GpC10.Text = ""
        GpC11.Text = ""
        GpC12.Text = ""
        Gp9.Text = ""
        Gp10.Text = ""
        Gp11.Text = ""
        Gp12.Text = ""
        ComboBox2.SelectedIndex = 0
    End Sub

    Sub mulpGrad()
        Label27.Text = Val(TextBox10.Text) * Val(Label23.Text)
        Label28.Text = Val(TextBox11.Text) * Val(Label16.Text)
        Label29.Text = Val(TextBox12.Text) * Val(Label17.Text)
        Label30.Text = Val(TextBox13.Text) * Val(Label18.Text)
        Label31.Text = Val(TextBox14.Text) * Val(Label19.Text)
        Label32.Text = Val(TextBox15.Text) * Val(Label20.Text)
        Label33.Text = Val(TextBox16.Text) * Val(Label21.Text)
        Label34.Text = Val(TextBox17.Text) * Val(Label22.Text)
        GpC9.Text = Val(CrH9.Text) * Val(Gp9.Text)
        GpC10.Text = Val(CrH10.Text) * Val(Gp10.Text)
        GpC11.Text = Val(CrH11.Text) * Val(Gp11.Text)
        GpC12.Text = Val(CrH12.Text) * Val(Gp12.Text)
    End Sub

    Private Sub bbckground()
        Me.WindowState = FormWindowState.Normal
        Me.ResitList.Items.Add("-----Resit Courses----")
        If Me.ResitList.SelectedItem = "" Then
            Me.ResitList.SelectedIndex = 0
        End If

        ComboBox2.SelectedIndex = 0
        Me.Width = 848
        Me.Height = 248
        Me.GroupBox1.Width = 829
        Me.GroupBox1.Height = 195

        'course name textbox
        Input1.Visible = False
        Input2.Visible = False
        Input3.Visible = False
        Input4.Visible = False
        Input5.Visible = False
        Input6.Visible = False
        Input7.Visible = False
        Input8.Visible = False
        Input9.Visible = False
        Input10.Visible = False
        Input11.Visible = False
        Input12.Visible = False

        'Grade box
        TextBox18.Visible = False
        TextBox19.Visible = False
        TextBox20.Visible = False
        TextBox21.Visible = False
        TextBox22.Visible = False
        TextBox23.Visible = False
        TextBox24.Visible = False
        TextBox25.Visible = False
        Grade9.Visible = False
        Grade10.Visible = False
        Grade11.Visible = False
        Grade12.Visible = False

        'credit hour box
        TextBox10.Visible = False
        TextBox11.Visible = False
        TextBox12.Visible = False
        TextBox13.Visible = False
        TextBox14.Visible = False
        TextBox15.Visible = False
        TextBox16.Visible = False
        TextBox17.Visible = False
        CrH9.Visible = False
        CrH10.Visible = False
        CrH11.Visible = False
        CrH12.Visible = False

        'G*C textbox
        Label27.Visible = False
        Label28.Visible = False
        Label29.Visible = False
        Label30.Visible = False
        Label31.Visible = False
        Label32.Visible = False
        Label33.Visible = False
        Label34.Visible = False
        GpC9.Visible = False
        GpC10.Visible = False
        GpC11.Visible = False
        GpC12.Visible = False

        'Grade point textbox
        Label23.Visible = False
        Label16.Visible = False
        Label17.Visible = False
        Label18.Visible = False
        Label19.Visible = False
        Label20.Visible = False
        Label21.Visible = False
        Label22.Visible = False
        Gp9.Visible = False
        Gp10.Visible = False
        Gp11.Visible = False
        Gp12.Visible = False
    End Sub


    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        Graddes()

        resit.Text = ref1 + ref2 + ref3 + ref4 + ref5 + ref6 + ref7 + ref8 + ref9 + ref10 + ref11 + ref12
        'Total credit hour'
        total_CreditHour.Text = TotalCredit()

        'Multiplying grade point by creditHour'

        mulpGrad()


        Gross_gpa.Text = GPmuCR()
        Dim all As Double
        all = GPmuCR() / TotalCredit()
        gpa.Text = all.ToString("N2")
        'GPmuCR() / TotalCredit()'


        'Class Obtabined'
        ClassObtained()
        gpa6 = gpa.Text
        crH6 = total_CreditHour.Text

    End Sub

    Private Sub Graddes()
        'Grade points'
        If (TextBox18.Text = "A+") Then
            Label23.Text = "5.0"
        ElseIf (TextBox18.Text = "A") Then
            Label23.Text = "4.5"
        ElseIf (TextBox18.Text = "B+") Then
            Label23.Text = "4.0"
        ElseIf (TextBox18.Text = "B") Then
            Label23.Text = "3.5"
        ElseIf (TextBox18.Text = "C+") Then
            Label23.Text = "3.0"
        ElseIf (TextBox18.Text = "C") Then
            Label23.Text = "2.5"
        ElseIf (TextBox18.Text = "D+") Then
            Label23.Text = "2.0"
        ElseIf (TextBox18.Text = "D") Then
            Label23.Text = "1.5"
        ElseIf (TextBox18.Text = "F") Then
            Label23.Text = "1.0"
            If TextBox18.Text = "F" Then
                ref1 = 1
                ResitList.Items.Add(Input1.Text)
            Else
                ref1 = 0
            End If
        Else
            Label23.Text = " "
        End If

        If (TextBox19.Text = "A+") Then
            Label16.Text = "5.0"
        ElseIf (TextBox19.Text = "A") Then
            Label16.Text = "4.5"
        ElseIf (TextBox19.Text = "B+") Then
            Label16.Text = "4.0"
        ElseIf (TextBox19.Text = "B") Then
            Label16.Text = "3.5"
        ElseIf (TextBox19.Text = "C+") Then
            Label16.Text = "3.0"
        ElseIf (TextBox19.Text = "C") Then
            Label16.Text = "2.5"
        ElseIf (TextBox19.Text = "D+") Then
            Label16.Text = "2.0"
        ElseIf (TextBox19.Text = "D") Then
            Label16.Text = "1.5"
        ElseIf (TextBox19.Text = "F") Then
            Label16.Text = "1.0"
            If TextBox19.Text = "F" Then
                ref2 = 1
                ResitList.Items.Add(Input2.Text)
            Else
                ref2 = 0
            End If
        Else
            Label16.Text = " "
        End If

        If (TextBox20.Text = "A+") Then
            Label17.Text = "5.0"
        ElseIf (TextBox20.Text = "A") Then
            Label17.Text = "4.5"
        ElseIf (TextBox20.Text = "B+") Then
            Label17.Text = "4.0"
        ElseIf (TextBox20.Text = "B") Then
            Label17.Text = "3.5"
        ElseIf (TextBox20.Text = "C+") Then
            Label17.Text = "3.0"
        ElseIf (TextBox20.Text = "C") Then
            Label17.Text = "2.5"
        ElseIf (TextBox20.Text = "D+") Then
            Label17.Text = "2.0"
        ElseIf (TextBox20.Text = "D") Then
            Label17.Text = "1.5"
        ElseIf (TextBox20.Text = "F") Then
            Label17.Text = "1.0"
            If TextBox20.Text = "F" Then
                ref3 = 1
                ResitList.Items.Add(Input3.Text)
            Else
                ref3 = 0
            End If
        Else
            Label17.Text = " "
        End If

        If (TextBox21.Text = "A+") Then
            Label18.Text = "5.0"
        ElseIf (TextBox21.Text = "A") Then
            Label18.Text = "4.5"
        ElseIf (TextBox21.Text = "B+") Then
            Label18.Text = "4.0"
        ElseIf (TextBox21.Text = "B") Then
            Label18.Text = "3.5"
        ElseIf (TextBox21.Text = "C+") Then
            Label18.Text = "3.0"
        ElseIf (TextBox21.Text = "C") Then
            Label18.Text = "2.5"
        ElseIf (TextBox21.Text = "D+") Then
            Label18.Text = "2.0"
        ElseIf (TextBox21.Text = "D") Then
            Label18.Text = "1.5"
        ElseIf (TextBox21.Text = "F") Then
            Label18.Text = "1.0"
            If TextBox21.Text = "F" Then
                ref4 = 1
                ResitList.Items.Add(Input4.Text)
            Else
                ref4 = 0
            End If
        Else
            Label18.Text = " "
        End If

        If (TextBox22.Text = "A+") Then
            Label19.Text = "5.0"
        ElseIf (TextBox22.Text = "A") Then
            Label19.Text = "4.5"
        ElseIf (TextBox22.Text = "B+") Then
            Label19.Text = "4.0"
        ElseIf (TextBox22.Text = "B") Then
            Label19.Text = "3.5"
        ElseIf (TextBox22.Text = "C+") Then
            Label19.Text = "3.0"
        ElseIf (TextBox22.Text = "C") Then
            Label19.Text = "2.5"
        ElseIf (TextBox22.Text = "D+") Then
            Label19.Text = "2.0"
        ElseIf (TextBox22.Text = "D") Then
            Label19.Text = "1.5"
        ElseIf (TextBox22.Text = "F") Then
            Label19.Text = "1.0"
            If TextBox22.Text = "F" Then
                ref5 = 1
                ResitList.Items.Add(Input5.Text)
            Else
                ref5 = 0
            End If
        Else
            Label19.Text = " "
        End If

        If (TextBox23.Text = "A+") Then
            Label20.Text = "5.0"
        ElseIf (TextBox23.Text = "A") Then
            Label20.Text = "4.5"
        ElseIf (TextBox23.Text = "B+") Then
            Label20.Text = "4.0"
        ElseIf (TextBox23.Text = "B") Then
            Label20.Text = "3.5"
        ElseIf (TextBox23.Text = "C+") Then
            Label20.Text = "3.0"
        ElseIf (TextBox23.Text = "C") Then
            Label20.Text = "2.5"
        ElseIf (TextBox23.Text = "D+") Then
            Label20.Text = "2.0"
        ElseIf (TextBox23.Text = "D") Then
            Label20.Text = "1.5"
        ElseIf (TextBox23.Text = "F") Then
            Label20.Text = "1.0"
            If TextBox23.Text = "F" Then
                ref6 = 1
                ResitList.Items.Add(Input7.Text)
            Else
                ref8 = 0
            End If
        Else
            Label20.Text = " "
        End If

        If (TextBox24.Text = "A+") Then
            Label21.Text = "5.0"
        ElseIf (TextBox24.Text = "A") Then
            Label21.Text = "4.5"
        ElseIf (TextBox24.Text = "B+") Then
            Label21.Text = "4.0"
        ElseIf (TextBox24.Text = "B") Then
            Label21.Text = "3.5"
        ElseIf (TextBox24.Text = "C+") Then
            Label21.Text = "3.0"
        ElseIf (TextBox24.Text = "C") Then
            Label21.Text = "2.5"
        ElseIf (TextBox24.Text = "D+") Then
            Label21.Text = "2.0"
        ElseIf (TextBox24.Text = "D") Then
            Label21.Text = "1.5"
        ElseIf (TextBox24.Text = "F") Then
            Label21.Text = "1.0"
            If TextBox24.Text = "F" Then
                ref7 = 1
                ResitList.Items.Add(Input7.Text)
            Else
                ref7 = 0
            End If
        Else
            Label21.Text = " "
        End If

        If (TextBox25.Text = "A+") Then
            Label22.Text = "5.0"
        ElseIf (TextBox25.Text = "A") Then
            Label22.Text = "4.5"
        ElseIf (TextBox25.Text = "B+") Then
            Label22.Text = "4.0"
        ElseIf (TextBox25.Text = "B") Then
            Label22.Text = "3.5"
        ElseIf (TextBox25.Text = "C+") Then
            Label22.Text = "3.0"
        ElseIf (TextBox25.Text = "C") Then
            Label22.Text = "2.5"
        ElseIf (TextBox25.Text = "D+") Then
            Label22.Text = "2.0"
        ElseIf (TextBox25.Text = "D") Then
            Label22.Text = "1.5"
        ElseIf (TextBox25.Text = "F") Then
            Label22.Text = "1.0"
            If TextBox25.Text = "F" Then
                ref8 = 1
                ResitList.Items.Add(Input8.Text)
            Else
                ref8 = 0
            End If
        Else
            Label22.Text = " "
        End If
        '9th
        If (Grade9.Text = "A+") Then
            Gp9.Text = "5.0"
        ElseIf (Grade9.Text = "A") Then
            Gp9.Text = "4.5"
        ElseIf (Grade9.Text = "B+") Then
            Gp9.Text = "4.0"
        ElseIf (Grade9.Text = "B") Then
            Gp9.Text = "3.5"
        ElseIf (Grade9.Text = "C+") Then
            Gp9.Text = "3.0"
        ElseIf (Grade9.Text = "C") Then
            Gp9.Text = "2.5"
        ElseIf (Grade9.Text = "D+") Then
            Gp9.Text = "2.0"
        ElseIf (Grade9.Text = "D") Then
            Gp9.Text = "1.5"
        ElseIf (Grade9.Text = "F") Then
            Gp9.Text = "1.0"
            If Grade9.Text = "F" Then
                ref9 = 1
                ResitList.Items.Add(Input9.Text)
            Else
                ref9 = 0
            End If
        Else
            Gp9.Text = " "
        End If

        If (Grade10.Text = "A+") Then
            Gp10.Text = "5.0"
        ElseIf (Grade10.Text = "A") Then
            Gp10.Text = "4.5"
        ElseIf (Grade10.Text = "B+") Then
            Gp10.Text = "4.0"
        ElseIf (Grade10.Text = "B") Then
            Gp10.Text = "3.5"
        ElseIf (Grade10.Text = "C+") Then
            Gp10.Text = "3.0"
        ElseIf (Grade10.Text = "C") Then
            Gp10.Text = "2.5"
        ElseIf (Grade10.Text = "D+") Then
            Gp10.Text = "2.0"
        ElseIf (Grade10.Text = "D") Then
            Gp10.Text = "1.5"
        ElseIf (Grade10.Text = "F") Then
            Gp10.Text = "1.0"
            If Grade10.Text = "F" Then
                ref10 = 1
                ResitList.Items.Add(Input10.Text)
            Else
                ref10 = 0
            End If
        Else
            Gp10.Text = " "
        End If


        If (Grade11.Text = "A+") Then
            Gp11.Text = "5.0"
        ElseIf (Grade11.Text = "A") Then
            Gp11.Text = "4.5"
        ElseIf (Grade11.Text = "B+") Then
            Gp11.Text = "4.0"
        ElseIf (Grade11.Text = "B") Then
            Gp11.Text = "3.5"
        ElseIf (Grade11.Text = "C+") Then
            Gp11.Text = "3.0"
        ElseIf (Grade11.Text = "C") Then
            Gp11.Text = "2.5"
        ElseIf (Grade11.Text = "D+") Then
            Gp11.Text = "2.0"
        ElseIf (Grade11.Text = "D") Then
            Gp11.Text = "1.5"
        ElseIf (Grade11.Text = "F") Then
            Gp11.Text = "1.0"
            If Grade11.Text = "F" Then
                ref11 = 1
                ResitList.Items.Add(Input11.Text)
            Else
                ref11 = 0
            End If
        Else
            Gp11.Text = " "
        End If

        If (Grade12.Text = "A+") Then
            Gp12.Text = "5.0"
        ElseIf (Grade12.Text = "A") Then
            Gp12.Text = "4.5"
        ElseIf (Grade12.Text = "B+") Then
            Gp12.Text = "4.0"
        ElseIf (Grade12.Text = "B") Then
            Gp12.Text = "3.5"
        ElseIf (Grade12.Text = "C+") Then
            Gp12.Text = "3.0"
        ElseIf (Grade12.Text = "C") Then
            Gp12.Text = "2.5"
        ElseIf (Grade12.Text = "D+") Then
            Gp12.Text = "2.0"
        ElseIf (Grade12.Text = "D") Then
            Gp12.Text = "1.5"
        ElseIf (Grade12.Text = "F") Then
            Gp12.Text = "1.0"
            If Grade12.Text = "F" Then
                ref12 = 1
                ResitList.Items.Add(Input12.Text)
            Else
                ref11 = 0
            End If
        Else
            Gp11.Text = " "
        End If
    End Sub
    Sub ClassObtained()

        If (Val(gpa.Text) >= 4.0 And Val(gpa.Text) <= 5.0) Then
            class_Obtained.Text = "1ST CLASS"
        ElseIf (Val(gpa.Text) >= 3.0 And Val(gpa.Text) < 4.0) Then
            class_Obtained.Text = "2ND CLASS UPPER"
        ElseIf (Val(gpa.Text) >= 2.0 And Val(gpa.Text) < 3.0) Then
            class_Obtained.Text = "2ND CLASS LOWER"
        ElseIf (Val(gpa.Text) >= 1.0 And Val(gpa.Text) < 2.0) Then
            class_Obtained.Text = "3RD CLASS"
        ElseIf (Val(gpa.Text) >= 0 And Val(gpa.Text) < 1.0) Then
            class_Obtained.Text = "PASS"

        End If


    End Sub

    Private Function GPmuCR() As Double
        Dim CrHGp As Double
        CrHGp = Val(Label27.Text) + Val(Label28.Text) + Val(Label29.Text) + Val(Label30.Text) + Val(Label31.Text) + Val(Label32.Text) + Val(Label33.Text) + Val(Label34.Text) + Val(GpC9.Text) + Val(GpC10.Text) + Val(GpC11.Text) + Val(GpC12.Text)
        Return CrHGp
    End Function

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Dim L300_1 As New Level300_1
        Me.WindowState = FormWindowState.Minimized

        L300_1.Show()
    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        Empty()
    End Sub

    Private Sub go_back_Click(sender As Object, e As EventArgs) Handles go_back.Click
        Application.Exit()
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub minimize_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim final As New Over
        Me.Hide()
        final.Show()

    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Me.Close()
    End Sub
End Class