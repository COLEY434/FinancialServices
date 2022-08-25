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
    internal class AccountServiceConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.HasKey(k => k.Id);
            builder.HasIndex(k => k.AccountNo).IsUnique();
            builder.Property(k => k.AccountNo).HasMaxLength(10).IsRequired();
            builder.Property(k => k.AccountType).HasMaxLength(1).IsRequired();
            builder.Property(k => k.CustomerID).HasMaxLength(10).IsRequired();
            builder.Property(k => k.CreatedAt).IsRequired();
            builder.Property(k => k.AvaliableBalance).IsRequired();
            builder.HasOne(k => k.AccountOwner)
                   .WithMany(x => x.Accounts)
                   .HasForeignKey(k => k.CustomerID)
                   .HasPrincipalKey(x => x.CustomerID);
        }
    }
}
