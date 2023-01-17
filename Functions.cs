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
    }
}
