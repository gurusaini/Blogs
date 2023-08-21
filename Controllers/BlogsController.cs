using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogApp.Controllers
{
    public class BlogsController : Controller
    {
        // GET: Blogs
        public ActionResult Index()
        {
            return View();
        }
        [Route("Blog/BlogDetails/{id}")]
        public ActionResult BlogDetail(string id)
        {
            ViewBag.BlogId = id;            
            return View();
        }
        public ActionResult CreateBlog()
        {
            if (!string.IsNullOrEmpty(Session["LoginId"] as string))
            {
                string LoginId = Session["LoginId"].ToString();
                ViewBag.LoginId = LoginId;
                return View();
            }
            else
            {
                return RedirectToAction("LogIn", "Account", new { area = "" });
            }
        }
        public ActionResult UpdateBlog(string id)
        {
            if (!string.IsNullOrEmpty(Session["LoginId"] as string))
            {
                string LoginId = Session["LoginId"].ToString();
                ViewBag.BlogId = id;
                ViewBag.LoginId = LoginId;
                return View();
            }
            else
            {
                return RedirectToAction("LogIn", "Account", new { area = "" });
            }
        }
        public ActionResult MyBlogs()
        {
            if (!string.IsNullOrEmpty(Session["LoginId"] as string))
            {
                string LoginId = Session["LoginId"].ToString();
                ViewBag.LoginId = LoginId;
                return View();
            }
            else
            {
                return RedirectToAction("LogIn", "Account", new { area = "" });
            }
        }
    }
}