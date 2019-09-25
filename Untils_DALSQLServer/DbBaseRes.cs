using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Untils_DALProfile;

namespace Untils_DALSQLServer
{
    public class DbBaseRes:IDbBase
    {
        DbCommand IDbBase.CreateCommand()
        {
            return new SqlCommand();
        }
        DbConnection IDbBase.CreateConnection()
        {
            return new SqlConnection();
        }
        DbDataAdapter IDbBase.CreateDataAdapter()
        {
            return new SqlDataAdapter();
        }
        DbParameter IDbBase.CreateParameter()
        {
            return new SqlParameter();
        }

        protected string Pre;

        public DbBaseRes()
        {
            DB_UntilsHelper.Provider = this;
        }
    }
}
