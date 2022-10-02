Console.Write ("Введи первое целое число ");
string usernum1 = Console.ReadLine () ?? "";
int num1 = int.Parse (usernum1);
Console.Write ("Введи второе целое число ");
string usernum2 = Console.ReadLine () ?? "";
int num2 = int.Parse (usernum2);
Console.Write ("Введи третье целое число ");
string usernum3 = Console.ReadLine () ?? "";
int num3 = int.Parse (usernum3);
int max = 0;
if (num1 > num2)
{
    max = num1;
}
else 
{
    max = num2;
}
if (num3 > max)
{
    max = num3;
}
Console.WriteLine ("a=" + num1 + " b=" + num2 + " c=" + num3 + " -> max=" + max);