using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MVVM_Crud.Model
{
    [Table("Producto")]
    public class Producto
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public string Imagen { get; set; }
        public string ImagenFile { get; set; }
    }
}
