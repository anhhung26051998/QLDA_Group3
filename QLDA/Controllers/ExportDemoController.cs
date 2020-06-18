using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLDA.Controllers
{
    public class ExportDemoController : BaseController
    {
        // GET: ExportDemo
        public FileResult Export()
        {
            return File(exportBusiness.Export().GetAsByteArray(), "application / vnd.openxmlformats - officedocument.spreadsheetml.sheet", "Report.xlsx");
        }
    }
}