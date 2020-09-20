Imports System.Data
Imports System.Data.SqlClient

Public Class frmProduct
    Private Sub frmProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        BindingNavigator1.DeleteItem = Nothing
        BindingData()
    End Sub

    Private Sub BindingData(ByVal Optional cmd As SqlCommand = Nothing)
        Dim tbx As New TextBox
        Dim pbx As New PictureBox
        Dim dtp As New DateTimePicker
        Dim cbx As New ComboBox

        For Each ctrl As Control In Controls
            If TypeOf ctrl Is TextBox Then
                tbx = CType(ctrl, TextBox)
                tbx.DataBindings.Clear()
                tbx.Text = ""
            End If
            If TypeOf ctrl Is PictureBox Then
                pbx = CType(ctrl, PictureBox)
                pbx.DataBindings.Clear()
                pbx.Image = Nothing
            End If
            If TypeOf ctrl Is DateTimePicker Then
                dtp = CType(ctrl, DateTimePicker)
                dtp.DataBindings.Clear()
                dtp.Value = DateTime.Now
            End If
            If TypeOf ctrl Is ComboBox Then
                cbx = CType(ctrl, ComboBox)
                cbx.DataBindings.Clear()
                IIf(cbx.Items.Count > 0, cbx.SelectedItem = 0, Nothing)
            End If
        Next

        If cmd Is Nothing Then
            command.CommandText = "SELECT * FROM Product;"
        Else
            command = cmd
        End If

        adapter = New SqlDataAdapter(command)
        dataSt = New DataSet
        adapter.Fill(dataSt, "Product")

        bindingSrc = New BindingSource(dataSt, "Product")
        tbxID.DataBindings.Add("Text", bindingSrc, "ProductId")
        tbxName.DataBindings.Add("Text", bindingSrc, "Name")
        tbxPrice.DataBindings.Add("Text", bindingSrc, "Price")
        tbxStock.DataBindings.Add("Text", bindingSrc, "Stock")
        dtp.DataBindings.Add("Text", bindingSrc, "Expire")
        pbx.DataBindings.Add("Image", bindingSrc, "Picture", True)

        'Complex Binding for Category
        command.CommandText = "SELECT CategoryId, Name FROM Category;"
        adapter.SelectCommand = command
        adapter.Fill(dataSt, "Category")
        cbx.DataSource = dataSt.Tables("Category")
        cbx.DisplayMember = "Name"
        cbx.ValueMember = "CategoryId"
        cbx.DataBindings.Add("SelectValue", bindingSrc, "CatgoryId")

        'Complex Binding for Supplier
        command.CommandText = "SELECT SupplierId, Name FROM Supplier;"
        adapter.SelectCommand = command
        adapter.Fill(dataSt, "Supplier")
        cbx.DataSource = dataSt.Tables("Supplier")
        cbx.DisplayMember = "Name"
        cbx.ValueMember = "SupplierId"
        cbx.DataBindings.Add("SelectValue", bindingSrc, "SupplierId")

        BindingNavigator1.BindingSource = bindingSrc
        createAutoComplete()
    End Sub


    Private Sub createAutoComplete()
        sql = "SELECT Name FROM Product;"

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

    Private Sub lbLinkSelectPicture_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbLinkSelectPicture.LinkClicked
        OpenFileDialog1.Filter = "Image File(*.jpg, *.png, *.gif, *.bmp)|*.jpgl*.png;*.gif;*.bmp"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            picBox.Image = Bitmap.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub BindingNavigatorSave_Click(sender As Object, e As EventArgs) Handles BindingNavigatorSave.Click
        If tbxID.Text = "" Then
            insertData()
        Else
            updateData()
        End If
    End Sub

    Private Sub insertData()
        sql = "INSERT INTO Product(CategoryId, SupplierId, Name, Price, Stock, Detail, Expire, Picture) 
                VALUES(@cid, @sid, @n, @p, @s, @d, @e, @pic);"

        command.CommandText = sql
        command.Parameters.Clear()
        command.Parameters.AddWithValue("@cid", cbxCategory.SelectedValue.ToString())
        command.Parameters.AddWithValue("@sid", cbxSupplier.SelectedValue.ToString())
        command.Parameters.AddWithValue("@n", tbxName.Text.ToString())
        command.Parameters.AddWithValue("@p", tbxPrice.Text.ToString())
        command.Parameters.AddWithValue("@s", tbxStock.Text.ToString())
        command.Parameters.AddWithValue("@d", tbxDetail.Text.ToString())

        Dim dateStr = $"{dtpEexpired.Value.Year}/{dtpEexpired.Value.Month}/{dtpEexpired.Value.Day}"
        command.Parameters.AddWithValue("@e", dataSt.ToString())

        If Not (picBox.Image Is Nothing) Then
            Dim pic() As Byte = readImage()
            command.Parameters.AddWithValue("@pic", pic)
        Else
            command.Parameters.AddWithValue("@pic", DBNull.Value)
        End If

        Dim result As Integer = command.ExecuteNonQuery()

        If result = -1 Then
            MsgBox("เกิดข้อผิดพลาด ไม่สามรถเพิ่มข้อมูลได้")
        Else
            MsgBox("บันทึกข้อมูลแล้ว")
            BindingData()
        End If
    End Sub

    Private Sub updateData()
        sql = "UPDATE Category SET CatgoryId = @cid, 
                                    SupplierId = @sid, 
                                    Name = @n, 
                                    Price = @p, 
                                    Stock = @s, 
                                    Detail = @d, 
                                    Expire = @e, 
                                    Picture = @pic
                WHERE
                    ProductId = @i"

        command.CommandText = sql
        command.Parameters.Clear()
        command.Parameters.AddWithValue("@i", tbxID.Text.ToString())
        command.Parameters.AddWithValue("@cid", cbxCategory.SelectedValue.ToString())
        command.Parameters.AddWithValue("@sid", cbxSupplier.SelectedValue.ToString())
        command.Parameters.AddWithValue("@n", tbxName.Text.ToString())
        command.Parameters.AddWithValue("@p", tbxPrice.Text.ToString())
        command.Parameters.AddWithValue("@s", tbxStock.Text.ToString())
        command.Parameters.AddWithValue("@d", tbxDetail.Text.ToString())

        Dim dateStr = $"{dtpEexpired.Value.Year}/{dtpEexpired.Value.Month}/{dtpEexpired.Value.Day}"
        command.Parameters.AddWithValue("@e", dataSt.ToString())

        If Not (picBox.Image Is Nothing) Then
            Dim pic() As Byte = readImage()
            command.Parameters.AddWithValue("@pic", pic)
        Else
            command.Parameters.AddWithValue("@pic", DBNull.Value)
        End If

        Dim result As Integer = command.ExecuteNonQuery()

        If result = -1 Then
            MsgBox("เกิดข้อผิดพลาด ไม่สามรถแก้ไขข้อมูลได้")
        Else
            MsgBox("แก้ไขข้อมูลแล้ว")
            BindingData()
        End If
    End Sub

    Private Function readImage() As Byte()
        Dim memStream As New IO.MemoryStream
        picBox.Image.Save(memStream, picBox.Image.RawFormat)
        Return memStream.ToArray()
    End Function

    Private Sub BindingNavigatorAddDelete_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddDelete.Click
        Dim result As DialogResult = MessageBox.Show("ท่านต้องการลบข้อมูลหรือไม่?", "ยืนยันการลบ", MessageBoxButtons.OKCancel)

        If result = DialogResult.Cancel Then
            Exit Sub
        End If

        sql = "DELETE FROM Product WHERE ProductId = @i"

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

        sql = "SELECT * FROM Product WHERE Name LIKE '%' + @n + '%';"

        command.CommandText = sql
        command.Parameters.Clear()
        command.Parameters.AddWithValue("@n", tbxSearch.Text.ToString())

        BindingData()
    End Sub

End Class