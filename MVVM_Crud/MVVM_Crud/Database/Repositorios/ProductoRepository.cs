using MVVM_Crud.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Crud.Database.Repositorios
{
    public class ProductoRepository : IRepository<Producto>
    {
        public readonly SQLiteAsyncConnection database;
        public ProductoRepository(SQLiteAsyncConnection database)
        {
            this.database = database;
        }

        public Task<int> BorrarItem(Producto entidad)
        {
            return database.DeleteAsync(entidad);
        }

        public Task<int> EditarItem(Producto entidad)
        {
            Producto editItem = new Producto
            {
                Id = entidad.Id,
                Nombre = entidad.Nombre,
                Precio = entidad.Precio,
                Imagen = entidad.Imagen
            };
            return database.UpdateAsync(editItem);
        }

        public Task<int> InsertarItem(Producto entidad)
        {
            return database.InsertAsync(entidad);
        }

        public Task<Producto> ObtenerItem(int id)
        {
            return (from producto in database.Table<Producto>()
                    where producto.Id == id
                    select producto).FirstOrDefaultAsync();
        }

        public Task<List<Producto>> ObtenerListado()
        {
            return database.Table<Producto>().ToListAsync();
        }
    }
}
