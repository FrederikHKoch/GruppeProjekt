using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace ConsoleApp1
{
    class SQLCon
    {
        private static string ConnectionString = @"Data Source=SKAB6-PC-02\GRUPPEPROJEKT;Initial Catalog=Autoværksted; Integrated Security=True";


        public static void Insert(string sqlCon)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sqlCon, con);
                cmd.ExecuteNonQuery();
            }
        }

        public static void Select(string sqlSelect)
        {
            DataTable table = new DataTable();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlSelect, con);
                adapter.Fill(table);

                foreach (DataRow customer in table.Rows)
                {
                    if (customer != null)
                    {
                        Console.WriteLine(customer["id"].ToString());
                        Console.WriteLine(customer["navn"].ToString());
                        Console.WriteLine(customer["adr"].ToString());
                        Console.WriteLine(customer["alder"].ToString());
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Kunde bibliotek er tomt");
                    }
                   
                
                }
            }
        }
        public static void Delete(string sqlDelete)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sqlDelete, con);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Kunden er slettet");
            }
        }
        public static void Update(string sqlUpdate)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();                
                SqlCommand cmd = new SqlCommand(sqlUpdate, con);
                cmd.ExecuteNonQuery();
            }
        }


    }
}
