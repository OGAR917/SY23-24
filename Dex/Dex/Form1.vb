Imports System.IO

Public Class Form1
    Dim records(50) As String
    Dim count As Integer
    Dim current As Integer
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        F1.Text = ""
        F2.Text = ""
        F3.Text = ""
        F4.Text = ""
        F5.Text = ""
        PictureBox1.Image = Nothing
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim outFile As New IO.StreamWriter("Data.txt")
        outFile.Write(F1.Text)
        outFile.Write("|")
        outFile.Write(F2.Text)
        outFile.Write("|")
        outFile.Write(F3.Text)
        outFile.Write("|")
        outFile.Write(F4.Text)
        outFile.Write("|")
        outFile.Write(F5.Text)
        outFile.Write("|")
        outFile.WriteLine(PictureBox1.ImageLocation)
        outFile.Close()
    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        OpenFileDialog1.ShowDialog()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IO.File.Exists("data.txt") Then
            Dim inFile As New IO.StreamReader("data.txt")
            While Not inFile.EndOfStream
                records(count) = inFile.ReadLine
                count = count + 1
            End While
            inFile.Close()
            showrecord(0)
        End If

    End Sub
    Public Sub showrecord(index As Integer)
        Dim fields() As String
        If records(index) <> Nothing Then
            fields = records(index).Split("|")
            F1.Text = fields(0)
            F2.Text = fields(1)
            F3.Text = fields(2)
            F4.Text = fields(3)
            F5.Text = fields(4)
            If File.Exists(fields(5)) Then
                PictureBox1.Load(fields(5))
            End If
        End If
    End Sub

    Private Sub OpenFileDialog1_FileOk_1(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        PictureBox1.Load(OpenFileDialog1.FileName)
    End Sub

    Private Sub FirstB_Click(sender As Object, e As EventArgs) Handles FirstB.Click
        current = 0
        showrecord(current)
    End Sub

    Private Sub LastB_Click(sender As Object, e As EventArgs) Handles LastB.Click
        current = count - 1
        showrecord(current)
    End Sub

    Private Sub PrevB_Click(sender As Object, e As EventArgs) Handles PrevB.Click
        If current > 0 Then
            current = current - 1
            showrecord(current)
        End If
    End Sub

    Private Sub NextB_Click(sender As Object, e As EventArgs) Handles NextB.Click
        If current < count - 1 Then
            current = current + 1
            showrecord(current)
        End If
    End Sub
End Class