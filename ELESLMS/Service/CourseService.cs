using ELESLMS.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Windows;
using Microsoft.EntityFrameworkCore;

namespace ELESLMS.Service
{
    public class CourseService
    {
        private DbModel db;
        public CourseService()
        {
            db = new DbModel();
        }
        public void CreateCourse(string name,string description,User user)
        {
            if (!CourseExists(name))
            {
                db.Courses.Add(new Course()
                {
                    Name = name,
                    Description = description,
                    OpeningDate = DateTime.Now,
                    TeacherId = user.Id
                });
                db.SaveChanges();
            }
            else
            {
                MessageBox.Show("This course is already created");
            }
        }
        public void JoinCourse(User user, Course course)
        {
            var c = db.Courses.Find(course.Id);
            if (c!=null)
            {
                db.StudentCourses.Add(new StudentCourse()
                {
                    EnrollmentDate = DateTime.Now,
                    StudentId=user.Id,
                    CourseId=course.Id
                });
                db.SaveChanges();
            }
        }
        public List<Course> courses() => db.Courses.ToList();
        public List<StudentCourse> ClassList(Course course)
        {
            var sc = db.StudentCourses.Where(x => x.CourseId == course.Id).Include(i=>i.Student);
            return sc.ToList();
        }
        public List<StudentCourse> studentCourses(User user)
        {
            var sc = db.StudentCourses.Where(x => x.StudentId == user.Id).Include(i => i.Course);
            return sc.ToList();
        }
        public bool CourseExists(string name)
        {
            var f = CourseByName(name);
            if (f == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public Course CourseByName(string name)
        {
            return db.Courses.FirstOrDefault(k => k.Name == name);
        }
    }
}
