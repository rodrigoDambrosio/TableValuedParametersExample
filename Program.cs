using Dapper;
using Microsoft.SqlServer.Server;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using TableValuedParametersExample;
using TableValuedParametersExample.Model;

//var dt = new DataTable("DriversType");
//dt.Columns.Add("Id", typeof(int));
//dt.Columns.Add("FirstName", typeof(string));
//dt.Columns.Add("LastName", typeof(string));
//dt.Columns.Add("Number", typeof(int));
//dt.Columns.Add("PhotoPath", typeof(string));
//dt.Columns.Add("Wins", typeof(int));

//dt.Rows.Add(1,"Fernando","Alonso",14,"1.jpg",40);

// Using a list

//List<Driver> driversList = new List<Driver>
//{
//          new Driver(1, "Fernando", "Alonso",14,"1.jpg",60),
//          new Driver(2, "Sebastian", "Vettel",4,"2.jpg",57)
//  };
//DataTable dt = Functions.ToDataTable(driversList);

//using (var conn = new SqlConnection("Data Source=127.0.0.1;Initial Catalog=Db_Tvp_Test;Persist Security Info=True;User ID=sa;Password=d0ck3rX12!4354"))
//{
//    conn.Open();
//    conn.Execute("EXEC sp_UpdateDriver @param", new { param = dt.AsTableValuedParameter("DriverType") });
//}

List<Driver> driversList = new List<Driver>
{
          new Driver("Valteri", "Bottas",77,"77.jpg",7),
          new Driver("Mick", "Schumacher",33,"56.jpg",0)
  };
DataTable dt = Functions.ToDataTable(driversList);

using (var conn = new SqlConnection("Data Source=127.0.0.1;Initial Catalog=Db_Tvp_Test;Persist Security Info=True;User ID=sa;Password=d0ck3rX12!4354"))
{
    conn.Open();
    conn.Execute("EXEC sp_InsertDriver @param", new { param = dt.AsTableValuedParameter("DriverType") });
}