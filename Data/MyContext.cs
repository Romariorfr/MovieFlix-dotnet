using Microsoft.EntityFrameworkCore;
using MovieFlix.Models;

namespace MovieFlix_dotnet.Data
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var movie = modelBuilder.Entity<Movie>();

            movie.HasKey(x => x.Id);
            movie.ToTable("tb_movie");

            movie.Property(x => x.Id)
                .HasColumnName("id")
                .ValueGeneratedOnAdd();

            movie.Property(x => x.Title)
                .HasColumnName("title")
                .IsRequired();

            movie.Property(x => x.SubTitle)
                .HasColumnName("subTitle")
                .IsRequired();

            movie.Property(x => x.Year)
                .HasColumnName("year");

            movie.Property(x => x.ImgUrl)
                .HasColumnName("imgUrl");

            movie.Property(x => x.Synopsis)
                .HasColumnName("synopsis");


            movie.HasOne(x => x.Genre)
                .WithMany(x => x.Movies)
                .HasForeignKey(x => x.GenreId)
                .HasPrincipalKey(x => x.Id)
                .OnDelete(DeleteBehavior.Restrict);
        }

    }
}
