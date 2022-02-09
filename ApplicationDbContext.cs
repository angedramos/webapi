using Microsoft.EntityFrameworkCore;
using WebApiAngel.Entidades;

namespace WebApiAngel
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        //This means to create a table in SQL with fields of entities (Autor)
        public DbSet<Autor> Autores { get; set; }
    }
}