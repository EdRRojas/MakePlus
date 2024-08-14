

using MakePlus.Core;
using MakePlus.Domain.Entities;
using MakePlus.Entities;
using Microsoft.EntityFrameworkCore;

namespace MakePlus.Infraestructure.Context
{
    public class MakePlusContext : DbContext
    {
        public MakePlusContext(DbContextOptions<MakePlusContext> options) : base(options) { }
        public DbSet<BaseEntity> info { get; set; }
        public DbSet<Custumers> custumers { get; set; }
        public DbSet<Sellers> sellers { get; set; }
        public DbSet<Products> products { get; set; }
        public DbSet<ProductCustumer> productCustumers { get; set;}
    }
}
