using catalogo.Models;
using Microsoft.EntityFrameworkCore;

namespace catalogo.Data
{
    public class BancoContext : DbContext
    {
        public DbSet<ControleCadastro> Cadastros { get; set; }

        public BancoContext(DbContextOptions<BancoContext> options) : base(options){
            
        }
    }
}
