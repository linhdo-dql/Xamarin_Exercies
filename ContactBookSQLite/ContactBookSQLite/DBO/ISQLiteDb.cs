﻿using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace ContactBookSQLite.DBO
{
    public interface ISQLiteDb
    {
        SQLiteAsyncConnection GetConnection();
    }
}
