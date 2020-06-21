using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Data.Business;
using Data.Connect;
using QLDA.App_Start;

namespace QLDA.Controllers
{
   
    public class DuanController : BaseController
    {
        // GET: Duan
      
        [HttpGet]
        public JsonResult Search(int? chudatu,string tenda="", string mada="", int? tinh=null)
        {
            return Json(duanBusiness.Search(tenda, mada, tinh, chudatu), JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public JsonResult SearchSpecail(int? tinh)
        {
            return Json(duanBusiness.SearchSpecail(tinh), JsonRequestBehavior.AllowGet);
        }    
        [HttpGet]
        public JsonResult DaDetail(int?id)
        {
            return Json(duanBusiness.DaDetail(id), JsonRequestBehavior.AllowGet);
        }
        public JsonResult SreachTieuDuan(int? idduan, int? chudautu, string name)
        {
            return Json(duanBusiness.SreachTieuDuan(idduan,chudautu,name), JsonRequestBehavior.AllowGet);
        }
        public JsonResult Gettongdautu(int?id,int?type)
        {
            return Json(duanBusiness.Gettongdautu(id,type), JsonRequestBehavior.AllowGet);
        }
  
        public JsonResult SearchDaAdmin(string nameandkey, int? tinh = null, int? chudatu = null,int?id=null)
        {
            return Json(duanBusiness.SearchDaAdmin(nameandkey, tinh, chudatu,id), JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        [AuthenToken]
        public JsonResult AddDuan(tbl_duan da,int?idtinh)
        {
            return Json(duanBusiness.AddDuan(da,idtinh), JsonRequestBehavior.AllowGet);
        }

     
        [HttpPost]
        [AuthenToken]

        public JsonResult EditDa(tbl_duan da, int? idtinh)
        {
            return Json(duanBusiness.EditDa(da, idtinh), JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        [AuthenToken]
        public JsonResult DeleteDuan(int? idda)
        {
            return Json(duanBusiness.DeleteDuan(idda), JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        [AuthenToken]
        public JsonResult AddTieuDa(tbl_tieuduan tieuda)
        {
            return Json(duanBusiness.AddTieuDa(tieuda), JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        [AuthenToken]
        public JsonResult EditTieuDa(tbl_tieuduan tieuda)
        {
            return Json(duanBusiness.EditTieuDa(tieuda), JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        [AuthenToken]
        public JsonResult DeleteTieuDa(int? id)
        {
            return Json(duanBusiness.DeleteTieuDa(id), JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        [AuthenToken]
        public JsonResult TieuDaDetail(int? id)
        {
            return Json(duanBusiness.TieuDaDetail(id), JsonRequestBehavior.AllowGet);
        }
     
        public FileResult ReportDuan(string nameandkey, int? tinh = null, int? chudatu = null, int? id = null)
        {
            return File(duanBusiness.ReportDuan(nameandkey, tinh, chudatu, id).GetAsByteArray(), "application / vnd.openxmlformats - officedocument.spreadsheetml.sheet", "ReportDuan.xlsx");
        }
        public FileResult ReportTieuDuan(int? idduan, int? chudautu, string name)
        {
            return File(duanBusiness.ReportTieuDuan(idduan, chudautu, name).GetAsByteArray(), "application / vnd.openxmlformats - officedocument.spreadsheetml.sheet", "ReportTieuDuan.xlsx");
        }
    }
}