using DbLayer.Entities.Custom;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DbLayer
{
    public class EducationPlatformDbContext : DbContext
    {
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<FileInstance> Files { get; set; }
        public DbSet<Folder> Folders { get; set; }
        public DbSet<Mark> Marks { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Response> Responses { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RoleInRoom> RolesInRoom { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomUser> RoomUsers { get; set; }
        public DbSet<Suggestion> Suggestions { get; set; }
        public DbSet<User> Users { get; set; }

        public EducationPlatformDbContext(DbContextOptions<EducationPlatformDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region (Adding of a composite key to RoomUser entity and) ??? configuring many-to-many relationship between entities Room and User

            //modelBuilder.Entity<RoomUser>()
            //    .HasKey(rm => new { rm.RoomId, rm.UserId });

            modelBuilder.Entity<RoomUser>()
                .HasOne(rm => rm.Room)
                .WithMany(us => us.RoomUsers)
                .HasForeignKey(rm => rm.RoomId);

            modelBuilder.Entity<RoomUser>()
                .HasOne(rm => rm.User)
                .WithMany(us => us.RoomUsers)
                .HasForeignKey(pt => pt.UserId);

            #endregion

        }

    }
}
