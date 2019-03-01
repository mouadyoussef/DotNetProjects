using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.Mql.Ado;

namespace ShopConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlDataBase cnx = new SqlDataBase(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Shop;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            //string req = $"INSERT INTO Products VALUES ({3}, '{"Samsung galaxy S8"}', {15000.0}, '{"Smartphone"}', {120})";
            //SqlCommand cmd = new SqlCommand(req, cnx.Cnx);

            //int rowsUpdated = cmd.ExecuteNonQuery();
            //Console.WriteLine($"Rows Updated : {rowsUpdated}");

            DataTable table = cnx.Select("Products");

            foreach (DataRow row in table.Rows)
            {
                Console.WriteLine($"ID = {row[0]}");
                Console.WriteLine($"Label = {row["Label"]}");
            }

            //Dictionary<string, object> dic = new Dictionary<string, object>();
            //dic.Add("Label", "Razer cortex");
            //dic.Add("Price", 12000.0);

            cnx.Delete("Products", "ID", 5);

            //Console.WriteLine(cnx.Insert("Products", dic));
            //while (reader.Read())
            //{
            //    Console.WriteLine($"ID = {reader[0]}");
            //    Console.WriteLine($"Label = {reader["Label"]}");
            //}

            Console.ReadKey();
        }
    }
}
