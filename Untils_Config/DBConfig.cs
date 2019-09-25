using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace Untils_Config
{
    public class DBConfig
    {
        public static readonly string ResConnStr = ConfigurationManager.ConnectionStrings["UntilsConn"].ConnectionString;
    }
}
