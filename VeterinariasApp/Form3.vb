Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient
Public Class FormNuevoC
    Dim conexion As New MySqlConnection
    Dim consulta As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim comando As New MySqlCommand
        Dim nombres = TBNomCliente.Text
        Dim direccion = TBDireccion.Text
        Dim telefono = TBTelefono.Text
        Try
            conexion.ConnectionString = "server=127.0.0.1;database=veterinaria;user id=root;password=;"
            consulta = "INSERT INTO `clientes` (`nombre`, `direccion`, `telefono`) 
            VALUES ('" & nombres & "','" & direccion & "','" & telefono & "');"
            conexion.Open()
            comando = New MySqlCommand(consulta, conexion)
            comando.ExecuteNonQuery()
            MsgBox("Datos Almacenados correctamente")
            TBNomCliente.Clear()
            TBDireccion.Clear()
            TBTelefono.Clear()
            conexion.Close()
        Catch ex As Exception
            MsgBox("Error al guardar los datos " & ex.Message)
            TBNomCliente.Clear()
            TBDireccion.Clear()
            TBTelefono.Clear()
            conexion.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class