using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLDA.Controllers
{
    public class DropDownController : BaseController
    {
        // GET: DropDown
        public JsonResult Gettinh()
        {
            return Json(dropDownBusiness.GetTinh(),JsonRequestBehavior.AllowGet);
        }
        public JsonResult Getchudautu()
        {
            return Json(dropDownBusiness.Getchudautu(), JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetallHTQL()
        {
            return Json(dropDownBusiness.GetallHTQL(), JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetallLoaivon()
        {
            return Json(dropDownBusiness.GetallLoaivon(), JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetloaiCDT()
        {
            return Json(dropDownBusiness.GetloaiCDT(), JsonRequestBehavior.AllowGet);
        }
        
        public JsonResult GetRole()
        {
            return Json(dropDownBusiness.GetRole(), JsonRequestBehavior.AllowGet);
        }

        public int GetOverview(int? type)
        {
            return dropDownBusiness.GetOverview(type);
        }

        public JsonResult GetDuan()
        {
            return Json(dropDownBusiness.GetDuan(), JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetTieuDuan(int? idduan)
        {
            return Json(dropDownBusiness.GetTieuDuan(idduan), JsonRequestBehavior.AllowGet);
        }
    }
}