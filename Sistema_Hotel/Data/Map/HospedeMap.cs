using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sistema_Hotel.Models;

namespace Sistema_Hotel.Data.Map
{
    public class HospedeMap : IEntityTypeConfiguration<HospedeModel>
    {
        public void Configure(EntityTypeBuilder<HospedeModel> builder) => builder.Property(p => p.CPF)
            .HasColumnType("bigint")
            .IsRequired()
            .ValueGeneratedNever();

    }
}
