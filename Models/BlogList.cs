using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogApp.Models
{
    public class BlogList
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string BlogImage { get; set; }
        public string BlogVideo { get; set; }
        public string BlogContent { get; set; }
        public DateTime? Published_Date { get; set; }
        public bool Status { get; set; }
        public DateTime Creation_Date { get; set; }

    }
}