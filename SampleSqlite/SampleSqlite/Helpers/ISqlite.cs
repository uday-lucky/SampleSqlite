using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleSqlite.Helpers
{
    public interface ISqlite
    {
        SQLiteConnection GetConnection();
    }
}
