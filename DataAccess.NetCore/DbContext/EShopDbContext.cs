using DataAccess.NetCore.DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.NetCore.DbContext
{
    public class EShopDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public EShopDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder) { base.OnModelCreating(builder); }
        public DbSet<Post>? post { get; set; }
    }
    
}
