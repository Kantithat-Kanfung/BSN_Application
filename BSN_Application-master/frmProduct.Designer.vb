<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProduct
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProduct))
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSave = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorAddDelete = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbxDetail = New System.Windows.Forms.TextBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.tbxSearch = New System.Windows.Forms.TextBox()
        Me.LabelSearch = New System.Windows.Forms.Label()
        Me.LabelSupplier = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.tbxName = New System.Windows.Forms.TextBox()
        Me.tbxID = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbLinkSelectPicture = New System.Windows.Forms.LinkLabel()
        Me.picBox = New System.Windows.Forms.PictureBox()
        Me.dtpEexpired = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbxSupplier = New System.Windows.Forms.ComboBox()
        Me.cbxCategory = New System.Windows.Forms.ComboBox()
        Me.tbxStock = New System.Windows.Forms.TextBox()
        Me.tbxPrice = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.picBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 42)
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 39)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 39)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorSave
        '
        Me.BindingNavigatorSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorSave.Image = CType(resources.GetObject("BindingNavigatorSave.Image"), System.Drawing.Image)
        Me.BindingNavigatorSave.Name = "BindingNavigatorSave"
        Me.BindingNavigatorSave.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorSave.Size = New System.Drawing.Size(23, 39)
        Me.BindingNavigatorSave.Text = "Delete"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 39)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 42)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 42)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 39)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 39)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorAddDelete
        '
        Me.BindingNavigatorAddDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddDelete.Image = CType(resources.GetObject("BindingNavigatorAddDelete.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddDelete.Name = "BindingNavigatorAddDelete"
        Me.BindingNavigatorAddDelete.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddDelete.Size = New System.Drawing.Size(23, 39)
        Me.BindingNavigatorAddDelete.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 39)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(269, 207)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "รายละเอียด"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "หมวดหมู่"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "รหัส"
        '
        'tbxDetail
        '
        Me.tbxDetail.Location = New System.Drawing.Point(336, 214)
        Me.tbxDetail.Multiline = True
        Me.tbxDetail.Name = "tbxDetail"
        Me.tbxDetail.Size = New System.Drawing.Size(219, 93)
        Me.tbxDetail.TabIndex = 8
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(526, 13)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(46, 23)
        Me.btnOk.TabIndex = 3
        Me.btnOk.Text = "ตกลง"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'tbxSearch
        '
        Me.tbxSearch.Location = New System.Drawing.Point(386, 16)
        Me.tbxSearch.Name = "tbxSearch"
        Me.tbxSearch.ReadOnly = True
        Me.tbxSearch.Size = New System.Drawing.Size(133, 20)
        Me.tbxSearch.TabIndex = 2
        '
        'LabelSearch
        '
        Me.LabelSearch.AutoSize = True
        Me.LabelSearch.Location = New System.Drawing.Point(333, 19)
        Me.LabelSearch.Name = "LabelSearch"
        Me.LabelSearch.Size = New System.Drawing.Size(47, 13)
        Me.LabelSearch.TabIndex = 1
        Me.LabelSearch.Text = "ค้นหาชื่อ"
        '
        'LabelSupplier
        '
        Me.LabelSupplier.AutoSize = True
        Me.LabelSupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSupplier.Location = New System.Drawing.Point(3, 10)
        Me.LabelSupplier.Name = "LabelSupplier"
        Me.LabelSupplier.Size = New System.Drawing.Size(217, 25)
        Me.LabelSupplier.TabIndex = 0
        Me.LabelSupplier.Text = "Product Management"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnOk)
        Me.Panel1.Controls.Add(Me.tbxSearch)
        Me.Panel1.Controls.Add(Me.LabelSearch)
        Me.Panel1.Controls.Add(Me.LabelSupplier)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(584, 48)
        Me.Panel1.TabIndex = 18
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.AutoSize = False
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorSave
        Me.BindingNavigator1.Dock = System.Windows.Forms.DockStyle.None
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorAddDelete, Me.BindingNavigatorSave})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 39)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(584, 42)
        Me.BindingNavigator1.TabIndex = 19
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'tbxName
        '
        Me.tbxName.Location = New System.Drawing.Point(90, 89)
        Me.tbxName.Name = "tbxName"
        Me.tbxName.Size = New System.Drawing.Size(148, 20)
        Me.tbxName.TabIndex = 5
        '
        'tbxID
        '
        Me.tbxID.Location = New System.Drawing.Point(90, 53)
        Me.tbxID.Name = "tbxID"
        Me.tbxID.Size = New System.Drawing.Size(148, 20)
        Me.tbxID.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.lbLinkSelectPicture)
        Me.Panel2.Controls.Add(Me.picBox)
        Me.Panel2.Controls.Add(Me.dtpEexpired)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.cbxSupplier)
        Me.Panel2.Controls.Add(Me.cbxCategory)
        Me.Panel2.Controls.Add(Me.tbxStock)
        Me.Panel2.Controls.Add(Me.tbxPrice)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.tbxDetail)
        Me.Panel2.Controls.Add(Me.tbxName)
        Me.Panel2.Controls.Add(Me.tbxID)
        Me.Panel2.Location = New System.Drawing.Point(0, 78)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(584, 335)
        Me.Panel2.TabIndex = 20
        '
        'lbLinkSelectPicture
        '
        Me.lbLinkSelectPicture.AutoSize = True
        Me.lbLinkSelectPicture.Location = New System.Drawing.Point(495, 189)
        Me.lbLinkSelectPicture.Name = "lbLinkSelectPicture"
        Me.lbLinkSelectPicture.Size = New System.Drawing.Size(51, 13)
        Me.lbLinkSelectPicture.TabIndex = 24
        Me.lbLinkSelectPicture.TabStop = True
        Me.lbLinkSelectPicture.Text = "เลือกภาพ"
        '
        'picBox
        '
        Me.picBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picBox.Location = New System.Drawing.Point(360, 17)
        Me.picBox.Name = "picBox"
        Me.picBox.Size = New System.Drawing.Size(159, 165)
        Me.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBox.TabIndex = 23
        Me.picBox.TabStop = False
        '
        'dtpEexpired
        '
        Me.dtpEexpired.Location = New System.Drawing.Point(90, 241)
        Me.dtpEexpired.Name = "dtpEexpired"
        Me.dtpEexpired.Size = New System.Drawing.Size(148, 20)
        Me.dtpEexpired.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 241)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "หมดอายุ"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 207)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "ผู้จัดส่ง"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "คงเหลือ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "ราคา"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "ชื่อสินค้า"
        '
        'cbxSupplier
        '
        Me.cbxSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxSupplier.FormattingEnabled = True
        Me.cbxSupplier.Location = New System.Drawing.Point(90, 207)
        Me.cbxSupplier.Name = "cbxSupplier"
        Me.cbxSupplier.Size = New System.Drawing.Size(148, 21)
        Me.cbxSupplier.TabIndex = 20
        '
        'cbxCategory
        '
        Me.cbxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCategory.FormattingEnabled = True
        Me.cbxCategory.Location = New System.Drawing.Point(90, 17)
        Me.cbxCategory.Name = "cbxCategory"
        Me.cbxCategory.Size = New System.Drawing.Size(148, 21)
        Me.cbxCategory.TabIndex = 20
        '
        'tbxStock
        '
        Me.tbxStock.Location = New System.Drawing.Point(90, 169)
        Me.tbxStock.Name = "tbxStock"
        Me.tbxStock.Size = New System.Drawing.Size(148, 20)
        Me.tbxStock.TabIndex = 18
        '
        'tbxPrice
        '
        Me.tbxPrice.Location = New System.Drawing.Point(90, 128)
        Me.tbxPrice.Name = "tbxPrice"
        Me.tbxPrice.Size = New System.Drawing.Size(148, 20)
        Me.tbxPrice.TabIndex = 17
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 412)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmProduct"
        Me.Text = "frmProduct"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.picBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorSave As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorAddDelete As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbxDetail As TextBox
    Friend WithEvents btnOk As Button
    Friend WithEvents tbxSearch As TextBox
    Friend WithEvents LabelSearch As Label
    Friend WithEvents LabelSupplier As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents tbxName As TextBox
    Friend WithEvents tbxID As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dtpEexpired As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbxSupplier As ComboBox
    Friend WithEvents cbxCategory As ComboBox
    Friend WithEvents tbxStock As TextBox
    Friend WithEvents tbxPrice As TextBox
    Friend WithEvents lbLinkSelectPicture As LinkLabel
    Friend WithEvents picBox As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
