<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuUtama2
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PTrx = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.PMaster = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PDash = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btTransaksi = New System.Windows.Forms.Button()
        Me.btMaster = New System.Windows.Forms.Button()
        Me.btDash = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.UPenjualan1 = New PenjualanSQL.UPenjualan()
        Me.UBarang1 = New PenjualanSQL.UBarang()
        Me.UCustomer1 = New PenjualanSQL.UCustomer()
        Me.USupplier1 = New PenjualanSQL.USupplier()
        Me.UDash2 = New PenjualanSQL.UDash()
        Me.UDash1 = New PenjualanSQL.UDash()
        Me.UPembelian1 = New PenjualanSQL.UPembelian()
        Me.Panel1.SuspendLayout()
        Me.PTrx.SuspendLayout()
        Me.PMaster.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.PDash.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PTrx)
        Me.Panel1.Controls.Add(Me.btTransaksi)
        Me.Panel1.Controls.Add(Me.PMaster)
        Me.Panel1.Controls.Add(Me.btMaster)
        Me.Panel1.Controls.Add(Me.PDash)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 800)
        Me.Panel1.TabIndex = 0
        '
        'PTrx
        '
        Me.PTrx.Controls.Add(Me.Panel8)
        Me.PTrx.Controls.Add(Me.Button13)
        Me.PTrx.Controls.Add(Me.Button14)
        Me.PTrx.Dock = System.Windows.Forms.DockStyle.Top
        Me.PTrx.Location = New System.Drawing.Point(0, 420)
        Me.PTrx.Name = "PTrx"
        Me.PTrx.Size = New System.Drawing.Size(200, 100)
        Me.PTrx.TabIndex = 11
        '
        'Panel8
        '
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 100)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(200, 150)
        Me.Panel8.TabIndex = 10
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Button13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button13.FlatAppearance.BorderSize = 0
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button13.Location = New System.Drawing.Point(0, 50)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(200, 50)
        Me.Button13.TabIndex = 7
        Me.Button13.Text = "Penjualan"
        Me.Button13.UseVisualStyleBackColor = False
        '
        'Button14
        '
        Me.Button14.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Button14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button14.FlatAppearance.BorderSize = 0
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button14.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button14.Location = New System.Drawing.Point(0, 0)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(200, 50)
        Me.Button14.TabIndex = 6
        Me.Button14.Text = "Pembelian"
        Me.Button14.UseVisualStyleBackColor = False
        '
        'PMaster
        '
        Me.PMaster.Controls.Add(Me.Panel4)
        Me.PMaster.Controls.Add(Me.Button1)
        Me.PMaster.Controls.Add(Me.Button4)
        Me.PMaster.Controls.Add(Me.Button3)
        Me.PMaster.Dock = System.Windows.Forms.DockStyle.Top
        Me.PMaster.Location = New System.Drawing.Point(0, 220)
        Me.PMaster.Name = "PMaster"
        Me.PMaster.Size = New System.Drawing.Size(200, 150)
        Me.PMaster.TabIndex = 9
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Button6)
        Me.Panel4.Controls.Add(Me.Button7)
        Me.Panel4.Controls.Add(Me.Button8)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 150)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(200, 150)
        Me.Panel4.TabIndex = 10
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Button6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(0, 100)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(200, 50)
        Me.Button6.TabIndex = 8
        Me.Button6.Text = "Stock"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Button7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(0, 50)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(200, 50)
        Me.Button7.TabIndex = 7
        Me.Button7.Text = "Customer"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Button8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.Location = New System.Drawing.Point(0, 0)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(200, 50)
        Me.Button8.TabIndex = 6
        Me.Button8.Text = "Supplier"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(0, 100)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(200, 50)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Barang"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(0, 50)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(200, 50)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Customer"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(0, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(200, 50)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Supplier"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'PDash
        '
        Me.PDash.Controls.Add(Me.btDash)
        Me.PDash.Dock = System.Windows.Forms.DockStyle.Top
        Me.PDash.Location = New System.Drawing.Point(0, 120)
        Me.PDash.Name = "PDash"
        Me.PDash.Size = New System.Drawing.Size(200, 50)
        Me.PDash.TabIndex = 7
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 109)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(200, 11)
        Me.Panel6.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 30)
        Me.Panel2.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(200, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1082, 30)
        Me.Panel3.TabIndex = 1
        '
        'btTransaksi
        '
        Me.btTransaksi.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.btTransaksi.Dock = System.Windows.Forms.DockStyle.Top
        Me.btTransaksi.FlatAppearance.BorderSize = 0
        Me.btTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btTransaksi.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btTransaksi.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btTransaksi.Image = Global.PenjualanSQL.My.Resources.Resources.icons8_add_shopping_cart_32
        Me.btTransaksi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btTransaksi.Location = New System.Drawing.Point(0, 370)
        Me.btTransaksi.Name = "btTransaksi"
        Me.btTransaksi.Size = New System.Drawing.Size(200, 50)
        Me.btTransaksi.TabIndex = 10
        Me.btTransaksi.Text = "Transaksi"
        Me.btTransaksi.UseVisualStyleBackColor = False
        '
        'btMaster
        '
        Me.btMaster.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.btMaster.Dock = System.Windows.Forms.DockStyle.Top
        Me.btMaster.FlatAppearance.BorderSize = 0
        Me.btMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btMaster.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btMaster.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btMaster.Image = Global.PenjualanSQL.My.Resources.Resources.icons8_product_32
        Me.btMaster.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btMaster.Location = New System.Drawing.Point(0, 170)
        Me.btMaster.Name = "btMaster"
        Me.btMaster.Size = New System.Drawing.Size(200, 50)
        Me.btMaster.TabIndex = 8
        Me.btMaster.Text = "Master"
        Me.btMaster.UseVisualStyleBackColor = False
        '
        'btDash
        '
        Me.btDash.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.btDash.Dock = System.Windows.Forms.DockStyle.Top
        Me.btDash.FlatAppearance.BorderSize = 0
        Me.btDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btDash.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btDash.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btDash.Image = Global.PenjualanSQL.My.Resources.Resources.icons8_online_store_32
        Me.btDash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btDash.Location = New System.Drawing.Point(0, 0)
        Me.btDash.Name = "btDash"
        Me.btDash.Size = New System.Drawing.Size(200, 50)
        Me.btDash.TabIndex = 5
        Me.btDash.Text = "Dashboard"
        Me.btDash.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Image = Global.PenjualanSQL.My.Resources.Resources.icons8_box_important_32
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(0, 750)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(200, 50)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Logout"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackgroundImage = Global.PenjualanSQL.My.Resources.Resources.icons8_rocket_64
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 30)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(200, 79)
        Me.Panel5.TabIndex = 1
        '
        'UPenjualan1
        '
        Me.UPenjualan1.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.UPenjualan1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UPenjualan1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UPenjualan1.Location = New System.Drawing.Point(200, 30)
        Me.UPenjualan1.Name = "UPenjualan1"
        Me.UPenjualan1.Size = New System.Drawing.Size(1082, 770)
        Me.UPenjualan1.TabIndex = 7
        '
        'UBarang1
        '
        Me.UBarang1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UBarang1.Location = New System.Drawing.Point(200, 30)
        Me.UBarang1.Name = "UBarang1"
        Me.UBarang1.Size = New System.Drawing.Size(1082, 770)
        Me.UBarang1.TabIndex = 6
        '
        'UCustomer1
        '
        Me.UCustomer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UCustomer1.Location = New System.Drawing.Point(200, 30)
        Me.UCustomer1.Name = "UCustomer1"
        Me.UCustomer1.Size = New System.Drawing.Size(1082, 770)
        Me.UCustomer1.TabIndex = 5
        '
        'USupplier1
        '
        Me.USupplier1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.USupplier1.Location = New System.Drawing.Point(200, 30)
        Me.USupplier1.Name = "USupplier1"
        Me.USupplier1.Size = New System.Drawing.Size(1082, 770)
        Me.USupplier1.TabIndex = 4
        '
        'UDash2
        '
        Me.UDash2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UDash2.Location = New System.Drawing.Point(200, 30)
        Me.UDash2.Name = "UDash2"
        Me.UDash2.Size = New System.Drawing.Size(1082, 770)
        Me.UDash2.TabIndex = 3
        '
        'UDash1
        '
        Me.UDash1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UDash1.Location = New System.Drawing.Point(200, 30)
        Me.UDash1.Name = "UDash1"
        Me.UDash1.Size = New System.Drawing.Size(1082, 770)
        Me.UDash1.TabIndex = 2
        '
        'UPembelian1
        '
        Me.UPembelian1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UPembelian1.Location = New System.Drawing.Point(200, 30)
        Me.UPembelian1.Name = "UPembelian1"
        Me.UPembelian1.Size = New System.Drawing.Size(1082, 770)
        Me.UPembelian1.TabIndex = 8
        '
        'MenuUtama2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1282, 800)
        Me.Controls.Add(Me.UPembelian1)
        Me.Controls.Add(Me.UPenjualan1)
        Me.Controls.Add(Me.UBarang1)
        Me.Controls.Add(Me.UCustomer1)
        Me.Controls.Add(Me.USupplier1)
        Me.Controls.Add(Me.UDash2)
        Me.Controls.Add(Me.UDash1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MenuUtama2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuUtama2"
        Me.Panel1.ResumeLayout(False)
        Me.PTrx.ResumeLayout(False)
        Me.PMaster.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.PDash.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents UDash1 As PenjualanSQL.UDash
    Friend WithEvents PDash As System.Windows.Forms.Panel
    Friend WithEvents btDash As System.Windows.Forms.Button
    Friend WithEvents PTrx As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents btTransaksi As System.Windows.Forms.Button
    Friend WithEvents PMaster As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btMaster As System.Windows.Forms.Button
    Friend WithEvents UDash2 As PenjualanSQL.UDash
    Friend WithEvents USupplier1 As PenjualanSQL.USupplier
    Friend WithEvents UCustomer1 As PenjualanSQL.UCustomer
    Friend WithEvents UBarang1 As PenjualanSQL.UBarang
    Friend WithEvents UPenjualan1 As PenjualanSQL.UPenjualan
    Friend WithEvents UPembelian1 As PenjualanSQL.UPembelian
End Class
