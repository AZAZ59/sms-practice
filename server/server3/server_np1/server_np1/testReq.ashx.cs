using System;
using System.Web;
using System.Web.UI;


namespace server_np1
{
	
	public class testReq : System.Web.IHttpHandler
	{
	
		public void ProcessRequest (HttpContext context)
		{
			HttpRequest Request = context.Request;
			HttpResponse Response = context.Response;
			string s = string.Empty;
			s = Request.QueryString.Get(0);

			Response.ContentType = "application/json";
			Response.AddHeader ("Access-Control-Allow-Origin", "*");
			//Response.Write ("{\"test\":123,\"qwe\":321}");

			Response.Write ("{\"test\":123,\"data\":\""+Request.QueryString.ToString()+"\"}");
			Console.WriteLine ("{\"test\":123,\"data\":\"" + Request.QueryString.ToString () + "\"}");
		}
		public bool IsReusable {
			get { return true; }
		}
	}
}