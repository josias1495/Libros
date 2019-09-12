using System;
using System.Collections.Generic;
using System.Text;
using Libros.model;

namespace Libros.Service
{
    public interface RepositorioLibro
    {
        void AgregarNuevoLibro(LibroModel NuevoLibro);
        List<LibroModel> ObtenerLibro();

        

    }
}
