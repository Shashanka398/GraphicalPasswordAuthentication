Public Class Form1
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Me.Hide()

        frmLogin.Show()

    End Sub

    Private Sub btnsignup_Click(sender As Object, e As EventArgs) Handles btnsignup.Click
        Me.Hide()

        frmsignup.Show()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Form5.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) 
        verifyimg.Show()
        Me.Hide()
    End Sub
End Class
