using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Test1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
            if(Session["login"] == "True")
            {
                Response.Redirect("game1");
            }else if(Session["loginChat"] == "True")
            {
                Response.Redirect("ChatForm");
            }
            if (IsPostBack)
            {
                if(Request.Form["user"] != null && Request.Form["passwd"] != null)
                {
                    if (Request.Form["user"] == "root" )
                    {
                        Label3.Text = "正確";
                    }
                    else
                    {
                        Label3.Text = "錯誤";
                    }
                    if (Request.Form["passwd"] == "123456")
                    {
                        Label4.Text = "正確";
                    }
                    else
                    {
                        Label4.Text = "錯誤";
                    }
                    if (Request.Form["user"] == "root" && Request.Form["passwd"] == "123456")
                    {
                        Application["login"] = Convert.ToInt32(Application["login"]) + 1;
                        Session["login"] = "True";
                        Response.Redirect("game1");
                    }
                }
                else
                {
                    Response.Write("Error");
                }
            }
            */
            if (Session["login"] == "True")
            {
                Response.Redirect("game1");
            }
            else if (Session["loginChat"] == "True")
            {
                Response.Redirect("ChatForm");
            }
            if (IsPostBack)
            {
                if (Request.Form["user"] != null && Request.Form["passwd"] != null)
                {
                    string s_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["AcountConnectionString1"].ConnectionString;
                    SqlConnection connection = new SqlConnection(s_data);
                    string sql_str = $"select * from Acounts where UserName='{Request.Form["user"]}'";
                    SqlCommand Command = new SqlCommand(sql_str, connection);
                    connection.Open();
                    SqlDataReader Reader = Command.ExecuteReader();
                    if (Reader.HasRows)
                    {
                        if (Reader.Read())
                        {
                            if (Reader["Password"].ToString() == Request.Form["passwd"])
                            {
                                Application["login"] = Convert.ToInt32(Application["login"]) + 1;
                                Session["login"] = "True";
                                Response.Redirect("game1");
                            }
                            else
                            {
                                Label4.Text = "錯誤";
                            }
                        }
                    }
                    else
                    {
                        Label3.Text = "無此帳號或帳號錯誤";
                    }

                    //關閉與資料庫連接的通道
                    connection.Close();
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            /*
            if (TextBox1.Text == "root")
            {
                Label1.Text = "正確";
                if(TextBox2.Text == "123456")
                {
                    Label2.Text = "正確";
                }
                else
                {
                    Label2.Text = "錯誤";
                }
            }
            else
            {
                Label1.Text = "錯誤";
            }
            */            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (Request.Form["chatuser"] == "root" && Request.Form["chatpasswd"] == "123456")
            {
                Application["loginChat"] = Convert.ToInt32(Application["loginChat"]) + 1;
                Session["loginChat"] = "True";
                Session["chatname"] = Request.Form["chatname"];
                Response.Redirect("ChatForm");
            }
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            Button3.Text = "哭啊!!!";
            LinkButton1.Text = "是時候轉守為攻了!!";
            ImageButton1.ImageUrl = "https://memeprod.sgp1.digitaloceanspaces.com/user-resource/4da62457198a6fde4d3469f97afcfd21.png";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string s_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["AcountConnectionString1"].ConnectionString;

            SqlConnection connection = new SqlConnection(s_data);

            string setsql = $"insert into [Acounts](UserName, Password, name) values('{Request.Form["chatuser"]}','{Request.Form["chatpasswd"]}','{Request.Form["chatname"]}')";

            SqlCommand Command = new SqlCommand(setsql, connection);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(Command);//從Command取得資料存入dataAdapter

            DataSet dataset = new DataSet();//創一個dataset的記憶體資料集

            dataAdapter.Fill(dataset);//將dataAdapter資料存入dataset

            /*
            //新增一筆資料
            DataRow newRow = dataset.Tables["Acounts"].NewRow();
            newRow["UserName"] = "root";
            newRow["Password"] = "Root123456789";
            newRow["name"] = "Root";
            dataset.Tables["Acounts"].Rows.Add(newRow);

            //移除一筆資料
            dataset.Tables["Acounts"].Rows.Remove(dataset.Tables["Acounts"].Rows[1]);

            //修改一筆資料
            DataRow[] rows = dataset.Tables["Acounts"].Select("id=1");
            if (rows.Length > 0)
            {
                rows[0]["id"] = 2;
            }

            GridView1.DataSource = dataset; //告訴GridView1的DataSource資料來源是dataset
            GridView1.DataBind(); //資料繫結
            */
        }
    }
}