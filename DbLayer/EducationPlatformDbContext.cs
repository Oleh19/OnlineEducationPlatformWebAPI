using DbLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DbLayer
{
    public class EducationPlatformDbContext : DbContext
    {
        public DbSet<Room> Rooms { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<RoomUser> RoomUsers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Adding of a composite key to RoomUser entity

            modelBuilder.Entity<RoomUser>()
                .HasKey(rm => new { rm.RoomId, rm.UserId });

            #endregion

            #region

            #endregion

        }
    }
}
