﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.ButtonPelotao = New System.Windows.Forms.Button()
        Me.ButtonMissao = New System.Windows.Forms.Button()
        Me.Equipamento = New System.Windows.Forms.Button()
        Me.ButtonBases = New System.Windows.Forms.Button()
        Me.ButtonRamos = New System.Windows.Forms.Button()
        Me.ButtonMilitar = New System.Windows.Forms.Button()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(698, -178)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "RAMOS"
        '
        'PictureBox4
        '
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(834, 50)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(180, 105)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 16
        Me.PictureBox4.TabStop = False
        '
        'ButtonPelotao
        '
        Me.ButtonPelotao.Location = New System.Drawing.Point(745, 422)
        Me.ButtonPelotao.Name = "ButtonPelotao"
        Me.ButtonPelotao.Size = New System.Drawing.Size(241, 149)
        Me.ButtonPelotao.TabIndex = 15
        Me.ButtonPelotao.Text = "Pelotão"
        Me.ButtonPelotao.UseVisualStyleBackColor = True
        '
        'ButtonMissao
        '
        Me.ButtonMissao.Location = New System.Drawing.Point(452, 422)
        Me.ButtonMissao.Name = "ButtonMissao"
        Me.ButtonMissao.Size = New System.Drawing.Size(241, 149)
        Me.ButtonMissao.TabIndex = 14
        Me.ButtonMissao.Text = "Missão"
        Me.ButtonMissao.UseVisualStyleBackColor = True
        '
        'Equipamento
        '
        Me.Equipamento.Location = New System.Drawing.Point(168, 422)
        Me.Equipamento.Name = "Equipamento"
        Me.Equipamento.Size = New System.Drawing.Size(241, 149)
        Me.Equipamento.TabIndex = 13
        Me.Equipamento.Text = "Equipamento"
        Me.Equipamento.UseVisualStyleBackColor = True
        '
        'ButtonBases
        '
        Me.ButtonBases.Location = New System.Drawing.Point(745, 237)
        Me.ButtonBases.Name = "ButtonBases"
        Me.ButtonBases.Size = New System.Drawing.Size(241, 149)
        Me.ButtonBases.TabIndex = 12
        Me.ButtonBases.Text = "Bases Militares"
        Me.ButtonBases.UseVisualStyleBackColor = True
        '
        'ButtonRamos
        '
        Me.ButtonRamos.Location = New System.Drawing.Point(452, 237)
        Me.ButtonRamos.Name = "ButtonRamos"
        Me.ButtonRamos.Size = New System.Drawing.Size(241, 149)
        Me.ButtonRamos.TabIndex = 11
        Me.ButtonRamos.Text = "Ramos"
        Me.ButtonRamos.UseVisualStyleBackColor = True
        '
        'ButtonMilitar
        '
        Me.ButtonMilitar.Location = New System.Drawing.Point(168, 237)
        Me.ButtonMilitar.Name = "ButtonMilitar"
        Me.ButtonMilitar.Size = New System.Drawing.Size(241, 149)
        Me.ButtonMilitar.TabIndex = 10
        Me.ButtonMilitar.Text = "Militares"
        Me.ButtonMilitar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1071, 632)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.ButtonPelotao)
        Me.Controls.Add(Me.ButtonMissao)
        Me.Controls.Add(Me.Equipamento)
        Me.Controls.Add(Me.ButtonBases)
        Me.Controls.Add(Me.ButtonRamos)
        Me.Controls.Add(Me.ButtonMilitar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents ButtonPelotao As Button
    Friend WithEvents ButtonMissao As Button
    Friend WithEvents Equipamento As Button
    Friend WithEvents ButtonBases As Button
    Friend WithEvents ButtonRamos As Button
    Friend WithEvents ButtonMilitar As Button
End Class