using System;
using System.Data;
using System.Data.SqlClient;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection cnx = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Biblio;Integrated Security=True;");
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Books", cnx);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Books");
            
            for (int j = 0; j < ds.Tables[0].Columns.Count; j++)
                Console.Write(ds.Tables[0].Columns[j].ColumnName + "\t");
                Console.WriteLine();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                for (int j = 0; j < ds.Tables[0].Columns.Count; j++)
                    Console.Write(ds.Tables[0].Rows[i][j].ToString() + "\t");
                    Console.WriteLine();
            }

            //Creates a new data row
            DataRow row = ds.Tables["Books"].NewRow();
            
            row["isbn"] = "1-972";
            row["title"] = "ADO";
            row["YearPublished"] = 2018;
            row["PublisherId"] = 1;

            ds.Tables["Books"].Rows.Add(row);

            // Update a row
            ds.Tables["Books"].Rows[0]["Title"] = "ASP";

            // Delete a row
            ds.Tables["Books"].Rows[1].Delete();

            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.UpdateCommand = builder.GetUpdateCommand();

            adapter.Update(ds, "Books");

            Console.ReadKey();
        }
    }
}
