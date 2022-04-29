using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace LivrariaNoctua.Models
{
    public class ContextoUsuario : DbContext
    {
        public ContextoUsuario(DbContextOptions<ContextoUsuario> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Usuario> Usuario { get; set; }

    }

}
