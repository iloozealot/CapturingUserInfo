
//Console Application?
//name?
//age?
//alive?
//phone number?


string? firstAndLastName = null;
int? age = null;
bool? deceased = null;
string? phoneNumber = null;

Console.WriteLine("Welcome, please enter the required registration info below.");
Console.WriteLine("-------------------------------------------------------------");
Console.WriteLine();

Console.Write("First and Last Name? ");
firstAndLastName = Console.ReadLine();

Console.Write("Age? ");
age = Convert.ToInt32(Console.ReadLine());

Console.Write("True or False, Deceased? ");
deceased = Convert.ToBoolean(
    Console.ReadLine()?
    .ToLower());

Console.Write("Phone Number? ");
phoneNumber = Console.ReadLine();
Console.WriteLine();

Console.WriteLine(firstAndLastName);
Console.WriteLine(age);
Console.WriteLine(deceased);
Console.WriteLine(phoneNumber);