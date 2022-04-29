using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace LivrariaNoctua.Models
{
    public class ContextoLivros : DbContext
    {
        public ContextoLivros(DbContextOptions<ContextoLivros>options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Livros> Livros { get; set; }

    }
}