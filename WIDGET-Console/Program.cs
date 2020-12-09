//
// Try connection to a database
//
// https://www.c-sharpcorner.com/blogs/access-sql-server-database-in-net-core-console-application
// 
// NUGet 
//      Microsoft.Extensions.Configuration
//      Microsoft.Extensions.Configuration.FileExtensions
//      Microsoft.Extensions.Configuration.Json
//      System.Data.SqlClient
//
// appsetings.json
//      {
//          "ConnectionStrings": {
//              "Default": "Server=YOUR_SERVER;Database=mydatabase;User  Id=YOUR_USER;Password=YOUR_PASSWORD;MultipleActiveResultSets=true"
//          }
//      }
//
// ConnectionStrings
//      https://www.connectionstrings.com/sql-server/
//      https://csharp.hotexamples.com/examples/-/SqlConnection/-/php-sqlconnection-class-examples.html
//      https://stackoverflow.com/questions/15631602/how-to-set-sql-server-connection-string

//.NET DataProvider -- Standard Connection with username and password
//
//using System.Data.SqlClient;
/*
SqlConnection conn = new SqlConnection();
conn.ConnectionString =
  "Data Source=ServerName;" +
  "Initial Catalog=DataBaseName;" +
 "User id=UserName;" +
  "Password=Secret;";
conn.Open();
*/

//.NET DataProvider -- Trusted Connection
//
/*
SqlConnection conn = new SqlConnection();
conn.ConnectionString =
  "Data Source=ServerName;" +
  "Initial Catalog=DataBaseName;" +
  "Integrated Security=SSPI;";
conn.Open();
*/

//  ASP.NET Data Access Options
//      https://docs.microsoft.com/en-us/previous-versions/aspnet/ms178359(v=vs.110)
//  SQL Server Connection Strings for ASP.NET Web Applications
//      https://docs.microsoft.com/en-us/previous-versions/aspnet/jj653752(v=vs.110)?redirectedfrom=MSDN#sqlserver
//  SQL Server 2012 Express LocalDB
//      https://docs.microsoft.com/en-us/previous-versions/sql/sql-server-2012/hh510202(v=sql.110)?redirectedfrom=MSDN
//  SQL Server Connection Strings for ASP.NET Web Applications
//      https://docs.microsoft.com/en-us/previous-versions/aspnet/jj653752(v=vs.110)
//  Connection strings and models (EntityFramework)
//      https://docs.microsoft.com/en-us/ef/ef6/fundamentals/configuring/connection-strings?redirectedfrom=MSDN
//  SQL Server 2012 Express LocalDB
//      https://docs.microsoft.com/en-us/previous-versions/sql/sql-server-2012/hh510202(v=sql.110)?redirectedfrom=MSDN#starting-localdb-and-connecting-to-localdb
//  Database Features
//      https://docs.microsoft.com/en-us/previous-versions/sql/sql-server-2012/hh230827(v=sql.110)

using System;
using System.IO;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using SQLCoreApp.DAL;

namespace SQLCoreApp
{
    class Program
    {
        private static IConfiguration _iconfiguration;
        static void Main(string[] args)
        {
            GetAppSettingsFile();
            PrintWidgets();
        }
        static void GetAppSettingsFile()
        {
            var builder = new ConfigurationBuilder()
                                 .SetBasePath(Directory.GetCurrentDirectory())
                                 .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            _iconfiguration = builder.Build();
        }
        static void PrintWidgets()
        {
            var WidgetDAL = new WidgetDAL(_iconfiguration);
            var listWidgetModel = WidgetDAL.GetList();
            listWidgetModel.ForEach(item =>
            {
                Console.WriteLine(item.Name);
            });
            Console.WriteLine("Press any key to stop.");
            Console.ReadKey();
        }
    }
}
