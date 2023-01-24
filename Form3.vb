Imports System.Data.SqlClient

Public Class frmsignup
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Public pass As String
    Public email As String

    Dim obj As New verifyimg
    Private Sub frmsignup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblpass.Hide()
        btnblue.Hide()
        btngreen.Hide()
        btnred.Hide()

        btnred.Hide()
        btnindigo.Hide()
        btnblue.Hide()
        btnorange.Hide()
        btngreen.Hide()
        btnyellow.Hide()
        cmbsel.Hide()


    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblpass.Click

    End Sub

    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        lblpass.Show()
        cmbsel.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lblpass.Hide()
        btnred.Hide()
        btnindigo.Hide()
        btnblue.Hide()
        btnorange.Hide()
        btngreen.Hide()
        btnyellow.Hide()
        cmbsel.Hide()
        txtfisrt.Text = ""
        txtsecond.Text = ""
        txtemail.Text = ""
        pass = String.Empty
        Form1.Show()

        Me.Hide()

    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        Dim OBJ As New Form5
        OBJ.StringPass = txtemail.Text
        OBJ.Show()


        email = txtemail.Text

        myConn = New SqlConnection("Initial Catalog=logindetails;" & "Data Source=LAPTOP-N2T5OL68\SQLEXPRESS;Integrated Security=SSPI;")
        myCmd = myConn.CreateCommand
        Try
            myCmd.CommandText = "insert into logindetails(FirstName,SecondName,Email,password) values('" & txtfisrt.Text & "','" & txtsecond.Text & "','" & email & "','" & pass & "' )"
            myConn.Open()
            myCmd.ExecuteNonQuery()
            MsgBox("Data inserted sucessfully")

            MsgBox(email)
        Catch except As Exception
            MsgBox("not inserted")
        End Try

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

    Private Sub btnorange_Click(sender As Object, e As EventArgs) Handles btnorange.Click
        pass = pass + "o"
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

    Private Sub btnindigo_Click(sender As Object, e As EventArgs) Handles btnindigo.Click
        pass = pass + "i"
    End Sub

    Private Sub btnyellow_Click(sender As Object, e As EventArgs) Handles btnyellow.Click
        pass = pass + "y"
    End Sub

    Private Sub txtemail_TextChanged(sender As Object, e As EventArgs) Handles txtemail.TextChanged

    End Sub
End Class