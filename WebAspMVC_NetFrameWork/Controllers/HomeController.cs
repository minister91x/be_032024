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
        public ActionResult Index()
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
    }
}