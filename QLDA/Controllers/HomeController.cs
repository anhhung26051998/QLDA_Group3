using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QLDA.Common;
using QLDA.App_Start;

namespace QLDA.Controllers
{
    public class HomeController : BaseController
    {

        public ActionResult Index()
        {
            return View();
        }


        [AuthenToken]
        [HttpGet]

        public ActionResult Contact()
        {


            return Json("Có Dữ Liệu Rồi Nhé!", JsonRequestBehavior.AllowGet);
        }
        public JsonResult Erorr()
        {

            Erorracess data = new Erorracess();
            data.Code = 404;
            data.Status = "Erorr Token!";
            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}