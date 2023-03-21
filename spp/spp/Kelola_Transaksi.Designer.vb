<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kelola_Transaksi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Kelola_Transaksi))
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PrintDoc = New System.Drawing.Printing.PrintDocument()
        Me.Txtcari = New System.Windows.Forms.TextBox()
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Txtkembali = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_user, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(228, 112)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(25, 13)
        Me.Label11.TabIndex = 185
        Me.Label11.Text = "Cari"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(722, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 20)
        Me.Label1.TabIndex = 149
        Me.Label1.Text = "Admin"
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
        Me.Panel1.TabIndex = 183
        '
        'Txtcari
        '
        Me.Txtcari.Location = New System.Drawing.Point(228, 128)
        Me.Txtcari.Name = "Txtcari"
        Me.Txtcari.Size = New System.Drawing.Size(125, 20)
        Me.Txtcari.TabIndex = 184
        '
        'dgv_user
        '
        Me.dgv_user.BackgroundColor = System.Drawing.Color.White
        Me.dgv_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_user.Location = New System.Drawing.Point(228, 154)
        Me.dgv_user.Name = "dgv_user"
        Me.dgv_user.RowHeadersWidth = 62
        Me.dgv_user.Size = New System.Drawing.Size(524, 256)
        Me.dgv_user.TabIndex = 182
        '
        'PrintPD
        '
        Me.PrintPD.BackColor = System.Drawing.Color.DarkGray
        Me.PrintPD.Location = New System.Drawing.Point(586, 417)
        Me.PrintPD.Margin = New System.Windows.Forms.Padding(2)
        Me.PrintPD.Name = "PrintPD"
        Me.PrintPD.Size = New System.Drawing.Size(73, 21)
        Me.PrintPD.TabIndex = 181
        Me.PrintPD.Text = "Print"
        Me.PrintPD.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(72, 413)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 13)
        Me.Label9.TabIndex = 180
        Me.Label9.Text = "Jumlah Bayar"
        '
        'jmlbyr
        '
        Me.jmlbyr.Location = New System.Drawing.Point(44, 427)
        Me.jmlbyr.Name = "jmlbyr"
        Me.jmlbyr.Size = New System.Drawing.Size(144, 20)
        Me.jmlbyr.TabIndex = 179
        '
        'dttbayar
        '
        Me.dttbayar.Location = New System.Drawing.Point(46, 311)
        Me.dttbayar.Margin = New System.Windows.Forms.Padding(2)
        Me.dttbayar.Name = "dttbayar"
        Me.dttbayar.Size = New System.Drawing.Size(142, 20)
        Me.dttbayar.TabIndex = 178
        '
        'idspp
        '
        Me.idspp.FormattingEnabled = True
        Me.idspp.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.idspp.Location = New System.Drawing.Point(46, 229)
        Me.idspp.Margin = New System.Windows.Forms.Padding(2)
        Me.idspp.Name = "idspp"
        Me.idspp.Size = New System.Drawing.Size(142, 21)
        Me.idspp.TabIndex = 177
        '
        'nisn
        '
        Me.nisn.FormattingEnabled = True
        Me.nisn.Items.AddRange(New Object() {"123", "124", "421", "132", "231", "221", "112", "212", "121", "128"})
        Me.nisn.Location = New System.Drawing.Point(46, 270)
        Me.nisn.Margin = New System.Windows.Forms.Padding(2)
        Me.nisn.Name = "nisn"
        Me.nisn.Size = New System.Drawing.Size(142, 21)
        Me.nisn.TabIndex = 176
        '
        'idptgs
        '
        Me.idptgs.FormattingEnabled = True
        Me.idptgs.Items.AddRange(New Object() {"1", "2", "3"})
        Me.idptgs.Location = New System.Drawing.Point(44, 191)
        Me.idptgs.Margin = New System.Windows.Forms.Padding(2)
        Me.idptgs.Name = "idptgs"
        Me.idptgs.Size = New System.Drawing.Size(142, 21)
        Me.idptgs.TabIndex = 175
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(82, 214)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 174
        Me.Label6.Text = "ID SPP"
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.DarkGray
        Me.Button6.Location = New System.Drawing.Point(679, 416)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 173
        Me.Button6.Text = "Logout"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(72, 374)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 172
        Me.Label8.Text = "Tahun Bayar"
        '
        'Thnbyr
        '
        Me.Thnbyr.Location = New System.Drawing.Point(45, 390)
        Me.Thnbyr.Name = "Thnbyr"
        Me.Thnbyr.Size = New System.Drawing.Size(143, 20)
        Me.Thnbyr.TabIndex = 171
        '
        'Blnbyr
        '
        Me.Blnbyr.Location = New System.Drawing.Point(45, 350)
        Me.Blnbyr.Name = "Blnbyr"
        Me.Blnbyr.Size = New System.Drawing.Size(143, 20)
        Me.Blnbyr.TabIndex = 170
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(72, 333)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 169
        Me.Label7.Text = "Bulan Bayar"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.DarkGray
        Me.Button5.Location = New System.Drawing.Point(321, 415)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 168
        Me.Button5.Text = "Hapus"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DarkGray
        Me.Button4.Location = New System.Drawing.Point(452, 417)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 167
        Me.Button4.Text = "Edit"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkGray
        Me.Button3.Location = New System.Drawing.Point(228, 413)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 166
        Me.Button3.Text = "Tambah"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Bayar
        '
        Me.Bayar.Location = New System.Drawing.Point(44, 154)
        Me.Bayar.Name = "Bayar"
        Me.Bayar.Size = New System.Drawing.Size(143, 20)
        Me.Bayar.TabIndex = 165
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(71, 293)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 164
        Me.Label5.Text = "Tanggal Bayar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(87, 252)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 163
        Me.Label4.Text = "NISN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 161
        Me.Label2.Text = "ID Pembayaran"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkGray
        Me.Button2.Location = New System.Drawing.Point(679, 125)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 160
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(72, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 162
        Me.Label3.Text = "ID Petugas"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkGray
        Me.Button1.Location = New System.Drawing.Point(383, 105)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 186
        Me.Button1.Text = "Bayar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Txtkembali
        '
        Me.Txtkembali.Location = New System.Drawing.Point(476, 105)
        Me.Txtkembali.Name = "Txtkembali"
        Me.Txtkembali.Size = New System.Drawing.Size(125, 20)
        Me.Txtkembali.TabIndex = 187
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(497, 89)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 13)
        Me.Label12.TabIndex = 188
        Me.Label12.Text = "Jumlah Bayar"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(497, 128)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 13)
        Me.Label13.TabIndex = 189
        Me.Label13.Text = "Kembalikan"
        '
        'Kelola_Transaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GreenYellow
        Me.ClientSize = New System.Drawing.Size(800, 472)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Txtkembali)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Txtcari)
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
        Me.Name = "Kelola_Transaksi"
        Me.Text = "Kelola_Transaksi"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv_user, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label11 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PrintDoc As Printing.PrintDocument
    Friend WithEvents Txtcari As TextBox
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
    Friend WithEvents Button1 As Button
    Friend WithEvents Txtkembali As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
End Class
