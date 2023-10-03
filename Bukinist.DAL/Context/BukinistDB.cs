using Bukinist.DAL.Entityes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bukinist.DAL.Context
{
    public class BukinistDB : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Buyer> Buyers { get; set; }
        public DbSet<Deal> Deals { get; set; }
        public BukinistDB(DbContextOptions<BukinistDB> options) : base(options) { }

    }
}
