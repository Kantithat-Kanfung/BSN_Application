<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSupplier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSupplier))
        Me.dvgListProduct = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbxAddress = New System.Windows.Forms.TextBox()
        Me.tbxPhone = New System.Windows.Forms.TextBox()
        Me.tbxMail = New System.Windows.Forms.TextBox()
        Me.tbxName = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LabelURL = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LinkURL = New System.Windows.Forms.LinkLabel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbxFax = New System.Windows.Forms.TextBox()
        Me.tbxID = New System.Windows.Forms.TextBox()
        Me.BindingNavigatorAddDelete = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSave = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.tbxSearch = New System.Windows.Forms.TextBox()
        Me.LabelSearch = New System.Windows.Forms.Label()
        Me.LabelSupplier = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.dvgListProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dvgListProduct
        '
        Me.dvgListProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgListProduct.Location = New System.Drawing.Point(0, 284)
        Me.dvgListProduct.Name = "dvgListProduct"
        Me.dvgListProduct.Size = New System.Drawing.Size(584, 129)
        Me.dvgListProduct.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 162)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "เว็บไซต์"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(264, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "แฟกซ์"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "เบอร์โทรศัพท์"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "อีเมล์"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "ชื่อลูกค้า"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "รหัส"
        '
        'tbxAddress
        '
        Me.tbxAddress.Location = New System.Drawing.Point(311, 53)
        Me.tbxAddress.Multiline = True
        Me.tbxAddress.Name = "tbxAddress"
        Me.tbxAddress.Size = New System.Drawing.Size(251, 93)
        Me.tbxAddress.TabIndex = 8
        '
        'tbxPhone
        '
        Me.tbxPhone.Location = New System.Drawing.Point(90, 126)
        Me.tbxPhone.Name = "tbxPhone"
        Me.tbxPhone.Size = New System.Drawing.Size(148, 20)
        Me.tbxPhone.TabIndex = 7
        '
        'tbxMail
        '
        Me.tbxMail.Location = New System.Drawing.Point(90, 90)
        Me.tbxMail.Name = "tbxMail"
        Me.tbxMail.Size = New System.Drawing.Size(148, 20)
        Me.tbxMail.TabIndex = 6
        '
        'tbxName
        '
        Me.tbxName.Location = New System.Drawing.Point(90, 53)
        Me.tbxName.Name = "tbxName"
        Me.tbxName.Size = New System.Drawing.Size(148, 20)
        Me.tbxName.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.LabelURL)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.LinkURL)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.tbxAddress)
        Me.Panel2.Controls.Add(Me.tbxPhone)
        Me.Panel2.Controls.Add(Me.tbxMail)
        Me.Panel2.Controls.Add(Me.tbxName)
        Me.Panel2.Controls.Add(Me.tbxFax)
        Me.Panel2.Controls.Add(Me.tbxID)
        Me.Panel2.Location = New System.Drawing.Point(0, 78)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(584, 214)
        Me.Panel2.TabIndex = 8
        '
        'LabelURL
        '
        Me.LabelURL.AutoSize = True
        Me.LabelURL.Location = New System.Drawing.Point(87, 162)
        Me.LabelURL.Name = "LabelURL"
        Me.LabelURL.Size = New System.Drawing.Size(45, 13)
        Me.LabelURL.TabIndex = 17
        Me.LabelURL.Text = "เว็บไซต์"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(264, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "ที่อยู่"
        '
        'LinkURL
        '
        Me.LinkURL.AutoSize = True
        Me.LinkURL.Location = New System.Drawing.Point(483, 162)
        Me.LinkURL.Name = "LinkURL"
        Me.LinkURL.Size = New System.Drawing.Size(79, 13)
        Me.LinkURL.TabIndex = 15
        Me.LinkURL.TabStop = True
        Me.LinkURL.Text = "กำหนดเว็บไซต์"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 190)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "รายการสินค้า"
        '
        'tbxFax
        '
        Me.tbxFax.Location = New System.Drawing.Point(311, 17)
        Me.tbxFax.Name = "tbxFax"
        Me.tbxFax.Size = New System.Drawing.Size(148, 20)
        Me.tbxFax.TabIndex = 4
        '
        'tbxID
        '
        Me.tbxID.Location = New System.Drawing.Point(90, 17)
        Me.tbxID.Name = "tbxID"
        Me.tbxID.Size = New System.Drawing.Size(148, 20)
        Me.tbxID.TabIndex = 4
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
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 42)
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
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 42)
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
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 42)
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
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 39)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
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
        Me.BindingNavigator1.TabIndex = 7
        Me.BindingNavigator1.Text = "BindingNavigator1"
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
        Me.LabelSupplier.Size = New System.Drawing.Size(222, 25)
        Me.LabelSupplier.TabIndex = 0
        Me.LabelSupplier.Text = "Supplier Management"
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
        Me.Panel1.TabIndex = 6
        '
        'frmSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 412)
        Me.Controls.Add(Me.dvgListProduct)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmSupplier"
        Me.Text = "frmSupplier"
        CType(Me.dvgListProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dvgListProduct As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbxAddress As TextBox
    Friend WithEvents tbxPhone As TextBox
    Friend WithEvents tbxMail As TextBox
    Friend WithEvents tbxName As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents tbxID As TextBox
    Friend WithEvents BindingNavigatorAddDelete As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorSave As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents btnOk As Button
    Friend WithEvents tbxSearch As TextBox
    Friend WithEvents LabelSearch As Label
    Friend WithEvents LabelSupplier As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LinkURL As LinkLabel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents tbxFax As TextBox
    Friend WithEvents LabelURL As Label
End Class
