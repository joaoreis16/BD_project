<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class missao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(missao))
        Me.menuBar = New System.Windows.Forms.GroupBox()
        Me.homeBttn = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.goBack = New System.Windows.Forms.PictureBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TBpais = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TBnome = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.menuBar.SuspendLayout()
        CType(Me.homeBttn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.goBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuBar
        '
        Me.menuBar.BackColor = System.Drawing.SystemColors.Desktop
        Me.menuBar.Controls.Add(Me.homeBttn)
        Me.menuBar.Controls.Add(Me.PictureBox1)
        Me.menuBar.Controls.Add(Me.goBack)
        Me.menuBar.Location = New System.Drawing.Point(-4, -11)
        Me.menuBar.Name = "menuBar"
        Me.menuBar.Size = New System.Drawing.Size(1086, 92)
        Me.menuBar.TabIndex = 42
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
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(958, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(107, 59)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
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
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(694, 188)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(304, 384)
        Me.ListBox1.TabIndex = 43
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(790, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 20)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Missões Ativas"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(36, 337)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(178, 40)
        Me.Button1.TabIndex = 45
        Me.Button1.Text = "Criar Missão"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.TBpais)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.TBnome)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(52, 178)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(608, 394)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informações da Missão"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(230, 337)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(144, 40)
        Me.Button3.TabIndex = 53
        Me.Button3.Text = "Reset"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(67, 227)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 20)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Tipo"
        '
        'ComboBox1
        '
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"-- tipo --", "Territorial", "Conflito", "Diplomática", "Civil-Militar", "Evacuação", "Assalto"})
        Me.ComboBox1.Location = New System.Drawing.Point(148, 224)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(211, 28)
        Me.ComboBox1.TabIndex = 51
        '
        'TBpais
        '
        Me.TBpais.Location = New System.Drawing.Point(148, 156)
        Me.TBpais.Name = "TBpais"
        Me.TBpais.ReadOnly = True
        Me.TBpais.Size = New System.Drawing.Size(389, 27)
        Me.TBpais.TabIndex = 50
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(67, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 20)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "País"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(393, 337)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(178, 40)
        Me.Button2.TabIndex = 48
        Me.Button2.Text = "Ver mais Informações"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TBnome
        '
        Me.TBnome.Location = New System.Drawing.Point(148, 87)
        Me.TBnome.Name = "TBnome"
        Me.TBnome.ReadOnly = True
        Me.TBnome.Size = New System.Drawing.Size(389, 27)
        Me.TBnome.TabIndex = 47
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(67, 90)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(50, 20)
        Me.Label15.TabIndex = 46
        Me.Label15.Text = "Nome"
        '
        'missao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1077, 632)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.menuBar)
        Me.Name = "missao"
        Me.Text = "missao"
        Me.menuBar.ResumeLayout(False)
        CType(Me.homeBttn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.goBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menuBar As GroupBox
    Friend WithEvents homeBttn As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents goBack As PictureBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TBpais As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents TBnome As TextBox
End Class
