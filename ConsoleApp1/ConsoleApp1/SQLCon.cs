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

        public static void SelectCustomer(string sqlSelect)
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
                        Console.WriteLine();
                        Console.Write("Kunde id: ");
                        Console.WriteLine(customer["id"].ToString());
                        Console.Write("Navn: ");
                        Console.WriteLine(customer["navn"].ToString());
                        Console.Write("Adresse: ");
                        Console.WriteLine(customer["adr"].ToString());
                        Console.Write("Alder: ");
                        Console.WriteLine(customer["alder"].ToString());
                        Console.Write("Oprettelses dato: ");
                        Console.WriteLine(customer["oprettet"].ToString());
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
        public static void SelectCar(string sqlSelectCar)
        {
            DataTable table = new DataTable();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlSelectCar, con);
                adapter.Fill(table);

                foreach (DataRow car in table.Rows)
                {
                    if (car != null)
                    {
                        Console.WriteLine();
                        Console.Write("Kunde id: ");
                        Console.WriteLine(car["id"].ToString());
                        Console.Write("Model: ");
                        Console.WriteLine(car["Model"].ToString());
                        Console.Write("Mærke: ");
                        Console.WriteLine(car["Brand"].ToString());
                        Console.Write("Registrerings nummer: ");
                        Console.WriteLine(car["RegNr"].ToString());
                        Console.Write("Antal Km kørt: ");
                        Console.WriteLine(car["KiloMeter"].ToString());
                        Console.Write("Brændstof: ");
                        Console.WriteLine(car["Fuel"].ToString());
                        Console.Write("Antal km kørt: ");
                        Console.WriteLine(car["Year"].ToString());
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Bil bibliotek er tomt");
                    }


                }
            }
        }
        public static void SelectLog(string sqlLog)
        {
            DataTable table = new DataTable();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlLog, con);
                adapter.Fill(table);
                foreach (DataRow CarLog in table.Rows)
                {
                    Console.Write("Bilens Registreringsnummer: ");
                    Console.WriteLine(CarLog["RegNr"].ToString());
                    Console.Write("Dato for værkstedsbesøg: ");
                    Console.WriteLine(CarLog["VisitDate"].ToString());
                    Console.WriteLine();
                }
            }
        }

        public static void SelectLibrary(string sqlLibrary)
        {
            DataTable table = new DataTable();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlLibrary, con);
                adapter.Fill(table);

                foreach (DataRow carLibrary in table.Rows)
                {
                    Console.Write("Bilens Registreringsnummer: ");
                    Console.WriteLine(carLibrary["RegNr"].ToString());
                    Console.Write("Dato for værkstedsbesøg: ");
                    Console.WriteLine(carLibrary["VisitDate"].ToString());
                    Console.Write("Dato for færdig værkstedsbesøg: ");
                    Console.WriteLine(carLibrary["LeftDate"].ToString());
                    Console.WriteLine();
                }
            }
        }
    }
}
