Imports System.Data.SqlClient
Imports System.IO
Public Class verifyimg
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Dim passimg As String
    Dim email As String
    Dim arrR As String
    Public Property imgsrc As String
    Public Property stringpass As String
    Dim im As New Form5
    Private Sub imsave_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        box1.AllowDrop = True
        box2.AllowDrop = True
        box3.AllowDrop = True

        box5.AllowDrop = True
        box6.AllowDrop = True
        box7.AllowDrop = True

        box9.AllowDrop = True
        box10.AllowDrop = True
        box11.AllowDrop = True


        box1.Hide()
        box2.Hide()
        box3.Hide()
        box5.Hide()
        box6.Hide()
        box7.Hide()
        box9.Hide()
        box10.Hide()
        box11.Hide()
        passimg = String.Empty
        email = stringpass
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnbrow_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub box1_MouseDown(sender As Object, e As MouseEventArgs) Handles box1.MouseDown
        box1.DoDragDrop(box1.Image, DragDropEffects.Move)
        box1.Image = Nothing
        If box1.Image Is Nothing Then
            MsgBox("emptied")
        End If

    End Sub

    Private Sub box1_DragDrop(sender As Object, e As DragEventArgs) Handles box1.DragDrop
        Dim getpic = e.Data.GetData(DataFormats.Bitmap)
        box1.Image = getpic
    End Sub

    Private Sub box1_DragEnter(sender As Object, e As DragEventArgs) Handles box1.DragEnter
        If (e.Data.GetDataPresent(DataFormats.Bitmap)) Then
            e.Effect = DragDropEffects.Move
        End If
    End Sub
    Private Sub box2_DragDrop(sender As Object, e As DragEventArgs) Handles box2.DragDrop
        Dim getpic = e.Data.GetData(DataFormats.Bitmap)
        box2.Image = getpic
    End Sub

    Private Sub box2_DragEnter(sender As Object, e As DragEventArgs) Handles box2.DragEnter
        If (e.Data.GetDataPresent(DataFormats.Bitmap)) Then
            e.Effect = DragDropEffects.Move
        End If

    End Sub

    Private Sub box2_MouseDown(sender As Object, e As MouseEventArgs) Handles box2.MouseDown
        box2.DoDragDrop(box2.Image, DragDropEffects.Move)
        box2.Image = Nothing
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub box3_DragDrop(sender As Object, e As DragEventArgs) Handles box3.DragDrop
        Dim getpic = e.Data.GetData(DataFormats.Bitmap)
        box3.Image = getpic
    End Sub

    Private Sub box3_DragEnter(sender As Object, e As DragEventArgs) Handles box3.DragEnter
        If (e.Data.GetDataPresent(DataFormats.Bitmap)) Then
            e.Effect = DragDropEffects.Move
        End If
    End Sub

    Private Sub box3_MouseDown(sender As Object, e As MouseEventArgs) Handles box3.MouseDown
        box3.DoDragDrop(box3.Image, DragDropEffects.Move)
        box3.Image = Nothing
    End Sub

    Private Sub box5_DragDrop(sender As Object, e As DragEventArgs) Handles box5.DragDrop
        Dim getpic = e.Data.GetData(DataFormats.Bitmap)
        box5.Image = getpic
    End Sub

    Private Sub box5_DragEnter(sender As Object, e As DragEventArgs) Handles box5.DragEnter
        If (e.Data.GetDataPresent(DataFormats.Bitmap)) Then
            e.Effect = DragDropEffects.Move
        End If
    End Sub

    Private Sub box5_MouseDown(sender As Object, e As MouseEventArgs) Handles box5.MouseDown
        box5.DoDragDrop(box5.Image, DragDropEffects.Move)
        box5.Image = Nothing
    End Sub

    Private Sub box6_DragDrop(sender As Object, e As DragEventArgs) Handles box6.DragDrop
        Dim getpic = e.Data.GetData(DataFormats.Bitmap)
        box6.Image = getpic
    End Sub

    Private Sub box6_DragEnter(sender As Object, e As DragEventArgs) Handles box6.DragEnter
        If (e.Data.GetDataPresent(DataFormats.Bitmap)) Then
            e.Effect = DragDropEffects.Move
        End If
    End Sub

    Private Sub box6_MouseDown(sender As Object, e As MouseEventArgs) Handles box6.MouseDown
        box6.DoDragDrop(box6.Image, DragDropEffects.Move)
        box6.Image = Nothing
    End Sub

    Private Sub box7_DragDrop(sender As Object, e As DragEventArgs) Handles box7.DragDrop
        Dim getpic = e.Data.GetData(DataFormats.Bitmap)
        box7.Image = getpic
    End Sub

    Private Sub box7_DragEnter(sender As Object, e As DragEventArgs) Handles box7.DragEnter
        If (e.Data.GetDataPresent(DataFormats.Bitmap)) Then
            e.Effect = DragDropEffects.Move
        End If
    End Sub

    Private Sub box7_MouseDown(sender As Object, e As MouseEventArgs) Handles box7.MouseDown
        box7.DoDragDrop(box7.Image, DragDropEffects.Move)
        box7.Image = Nothing
    End Sub

    Private Sub box9_DragDrop(sender As Object, e As DragEventArgs) Handles box9.DragDrop
        Dim getpic = e.Data.GetData(DataFormats.Bitmap)
        box9.Image = getpic
    End Sub

    Private Sub box9_DragEnter(sender As Object, e As DragEventArgs) Handles box9.DragEnter
        If (e.Data.GetDataPresent(DataFormats.Bitmap)) Then
            e.Effect = DragDropEffects.Move
        End If
    End Sub

    Private Sub box9_MouseDown(sender As Object, e As MouseEventArgs) Handles box9.MouseDown
        box9.DoDragDrop(box9.Image, DragDropEffects.Move)
        box9.Image = Nothing
    End Sub

    Private Sub box10_DragDrop(sender As Object, e As DragEventArgs) Handles box10.DragDrop
        Dim getpic = e.Data.GetData(DataFormats.Bitmap)
        box10.Image = getpic
    End Sub

    Private Sub box10_DragEnter(sender As Object, e As DragEventArgs) Handles box10.DragEnter
        If (e.Data.GetDataPresent(DataFormats.Bitmap)) Then
            e.Effect = DragDropEffects.Move
        End If
    End Sub

    Private Sub box10_MouseDown(sender As Object, e As MouseEventArgs) Handles box10.MouseDown
        box10.DoDragDrop(box10.Image, DragDropEffects.Move)
        box10.Image = Nothing
    End Sub

    Private Sub box11_DragDrop(sender As Object, e As DragEventArgs) Handles box11.DragDrop
        Dim getpic = e.Data.GetData(DataFormats.Bitmap)
        box11.Image = getpic
    End Sub

    Private Sub box11_DragEnter(sender As Object, e As DragEventArgs) Handles box11.DragEnter
        If (e.Data.GetDataPresent(DataFormats.Bitmap)) Then
            e.Effect = DragDropEffects.Move
        End If
    End Sub

    Private Sub box11_MouseDown(sender As Object, e As MouseEventArgs) Handles box11.MouseDown
        box11.DoDragDrop(box11.Image, DragDropEffects.Move)
        box11.Image = Nothing
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btninsert.Click
        If box1.Image IsNot Nothing Then
            passimg = passimg + "1"
        End If
        If box2.Image IsNot Nothing Then
            passimg = passimg + "2"
        End If
        If box3.Image IsNot Nothing Then
            passimg = passimg + "3"
        End If
        If box5.Image IsNot Nothing Then
            passimg = passimg + "4"
        End If
        If box6.Image IsNot Nothing Then
            passimg = passimg + "5"
        End If
        If box7.Image IsNot Nothing Then
            passimg = passimg + "6"
        End If
        If box9.Image IsNot Nothing Then
            passimg = passimg + "7"
        End If
        If box10.Image IsNot Nothing Then
            passimg = passimg + "8"
        End If
        If box11.Image IsNot Nothing Then
            passimg = passimg + "9"
        End If
        myConn = New SqlConnection("Initial Catalog=logindetails;" & "Data Source=LAPTOP-N2T5OL68\SQLEXPRESS;Integrated Security=SSPI;")
        myCmd = myConn.CreateCommand

        myCmd.CommandText = "select imgpass from imagedetails where Email='" & email & "'"
        myConn.Open()
        myCmd.ExecuteNonQuery()
        myReader = myCmd.ExecuteReader()
        Do While myReader.Read()
            arrR = myReader.GetString(0)




        Loop
        Dim trimspaces As String = passimg
        trimspaces = trimspaces.Replace(" ", "")
        Dim trimspace As String = arrR
        trimspace = trimspace.Replace(" ", "")
        If String.Equals(trimspace, trimspaces) Then
            MsgBox("Valid Password ")
        Else

            MsgBox("Invalid Password")




        End If


    End Sub

    Private Sub btnsubmit_Click_1(sender As Object, e As EventArgs) Handles btnsubmit.Click
        myConn = New SqlConnection("Initial Catalog=logindetails;" & "Data Source=LAPTOP-N2T5OL68\SQLEXPRESS;Integrated Security=SSPI;")
        myCmd = myConn.CreateCommand

        myCmd.CommandText = "select img from imagedetails where Email='" & email & "'"
            myConn.Open()
            myCmd.ExecuteNonQuery()
            myReader = myCmd.ExecuteReader()
            Do While myReader.Read()
                arrR = myReader.GetString(0)




            Loop

            box1.Image = Image.FromFile(arrR)
            box2.Image = Image.FromFile(arrR)
            box3.Image = Image.FromFile(arrR)


















            box1.Show()
        box2.Show()
        box3.Show()
        box5.Show()
        box6.Show()
        box7.Show()
        box9.Show()
        box10.Show()
        box11.Show()

        cmbbox.Hide()
        btnsubmit.Hide()

    End Sub
End Class