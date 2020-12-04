using System;
using System.Collections.Generic;
using System.Text;
using MVVM_Crud.Database.Repositorios;
using SQLite;

namespace MVVM_Crud.Database
{
    public class UnitOfWork
    {
        public ProductoRepository productoRepository;
        public UnitOfWork(SQLiteAsyncConnection db)
        {
            productoRepository = new ProductoRepository(db);
        }
    }
}
