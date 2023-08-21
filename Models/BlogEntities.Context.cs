﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlogApp.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class BlogsEntities1 : DbContext
    {
        public BlogsEntities1()
            : base("name=BlogsEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblAuthor> tblAuthors { get; set; }
        public virtual DbSet<tblBlog> tblBlogs { get; set; }
    
        public virtual int Blogs_CreateUpdate(Nullable<int> id, string title, Nullable<int> author, string blogContent, Nullable<bool> status, string blogImage, string blogVideo)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var titleParameter = title != null ?
                new ObjectParameter("Title", title) :
                new ObjectParameter("Title", typeof(string));
    
            var authorParameter = author.HasValue ?
                new ObjectParameter("Author", author) :
                new ObjectParameter("Author", typeof(int));
    
            var blogContentParameter = blogContent != null ?
                new ObjectParameter("BlogContent", blogContent) :
                new ObjectParameter("BlogContent", typeof(string));
    
            var statusParameter = status.HasValue ?
                new ObjectParameter("Status", status) :
                new ObjectParameter("Status", typeof(bool));
    
            var blogImageParameter = blogImage != null ?
                new ObjectParameter("BlogImage", blogImage) :
                new ObjectParameter("BlogImage", typeof(string));
    
            var blogVideoParameter = blogVideo != null ?
                new ObjectParameter("BlogVideo", blogVideo) :
                new ObjectParameter("BlogVideo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Blogs_CreateUpdate", idParameter, titleParameter, authorParameter, blogContentParameter, statusParameter, blogImageParameter, blogVideoParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> LoginUser(string username, string password)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("Username", username) :
                new ObjectParameter("Username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("LoginUser", usernameParameter, passwordParameter);
        }
    
        public virtual ObjectResult<ViewBlogs_Result> ViewBlogs()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ViewBlogs_Result>("ViewBlogs");
        }
    
        public virtual ObjectResult<ViewBlogDetail_Result> ViewBlogDetail(Nullable<int> blogId)
        {
            var blogIdParameter = blogId.HasValue ?
                new ObjectParameter("BlogId", blogId) :
                new ObjectParameter("BlogId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ViewBlogDetail_Result>("ViewBlogDetail", blogIdParameter);
        }
    
        public virtual ObjectResult<MyBlogs_Result> MyBlogs(Nullable<int> author)
        {
            var authorParameter = author.HasValue ?
                new ObjectParameter("Author", author) :
                new ObjectParameter("Author", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<MyBlogs_Result>("MyBlogs", authorParameter);
        }
    
        public virtual int DeleteBlog(Nullable<int> blogId)
        {
            var blogIdParameter = blogId.HasValue ?
                new ObjectParameter("BlogId", blogId) :
                new ObjectParameter("BlogId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteBlog", blogIdParameter);
        }
    }
}
