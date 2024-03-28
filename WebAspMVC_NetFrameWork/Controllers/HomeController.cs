using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAspMVC_NetFrameWork.Models;

namespace WebAspMVC_NetFrameWork.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string id)
        {
            var model_return_view = new List<DemoModels>();
            for (int i = 0; i < 2; i++)
            {
                model_return_view.Add(new DemoModels { Id = i, Name = "LOP ASP NET MVC NGAY : " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") });
            }


            return View(model_return_view);// NÉM DỮ LIỆU TỪ TRONG MODEL LÊN VIEW 
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public JsonResult AccountInsert(AccountInsertRequestData requestData)
        {
            var returnData = new InsertAccountResponseDataa();
            try
            {
                if (requestData == null ||
                    string.IsNullOrEmpty(requestData.email)
                    || string.IsNullOrEmpty(requestData.password))
                {
                    returnData.Code = -1;
                    returnData.Description = "Dữ liệu đầu vào không hợp lệ";
                    return Json(returnData, JsonRequestBehavior.AllowGet);

                }

                // INSERT DỮ LIỆU
                // gọi interface

                var req = new DataAccess.NetFrameWork.Account {
                    email = requestData.email,
                    password = requestData.password
                };


                var result = new DataAccess.NetFrameWork.Interface.AccountManagerment()
                    .Account_Insert(req);



                returnData.Code = 1;
                returnData.Description = "Email : " + requestData.email + " | pass :" + requestData.password;
                return Json(returnData, JsonRequestBehavior.AllowGet);

            }
            catch (Exception ex)
            {

                throw;
            }

            return Json(returnData, JsonRequestBehavior.AllowGet);
        }
    }
}