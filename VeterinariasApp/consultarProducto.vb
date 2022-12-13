Imports MySql.Data.MySqlClient

Public Class consultarProducto
    Dim conexion As New MySqlConnection
    Dim dataadapter As MySqlDataAdapter
    Dim dataset As New DataSet
    Dim datareader As MySqlDataReader
    Dim consulta As String


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            conexion.ConnectionString = "server=127.0.0.1;database=veterinaria; user id=root;password=;"
            consulta = "select * from producto WHERE idProducto = " & TBBuscarProducto.Text & ";"
            conexion.Open()
            dataadapter = New MySqlDataAdapter(consulta, conexion)
            dataset.Clear()
            dataadapter.Fill(dataset, "producto")
            DataGridView1.DataSource = dataset
            DataGridView1.DataMember = "producto"
            conexion.Close()

        Catch ex As Exception
            MsgBox("Error al mostrar la informacion del producto : " & ex.Message)
            conexion.Close()

        End Try

    End Sub
End Class