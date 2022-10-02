Console.WriteLine ("Введи целое число");
string user = Console.ReadLine () ?? "";
int usernumber = int.Parse (user);
Console.WriteLine (usernumber + " -> " + usernumber * usernumber);
