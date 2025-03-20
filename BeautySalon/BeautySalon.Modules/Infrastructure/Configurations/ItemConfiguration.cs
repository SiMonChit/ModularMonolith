using BeautySalon.Modules.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace BeautySalon.Modules.Infrastructure.Configurations
{
    public class ItemConfiguration : IEntityTypeConfiguration<Items>
    {
        public void Configure(EntityTypeBuilder<Items> builder)
        {
            builder.ToTable("Tbl_Items");

            builder.HasKey(i => i.ItemId);

            builder.Property(i => i.ItemCode)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(i => i.ItemName)
                   .IsRequired()
                   .HasMaxLength(255);

            builder.Property(i => i.SellPrice)
                   .IsRequired();

            // Optional fields
            builder.Property(i => i.Qty);
            builder.Property(i => i.PurchasePrice);
            builder.Property(i => i.IsInventory);
            builder.Property(i => i.IsActive);
            builder.Property(i => i.ShopId);
        }
    }

}
