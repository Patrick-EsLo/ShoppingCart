using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace ShoppingCart.Data
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
