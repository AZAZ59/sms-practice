using System.Web.Services;
using System.Web.Script.Services;

namespace Project.Services
{
	[WebService(Namespace = "http://tempuri.org/")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[System.ComponentModel.ToolboxItem(false)]
	[System.Web.Script.Services.ScriptService]
	public class UserService : System.Web.Services.WebService
	{
		[WebMethod(EnableSession = true)]
		public string UserLogin(string Username, string Password)
		{
			if (Username == "yasin" && Password == "123456")
			{
				return "true";
			}
			else
			{
				return "false";
			}
		}
	}
}