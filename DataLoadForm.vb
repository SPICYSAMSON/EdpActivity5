Imports System.IO
Imports System.Data.OleDb

Public Class DataLoadForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim openFileDialog1 As New OpenFileDialog()

        openFileDialog1.Filter = "CSV Files (*.csv)|*.csv"
        openFileDialog1.FilterIndex = 1
        openFileDialog1.Multiselect = False

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim fileName As String = openFileDialog1.FileName
            Dim connectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" &
                Path.GetDirectoryName(fileName) & ";Extended Properties='Text;HDR=YES;'"
            Dim adapter As New OleDbDataAdapter("SELECT * FROM [" & Path.GetFileName(fileName) & "]", connectionString)
            Dim ds As New DataSet()
            adapter.Fill(ds, "data")
            DataGridView1.DataSource = ds.Tables("data")
        End If
    End Sub
End Class
