using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace segp2
{
    class DBConnection
    {
        private static DBConnection _instance;

        private string dbConnectionString;


    private DBConnection()
        {
            dbConnectionString = Properties.Settings.Default.DBConnectionsString;
        }

        public static DBConnection getInstanceOfDBConnection()
        {
            if (_instance == null)
                _instance = new DBConnection();
                return _instance;

        }

        public DataSet getDataSet(string sqlQuery)
        {
            DataSet dataset = new DataSet();
            

            using (SqlConnection connToDB = new SqlConnection(dbConnectionString))
            {
                connToDB.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connToDB);

                adapter.Fill(dataset);

            }

            return dataset;
        }
    }
}
 