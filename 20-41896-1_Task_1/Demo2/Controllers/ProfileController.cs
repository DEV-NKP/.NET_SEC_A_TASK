using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo2.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        public ActionResult Index()
        {
            ViewData["Name"] = "Niloy Kanti Paul";
            ViewData["Mail"] = "niloykantipaul.aiub@gmail.com";


            return View();
        }
        public ActionResult Basic()
        {
            ViewBag.Message = "Your application description page.";
            ViewData["Name"] = "Niloy Kanti Paul";
            ViewData["Father_Name"] = "Mrinal Kanti Paul";

            ViewData["Mother_Name"] = "Alay Rani Paul";

            ViewData["Gender"] = "Male";

            ViewData["Marital_Status"] = "Single";

            ViewData["Mobile_No"] = "01787700037";

            ViewData["Religion"] = "Hindu";

            ViewData["Nationality"] = "Bangladeshi";
            ViewData["Mail"] = "niloykantipaul.aiub@gmail.com";
            return View();
        }

        public ActionResult Education()
        {
            ViewBag.Message = "Your application description page.";
         
            return View();
        }

        public ActionResult Project()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Reference()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}