using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Untils_Web.WebContent.Html
{
    public partial class Index : System.Web.UI.Page
    {
        private Untils_BLL.BLLUser bu = new Untils_BLL.BLLUser();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataTable dt = bu.GetAllData();
            DataTable ss = dt;
        }
    }
}