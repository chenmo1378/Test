using DTcms.Common;
using DTcms.Web.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DTcms.Web.Controllers
{
    public class HomeController : BaseController
    {
        

        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }

        
    }
}
