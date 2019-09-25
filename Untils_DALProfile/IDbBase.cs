using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace Untils_DALProfile
{
    public interface IDbBase
    {
        DbCommand CreateCommand();
        DbConnection CreateConnection();
        DbDataAdapter CreateDataAdapter();
        DbParameter CreateParameter();
    }
}
