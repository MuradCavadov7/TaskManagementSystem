using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManagementSystem_Core.Entities;

namespace TaskManagementSystem_DAL.Configurations;

public class AssignmentConfiguration : IEntityTypeConfiguration<Assignment>
{
    public void Configure(EntityTypeBuilder<Assignment> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x=>x.Title)
            .IsRequired()
            .HasMaxLength(32);
        builder.Property(x => x.Description)
            .IsRequired()
            .HasMaxLength(128);
        builder.HasOne(x => x.Employee)
            .WithMany(x => x.Assignments)
            .HasForeignKey(x => x.EmployeeId);

        builder.HasOne(x => x.Topic)
            .WithMany(x => x.Assignments)
            .HasForeignKey(x => x.TopicId);

        builder.HasMany(x=>x.Tags)
            .WithMany(x=>x.Assignments)
            .UsingEntity(j => j.ToTable("AssigmentTags"));
    }
}
