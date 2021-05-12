using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace WebApplication1
{
    /// <summary>
    /// Handler1 的摘要描述
    /// </summary>
    public class Handler1 : IHttpHandler, IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            if(context.Session["myFile"] != null)
            {
                HttpPostedFile myFile = (HttpPostedFile)context.Session["myFile"];
                int myFile_Length = myFile.ContentLength;
                byte[] myData = new byte[myFile_Length];
                myFile.InputStream.Read(myData, 0, myFile_Length);
                context.Response.ContentType = "image/jpeg";
                context.Response.BinaryWrite(myData);
            }
            //context.Response.ContentType = "text/plain";
            //context.Response.Write("Hello World");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}