Imports Excel = Microsoft.Office.Interop.Excel

Public Module ExcelModule
    Public Sub ExportToExcel(dataGridView As DataGridView)
        If dataGridView.Rows.Count <= 0 Then
            MessageBox.Show("No data to export.", "Export to Excel", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim excelApp As New Excel.Application()
        Dim excelWorkbook As Excel.Workbook = excelApp.Workbooks.Add()
        Dim excelWorksheet As Excel.Worksheet = excelWorkbook.Sheets("Sheet1")
        Dim rowIndex As Integer = 1
        Dim columnIndex As Integer = 1

        ' Write header row to Excel
        For Each column As DataGridViewColumn In dataGridView.Columns
            excelWorksheet.Cells(rowIndex, columnIndex) = column.HeaderText
            columnIndex += 1
        Next

        ' Write data to Excel
        For Each row As DataGridViewRow In dataGridView.Rows
            rowIndex += 1
            columnIndex = 1
            For Each cell As DataGridViewCell In row.Cells
                excelWorksheet.Cells(rowIndex, columnIndex) = cell.Value
                columnIndex += 1
            Next
        Next

        ' Save the Excel file
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx"
        saveFileDialog.FileName = "ExportedData"
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            excelWorkbook.SaveAs(saveFileDialog.FileName)
            MessageBox.Show("Data exported to Excel successfully.", "Export to Excel", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        ' Close the Excel file and release resources
        excelWorkbook.Close()
        excelApp.Quit()
        System.Runtime.InteropServices.Marshal.ReleaseComObject(excelWorksheet)
        System.Runtime.InteropServices.Marshal.ReleaseComObject(excelWorkbook)
        System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp)
    End Sub
End Module
