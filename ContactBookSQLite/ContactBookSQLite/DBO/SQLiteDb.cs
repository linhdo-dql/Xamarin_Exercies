using ContactBookSQLite.DBO;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLiteDb))]
namespace ContactBookSQLite.DBO
{  
    
    public class SQLiteDb : ISQLiteDb
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var documentPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var dbPath = Path.Combine(documentPath, "contacts.db3");
            return new SQLiteAsyncConnection(dbPath);
        }
    }
}
