using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Website
{
    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int count = 10;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("p");
            }
        }
    }
}