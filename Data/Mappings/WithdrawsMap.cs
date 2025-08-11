using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyBank.Models;

namespace MyBank.Data.Mappings
{
    public class WithdrawsMap : IEntityTypeConfiguration<Withdraws>
    {
        public void Configure(EntityTypeBuilder<Withdraws> builder)
        {
            // Table name
            builder.ToTable("Withdraws");

            // Primary key
            builder.HasKey(x => x.Id);

            //Identity
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            // Properties
            builder.Property(x => x.Amount)
                .IsRequired()
                .HasColumnName("Amount")
                .HasColumnType("DECIMAL")
                .HasPrecision(18, 2);

            builder.Property(x => x.TransactionDate)
                .IsRequired()
                .HasColumnName("TransactionDate")
                .HasColumnType("DATETIME")
                .HasDefaultValueSql("GETDATE()");

            // Relationships
            builder.HasOne(x => x.Client)
                .WithMany(c => c.Withdraws)
                .HasForeignKey(x => x.ClientId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
