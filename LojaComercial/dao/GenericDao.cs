using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LojaComercial.dao
{
    abstract class GenericDao
    {
        private const String connectionString = "Data Source=(localdb)\\lojacomercial; Initial Catalog=lojacomercial; Integrated Security=True;";

        private SqlConnection sqlConn;
        
        public GenericDao()
        {
            SqlConn = new SqlConnection(connectionString);

            SqlConn.Open();

            System.Diagnostics.Debug.WriteLine("Conexão efetuada !");
        }

        public SqlConnection SqlConn
        {
            get { return sqlConn; }
            set { sqlConn = value; }
        }

        public void close()
        {
            if (SqlConn.State == System.Data.ConnectionState.Open)
            {
                SqlConn.Close();
            }            
        }
    }
}
