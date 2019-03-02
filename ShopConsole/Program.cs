using System;
using System.Data;
using Org.Mql.Ado;

namespace ShopConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlDataBase cnx = new SqlDataBase(
                @"Data Source=(localdb)\MSSQLLocalDB;
                      Initial Catalog=Shop;Integrated Security=True;");

            DataTable table = cnx.Select("Products");

            foreach (DataRow row in table.Rows)
            {
                Console.Write($"ID = {row[0]}");
                Console.WriteLine($" - Label = {row["Label"]}");
            }
            Console.ReadKey();
        }
    }
}
