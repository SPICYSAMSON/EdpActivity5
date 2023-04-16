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
                Dim dt As New DataTable()

                ' Read data from CSV file into DataTable
                Using cn As New OleDbConnection With {
                    .ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Path.GetDirectoryName(fileName) & ";Extended Properties='text;HDR=YES;FMT=Delimited'"
                }
                    Using da As New OleDbDataAdapter("SELECT * FROM [" & Path.GetFileName(fileName) & "]", cn)
                        da.Fill(dt)
                    End Using
                End Using

                ' Bind DataTable to DataGridView
                DataGridView1.DataSource = dt
                DataGridView1.AutoResizeColumns()

                ' Show save button
                saveButton.Enabled = True

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Load from CSV", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub saveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click
        Try
            Connect_to_DB()

            Dim adapter As New MySqlDataAdapter()
            Dim cmd As New MySqlCommand("INSERT INTO client(client_id, last_name, first_name, age, sex, address, program_id) " &
                                        "VALUES(@client_id, @last_name, @first_name, @age, @sex, @address, @program_id)", myconn)
            cmd.Parameters.AddWithValue("@client_id", "")
            cmd.Parameters.AddWithValue("@last_name", "")
            cmd.Parameters.AddWithValue("@first_name", "")
            cmd.Parameters.AddWithValue("@age", "")
            cmd.Parameters.AddWithValue("@sex", "")
            cmd.Parameters.AddWithValue("@address", "")
            cmd.Parameters.AddWithValue("@program_id", "")
            adapter.InsertCommand = cmd

            For Each row As DataGridViewRow In DataGridView1.Rows
                cmd.Parameters("@client_id").Value = row.Cells(0).Value
                cmd.Parameters("@last_name").Value = row.Cells(1).Value
                cmd.Parameters("@first_name").Value = row.Cells(2).Value
                cmd.Parameters("@age").Value = row.Cells(3).Value
                cmd.Parameters("@sex").Value = row.Cells(4).Value
                cmd.Parameters("@address").Value = row.Cells(5).Value
                cmd.Parameters("@program_id").Value = row.Cells(6).Value
                adapter.InsertCommand.ExecuteNonQuery()
            Next

            Disconnect_to_DB()
            MessageBox.Show("Data saved to database successfully.", "Save to Database", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            Disconnect_to_DB()
            MessageBox.Show("Error: " & ex.Message, "Save to Database", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class

