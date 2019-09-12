using System;
using System.Collections.Generic;
using System.Text;
using Libros.Service;
using SQLite;
using SQLiteNetExtensions.Extensions;
using Libros.model;

namespace Libros.model
{
    public class LibroRepositorioSqlite : RepositorioLibro
    {
        public string EstatusMensaje { get; set; }
        SQLiteConnection ConecLibro;

        public LibroRepositorioSqlite(string dbPath)
        {
            ConecLibro = new SQLiteConnection(dbPath);
            ConecLibro.CreateTable<LibroModel>();

        }
        public void AgregarNuevoLibro(LibroModel NuevoLibro)
        {
            try
            {
                ConecLibro.Insert(NuevoLibro);
                EstatusMensaje = $"Registro Ingresado. Libro Id{NuevoLibro.IDLibro}, Nombre libro{NuevoLibro.NombreLibro} ";
            }
            catch (Exception ex)
            {
                EstatusMensaje = $"Error al guardar registro. Error:{ex.Message}";
            }
        }

        public List<LibroModel> ObtenerLibro()
        {
            return ConecLibro.Table<LibroModel>().ToList();
        }
    }
}
