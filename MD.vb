Imports System.Data
Imports System.Data.SqlClient

Module MD

    Public conStr As String = "Data Source=snakeman-pc\sqlexpress;Initial Catalog=DVD;Integrated Security=True"
    Public connection As New SqlConnection(conStr)
    Public command As New SqlCommand
    Public adapter As SqlDataAdapter
    Public dataSt As DataSet
    Public bindingSrc As BindingSource
    Public reader As SqlDataReader
    Public sql As String

End Module
