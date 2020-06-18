using Data.Connect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Filters;
using System.Web.Mvc;
using QLDA.Common;

namespace Data.Business
{    
    public class GenericBusiness: System.Web.Mvc.ActionFilterAttribute
    {
       
        public QLDAEntities context = new QLDAEntities();
        public QLDAEntities cnn = new QLDAEntities();
        
       // public SystemResultBusiness resultBus = new SystemResultBusiness();
        public GenericBusiness(QLDAEntities context = null)
        {
            this.context = context == null ? new QLDAEntities() : context;

            cnn = this.context;
            
        }
    }
}