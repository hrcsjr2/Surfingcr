Namespace Servicios
    Public Class Tarjeta
        Public Function ValidarTipoTarjeta(ByVal tarjeta As Dominios.Tarjeta) As Boolean
            Return (tarjeta.Tipo = "VISA" Or tarjeta.Tipo = "MASTERCARD" Or tarjeta.Tipo = "AMEX")
        End Function
    End Class
End Namespace
