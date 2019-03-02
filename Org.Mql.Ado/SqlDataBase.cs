using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Org.Mql.Ado
{
    public class SqlDataBase
    {
        public SqlConnection Cnx { get; private set; }

        private string _connectionString;
        public string ConnectionString {
            get { return _connectionString; }
            set {
                _connectionString = value;
                Cnx = new SqlConnection(_connectionString);
                Cnx.Open();
            }
        }
        public SqlDataBase(string connectionString)
        {
            ConnectionString = connectionString;
        }
        public void Disconnect()
        {
            if (Cnx.State == ConnectionState.Open)
                Cnx.Close();
        }

        public DataTable Select(string tableName)
        {
            string req = $"SELECT * FROM {tableName}";
            SqlCommand cmd = new SqlCommand(req, Cnx);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable(tableName);
            adapter.Fill(table);

            return table;
        }

        public DataRow FindById(string tableName, int id)
        {
            string req = $"SELECT * FROM {tableName} WHERE id = {id}";
            SqlCommand cmd = new SqlCommand(req, Cnx);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable(tableName);
            adapter.Fill(table);

            return table.Rows[0];
        }
        
        public int ExecuteUpdate(string req)
        {
            SqlCommand cmd = new SqlCommand(req, Cnx);
            return cmd.ExecuteNonQuery();
        }

        public int Insert(string tableName, Dictionary<string, object> data)
        {
            string keys = "", values = "";
            foreach (KeyValuePair<string, object> pair in data)
            {
                keys += pair.Key + ",";
                values += $"'{pair.Value}',";
            }
            keys = keys.Substring(0, keys.Length - 1);
            values = values.Substring(0, values.Length - 1);

            string req = $"INSERT INTO {tableName} ({keys}) VALUES ({values})";

            return ExecuteUpdate(req);
        }

        public int Delete(string tableName, string key, object value)
        {
            string req = $"DELETE FROM {tableName} WHERE {key} = {value}";
            return ExecuteUpdate(req);
        }

    }
}
