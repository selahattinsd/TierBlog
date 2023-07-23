
namespace TierBlog_Data
{
    using Microsoft.EntityFrameworkCore;
    using TierBlog_Model;

    public class DataContext : DbContext
    {
        public DataContext(string connectionString) : base(new DbContextOptionsBuilder().UseSqlServer(connectionString).Options) 
        {
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<ContentCategory> ContentCategories { get; set; }
        public DbSet<ContentTag> ContentTags { get; set; }
        public DbSet<Media> Medias { get; set; }
        public DbSet<Tags> Tags { get; set; }
        public DbSet<Setting> Setting { get; set; }
    }
}
