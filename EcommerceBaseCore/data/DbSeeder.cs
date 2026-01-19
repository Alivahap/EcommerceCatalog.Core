using EcommerceBaseCore.Models;
using Microsoft.EntityFrameworkCore;

namespace EcommerceBaseCore.Data
{
    public static class DbSeeder
    {
        public static void Seed(AppDbContext context)
        {
            context.Database.Migrate();

            if (!context.Categories.Any())
            {
                var categories = new List<Category>
                {
                    new Category { Name = "Yenidoğan", Slug = "yenidogan" },
                    new Category { Name = "Kız Çocuk", Slug = "kiz-cocuk" },
                    new Category { Name = "Erkek Çocuk", Slug = "erkek-cocuk" },
                    new Category { Name = "Aksesuar", Slug = "aksesuar" }
                };

                context.Categories.AddRange(categories);
                context.SaveChanges();
            }

            if (!context.Products.Any())
{
    var yenidogan = context.Categories.First(c => c.Slug == "yenidogan");

    var products = new List<Product>
    {
        new Product
        {
            Name = "Pamuklu Bebek Tulumu",
            Slug = "pamuklu-bebek-tulumu",
            Description = "Yumuşak pamuk kumaştan üretilmiş, yenidoğanlar için ideal tulum.",
            ImagePath = "/images/products/tulum1.jpg",
            Price = 249,
            CategoryId = yenidogan.Id,
            IsFeatured = true,
            CreatedAt = DateTime.UtcNow
        },
        new Product
        {
            Name = "Sevimli Bebek Body",
            Slug = "sevimli-bebek-body",
            Description = "Cilt dostu kumaş, rahat kesim.",
            ImagePath = "/images/products/body1.jpg",
            Price = 199,
            CategoryId = yenidogan.Id,
            IsFeatured = true,
            CreatedAt = DateTime.UtcNow
        },
        new Product
        {
            Name = "Kız Çocuk Elbisesi",
            Slug = "kiz-cocuk-elbisesi",
            Description = "Hafif ve rahat, günlük kullanım için ideal.",
            ImagePath = "/images/products/elbise1.jpg",
            Price = 349,
            CategoryId = yenidogan.Id,
            IsFeatured = true,
            CreatedAt = DateTime.UtcNow
        },
        new Product
        {
            Name = "Erkek Çocuk Takımı",
            Slug = "erkek-cocuk-takimi",
            Description = "Pamuklu kumaş, rahat kesim.",
            ImagePath = "/images/products/takim1.jpg",
            Price = 399,
            CategoryId = yenidogan.Id,
            IsFeatured = true,
            CreatedAt = DateTime.UtcNow
        }
    };

    context.Products.AddRange(products);
    context.SaveChanges();
}


            if (!context.BlogPosts.Any())
            {
                var posts = new List<BlogPost>
                {
                    new BlogPost
                    {
                        Title = "Bebekler için pamuklu kıyafet seçimi",
                        Slug = "bebekler-icin-pamuklu-kiyafet-secimi",
                        Content = "Bebek cildi çok hassastır. Pamuklu kumaşlar en doğru tercihtir...",
                        CoverImage = "/images/blog/blog1.jpg",
                        PublishedAt = DateTime.UtcNow.AddDays(-5),
                        IsPublished = true
                    }
                };

                context.BlogPosts.AddRange(posts);
                context.SaveChanges();
            }

            if (!context.Faqs.Any())
            {
                var faqs = new List<Faq>
                {
                    new Faq
                    {
                        Question = "Ürünleriniz %100 pamuk mu?",
                        Answer = "Evet, tüm ürünlerimiz doğal pamuk kumaştan üretilmektedir.",
                        Order = 1
                    },
                    new Faq
                    {
                        Question = "Kaç günde kargoya verilir?",
                        Answer = "Siparişleriniz 1-3 iş günü içinde kargoya verilir.",
                        Order = 2
                    }
                };

                context.Faqs.AddRange(faqs);
                context.SaveChanges();
            }
        }
    }
}
