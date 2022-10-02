Console.Write("Введи целое число от 1 до 7 ");
string user = Console.ReadLine() ?? "";
int usernum = int.Parse(user);
if (usernum == 1)
{
    Console.WriteLine(usernum + " -> понедельник");
}
else 
{
    if (usernum == 2)
    {
      Console.WriteLine(usernum + " -> вторник");  
    }
    else
    {
        if (usernum == 3)
    { 
           Console.WriteLine(usernum + " -> среда"); 
    }
    else
    {
        if (usernum == 4)
        {
            Console.WriteLine(usernum + " -> четверг"); 
        }
        else
        {
            if (usernum == 5)
            {
                Console.WriteLine(usernum + " -> пятница");
            }
            else
            {
                if (usernum == 6)
            {
                Console.WriteLine(usernum + " -> суббота");
            }
            else
            {
                Console.WriteLine(usernum + " -> воскресенье");
            }
            }
        } 
    }}}