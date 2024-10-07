using OOP.Basic;
using OOPBasic;

WaterBottle bottle = new WaterBottle(100, "red");
bottle.AddWater(30);

WaterBottle bottle1 = new WaterBottle(150, "blue");
bottle1.AddWater(30);
bottle1.AddWater(50);

Console.WriteLine(bottle.WaterAmount);
Console.WriteLine(bottle1.WaterAmount);

Products product1 = new Products();
product1.Name = "Camera";
product1.Price = 10000;
product1.CalculateDiscount();


Students student = new Students("Nakib Khan", "111");
student.ChangePassword("111", "888");
student.CreateID();

Teacher newTeacher = new Teacher("Alif", "000");
newTeacher.CalculateSalary();
Console.WriteLine(newTeacher.Salary);
newTeacher.CreateID();

Console.WriteLine(student.ID);
Console.WriteLine(newTeacher.ID);

User user = new Students("Nakib Khan", "Khan Shaheb123");
user.CreateID();
Console.WriteLine(user.ID);