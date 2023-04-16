

Imports MySql.Data.MySqlClient

Public Class FormCRUD
    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        'Establish connection to the database
        Connect_to_DB()

        'Create a MySqlCommand object
        'Set the CommandText property of the MySqlCommand object to an SQL INSERT statement
        Dim cmd As New MySqlCommand With {
            .CommandText = "INSERT INTO client (client_id, program_id, first_name, last_name, age, sex) VALUES (@client_id, @program_id, @first_name, @last_name, @age, @sex)"
        }

        'Set the parameters of the SQL INSERT statement using the values entered in the textboxes
        cmd.Parameters.AddWithValue("@client_id", clientIdTextBox.Text)
        cmd.Parameters.AddWithValue("@program_id", programIdTextBox.Text)
        cmd.Parameters.AddWithValue("@first_name", clientFirstNameTextBox.Text)
        cmd.Parameters.AddWithValue("@last_name", clientLastNameTextBox.Text)
        cmd.Parameters.AddWithValue("@age", ageTextBox.Text)
        cmd.Parameters.AddWithValue("@sex", sexTextBox.Text)

        'Set the Connection property of the MySqlCommand object to the MySqlConnection object
        cmd.Connection = myconn

        'Execute the SQL INSERT statement
        cmd.ExecuteNonQuery()

        'Disconnect from the database
        Disconnect_to_DB()

        'Show a message box to indicate that the record has been added
        MessageBox.Show("Record added successfully.")
    End Sub

    Private Sub updateButton_Click(sender As Object, e As EventArgs) Handles updateButton.Click
        'Establish connection to the database
        Connect_to_DB()

        'Create a MySqlCommand object
        Dim cmd As New MySqlCommand

        'Set the CommandText property of the MySqlCommand object to an SQL UPDATE statement
        cmd.CommandText = "UPDATE client SET first_name = @first_name, last_name = @last_name, client_id = @client_id, program_id = @program_id WHERE client_id = @client_id"

        'Set the parameters of the SQL UPDATE statement using the values entered in the textboxes
        cmd.Parameters.AddWithValue("@client_id", clientIdTextBox.Text)
        cmd.Parameters.AddWithValue("@program_id", programIdTextBox.Text)
        cmd.Parameters.AddWithValue("@first_name", clientFirstNameTextBox.Text)
        cmd.Parameters.AddWithValue("@last_name", clientLastNameTextBox.Text)

        'Set the Connection property of the MySqlCommand object to the MySqlConnection object
        cmd.Connection = myconn

        'Execute the SQL UPDATE statement
        cmd.ExecuteNonQuery()

        'Disconnect from the database
        Disconnect_to_DB()

        'Show a message box to indicate that the record has been updated
        MessageBox.Show("Record updated successfully.")
    End Sub

    Private Sub deleteClientBtn_Click(sender As Object, e As EventArgs) Handles deleteButton.Click
        'Establish connection to the database
        Connect_to_DB()

        'Create a MySqlCommand object
        Dim cmd As New MySqlCommand

        'Check if the client has associated transactions
        cmd.CommandText = "SELECT COUNT(*) FROM transactions WHERE client_id = @client_id"
        cmd.Parameters.AddWithValue("@client_id", clientIdTextBox.Text)
        cmd.Connection = myconn
        Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

        If count > 0 Then
            'Show error message
            MessageBox.Show("Cannot delete client, they have associated transactions.")
        Else
            'Set the CommandText property of the MySqlCommand object to an SQL DELETE statement
            cmd.CommandText = "DELETE FROM client WHERE client_id = @client_id"

            'Set the parameters of the SQL DELETE statement using the values entered in the textboxes
            cmd.Parameters.AddWithValue("@client_id", clientIdTextBox.Text)

            'Set the Connection property of the MySqlCommand object to the MySqlConnection object
            cmd.Connection = myconn

            'Execute the SQL DELETE statement
            cmd.ExecuteNonQuery()

            'Show a message box to indicate that the record has been deleted
            MessageBox.Show("Record deleted successfully.")
        End If

        'Disconnect from the database
        Disconnect_to_DB()
    End Sub

    Private Sub searchBtn_Click(sender As Object, e As EventArgs) Handles searchBtn.Click
        'Establish connection to the database
        Connect_to_DB()

        'Create a MySqlCommand object
        Dim cmd As New MySqlCommand

        'Set the CommandText property of the MySqlCommand object to an SQL SELECT statement
        cmd.CommandText = "SELECT * FROM client WHERE first_name LIKE @search OR last_name LIKE @search"

        'Set the parameters of the SQL SELECT statement using the value entered in the searchTextBox
        cmd.Parameters.AddWithValue("@search", "%" & searchTextBox.Text & "%")

        'Set the Connection property of the MySqlCommand object to the MySqlConnection object
        cmd.Connection = myconn

        'Create a DataTable object to hold the results of the SQL SELECT statement
        Dim dt As New DataTable

        'Create a MySqlDataAdapter object
        Dim da As New MySqlDataAdapter(cmd)

        'Fill the DataTable object with the results of the SQL SELECT statement
        da.Fill(dt)

        'Disconnect from the database
        Disconnect_to_DB()

        'Bind the DataTable object to the DataGridView control
        DataGridView1.DataSource = dt

        'Show a message box to indicate the number of records found
        MessageBox.Show(dt.Rows.Count & " record(s) found.")
    End Sub


End Class