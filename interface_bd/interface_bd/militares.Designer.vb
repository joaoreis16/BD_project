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
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.menuBar = New System.Windows.Forms.GroupBox()
        Me.homeBttn = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.goBack = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.totalTxtBox = New System.Windows.Forms.TextBox()
        Me.menuBar.SuspendLayout()
        CType(Me.homeBttn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.goBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CheckAll
        '
        Me.CheckAll.AutoSize = True
        Me.CheckAll.Location = New System.Drawing.Point(38, 353)
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
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(118, 353)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(70, 24)
        Me.CheckBox1.TabIndex = 22
        Me.CheckBox1.Text = "Ramo"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(234, 353)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(109, 24)
        Me.CheckBox2.TabIndex = 23
        Me.CheckBox2.Text = "Base Militar"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(391, 353)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(128, 24)
        Me.CheckBox3.TabIndex = 24
        Me.CheckBox3.Text = "Nacionalidade"
        Me.CheckBox3.UseVisualStyleBackColor = True
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
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(33, 233)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(501, 27)
        Me.TextBox1.TabIndex = 26
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
        Me.Label4.Location = New System.Drawing.Point(922, 603)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 20)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Total:"
        '
        'totalTxtBox
        '
        Me.totalTxtBox.Location = New System.Drawing.Point(973, 600)
        Me.totalTxtBox.Name = "totalTxtBox"
        Me.totalTxtBox.ReadOnly = True
        Me.totalTxtBox.Size = New System.Drawing.Size(58, 27)
        Me.totalTxtBox.TabIndex = 35
        '
        'militares
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1071, 632)
        Me.Controls.Add(Me.totalTxtBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.menuBar)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.CheckAll)
        Me.Name = "militares"
        Me.Text = " "
        Me.menuBar.ResumeLayout(False)
        CType(Me.homeBttn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.goBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckAll As CheckBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents menuBar As GroupBox
    Friend WithEvents homeBttn As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents goBack As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents totalTxtBox As TextBox
End Class
