using Microsoft.EntityFrameworkCore;
using EcommerceBaseCore.Models;

namespace EcommerceBaseCore.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Faq> Faqs { get; set; }
        public DbSet<ContactMessage> ContactMessages { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
    }
}
