using contactapp.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace contactapp.Data
{
    public class ContactAppDbContext : DbContext
    {
        public ContactAppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
