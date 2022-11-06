using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyTest.Models;

namespace MyTest.Controllers
{
    public class ApplicationController : Controller
    {
        // GET: Application
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SaveApplication(ApplicationModel model)
        {
            try
            {
                return Json(new { Message = (new ApplicationModel().SaveApplication(model)) },JsonRequestBehavior.AllowGet);
            }
            catch (Exception Ex)
            {
                return Json(new { Ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }
        public ActionResult GetApplication (ApplicationModel model)
        {
            try
            {
                return Json(new { model = (new ApplicationModel().GetApplication()) },JsonRequestBehavior.AllowGet);
            }
            catch (Exception Ex)
            {
                return Json(new {  model= Ex.Message }, JsonRequestBehavior.AllowGet);
            }
         jwa}
    }
}