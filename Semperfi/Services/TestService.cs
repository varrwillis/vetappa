using Sabio.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semperfi.Services
{
    public class TestService : BaseService
    {
        public static void Delete(string Name)
        {

            DataProvider.ExecuteNonQuery(GetConnection, "dbo.TestTable_Delete"
               , inputParamMapper: delegate (SqlParameterCollection paramCollection)
               {

                   paramCollection.AddWithValue("@Name", Name);

               }, returnParameters: delegate (SqlParameterCollection param)
               {

               }
               );


        }
    }
}
