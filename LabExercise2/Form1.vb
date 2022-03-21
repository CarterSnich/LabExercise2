Public Class Form1

    Private Sub Calculcate(sender As Object, e As EventArgs) Handles SubtractBtn.Click, MultiplicationBtn.Click, DivisionBtn.Click, Button5.Click, AdditionBtn.Click, SupBtn.Click
        Dim EventSource As Button = sender

        If Operator1.Text = "" Or Operator2.Text = "" Then
            MsgBox("Please fill-up all fields.", MsgBoxStyle.OkOnly, "Warning")
            Return
        End If

        Dim Number1 As Double = Val(Operator1.Text)
        Dim Number2 As Double = Val(Operator2.Text)
        Dim Operation As String = EventSource.Text
        Dim Result As Double

        If Operation = "+" Then
            Result = Number1 + Number2
        ElseIf Operation = "-" Then
            Result = Number1 - Number2
        ElseIf Operation = "×" Then
            Result = Number1 * Number2
        ElseIf Operation = "÷" Then
            Result = Number1 / Number2
        ElseIf Operation = "Mod" Then
            Result = Number1 Mod Number2
        ElseIf Operation = "^" Then
            Result = Number1 ^ Number2
        End If

        OperatorLabel.Text = Operation
        ResultBox.Text = Result

    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        Operator1.Text = ""
        Operator2.Text = ""
        OperatorLabel.Text = ""
        ResultBox.Text = ""
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Close()
    End Sub

    Private Sub IgnoredBtn_Click(sender As Object, e As EventArgs) Handles IgnoredBtn.Click
        MessageBox.Show("Ignored.", "Operation", MessageBoxButtons.OK, MessageBoxIcon.None)
    End Sub

End Class
