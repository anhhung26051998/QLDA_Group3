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
    public class ChuDauTuController : BaseController
    {
        // GET: ChuDauTu
        public JsonResult Search(string name="")
        {
            return Json(chudautuBusiness.Search(name),JsonRequestBehavior.AllowGet);
        }
        public JsonResult ChuDauTuDetail(int?id=null)
        {
            return Json(chudautuBusiness.ChuDauTuDetail(id), JsonRequestBehavior.AllowGet);
        }
        public JsonResult SearchTieuDaByDa(int?idda)
        {
            return Json(chudautuBusiness.SearchTieuDaByDa(idda), JsonRequestBehavior.AllowGet);
        }
        [AuthenToken]
        [HttpPost]
        public JsonResult AddCDT(tbl_chudautu cdt)
        {
            return Json(chudautuBusiness.AddCDT(cdt), JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        [AuthenToken]
        public JsonResult EditCDT(tbl_chudautu cdt)
        {
            return Json(chudautuBusiness.EditCDT(cdt), JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        [AuthenToken]
        public JsonResult DeleteCDT(int?id)
        {
            return Json(chudautuBusiness.DeleteCDT(id), JsonRequestBehavior.AllowGet);
        }

    }
}