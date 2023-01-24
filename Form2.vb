Imports System.Data.SqlClient

Public Class frmLogin
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Public pass As String
    Public result As Integer
    Dim arrR As String
    Dim password As String

    Dim emial As New verifyimg



    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtuserid.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btngreen.Click
        pass = pass + "g"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnred.Click
        pass = pass + "r"
    End Sub

    Private Sub btnblue_Click(sender As Object, e As EventArgs) Handles btnblue.Click
        pass = pass + "b"
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        Dim trimspaces As String = pass
        trimspaces = trimspaces.Replace(" ", "")

        myConn = New SqlConnection("Initial Catalog=logindetails;" & "Data Source=LAPTOP-N2T5OL68\SQLEXPRESS;Integrated Security=SSPI;")
        myCmd = myConn.CreateCommand
        Try
            myCmd.CommandText = "select password from logindetails where Email='" & txtuserid.Text & "'"
            myConn.Open()
            myCmd.ExecuteNonQuery()
            myReader = myCmd.ExecuteReader()
            Do While myReader.Read()
                arrR = myReader.GetString(0)


            Loop
            Dim trimspace As String = arrR
            trimspace = trimspace.Replace(" ", "")
            If String.Equals(trimspace, trimspaces) Then
                MsgBox("Valid Password ")
            Else

                MsgBox("Invalid Password")




            End If



        Catch except As Exception
            MsgBox("not inserted")
        End Try

        Dim OBJ As New verifyimg
        OBJ.stringpass = txtuserid.Text
        OBJ.Show()

        Me.Hide()




    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnred.Hide()
        btnindigo.Hide()
        btnblue.Hide()
        btnorange.Hide()
        btngreen.Hide()
        btnyellow.Hide()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtuserid.Text = ""
        pass = String.Empty

        Form1.Show()

        Me.Hide()


    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form4.Show()
        Me.Hide()

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

    Private Sub btnpink_Click(sender As Object, e As EventArgs)
        pass = pass + "p"
    End Sub

    Private Sub btnindigo_Click(sender As Object, e As EventArgs) Handles btnindigo.Click
        pass = pass + "i"
    End Sub

    Private Sub btnyellow_Click(sender As Object, e As EventArgs) Handles btnyellow.Click
        pass = pass + "y"
    End Sub
End Class