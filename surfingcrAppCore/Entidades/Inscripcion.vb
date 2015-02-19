Namespace Entidad
    Public Class Inscripcion
        Implements IInscripcion


        ''Método que se permite el pago en línea con una tarjeta de crédito ó débito VISA, MasterCard ó Amex.
        Public Function RealizarPago(surfista As Dominios.Usuario, Categoria As Dominios.CategoriasTorneo) As Moneda Implements IInscripcion.RealizarPago
            Dim servicio As New Servicios.Inscripcion()
            Dim tarjeta As New Servicios.Tarjeta()

            If (tarjeta.ValidarTipoTarjeta(surfista.Tarjeta)) Then
                Dim categoriaInscripcion = servicio.BuscarCategoria(Categoria)
                If Not categoriaInscripcion Is Nothing Then
                    Dim cobro As New Entidad.Moneda(categoriaInscripcion.PrecioInscripcion, Transaccion.Cobro)
                    Return cobro
                End If
            End If
            Return Nothing
        End Function


        Public Function SolicitarInscripcion(surfista As Dominios.Usuario, Categoria As Dominios.CategoriasTorneo) As Moneda Implements IInscripcion.SolicitarInscripcion
            Dim servicio As New Servicios.Inscripcion()

            If servicio.ValidarCampoDisponible(Categoria) Then
                Dim categoriaInscripcion = servicio.BuscarCategoria(Categoria)
                If Not categoriaInscripcion Is Nothing Then
                    Dim cupos = categoriaInscripcion.CuposDisponibles - 1
                    Dim resultado = New Dominios.CategoriasTorneo With {.Categoria = categoriaInscripcion.Categoria, .CuposDisponibles = cupos, .PrecioInscripcion = categoriaInscripcion.PrecioInscripcion}
                    Dim servicioCategorias As New Servicios.CategoriasTorneo

                    servicioCategorias.GuardarCategoria(resultado)

                    Dim cobro As New Entidad.Moneda(categoriaInscripcion.PrecioInscripcion, Transaccion.Cobro)
                    Return cobro
                End If
            End If
            Return Nothing
        End Function
    End Class
End Namespace