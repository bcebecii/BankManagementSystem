using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace den_2
{   
    public static class SqlOperations
    { 
      public static SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-7PU6J5N;Initial Catalog=den2;Integrated Security=True");

    }
}
