Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient
Public Class FormRegistro
    Dim conexion As New MySqlConnection
    Dim consulta As String
    Private Sub FormRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Dataadapter As MySqlDataAdapter
        Dim dataset As New DataSet
        Try
            conexion.ConnectionString = "server=127.0.0.1;database=veterinaria;user id=root;password=;"
            consulta = "select * from clientes;"
            conexion.Open()
            Dataadapter = New MySqlDataAdapter(consulta, conexion)
            dataset.Clear()
            dataset.Tables.Add("nombre")
            Dataadapter.Fill(dataset.Tables("nombre"))
            CBCliente.DataSource = dataset.Tables("nombre")
            CBCliente.DisplayMember = "nombre"
            conexion.Close()
        Catch ex As Exception
            MsgBox("Error al llenar los perfiles: " & ex.Message)
            conexion.Close()
        End Try
    End Sub
    Private Sub Agregar_Click(sender As Object, e As EventArgs) Handles Agregar.Click
        Dim comando As New MySqlCommand
        Dim nombre_m = TBNombreM.Text
        Dim especie = TBEspecie.Text
        Dim sexo = TBSexo.Text
        Dim esterilizado = TBEsterilizacion.Text
        Dim raza = TBRaza.Text
        Dim peso = TBPeso.Text
        Dim vacunas = TBVacunas.Text
        Dim color = TBColor.Text
        Dim cliente = CBCliente.SelectedIndex
        Try
            conexion.ConnectionString = "server=127.0.0.1;database=veterinaria;user id=root;password=;"
            consulta = "INSERT INTO `mascotas` (`nombre_m`, `especie`, `sexo`,`esterilizacion`, `raza`, `peso`,`vacunas`, `color`,`cliente_id`) 
            VALUES ('" & nombre_m & "','" & especie & "','" & sexo & "','" & esterilizado & "','" & raza & "','" & peso & "','" & vacunas & "','" & color & "','" & cliente + 1 & "');"
            conexion.Open()
            comando = New MySqlCommand(consulta, conexion)
            comando.ExecuteNonQuery()
            MsgBox("Datos Almacenados correctamente")
            TBNombreM.Clear()
            TBEspecie.Clear()
            TBSexo.Clear()
            TBEsterilizacion.Clear()
            TBRaza.Clear()
            TBPeso.Clear()
            TBVacunas.Clear()
            TBColor.Clear()
            conexion.Close()
        Catch ex As Exception
            MsgBox("Error al guardar los datos " & ex.Message)
            TBNombreM.Clear()
            TBEspecie.Clear()
            TBSexo.Clear()
            TBEsterilizacion.Clear()
            TBRaza.Clear()
            TBPeso.Clear()
            TBVacunas.Clear()
            TBColor.Clear()
            conexion.Close()
        End Try
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TBNombreM.Clear()
        TBEspecie.Clear()
        TBSexo.Clear()
        TBEsterilizacion.Clear()
        TBRaza.Clear()
        TBPeso.Clear()
        TBVacunas.Clear()
        TBColor.Clear()
        Me.Hide()
    End Sub

    Private Sub CBCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBCliente.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TBNombreM.Clear()
        TBEspecie.Clear()
        TBSexo.Clear()
        TBEsterilizacion.Clear()
        TBRaza.Clear()
        TBPeso.Clear()
        TBVacunas.Clear()
        TBColor.Clear()
        CBCliente.Refresh()
        Me.Refresh()
    End Sub
End Class