Imports System.IO
Imports System.Runtime.CompilerServices

Public Class Form1
    Private Sub ButtonWrite_Click(sender As Object, e As EventArgs) Handles ButtonWrite.Click
        Try
            Dim filePath As String = "sample.txt" ' File Location

            Using writer As New StreamWriter(filePath, True) 'True to apppend
                writer.WriteLine("Hello, this is a test file!")
                writer.WriteLine("Second line of the text.")
            End Using

            MessageBox.Show("Data written successfully.", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub ButtonRead_Click(sender As Object, e As EventArgs) Handles ButtonReadPerLine.Click
        Dim filepath As String = "sample.txt"
        Using reader As New StreamReader(filepath)
            Dim content As String = reader.ReadToEnd()
            MessageBox.Show("File content:" + content)
        End Using
    End Sub

    Private Sub ButtonReadPerLIne_Click(sender As Object, e As EventArgs) Handles ButtonReadPerLIne.Click
        ListBox1.Items.Clear()
        Dim filepath As String = "sample.txt"
        Using reader As New StreamReader(filepath)
            Dim Line As String
            Line = reader.ReadLine()
            While (Line IsNot Nothing)
                ListBox1.Items.Add(Line)
                Line = reader.ReadLine()
            End While
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class