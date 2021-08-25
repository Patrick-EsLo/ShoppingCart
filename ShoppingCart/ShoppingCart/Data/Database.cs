using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;
using ShoppingCart.Model;
using System.Threading.Tasks;


using Xamarin.Forms;

namespace ShoppingCart.Data
{
    public class Database
    {
        private readonly SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Barcode>();
        }

        public Task<List<Barcode>> GetPeopleAsync()
        {
            return _database.Table<Barcode>().ToListAsync();
        }

        public Task<int> SavePersonAsync(Barcode barcode)
        {
            return _database.InsertAsync(barcode);
        }
    }
}