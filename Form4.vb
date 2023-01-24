Imports System.Data.SqlClient
Public Class Form4
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Public pass As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        myConn = New SqlConnection("Initial Catalog=logindetails;" & "Data Source=LAPTOP-N2T5OL68\SQLEXPRESS;Integrated Security=SSPI;")
        myCmd = myConn.CreateCommand
        Try
            myCmd.CommandText = "update logindetails set password='" & pass & "' where Email='" & txtuserid.Text & "'"
            myConn.Open()
            myCmd.ExecuteNonQuery()
        Catch except As Exception
            MsgBox("not inserted")
        End Try
        pass = String.Empty
        frmLogin.Show()
        Me.Hide()
    End Sub

    Private Sub btnred_Click(sender As Object, e As EventArgs) Handles btnred.Click
        pass = pass + "r"
    End Sub

    Private Sub btnblue_Click(sender As Object, e As EventArgs) Handles btnblue.Click
        pass = pass + "b"
    End Sub

    Private Sub btngreen_Click(sender As Object, e As EventArgs) Handles btngreen.Click
        pass = pass + "g"
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnred.Hide()
        btnindigo.Hide()
        btnblue.Hide()
        btnorange.Hide()
        btngreen.Hide()
        btnyellow.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If (cmbsel.Text = "Red") Then
            btnred.Show()

        End If
        If (cmbsel.Text = "Green") Then
            btngreen.Show()

        End If
        If (cmbsel.Text = "Blue") Then
            btnblue.Show()

        End If
        If (cmbsel.Text = "Orange") Then
            btnorange.Show()

        End If

        If (cmbsel.Text = "Indigo") Then
            btnindigo.Show()

        End If
        If (cmbsel.Text = "Yellow") Then
            btnyellow.Show()

        End If
    End Sub

    Private Sub btnorange_Click(sender As Object, e As EventArgs) Handles btnorange.Click
        pass = pass + "o"
    End Sub

    Private Sub btnindigo_Click(sender As Object, e As EventArgs) Handles btnindigo.Click
        pass = pass + "i"
    End Sub

    Private Sub btnyellow_Click(sender As Object, e As EventArgs) Handles btnyellow.Click
        pass = pass + "y"
    End Sub
End Class