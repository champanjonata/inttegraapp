using Microsoft.EntityFrameworkCore;

namespace inttegraapp.Data
{
    public class InttegraappContext : DbContext
    {
        public InttegraappContext (DbContextOptions<InttegraappContext> options) 
            : base(options)
        {

        }
    }
}
