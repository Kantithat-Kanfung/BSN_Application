<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tspBtnCustomer = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabelCustomer = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tspBtnSupplier = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabelSupplier = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tspBtnCategory = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabelCategory = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tspBtnProduct = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabelProduct = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tspBtnOrder = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabelOrder = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tspBtnPersonal = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabelPersonal = New System.Windows.Forms.ToolStripLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ManagementToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(784, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ManagementToolStripMenuItem
        '
        Me.ManagementToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerToolStripMenuItem, Me.SupplierToolStripMenuItem, Me.CategoryToolStripMenuItem, Me.ProductToolStripMenuItem, Me.OrderToolStripMenuItem, Me.PersonalToolStripMenuItem})
        Me.ManagementToolStripMenuItem.Name = "ManagementToolStripMenuItem"
        Me.ManagementToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.ManagementToolStripMenuItem.Text = "Management"
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.Image = CType(resources.GetObject("CustomerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.CustomerToolStripMenuItem.Text = "Customer"
        '
        'SupplierToolStripMenuItem
        '
        Me.SupplierToolStripMenuItem.Image = CType(resources.GetObject("SupplierToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SupplierToolStripMenuItem.Name = "SupplierToolStripMenuItem"
        Me.SupplierToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.SupplierToolStripMenuItem.Text = "Supplier"
        '
        'CategoryToolStripMenuItem
        '
        Me.CategoryToolStripMenuItem.Image = CType(resources.GetObject("CategoryToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CategoryToolStripMenuItem.Name = "CategoryToolStripMenuItem"
        Me.CategoryToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.CategoryToolStripMenuItem.Text = "Category"
        '
        'ProductToolStripMenuItem
        '
        Me.ProductToolStripMenuItem.Image = CType(resources.GetObject("ProductToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ProductToolStripMenuItem.Name = "ProductToolStripMenuItem"
        Me.ProductToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.ProductToolStripMenuItem.Text = "Product"
        '
        'OrderToolStripMenuItem
        '
        Me.OrderToolStripMenuItem.Image = CType(resources.GetObject("OrderToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OrderToolStripMenuItem.Name = "OrderToolStripMenuItem"
        Me.OrderToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.OrderToolStripMenuItem.Text = "Order"
        '
        'PersonalToolStripMenuItem
        '
        Me.PersonalToolStripMenuItem.Image = CType(resources.GetObject("PersonalToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PersonalToolStripMenuItem.Name = "PersonalToolStripMenuItem"
        Me.PersonalToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.PersonalToolStripMenuItem.Text = "Personal"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 580)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(784, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tspBtnCustomer, Me.ToolStripLabelCustomer, Me.ToolStripSeparator1, Me.tspBtnSupplier, Me.ToolStripLabelSupplier, Me.ToolStripSeparator2, Me.tspBtnCategory, Me.ToolStripLabelCategory, Me.ToolStripSeparator3, Me.tspBtnProduct, Me.ToolStripLabelProduct, Me.ToolStripSeparator4, Me.tspBtnOrder, Me.ToolStripLabelOrder, Me.ToolStripSeparator5, Me.tspBtnPersonal, Me.ToolStripLabelPersonal})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(111, 556)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tspBtnCustomer
        '
        Me.tspBtnCustomer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tspBtnCustomer.Image = CType(resources.GetObject("tspBtnCustomer.Image"), System.Drawing.Image)
        Me.tspBtnCustomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tspBtnCustomer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tspBtnCustomer.Name = "tspBtnCustomer"
        Me.tspBtnCustomer.Size = New System.Drawing.Size(109, 68)
        Me.tspBtnCustomer.Text = "ToolStripButton1"
        '
        'ToolStripLabelCustomer
        '
        Me.ToolStripLabelCustomer.Name = "ToolStripLabelCustomer"
        Me.ToolStripLabelCustomer.Size = New System.Drawing.Size(109, 15)
        Me.ToolStripLabelCustomer.Text = "Customer"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(109, 6)
        '
        'tspBtnSupplier
        '
        Me.tspBtnSupplier.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tspBtnSupplier.Image = CType(resources.GetObject("tspBtnSupplier.Image"), System.Drawing.Image)
        Me.tspBtnSupplier.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tspBtnSupplier.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tspBtnSupplier.Name = "tspBtnSupplier"
        Me.tspBtnSupplier.Size = New System.Drawing.Size(109, 68)
        Me.tspBtnSupplier.Text = "ToolStripButton2"
        '
        'ToolStripLabelSupplier
        '
        Me.ToolStripLabelSupplier.Name = "ToolStripLabelSupplier"
        Me.ToolStripLabelSupplier.Size = New System.Drawing.Size(109, 15)
        Me.ToolStripLabelSupplier.Text = "Supplier"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(109, 6)
        '
        'tspBtnCategory
        '
        Me.tspBtnCategory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tspBtnCategory.Image = CType(resources.GetObject("tspBtnCategory.Image"), System.Drawing.Image)
        Me.tspBtnCategory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tspBtnCategory.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tspBtnCategory.Name = "tspBtnCategory"
        Me.tspBtnCategory.Size = New System.Drawing.Size(109, 52)
        '
        'ToolStripLabelCategory
        '
        Me.ToolStripLabelCategory.Name = "ToolStripLabelCategory"
        Me.ToolStripLabelCategory.Size = New System.Drawing.Size(109, 15)
        Me.ToolStripLabelCategory.Text = "Category"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(109, 6)
        '
        'tspBtnProduct
        '
        Me.tspBtnProduct.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tspBtnProduct.Image = CType(resources.GetObject("tspBtnProduct.Image"), System.Drawing.Image)
        Me.tspBtnProduct.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tspBtnProduct.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tspBtnProduct.Name = "tspBtnProduct"
        Me.tspBtnProduct.Size = New System.Drawing.Size(109, 68)
        '
        'ToolStripLabelProduct
        '
        Me.ToolStripLabelProduct.Name = "ToolStripLabelProduct"
        Me.ToolStripLabelProduct.Size = New System.Drawing.Size(109, 15)
        Me.ToolStripLabelProduct.Text = "Product"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(109, 6)
        '
        'tspBtnOrder
        '
        Me.tspBtnOrder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tspBtnOrder.Image = CType(resources.GetObject("tspBtnOrder.Image"), System.Drawing.Image)
        Me.tspBtnOrder.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tspBtnOrder.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tspBtnOrder.Name = "tspBtnOrder"
        Me.tspBtnOrder.Size = New System.Drawing.Size(109, 52)
        '
        'ToolStripLabelOrder
        '
        Me.ToolStripLabelOrder.Name = "ToolStripLabelOrder"
        Me.ToolStripLabelOrder.Size = New System.Drawing.Size(109, 15)
        Me.ToolStripLabelOrder.Text = "Order"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(109, 6)
        '
        'tspBtnPersonal
        '
        Me.tspBtnPersonal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tspBtnPersonal.Image = CType(resources.GetObject("tspBtnPersonal.Image"), System.Drawing.Image)
        Me.tspBtnPersonal.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tspBtnPersonal.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tspBtnPersonal.Name = "tspBtnPersonal"
        Me.tspBtnPersonal.Size = New System.Drawing.Size(109, 68)
        '
        'ToolStripLabelPersonal
        '
        Me.ToolStripLabelPersonal.Name = "ToolStripLabelPersonal"
        Me.ToolStripLabelPersonal.Size = New System.Drawing.Size(52, 15)
        Me.ToolStripLabelPersonal.Text = "Personal"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(784, 602)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BSN Application"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tspBtnCustomer As ToolStripButton
    Friend WithEvents ToolStripLabelCustomer As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tspBtnSupplier As ToolStripButton
    Friend WithEvents ToolStripLabelSupplier As ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tspBtnCategory As ToolStripButton
    Friend WithEvents ToolStripLabelCategory As ToolStripLabel
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents tspBtnProduct As ToolStripButton
    Friend WithEvents ToolStripLabelProduct As ToolStripLabel
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents tspBtnOrder As ToolStripButton
    Friend WithEvents ToolStripLabelOrder As ToolStripLabel
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents tspBtnPersonal As ToolStripButton
    Friend WithEvents ToolStripLabelPersonal As ToolStripLabel
    Friend WithEvents CustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SupplierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CategoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PersonalToolStripMenuItem As ToolStripMenuItem
End Class
