using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyBank.Models;

namespace MyBank.Data.Mappings
{
    public class TransfersMap : IEntityTypeConfiguration<Transfers>
    {
        public void Configure(EntityTypeBuilder<Transfers> builder)
        {
            // Table name
            builder.ToTable("Transfers");

            // Primary key
            builder.HasKey(x => x.Id);

            //Identity
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            // Properties
            builder.Property(x => x.SenderId)
                .IsRequired()
                .HasColumnName("SenderId")
                .HasColumnType("INT");

            builder.Property(x => x.ReceiverId)
                .IsRequired()
                .HasColumnName("ReceiverId")
                .HasColumnType("INT");

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
            builder.HasOne(t => t.Sender)
                   .WithMany(c => c.SendedTransfers)
                   .HasForeignKey(t => t.SenderId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(t => t.Receiver)
                   .WithMany(c => c.ReceivedTransfers)
                   .HasForeignKey(t => t.ReceiverId)
                   .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
