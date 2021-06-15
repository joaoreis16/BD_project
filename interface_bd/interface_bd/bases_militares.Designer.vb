<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class bases_militares
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bases_militares))
        Me.menuBar = New System.Windows.Forms.GroupBox()
        Me.homeBttn = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.goBack = New System.Windows.Forms.PictureBox()
        Me.totalTxtBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.barraBases = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FT = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.FA = New System.Windows.Forms.CheckBox()
        Me.ApplyBases = New System.Windows.Forms.Button()
        Me.FM = New System.Windows.Forms.CheckBox()
        Me.pesquisaBttn = New System.Windows.Forms.PictureBox()
        Me.menuBar.SuspendLayout()
        CType(Me.homeBttn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.goBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.pesquisaBttn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'menuBar
        '
        Me.menuBar.BackColor = System.Drawing.SystemColors.Desktop
        Me.menuBar.Controls.Add(Me.homeBttn)
        Me.menuBar.Controls.Add(Me.PictureBox4)
        Me.menuBar.Controls.Add(Me.goBack)
        Me.menuBar.Location = New System.Drawing.Point(-6, -11)
        Me.menuBar.Name = "menuBar"
        Me.menuBar.Size = New System.Drawing.Size(1086, 92)
        Me.menuBar.TabIndex = 32
        Me.menuBar.TabStop = False
        '
        'homeBttn
        '
        Me.homeBttn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.homeBttn.Image = CType(resources.GetObject("homeBttn.Image"), System.Drawing.Image)
        Me.homeBttn.Location = New System.Drawing.Point(546, 34)
        Me.homeBttn.Name = "homeBttn"
        Me.homeBttn.Size = New System.Drawing.Size(47, 42)
        Me.homeBttn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.homeBttn.TabIndex = 19
        Me.homeBttn.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(958, 26)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(107, 59)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 18
        Me.PictureBox4.TabStop = False
        '
        'goBack
        '
        Me.goBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.goBack.Image = CType(resources.GetObject("goBack.Image"), System.Drawing.Image)
        Me.goBack.Location = New System.Drawing.Point(40, 34)
        Me.goBack.Name = "goBack"
        Me.goBack.Size = New System.Drawing.Size(47, 42)
        Me.goBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.goBack.TabIndex = 14
        Me.goBack.TabStop = False
        '
        'totalTxtBox
        '
        Me.totalTxtBox.Location = New System.Drawing.Point(977, 587)
        Me.totalTxtBox.Name = "totalTxtBox"
        Me.totalTxtBox.ReadOnly = True
        Me.totalTxtBox.Size = New System.Drawing.Size(58, 27)
        Me.totalTxtBox.TabIndex = 45
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(926, 590)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 20)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Total:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(37, 316)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 20)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "FILTROS"
        '
        'barraBases
        '
        Me.barraBases.Location = New System.Drawing.Point(37, 231)
        Me.barraBases.Name = "barraBases"
        Me.barraBases.Size = New System.Drawing.Size(456, 27)
        Me.barraBases.TabIndex = 42
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(37, 187)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 20)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "PESQUISA"
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 20
        Me.ListBox2.Location = New System.Drawing.Point(598, 133)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(437, 444)
        Me.ListBox2.TabIndex = 37
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.FT)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.ApplyBases)
        Me.GroupBox1.Location = New System.Drawing.Point(37, 339)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(504, 238)
        Me.GroupBox1.TabIndex = 47
        Me.GroupBox1.TabStop = False
        '
        'FT
        '
        Me.FT.AutoSize = True
        Me.FT.Location = New System.Drawing.Point(44, 52)
        Me.FT.Name = "FT"
        Me.FT.Size = New System.Drawing.Size(128, 24)
        Me.FT.TabIndex = 0
        Me.FT.Text = "Força Terrestre"
        Me.FT.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.FA)
        Me.GroupBox2.Location = New System.Drawing.Point(26, 26)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(461, 66)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ramos"
        '
        'FA
        '
        Me.FA.AutoSize = True
        Me.FA.Location = New System.Drawing.Point(176, 26)
        Me.FA.Name = "FA"
        Me.FA.Size = New System.Drawing.Size(110, 24)
        Me.FA.TabIndex = 0
        Me.FA.Text = "Força Aerea"
        Me.FA.UseVisualStyleBackColor = True
        '
        'ApplyBases
        '
        Me.ApplyBases.Location = New System.Drawing.Point(190, 187)
        Me.ApplyBases.Name = "ApplyBases"
        Me.ApplyBases.Size = New System.Drawing.Size(133, 29)
        Me.ApplyBases.TabIndex = 1
        Me.ApplyBases.Text = "Apply"
        Me.ApplyBases.UseVisualStyleBackColor = True
        '
        'FM
        '
        Me.FM.AutoSize = True
        Me.FM.Location = New System.Drawing.Point(387, 391)
        Me.FM.Name = "FM"
        Me.FM.Size = New System.Drawing.Size(131, 24)
        Me.FM.TabIndex = 1
        Me.FM.Text = "Força Marítima"
        Me.FM.UseVisualStyleBackColor = True
        '
        'pesquisaBttn
        '
        Me.pesquisaBttn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pesquisaBttn.Image = CType(resources.GetObject("pesquisaBttn.Image"), System.Drawing.Image)
        Me.pesquisaBttn.Location = New System.Drawing.Point(513, 231)
        Me.pesquisaBttn.Name = "pesquisaBttn"
        Me.pesquisaBttn.Size = New System.Drawing.Size(28, 27)
        Me.pesquisaBttn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pesquisaBttn.TabIndex = 48
        Me.pesquisaBttn.TabStop = False
        '
        'bases_militares
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1071, 632)
        Me.Controls.Add(Me.pesquisaBttn)
        Me.Controls.Add(Me.FM)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.totalTxtBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.barraBases)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.menuBar)
        Me.Name = "bases_militares"
        Me.Text = "bases_militares"
        Me.menuBar.ResumeLayout(False)
        CType(Me.homeBttn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.goBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.pesquisaBttn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menuBar As GroupBox
    Friend WithEvents homeBttn As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents goBack As PictureBox
    Friend WithEvents totalTxtBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents barraBases As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ApplyBases As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents FT As CheckBox
    Friend WithEvents FM As CheckBox
    Friend WithEvents FA As CheckBox
    Friend WithEvents pesquisaBttn As PictureBox
End Class
