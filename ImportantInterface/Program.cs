using ImportantInterface;

People<string> people = new People<string>();

foreach (var person in people)
{

}

using FileContentReader fileContentReader = new FileContentReader("Docs.txt");
string data = fileContentReader.GetContent(20);
Console.WriteLine(data);
data = fileContentReader.GetContent(20);
Console.WriteLine(data);


Product product = new Product();
product.Name = "Camera";
product.Description = "Cannon Camera";
product.Price = 90000;
product.IsDefault = true;



Product product2 = (Product)product.Clone();