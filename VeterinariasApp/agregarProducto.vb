Imports MySql.Data.MySqlClient
Public Class agregarProducto
    Dim conexion As New MySqlConnection
    Dim consulta As String
    Dim Dataadapter As MySqlDataAdapter
    Dim dataset As New DataSet


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTAgregar.Click
        Dim comando As New MySqlCommand
        Dim nombrep = TBNombrep.Text
        Dim stock = TBStock.Text
        Dim descripcion = TBDescripcion.Text
        Dim valor = TBValor.Text
        Try
            conexion.ConnectionString = "server=127.0.0.1;database=veterinaria; user id=root;password=;"

            consulta = "INSERT INTO `producto` ( `nombreProducto`, `stock`, `descripcion`, `valor`) 
            VALUES ('" & nombrep & "', ' " & stock & "', ' " & descripcion & " ',  ' " & valor & " '); "
            conexion.Open()
            comando = New MySqlCommand(consulta, conexion)
            comando.ExecuteNonQuery()
            MsgBox("Los datos del producto se almacenaron de manera correcta", vbInformation, "SISTEMA")
            TBNombrep.Clear()
            TBStock.Clear()
            TBDescripcion.Clear()
            TBValor.Clear()
            conexion.Close()
        Catch ex As Exception
            MsgBox("Error al guardar los datos del producto: " & ex.Message)
            TBNombrep.Clear()
            TBStock.Clear()
            TBDescripcion.Clear()
            TBValor.Clear()
            conexion.Close()
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BTLimpiar.Click

    End Sub

    Private Sub agregarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class