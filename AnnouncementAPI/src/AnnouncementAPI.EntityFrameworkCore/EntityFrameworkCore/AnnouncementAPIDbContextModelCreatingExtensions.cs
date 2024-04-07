using AnnouncementAPI.Entities;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace AnnouncementAPI.EntityFrameworkCore;

public static class AnnouncementAPIDbContextModelCreatingExtensions
{
    public static void ConfigureAnnouncementAPI(
        this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));

        builder.Entity<Annouchment>(b =>
        {
            b.ToTable("Annouchments", AnnouncementAPIDbProperties.DbSchema);
            b.ConfigureByConvention();
            b.Property(q => q.Title).IsRequired().HasMaxLength(100);
            b.Property(q => q.Content).IsRequired().HasMaxLength(300);
            b.Property(q => q.CreatedDate).HasDefaultValueSql("getdate()");
            b.HasKey(x => x.Id);
            b.Property(b => b.Id).ValueGeneratedOnAdd();
        });
    }
}
