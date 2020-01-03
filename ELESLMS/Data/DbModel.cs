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
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbModel() : base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(connectionString);
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasOne<Role>(r => r.Role).WithMany(u => u.Users).HasForeignKey(f => f.RoleId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<User>().Property(d => d.CreatedTime).ValueGeneratedOnAdd();
            modelBuilder.Entity<User>().HasDiscriminator<int>("RoleId").HasValue<User>(1).HasValue<Student>(2).HasValue<Teacher>(3); 
            modelBuilder.Entity<Student>().HasBaseType<User>();
            modelBuilder.Entity<Teacher>().HasBaseType<User>(); 
            modelBuilder.Entity<StudentCourse>().HasAlternateKey(sc => new { sc.StudentId, sc.CourseId });
            modelBuilder.Entity<StudentCourse>().HasOne<Student>(sc => sc.Student).WithMany(s => s.StudentCourses).HasForeignKey(sc => sc.StudentId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<StudentCourse>().HasOne<Course>(sc => sc.Course).WithMany(s => s.StudentCourses).HasForeignKey(sc => sc.CourseId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Course>().HasOne<Teacher>(t => t.Teacher).WithMany(c => c.Courses).HasForeignKey(f => f.TeacherId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Grade>().HasOne<Assignment>(a => a.Assignment).WithMany(g => g.Grades).HasForeignKey(f => f.AssignmentId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Grade>().HasOne<StudentCourse>(c => c.StudentCourse).WithMany(g => g.Grades).HasForeignKey(f => f.StudentCourseId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Assignment>().HasOne<Course>(c => c.Course).WithMany(a => a.Assignments).HasForeignKey(f => f.CourseId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Role>().HasData(
                new Role
                {
                    Id = 1,
                    Name = "Admin"
                },
                new Role
                {
                    Id = 2,
                    Name = "Student"
                },
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
                    Id = 2,
                    Name = "Dervişhan",
                    Surname = "Sezer",
                    UserName = "Yarali89",
                    Password = new Service.UserService().hashPassword("Yarali89"),
                    EMail = "yarali89@gmail.com",
                    CreatedTime = DateTime.Now,
                    RoleId = 2,
                    Number = "321"
                },
                new Student()
                {
                    Id = 4,
                    Name = "David",
                    Surname = "Bechkham",
                    UserName = "Yakisikli1",
                    Password = new Service.UserService().hashPassword("Yakisikli1"),
                    EMail = "yakisikli1@gmail.com",
                    CreatedTime = DateTime.Now,
                    RoleId = 2,
                    Number = "123"
                },
                new Student()
                {
                    Id = 6,
                    Name = "Cristiano",
                    Surname = "Ronaldı",
                    UserName = "Tsubasa333",
                    Password = new Service.UserService().hashPassword("Tsubasa333"),
                    EMail = "tsubasa333@gmail.com",
                    CreatedTime = DateTime.Now,
                    RoleId = 2,
                    Number = "333"
                },
                new Student()
                {
                    Id = 7,
                    Name = "Okuttum",
                    Surname = "Bro",
                    UserName = "whaat2",
                    Password = new Service.UserService().hashPassword("whaat2"),
                    EMail = "whaat2@gmail.com",
                    CreatedTime = DateTime.Now,
                    RoleId = 2,
                    Number = "222"
                },
                new Student()
                {
                    Id = 8,
                    Name = "Yeter",
                    Surname = "Bukadar",
                    UserName = "elveda26",
                    Password = new Service.UserService().hashPassword("elveda26"),
                    EMail = "elveda26@gmail.com",
                    CreatedTime = DateTime.Now,
                    RoleId = 2,
                    Number = "262"
                }
            );
            modelBuilder.Entity<Teacher>().HasData(
                new Teacher()
                {
                    Id = 3,
                    Name = "Hüseyin",
                    Surname = "Şimşek",
                    UserName = "HocalarınHocası",
                    Password = new Service.UserService().hashPassword("HocalarınHocası"),
                    EMail = "huseyinsimsek@gmail.com",
                    CreatedTime = DateTime.Now,
                    RoleId = 3,
                    Subject = "Programming"
                },
                new Teacher()
                {
                    Id = 9,
                    Name = "Hamdi",
                    Surname = "Erkunt",
                    UserName = "Kral",
                    Password = new Service.UserService().hashPassword("Kral"),
                    EMail = "hamdierkunt@gmail.com",
                    CreatedTime = DateTime.Now,
                    RoleId = 3,
                    Subject = "Algorythm"
                }
            );
            modelBuilder.Entity<Course>().HasData(
                new Course()
                {
                    Id = 1,
                    Name = "cet 301",
                    Description = "efso ders",
                    OpeningDate = DateTime.Now,
                    TeacherId = 3
                },
                new Course()
                {
                    Id = 6,
                    Name = "cet 322",
                    Description = "efso dersin ikincisi",
                    OpeningDate = DateTime.Now,
                    TeacherId = 3
                },
                new Course()
                {
                    Id = 7,
                    Name = "cet 314",
                    Description = "muttesem ders",
                    OpeningDate = DateTime.Now,
                    TeacherId = 9
                }
            );
        }
    }
}
