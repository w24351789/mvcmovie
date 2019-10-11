using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Data
{
    public class MvcPhoneContext : DbContext
    {
        public MvcPhoneContext (DbContextOptions<MvcPhoneContext> options)
            :base(options)
        {

        }

        public DbSet<Phone> Phone { get; set; }
    }
}
