Imports MySql.Data.MySqlClient

Public Class eliminarProducto
    Dim conexion As New MySqlConnection
    Dim dataadapter As MySqlDataAdapter
    Dim dataset As New DataSet
    Dim datareader As MySqlDataReader
    Dim consulta As String
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub TBBorrar_Click(sender As Object, e As EventArgs) Handles TBBorrar.Click
        Try

            conexion.ConnectionString = "server=127.0.0.1;database=veterinaria; user id=root;password=;"
            consulta = "delete from producto where idProducto = " & TBEliminarproducto.Text & ";"
            conexion.Open()
            dataadapter = New MySqlDataAdapter(consulta, conexion)
            dataset.Clear()
            dataadapter.Fill(dataset, "producto")
            DataGridView2.DataSource = dataset
            DataGridView2.DataMember = "producto"
            conexion.Close()

        Catch ex As Exception
            MsgBox("Error al mostrar la informacion del producto : " & ex.Message)
            conexion.Close()

        End Try
    End Sub
End Class