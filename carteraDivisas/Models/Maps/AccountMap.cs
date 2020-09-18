using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudPer.Models.Maps
{
    public class AccountMap : IEntityTypeConfiguration<account>
    {
        public void Configure(EntityTypeBuilder<account> builder)
        {
            builder.ToTable("Account");
            builder.HasKey(o => o.Id);
        }
    }
}
