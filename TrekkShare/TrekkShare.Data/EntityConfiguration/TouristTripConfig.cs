﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrekkShare.Models;

namespace TrekkShare.Data.EntityConfiguration
{
    public class TouristTripConfig : IEntityTypeConfiguration<TouristTrip>
    {
        public void Configure(EntityTypeBuilder<TouristTrip> builder)
        {
            builder.HasKey(x => new { x.TouristId, x.TripId });

            builder.HasOne(x => x.Tourist)
                .WithMany(x => x.TouristTrips)
                .HasForeignKey(x => x.TouristId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Trip)
                .WithMany(x => x.TouristTrips)
                .HasForeignKey(x => x.TripId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
