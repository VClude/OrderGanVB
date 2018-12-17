Imports System.Net
Imports System.Text
Imports System.IO
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Data.Odbc
Public Class FormKiosk
    Private Sub FormKiosk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Srvaddr()
        Timer1.Interval = 1000
        Timer1.Enabled = True
        ''getfood()
        ''otomatis
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub


    Protected Sub updateFunc(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        MetroButton1.Text = Now.ToString("h:mm:ss tt" + " WIB")
    End Sub
    Public Sub getfood()

        Dim request As WebRequest = WebRequest.Create(serverapi + "/hidangan/burger/limit")
        request.Method = "POST"
        Dim postData As String
        postData = "dataretrieve=5"
        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
        request.ContentType = "application/x-www-form-urlencoded"
        request.ContentLength = byteArray.Length
        Dim dataStream As Stream = request.GetRequestStream()
        dataStream.Write(byteArray, 0, byteArray.Length)
        dataStream.Close()
        Dim response As WebResponse = request.GetResponse()
        Console.WriteLine(CType(response, HttpWebResponse).StatusDescription)
        dataStream = response.GetResponseStream()
        Dim reader As New StreamReader(dataStream)
        Dim responseFromServer As String = reader.ReadToEnd()
        If responseFromServer = "401" Then
            MsgBox("Unauthorized")
        Else
            Dim json As String = responseFromServer
            Dim ser As JObject = JObject.Parse(json)
            Dim data As List(Of JToken) = ser.Children().ToList
            Dim output As String = ""
            Dim u, d, c, b As String
            Dim number As Integer = 1

            For Each item As JProperty In data
                item.CreateReader()
                Select Case item.Name
                    Case "hidangan"
                        output += "cart:" + vbCrLf
                        For Each comment As JObject In item.Values
                            u = comment("nama_hidangan")
                            d = comment("id_hidangan")
                            c = comment("harga_hidangan")
                            b = comment("foto_hidangan")
                            Dim pt As New PictureBox
                            Dim nama, harga As New Label
                            Dim bt As New MetroFramework.Controls.MetroTile
                            With pt
                                Dim img As Image = GetImageFromURL(server + "/phpapi/public/upload/" + b)
                                .Name = "pt" + d
                                .Location = New Point(number * 100, 3)
                                If img IsNot Nothing Then
                                    .BackgroundImage = img
                                    .BackgroundImageLayout = ImageLayout.Stretch
                                    .Height = 86
                                    .Width = 86
                                Else
                                    MsgBox(serverapi + "/phpapi/public/upload/" + b)
                                End If
                            End With
                            With nama
                                .Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!)
                                .ForeColor = System.Drawing.SystemColors.ActiveCaptionText
                                .Location = New System.Drawing.Point(number * 100, 92)
                                .Size = New System.Drawing.Size(86, 15)
                                .TabIndex = 4
                                .TextAlign = System.Drawing.ContentAlignment.MiddleCenter
                                .Name = "lblNama" + d
                                .Text = u
                            End With
                            With harga
                                .Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!)
                                .ForeColor = System.Drawing.SystemColors.ActiveCaptionText
                                .Location = New System.Drawing.Point(number * 100, 107)
                                .Size = New System.Drawing.Size(86, 15)
                                .TabIndex = 4
                                .TextAlign = System.Drawing.ContentAlignment.MiddleCenter
                                .Name = "lblHarga" + d
                                .Text = c
                            End With
                            With bt
                                .Location = New System.Drawing.Point(number * 100, 125)
                                .Size = New System.Drawing.Size(75, 23)
                                .TabIndex = 6
                                .TextAlign = System.Drawing.ContentAlignment.MiddleCenter
                                .Name = "btawe" + d
                                .Text = "Add"
                            End With
                            number += 1
                            AddHandler bt.Click, AddressOf updateFunc
                            PanelFood.Controls.Add(pt)
                            PanelFood.Controls.Add(nama)
                            PanelFood.Controls.Add(harga)
                            PanelFood.Controls.Add(bt)
                            ''  output += u + vbTab + d + vbTab + c + vbCrLf
                        Next

                End Select
            Next
            MsgBox("Complete")
        End If
        reader.Close()
        dataStream.Close()
        response.Close()
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
        getfood()

    End Sub

    Private Sub MetroButton4_Click(sender As Object, e As EventArgs) Handles MetroButton4.Click

    End Sub

    Private Sub PanelFood_Paint(sender As Object, e As PaintEventArgs) Handles PanelFood.Paint

    End Sub
    Private Function _
       GetImageFromURL(ByVal url As String) As Image

        Dim retVal As Image = Nothing

        Try
            If Not String.IsNullOrWhiteSpace(url) Then
                Dim req As System.Net.WebRequest = System.Net.WebRequest.Create(url.Trim)

                Using request As System.Net.WebResponse = req.GetResponse
                    Using stream As System.IO.Stream = request.GetResponseStream
                        retVal = New Bitmap(System.Drawing.Image.FromStream(stream))
                    End Using
                End Using
            End If

        Catch ex As Exception
            MessageBox.Show(String.Format("An error occurred:{0}{0}{1}",
                                          vbCrLf, ex.Message),
                                          "Exception Thrown",
                                          MessageBoxButtons.OK,
                                          MessageBoxIcon.Warning)

        End Try

        Return retVal

    End Function

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click

    End Sub

    Private Sub MetroButton2_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Close()
    End Sub

    Private Sub MetroTile1_Click(sender As Object, e As EventArgs) Handles MetroTile1.Click

    End Sub
End Class

