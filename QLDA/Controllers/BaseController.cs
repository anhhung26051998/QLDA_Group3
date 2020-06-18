using System;
using System.Collections.Generic;
using System.Linq;
using Data.Connect;
using System.Web;
using Data.Business;
using System.Web.Mvc;
using QLDA.App_Start;

namespace QLDA.Controllers
{


    public class BaseController : Controller
    {
        // GET: Base
        protected QLDAEntities Context;
        public UserBusiness userBusiness;
        public DuanBusiness duanBusiness;
        public DropDownBusiness dropDownBusiness;
        public ExportBusiness exportBusiness;
        public ChuDauTuBusiness chudautuBusiness;
        public VonBusiness vonBusiness;
        public BaseController() : base()
        {
            userBusiness = new UserBusiness(this.GetContext());
            duanBusiness = new DuanBusiness(this.GetContext());
            dropDownBusiness = new DropDownBusiness(this.GetContext());
            exportBusiness = new ExportBusiness(this.GetContext());
            chudautuBusiness = new ChuDauTuBusiness(this.GetContext());
            vonBusiness = new VonBusiness(this.GetContext());
        }
        public QLDAEntities GetContext()
        {
            if (Context == null)
            {
                Context = new QLDAEntities();
            }
            return Context;
        }
    }
}