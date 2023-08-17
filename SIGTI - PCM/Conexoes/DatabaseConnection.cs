using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace SIGT___PCM.Conexoes
{
    public class DatabaseConnection
    {
        public static OleDbConnection DB_SIGT()
        {
            string sql = System.Configuration.ConfigurationManager.ConnectionStrings["DB_SIGT"].ConnectionString;
            OleDbConnection CONEX = new OleDbConnection(sql);
            CONEX.Open();
            return CONEX;
        }
    }
}
