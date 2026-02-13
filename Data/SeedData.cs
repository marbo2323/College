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
            
            var george = context.Student.Where(student=> student.FirstName=="George").First();

            var programmingBasics = context.Course.Where(course => course.Title == "Programmeerimise alused").First();
            
            if (!context.Enrollment.Any())
            {
                // DB has not been seeded with courses data
                context.Enrollment.AddRange(
                //new Enrollment {CourseID=1, StudentID = 1, CurrentGrade=Grade.X }
                    
                    
                );
                context.SaveChanges();
            }


        }

    }
}