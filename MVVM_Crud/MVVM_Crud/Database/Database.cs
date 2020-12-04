using System;
using System.Collections.Generic;
using System.Text;
using MVVM_Crud.Model;
using SQLite;

namespace MVVM_Crud.Database
{
    public class Database
    {
        public readonly SQLiteAsyncConnection db;
        public UnitOfWork unitOfWork;

        public Database(string path)
        {
            db = new SQLiteAsyncConnection(path);

            // CREACION DE TABLAS
            db.CreateTableAsync<Producto>().Wait();

            // REPOSITORIOS
            unitOfWork = new UnitOfWork(db);
        }
    }
}
