using Data.Connect;
using QLDA.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace QLDA.Controllers
{
    public class VonController : BaseController
    {
        // GET: Von
        public JsonResult GetGDVon()
        {
            return Json(vonBusiness.GetVonGD(), JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        [AuthenToken]
        public JsonResult AddVon(tbl_von v)
        {
            return Json(vonBusiness.AddVon(v), JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        [AuthenToken]
        public JsonResult AddVonGD(tbl_von_giaidoan vgd)
        {
            return Json(vonBusiness.AddVonGD(vgd), JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        [AuthenToken]
        public JsonResult EditVon(tbl_von v)
        {
            return Json(vonBusiness.EditVon(v), JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        [AuthenToken]
        public JsonResult DeleteVon(int? idvon)
        {
            return Json(vonBusiness.DeleteVon(idvon), JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        [AuthenToken]
        public JsonResult SearchVon(string tenvon, int? idduan, int? idtieuda)
        {
            return Json(vonBusiness.SearchVon(tenvon,idduan,idtieuda), JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        [AuthenToken]
        public JsonResult VonDetail(int? idvon)
        {
            return Json(vonBusiness.VonDetail(idvon), JsonRequestBehavior.AllowGet);
        }
        public FileResult ReportVon(string tenvon, int? idduan, int? idtieuda)
        {
            return File(vonBusiness.ReportVon(tenvon, idduan,idtieuda).GetAsByteArray(), "application / vnd.openxmlformats - officedocument.spreadsheetml.sheet", "ReportVon.xlsx");

        }

    }
}