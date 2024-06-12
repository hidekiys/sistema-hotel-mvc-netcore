using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sistema_Hotel.Models;

namespace Sistema_Hotel.Data.Map
{
    public class QuartoMap : IEntityTypeConfiguration<QuartoModel>
    {
        public void Configure(EntityTypeBuilder<QuartoModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.ObjHospede);
        }

    }
}
