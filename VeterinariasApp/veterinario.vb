Imports MySql.Data.MySqlClient
Public Class FormVet
    Dim conexion As New MySqlConnection
    Dim dataadapter As MySqlDataAdapter
    Dim dataset As New DataSet
    Dim datareader As MySqlDataReader
    Dim consulta As String
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FormRegistro.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormNuevoC.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub
End Class