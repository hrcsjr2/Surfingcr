Imports System.Collections

Namespace Servicios

    Public Class CategoriasTorneo
        Private _Categorias As New Hashtable

        Public ReadOnly Property Categorias As Hashtable
            Get
                Return _Categorias
            End Get
        End Property

        Public Sub GuardarCategoria(Categoria As Dominios.CategoriasTorneo)
            Me.Categorias.Add(Me.Categorias.Count, Categoria)
        End Sub
    End Class

End Namespace

