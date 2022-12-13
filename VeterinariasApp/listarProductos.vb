Imports MySql.Data.MySqlClient

Imports System.Security.Cryptography.Pkcs
Public Class listarProductos
    Dim conexion As New MySqlConnection
    Dim dataadapter As MySqlDataAdapter
    Dim dataset As New DataSet
    Dim datareader As MySqlDataReader
    Dim consulta As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class