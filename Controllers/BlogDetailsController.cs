using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BlogApp.Models;
namespace BlogApp.Controllers
{
    public class BlogDetailsController : ApiController
    {
        [HttpGet]
        public IEnumerable<BlogList> GetBlogList()
        {
            List<BlogList> lstBlog = new List<BlogList>();
            BlogsEntities1 objEntities = new BlogsEntities1();
            var res = objEntities.ViewBlogs();
            foreach (var lst in res)
            {
                BlogList obj = new BlogList();
                obj.Id = lst.Id;
                obj.Title = lst.Title;
                obj.Author = lst.Author;
                obj.BlogContent = lst.BlogContent;
                obj.Published_Date = lst.Published_Date;
                lstBlog.Add(obj);
            }
            return lstBlog;
        }
        [Route("api/BlogDetails/MyBlogList/{Author}")]
        [HttpGet]
        public IEnumerable<BlogList> MyBlogList(int Author)
        {
            List<BlogList> lstBlog = new List<BlogList>();
            BlogsEntities1 objEntities = new BlogsEntities1();
            var res = objEntities.MyBlogs(Author);
            foreach (var lst in res)
            {
                BlogList obj = new BlogList();
                obj.Id = lst.Id;
                obj.Title = lst.Title;
                obj.BlogContent = lst.BlogContent;
                obj.Status = lst.Status;
                obj.Published_Date = lst.Published_Date;
                obj.Creation_Date = lst.Creation_Date;
                lstBlog.Add(obj);
            }

            return lstBlog;
        }

        // GET api/<controller>/5
        [Route("api/BlogDetails/{id}")]
        [HttpGet]
        public BlogList Get(int id)
        {
            BlogList objList = new BlogList();
            BlogsEntities1 objEntities = new BlogsEntities1();

            var res = objEntities.ViewBlogDetail(id);

            foreach (var lst in res)
            {
                objList.Id = lst.Id;
                objList.Author = lst.Author;
                objList.Title = lst.Title;
                objList.BlogContent = lst.BlogContent;
                objList.Published_Date = lst.Published_Date;
                objList.BlogImage = lst.BlogImage;
                objList.BlogVideo = lst.BlogVideo;
                objList.Status = lst.Status;
                objList.Creation_Date = lst.Creation_Date;
            }
            return objList;
        }

        // POST api/<controller>
        [Route("api/BlogDetails/CreateBlog")]
        [HttpPost]
        public int CreateBlog([FromBody] BlogList blogList)
        {
            BlogsEntities1 objEntities = new BlogsEntities1();
            int res = objEntities.Blogs_CreateUpdate(0, blogList.Title,Convert.ToInt32(blogList.Author), blogList.BlogContent, blogList.Status, blogList.BlogImage, blogList.BlogVideo);
            return res;
        }
        [Route("api/BlogDetails/EditBlog")]
        [HttpPost]
        public int EditBlog([FromBody] BlogList blogList)
        {
            BlogsEntities1 objEntities = new BlogsEntities1();
            int res = objEntities.Blogs_CreateUpdate(blogList.Id, blogList.Title, Convert.ToInt32(blogList.Author), blogList.BlogContent, blogList.Status, blogList.BlogImage, blogList.BlogVideo);
            return res;
        }
        [Route("api/BlogDetails/DeleteBlog/{id}")]
        [HttpPost]
        public int DeleteBlog(int id)
        {
            BlogsEntities1 objEntities = new BlogsEntities1();
            int res = objEntities.DeleteBlog(id);
            return res;
        }


        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}