Imports System.IO

Public Class Form1
    Dim records(50) As String
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

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs)
        PictureBox1.Load(OpenFileDialog1.FileName)
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IO.File.Exists("data.txt") Then
            Dim inFile As New IO.StreamReader("data.txt")
            records(0) = inFile.ReadLine
            inFile.Close()
            showrecord(0)
        End If

    End Sub
    Public Sub showrecord(index As Integer)
        Dim fields() As String
        fields = records(index).Split("|")
        F1.Text = fields(0)
        F2.Text = fields(1)
        F3.Text = fields(2)
        F4.Text = fields(3)
        F5.Text = fields(4)
        If File.Exists(fields(5)) Then
            PictureBox1.Load(fields(5))
        End If
    End Sub

    Private Sub OpenFileDialog1_FileOk_1(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        PictureBox1.Load(OpenFileDialog1.FileName)
    End Sub
End Class
