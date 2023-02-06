using FastMember;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableValuedParametersExample.Model;

namespace TableValuedParametersExample
{
    public static class Functions
    {
        public static DataTable CreateSQLDataRecords(IEnumerable<Driver> drivers)
        {
            // This is faster than reflection (FastMember)
            IEnumerable<Driver> data = drivers;
            DataTable table = new DataTable();
            using (var reader = ObjectReader.Create(data, "Id", "FirstName", "LastName","Number","PhotoPath","Wins"))
            {
                table.Load(reader);
            }
            return table;
        }
        // This is a more generic method
        public static DataTable ToDataTable<T>(IEnumerable<T> list)
        {
            // https://stackoverflow.com/questions/564366/convert-generic-list-enumerable-to-datatable
            IEnumerable<T> data = list;

            DataTable table = new();
            // It needs to have the same order of the SQL Type 
            try
            {
                using var reader = ObjectReader.Create(data, typeof(T).GetProperties().Select(x => x.Name).ToArray());
                table.Load(reader);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.ToString());
            }
            return table;
        }
    }
}
