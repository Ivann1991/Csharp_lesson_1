Console.Write("Введи первое целое число ");
string user1 = Console.ReadLine() ?? "";
int usernum1 = int.Parse (user1);
Console.Write("Введи второе целое число ");
string user2 = Console.ReadLine () ?? "";
int usernum2 = int.Parse (user2);

if (usernum2 * usernum2 == usernum1)
{
    Console.WriteLine ("a=" + usernum1 + ", b=" + usernum2 + " -> да");
}
else 
{
    Console.WriteLine ("a=" + usernum1 + ", b=" + usernum2 + " -> нет");
}