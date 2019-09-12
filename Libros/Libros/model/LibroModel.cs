using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;
using SQLiteNetExtensions.Extensions;

namespace Libros.model
{
    [Table("Libros")]
    public class LibroModel
    {
        [PrimaryKey, AutoIncrement]
        public int IDLibro { get; set; }
        public string NombreLibro { get; set; }
        public string DescripcionLibro { get; set; }

        [ForeignKey(typeof(AutorModel))]
        public int AutorId { get; set; }

        [ForeignKey(typeof(GeneroModel))]
        public int GeneroId { get; set; }

        [ManyToOne]
        public AutorModel Autor { get; set; }
        [ManyToOne]
        public GeneroModel Genero { get; set; }
    }
}
