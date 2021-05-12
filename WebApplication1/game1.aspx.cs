using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class game1 : System.Web.UI.Page
    {
        static int ct = 30;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["login"] != "True")
            {
                Response.Redirect("Test1");
            }
            Label6.Text = "目前登入人數: "+Application["login"];
            Random rnd = new Random();
            if (IsPostBack)
            {
                int com = rnd.Next(1, 4);
                if (com == 1)
                {
                    Image1.ImageUrl = "~/pic/paper.png";
                }
                else if (com == 2)
                {
                    Image1.ImageUrl = "~/pic/sicer.png";
                }
                else if (com == 3)
                {
                    Image1.ImageUrl = "~/pic/stone.png";
                }
            }           
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            if(Image1.ImageUrl == "~/pic/paper.png")
            {
                Label4.Text = "平手";
                Session["draw"] = Convert.ToInt32(Session["draw"]) + 1;
            }
            else if(Image1.ImageUrl == "~/pic/sicer.png")
            {
                Label4.Text = "你輸了!";
                Session["lose"] = Convert.ToInt32(Session["lose"]) + 1;
            }
            else if (Image1.ImageUrl == "~/pic/stone.png")
            {
                Label4.Text = "你贏了!!!";
                Session["win"] = Convert.ToInt32(Session["win"]) + 1;
            }
            Label5.Text = $"平手{Session["draw"]}次、贏了{Session["win"]}次、輸了{Session["lose"]}次";
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            if (Image1.ImageUrl == "~/pic/paper.png")
            {
                Label4.Text = "你贏了!!!";
                Session["win"] = Convert.ToInt32(Session["win"]) + 1;
            }
            else if (Image1.ImageUrl == "~/pic/sicer.png")
            {
                Label4.Text = "平手";
                Session["draw"] = Convert.ToInt32(Session["draw"]) + 1;
            }
            else if (Image1.ImageUrl == "~/pic/stone.png")
            {
                Label4.Text = "你輸了!";
                Session["lose"] = Convert.ToInt32(Session["lose"]) + 1;
            }
            Label5.Text = $"平手{Session["draw"]}次、贏了{Session["win"]}次、輸了{Session["lose"]}次";
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            if (Image1.ImageUrl == "~/pic/paper.png")
            {
                Label4.Text = "你輸了!";
                Session["lose"] = Convert.ToInt32(Session["lose"]) + 1;
            }
            else if (Image1.ImageUrl == "~/pic/sicer.png")
            {
                Label4.Text = "你贏了!!!";
                Session["win"] = Convert.ToInt32(Session["win"]) + 1;
            }
            else if (Image1.ImageUrl == "~/pic/stone.png")
            {
                Label4.Text = "平手";
                Session["draw"] = Convert.ToInt32(Session["draw"]) + 1;
            }
            Label5.Text = $"平手{Session["draw"]}次、贏了{Session["win"]}次、輸了{Session["lose"]}次";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Application["login"] = Convert.ToInt32(Application["login"]) - 1;
            Session.RemoveAll();
            Response.Redirect("Test1");
        }
        protected void Timer1_Tick1(object sender, EventArgs e)
        {
            ct--;
            Label7.Text = "時間倒數:" + ct;
        }
    }
}