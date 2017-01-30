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

#Region "Eventos"

    ''' <summary>
    ''' Cierea la pantalla
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>David Reyes Sánchez</remarks>
    Private Sub Felicitaciones_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            Inicio.Show()
            Me.Finalize()
        Catch ex As Exception
            MessageBox.Show("Error en el sistema" & vbCrLf & ex.ToString, "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Inicializa la pantalla
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>David Reyes Sánchez</remarks>
    Private Sub Felicitaciones_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            lblTexto.Text = vTexto
            If vModo = "F" Then
                Panel1.BackgroundImage = Global.Juego.My.Resources.felicidades
            Else
                Panel1.BackgroundImage = Global.Juego.My.Resources.lacasa_gana
            End If
        Catch ex As Exception
            MessageBox.Show("Error en el sistema" & vbCrLf & ex.ToString, "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region
End Class