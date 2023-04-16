Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient
Public Class LoginForm
    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        Dim conn As MySqlConnection = Nothing
        Try
            conn = myconn
            If conn.State <> ConnectionState.Open Then
                Connect_to_DB()
            End If

            Dim query As String = "SELECT * FROM login WHERE username = @username AND password = @password"
            Dim command As New MySqlCommand(query, conn)
            command.Parameters.AddWithValue("@username", txtUsername.Text)
            command.Parameters.AddWithValue("@password", txtPassword.Text)
            Dim reader As MySqlDataReader = command.ExecuteReader()

            If reader.HasRows Then
                MessageBox.Show("Login successful!", "Login")
                Dim form2 As New Form2()
                form2.Show()
                Me.Hide()
            Else
                MessageBox.Show("Invalid username or password", "Login")
            End If

            reader.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                Disconnect_to_DB()
            End If
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
