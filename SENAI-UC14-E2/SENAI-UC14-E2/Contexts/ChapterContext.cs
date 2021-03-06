using Microsoft.EntityFrameworkCore;
using SENAI_UC14_E2.Models;

namespace SENAI_UC14_E2.Contexts
{
    public class ChapterContext : DbContext
    {
        public ChapterContext() { }

        public ChapterContext(DbContextOptions<ChapterContext> options) : base(options) { }

        protected override void
        OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Data Source=DESKTOP-Q4INLOT\\SQLEXPRESS;" +
                    "initial catalog=Chapter;" +
                    "Integrated Security=False;" +
                    "User ID=sa;Password=server"
                    );
            }
        }

        public DbSet<Livro> Livros { get; set; }
    }
}
