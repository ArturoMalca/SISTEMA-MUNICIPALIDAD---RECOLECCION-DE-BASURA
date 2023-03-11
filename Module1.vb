Imports System.Data.SqlClient
Module Module1
    Public conn As New SqlConnection
    Public cmd As New SqlCommand
    Public dr As SqlDataReader

    Public Sub Abrir()
        conn.ConnectionString = "database=bd_soft_fran;Integrated Security=SSPI;Data Source=(Local)"
        cmd.Connection = conn
        conn.Open()
    End Sub

    Public Sub Cerrar()
        conn.Close()
    End Sub
    'Select Case FORMAT(getdate(),'dd-MM-yyyy hh:mm')
End Module
