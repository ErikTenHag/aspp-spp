Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.Windows
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar
Public Class Transaksi_Petugas
    Dim WithEvents PD As New PrintDocument
    Dim PDD As New PrintPreviewDialog
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        connect()
        If Bayar.Text = "" And idptgs.Text = "" And nisn.Text = "" And Blnbyr.Text = "" And Thnbyr.Text = "" And idptgs.Text = "" And jmlbyr.Text = "" Then
            MsgBox("Pastikan semua field terisi")
        Else
            sql = "INSERT into pembayaran (id_pembayaran, id_petugas, nisn, tgl_bayar, bulan_dibayar, tahun_dibayar, id_spp, jumlah_bayar) VALUES ('" & Bayar.Text & "', '" & idptgs.Text & "','" & nisn.Text & "','" & Format(dttbayar.Value, "yyyy-MM-dd") & "','" & Blnbyr.Text & "','" & Thnbyr.Text & "','" & idspp.Text & "','" & jmlbyr.Text & "')"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil tambah data")
            aturdgv()
            kosong()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        connect()
        If Bayar.Text = "" And idptgs.Text = "" And nisn.Text = "" And Blnbyr.Text = "" And Thnbyr.Text = "" And idspp.Text = "" And jmlbyr.Text = "" Then
            MsgBox("Pastikan semua field terisi")
        Else
            sql = "DELETE FROM pembayaran where id_pembayaran='" & Bayar.Text & "'"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil hapus data")
            aturdgv()
            kosong()
        End If
    End Sub

    Sub aturdgv()
        sql = "SELECT  bulan_dibayar,  jumlah_bayar, tgl_bayar FROM pembayaran"
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "pembayaran")
        dgv_user.DataSource = ds.Tables("pembayaran")
    End Sub

    Sub kosong()
        idptgs.Text = ""
        nisn.Text = ""
        Blnbyr.Text = ""
        Thnbyr.Text = ""
        idspp.Text = ""
        jmlbyr.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        connect()
        If Bayar.Text = "" And idptgs.Text = "" And nisn.Text = "" And Blnbyr.Text = "" And Thnbyr.Text = "" And idspp.Text = "" And jmlbyr.Text = "" Then
            MsgBox("Pastikan semua field terisi")
        Else
            sql = "UPDATE pembayaran set id_petugas='" & idptgs.Text & "', nisn='" & nisn.Text & "', tgl_bayar='" & Format(dttbayar.Value, "yyyy-MM-dd") & "', bulan_dibayar='" & Blnbyr.Text & "', tahun_dibayar='" & Thnbyr.Text & "', id_spp='" & idspp.Text & "', jumlah_bayar='" & jmlbyr.Text & "' WHERE id_pembayaran='" & Bayar.Text & "'"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil edit data")
            aturdgv()
            kosong()
        End If
    End Sub

    Private Sub PrintPD_Click(sender As Object, e As EventArgs) Handles PrintPD.Click
        'printPD()
        PDD.Document = PD
        PDD.ShowDialog()
    End Sub

    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim f10 As New Font("Times New Roman", 10, FontStyle.Regular)
        Dim f10b As New Font("Times New Roman", 10, FontStyle.Bold)
        Dim f14 As New Font("Times New Roman", 14, FontStyle.Bold)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        Dim kanan As New StringFormat
        Dim tengah As New StringFormat
        kanan.Alignment = StringAlignment.Far
        tengah.Alignment = StringAlignment.Center

        Dim garis As String
        garis = "--------------------------------------------------------------------------------------"

        e.Graphics.DrawString("SPP SMK Negeri 2 Kuningan", f14, Brushes.Black, centermargin, 5, tengah)
        e.Graphics.DrawString("Jl.Sukamulya No.77", f10, Brushes.Black, centermargin, 25, tengah)
        e.Graphics.DrawString("No Tlp: 0812", f10, Brushes.Black, centermargin, 40, tengah)

        e.Graphics.DrawString("Petugas", f10, Brushes.Black, 0, 65)
        e.Graphics.DrawString(":", f10, Brushes.Black, 60, 65)
        e.Graphics.DrawString("Erik Tohir", f10, Brushes.Black, 80, 65)

        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 80)
        e.Graphics.DrawString("Bulan Bayar", f10, Brushes.Black, 0, 95)
        e.Graphics.DrawString("Harga", f10, Brushes.Black, 100, 95)
        e.Graphics.DrawString("Tanggal Bayar", f10, Brushes.Black, 200, 95)
        dgv_user.AllowUserToAddRows = False

        Dim tinggi As Integer
        For baris As Integer = 0 To dgv_user.RowCount - 1
            tinggi += 15
            e.Graphics.DrawString(dgv_user.Rows(baris).Cells(0).Value.ToString, f10, Brushes.Black, 0, 100 + tinggi)
            e.Graphics.DrawString(dgv_user.Rows(baris).Cells(1).Value.ToString, f10, Brushes.Black, 100, 100 + tinggi)
            e.Graphics.DrawString(dgv_user.Rows(baris).Cells(2).Value.ToString, f10, Brushes.Black, 200, 100 + tinggi)

        Next
        tinggi = 110 + tinggi
        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 400)
        e.Graphics.DrawString("Aligatogojaimazzzz", f10, Brushes.Black, centermargin, 450, tengah)


    End Sub

    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 350, 500)
        PD.DefaultPageSettings = pagesetup

    End Sub

    Private Sub Transaksi_Petugas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        aturdgv()
    End Sub

    Private Sub PrintDoc_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDoc.PrintPage

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Petugas.Show()
        Me.Hide()
    End Sub

    Private Sub dgv_user_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_user.CellContentClick

    End Sub
End Class