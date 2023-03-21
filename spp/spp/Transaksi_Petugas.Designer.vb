<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transaksi_Petugas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Transaksi_Petugas))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dgv_user = New System.Windows.Forms.DataGridView()
        Me.PrintPD = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.jmlbyr = New System.Windows.Forms.TextBox()
        Me.dttbayar = New System.Windows.Forms.DateTimePicker()
        Me.idspp = New System.Windows.Forms.ComboBox()
        Me.nisn = New System.Windows.Forms.ComboBox()
        Me.idptgs = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Thnbyr = New System.Windows.Forms.TextBox()
        Me.Blnbyr = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Bayar = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PrintDoc = New System.Drawing.Printing.PrintDocument()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_user, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Blue
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Location = New System.Drawing.Point(-4, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(807, 79)
        Me.Panel1.TabIndex = 205
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(713, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 20)
        Me.Label1.TabIndex = 149
        Me.Label1.Text = "Petugas"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(702, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(4, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 79)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(300, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(231, 31)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Kelola Transaksi"
        '
        'dgv_user
        '
        Me.dgv_user.BackgroundColor = System.Drawing.Color.White
        Me.dgv_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_user.Location = New System.Drawing.Point(230, 158)
        Me.dgv_user.Name = "dgv_user"
        Me.dgv_user.RowHeadersWidth = 62
        Me.dgv_user.Size = New System.Drawing.Size(524, 256)
        Me.dgv_user.TabIndex = 204
        '
        'PrintPD
        '
        Me.PrintPD.BackColor = System.Drawing.Color.DarkGray
        Me.PrintPD.Location = New System.Drawing.Point(586, 419)
        Me.PrintPD.Margin = New System.Windows.Forms.Padding(2)
        Me.PrintPD.Name = "PrintPD"
        Me.PrintPD.Size = New System.Drawing.Size(73, 21)
        Me.PrintPD.TabIndex = 203
        Me.PrintPD.Text = "Print"
        Me.PrintPD.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(72, 415)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 13)
        Me.Label9.TabIndex = 202
        Me.Label9.Text = "Jumlah Bayar"
        '
        'jmlbyr
        '
        Me.jmlbyr.Location = New System.Drawing.Point(44, 429)
        Me.jmlbyr.Name = "jmlbyr"
        Me.jmlbyr.Size = New System.Drawing.Size(144, 20)
        Me.jmlbyr.TabIndex = 201
        '
        'dttbayar
        '
        Me.dttbayar.Location = New System.Drawing.Point(46, 313)
        Me.dttbayar.Margin = New System.Windows.Forms.Padding(2)
        Me.dttbayar.Name = "dttbayar"
        Me.dttbayar.Size = New System.Drawing.Size(142, 20)
        Me.dttbayar.TabIndex = 200
        '
        'idspp
        '
        Me.idspp.FormattingEnabled = True
        Me.idspp.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.idspp.Location = New System.Drawing.Point(46, 231)
        Me.idspp.Margin = New System.Windows.Forms.Padding(2)
        Me.idspp.Name = "idspp"
        Me.idspp.Size = New System.Drawing.Size(142, 21)
        Me.idspp.TabIndex = 199
        '
        'nisn
        '
        Me.nisn.FormattingEnabled = True
        Me.nisn.Items.AddRange(New Object() {"123", "124", "421", "132", "231", "221", "112", "212", "121", "128"})
        Me.nisn.Location = New System.Drawing.Point(46, 272)
        Me.nisn.Margin = New System.Windows.Forms.Padding(2)
        Me.nisn.Name = "nisn"
        Me.nisn.Size = New System.Drawing.Size(142, 21)
        Me.nisn.TabIndex = 198
        '
        'idptgs
        '
        Me.idptgs.FormattingEnabled = True
        Me.idptgs.Items.AddRange(New Object() {"1", "2", "3"})
        Me.idptgs.Location = New System.Drawing.Point(44, 193)
        Me.idptgs.Margin = New System.Windows.Forms.Padding(2)
        Me.idptgs.Name = "idptgs"
        Me.idptgs.Size = New System.Drawing.Size(142, 21)
        Me.idptgs.TabIndex = 197
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(82, 216)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 196
        Me.Label6.Text = "ID SPP"
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.DarkGray
        Me.Button6.Location = New System.Drawing.Point(679, 418)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 195
        Me.Button6.Text = "Logout"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(72, 376)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 194
        Me.Label8.Text = "Tahun Bayar"
        '
        'Thnbyr
        '
        Me.Thnbyr.Location = New System.Drawing.Point(45, 392)
        Me.Thnbyr.Name = "Thnbyr"
        Me.Thnbyr.Size = New System.Drawing.Size(143, 20)
        Me.Thnbyr.TabIndex = 193
        '
        'Blnbyr
        '
        Me.Blnbyr.Location = New System.Drawing.Point(45, 352)
        Me.Blnbyr.Name = "Blnbyr"
        Me.Blnbyr.Size = New System.Drawing.Size(143, 20)
        Me.Blnbyr.TabIndex = 192
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(72, 335)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 191
        Me.Label7.Text = "Bulan Bayar"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.DarkGray
        Me.Button5.Location = New System.Drawing.Point(321, 417)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 190
        Me.Button5.Text = "Hapus"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DarkGray
        Me.Button4.Location = New System.Drawing.Point(452, 417)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 189
        Me.Button4.Text = "Edit"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkGray
        Me.Button3.Location = New System.Drawing.Point(228, 415)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 188
        Me.Button3.Text = "Tambah"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Bayar
        '
        Me.Bayar.Location = New System.Drawing.Point(44, 156)
        Me.Bayar.Name = "Bayar"
        Me.Bayar.Size = New System.Drawing.Size(143, 20)
        Me.Bayar.TabIndex = 187
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(71, 295)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 186
        Me.Label5.Text = "Tanggal Bayar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(87, 254)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 185
        Me.Label4.Text = "NISN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 183
        Me.Label2.Text = "ID Pembayaran"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkGray
        Me.Button2.Location = New System.Drawing.Point(679, 127)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 182
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(72, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 184
        Me.Label3.Text = "ID Petugas"
        '
        'Transaksi_Petugas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GreenYellow
        Me.ClientSize = New System.Drawing.Size(800, 479)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgv_user)
        Me.Controls.Add(Me.PrintPD)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.jmlbyr)
        Me.Controls.Add(Me.dttbayar)
        Me.Controls.Add(Me.idspp)
        Me.Controls.Add(Me.nisn)
        Me.Controls.Add(Me.idptgs)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Thnbyr)
        Me.Controls.Add(Me.Blnbyr)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Bayar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Transaksi_Petugas"
        Me.Text = "Transaksi_Petugas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_user, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents dgv_user As DataGridView
    Friend WithEvents PrintPD As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents jmlbyr As TextBox
    Friend WithEvents dttbayar As DateTimePicker
    Friend WithEvents idspp As ComboBox
    Friend WithEvents nisn As ComboBox
    Friend WithEvents idptgs As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Thnbyr As TextBox
    Friend WithEvents Blnbyr As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Bayar As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents PrintDoc As Printing.PrintDocument
End Class
