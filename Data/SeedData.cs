using College.Data;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace College.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new CollegeContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<CollegeContext>>()))
        {
            // Seeding Students. 
            // Look for any students.
            if (!context.Student.Any())
            {
                // DB has not been seeded with student data
                context.Student.AddRange(
                    new Student { FirstName = "George", LastName = "Teemus", EnrollmentDate = DateTime.Now, },
                    new Student { FirstName = "Among", LastName = "us", EnrollmentDate = DateTime.Now, },
                    new Student { FirstName = "Must", LastName = "Washhands", EnrollmentDate = DateTime.Now, },
                    new Student { FirstName = "Mao", LastName = "Zedong", EnrollmentDate = DateTime.Now, },
                    new Student { FirstName = "Benito", LastName = "Mussolini", EnrollmentDate = DateTime.Now, },
                    new Student { FirstName = "Antony", LastName = "Martial", EnrollmentDate = DateTime.Now, },
                    new Student { FirstName = "Cristiano", LastName = "Ronaldo", EnrollmentDate = DateTime.Now, },
                    new Student { FirstName = "Donald", LastName = "Trump", EnrollmentDate = DateTime.Now, }
                );
                context.SaveChanges();
            }

            // Seeding Courses. 
            // Look for any courses.            
            if (!context.Course.Any())
            {
                // DB has not been seeded with courses data
                context.Course.AddRange(
                    new Course { Title = "Programmeerimise alused", Credits = 3 },
                    new Course { Title = "Programmeerimine 1", Credits = 6 },
                    new Course { Title = "Programmeerimine 2", Credits = 6 },
                    new Course { Title = "Tarkvara Arendusprotsess", Credits = 3 },
                    new Course { Title = "Multimeedia", Credits = 3 },
                    new Course { Title = "Hajusrakenduste Arendus", Credits = 3 }
                );
                context.SaveChanges();
            }
            
            int george = context.Student.Where(student=> student.FirstName=="George").First().Id;
            int among = context.Student.Where(student=> student.FirstName=="Among").First().Id;
            int must = context.Student.Where(student=> student.FirstName=="Must").First().Id;
            int mao = context.Student.Where(student=> student.FirstName=="Mao").First().Id;
            int benito = context.Student.Where(student=> student.FirstName=="Benito").First().Id;
            int antony = context.Student.Where(student=> student.FirstName=="Antony").First().Id;
            int cristiano = context.Student.Where(student=> student.FirstName=="Cristiano").First().Id;
            int donald = context.Student.Where(student=> student.FirstName=="Donald").First().Id;

            int programmingBasics = context.Course.Where(course => course.Title == "Programmeerimise alused").First().CourseId;
            int programming1 = context.Course.Where(course => course.Title == "Programmeerimine 1").First().CourseId;
            int programming2 = context.Course.Where(course => course.Title == "Programmeerimine 2").First().CourseId;
            int devProcess = context.Course.Where(course => course.Title == "Tarkvara Arendusprotsess").First().CourseId;
            int multimedia = context.Course.Where(course => course.Title == "Multimeedia").First().CourseId;
            int distAppDev = context.Course.Where(course => course.Title == "Hajusrakenduste Arendus").First().CourseId;
            
            if (!context.Enrollment.Any())
            {
                // DB has not been seeded with courses data
                context.Enrollment.AddRange(
                    new Enrollment { StudentID = george, CourseID=programmingBasics, CurrentGrade=Grade.X },
                    new Enrollment { StudentID = george, CourseID=programming1, CurrentGrade=Grade.X },
                    new Enrollment { StudentID = george, CourseID=programming2, CurrentGrade=Grade.X },
                    new Enrollment { StudentID = among, CourseID=programmingBasics, CurrentGrade=Grade.X },
                    new Enrollment { StudentID = among, CourseID=devProcess, CurrentGrade=Grade.X },
                    new Enrollment { StudentID = among, CourseID=distAppDev, CurrentGrade=Grade.X },
                    new Enrollment { StudentID = must, CourseID=programming1, CurrentGrade=Grade.X },
                    new Enrollment { StudentID = must, CourseID=distAppDev, CurrentGrade=Grade.X },
                    new Enrollment { StudentID = mao, CourseID=multimedia, CurrentGrade=Grade.X },
                    new Enrollment { StudentID = mao, CourseID=programming2, CurrentGrade=Grade.X },
                    new Enrollment { StudentID = benito, CourseID=programming1, CurrentGrade=Grade.X },
                    new Enrollment { StudentID = benito, CourseID=multimedia, CurrentGrade=Grade.X },
                    new Enrollment { StudentID = donald, CourseID=multimedia, CurrentGrade=Grade.X },
                    new Enrollment { StudentID = donald, CourseID=distAppDev, CurrentGrade=Grade.X },                    
                    new Enrollment { StudentID = antony, CourseID=distAppDev, CurrentGrade=Grade.X },                   
                    new Enrollment { StudentID = cristiano, CourseID=distAppDev, CurrentGrade=Grade.X }                  
                );
                context.SaveChanges();
            }


        }

    }
}