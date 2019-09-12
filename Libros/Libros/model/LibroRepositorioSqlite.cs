using System;
using System.Collections.Generic;
using System.Text;
using Libros.Service;
using SQLite;
using SQLiteNetExtensions.Extensions;

namespace Libros.model
{
    public class LibroRepositorioSqlite : RepositorioLibro
    {
        public string EstatusMensaje { get; set; }
        SQLiteConnection ConecLibro;
        public void AgregarNuevoLibro(LibroModel NuevoLibro)
        {
            throw new NotImplementedException();
        }

        public List<LibroModel> ObtenerLibro()
        {
            throw new NotImplementedException();
        }
    }
}
