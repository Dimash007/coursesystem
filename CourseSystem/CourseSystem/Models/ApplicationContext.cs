using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseSystem.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Direction> Directions { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            string adminRoleName = "admin";
            string userRoleName = "user";
            string teacherRoleName = "teacher";

            string adminEmail = "admin@mail.ru";
            string adminPassword = "123456";
            string adminName = "Admin";
            string adminSurname = "Admin";
            string adminPhone = "87011111111";

            // добавляем роли
            Role adminRole = new Role { Id = 1, Name = adminRoleName };
            Role userRole = new Role { Id = 2, Name = userRoleName };
            Role teacherRole = new Role { Id = 3, Name = teacherRoleName };
            User adminUser = new User { Id = 1, Name= adminName, Surname = adminSurname, Phone= adminPhone, Email = adminEmail, Password = adminPassword, RoleId = adminRole.Id };

            modelBuilder.Entity<Role>().HasData(new Role[] { adminRole, userRole, teacherRole });
            modelBuilder.Entity<User>().HasData(new User[] { adminUser });
            base.OnModelCreating(modelBuilder);
        }
    }
}
