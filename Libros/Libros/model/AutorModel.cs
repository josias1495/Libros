using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Extensions;
using SQLiteNetExtensions.Attributes;

namespace Libros.model
{
    public class AutorModel
    {
        [AutoIncrement, PrimaryKey]
        public int IDAutor { get; set; }
        [MaxLength(100), Unique]
        public string  NombreAutor { get; set; }

        [OneToMany(CascadeOperations=CascadeOperation.CascadeInsert)]
        public List<LibroModel> libros { get; set; }

    }
}
