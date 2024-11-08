using Dotnet.EFCore.Blog.Crud.Data.Mappings;
using Dotnet.EFCore.Blog.Crud.Models;
using Microsoft.EntityFrameworkCore;

namespace Dotnet.EFCore.Blog.Crud.Data
{
    public class BlogDataContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<PostWithTagsCount> PostWithTagsCount { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=BlogFluentMap;User ID=sa;Password=1q2w3e4r@#$;Trusted_Connection=False; TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new PostMap());

            modelBuilder.Entity<PostWithTagsCount>(x =>
            {
                x.ToSqlQuery(@"
                    SELECT 
                        [Post].[Title], 
                        COUNT([PostTag].[TagId]) AS Count
                    FROM 
                        [Post] WITH (NOLOCK)
                    LEFT JOIN 
                        [PostTag] ON [Post].[Id] = [PostTag].[PostId]
                    GROUP BY 
                        [Post].[Title]");
            });
        }
    }
}
