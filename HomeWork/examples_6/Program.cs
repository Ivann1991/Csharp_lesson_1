Console.Write("Введи целое число ");
string usernum = Console.ReadLine () ??"";
int num = int.Parse (usernum);

if (num % 2 == 0)
{
    Console.WriteLine (num + " -> Четное");
}
else 
{
    Console.WriteLine (num + " -> Нечетное");
}