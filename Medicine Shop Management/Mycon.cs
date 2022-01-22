using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Medicine_Shop_Managment_System
{
    class Mycon
    {
        public SqlConnection Con;
        public Mycon()
        {
            Con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString);
        }
    }
}
