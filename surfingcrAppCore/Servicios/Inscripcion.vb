Namespace Servicios
    Public Class Inscripcion
        Private ReadOnly categoriasTorneo As Servicios.CategoriasTorneo
            
        Public Sub New(CategoriasTorneo As Servicios.CategoriasTorneo)
            Me.categoriasTorneo = CategoriasTorneo
        End Sub

        Public Sub New()

        End Sub

        Public Function BuscarCategoria(ByVal Categoria As Dominios.CategoriasTorneo) As Dominios.CategoriasTorneo
            For Each elemento As DictionaryEntry In Me.categoriasTorneo.Categorias
                If CType(elemento.Value, Dominios.CategoriasTorneo).Categoria = Categoria.Categoria Then
                    Dim catEncontrada = CType(elemento.Value, Dominios.CategoriasTorneo)
                    Return New Dominios.CategoriasTorneo With {.Categoria = catEncontrada.Categoria, .CuposDisponibles = catEncontrada.CuposDisponibles, .PrecioInscripcion = catEncontrada.PrecioInscripcion}
                End If
            Next
            Return Nothing
        End Function

        Public Function ValidarCampoDisponible(ByVal Categoria As Dominios.CategoriasTorneo) As Boolean
            For Each elemento As DictionaryEntry In Me.categoriasTorneo.Categorias
                If CType(elemento.Value, Dominios.CategoriasTorneo).Categoria = Categoria.Categoria Then
                    If CType(elemento.Value, Dominios.CategoriasTorneo).CuposDisponibles > 0 Then
                        Return True
                    End If
                End If
            Next
            Return False
        End Function


    End Class
End Namespace