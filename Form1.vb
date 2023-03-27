Public Class Form1
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        TextBox1.Text = ""
        TextBox1.Focus()
        lblPayment.Text = ""
        radCheese.Checked = True
        radPinwheel.Checked = False
        radVeggie.Checked = False
        radSausage.Checked = False
        radFruit.Checked = False
        radPre.Checked = True
        radPickup.Checked = False
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decCost As Decimal
        Dim decFinal As Decimal
        Dim cdecDiscount As Decimal = 5D
        Dim decPoints As Decimal
        Dim strOrder As String = ""
        Dim strPay As String = ""
        Dim strPoints As String = ""
        Dim intPoints As Integer
        'Dim isomevar As Integer = Convert.ToInt32(lblPayment.Text)
        If IsNumeric(TextBox1.Text) Then
            intPoints = Convert.ToInt32(TextBox1.Text)
            strPoints = "after discount of " & intPoints.ToString() & " loyalty points."
            'MsgBox(intPoints)

            If radCheese.Checked Then
                decCost = 49.99D
                strOrder = "Cheese"
            ElseIf radPinwheel.Checked Then
                decCost = 59.99D
                strOrder = "Pinwheel"
            ElseIf radVeggie.Checked Then
                decCost = 29.99D
                strOrder = "Veggie"
            ElseIf radSausage.Checked Then
                decCost = 49.99D
                strOrder = "Sausage and Cheese"
            ElseIf radFruit.Checked Then
                decCost = 29.99D
                strOrder = "Fruit"
            End If
            If radPre.Checked Then
                strPay = "Using pre-pay"
            ElseIf radPickup.Checked Then
                strPay = "Paying upon pickup."

            End If



            intPoints = Convert.ToInt32(intPoints / 10I)
            decPoints = (intPoints * cdecDiscount) / 100

            MsgBox(decPoints)

            If decPoints > 1 Then
                decPoints = 1
            End If

            MsgBox(decPoints)

            decFinal = decCost * (1 - decPoints)
            MsgBox(decFinal)

            lblPayment.Text = "Your order " & strOrder & " platter costs " & decFinal.ToString("C") & strPay & strPoints

        Else
            MsgBox("Please enter a valid number of points.", , "Input Error")
            TextBox1.Text = ""

        End If

    End Sub

End Class
