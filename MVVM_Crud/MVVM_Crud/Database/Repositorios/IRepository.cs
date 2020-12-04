using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Crud.Database.Repositorios
{
    public interface IRepository<T> where T : class
    {
        public Task<List<T>> ObtenerListado();
        public Task<T> ObtenerItem(int id);
        public Task<int> InsertarItem(T entidad);
        public Task<int> EditarItem(T entidad);
        public Task<int> BorrarItem(T entidad);
    }
}
