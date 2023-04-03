Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Dim classConvert As Convertfunction = New Convertfunction
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        If (checkError() = True) Then
            Dim convertUppercase As String = classConvert.DoConvert(txtConvert.Text)
            txtConvert.Text = convertUppercase
            classConvert.DoMessageBox()
        End If

    End Sub

    Public Function checkError() As Boolean
        Dim textboxdata As String
        textboxdata = txtConvert.Text
        If textboxdata = "" Then
            MsgBox("Blank text box")
            checkError = False
        Else
            MsgBox("Text box Validated")
            checkError = True
        End If
    End Function

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim first, second, result As Integer

        first = Val(txtNo1.Text)
        second = Val(txtNo2.Text)
        result = classConvert.AddTwoNumbers(first, second)

        If result = 0 Then
            MsgBox("Please try again")
        Else
            txtResult.Text = result
        End If

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Dim checkGender As String = classConvert.checkGender(txtNric.Text)
        lblGender.Text = "Gender : " & checkGender

        Dim checkDob As String = classConvert.checkDob(txtNric.Text)
        lblDob.Text = "Birthday : " & checkDob

        Dim CheckState As String = classConvert.checkState(txtNric.Text)
        lblPob.Text = "State of birth : " & CheckState

    End Sub
End Class
