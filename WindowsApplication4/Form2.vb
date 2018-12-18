Imports System.Net
Imports System.Text
Imports System.IO
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Data.Odbc
Imports MySql.Data.MySqlClient
Imports System.Diagnostics.Eventing

Public Class Form2
    Private _elapseTimerRunning As Boolean = False
    Private _elapseStartTime As DateTime
    Private awe As Integer
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000
        ListBox1.Height = 0
        Srvaddr()
        awe = 0
        Timer1.Enabled = True
        _elapseStartTime = Now
        _elapseTimerRunning = True
        grid()
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim req As HttpWebRequest = WebRequest.CreateHttp(server + "/ci/login/logout")
        Dim resp As HttpWebResponse
        Try
            Dim result As Integer = MessageBox.Show("Do you want to Logout?", "OrderGan", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                resp = DirectCast(req.GetResponse(), HttpWebResponse)
                MsgBox("Logout Sukses")
                Dim awe As New Form1
                awe.Show()
                Close()
            ElseIf result = DialogResult.No Then

            End If

        Catch ex As WebException
            resp = DirectCast(ex.Response, HttpWebResponse)
            MsgBox("Logout Gagal")

        End Try
    End Sub
    Protected Sub updateFunc(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Dim awe As New FormKiosk
        awe.Show()
        Close()

    End Sub

    Private Sub MetroPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtTime.Text = Now.ToString("h:mm:ss tt")
        If _elapseTimerRunning = True Then
            Dim elapsedtime = DateTime.Now.Subtract(_elapseStartTime)
            txtElapsed.Text = String.Format("{0}hr : {1}min : {2}sec", elapsedtime.Hours, elapsedtime.Minutes, elapsedtime.Seconds)
        End If
    End Sub


    Private Sub txtElapsed_Click(sender As Object, e As EventArgs) Handles txtElapsed.Click

    End Sub

    Private Sub LabelNama_Click(sender As Object, e As EventArgs) Handles LabelNama.Click

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

    End Sub
    Sub grid()
        Call initdb()
        da = New MySql.Data.MySqlClient.MySqlDataAdapter("select id_hidangan as id, nama_hidangan as Nama, deskripsi_hidangan as deskripsi ,harga_hidangan as harga, kategori_hidangan as kategori, foto_hidangan as foto from tb_hidangan", conn)
        ds = New DataSet()
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        DataGridView1.Columns("id").Width = 100
        DataGridView1.Columns("nama").Width = 250
        DataGridView1.Columns("deskripsi").Width = 250
        DataGridView1.Columns("harga").Width = 100
        DataGridView1.Columns("kategori").Width = 200
        DataGridView1.Columns("foto").Width = 200
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub MetroButton4_Click(sender As Object, e As EventArgs) Handles MetroButton4.Click
        If ListBox1.Height = 0 Then
            ListBox1.Height = 91
        Else
            ListBox1.Height = 0
            ListBox1.ClearSelected()
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or RichTextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MessageBox.Show("Please Fill All Field To Insert", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim Command As MySqlCommand
            Try
                Command = conn.CreateCommand
                Command.CommandText = "insert into tb_hidangan (nama_hidangan, deskripsi_hidangan, harga_hidangan, kategori_hidangan, foto_hidangan) values ('" & TextBox1.Text & "','" & RichTextBox1.Text & "','" & TextBox2.Text & "','" & TextBox4.Text & "','" & TextBox3.Text & "')"
                Command.ExecuteNonQuery()
                grid()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub PanelFood_Paint(sender As Object, e As PaintEventArgs) Handles PanelFood.Paint

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Or RichTextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MessageBox.Show("Please Fill All Field To Insert", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim Command As MySqlCommand
            Try
                Command = conn.CreateCommand
                Command.CommandText = "update tb_hidangan set nama_hidangan='" & TextBox1.Text & "',deskripsi_hidangan='" & RichTextBox1.Text & "',harga_hidangan='" & TextBox2.Text & "',foto_hidangan='" & TextBox3.Text & "',kategori_hidangan='" & TextBox4.Text & "' where id_hidangan='" & TextBox5.Text & "'"
                Command.ExecuteNonQuery()
                grid()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)

            TextBox1.Text = row.Cells("Nama").Value.ToString
            RichTextBox1.Text = row.Cells("deskripsi").Value.ToString
            TextBox2.Text = row.Cells("harga").Value.ToString
            TextBox3.Text = row.Cells("foto").Value.ToString
            TextBox4.Text = row.Cells("kategori").Value.ToString
            TextBox5.Text = row.Cells("id").Value.ToString
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Or RichTextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MessageBox.Show("Please Fill All Field To Insert", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim Command As MySqlCommand
            Try
                Command = conn.CreateCommand
                Command.CommandText = "delete from tb_hidangan where id_hidangan='" & TextBox5.Text & "'"
                Command.ExecuteNonQuery()
                grid()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
End Class
