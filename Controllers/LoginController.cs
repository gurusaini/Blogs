using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BlogApp.Models;
namespace BlogApp.Controllers
{
    public class LoginController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
        [HttpPost]
        public int ValidateUser(string userid, string password)
        {
            BlogsEntities1 objEntities = new BlogsEntities1();
            var res = objEntities.LoginUser(userid, password);
            int item = (int)res.FirstOrDefault();

            if (item > 0)
            {
                System.Web.HttpContext.Current.Session["LoginId"] = item.ToString();
            }

            return item;

        }
    }
}