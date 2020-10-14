using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace XF.LocalDB.Data
{
    public interface ISQLite
    {
        SQLiteConnection GetConexao();
    }
}
