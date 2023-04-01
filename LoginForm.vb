Imports MySql.Data.MySqlClient
Public Class LoginForm
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub Admin_username_TextChanged(sender As Object, e As EventArgs) Handles Admin_username.TextChanged

    End Sub
    Private Sub Pass_word_TextChanged(sender As Object, e As EventArgs) Handles Pass_word.TextChanged

    End Sub
    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='HAKDUGERZ69';database=lions_den_mma"

        Try
            conn.Open()
            MessageBox.Show("Connection to MySQL test database was successful!!!!", "TESTING      CONNECTION TO MySQL DATABASE")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click

    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Admin_Click(sender As Object, e As EventArgs) Handles Admin.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
