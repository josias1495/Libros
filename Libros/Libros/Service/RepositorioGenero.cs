using System;
using System.Collections.Generic;
using System.Text;
using Libros.model;

namespace Libros.Service
{
    public interface RepositorioGenero
    {
        void AgregarNuevoGenero(GeneroModel NuevoGenero);

        List<GeneroModel> ObtenerGenero();

        
    }
}
