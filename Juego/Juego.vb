Public Class Juego

    Private Sub btnLanzar_Paint(sender As Object, e As PaintEventArgs) Handles btnLanzar.Paint
        Dim buttonPath As New System.Drawing.Drawing2D.GraphicsPath
        Dim newRectangle As Rectangle = btnLanzar.ClientRectangle

        newRectangle.Inflate(-10, -10)
        newRectangle.Inflate(1, 1)
        buttonPath.AddEllipse(newRectangle)
        ' e.Graphics.DrawPath(Pens.Black, buttonPath)
        btnLanzar.Region = New System.Drawing.Region(buttonPath)
    End Sub

    Private Sub btnLanzar_Click(sender As Object, e As EventArgs) Handles btnLanzar.Click
    End Sub

    Private Sub btnSalir_Paint(sender As Object, e As PaintEventArgs) Handles btnSalir.Paint
        Dim buttonPath As New System.Drawing.Drawing2D.GraphicsPath
        Dim newRectangle As Rectangle = btnSalir.ClientRectangle

        newRectangle.Inflate(-10, -10)
        newRectangle.Inflate(1, 1)
        buttonPath.AddEllipse(newRectangle)
        btnSalir.Region = New System.Drawing.Region(buttonPath)
    End Sub


    Private Sub btnAcomular_Click(sender As Object, e As EventArgs) Handles btnAcomular.Click

    End Sub

    Private Sub lblPuntos2_Click(sender As Object, e As EventArgs) Handles lblPuntos2.Click

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Inicio.Show()

    End Sub
End Class