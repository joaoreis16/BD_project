<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class militares
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(militares))
        Me.CheckAll = New System.Windows.Forms.CheckBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.CheckRamo = New System.Windows.Forms.CheckBox()
        Me.CheckBase = New System.Windows.Forms.CheckBox()
        Me.CheckNasc = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBpesquisa = New System.Windows.Forms.TextBox()
        Me.menuBar = New System.Windows.Forms.GroupBox()
        Me.homeBttn = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.goBack = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.totalTxtBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckMissao = New System.Windows.Forms.CheckBox()
        Me.pesquisaBttn = New System.Windows.Forms.PictureBox()
        Me.menuBar.SuspendLayout()
        CType(Me.homeBttn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.goBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pesquisaBttn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CheckAll
        '
        Me.CheckAll.AutoSize = True
        Me.CheckAll.Location = New System.Drawing.Point(31, 46)
        Me.CheckAll.Name = "CheckAll"
        Me.CheckAll.Size = New System.Drawing.Size(49, 24)
        Me.CheckAll.TabIndex = 18
        Me.CheckAll.Text = "All"
        Me.CheckAll.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(594, 135)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(437, 444)
        Me.ListBox1.TabIndex = 21
        '
        'CheckRamo
        '
        Me.CheckRamo.AutoSize = True
        Me.CheckRamo.Location = New System.Drawing.Point(31, 95)
        Me.CheckRamo.Name = "CheckRamo"
        Me.CheckRamo.Size = New System.Drawing.Size(70, 24)
        Me.CheckRamo.TabIndex = 22
        Me.CheckRamo.Text = "Ramo"
        Me.CheckRamo.UseVisualStyleBackColor = True
        '
        'CheckBase
        '
        Me.CheckBase.AutoSize = True
        Me.CheckBase.Location = New System.Drawing.Point(174, 46)
        Me.CheckBase.Name = "CheckBase"
        Me.CheckBase.Size = New System.Drawing.Size(109, 24)
        Me.CheckBase.TabIndex = 23
        Me.CheckBase.Text = "Base Militar"
        Me.CheckBase.UseVisualStyleBackColor = True
        '
        'CheckNasc
        '
        Me.CheckNasc.AutoSize = True
        Me.CheckNasc.Location = New System.Drawing.Point(346, 46)
        Me.CheckNasc.Name = "CheckNasc"
        Me.CheckNasc.Size = New System.Drawing.Size(128, 24)
        Me.CheckNasc.TabIndex = 24
        Me.CheckNasc.Text = "Nacionalidade"
        Me.CheckNasc.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(33, 189)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 20)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "PESQUISA"
        '
        'TBpesquisa
        '
        Me.TBpesquisa.Location = New System.Drawing.Point(33, 233)
        Me.TBpesquisa.Name = "TBpesquisa"
        Me.TBpesquisa.Size = New System.Drawing.Size(460, 27)
        Me.TBpesquisa.TabIndex = 26
        '
        'menuBar
        '
        Me.menuBar.BackColor = System.Drawing.SystemColors.Desktop
        Me.menuBar.Controls.Add(Me.homeBttn)
        Me.menuBar.Controls.Add(Me.PictureBox1)
        Me.menuBar.Controls.Add(Me.goBack)
        Me.menuBar.Location = New System.Drawing.Point(-7, -11)
        Me.menuBar.Name = "menuBar"
        Me.menuBar.Size = New System.Drawing.Size(1086, 92)
        Me.menuBar.TabIndex = 31
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(33, 318)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 20)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "FILTROS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(922, 592)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 20)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Total:"
        '
        'totalTxtBox
        '
        Me.totalTxtBox.Location = New System.Drawing.Point(973, 589)
        Me.totalTxtBox.Name = "totalTxtBox"
        Me.totalTxtBox.ReadOnly = True
        Me.totalTxtBox.Size = New System.Drawing.Size(58, 27)
        Me.totalTxtBox.TabIndex = 35
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckMissao)
        Me.GroupBox1.Controls.Add(Me.CheckAll)
        Me.GroupBox1.Controls.Add(Me.CheckRamo)
        Me.GroupBox1.Controls.Add(Me.CheckBase)
        Me.GroupBox1.Controls.Add(Me.CheckNasc)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(33, 341)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(501, 238)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        '
        'CheckMissao
        '
        Me.CheckMissao.AutoSize = True
        Me.CheckMissao.Location = New System.Drawing.Point(174, 95)
        Me.CheckMissao.Name = "CheckMissao"
        Me.CheckMissao.Size = New System.Drawing.Size(125, 24)
        Me.CheckMissao.TabIndex = 25
        Me.CheckMissao.Text = "Nº de Missões"
        Me.CheckMissao.UseVisualStyleBackColor = True
        '
        'pesquisaBttn
        '
        Me.pesquisaBttn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pesquisaBttn.Image = CType(resources.GetObject("pesquisaBttn.Image"), System.Drawing.Image)
        Me.pesquisaBttn.Location = New System.Drawing.Point(506, 233)
        Me.pesquisaBttn.Name = "pesquisaBttn"
        Me.pesquisaBttn.Size = New System.Drawing.Size(28, 27)
        Me.pesquisaBttn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pesquisaBttn.TabIndex = 20
        Me.pesquisaBttn.TabStop = False
        '
        'militares
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1071, 632)
        Me.Controls.Add(Me.pesquisaBttn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.totalTxtBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.menuBar)
        Me.Controls.Add(Me.TBpesquisa)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "militares"
        Me.Text = " "
        Me.menuBar.ResumeLayout(False)
        CType(Me.homeBttn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.goBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pesquisaBttn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckAll As CheckBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents CheckRamo As CheckBox
    Friend WithEvents CheckBase As CheckBox
    Friend WithEvents CheckNasc As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TBpesquisa As TextBox
    Friend WithEvents menuBar As GroupBox
    Friend WithEvents homeBttn As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents goBack As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents totalTxtBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CheckMissao As CheckBox
    Friend WithEvents pesquisaBttn As PictureBox
End Class
