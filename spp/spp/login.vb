Imports System.Data.SqlClient

Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        connect()
        If Txtnm.Text = "" And Txtpass.Text = "" Then
            MsgBox("Pastikan Mengisi Semua Field")
        Else
            Sql = "SELECT id_petugas, username, password, level FROM petugas WHERE username='" & Trim(Txtnm.Text) & "' and password='" & Trim(Txtpass.Text) & "'"
            cmd = New SqlCommand(Sql, con)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                If rd.Item("level").Equals("Admin") Then
                    admin.Show()
                    Me.Hide()
                ElseIf rd.Item("level").Equals("Petugas") Then
                    petugas.Show()
                    Me.Hide()
                ElseIf rd.Item("level").Equals("Siswa") Then
                    siswa.Show()
                    Me.Hide()
                Else
                    MsgBox("Username atau password yang anda masukan tidak sesuai")
                    rd.Close()
                End If
            Else
                MsgBox("Username atau password yang anda masukan tidak sesuai")
                rd.Close()
            End If
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Txtnm.Text = ""
        Txtpass.Text = ""
        MsgBox("Username Dan password anda belum terisi")


    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel2_Paint_1(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class
