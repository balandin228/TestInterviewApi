using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestInterviewApi.Domain.PhoneNumber;

namespace TestInterviewApi.Infrastructure.Configurations
{
    public class PhoneNumberTypeConfiguration : IEntityTypeConfiguration<PhoneNumber>
    {
        public void Configure(EntityTypeBuilder<PhoneNumber> builder)
        {
            builder.ToTable("PhoneNumbers");
            builder.HasKey(x => x.Key);
            builder.Property(x => x.Key).HasColumnName("Id");
            builder.HasAlternateKey(x => new { x.Number, x.UserId });
        }
    }
}
