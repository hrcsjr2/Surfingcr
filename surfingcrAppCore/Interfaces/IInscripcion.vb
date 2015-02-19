Public Interface IInscripcion
    Function SolicitarInscripcion(ByVal surfista As Dominios.Usuario, ByVal Categoria As Dominios.CategoriasTorneo) As Entidad.Moneda

    Function RealizarPago(ByVal surfista As Dominios.Usuario, ByVal Categoria As Dominios.CategoriasTorneo) As Entidad.Moneda

End Interface
