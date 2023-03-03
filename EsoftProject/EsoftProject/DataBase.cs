using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsoftProject
{
    class DataBase
    {

        public static SqlConnection SqlConnection()
        {
            return new SqlConnection(@"Data Source=KAURCEV\SQLEXPRESS; Initial Catalog =Esoft; Integrated Security=True");
        }
        public static void toDB(string stroke)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(stroke, SqlConnection());
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
        }
        public static DataTable fromDB(string stroke)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(stroke, SqlConnection());
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            DataTable dataTable = dataSet.Tables[0];
            return dataTable;
        }
    }
}
