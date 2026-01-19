using System;

namespace EcommerceBaseCore.Models
{
    public class BlogPost
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Slug { get; set; }

        public string Content { get; set; }
        public string CoverImage { get; set; }

        public DateTime PublishedAt { get; set; }
        public bool IsPublished { get; set; }
    }
}
