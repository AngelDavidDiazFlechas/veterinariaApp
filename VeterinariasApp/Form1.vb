Imports System.Runtime.Intrinsics.Arm
Imports System.Windows
Imports System.Windows.Forms.DataFormats
Imports MySql.Data.MySqlClient
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ingresar_Click(sender As Object, e As EventArgs) Handles ingresar.Click
        panelS.Location = New Point(142, 28)
        panelS.Visible = True
        TBNusuario.Select()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conexion As New MySqlConnection
        Dim dataadapter As MySqlDataAdapter
        Dim dataset As New DataSet
        Dim datareader As MySqlDataReader
        Dim consulta As String
        Dim usuario As String
        Dim password As String
        Dim perfil As Integer
        usuario = TBNusuario.Text
        password = TBclave.Text
        TBNusuario.Text = ""
        TBclave.Clear()

        Try
            conexion.ConnectionString = "server=127.0.0.1;database=veterinaria;user id=root;password=root;"
            consulta = "SELECT * FROM usuarios WHERE nomusuario = '" & usuario & "' AND contraseña ='" & password & "';"
            conexion.Open()
            dataadapter = New MySqlDataAdapter(consulta, conexion)
            dataset.Clear()
            dataadapter.Fill(dataset, "usuarios")
            Dim querry As New MySqlCommand(consulta, conexion)
            datareader = querry.ExecuteReader
            While datareader.Read
                perfil = (datareader.GetString(3))
            End While
            If (dataset.Tables("usuarios").Rows.Count() <> 0) Then
                Select Case perfil
                    Case 1
                        MsgBox("Admisitrador bienvenido al sistema", vbInformation, "SISTEMA")
                        panelS.Visible = False
                        administrador.Show()
                        Me.Hide()
                    Case 2
                        MsgBox("Veterinario bienvenido al sistema", vbInformation, "SISTEMA")
                        panelS.Visible = False
                        veterinario.Show()
                        Me.Hide()
                    Case 3
                        MsgBox("Empleado bienvenido al sistema", vbInformation, "SISTEMA")
                        panelS.Visible = False
                        empleado.Show()
                        Me.Hide()
                    Case Else
                        MsgBox("Los datos digitados no se encuentran en la base de datos", vbInformation, "SISTEMA")
                        panelS.Visible = False
                End Select
            End If
            conexion.Close()
        Catch ex As Exception
            MsgBox("Error al consultar las credenciales" & ex.Message)
            conexion.Close()
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
