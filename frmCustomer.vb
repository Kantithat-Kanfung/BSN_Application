Imports System.Data
Imports System.Data.SqlClient

Public Class frmCustomer
    Private Sub frmCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        BindingNavigator1.DeleteItem = Nothing
        BindingData()
    End Sub

    Private Sub BindingData(Optional cmd As SqlCommand = Nothing)
        Dim tbx As TextBox

        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                tbx = CType(ctrl, TextBox)
                tbx.DataBindings.Clear()
                tbx.Text = ""
            End If
        Next

        If cmd Is Nothing Then
            command.CommandText = "SELECT * FROM Customer;"
        Else
            command = cmd
        End If

        adapter = New SqlDataAdapter(command)
        dataSt = New DataSet
        adapter.Fill(dataSt, "customer")

        bindingSrc = New BindingSource(dataSt, "customer")
        tbxID.DataBindings.Add("text", bindingSrc, "CustomerId")
        tbxName.DataBindings.Add("text", bindingSrc, "Name")
        tbxPhone.DataBindings.Add("text", bindingSrc, "Phone")
        tbxMail.DataBindings.Add("text", bindingSrc, "Email")
        tbxAddress.DataBindings.Add("text", bindingSrc, "Address")
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
        sql = "INSERT INTO Customer(Name, Phone, Email, Address) VALUES(@n, @p, @e, @a)"

        command.CommandText = sql
        command.Parameters.Clear()
        command.Parameters.AddWithValue("@n", tbxName.Text.ToString())
        command.Parameters.AddWithValue("@p", tbxPhone.Text.ToString())
        command.Parameters.AddWithValue("@e", tbxMail.Text.ToString())
        command.Parameters.AddWithValue("@a", tbxAddress.Text.ToString())

        Dim result As Integer = command.ExecuteNonQuery()

        If result = -1 Then
            MsgBox("เกิดข้อผิดพลาด ไม่สามรถเพิ่มข้อมูลได้")
        Else
            MsgBox("บันทึกข้อมูลแล้ว")
            BindingData()
        End If
    End Sub

    Private Sub updateData()
        sql = "UPDATE Customer SET Name = @n, Phone = @p, Email = @e, Address = @a WHERE CustomerId = @i;"

        command.CommandText = sql
        command.Parameters.Clear()
        command.Parameters.AddWithValue("@n", tbxName.Text.ToString())
        command.Parameters.AddWithValue("@p", tbxPhone.Text.ToString())
        command.Parameters.AddWithValue("@e", tbxMail.Text.ToString())
        command.Parameters.AddWithValue("@a", tbxAddress.Text.ToString())
        command.Parameters.AddWithValue("@i", tbxID.Text.ToString())

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

        sql = "DELETE FROM Customer WHERE CustomerId = @i"

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

    Private Sub createAutoComplete()
        sql = "DELETE FROM Customer WHERE CustomerId = @i"

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

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If String.IsNullOrEmpty(tbxSearch.Text) Then
            BindingData()
        End If

        sql = "SELECT * FROM Customer WHERE LIKE '%' + @n + '%';"

        command.CommandText = sql
        command.Parameters.Clear()
        command.Parameters.AddWithValue("@n", tbxSearch.Text.ToString())

        BindingData()
    End Sub

    Private Sub tbxSearch_TextChanged(sender As Object, e As EventArgs) Handles tbxSearch.TextChanged
        sql = "SELECT Order, Payment, Delivery, Note FROM Orders WHERE CustomerId = @i"

        command.CommandText = sql
        command.Parameters.Clear()
        command.Parameters.AddWithValue("@i", tbxID.Text.ToString())

        adapter.SelectCommand = command

        dataSt = New DataSet

        'adapter.Fill(dataSt, "CustomerDataGridView")
        'dvgHistoryOrder.DataSource = dataSt.Tables("CustomerDataGridView")

        Dim header() As String = {"วันที่", "การชำระเงิน", "การจัดส่ง", "หมายเหตุ"}

        For index = 1 To header.Length - 1
            dvgHistoryOrder.Columns(index).HeaderText = header(index)
        Next
    End Sub
End Class