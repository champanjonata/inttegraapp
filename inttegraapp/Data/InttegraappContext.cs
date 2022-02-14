using inttegraapp.Models;
using Microsoft.EntityFrameworkCore;

namespace inttegraapp.Data
{
    public class InttegraappContext : DbContext
    {
        public InttegraappContext (DbContextOptions<InttegraappContext> options) 
            : base(options)
        {

        }

        public DbSet<Contato> Contatos { get; set; }

        public DbSet<Emprestimo> Emprestimo { get; set; }
    }
}
