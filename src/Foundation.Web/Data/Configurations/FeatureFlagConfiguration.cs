using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Foundation.Web.Data
{
    public class FeatureFlagConfiguration : IEntityTypeConfiguration<FeatureFlag>
    {
        //TODO - Adicionar configuração das propriedades
        public void Configure(EntityTypeBuilder<FeatureFlag> builder)
        {
            builder.ToTable("FeatureFlags");
            builder.HasKey(x => x.Name);
            builder.Property(x => x.Name).HasMaxLength(100);
            builder.Property(x => x.Enabled).IsRequired();
        }
    }
}