using System;
using System.Collections.Generic;
using System.Text;
using Libros.model;

namespace Libros.Service
{
    public interface RepositorioAutor
    {
        void AgregarNuevoAutor(AutorModel NuevoAutor);
        List<AutorModel> ObtenerAutorYLibros();
        
    }
}
