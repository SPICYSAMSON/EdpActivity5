Imports System.IO
Imports System.Data.OleDb

Imports MySql.Data.MySqlClient


Public Class DataLoadForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim openFileDialog1 As New OpenFileDialog()

        openFileDialog1.Filter = "CSV Files (*.csv)|*.csv"
        openFileDialog1.FilterIndex = 1
        openFileDialog1.Multiselect = False

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim fileName As String = openFileDialog1.FileName

            Try
                Connect_to_DB()

                Dim adapter As New MySqlDataAdapter()
                Dim cmd As New MySqlCommand("INSERT INTO client(id, last_name, first_name, age, sex, address, program_id) " &
                                            "VALUES(@id, @last_name, @first_name, @age, @sex, @address, @program_id)", myconn)
                cmd.Parameters.AddWithValue("@id", "")
                cmd.Parameters.AddWithValue("@last_name", "")
                cmd.Parameters.AddWithValue("@first_name", "")
                cmd.Parameters.AddWithValue("@age", "")
                cmd.Parameters.AddWithValue("@sex", "")
                cmd.Parameters.AddWithValue("@address", "")
                cmd.Parameters.AddWithValue("@program_id", "")
                adapter.InsertCommand = cmd

                Dim lines As String() = File.ReadAllLines(fileName)
                For i As Integer = 1 To lines.Length - 1
                    Dim parts As String() = lines(i).Split(","c)
                    cmd.Parameters("@id").Value = parts(0)
                    cmd.Parameters("@last_name").Value = parts(1)
                    cmd.Parameters("@first_name").Value = parts(2)
                    cmd.Parameters("@age").Value = parts(3)
                    cmd.Parameters("@sex").Value = parts(4)
                    cmd.Parameters("@address").Value = parts(5)
                    cmd.Parameters("@program_id").Value = parts(6)
                    adapter.InsertCommand.ExecuteNonQuery()
                Next

                Disconnect_to_DB()
                MessageBox.Show("Data saved to database successfully.", "Save to Database", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                Disconnect_to_DB()
                MessageBox.Show("Error: " & ex.Message, "Save to Database", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class

