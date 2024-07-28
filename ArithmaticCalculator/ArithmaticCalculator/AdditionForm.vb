Public Class AdditionForm

    Private Sub AddBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddBtn.Click
        Dim sum As Integer
        sum = Val(FirstNoTxt.Text) + Val(SecondNoTxt.Text)
        ResultLbl.Text = "The sum of two nos is " + Str(sum)
    End Sub
    Private Sub SubtractBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubtractBtn.Click
        Dim difference As Integer
        difference = Val(FirstNoTxt.Text) - Val(SecondNoTxt.Text)
        ResultLbl.Text = "The difference of two nos is " + Str(difference)
    End Sub
    Private Sub MultiplyBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MultiplyBtn.Click
        Dim product As Integer
        product = Val(FirstNoTxt.Text) * Val(SecondNoTxt.Text)
        ResultLbl.Text = "The product of two nos is " + Str(product)
    End Sub
    Private Sub DivideBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DivideBtn.Click
        Dim quotient As Integer
        quotient = Val(FirstNoTxt.Text) / Val(SecondNoTxt.Text)
        ResultLbl.Text = "The quotient of two nos is " + Str(quotient)
    End Sub

End Class
