<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Juego
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Juego))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnLanzarDos = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnAcomular = New System.Windows.Forms.Button()
        Me.btnLanzarUno = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblPuntajeTurno = New System.Windows.Forms.Label()
        Me.lblPuntaje1 = New System.Windows.Forms.Label()
        Me.lblPuntos2 = New System.Windows.Forms.Label()
        Me.lblPuntos1 = New System.Windows.Forms.Label()
        Me.lblPuntaje2 = New System.Windows.Forms.Label()
        Me.ptbDados = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.ptbDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLanzarDos
        '
        Me.btnLanzarDos.BackColor = System.Drawing.Color.Transparent
        Me.btnLanzarDos.BackgroundImage = Global.Juego.My.Resources.Resources.siguiente_icono_5491_64
        Me.btnLanzarDos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnLanzarDos.Location = New System.Drawing.Point(466, 129)
        Me.btnLanzarDos.Name = "btnLanzarDos"
        Me.btnLanzarDos.Size = New System.Drawing.Size(90, 90)
        Me.btnLanzarDos.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.btnLanzarDos, "Tirar")
        Me.btnLanzarDos.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Transparent
        Me.btnSalir.BackgroundImage = Global.Juego.My.Resources.Resources.liberar_icono_7141_64
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSalir.Location = New System.Drawing.Point(466, 214)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(90, 90)
        Me.btnSalir.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.btnSalir, "Salir")
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnAcomular
        '
        Me.btnAcomular.BackgroundImage = Global.Juego.My.Resources.Resources.flechas_cambiar_icono_6893_48
        Me.btnAcomular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAcomular.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAcomular.Location = New System.Drawing.Point(41, 234)
        Me.btnAcomular.Name = "btnAcomular"
        Me.btnAcomular.Size = New System.Drawing.Size(60, 50)
        Me.btnAcomular.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.btnAcomular, "Plantarse")
        Me.btnAcomular.UseVisualStyleBackColor = True
        '
        'btnLanzarUno
        '
        Me.btnLanzarUno.BackColor = System.Drawing.Color.Transparent
        Me.btnLanzarUno.BackgroundImage = Global.Juego.My.Resources.Resources.siguiente_icono_5491_64
        Me.btnLanzarUno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnLanzarUno.Location = New System.Drawing.Point(26, 126)
        Me.btnLanzarUno.Name = "btnLanzarUno"
        Me.btnLanzarUno.Size = New System.Drawing.Size(90, 90)
        Me.btnLanzarUno.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.btnLanzarUno, "Tirar")
        Me.btnLanzarUno.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Juego.My.Resources.Resources.roll_dice_gambling_casino_560x224
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.lblPuntajeTurno)
        Me.Panel1.Controls.Add(Me.lblPuntaje1)
        Me.Panel1.Controls.Add(Me.lblPuntos2)
        Me.Panel1.Controls.Add(Me.lblPuntos1)
        Me.Panel1.Controls.Add(Me.lblPuntaje2)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(578, 90)
        Me.Panel1.TabIndex = 11
        '
        'lblPuntajeTurno
        '
        Me.lblPuntajeTurno.AutoSize = True
        Me.lblPuntajeTurno.BackColor = System.Drawing.Color.Transparent
        Me.lblPuntajeTurno.Font = New System.Drawing.Font("Rockwell", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblPuntajeTurno.ForeColor = System.Drawing.Color.White
        Me.lblPuntajeTurno.Location = New System.Drawing.Point(272, 41)
        Me.lblPuntajeTurno.Name = "lblPuntajeTurno"
        Me.lblPuntajeTurno.Size = New System.Drawing.Size(34, 26)
        Me.lblPuntajeTurno.TabIndex = 11
        Me.lblPuntajeTurno.Text = "00"
        '
        'lblPuntaje1
        '
        Me.lblPuntaje1.AutoSize = True
        Me.lblPuntaje1.BackColor = System.Drawing.Color.Transparent
        Me.lblPuntaje1.Font = New System.Drawing.Font("Rockwell", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPuntaje1.ForeColor = System.Drawing.Color.White
        Me.lblPuntaje1.Location = New System.Drawing.Point(12, 18)
        Me.lblPuntaje1.Name = "lblPuntaje1"
        Me.lblPuntaje1.Size = New System.Drawing.Size(90, 26)
        Me.lblPuntaje1.TabIndex = 7
        Me.lblPuntaje1.Text = "Puntaje"
        '
        'lblPuntos2
        '
        Me.lblPuntos2.AutoSize = True
        Me.lblPuntos2.BackColor = System.Drawing.Color.Transparent
        Me.lblPuntos2.Font = New System.Drawing.Font("Rockwell", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblPuntos2.ForeColor = System.Drawing.Color.White
        Me.lblPuntos2.Location = New System.Drawing.Point(522, 18)
        Me.lblPuntos2.Name = "lblPuntos2"
        Me.lblPuntos2.Size = New System.Drawing.Size(34, 26)
        Me.lblPuntos2.TabIndex = 10
        Me.lblPuntos2.Text = "00"
        '
        'lblPuntos1
        '
        Me.lblPuntos1.AutoSize = True
        Me.lblPuntos1.BackColor = System.Drawing.Color.Transparent
        Me.lblPuntos1.Font = New System.Drawing.Font("Rockwell", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblPuntos1.ForeColor = System.Drawing.Color.White
        Me.lblPuntos1.Location = New System.Drawing.Point(131, 18)
        Me.lblPuntos1.Name = "lblPuntos1"
        Me.lblPuntos1.Size = New System.Drawing.Size(34, 26)
        Me.lblPuntos1.TabIndex = 9
        Me.lblPuntos1.Text = "00"
        '
        'lblPuntaje2
        '
        Me.lblPuntaje2.AutoSize = True
        Me.lblPuntaje2.BackColor = System.Drawing.Color.Transparent
        Me.lblPuntaje2.Font = New System.Drawing.Font("Rockwell", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblPuntaje2.ForeColor = System.Drawing.Color.White
        Me.lblPuntaje2.Location = New System.Drawing.Point(410, 18)
        Me.lblPuntaje2.Name = "lblPuntaje2"
        Me.lblPuntaje2.Size = New System.Drawing.Size(90, 26)
        Me.lblPuntaje2.TabIndex = 8
        Me.lblPuntaje2.Text = "Puntaje"
        '
        'ptbDados
        '
        Me.ptbDados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ptbDados.Image = Global.Juego.My.Resources.Resources._1
        Me.ptbDados.Location = New System.Drawing.Point(250, 153)
        Me.ptbDados.Name = "ptbDados"
        Me.ptbDados.Size = New System.Drawing.Size(90, 90)
        Me.ptbDados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbDados.TabIndex = 6
        Me.ptbDados.TabStop = False
        '
        'Juego
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(578, 336)
        Me.Controls.Add(Me.btnLanzarDos)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ptbDados)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAcomular)
        Me.Controls.Add(Me.btnLanzarUno)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Juego"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Juego"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ptbDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnLanzarUno As System.Windows.Forms.Button
    Friend WithEvents btnAcomular As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents ptbDados As System.Windows.Forms.PictureBox
    Friend WithEvents lblPuntaje1 As System.Windows.Forms.Label
    Friend WithEvents lblPuntaje2 As System.Windows.Forms.Label
    Friend WithEvents lblPuntos1 As System.Windows.Forms.Label
    Friend WithEvents lblPuntos2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lblPuntajeTurno As System.Windows.Forms.Label
    Friend WithEvents btnLanzarDos As System.Windows.Forms.Button
End Class
