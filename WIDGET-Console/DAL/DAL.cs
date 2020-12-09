using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using SQLCoreApp.Model;

namespace SQLCoreApp.DAL
{
    public class WidgetDAL
    {
        // Lets use a ConnectionStringBuilder class for the database type chosen

        private string _connectionString;
        public WidgetDAL(IConfiguration iconfiguration)
        {
            //Just the database, therefore localDB with Windows Authentication
            ConnectionMSSQLStringBuilder myConnectionString1 = new ConnectionMSSQLStringBuilder
            (
                iconfiguration.GetSection("ConnectionStringsMSQL1")["Database"]
            ) ;
            _connectionString = myConnectionString1.ToString();
            Console.WriteLine("myConnectionString{0} -> {1}", 1, _connectionString);
 
            // Server,therefore MS-SQL, username & passoword not present, therefore Windows Authenication
            ConnectionMSSQLStringBuilder myConnectionString2 = new ConnectionMSSQLStringBuilder
            (
                iconfiguration.GetSection("ConnectionStringsMSQL2")["Server"],
                iconfiguration.GetSection("ConnectionStringsMSQL2")["Database"]
            );
            _connectionString = myConnectionString2.ToString();
            Console.WriteLine("myConnectionString{0} -> {1}", 2, _connectionString);

            // No server, therefore LocalDB, Username & password, therefore SQL Auntentication
            ConnectionMSSQLStringBuilder myConnectionString3 = new ConnectionMSSQLStringBuilder
            (
                iconfiguration.GetSection("ConnectionStringsMSQL3")["Database"],
                iconfiguration.GetSection("ConnectionStringsMSQL3")["UserName"],
                iconfiguration.GetSection("ConnectionStringsMSQL3")["Password"]
            );
            _connectionString = myConnectionString3.ToString();
            Console.WriteLine("myConnectionString{0} -> {1}", 3, _connectionString);

            // All items in config are present
            ConnectionMSSQLStringBuilder myConnectionString4 = new ConnectionMSSQLStringBuilder
            (
                iconfiguration.GetSection("ConnectionStringsMSQL4")["Server"],
                iconfiguration.GetSection("ConnectionStringsMSQL4")["Database"],
                iconfiguration.GetSection("ConnectionStringsMSQL4")["UserName"],
                iconfiguration.GetSection("ConnectionStringsMSQL4")["Password"]
            );
            _connectionString = myConnectionString4.ToString();
            Console.WriteLine("myConnectionString{0} -> {1}", 4, _connectionString);

            // All items in config are present, but empty
            ConnectionMSSQLStringBuilder myConnectionString5 = new ConnectionMSSQLStringBuilder
            (
                iconfiguration.GetSection("ConnectionStringsMSQL5")["Server"],
                iconfiguration.GetSection("ConnectionStringsMSQL5")["Database"],
                iconfiguration.GetSection("ConnectionStringsMSQL5")["UserName"],
                iconfiguration.GetSection("ConnectionStringsMSQL5")["Password"]
            );
            _connectionString = myConnectionString5.ToString();
            Console.WriteLine("myConnectionString{0} -> {1}", 5, _connectionString);

            // Config items not present in config section
            ConnectionMSSQLStringBuilder myConnectionString6 = new ConnectionMSSQLStringBuilder
            (
                iconfiguration.GetSection("ConnectionStringsMSQL6")["Server"],
                iconfiguration.GetSection("ConnectionStringsMSQL6")["Database"],
                iconfiguration.GetSection("ConnectionStringsMSQL6")["UserName"],
                iconfiguration.GetSection("ConnectionStringsMSQL6")["Password"]
            );
            _connectionString = myConnectionString6.ToString();
            Console.WriteLine("myConnectionString{0} -> {1}", 6, _connectionString);

            // Hard coded (eg blanks) and not using config at all
            ConnectionMSSQLStringBuilder myConnectionString7 = new ConnectionMSSQLStringBuilder
            (
                "",
                "",
                "",
                ""
            );
            _connectionString = myConnectionString6.ToString();
            Console.WriteLine("myConnectionString{0} -> {1}", 7, _connectionString);

            // Config section not present in appsetting.json
            ConnectionMSSQLStringBuilder myConnectionString8 = new ConnectionMSSQLStringBuilder
            (
                iconfiguration.GetSection("ConnectionStringsMSQL8")["Server"],
                iconfiguration.GetSection("ConnectionStringsMSQL8")["Database"],
                iconfiguration.GetSection("ConnectionStringsMSQL8")["UserName"],
                iconfiguration.GetSection("ConnectionStringsMSQL8")["Password"]
            );
            _connectionString = myConnectionString7.ToString();
            Console.WriteLine("myConnectionString{0} -> {1}", 8, _connectionString);

            // Decide which one to use in connection
            _connectionString = myConnectionString6.ToString();
            Console.WriteLine("USE THIS ONE !!!! myConnectionString{0} -> {1}", 6, _connectionString);
        }
        public List<WidgetModel> GetList()
        {
            var listWidgetModel = new List<WidgetModel>();
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    SqlCommand cmd = new SqlCommand("SP_WIDGET_GET_LIST", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();

                    // Have to convert string to DateOffset outside of the WidgetModel 
                    // constructor so use Date varible define here and assigned in the 
                    // read processinbg loop below

                    DateTimeOffset Date = new DateTimeOffset();

                    while (rdr.Read())
                    {
                        DateTimeOffset.TryParse(rdr[1].ToString(), out Date);

                        listWidgetModel.Add(new WidgetModel
                        {
                            Id = Convert.ToInt32(rdr[0]),
                            Date = Date, // see TryParse(rdr[1].ToString()) above
                            Name = rdr[2].ToString(),
                            Count = Convert.ToInt32(rdr[3]),
                            Secret = rdr[4].ToString()
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return listWidgetModel;
        }
    }
}



