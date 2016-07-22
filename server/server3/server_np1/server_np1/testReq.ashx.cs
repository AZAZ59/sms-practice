using System;
using System.Web;
using System.Web.UI;


namespace server_np1
{
	
	public class testReq : System.Web.IHttpHandler
	{
		public static bool NoRecomendedZone115(double power, double pressure)
		{
			if (power < 22 || power > 160 || pressure < 14 || pressure > 30) return false;
			if (0.5 * power + 5 < pressure && 22 <= power && power <= 50) return true;
			else return false;
		}
		public static bool ForbiddenZone115(double power, double pressure)
		{
			if (power < 22 || power > 160 || pressure < 14 || pressure > 30) return false;
			if (78 <= power && power < 100 && 0.1 * power + 7 > pressure) return true;
			else if (100 <= power && power < 117 && 0.15 * power + 2 > pressure) return true;
			else if (power >= 117) return true;
			else return false;
		}
		public static string CheckZone115(double power, double pressure)
		{
			if (power < 22 || power > 160 || pressure < 14 || pressure > 30) return "Íå èçâåñòíî";
			else if (NoRecomendedZone115(power, pressure)) return "Íå ðåêîìåíäóåìàÿ çîíà";
			else if (ForbiddenZone115(power, pressure)) return "Çàïðåùžííàÿ çîíà";
			else return "Äîïóñòèìàÿ çîíà";
		}
		public static bool NoRecomendedZone120(double power, double pressure)
		{
			if (power < 22 || power > 160 || pressure < 14 || pressure > 30) return false;
			if (0.6 * power + 2 < pressure && 22 <= power && power <= 42 && pressure <= 27) return true;
			else return false;
		}
		public static bool ForbiddenZone120(double power, double pressure)
		{
			if (power < 22 || power > 160 || pressure < 14 || pressure > 30) return false;
			if (pressure > 27) return true;
			if (65 <= power && power < 110 && 0.125 * power + 6.25 > pressure) return true;
			else if (110 <= power && power < 120 && 0.15 * power + 3.5 > pressure) return true;
			else if (120 <= power && power < 122 && power - 118.5 > pressure) return true;
			else if (power >= 122) return true;
			else return false;
		}
		public static string CheckZone120(double power, double pressure)
		{
			if (power < 22 || power > 160 || pressure < 14 || pressure > 30) return "Íå èçâåñòíî";
			else if (NoRecomendedZone120(power, pressure)) return "Íå ðåêîìåíäóåìàÿ çîíà";
			else if (ForbiddenZone120(power, pressure)) return "Çàïðåùžííàÿ çîíà";
			else return "Äîïóñòèìàÿ çîíà";
		}
		public static bool NoRecomendedZone125(double power, double pressure)
		{
			if (power < 20 || power > 160 || pressure < 14 || pressure > 30) return false;
			if (0.5 * power < pressure && power <= 61) return true;
			else return false;
		}
		public static bool ForbiddenZone125(double power, double pressure)
		{
			if (power < 20 || power > 160 || pressure < 14 || pressure > 30) return false;
			if (80 <= power && power < 128 && 2 * power / 15 + 10 / 3 > pressure) return true;
			else if (128 <= power && power < 144 && 0.35 * power - 24.5 > pressure) return true;
			else if (power >= 144) return true;
			else return false;
		}
		public static string CheckZone125(double power, double pressure)
		{
			if (power < 20 || power > 160 || pressure < 14 || pressure > 30) return "Íå èçâåñòíî";
			else if (NoRecomendedZone125(power, pressure)) return "Íå ðåêîìåíäóåìàÿ çîíà";
			else if (ForbiddenZone125(power, pressure)) return "Çàïðåùžííàÿ çîíà";
			else return "Äîïóñòèìàÿ çîíà";
		}
		
	
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