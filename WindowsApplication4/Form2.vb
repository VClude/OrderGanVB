Imports System.Net
Imports System.Text
Imports System.IO

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim req As HttpWebRequest = HttpWebRequest.CreateHttp("http://125.166.114.8/ci/login/logout")
        Dim resp As HttpWebResponse
        Try
            resp = DirectCast(req.GetResponse(), HttpWebResponse)
            MsgBox("Logout Sukses")
            Dim awe As New Form1
            awe.Show()
            Close()
        Catch ex As WebException
            resp = DirectCast(ex.Response, HttpWebResponse)
            MsgBox("Logout Gagal")

        End Try
    End Sub
End Class