Imports MySql.Data.MySqlClient

Public Class FormCRUD
    Private Sub FormCRUD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub LoadData()
        'Retrieve data from database
        Dim query As String = "SELECT * FROM clients_and_programs"
        Dim adapter As New MySqlDataAdapter(query, myconn)
        Dim table As New DataTable()
        adapter.Fill(table)

        'Display data in DataGridView
        DataGridView1.DataSource = table
    End Sub

    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        'Insert a new record into the database
        Dim query As String = "INSERT INTO clients_and_programs (client_name, program_name) VALUES (@client_name, @program_name)"
        Dim command As New MySqlCommand(query, myconn)
        command.Parameters.AddWithValue("@client_name", TextBox1.Text)
        command.Parameters.AddWithValue("@program_name", TextBox2.Text)
        command.ExecuteNonQuery()

        'Reload data in DataGridView
        LoadData()
    End Sub

    Private Sub updateButton_Click(sender As Object, e As EventArgs) Handles updateButton.Click
        'Update a record in the database
        Dim query As String = "UPDATE clients_and_programs SET program_name = @program_name WHERE client_name = @client_name"
        Dim command As New MySqlCommand(query, myconn)
        command.Parameters.AddWithValue("@client_name", TextBox1.Text)
        command.Parameters.AddWithValue("@program_name", TextBox2.Text)
        command.ExecuteNonQuery()

        'Reload data in DataGridView
        LoadData()
    End Sub

    Private Sub deleteRecord_Click(sender As Object, e As EventArgs) Handles deleteRecord.Click
        'Delete a record from the database
        Dim query As String = "DELETE FROM clients_and_programs WHERE client_name = @client_name"
        Dim command As New MySqlCommand(query, myconn)
        command.Parameters.AddWithValue("@client_name", TextBox1.Text)
        command.ExecuteNonQuery()

        'Reload data in DataGridView
        LoadData()
    End Sub

    Private Sub searchBtn_Click(sender As Object, e As EventArgs) Handles searchBtn.Click
        'Retrieve data from database based on search criteria
        Dim query As String = "SELECT * FROM clients_and_programs WHERE client_name LIKE @client_name"
        Dim adapter As New MySqlDataAdapter(query, myconn)
        adapter.SelectCommand.Parameters.AddWithValue("@client_name", "%" & TextBox3.Text & "%")
        Dim table As New DataTable()
        adapter.Fill(table)

        'Display data in DataGridView
        DataGridView1.DataSource = table
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        'Display selected record in TextBoxes
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        TextBox1.Text = row.Cells(0).Value.ToString()
        TextBox2.Text = row.Cells(1).Value.ToString()
    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
