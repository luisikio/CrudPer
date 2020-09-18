using CrudPer.Models.Maps;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudPer.Models
{
    public class PersonaContext: DbContext
    {
        
        public DbSet<account> Accounts { get; set; }
        public PersonaContext(DbContextOptions<PersonaContext>options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration (new AccountMap());
        }
    }
}
