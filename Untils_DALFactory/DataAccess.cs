using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Untils_DALFactory
{
    public sealed partial class DataAccess
    {
        private static readonly string path = Untils_Config.UIConfig.WebDAL;
        public DataAccess() { }
    }
}