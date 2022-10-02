Console.Write("Введи целое число ");
string usernum = Console.ReadLine() ?? "";
int num = int.Parse(usernum);
int a = 2;
int b = -2;
Console.Write("Четные числа от 1 до " + num + ": ");
if (num > 0)
{
    while (a <= num)
    {
        Console.Write(a + "; ");
        a = a + 2;
    }
}
else
{
    while (b >= num)
    {
        Console.Write(b + "; ");
        b = b - 2;
    }
}

