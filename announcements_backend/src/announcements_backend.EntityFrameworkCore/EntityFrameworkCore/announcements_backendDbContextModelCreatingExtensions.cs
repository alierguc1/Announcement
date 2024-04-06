using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace announcements_backend.EntityFrameworkCore;

public static class announcements_backendDbContextModelCreatingExtensions
{
    public static void Configureannouncements_backend(
        this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));

        /* Configure all entities here. Example:

        builder.Entity<Question>(b =>
        {
            //Configure table & schema name
            b.ToTable(announcements_backendDbProperties.DbTablePrefix + "Questions", announcements_backendDbProperties.DbSchema);

            b.ConfigureByConvention();

            //Properties
            b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);

            //Relations
            b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

            //Indexes
            b.HasIndex(q => q.CreationTime);
        });
        */
    }
}
