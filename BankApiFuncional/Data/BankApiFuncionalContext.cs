using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BankApiFuncional.Models;

namespace BankApiFuncional.Data
{
    public class BankApiFuncionalContext : DbContext
    {
        public BankApiFuncionalContext (DbContextOptions<BankApiFuncionalContext> options)
            : base(options)
        {
        }

        public DbSet<BankApiFuncional.Models.Address> Address { get; set; }

        public DbSet<BankApiFuncional.Models.Client> Client { get; set; }

        public DbSet<BankApiFuncional.Models.BankAccount> BankAccount { get; set; }
    }
}
