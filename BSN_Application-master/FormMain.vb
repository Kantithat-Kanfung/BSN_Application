Public Class FormMain
    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is MdiClient Then
                ctrl.BackColor = Color.Gray
            End If
        Next
    End Sub

    Friend Sub ShowForm(ByVal f As Form, Optional multiForm As Boolean = False)
        If Not multiForm AndAlso Me.MdiChildren.Count <> 0 Then
            MsgBox("กรุณาปิดฟอร์มที่กำลังเปิดอยู่")
            Exit Sub
        End If

        f.MdiParent = Me
        f.StartPosition = FormStartPosition.CenterScreen
        f.Left = Me.Width / 2 - ToolStrip1.Width / 2 - f.Width / 2
        f.Top = 10
        f.Show()
    End Sub

    Private Sub tspBtnCustomer_Click(sender As Object, e As EventArgs) Handles tspBtnCustomer.Click
        ShowForm(frmCustomer)
    End Sub

    Private Sub tspBtnSupplier_Click(sender As Object, e As EventArgs) Handles tspBtnSupplier.Click
        ShowForm(frmSupplier)
    End Sub

    Private Sub tspBtnCategory_Click(sender As Object, e As EventArgs) Handles tspBtnCategory.Click
        ShowForm(frmCategory)
    End Sub

    Private Sub tspBtnProduct_Click(sender As Object, e As EventArgs) Handles tspBtnProduct.Click
        ShowForm(frmProduct)
    End Sub

    Private Sub tspBtnOrder_Click(sender As Object, e As EventArgs) Handles tspBtnOrder.Click

    End Sub

    Private Sub tspBtnPersonal_Click(sender As Object, e As EventArgs) Handles tspBtnPersonal.Click

    End Sub
End Class
