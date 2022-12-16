Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop
Imports System.Security.Cryptography.Pkcs
Public Class listarProductos
    Dim conexion As New MySqlConnection
    Dim dataadapter As MySqlDataAdapter
    Dim dataset As New DataSet
    Dim datareader As MySqlDataReader
    Dim consulta As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles TBTraerp.Click
        Try

            conexion.ConnectionString = "server=127.0.0.1;database=veterinaria; user id=root;password=;"
            consulta = "SELECT * FROM veterinaria.producto;"
            conexion.Open()
            dataadapter = New MySqlDataAdapter(consulta, conexion)
            dataset.Clear()
            dataadapter.Fill(dataset, "producto")
            DGVProductos.DataSource = dataset
            DGVProductos.DataMember = "producto"
            conexion.Close()

        Catch ex As Exception
            MsgBox("Error al mostrar la informacion del producto : " & ex.Message)
            conexion.Close()

        End Try

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BTExcel.Click
        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet
        Dim Ncol As Integer
        Dim Nrow As Integer
        Try
            exLibro = exApp.Workbooks.Add
            exHoja = exLibro.Worksheets.Add()
            Ncol = DGVProductos.ColumnCount
            Nrow = DGVProductos.RowCount


            For i As Integer = 1 To Ncol
                exHoja.Cells.Item(1, i) = DGVProductos.Columns(i - 1).Name.ToString
            Next
            For fila As Integer = 0 To Nrow - 1
                For col As Integer = 0 To Ncol - 1
                    exHoja.Cells.Item(fila + 2, col + 1) = DGVProductos.Rows(fila).Cells(col).Value
                Next
            Next
            exHoja.Columns.AutoFit()
                exHoja.Columns.HorizontalAlignment = 2
                exApp.Application.Visible = True
            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing
        Catch ex As Exception
            MsgBox("Error al exportar la informacion de los productos: " & ex.Message)
        End Try
    End Sub
End Class