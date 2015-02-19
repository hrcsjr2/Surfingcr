Namespace Dominios
    Public Class CategoriasTorneo

        Private _categoria As String
        Private _cuposDisponibles As Integer
        Private _precioInscripcion As Decimal

        Public Property Categoria As String
            Get
                Return _categoria
            End Get
            Set(value As String)
                _categoria = value
            End Set
        End Property

        Public Property CuposDisponibles As Integer
            Get
                Return _cuposDisponibles
            End Get
            Set(value As Integer)
                _cuposDisponibles = value
            End Set
        End Property

        Public Property PrecioInscripcion As Decimal
            Get
                Return _precioInscripcion
            End Get
            Set(value As Decimal)
                _precioInscripcion = value
            End Set
        End Property

    End Class
End Namespace
