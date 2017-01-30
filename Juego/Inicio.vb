Public Class Inicio

    ''' <summary>
    ''' Abre la pantalla para jugar con la máquina
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>David Reyes Sánchez</remarks>
    Private Sub btnUnjugador_Click(sender As Object, e As EventArgs) Handles btnUnjugador.Click
        Try
            Juego.lblPuntaje1.Text = "Jugador"
            Juego.lblPuntaje2.Text = "Máquina"
            Juego.Modo = "C"
            Juego.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show("Error en el sistema" & vbCrLf & ex.ToString, "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Abre la pantalla para jugar como multijugador
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>David Reyes Sánchez</remarks>
    Private Sub BtnDosJugadores_Click(sender As Object, e As EventArgs) Handles BtnDosJugadores.Click
        Try
            Juego.lblPuntaje1.Text = "Jugador 1"
            Juego.lblPuntaje2.Text = "Jugador 2"
            Juego.Modo = "M"
            Juego.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show("Error en el sistema" & vbCrLf & ex.ToString, "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Se sale de la aplicación
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>David Reyes Sánchez</remarks>
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Try
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error en el sistema" & vbCrLf & ex.ToString, "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
