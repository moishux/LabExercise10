Imports System.IO
Imports System.Linq

Public Class Form1

    Private Sub ButtonWrite_Click(sender As Object, e As EventArgs) Handles ButtonWrite.Click
        Try
            Dim filePath As String = "numbers.txt"
            Dim number As Integer = CInt(NumericUpDown1.Value)
            Using writer As New StreamWriter(filePath, True)
                writer.WriteLine(number)
            End Using

            MessageBox.Show("Saved successfully!.txt.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonRead_Click(sender As Object, e As EventArgs) Handles ButtonRead.Click
        Try
            Dim filePath As String = "numbers.txt"

            If Not File.Exists(filePath) Then
                MessageBox.Show("File not found. Please add numbers first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Using reader As New StreamReader(filePath)
                Dim content As String = reader.ReadToEnd()
                MessageBox.Show("File Content:" & vbCrLf & content, "numbers.txt", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonSort_Click(sender As Object, e As EventArgs) Handles ButtonSort.Click
        Try
            ListBoxNumbers.Items.Clear()
            Dim filePath As String = "numbers.txt"

            If Not File.Exists(filePath) Then
                MessageBox.Show("File not found. Please add numbers first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If


            Dim numbers As List(Of Integer) =
                File.ReadAllLines(filePath).
                Where(Function(line) Not String.IsNullOrWhiteSpace(line)).
                Select(Function(line) Convert.ToInt32(line)).
                OrderBy(Function(n) n).
                ToList()


            For Each num In numbers
                ListBoxNumbers.Items.Add(num)
            Next

            MessageBox.Show("Numbers sorted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
