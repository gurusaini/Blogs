//------------------------------------------------------------------------------
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
    
    public partial class MyBlogs_Result
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Author { get; set; }
        public string BlogContent { get; set; }
        public bool Status { get; set; }
        public string BlogImage { get; set; }
        public string BlogVideo { get; set; }
        public Nullable<System.DateTime> Published_Date { get; set; }
        public System.DateTime Creation_Date { get; set; }
    }
}
