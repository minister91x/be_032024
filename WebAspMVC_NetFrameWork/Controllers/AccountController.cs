using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebAspMVC_NetFrameWork.Models;

namespace WebAspMVC_NetFrameWork.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        public async Task<JsonResult> Login(LoginRequestData requestData)
        {
            var returnData = new UserLoginReturnData();
            try
            {
                var url = System.Configuration.ConfigurationManager.AppSettings["API_URL"] ?? "";
                var baseUrl = "/api/Account/Login"; //-> http://localhost:5168//api/Account/Login"'
                var jsonData = JsonConvert.SerializeObject(requestData);

                // gọi api netcore 
                var result = await CommonLibs.HttpHelper.SendPost(url, baseUrl, jsonData);

                if (!string.IsNullOrEmpty(result))
                {
                    returnData = JsonConvert.DeserializeObject<UserLoginReturnData>(result);
                }
                

            }
            catch (Exception ex)
            {

                throw;
            }

            return Json(returnData, JsonRequestBehavior.AllowGet);
        }
    }
}