Namespace Dominios
    Public Class Usuario
        Private _rol As RolUsuario
        Private _nombre As String
        Private _apellidos As String
        Private _tarjeta As Tarjeta

        Public Property Rol As RolUsuario
            Get
                Return _rol
            End Get
            Set(value As RolUsuario)
                _rol = value
            End Set
        End Property

        Public Property Nombre As String
            Get
                Return _nombre
            End Get
            Set(value As String)
                _nombre = value
            End Set
        End Property

        Public Property Apellidos As String
            Get
                Return _apellidos
            End Get
            Set(value As String)
                _apellidos = value
            End Set
        End Property

        Public Property Tarjeta As Tarjeta
            Get
                Return _tarjeta
            End Get
            Set(value As Tarjeta)
                _tarjeta = value
            End Set
        End Property

    End Class
End Namespace

