using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace Untils_Config
{
    public class UIConfig
    {
        public static readonly string WebDAL = ConfigurationManager.AppSettings["WebDAL"];
    }
}
