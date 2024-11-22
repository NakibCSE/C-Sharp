using EntityFrameworkExample;
using System.Diagnostics.Contracts;
using System.Globalization;

using TrainingDbContext trainingDbContext = new TrainingDbContext();

/***********************************************************************
 *  Example 1 with single table
 * *********************************************************************

//Example 01 with single table
 
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

*****************************************************/

// Example 02 : with multitable

/**************************
 * One to many relationship example
 * *************************

Course course1 = new Course();
course1.Title = "Laravel";
course1.Fees = 13000;
course1.IsActive = true;
course1.StartDate = new DateTime(2023, 2, 2);

Topic topic = new Topic();
topic.Name = "Getting Started";
topic.Duration = 130;

Topic topic2 = new Topic();
topic2.Name = "Basic Sytex";
topic2.Duration = 1000;

Topic topic1 = new Topic();
topic1.Name = "Database connection";
topic1.Duration = 200;

course1.Topics = new List<Topic>();
course1.Topics.Add(topic);
course1.Topics.Add(topic2);
course1.Topics.Add(topic1);

trainingDbContext.Courses.Add(course1);
trainingDbContext.SaveChanges();
**********************/

Course course = new Course();
course.Title = "DevOps Course";
course.Fees = 28000;
course.IsActive = false;
course.StartDate = new DateTime(2024, 8, 8);

Topic topic = new Topic();
topic.Name = "Basic Syntex";
topic.Duration = 100;

course.Topics = new List<Topic>();
course.Topics.Add(topic);

trainingDbContext.Courses.Add(course);
trainingDbContext.SaveChanges();

Student student = new Student();
student.Name = "Nakib Khan";

Student student1 = new Student();
student1.Name = "Tamim Khan";

CourseEnrollment enrollment = new CourseEnrollment();
enrollment.student = student;

CourseEnrollment courseEnrollment1 = new CourseEnrollment();
courseEnrollment1.student = student1;

course.MyCourses = new List<CourseEnrollment>();
course.MyCourses.Add(courseEnrollment1);
course.MyCourses.Add(enrollment);
 