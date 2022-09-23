using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AssignmentCV.Controllers
{
    public class CVController : Controller
    {
        // GET: CV
        public ActionResult Index()
        {
            ViewBag.Name = "Subrata Das";
            ViewBag.Fname = "Nittya Gopal Das";
            ViewBag.Mname = "Anju Rani Das";
            ViewData["Gender"] = "Male";
            ViewBag.Mstat = " unmarried";
            ViewData["Nationality"] = "Bangladeshi";
            ViewBag.PermanentAddress = "Barisal, Bangladesh";
            ViewData["PhoneNo"] = "+8801761147512";
            ViewData["Email"] = "sumib2k17@gmail.com";

            return View();
        }
        public ActionResult Education()
        {
            return View();
        }

        public ActionResult ExtracExtracurricularActivities()
        {
            ViewBag.first = "Scout parade commander second division, OMHS";
            ViewBag.second = "Graphics Designer at Digital Fire Safety Ltd";
            ViewBag.third = "VFX Design using Adobe Maya";
            ViewBag.fourth = "Photographer and Video editor at AIUB Film Club";
            ViewBag.fifth = "competitive programming";
            return View();
        }
        public ActionResult Reference()
        {
            return View();
        }
        public ActionResult CVintro()
        {
            return View();
        }

    }
}