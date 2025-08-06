using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyBank.Models;

namespace MyBank.Mappings
{
    public class DepositsMap
    {
        public void Configure(EntityTypeBuilder<Deposits> builder)
        {
            // Table name
            builder.ToTable("Deposits");

            // Primary key
            builder.HasKey(x => x.Id);

            //Identity
            builder.Property(x => x.ClientId)
                .ValueGeneratedOnAdd()
                .IsRequired()
                .UseIdentityColumn();

            // Properties
            

        }
    }
}