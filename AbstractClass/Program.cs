using AbstractClass;

Teacher teacher = new Teacher("Jalal Uddin","3245");
Students student = new Students("hasan", "3434");

Test(teacher);
Test(student);

void Test(User user)
{
    user.CreateID();
}
