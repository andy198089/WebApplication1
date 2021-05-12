using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ChatForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["loginChat"] != "True")
            {
                Response.Redirect("Test1");
            }
            Label1.Text = "目前上線人數: " + Application["loginChat"];
            if (IsPostBack != true)
            {
                Application["Chat_content"] += $"{Session["chatname"]} 加入聊天室!!" + Environment.NewLine;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Application["Chat_content"] += $"{Session["chatname"]} 離開聊天室!!" + Environment.NewLine;
            Application["loginChat"] = Convert.ToInt32(Application["loginChat"]) - 1;
            Session.RemoveAll();
            Response.Redirect("Test1");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Application["Chat_content"] += $"{Session["chatname"]}: {TextBox2.Text}" + Environment.NewLine;
            TextBox1.Text = (string)Application["Chat_content"];
            TextBox2.Text = "";
        }

        protected void Timer2_Tick(object sender, EventArgs e)
        {
            TextBox1.Text = (string)Application["Chat_content"];
        }
    }
}