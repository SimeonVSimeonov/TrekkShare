﻿namespace TrekkShare.Data.EntityConfiguration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Models;

    public class LakeConfig : IEntityTypeConfiguration<Lake>
    {
        public void Configure(EntityTypeBuilder<Lake> builder)
        {
            builder.HasKey(l => l.LakeId);

            builder
                .Property(l => l.Name)
                .IsUnicode()
                .IsRequired()
                .HasMaxLength(80);

            builder
                .HasOne(l => l.Mountain)
                .WithMany(m => m.Lakes)
                .HasForeignKey(l => l.MountainId);

            //TODO: Add relation to GeoLocation
        }
    }
}
