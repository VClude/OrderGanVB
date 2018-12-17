<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormKiosk
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MetroButton4 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton3 = New MetroFramework.Controls.MetroButton()
        Me.LabelNama = New System.Windows.Forms.Label()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.PanelFood = New System.Windows.Forms.Panel()
        Me.MetroTile1 = New MetroFramework.Controls.MetroTile()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.PanelFood.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Panel1.Controls.Add(Me.MetroButton4)
        Me.Panel1.Controls.Add(Me.MetroButton3)
        Me.Panel1.Controls.Add(Me.LabelNama)
        Me.Panel1.Controls.Add(Me.MetroButton1)
        Me.Panel1.Location = New System.Drawing.Point(1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(216, 394)
        Me.Panel1.TabIndex = 9
        '
        'MetroButton4
        '
        Me.MetroButton4.Location = New System.Drawing.Point(0, 203)
        Me.MetroButton4.Name = "MetroButton4"
        Me.MetroButton4.Size = New System.Drawing.Size(216, 34)
        Me.MetroButton4.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroButton4.TabIndex = 9
        Me.MetroButton4.Text = "         Cart"
        Me.MetroButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroButton4.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroButton3
        '
        Me.MetroButton3.Location = New System.Drawing.Point(0, 173)
        Me.MetroButton3.Name = "MetroButton3"
        Me.MetroButton3.Size = New System.Drawing.Size(216, 34)
        Me.MetroButton3.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroButton3.TabIndex = 8
        Me.MetroButton3.Text = "         KLIK INI BUAT SHOW"
        Me.MetroButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroButton3.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'LabelNama
        '
        Me.LabelNama.Font = New System.Drawing.Font("Segoe UI Semilight", 18.25!)
        Me.LabelNama.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelNama.Location = New System.Drawing.Point(7, 117)
        Me.LabelNama.Name = "LabelNama"
        Me.LabelNama.Size = New System.Drawing.Size(204, 37)
        Me.LabelNama.TabIndex = 3
        Me.LabelNama.Text = "Order"
        Me.LabelNama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MetroButton1
        '
        Me.MetroButton1.AutoSize = True
        Me.MetroButton1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MetroButton1.Location = New System.Drawing.Point(0, 337)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(216, 57)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroButton1.TabIndex = 0
        Me.MetroButton1.Text = "%Time%"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'PanelFood
        '
        Me.PanelFood.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelFood.AutoScroll = True
        Me.PanelFood.Controls.Add(Me.MetroTile1)
        Me.PanelFood.Controls.Add(Me.Label2)
        Me.PanelFood.Controls.Add(Me.Label1)
        Me.PanelFood.Controls.Add(Me.PictureBox1)
        Me.PanelFood.Location = New System.Drawing.Point(223, 35)
        Me.PanelFood.Name = "PanelFood"
        Me.PanelFood.Size = New System.Drawing.Size(414, 201)
        Me.PanelFood.TabIndex = 14
        '
        'MetroTile1
        '
        Me.MetroTile1.Location = New System.Drawing.Point(8, 125)
        Me.MetroTile1.Name = "MetroTile1"
        Me.MetroTile1.Size = New System.Drawing.Size(75, 23)
        Me.MetroTile1.TabIndex = 6
        Me.MetroTile1.Text = "Add"
        Me.MetroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(3, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Cost "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(3, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Awewee"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(86, 86)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(224, 10)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(49, 19)
        Me.MetroLabel1.TabIndex = 15
        Me.MetroLabel1.Text = "Burger"
        '
        'Timer1
        '
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(393, 267)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FormKiosk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 393)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PanelFood)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormKiosk"
        Me.Text = "FormKiosk"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelFood.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MetroButton4 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton3 As MetroFramework.Controls.MetroButton
    Friend WithEvents LabelNama As Label
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents PanelFood As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MetroTile1 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents Button1 As Button
End Class
