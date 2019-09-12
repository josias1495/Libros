using System;
using System.Collections.Generic;
using System.Text;
using Libros.Service;
using SQLite;
using SQLiteNetExtensions.Extensions;

namespace Libros.model
{
    public class AutorRepositorioSqlite : RepositorioAutor
    {
        public string EstatusMensaje { get; set; }
        SQLiteConnection Coneccion;

        public AutorRepositorioSqlite(string dbPath )
        {
            Coneccion = new SQLiteConnection(dbPath);
            Coneccion.CreateTable<AutorModel>();

        }
        public void AgregarNuevoAutor(AutorModel NuevoAutor)
        {
            try
            {
                Coneccion.InsertWithChildren(NuevoAutor, recursive: true);
                EstatusMensaje = $"Registro ingresado. Libro id:{NuevoAutor.IDAutor}, Nombre:{NuevoAutor.NombreAutor}";
            }

            catch(Exception ex)
            {
                EstatusMensaje = $"Error al guardar registro. Error:{ex.Message}";
            }
        }

        

        public List<AutorModel> ObtenerAutorYLibros()
        {
            return Coneccion.GetAllWithChildren<AutorModel>();
        }
    }
}
