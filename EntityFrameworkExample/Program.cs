using EntityFrameworkExample;
using System.Globalization;

TrainingDbContext trainingDbContext = new TrainingDbContext();
Course course = new Course();
course.Title = "Professional PHP";
course.Fees = 8000;
course.IsActive = false;
course.StartDate = new DateTime(2024, 3, 3);

//Insert Data
trainingDbContext.Courses.Add(course);
trainingDbContext.SaveChanges();

//Get Data
//Fetch all the courses
List<Course> courses = trainingDbContext.Courses.ToList();

//Fetch only the active courses
List<Course> activeCourses = trainingDbContext.Courses.Where(c => c.IsActive).ToList();   //Linq

//Fetche the specific course (C# in this case)
Course? csharpCourse = trainingDbContext.Courses.Where(x => x.Title.Contains("C#")).FirstOrDefault();

Console.WriteLine($"ID : {csharpCourse?.Id}, Title: {csharpCourse?.Title}");

//Edit Data
csharpCourse.Title = "Professional C# Delevelopment";
csharpCourse.Fees = 9000;

trainingDbContext.SaveChanges();

//Delete 
trainingDbContext.Courses.Remove(csharpCourse);
trainingDbContext.SaveChanges();
