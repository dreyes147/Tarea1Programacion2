Public Class Inicio
    Private Sub btnUnjugador_Click(sender As Object, e As EventArgs) Handles btnUnjugador.Click
        Juego.lblPuntaje1.Text = "Jugador"
        Juego.lblPuntaje2.Text = "Máquina"
        Juego.Modo = "C"
        Juego.Show()
        Me.Hide()
    End Sub

    Private Sub BtnDosJugadores_Click(sender As Object, e As EventArgs) Handles BtnDosJugadores.Click
        Juego.lblPuntaje1.Text = "Jugador 1"
        Juego.lblPuntaje2.Text = "Jugador 2"
        Juego.Modo = "M"
        Juego.Show()
        Me.Hide()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class
