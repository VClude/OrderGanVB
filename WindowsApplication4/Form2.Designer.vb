<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MetroButton4 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton3 = New MetroFramework.Controls.MetroButton()
        Me.LabelNama = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtTime = New MetroFramework.Controls.MetroLabel()
        Me.txtElapsed = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PanelFood = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelFood.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.MetroButton1.Text = "Logout"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroButton2
        '
        Me.MetroButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroButton2.Location = New System.Drawing.Point(242, 117)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(156, 50)
        Me.MetroButton2.TabIndex = 1
        Me.MetroButton2.Text = "Masuk ke menu order"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Panel1.Controls.Add(Me.MetroButton4)
        Me.Panel1.Controls.Add(Me.MetroButton3)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.LabelNama)
        Me.Panel1.Controls.Add(Me.MetroButton1)
        Me.Panel1.Controls.Add(Me.ListBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(216, 394)
        Me.Panel1.TabIndex = 2
        '
        'MetroButton4
        '
        Me.MetroButton4.Location = New System.Drawing.Point(0, 203)
        Me.MetroButton4.Name = "MetroButton4"
        Me.MetroButton4.Size = New System.Drawing.Size(216, 34)
        Me.MetroButton4.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroButton4.TabIndex = 9
        Me.MetroButton4.Text = "         Crud"
        Me.MetroButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroButton4.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroButton3
        '
        Me.MetroButton3.Location = New System.Drawing.Point(0, 169)
        Me.MetroButton3.Name = "MetroButton3"
        Me.MetroButton3.Size = New System.Drawing.Size(216, 34)
        Me.MetroButton3.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroButton3.TabIndex = 8
        Me.MetroButton3.Text = "         Home"
        Me.MetroButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroButton3.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'LabelNama
        '
        Me.LabelNama.Font = New System.Drawing.Font("Segoe UI Semilight", 18.25!)
        Me.LabelNama.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelNama.Location = New System.Drawing.Point(0, 117)
        Me.LabelNama.Name = "LabelNama"
        Me.LabelNama.Size = New System.Drawing.Size(204, 37)
        Me.LabelNama.TabIndex = 3
        Me.LabelNama.Text = "Awewee"
        Me.LabelNama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.ForeColor = System.Drawing.SystemColors.Window
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"       >Hidangan", "       >Komentar", "       >Order", "       >Cart", "       >Pelanggan"})
        Me.ListBox1.Location = New System.Drawing.Point(23, 249)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(193, 13)
        Me.ListBox1.TabIndex = 8
        '
        'Timer1
        '
        '
        'txtTime
        '
        Me.txtTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTime.AutoSize = True
        Me.txtTime.Location = New System.Drawing.Point(230, 364)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(68, 19)
        Me.txtTime.TabIndex = 3
        Me.txtTime.Text = "h:mm:ss tt"
        '
        'txtElapsed
        '
        Me.txtElapsed.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtElapsed.AutoSize = True
        Me.txtElapsed.Location = New System.Drawing.Point(492, 364)
        Me.txtElapsed.Name = "txtElapsed"
        Me.txtElapsed.Size = New System.Drawing.Size(128, 19)
        Me.txtElapsed.TabIndex = 4
        Me.txtElapsed.Text = "{0}hr : {0}min : {0}sec"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(306, 364)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(53, 19)
        Me.MetroLabel1.TabIndex = 5
        Me.MetroLabel1.Text = "GMT+7"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(400, 364)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(93, 19)
        Me.MetroLabel2.TabIndex = 6
        Me.MetroLabel2.Text = "Work Session :"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.DataGridView1.Location = New System.Drawing.Point(23, 173)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(375, 118)
        Me.DataGridView1.TabIndex = 7
        '
        'PanelFood
        '
        Me.PanelFood.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelFood.Controls.Add(Me.DataGridView1)
        Me.PanelFood.Controls.Add(Me.MetroButton2)
        Me.PanelFood.Location = New System.Drawing.Point(222, 36)
        Me.PanelFood.Name = "PanelFood"
        Me.PanelFood.Size = New System.Drawing.Size(419, 325)
        Me.PanelFood.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(58, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(82, 78)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 393)
        Me.Controls.Add(Me.PanelFood)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.txtElapsed)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "Form2"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Blue
        Me.Text = "OrderGan Crud"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFood.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LabelNama As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtTime As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtElapsed As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PanelFood As Panel
    Friend WithEvents MetroButton3 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton4 As MetroFramework.Controls.MetroButton
    Friend WithEvents ListBox1 As ListBox
End Class
