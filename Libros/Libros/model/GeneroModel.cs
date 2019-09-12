using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;
using SQLiteNetExtensions.Extensions;

namespace Libros.model
{
    public class GeneroModel
    {
        [PrimaryKey, AutoIncrement]
        public int IDGenero { get; set; }
        public string NombreGenero { get; set; }

        [OneToMany(CascadeOperations=CascadeOperation.CascadeInsert)]
        public List<LibroModel> Libross { get; set; }
    }
}
