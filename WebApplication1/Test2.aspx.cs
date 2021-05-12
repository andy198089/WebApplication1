using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Test2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["row"] != null && Request.QueryString["col"] != null)
            {
                Label1.Text = "";
                int row = int.Parse(Request.QueryString["row"]);
                int col = int.Parse(Request.QueryString["col"]);
                for (int i = 1; i <= row; i++)
                {
                    for(int j = 1; j <= col; j++)
                    {
                        Label1.Text += $"{i} x {j} = {i*j}"+ "&nbsp;&nbsp;&nbsp;";
                    }
                    Label1.Text += "</br>";
                }
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://www.google.com");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if(user.Text == "root" && passwd.Text == "123456")
            {
                Response.Redirect("http://www.googel.com");
            }
            else
            {
                Response.Redirect("http://www.yahoo.com.tw");
            }
        }
    }
}