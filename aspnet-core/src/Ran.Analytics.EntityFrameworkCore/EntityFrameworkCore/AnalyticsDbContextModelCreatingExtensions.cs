using System;
using Microsoft.EntityFrameworkCore;
using Ran.Analytics.Visitors;
using Volo.Abp;

namespace Ran.Analytics.EntityFrameworkCore
{
    public static class AnalyticsDbContextModelCreatingExtensions
    {
        public static void ConfigureAnalytics(
            this ModelBuilder builder,
            Action<AnalyticsModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new AnalyticsModelBuilderConfigurationOptions(
                AnalyticsDbProperties.DbTablePrefix,
                AnalyticsDbProperties.DbSchema
            );

            optionsAction?.Invoke(options);

            /* Configure all entities here. Example:

            builder.Entity<Question>(b =>
            {
                //Configure table & schema name
                b.ToTable(options.TablePrefix + "Questions", options.Schema);
            
                b.ConfigureFullAuditedAggregateRoot();
            
                //Properties
                b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);
                
                //Relations
                b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

                //Indexes
                b.HasIndex(q => q.CreationTime);
            });
            */
            builder.Entity<Visitors.Visitor>(b =>
            {
                //Configure table & schema name
                b.ToTable(options.TablePrefix + "Visitors", options.Schema);

                //Properties
                b.Property(q => q.ClientIpAddress).IsRequired().HasColumnType("varchar(15)");
                b.Property(q => q.OnTime).IsRequired().HasColumnType("datetime");
                b.Property(q => q.Referrer).HasMaxLength(VisitorConsts.MaxReferrerLength);
                b.Property(q => q.ProviderName).IsRequired().HasMaxLength(VisitorConsts.MaxProviderNameLength);
                b.Property(q => q.ProviderKey).IsRequired();


                //Indexes
                b.HasIndex(q => new { q.ProviderName, q.ProviderKey,q.OnTime });
            });
        }
    }
}