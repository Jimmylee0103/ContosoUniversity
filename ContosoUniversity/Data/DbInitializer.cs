﻿using ContosoUniversity.Models;
using System;
using System.Linq;

namespace ContosoUniversity.Models
{
    public static class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            // context.Database.EnsureCreated();

            // Look for any students.
            if (context.Student.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Student[]
            {
            new Student{Id= 1, FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{Id= 2, FirstMidName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{Id= 3, FirstMidName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{Id= 4, FirstMidName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{Id= 5, FirstMidName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{Id= 6, FirstMidName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
            new Student{Id= 7, FirstMidName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{Id= 8, FirstMidName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };
            foreach (Student s in students)
            {
                context.Student.Add(s);
            }
            context.SaveChanges();

            var courses = new Course[]
            {
            new Course{CourseId=1050,Title="Chemistry",Credits=3},
            new Course{CourseId=4022,Title="Microeconomics",Credits=3},
            new Course{CourseId=4041,Title="Macroeconomics",Credits=3},
            new Course{CourseId=1045,Title="Calculus",Credits=4},
            new Course{CourseId=3141,Title="Trigonometry",Credits=4},
            new Course{CourseId=2021,Title="Composition",Credits=3},
            new Course{CourseId=2042,Title="Literature",Credits=4}
            };
            foreach (Course c in courses)
            {
                context.Course.Add(c);
            }
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
            new Enrollment{StudentId=2023,CourseId=1050,Grades=Grade.A},
            new Enrollment{StudentId=1,CourseId=4022,Grades=Grade.C},
            new Enrollment{StudentId=1,CourseId=4041,Grades=Grade.B},
            new Enrollment{StudentId=2,CourseId=1045,Grades=Grade.B},
            new Enrollment{StudentId=2,CourseId=3141,Grades=Grade.F},
            new Enrollment{StudentId=2,CourseId=2021,Grades=Grade.F},
            new Enrollment{StudentId=3,CourseId=1050},
            new Enrollment{StudentId=4,CourseId=1050},
            new Enrollment{StudentId=4,CourseId=4022,Grades=Grade.F},
            new Enrollment{StudentId=5,CourseId=4041,Grades=Grade.C},
            new Enrollment{StudentId=6,CourseId=1045},
            new Enrollment{StudentId=7,CourseId=3141,Grades=Grade.A},
            };
            foreach (Enrollment e in enrollments)
            {
                context.Enrollment.Add(e);
            }
            context.SaveChanges();
        }
    }
}