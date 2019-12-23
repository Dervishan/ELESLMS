using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ELESLMS.Data
{
    public class DbModel : DbContext
    {
        string connectionString = @"Server=.;Database=ELESLMS;Trusted_Connection=True;";
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        public DbModel() : base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(connectionString);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasOne<Role>(r => r.Role).WithMany(u => u.Users).HasForeignKey(f => f.RoleId);
            modelBuilder.Entity<StudentCourse>().HasKey(sc => new { sc.StudentId, sc.CourseId });
            modelBuilder.Entity<StudentCourse>().HasOne<Student>(sc => sc.Student).WithMany(s => s.StudentCourses).HasForeignKey(sc => sc.StudentId);
            modelBuilder.Entity<StudentCourse>().HasOne<Course>(sc => sc.Course).WithMany(s => s.StudentCourses).HasForeignKey(sc => sc.CourseId);
            modelBuilder.Entity<Course>().HasOne<Teacher>(t => t.Teacher).WithMany(c => c.Courses).HasForeignKey(f => f.TeacherId);
            modelBuilder.Entity<Role>().HasData(
                new Role
                {
                    Id = 1,
                    Name = "Admin",
                    ca
                }
            );
            modelBuilder.Entity<Role>().HasData(
                new Role
                {
                    Id = 2,
                    Name = "Student"
                }
            );
            modelBuilder.Entity<Role>().HasData(
                new Role
                {
                    Id = 3,
                    Name = "Teacher"
                }
            );
            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    Id = 1,
                    Name = "First",
                    Surname = "User",
                    UserName = "admin",
                    Password = new Service.UserService().hashPassword("admin"),
                    EMail = "admin@admin.com",
                    CreatedTime = DateTime.Now,
                    RoleId = 1,
                }
            );
            modelBuilder.Entity<Student>().HasData(
                new Student()
                {
                    Id = 1,
                    Name = "Dervişhan",
                    Surname = "Sezer",
                    UserName = "Yarali89",
                    Password = new Service.UserService().hashPassword("Yarali89"),
                    EMail = "yarali89@gmail.com",
                    CreatedTime = DateTime.Now,
                    RoleId = 2,
                    Number = 321
                }
            );
            modelBuilder.Entity<Teacher>().HasData(
                new Teacher()
                {
                    Id = 1,
                    Name = "Hüseyin",
                    Surname = "Şimşek",
                    UserName = "HocalarınHocası",
                    Password = new Service.UserService().hashPassword("reyis"),
                    EMail = "huseyinsimsek@gmail.com",
                    CreatedTime = DateTime.Now,
                    RoleId = 3
                }
            );
        }
    }
}
