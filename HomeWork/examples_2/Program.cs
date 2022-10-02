Console.Write ("Введи первое целое число ");
string num1 = Console.ReadLine () ??"";
int usernum1 = int.Parse (num1);
Console.Write ("Введи второе целое число ");
string num2 = Console.ReadLine () ??"";
int usernum2 = int.Parse (num2);

if (usernum1 > usernum2)
{
    Console.WriteLine ("a=" + usernum1 + ";b=" + usernum2 + " -> max=" + usernum1 + " min=" + usernum2);
}
else 
{
    Console.WriteLine ("a=" + usernum1 + ";b=" + usernum2 + " -> max=" + usernum2 + " min=" + usernum1);
}