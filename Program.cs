//Program written by: Peggy Walsh/Jenna Lillie (Group)
//Program Date: 2/23/2021
//Program description: Case 1 (Group) - Chapter 5
//Encountered issues: None


using System;
using static System.Console;
class GreenvilleRevenue
{
    static void Main()
    {
        int thisYear;
        int lastYear;

        while (true)
        {
            Write("Enter the number of contestants from last year (0 - 30): ");
            lastYear = Convert.ToInt16(ReadLine());
            if (lastYear > -1 && lastYear < 31)
            {
                WriteLine("You have entered {0} for last year.", lastYear);
                break; 
            } else
            {
                WriteLine("You wrote the wrong number for last year's contestants. Try again.");
            }
        }

        while (true)
        {
            Write("Enter the number of contestants from this year: ");
            thisYear = Convert.ToInt16(ReadLine());
            if (thisYear > -1 && thisYear < 31)
            {
                WriteLine("You have entered {0} for last year.", thisYear);
                break;
            }
            else
            {
                WriteLine("You wrote the wrong number for this year's contestants. Try again.");
            }
        }

        if (thisYear == 2 * lastYear)
            WriteLine("The competition is more than twice as big this year!");
        else if ((thisYear > lastYear) && (thisYear != 2 * lastYear))
            WriteLine("The competition is bigger than ever!");
        else
            WriteLine("A tighter race this year! Come out and cast your vote!");
    }
}