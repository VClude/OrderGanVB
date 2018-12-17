Imports System.Net
Imports System.Text
Imports System.IO
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Data.Odbc

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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

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


End Class
