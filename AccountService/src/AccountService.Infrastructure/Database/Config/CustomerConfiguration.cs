using AccountService.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountService.Infrastructure.Database.Config
{
    internal class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(k => k.Id);
            builder.HasIndex(k => k.CustomerID).IsUnique();
            builder.Property(k => k.CustomerID).HasMaxLength(10).IsRequired();
            builder.Property(k => k.FirstName).HasMaxLength(50).IsRequired();
            builder.Property(k => k.LastName).HasMaxLength(50).IsRequired();
            builder.Property(k => k.Dob).HasMaxLength(20).IsRequired();
            builder.Property(k => k.State).HasMaxLength(20).IsRequired();
            builder.Property(k => k.Country).HasMaxLength(20).IsRequired();
            builder.Property(k => k.Address).HasMaxLength(500).IsRequired();
            builder.Property(k => k.Email).HasMaxLength(50).IsRequired();
            builder.Property(k => k.PhoneNumber).HasMaxLength(20).IsRequired();
        }
    }
}
