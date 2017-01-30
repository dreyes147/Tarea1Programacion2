Public Class Felicitaciones
#Region "Variables"
    Private vTexto As String = String.Empty
    Private vModo As String = String.Empty
#End Region

#Region "Propiedades"
    Public Property Texto() As String
        Get
            Return vTexto
        End Get
        Set(value As String)
            vTexto = value
        End Set
    End Property
    Public Property Modo() As String
        Get
            Return vModo
        End Get
        Set(value As String)
            vModo = value
        End Set
    End Property
#End Region



    Private Sub Felicitaciones_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Inicio.Show()
        Me.Close()
    End Sub

    Private Sub Felicitaciones_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblTexto.Text = vTexto
        If vModo = "F" Then
            Panel1.BackgroundImage = Global.Juego.My.Resources.felicidades
        Else
            Panel1.BackgroundImage = Global.Juego.My.Resources.lacasa_gana
        End If
    End Sub
End Class