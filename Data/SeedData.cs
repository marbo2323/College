using College.Data;
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
            if (context.Student.Any())
            {
                return;   // DB has been seeded
            }

            context.Student.AddRange(
                new Student {FirstName = "George",LastName = "Teemus",EnrollmentDate = DateTime.Now, },
                new Student {FirstName = "Among",LastName = "us",EnrollmentDate = DateTime.Now, },
                new Student {FirstName = "Must",LastName = "Washhands",EnrollmentDate = DateTime.Now, },
                new Student {FirstName = "Mao",LastName = "Zedong",EnrollmentDate = DateTime.Now, },
                new Student {FirstName = "Benito",LastName = "Mussolini",EnrollmentDate = DateTime.Now, },
                new Student {FirstName = "Antony",LastName = "Martial",EnrollmentDate = DateTime.Now, },
                new Student {FirstName = "Cristiano",LastName = "Ronaldo",EnrollmentDate = DateTime.Now, },
                new Student {FirstName = "Donald",LastName = "Trump",EnrollmentDate = DateTime.Now, }
            );
            context.SaveChanges();
             
        }

    }
}