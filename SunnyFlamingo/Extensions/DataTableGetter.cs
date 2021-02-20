using Microsoft.EntityFrameworkCore;
using SunnyFlamingo.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Extensions
{
    public static class DataTableGetter
    {
        public static DataTable GetDataTable(this ApplicationDbContext _context, string tableName)
        {
            DataTable dataTable = new DataTable();
            DbConnection connection = _context.Database.GetDbConnection();
            DbProviderFactory dbFactory = DbProviderFactories.GetFactory(connection);
            using (var cmd = dbFactory.CreateCommand())
            {
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"SELECT TOP 1 * FROM {tableName}";
                using (DbDataAdapter adapter = dbFactory.CreateDataAdapter())
                {
                    adapter.SelectCommand = cmd;
                    adapter.Fill(dataTable);
                }
            }
            return dataTable;
        }
    }
}
