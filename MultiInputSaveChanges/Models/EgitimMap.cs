using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MultiInputSaveChanges.Models
{
    public class EgitimMap : IEntityTypeConfiguration<Egitim>
    {
        public void Configure(EntityTypeBuilder<Egitim> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.EgitimAdi).IsRequired();

            builder.ToTable("Egitims");
        }
    }
}
