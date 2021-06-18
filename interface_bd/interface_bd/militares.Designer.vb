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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
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
        Me.subclasse = New System.Windows.Forms.ComboBox()
        Me.resetBttn = New System.Windows.Forms.Button()
        Me.DispDD = New System.Windows.Forms.ComboBox()
        Me.ApplyFilters = New System.Windows.Forms.Button()
        Me.MissoesDD = New System.Windows.Forms.ComboBox()
        Me.CargoDD = New System.Windows.Forms.ComboBox()
        Me.NacDD = New System.Windows.Forms.ComboBox()
        Me.RamoDD = New System.Windows.Forms.ComboBox()
        Me.BaseDD = New System.Windows.Forms.ComboBox()
        Me.pesquisaBttn = New System.Windows.Forms.PictureBox()
        Me.stateDD = New System.Windows.Forms.ComboBox()
        Me.menuBar.SuspendLayout()
        CType(Me.homeBttn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.goBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pesquisaBttn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Label2.Location = New System.Drawing.Point(33, 299)
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
        Me.GroupBox1.Controls.Add(Me.stateDD)
        Me.GroupBox1.Controls.Add(Me.subclasse)
        Me.GroupBox1.Controls.Add(Me.resetBttn)
        Me.GroupBox1.Controls.Add(Me.DispDD)
        Me.GroupBox1.Controls.Add(Me.ApplyFilters)
        Me.GroupBox1.Controls.Add(Me.MissoesDD)
        Me.GroupBox1.Controls.Add(Me.CargoDD)
        Me.GroupBox1.Controls.Add(Me.NacDD)
        Me.GroupBox1.Controls.Add(Me.RamoDD)
        Me.GroupBox1.Controls.Add(Me.BaseDD)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(33, 322)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(501, 257)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        '
        'subclasse
        '
        Me.subclasse.FormattingEnabled = True
        Me.subclasse.Location = New System.Drawing.Point(31, 26)
        Me.subclasse.Name = "subclasse"
        Me.subclasse.Size = New System.Drawing.Size(179, 28)
        Me.subclasse.TabIndex = 35
        Me.subclasse.Text = "Funcao"
        '
        'resetBttn
        '
        Me.resetBttn.Location = New System.Drawing.Point(77, 213)
        Me.resetBttn.Name = "resetBttn"
        Me.resetBttn.Size = New System.Drawing.Size(133, 29)
        Me.resetBttn.TabIndex = 34
        Me.resetBttn.Text = "Reset"
        Me.resetBttn.UseVisualStyleBackColor = True
        '
        'DispDD
        '
        Me.DispDD.AutoCompleteCustomSource.AddRange(New String() {"Em Missão", "Disponível"})
        Me.DispDD.FormattingEnabled = True
        Me.DispDD.Location = New System.Drawing.Point(260, 168)
        Me.DispDD.Name = "DispDD"
        Me.DispDD.Size = New System.Drawing.Size(187, 28)
        Me.DispDD.TabIndex = 33
        Me.DispDD.Text = "Disponibilidade"
        '
        'ApplyFilters
        '
        Me.ApplyFilters.Location = New System.Drawing.Point(260, 213)
        Me.ApplyFilters.Name = "ApplyFilters"
        Me.ApplyFilters.Size = New System.Drawing.Size(133, 29)
        Me.ApplyFilters.TabIndex = 31
        Me.ApplyFilters.Text = "Apply"
        Me.ApplyFilters.UseVisualStyleBackColor = True
        '
        'MissoesDD
        '
        Me.MissoesDD.FormattingEnabled = True
        Me.MissoesDD.Location = New System.Drawing.Point(327, 123)
        Me.MissoesDD.Name = "MissoesDD"
        Me.MissoesDD.Size = New System.Drawing.Size(120, 28)
        Me.MissoesDD.TabIndex = 30
        Me.MissoesDD.Text = "Nº Missoes"
        '
        'CargoDD
        '
        Me.CargoDD.FormattingEnabled = True
        Me.CargoDD.Location = New System.Drawing.Point(327, 74)
        Me.CargoDD.Name = "CargoDD"
        Me.CargoDD.Size = New System.Drawing.Size(120, 28)
        Me.CargoDD.TabIndex = 29
        Me.CargoDD.Text = "Cargo"
        '
        'NacDD
        '
        Me.NacDD.FormattingEnabled = True
        Me.NacDD.Location = New System.Drawing.Point(31, 168)
        Me.NacDD.Name = "NacDD"
        Me.NacDD.Size = New System.Drawing.Size(179, 28)
        Me.NacDD.TabIndex = 28
        Me.NacDD.Text = "Nacionalidade"
        '
        'RamoDD
        '
        Me.RamoDD.FormattingEnabled = True
        Me.RamoDD.Location = New System.Drawing.Point(31, 123)
        Me.RamoDD.Name = "RamoDD"
        Me.RamoDD.Size = New System.Drawing.Size(262, 28)
        Me.RamoDD.TabIndex = 27
        Me.RamoDD.Text = "Ramo"
        '
        'BaseDD
        '
        Me.BaseDD.AccessibleName = ""
        Me.BaseDD.FormattingEnabled = True
        Me.BaseDD.Location = New System.Drawing.Point(31, 74)
        Me.BaseDD.Name = "BaseDD"
        Me.BaseDD.Size = New System.Drawing.Size(262, 28)
        Me.BaseDD.TabIndex = 26
        Me.BaseDD.Text = "Base"
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
        'stateDD
        '
        Me.stateDD.FormattingEnabled = True
        Me.stateDD.Location = New System.Drawing.Point(260, 26)
        Me.stateDD.Name = "stateDD"
        Me.stateDD.Size = New System.Drawing.Size(187, 28)
        Me.stateDD.TabIndex = 36
        Me.stateDD.Text = "Estado"
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
        CType(Me.pesquisaBttn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As ListBox
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
    Friend WithEvents pesquisaBttn As PictureBox
    Friend WithEvents BaseDD As ComboBox
    Friend WithEvents RamoDD As ComboBox
    Friend WithEvents MissoesDD As ComboBox
    Friend WithEvents CargoDD As ComboBox
    Friend WithEvents NacDD As ComboBox
    Friend WithEvents ApplyFilters As Button
    Friend WithEvents DispDD As ComboBox
    Friend WithEvents resetBttn As Button
    Friend WithEvents subclasse As ComboBox
    Friend WithEvents stateDD As ComboBox
End Class
