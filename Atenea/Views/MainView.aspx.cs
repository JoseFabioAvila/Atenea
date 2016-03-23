using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Atenea
{
    public partial class mainView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Models.Conexion inst = new Models.Conexion();
            int x = inst.conectar();
            TextBox1.Text = x.ToString();
        }
    }
}