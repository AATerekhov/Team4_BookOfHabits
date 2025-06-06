﻿using BookOfHabitsMicroservice.Domain.Entity.Propertys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookOfHabitsMicroservice.Infrastructure.EntityFramework.Configurations
{
    public class TimeResetIntervalConfiguration : IEntityTypeConfiguration<TimeResetInterval>
    {
        public void Configure(EntityTypeBuilder<TimeResetInterval> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.NameType).HasMaxLength(50);
        }
    }
}
