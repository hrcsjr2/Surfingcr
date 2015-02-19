Namespace Entidad
    Public Class Moneda
        Public ReadOnly transaccion As Transaccion
        Public ReadOnly monto As Decimal

        Public Sub New(ByVal Monto As Decimal, ByVal Transaccion As Transaccion)
            Me.monto = Monto
            Me.transaccion = Transaccion
        End Sub

        Public Function AgregarMonto(ByVal cantidad As Moneda) As Moneda
            Return New Moneda((Me.monto + cantidad.monto), Me.transaccion)
        End Function

    End Class

End Namespace
