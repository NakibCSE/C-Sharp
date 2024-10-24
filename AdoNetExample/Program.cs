using AdoNetExample;
string __connectionString = "Server=DESKTOP-O70O0UG\\SQLEXPRESS;Database=CSharpB18;User Id=CSharpB18;Password=12345; Trust Server Certificate=True";
AdoNetUtility adoNetUtility = new AdoNetUtility(__connectionString);
var sql = "insert into Employee(Name, DateOfBirth, IsMarried) values(@name, @dateofbirth, @ismarried)";

Dictionary<string, object> keyValuePairs = new Dictionary<string, object>();
keyValuePairs.Add("@name", "Khan Mr.");
keyValuePairs.Add("@dateofbirth", new DateTime(2000, 10, 1));
keyValuePairs.Add("@ismarried", true);

adoNetUtility.RunSql(sql, keyValuePairs);

var getData = "select *from employee where id < @ID";
Dictionary<string, object> parameters = new Dictionary<string, object>();
parameters.Add("@ID", 10);

var result = adoNetUtility.GetData(getData, parameters);

foreach (var row in result)
{
    foreach (var key in row.Keys)
    {
        Console.Write(row[key]);
        Console.Write(" ");
    }
    Console.WriteLine();
}