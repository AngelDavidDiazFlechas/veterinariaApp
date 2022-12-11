Imports MySql.Data.MySqlClient

Public Class NVProducto
    Dim conexion As New MySqlConnection
    Dim consulta As String
    Dim Dataadapter As MySqlDataAdapter
    Dim dataset As New DataSet
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TBdocumento_TextChanged(sender As Object, e As EventArgs) Handles TBProducto.TextChanged

    End Sub

    Private Sub TBcorreoe_TextChanged(sender As Object, e As EventArgs) Handles TBValor.TextChanged

    End Sub

    Private Sub TBapellidoe_TextChanged(sender As Object, e As EventArgs) Handles TBDescripcion.TextChanged

    End Sub

    Private Sub TBnombree_TextChanged(sender As Object, e As EventArgs) Handles TBStock.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub BTCancelar_Click(sender As Object, e As EventArgs) Handles BTCancelar.Click
        TBProducto.Clear()
        TBStock.Clear()
        TBDescripcion.Clear()
        TBValor.Clear()
        Me.Hide()


    End Sub

    Private Sub BTLimpiar_Click(sender As Object, e As EventArgs) Handles BTLimpiar.Click
        TBProducto.Clear()
        TBStock.Clear()
        TBDescripcion.Clear()
        TBValor.Clear()

    End Sub

    Private Sub NVProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BTAgregar_Click(sender As Object, e As EventArgs) Handles BTAgregarP.Click
        Dim comando As New MySqlCommand

        Dim nproducto = TBProducto.Text
        Dim stock = TBStock.Text
        Dim descripcion = TBDescripcion.Text
        Dim valor = TBValor.Text
        Try
            conexion.ConnectionString = "server=127.0.0.1;database=veterinaria; user id=root;password=;"
            consulta = "INSERT INTO `producto` ( `nombreProducto`, `stock`, `descripcion`, `valor`) VALUES ('" & nproducto & "', '" & stock & "', '" & descripcion & "', '" & valor & "');"
            conexion.Open()
            comando = New MySqlCommand(consulta, conexion)
            comando.ExecuteNonQuery()
            MsgBox("Se guardaron los datos del producto de forma exitosa", vbInformation, "SISTEMA")

            TBProducto.Clear()
            TBStock.Clear()
            TBDescripcion.Clear()
            TBValor.Clear()
            conexion.Close()


        Catch ex As Exception
            MsgBox("Se ha producido un error al guardar los datos del producto" & ex.Message)

            TBProducto.Clear()
            TBStock.Clear()
            TBDescripcion.Clear()
            TBValor.Clear()
            conexion.Close()


        End Try
    End Sub

    Private Sub CBMascota_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub
End Class