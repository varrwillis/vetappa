using Sabio.Data.Providers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sabio.Data
{
    public sealed class DataProvider
    {
        private DataProvider() { }

        public static IDao Instance
        {
            get
            {
                return SqlDao.Instance;
            }
        }

        public static void ExecuteNonQuery(object getConnection, string v, Func<SqlParameterCollection, object> inputParamMapper, Func<SqlParameterCollection, object> returnParameters)
        {
            throw new NotImplementedException();
        }

        public static void ExecuteCmd(object getConnection, string v, Func<SqlParameterCollection, object> inputParamMapper, Func<IDataReader, short, object> map)
        {
            throw new NotImplementedException();
        }
    }
}
