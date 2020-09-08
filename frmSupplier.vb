Imports System.Data
Imports System.Data.SqlClient

Public Class frmSupplier
    Private Sub frmSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        BindingNavigator1.DeleteItem = Nothing
        'BindingData()
    End Sub

    Private Sub BindingData(ByVal Optional cmd As SqlCommand = Nothing)
        Dim tbx As TextBox
        Dim link As LinkLabel

        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                tbx = CType(ctrl, TextBox)
                tbx.DataBindings.Clear()
                tbx.Text = ""
            ElseIf TypeOf ctrl Is LinkLabel Then
                link = CType(ctrl, LinkLabel)
                link.DataBindings.Clear()
            End If
        Next

        If cmd Is Nothing Then
            command.CommandText = "SELECT * FROM Supplier;"
        Else
            command = cmd
        End If

        adapter = New SqlDataAdapter(command)
        dataSt = New DataSet
        adapter.Fill(dataSt, "Supplier")

        bindingSrc = New BindingSource(dataSt, "Supplier")
        tbxID.DataBindings.Add("Text", bindingSrc, "SupplierId")
        tbxName.DataBindings.Add("Text", bindingSrc, "Name")
        tbxPhone.DataBindings.Add("Text", bindingSrc, "Phone")
        tbxFax.DataBindings.Add("Text", bindingSrc, "Fax")
        tbxMail.DataBindings.Add("Text", bindingSrc, "Mail")
        tbxAddress.DataBindings.Add("Text", bindingSrc, "Address")
        LinkURL.DataBindings.Add("Text", bindingSrc, "Website")
        LabelURL.Text = ""
        BindingNavigator1.BindingSource = bindingSrc
        createAutoComplete()
    End Sub

    Private Sub BindingNavigatorSave_Click(sender As Object, e As EventArgs) Handles BindingNavigatorSave.Click
        If tbxID.Text = "" Then
            insertData()
        Else
            updateData()
        End If
    End Sub

    Private Sub insertData()
        sql = "INSERT INTO Supplier(Name, Phone, Fax, Email, Address, Website) VALUES(@n, @p, @f, @e, @a, @w);"

        command.CommandText = sql
        command.Parameters.Clear()
        command.Parameters.AddWithValue("@n", tbxName.Text.ToString())
        command.Parameters.AddWithValue("@p", tbxPhone.Text.ToString())
        command.Parameters.AddWithValue("@f", tbxFax.Text.ToString())
        command.Parameters.AddWithValue("@e", tbxMail.Text.ToString())
        command.Parameters.AddWithValue("@a", tbxAddress.Text.ToString())
        command.Parameters.AddWithValue("@w", LabelURL.Text.ToString())

        Dim result As Integer = command.ExecuteNonQuery()

        If result = -1 Then
            MsgBox("เกิดข้อผิดพลาด ไม่สามรถเพิ่มข้อมูลได้")
        Else
            MsgBox("บันทึกข้อมูลแล้ว")
            BindingData()
        End If
    End Sub

    Private Sub updateData()
        sql = "UPDATE Supplier SET Name = @n, Phone = @p, Fax = @f, Email = @e, Address = @a, Website = @w WHERE CustomerId = @i;"

        command.CommandText = sql
        command.Parameters.Clear()
        command.Parameters.AddWithValue("@n", tbxName.Text.ToString())
        command.Parameters.AddWithValue("@p", tbxPhone.Text.ToString())
        command.Parameters.AddWithValue("@f", tbxFax.Text.ToString())
        command.Parameters.AddWithValue("@e", tbxMail.Text.ToString())
        command.Parameters.AddWithValue("@a", tbxAddress.Text.ToString())
        command.Parameters.AddWithValue("@w", LabelURL.Text.ToString())

        Dim result As Integer = command.ExecuteNonQuery()

        If result = -1 Then
            MsgBox("เกิดข้อผิดพลาด ไม่สามรถแก้ไขข้อมูลได้")
        Else
            MsgBox("แก้ไขข้อมูลแล้ว")
            BindingData()
        End If
    End Sub

    Private Sub BindingNavigatorAddDelete_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddDelete.Click
        Dim result As DialogResult = MessageBox.Show("ท่านต้องการลบข้อมูลหรือไม่?", "ยืนยันการลบ", MessageBoxButtons.OKCancel)

        If result = DialogResult.Cancel Then
            Exit Sub
        End If

        sql = "DELETE FROM Supplier WHERE SupplierId = @i"

        command.CommandText = sql
        command.Parameters.Clear()
        command.Parameters.AddWithValue("@i", tbxID.Text.ToString())

        If result = -1 Then
            MsgBox("เกิดข้อผิดพลาด ไม่สามรถลบข้อมูลได้")
        Else
            MsgBox("ลบข้อมูลแล้ว")
            BindingData()
        End If
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If String.IsNullOrEmpty(tbxSearch.Text) Then
            BindingData()
        End If

        sql = "SELECT * FROM Supplier WHERE Name LIKE '%' + @n + '%';"

        command.CommandText = sql
        command.Parameters.Clear()
        command.Parameters.AddWithValue("@n", tbxSearch.Text.ToString())

        BindingData()
    End Sub

    Private Sub LinkURL_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkURL.LinkClicked
        Dim website As String = InputBox("กรุณาใส่ URL ของเว็บไซต์")

        If website <> "http://" OrElse website <> "https://" OrElse website <> "" Then
            LabelURL.Text = website
        End If
    End Sub

    Private Sub tbxSearch_TextChanged(sender As Object, e As EventArgs) Handles tbxSearch.TextChanged
        sql = "SELECT ProductName, Price, Stock, Expire, Detail FROM Product WHERE SupplierId = @i"

        command.CommandText = sql
        command.Parameters.Clear()
        command.Parameters.AddWithValue("@i", tbxID.Text.ToString())

        adapter.SelectCommand = command

        dataSt = New DataSet

        Dim header() As String = {"ชื่อสินค้า", "ราคา", "คงเหลือ", "หมดอายุ", "รายละเอียด"}

        For index = 1 To header.Length - 1
            dvgListProduct.Columns(index).HeaderText = header(index)
        Next
    End Sub

    Private Sub createAutoComplete()
        sql = "SELECT Name FROM Supplier;"

        command.CommandText = sql

        reader = command.ExecuteReader()

        Dim autoComp As New AutoCompleteStringCollection()

        While reader.Read
            autoComp.Add(reader("Name"))
        End While

        reader.Close()

        tbxSearch.AutoCompleteMode = AutoCompleteMode.Suggest
        tbxSearch.AutoCompleteSource = AutoCompleteSource.CustomSource
        tbxSearch.AutoCompleteCustomSource = autoComp
    End Sub
End Class