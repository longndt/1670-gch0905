using System;
using System.Linq;
using webdemo.Models;

namespace webdemo.Data
{
    public class DbInitializer
    {
        public static void Initialize(DemoContext context)
        {
            //đảm bảo DB đã được khởi tạo
            context.Database.EnsureCreated();

            //kiểm tra xem đã có dữ liệu trong bảng thuộc DB hay chưa
            //nếu có rồi thì bỏ qua
            //chưa có thì chạy code khởi tạo dữ liệu ban đầu cho DB
            if (context.Students.Any())
            {
                return;
            }

            //khởi tạo dữ liệu cho bảng Student
            //1. tạo array list cho student
            var students = new Student[]
            {
                new Student {LastName = "Minh", FirstMidName = "Nguyen Van", EnrollmentDate = DateTime.Parse("2000-05-12")},
                new Student {LastName = "Chien", FirstMidName = "Nguyen Dinh", EnrollmentDate = DateTime.Parse("2001-09-02")},
                new Student {LastName = "Phuong", FirstMidName = "Hoang Viet", EnrollmentDate = DateTime.Parse("2002-02-22")},
                new Student {LastName = "Linh", FirstMidName = "Nguyen Thi", EnrollmentDate = DateTime.Parse("2003-07-14")},
                new Student {LastName = "Hong", FirstMidName = "Nguyen Mai", EnrollmentDate = DateTime.Parse("2006-09-08")},
            };
            //2. add từng student trong array vào DB
            foreach (Student s in students) {
                context.Students.Add(s);
            }
            //3. lưu lại thay đổi trong DB
            context.SaveChanges();

            //khởi tạo dữ liệu cho bảng Course
            var courses = new Course[]
            {
                new Course { CourseId = 1670, Title = "Application Development", Credits = 3 },
                new Course { CourseId = 1633, Title = "Web Design & Development", Credits = 4 },
                new Course { CourseId = 1618, Title = "Programming", Credits = 2 },
                new Course { CourseId = 301, Title = "Web Project", Credits = 5 },
                new Course { CourseId = 1640, Title = "Web Enterprise", Credits = 6 }
            };
            foreach (Course c in courses)
            {
                context.Courses.Add(c);
            }
            context.SaveChanges();

            //khởi tạo dữ liệu cho bảng Enrollment
            var enrollments = new Enrollment[]
            {
                new Enrollment{ CourseId = 1670, StudentId = 1, Grade = Grade.A},
                new Enrollment{ CourseId = 1633, StudentId = 2, Grade = Grade.B},
                new Enrollment{ CourseId = 1618, StudentId = 3, Grade = Grade.C},
                new Enrollment{ CourseId = 1670, StudentId = 2, Grade = Grade.E},
                new Enrollment{ CourseId = 301, StudentId = 2, Grade = Grade.D},
            };
            foreach (Enrollment e in enrollments)
            {
                context.Enrollments.Add(e);
            }
            context.SaveChanges();
        }
    }
}
