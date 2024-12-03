using Microsoft.EntityFrameworkCore;
using UserManager.Models;

namespace UserManager.DataAccess
{
    public class DatabaseContext : DbContext
    {
            public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }
            
            // DbSet для каждой модели
            public DbSet<User> Users { get; set; }
            public DbSet<UserProfile> UserProfiles { get; set; }
            public DbSet<HostingPlan> HostingPlans { get; set; }
            public DbSet<Role> Roles { get; set; }
            public DbSet<Subscription> Subscriptions { get; set; }
            public DbSet<Permission> Permissions { get; set; }
            public DbSet<ActivityLog> ActivityLogs { get; set; }
            public DbSet<Record> Records { get; set; }

            // Настрйока моделей
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                // Конфигурация для User
                modelBuilder.Entity<User>(entity =>
                {
                   entity.HasKey(u => u.UserId);
                   entity.HasMany(u => u.Subscriptions)
                       .WithOne(s => s.User)
                       .HasForeignKey(s => s.UserId)
                       .OnDelete(DeleteBehavior.Cascade);
                });
                
                // Конфигурация для UserProfile
                modelBuilder.Entity<UserProfile>(entity =>
                {
                    entity.HasKey(up => up.UserProfileId);
                    entity.HasOne(up => up.User)
                        .WithOne(u => u.UserProfile)
                        .HasForeignKey<UserProfile>(up => up.UserId)
                        .OnDelete(DeleteBehavior.Cascade);

                });
                
                // Конфигурация для HostingPlan
                modelBuilder.Entity<HostingPlan>(entity =>
                {
                    entity.HasKey(hp => hp.PlanId);
                });
                
                // Конфигурация для Subscription
                modelBuilder.Entity<Subscription>(entity =>
                {
                    entity.HasKey(s => s.SubscriptionId);
                    entity.HasOne(s => s.User)
                        .WithMany(u => u.Subscriptions)
                        .HasForeignKey(s => s.UserId)
                        .OnDelete(DeleteBehavior.Cascade);
                    entity.HasOne(s => s.HostingPlan)
                        .WithMany(hp => hp.Subscriptions)
                        .HasForeignKey(s => s.HostingPlanId);
                });
                
                // Конфигурация для Role
                modelBuilder.Entity<Role>(entity =>
                {
                    entity.HasMany(r => r.Permissions)
                        .WithMany(p => p.Roles)
                        .UsingEntity<Dictionary<string, object>>(
                            "RolePermission",
                            rp => rp.HasOne<Permission>().WithMany().HasForeignKey("PermissionId"),
                            rp => rp.HasOne<Role>().WithMany().HasForeignKey("RoleId"));
                });
                
                // Конфигурация для Permission
                modelBuilder.Entity<Permission>(entity =>
                {
                    entity.HasKey(p => p.PermissionId);
                });
                
                // ActivityLog для ActivityLog
                modelBuilder.Entity<ActivityLog>(entity =>
                {
                    entity.HasKey(al => al.LogId);
                    entity.HasOne(al => al.User)
                        .WithMany(u => u.ActivityLogs)
                        .HasForeignKey(al => al.UserId)
                        .OnDelete(DeleteBehavior.Cascade);
                });
                
                // Кофигурация для Record
                modelBuilder.Entity<Record>(entity =>
                {
                    entity.HasKey(r => r.RecordId);
                    entity.HasOne(r => r.User)
                        .WithMany(u => u.Records)
                        .HasForeignKey(r => r.UserId)
                        .OnDelete(DeleteBehavior.Cascade);
                });
                
                base.OnModelCreating(modelBuilder);
            }
        
    }
}