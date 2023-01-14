using Dapper;
using System.Data;
using System.Data.SqlClient;

var dt = new DataTable("DriversType");
dt.Columns.Add("Id", typeof(int));
dt.Columns.Add("FirstName", typeof(string));
dt.Columns.Add("LastName", typeof(string));
dt.Columns.Add("Number", typeof(int));
dt.Columns.Add("PhotoPath", typeof(string));
dt.Columns.Add("Wins", typeof(int));

dt.Rows.Add(1,"Fernando","Alonso",14,"1.jpg",40);

using (var conn = new SqlConnection("Data Source=127.0.0.1;Initial Catalog=Db_Tvp_Test;Persist Security Info=True;User ID=sa;Password=d0ck3rX12!4354"))
{
    conn.Open();
    conn.Execute("EXEC sp_UpdateDriver @param", new { param = dt.AsTableValuedParameter("DriverType") });
}