using Microsoft.EntityFrameworkCore;
using mvcActividad_1.Models;

namespace mvcActividad_1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        //Aqui todos los modelos que se creen 
        public DbSet<Producto> Producto { get; set; }
    }
}
