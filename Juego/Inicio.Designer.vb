<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.BtnDosJugadores = New System.Windows.Forms.Button()
        Me.btnUnjugador = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Juego.My.Resources.Resources.Imagen_de_inicio
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.btnSalir)
        Me.Panel1.Controls.Add(Me.BtnDosJugadores)
        Me.Panel1.Controls.Add(Me.btnUnjugador)
        Me.Panel1.Controls.Add(Me.lblTitulo)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(506, 280)
        Me.Panel1.TabIndex = 0
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSalir.Image = Global.Juego.My.Resources.Resources.cerrar_borrar_la_salida_icono_8537_48
        Me.btnSalir.Location = New System.Drawing.Point(215, 201)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(91, 49)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'BtnDosJugadores
        '
        Me.BtnDosJugadores.BackColor = System.Drawing.Color.SaddleBrown
        Me.BtnDosJugadores.Font = New System.Drawing.Font("Rockwell", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDosJugadores.ForeColor = System.Drawing.Color.White
        Me.BtnDosJugadores.Location = New System.Drawing.Point(191, 154)
        Me.BtnDosJugadores.Name = "BtnDosJugadores"
        Me.BtnDosJugadores.Size = New System.Drawing.Size(135, 41)
        Me.BtnDosJugadores.TabIndex = 2
        Me.BtnDosJugadores.Text = "Multijugador"
        Me.BtnDosJugadores.UseVisualStyleBackColor = False
        '
        'btnUnjugador
        '
        Me.btnUnjugador.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnUnjugador.Font = New System.Drawing.Font("Rockwell", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUnjugador.ForeColor = System.Drawing.Color.White
        Me.btnUnjugador.Location = New System.Drawing.Point(191, 107)
        Me.btnUnjugador.Name = "btnUnjugador"
        Me.btnUnjugador.Size = New System.Drawing.Size(135, 41)
        Me.btnUnjugador.TabIndex = 1
        Me.btnUnjugador.Text = "Un Jugador"
        Me.btnUnjugador.UseVisualStyleBackColor = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Rockwell", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(113, 2)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(291, 47)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Menú Principal"
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 278)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Meú Principal"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents BtnDosJugadores As System.Windows.Forms.Button
    Friend WithEvents btnUnjugador As System.Windows.Forms.Button

End Class
