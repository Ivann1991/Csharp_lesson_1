Console.Write("Введи целое число от 1 до 7 ");
string user = Console.ReadLine() ?? "";
int usernum = int.Parse(user);
if (usernum == 1)
{
    Console.WriteLine(usernum + " -> понедельник");
}
if (usernum == 2)
    {
    Console.WriteLine(usernum + " -> вторник");  
    }
if (usernum == 3)
    { 
    Console.WriteLine(usernum + " -> среда"); 
    }
if (usernum == 4)
    {
Console.WriteLine(usernum + " -> четверг"); 
    }
        
if (usernum == 5)
    {
Console.WriteLine(usernum + " -> пятница");
    }
if (usernum == 6)
    {
Console.WriteLine(usernum + " -> суббота");
    }    
if (usernum == 7)     
    {
    Console.WriteLine(usernum + " -> воскресенье");
    }
   