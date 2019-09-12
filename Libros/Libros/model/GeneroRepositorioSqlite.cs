using System;
using System.Collections.Generic;
using System.Text;
using Libros.model;
using Libros.Service;
using SQLite;
using SQLiteNetExtensions.Extensions;

namespace Libros.model
{
    public class GeneroRepositorioSqlite : RepositorioGenero
    {
        SQLiteConnection connge;
        public string EstatusMensaje { get; set; }

        public GeneroRepositorioSqlite(string dbPath)
        {
            connge = new SQLiteConnection(dbPath);
            connge.CreateTable<GeneroModel>();

        }
        public void AgregarNuevoGenero(GeneroModel NuevoGenero)
        {
            try
            {
                connge.InsertWithChildren(NuevoGenero, recursive: true);
                EstatusMensaje = $"Registro Ingresado con Exito. Genero Id {NuevoGenero.IDGenero}, Nombre Genero {NuevoGenero.NombreGenero} ";
            }

            catch (Exception ex)
            {
                EstatusMensaje = $"Error al guardar registro. Error:{ex.Message}";
            }
        }

        public List<GeneroModel> ObtenerGenero()
        {
            return connge.GetAllWithChildren<GeneroModel>();
        }
    }
}
