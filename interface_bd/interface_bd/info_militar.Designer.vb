<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class info_militar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(info_militar))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBnome = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBmorada = New System.Windows.Forms.TextBox()
        Me.TBtel = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nomeMiss = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CheckMissao = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Arma = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Veic = New System.Windows.Forms.TextBox()
        Me.BoxMissao = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tipoMiss = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TBcargo = New System.Windows.Forms.TextBox()
        Me.TBtipo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.menuBar = New System.Windows.Forms.GroupBox()
        Me.homeBttn = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.goBack = New System.Windows.Forms.PictureBox()
        Me.TBnCC = New System.Windows.Forms.TextBox()
        Me.nCC = New System.Windows.Forms.Label()
        Me.TBnac = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TBnMiss = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Espec = New System.Windows.Forms.TextBox()
        Me.TipoSol = New System.Windows.Forms.TextBox()
        Me.EspecLabel = New System.Windows.Forms.Label()
        Me.TpSolLabel = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.emailLab = New System.Windows.Forms.Label()
        Me.TBemail = New System.Windows.Forms.TextBox()
        Me.lname = New System.Windows.Forms.TextBox()
        Me.fname = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.dnascTB = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tSolCC = New System.Windows.Forms.ComboBox()
        Me.especCC = New System.Windows.Forms.ComboBox()
        Me.BaseCC = New System.Windows.Forms.ComboBox()
        Me.RamoCC = New System.Windows.Forms.ComboBox()
        Me.tmCC = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.CargoCC = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.baseTT = New System.Windows.Forms.TextBox()
        Me.ramoTT = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.State = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.submit = New System.Windows.Forms.Button()
        Me.useArmaBttn = New System.Windows.Forms.Button()
        Me.useVeiculoBttn = New System.Windows.Forms.Button()
        Me.BoxMissao.SuspendLayout()
        Me.menuBar.SuspendLayout()
        CType(Me.homeBttn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.goBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(70, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 20)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Nome"
        '
        'TBnome
        '
        Me.TBnome.Location = New System.Drawing.Point(135, 65)
        Me.TBnome.Name = "TBnome"
        Me.TBnome.ReadOnly = True
        Me.TBnome.Size = New System.Drawing.Size(308, 27)
        Me.TBnome.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(104, 241)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 20)
        Me.Label2.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(63, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 20)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Morada"
        '
        'TBmorada
        '
        Me.TBmorada.Location = New System.Drawing.Point(138, 109)
        Me.TBmorada.MaxLength = 100
        Me.TBmorada.Name = "TBmorada"
        Me.TBmorada.PlaceholderText = "Rua X n Y 999-99"
        Me.TBmorada.ReadOnly = True
        Me.TBmorada.Size = New System.Drawing.Size(308, 27)
        Me.TBmorada.TabIndex = 25
        '
        'TBtel
        '
        Me.TBtel.Location = New System.Drawing.Point(138, 150)
        Me.TBtel.MaxLength = 9
        Me.TBtel.Name = "TBtel"
        Me.TBtel.PlaceholderText = "9 digits"
        Me.TBtel.ReadOnly = True
        Me.TBtel.Size = New System.Drawing.Size(308, 27)
        Me.TBtel.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(58, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 20)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Telefone"
        '
        'nomeMiss
        '
        Me.nomeMiss.Location = New System.Drawing.Point(117, 29)
        Me.nomeMiss.Name = "nomeMiss"
        Me.nomeMiss.ReadOnly = True
        Me.nomeMiss.Size = New System.Drawing.Size(135, 27)
        Me.nomeMiss.TabIndex = 28
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 20)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Arma usada"
        '
        'CheckMissao
        '
        Me.CheckMissao.AutoSize = True
        Me.CheckMissao.Enabled = False
        Me.CheckMissao.Location = New System.Drawing.Point(120, 444)
        Me.CheckMissao.Name = "CheckMissao"
        Me.CheckMissao.Size = New System.Drawing.Size(18, 17)
        Me.CheckMissao.TabIndex = 30
        Me.CheckMissao.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(34, 441)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 20)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Em Missão"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(56, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 20)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Missão"
        '
        'Arma
        '
        Me.Arma.Location = New System.Drawing.Point(117, 70)
        Me.Arma.Name = "Arma"
        Me.Arma.ReadOnly = True
        Me.Arma.Size = New System.Drawing.Size(368, 27)
        Me.Arma.TabIndex = 33
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 108)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 20)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Veículo usado"
        '
        'Veic
        '
        Me.Veic.Location = New System.Drawing.Point(117, 108)
        Me.Veic.Name = "Veic"
        Me.Veic.ReadOnly = True
        Me.Veic.Size = New System.Drawing.Size(368, 27)
        Me.Veic.TabIndex = 35
        '
        'BoxMissao
        '
        Me.BoxMissao.Controls.Add(Me.Label13)
        Me.BoxMissao.Controls.Add(Me.tipoMiss)
        Me.BoxMissao.Controls.Add(Me.Label8)
        Me.BoxMissao.Controls.Add(Me.Veic)
        Me.BoxMissao.Controls.Add(Me.Label7)
        Me.BoxMissao.Controls.Add(Me.Arma)
        Me.BoxMissao.Controls.Add(Me.Label5)
        Me.BoxMissao.Controls.Add(Me.nomeMiss)
        Me.BoxMissao.Location = New System.Drawing.Point(34, 467)
        Me.BoxMissao.Name = "BoxMissao"
        Me.BoxMissao.Size = New System.Drawing.Size(520, 152)
        Me.BoxMissao.TabIndex = 36
        Me.BoxMissao.TabStop = False
        Me.BoxMissao.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(286, 33)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 20)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "Missão"
        '
        'tipoMiss
        '
        Me.tipoMiss.Location = New System.Drawing.Point(347, 30)
        Me.tipoMiss.Name = "tipoMiss"
        Me.tipoMiss.ReadOnly = True
        Me.tipoMiss.Size = New System.Drawing.Size(135, 27)
        Me.tipoMiss.TabIndex = 36
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(617, 186)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 20)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Tipo de Militar"
        '
        'TBcargo
        '
        Me.TBcargo.Location = New System.Drawing.Point(730, 140)
        Me.TBcargo.Name = "TBcargo"
        Me.TBcargo.ReadOnly = True
        Me.TBcargo.Size = New System.Drawing.Size(284, 27)
        Me.TBcargo.TabIndex = 38
        '
        'TBtipo
        '
        Me.TBtipo.Location = New System.Drawing.Point(730, 183)
        Me.TBtipo.Name = "TBtipo"
        Me.TBtipo.ReadOnly = True
        Me.TBtipo.Size = New System.Drawing.Size(284, 27)
        Me.TBtipo.TabIndex = 39
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(675, 143)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 20)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Cargo"
        '
        'menuBar
        '
        Me.menuBar.BackColor = System.Drawing.SystemColors.Desktop
        Me.menuBar.Controls.Add(Me.homeBttn)
        Me.menuBar.Controls.Add(Me.PictureBox1)
        Me.menuBar.Controls.Add(Me.goBack)
        Me.menuBar.Location = New System.Drawing.Point(-6, -11)
        Me.menuBar.Name = "menuBar"
        Me.menuBar.Size = New System.Drawing.Size(1086, 92)
        Me.menuBar.TabIndex = 41
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
        'TBnCC
        '
        Me.TBnCC.Location = New System.Drawing.Point(135, 26)
        Me.TBnCC.MaxLength = 9
        Me.TBnCC.Name = "TBnCC"
        Me.TBnCC.PlaceholderText = "9 digits"
        Me.TBnCC.ReadOnly = True
        Me.TBnCC.Size = New System.Drawing.Size(308, 27)
        Me.TBnCC.TabIndex = 42
        '
        'nCC
        '
        Me.nCC.AutoSize = True
        Me.nCC.Location = New System.Drawing.Point(85, 29)
        Me.nCC.Name = "nCC"
        Me.nCC.Size = New System.Drawing.Size(35, 20)
        Me.nCC.TabIndex = 43
        Me.nCC.Text = "nCC"
        '
        'TBnac
        '
        Me.TBnac.Location = New System.Drawing.Point(138, 194)
        Me.TBnac.MaxLength = 100
        Me.TBnac.Name = "TBnac"
        Me.TBnac.PlaceholderText = "Portuguesa"
        Me.TBnac.ReadOnly = True
        Me.TBnac.Size = New System.Drawing.Size(308, 27)
        Me.TBnac.TabIndex = 44
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(18, 197)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(106, 20)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "Nacionalidade"
        '
        'TBnMiss
        '
        Me.TBnMiss.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.TBnMiss.Location = New System.Drawing.Point(305, 438)
        Me.TBnMiss.Name = "TBnMiss"
        Me.TBnMiss.Size = New System.Drawing.Size(70, 27)
        Me.TBnMiss.TabIndex = 46
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(162, 441)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(137, 20)
        Me.Label12.TabIndex = 47
        Me.Label12.Text = "número de missões"
        '
        'Espec
        '
        Me.Espec.Location = New System.Drawing.Point(134, 254)
        Me.Espec.Name = "Espec"
        Me.Espec.ReadOnly = True
        Me.Espec.Size = New System.Drawing.Size(284, 27)
        Me.Espec.TabIndex = 48
        '
        'TipoSol
        '
        Me.TipoSol.Location = New System.Drawing.Point(133, 254)
        Me.TipoSol.Name = "TipoSol"
        Me.TipoSol.ReadOnly = True
        Me.TipoSol.Size = New System.Drawing.Size(284, 27)
        Me.TipoSol.TabIndex = 49
        '
        'EspecLabel
        '
        Me.EspecLabel.AutoSize = True
        Me.EspecLabel.Location = New System.Drawing.Point(18, 258)
        Me.EspecLabel.Name = "EspecLabel"
        Me.EspecLabel.Size = New System.Drawing.Size(101, 20)
        Me.EspecLabel.TabIndex = 50
        Me.EspecLabel.Text = "Especialidade"
        '
        'TpSolLabel
        '
        Me.TpSolLabel.AutoSize = True
        Me.TpSolLabel.Location = New System.Drawing.Point(-1, 258)
        Me.TpSolLabel.Name = "TpSolLabel"
        Me.TpSolLabel.Size = New System.Drawing.Size(120, 20)
        Me.TpSolLabel.TabIndex = 51
        Me.TpSolLabel.Text = "Tipo de Soldado"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.emailLab)
        Me.GroupBox1.Controls.Add(Me.TBemail)
        Me.GroupBox1.Controls.Add(Me.lname)
        Me.GroupBox1.Controls.Add(Me.fname)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.dnascTB)
        Me.GroupBox1.Controls.Add(Me.TBnac)
        Me.GroupBox1.Controls.Add(Me.nCC)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.TBnCC)
        Me.GroupBox1.Controls.Add(Me.TBnome)
        Me.GroupBox1.Controls.Add(Me.TBmorada)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TBtel)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(34, 109)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(520, 311)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        '
        'emailLab
        '
        Me.emailLab.AutoSize = True
        Me.emailLab.Location = New System.Drawing.Point(70, 238)
        Me.emailLab.Name = "emailLab"
        Me.emailLab.Size = New System.Drawing.Size(46, 20)
        Me.emailLab.TabIndex = 48
        Me.emailLab.Text = "email"
        '
        'TBemail
        '
        Me.TBemail.Location = New System.Drawing.Point(138, 235)
        Me.TBemail.MaxLength = 100
        Me.TBemail.Name = "TBemail"
        Me.TBemail.PlaceholderText = "you@fcp.pt"
        Me.TBemail.ReadOnly = True
        Me.TBemail.Size = New System.Drawing.Size(308, 27)
        Me.TBemail.TabIndex = 47
        '
        'lname
        '
        Me.lname.Location = New System.Drawing.Point(301, 65)
        Me.lname.MaxLength = 25
        Me.lname.Name = "lname"
        Me.lname.PlaceholderText = "Segundo Nome"
        Me.lname.Size = New System.Drawing.Size(141, 27)
        Me.lname.TabIndex = 46
        '
        'fname
        '
        Me.fname.Location = New System.Drawing.Point(135, 65)
        Me.fname.MaxLength = 25
        Me.fname.Name = "fname"
        Me.fname.PlaceholderText = "Primeiro Nome"
        Me.fname.Size = New System.Drawing.Size(143, 27)
        Me.fname.TabIndex = 45
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(48, 276)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(77, 20)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "Data Nasc"
        '
        'dnascTB
        '
        Me.dnascTB.Location = New System.Drawing.Point(139, 273)
        Me.dnascTB.MaxLength = 10
        Me.dnascTB.Name = "dnascTB"
        Me.dnascTB.PlaceholderText = "DD/MM/YYYY"
        Me.dnascTB.ReadOnly = True
        Me.dnascTB.Size = New System.Drawing.Size(308, 27)
        Me.dnascTB.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(34, 95)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(110, 20)
        Me.Label14.TabIndex = 53
        Me.Label14.Text = "Dados Pessoais"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tSolCC)
        Me.GroupBox2.Controls.Add(Me.especCC)
        Me.GroupBox2.Controls.Add(Me.BaseCC)
        Me.GroupBox2.Controls.Add(Me.RamoCC)
        Me.GroupBox2.Controls.Add(Me.tmCC)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.CargoCC)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.baseTT)
        Me.GroupBox2.Controls.Add(Me.ramoTT)
        Me.GroupBox2.Controls.Add(Me.Espec)
        Me.GroupBox2.Controls.Add(Me.TipoSol)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.State)
        Me.GroupBox2.Controls.Add(Me.EspecLabel)
        Me.GroupBox2.Controls.Add(Me.TpSolLabel)
        Me.GroupBox2.Location = New System.Drawing.Point(596, 109)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(446, 311)
        Me.GroupBox2.TabIndex = 54
        Me.GroupBox2.TabStop = False
        '
        'tSolCC
        '
        Me.tSolCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tSolCC.FormattingEnabled = True
        Me.tSolCC.Location = New System.Drawing.Point(133, 253)
        Me.tSolCC.Name = "tSolCC"
        Me.tSolCC.Size = New System.Drawing.Size(179, 28)
        Me.tSolCC.TabIndex = 57
        '
        'especCC
        '
        Me.especCC.FormattingEnabled = True
        Me.especCC.Location = New System.Drawing.Point(133, 253)
        Me.especCC.Name = "especCC"
        Me.especCC.Size = New System.Drawing.Size(179, 28)
        Me.especCC.TabIndex = 56
        '
        'BaseCC
        '
        Me.BaseCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BaseCC.FormattingEnabled = True
        Me.BaseCC.Location = New System.Drawing.Point(134, 165)
        Me.BaseCC.Name = "BaseCC"
        Me.BaseCC.Size = New System.Drawing.Size(178, 28)
        Me.BaseCC.TabIndex = 55
        '
        'RamoCC
        '
        Me.RamoCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RamoCC.FormattingEnabled = True
        Me.RamoCC.Location = New System.Drawing.Point(133, 118)
        Me.RamoCC.Name = "RamoCC"
        Me.RamoCC.Size = New System.Drawing.Size(179, 28)
        Me.RamoCC.TabIndex = 54
        '
        'tmCC
        '
        Me.tmCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tmCC.FormattingEnabled = True
        Me.tmCC.Location = New System.Drawing.Point(134, 74)
        Me.tmCC.Name = "tmCC"
        Me.tmCC.Size = New System.Drawing.Size(178, 28)
        Me.tmCC.TabIndex = 53
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(79, 172)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(40, 20)
        Me.Label19.TabIndex = 52
        Me.Label19.Text = "Base"
        '
        'CargoCC
        '
        Me.CargoCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CargoCC.FormattingEnabled = True
        Me.CargoCC.Location = New System.Drawing.Point(133, 31)
        Me.CargoCC.Name = "CargoCC"
        Me.CargoCC.Size = New System.Drawing.Size(179, 28)
        Me.CargoCC.TabIndex = 52
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(74, 121)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(48, 20)
        Me.Label18.TabIndex = 51
        Me.Label18.Text = "Ramo"
        '
        'baseTT
        '
        Me.baseTT.Location = New System.Drawing.Point(134, 165)
        Me.baseTT.Name = "baseTT"
        Me.baseTT.ReadOnly = True
        Me.baseTT.Size = New System.Drawing.Size(284, 27)
        Me.baseTT.TabIndex = 50
        '
        'ramoTT
        '
        Me.ramoTT.Location = New System.Drawing.Point(133, 118)
        Me.ramoTT.Name = "ramoTT"
        Me.ramoTT.ReadOnly = True
        Me.ramoTT.Size = New System.Drawing.Size(284, 27)
        Me.ramoTT.TabIndex = 49
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(68, 213)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(54, 20)
        Me.Label16.TabIndex = 48
        Me.Label16.Text = "Estado"
        '
        'State
        '
        Me.State.Location = New System.Drawing.Point(134, 209)
        Me.State.Name = "State"
        Me.State.ReadOnly = True
        Me.State.Size = New System.Drawing.Size(284, 27)
        Me.State.TabIndex = 47
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(596, 95)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(105, 20)
        Me.Label15.TabIndex = 55
        Me.Label15.Text = "Especificacoes"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(788, 567)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 42)
        Me.Button1.TabIndex = 56
        Me.Button1.Text = "Reformar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'submit
        '
        Me.submit.Location = New System.Drawing.Point(507, 454)
        Me.submit.Name = "submit"
        Me.submit.Size = New System.Drawing.Size(138, 77)
        Me.submit.TabIndex = 57
        Me.submit.Text = "Submit"
        Me.submit.UseVisualStyleBackColor = True
        '
        'useArmaBttn
        '
        Me.useArmaBttn.Location = New System.Drawing.Point(698, 454)
        Me.useArmaBttn.Name = "useArmaBttn"
        Me.useArmaBttn.Size = New System.Drawing.Size(132, 80)
        Me.useArmaBttn.TabIndex = 58
        Me.useArmaBttn.Text = "Armas"
        Me.useArmaBttn.UseVisualStyleBackColor = True
        '
        'useVeiculoBttn
        '
        Me.useVeiculoBttn.Location = New System.Drawing.Point(859, 454)
        Me.useVeiculoBttn.Name = "useVeiculoBttn"
        Me.useVeiculoBttn.Size = New System.Drawing.Size(139, 80)
        Me.useVeiculoBttn.TabIndex = 59
        Me.useVeiculoBttn.Text = "Veiculos"
        Me.useVeiculoBttn.UseVisualStyleBackColor = True
        '
        'info_militar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1077, 632)
        Me.Controls.Add(Me.useVeiculoBttn)
        Me.Controls.Add(Me.useArmaBttn)
        Me.Controls.Add(Me.submit)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TBnMiss)
        Me.Controls.Add(Me.menuBar)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TBtipo)
        Me.Controls.Add(Me.TBcargo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.BoxMissao)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CheckMissao)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "info_militar"
        Me.Text = "Força de Combate Portuguesa"
        Me.BoxMissao.ResumeLayout(False)
        Me.BoxMissao.PerformLayout()
        Me.menuBar.ResumeLayout(False)
        CType(Me.homeBttn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.goBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents TBnome As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TBmorada As TextBox
    Friend WithEvents TBtel As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents nomeMiss As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CheckMissao As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Arma As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Veic As TextBox
    Friend WithEvents BoxMissao As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TBcargo As TextBox
    Friend WithEvents TBtipo As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents menuBar As GroupBox
    Friend WithEvents homeBttn As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents goBack As PictureBox
    Friend WithEvents TBnCC As TextBox
    Friend WithEvents nCC As Label
    Friend WithEvents TBnac As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TBnMiss As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents tipoMiss As TextBox
    Friend WithEvents Espec As TextBox
    Friend WithEvents TipoSol As TextBox
    Friend WithEvents EspecLabel As Label
    Friend WithEvents TpSolLabel As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents State As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents dnascTB As TextBox
    Friend WithEvents ramoTT As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents baseTT As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents tmCC As ComboBox
    Friend WithEvents CargoCC As ComboBox
    Friend WithEvents submit As Button
    Friend WithEvents tSolCC As ComboBox
    Friend WithEvents especCC As ComboBox
    Friend WithEvents BaseCC As ComboBox
    Friend WithEvents RamoCC As ComboBox
    Friend WithEvents lname As TextBox
    Friend WithEvents fname As TextBox
    Friend WithEvents emailLab As Label
    Friend WithEvents TBemail As TextBox
    Friend WithEvents useArmaBttn As Button
    Friend WithEvents useVeiculoBttn As Button
End Class
