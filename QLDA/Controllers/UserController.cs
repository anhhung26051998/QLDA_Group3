using Data.Connect;
using QLDA.App_Start;
using QLDA.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLDA.Controllers
{
    public class UserController : BaseController
    {
        [HttpPost]
        public JsonResult Login(string UserName,string PassWord)
        {
       
            return Json(userBusiness.Login(UserName,PassWord), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public void Logout( int ?Userid )
        {
          userBusiness.Logout(Userid);
        }
        [HttpPost]
        [AuthenToken]
        public JsonResult AddUser(tbl_z_users us)
        {
            return Json(userBusiness.AddUser(us), JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        [AuthenToken]
        public JsonResult EditUser(tbl_z_users us)
        {
            return Json(userBusiness.EditUser(us), JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        [AuthenToken]
        public JsonResult DeleteUser(int?User_Id)
        {
            return Json(userBusiness.DeleteUser(User_Id), JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        [AuthenToken]
        public JsonResult SearchUser(string name)
        {
            return Json(userBusiness.SearchUser(name), JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        [AuthenToken]
        public JsonResult Userdetail(int? User_Id)
        {
            return Json(userBusiness.Userdetail(User_Id), JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        [AuthenToken]
        public JsonResult ChangPass(string UserName, string PassWord, string PassWordNew)
        {
            return Json(userBusiness.ChangPass(UserName, PassWord, PassWordNew), JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        [AuthenToken]
        public JsonResult ResetPass(int? id)
        {
            return Json(userBusiness.ResetPass(id), JsonRequestBehavior.AllowGet);
            
        }


    }
}