using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyBank.Models;

namespace MyBank.Data.Mappings
{
    public class ClientMap : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            // Table name
            builder.ToTable("Client");

            // Primary key
            builder.HasKey(x => x.Id);

            //Identity
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .IsRequired()
                .UseIdentityColumn();

            // Properties
            builder.Property(x => x.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(100);

            builder.Property(x => x.Email)
                .IsRequired()
                .HasColumnName("Email")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(100);

            builder.Property(x => x.CPF)
                .IsRequired()
                .HasColumnName("CPF")
                .HasColumnType("INT")
                .HasMaxLength(11);

            builder.Property(x => x.Password)
                .IsRequired()
                .HasColumnName("Password")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(100);

            builder.Property(x => x.Funds)
                .IsRequired()
                .HasColumnName("Funds")
                .HasColumnType("DECIMAL")
                .HasPrecision(18, 2);

        }
    }
}
