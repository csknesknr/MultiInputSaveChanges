using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MultiInputSaveChanges.Models
{
    public class GrupMap : IEntityTypeConfiguration<Grup>
    {
        public void Configure(EntityTypeBuilder<Grup> builder)
        {
            builder.HasKey(g => g.Id);
            builder.Property(g => g.Id).ValueGeneratedOnAdd();
            builder.Property(g => g.Adet).IsRequired();
            builder.Property(g => g.Sayi).IsRequired();
            builder.Property(g => g.Tarih).IsRequired();

           // builder.HasOne<Egitim>(g => g.Egitim).WithMany(e => e.Grups).HasForeignKey(g => g.EgitimId);

            builder.ToTable("Grups");
        }
    }
}
