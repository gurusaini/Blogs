using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using BlogApp.Models;
namespace BlogApp.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Logout()
        {
            Session["LoginId"] = null;
            Session.Abandon();
            return RedirectToAction("Login");
        }
        [HttpPost]
        public JsonResult ValidateUser(string userid, string password)
        {
            BlogsEntities1 objEntities = new BlogsEntities1();
            var res = objEntities.LoginUser(userid, password);
            int item = (int)res.FirstOrDefault();
            if (item > 0)
            {
                //FormsAuthentication.SetAuthCookie(item.ToString(), false);
                Session["LoginId"] = item.ToString();
                System.Web.HttpContext.Current.Session["UserId"] = item.ToString();
                return Json(new { Success = true }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { Success = false }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}
