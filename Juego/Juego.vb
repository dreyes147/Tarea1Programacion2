Public Class Juego

#Region "Declaracion de Variables"
    Private vModo As String = String.Empty
    Private vRandom As New Random()
    Private vJugador As Integer
#End Region

#Region "Declaración de Propiedades"
    Public Property Modo() As String
        Get
            Return vModo
        End Get
        Set(value As String)
            vModo = value
        End Set
    End Property

#End Region

#Region "Declaración de Métodos"

    ''' <summary>
    ''' Iniciliza los componentes
    ''' </summary>
    ''' <remarks>David Reyes Sánchez</remarks>
    Private Sub Inicializar()
        If vModo = "C" Then
            btnLanzarDos.Visible = False
        End If
    End Sub

    ''' <summary>
    ''' Hace la simulación de lanzar los dados
    ''' </summary>
    ''' <param name="pModo"></param>
    ''' <param name="pNumero"></param>
    ''' <param name="pJugador"></param>
    ''' <remarks>David Reyes Sánchez</remarks>
    Private Sub Lanzar(ByVal pModo As String, ByVal pNumero As Integer, Optional ByVal pJugador As Integer = 0)
        Try
            If vModo = "C" Then
                If pNumero = 1 Then
                    MessageBox.Show("Perdió su turno", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    lblPuntajeTurno.Text = "00"
                    Computadora()
                Else
                    CambiarDado(pNumero)
                End If
            Else
                If pJugador = 1 Then

                    If pNumero = 1 Then
                        MessageBox.Show("Perdió su turno", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        lblPuntajeTurno.Text = "00"
                        btnLanzarUno.Enabled = False
                        btnLanzarDos.Enabled = True
                    Else
                        CambiarDado(pNumero)
                    End If
                Else
                    If pNumero = 1 Then
                        MessageBox.Show("Perdió su turno", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        lblPuntajeTurno.Text = "00"
                        btnLanzarDos.Enabled = False
                        btnLanzarUno.Enabled = True
                    Else
                        CambiarDado(pNumero)
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error en el sistema" & vbCrLf & ex.ToString, "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Cambia las imagenes del PictureBox
    ''' </summary>
    ''' <param name="pNumero"></param>
    ''' <remarks>David Reyes Sánchez</remarks>
    Private Sub CambiarDado(ByVal pNumero As Integer)
        Try
            Select Case pNumero
                Case 1
                    ptbDados.Image = Global.Juego.My.Resources._1
                    Application.DoEvents()
                Case 2
                    ptbDados.Image = Global.Juego.My.Resources._2
                    Application.DoEvents()
                Case 3
                    ptbDados.Image = Global.Juego.My.Resources._3
                    Application.DoEvents()
                Case 4
                    ptbDados.Image = Global.Juego.My.Resources._4
                    Application.DoEvents()
                Case 5
                    ptbDados.Image = Global.Juego.My.Resources._5
                    Application.DoEvents()
                Case 6
                    ptbDados.Image = Global.Juego.My.Resources._6
                    Application.DoEvents()
            End Select
            lblPuntajeTurno.Text = CStr(CInt(lblPuntajeTurno.Text) + pNumero)
        Catch ex As Exception
            MessageBox.Show("Error en el sistema" & vbCrLf & ex.ToString, "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Crea la jugabilidad de la computadora
    ''' </summary>
    ''' <remarks>David Reyes Sánchez</remarks>
    Private Sub Computadora()
        Try
            Dim vNumeroComputadora As Integer = 0
            Dim vContador As Integer = vRandom.Next(1, 6)

            For i = 1 To vContador
                vNumeroComputadora = vRandom.Next(1, 6)
                If vNumeroComputadora = 1 Then
                    MessageBox.Show("Perdí mi turno", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    lblPuntajeTurno.Text = "00"
                    Exit Sub
                Else
                    CambiarDado(vNumeroComputadora)
                    System.Threading.Thread.Sleep(5000)
                End If
            Next
            Plantarse(2)
            MessageBox.Show("Terminó mi turno", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error en el sistema" & vbCrLf & ex.ToString, "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Suma los puntos acomulados del turno de los jugadores
    ''' </summary>
    ''' <param name="pjugador"></param>
    ''' <remarks>David Reyes Sánchez</remarks>
    Private Sub Plantarse(ByVal pjugador As Integer)
        If pjugador = 1 Then
            lblPuntos1.Text = CStr(CInt(lblPuntos1.Text) + CInt(lblPuntajeTurno.Text))
            If lblPuntos1.Text > 100 Then
                Felicitaciones.Texto = "El jugador 1 ha ganado"
                Felicitaciones.Modo = "F"
                Felicitaciones.Show()
                Me.Close()
            End If
        Else
            lblPuntos2.Text = CStr(CInt(lblPuntos2.Text) + CInt(lblPuntajeTurno.Text))
            If lblPuntos2.Text > 100 And vModo = "C" Then
                Felicitaciones.Texto = ""
                Felicitaciones.Modo = "P"
                Felicitaciones.Show()
                Me.Close()
            ElseIf lblPuntos2.Text > 100 And vModo = "M" Then
                Felicitaciones.Texto = "El jugador 2 ha ganado"
                Felicitaciones.Modo = "F"
                Felicitaciones.Show()
                Me.Close()
            End If
        End If
        lblPuntajeTurno.Text = "00"
        If vModo = "M" Then
            If pjugador = 1 Then
                btnLanzarDos.Enabled = True
                btnLanzarUno.Enabled = False
            Else
                btnLanzarDos.Enabled = False
                btnLanzarUno.Enabled = True
            End If
        Else
            If pjugador = 1 Then Computadora()
        End If

    End Sub
#End Region

#Region "Declaración de Eventos"

    ''' <summary>
    ''' Cambia la forma del botón de lanzar
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>David Reyes Sánchez</remarks>
    Private Sub btnLanzarUno_Paint(sender As Object, e As PaintEventArgs) Handles btnLanzarUno.Paint
        Try
            Dim buttonPath As New System.Drawing.Drawing2D.GraphicsPath
            Dim newRectangle As Rectangle = btnLanzarUno.ClientRectangle

            newRectangle.Inflate(-10, -10)
            newRectangle.Inflate(1, 1)
            buttonPath.AddEllipse(newRectangle)
            btnLanzarUno.Region = New System.Drawing.Region(buttonPath)
        Catch ex As Exception
            MessageBox.Show("Error en el sistema" & vbCrLf & ex.ToString, "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Cambia la forma del botón de salir
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>David Reyes Sánchez</remarks>
    Private Sub btnSalir_Paint(sender As Object, e As PaintEventArgs) Handles btnSalir.Paint
        Try
            Dim buttonPath As New System.Drawing.Drawing2D.GraphicsPath
            Dim newRectangle As Rectangle = btnSalir.ClientRectangle

            newRectangle.Inflate(-10, -10)
            newRectangle.Inflate(1, 1)
            buttonPath.AddEllipse(newRectangle)
            btnSalir.Region = New System.Drawing.Region(buttonPath)
        Catch ex As Exception
            MessageBox.Show("Error en el sistema" & vbCrLf & ex.ToString, "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Cambia la forma del botón de lanzar
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>David Reyes Sánchez</remarks>
    Private Sub btnLanzarDos_Paint(sender As Object, e As PaintEventArgs) Handles btnLanzarDos.Paint
        Try
            Dim buttonPath As New System.Drawing.Drawing2D.GraphicsPath
            Dim newRectangle As Rectangle = btnLanzarDos.ClientRectangle

            newRectangle.Inflate(-10, -10)
            newRectangle.Inflate(1, 1)
            buttonPath.AddEllipse(newRectangle)
            btnLanzarDos.Region = New System.Drawing.Region(buttonPath)
        Catch ex As Exception
            MessageBox.Show("Error en el sistema" & vbCrLf & ex.ToString, "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Ejecuta el método lanzar
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>David Reyes Sánchez</remarks>
    Private Sub btnLanzar_Click(sender As Object, e As EventArgs) Handles btnLanzarUno.Click
        Try
            vJugador = 1
            Lanzar(vModo, vRandom.Next(1, 6), vJugador)
        Catch ex As Exception
            MessageBox.Show("Error en el sistema" & vbCrLf & ex.ToString, "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Ejecuta el método el que acomula los puntos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>David Reyes Sánchez</remarks>
    Private Sub btnAcomular_Click(sender As Object, e As EventArgs) Handles btnAcomular.Click
        Try
            Plantarse(vJugador)
        Catch ex As Exception
            MessageBox.Show("Error en el sistema" & vbCrLf & ex.ToString, "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Ejecuta el método lanzar
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>David Reyes Sánchez</remarks>
    Private Sub btnLanzarDos_Click(sender As Object, e As EventArgs) Handles btnLanzarDos.Click
        Try
            vJugador = 2
            Lanzar(vModo, vRandom.Next(1, 6), vJugador)
        Catch ex As Exception
            MessageBox.Show("Error en el sistema" & vbCrLf & ex.ToString, "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Ejecuta el método Inicializar
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>David Reyes Sánchez</remarks>
    Private Sub Juego_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Inicializar()
        Catch ex As Exception
            MessageBox.Show("Error en el sistema" & vbCrLf & ex.ToString, "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Cierra la pantalla
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>David Reyes Sánchez</remarks>
    Private Sub lnkSalir_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Inicio.Show()
        Me.Close()
    End Sub

    ''' <summary>
    ''' Sale de la aplicación
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarksDavid Reyes Sánchez></remarks>
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Inicio.Show()
        Me.Close()
    End Sub
#End Region

    
   
End Class