using System;
namespace Program
{
    public class NumberOfWorkDays 
    {
        public static void Main(string [] args)
        {
            Console.Write("Enter first date(mm-dd-yyyy): ");
            DateTime firstDate = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Enter second date(mm-dd-yyyy): ");
            DateTime secondDate = Convert.ToDateTime(Console.ReadLine());

            int totalDays = Convert.ToInt32((secondDate - firstDate).TotalDays);
            int numOfweekends = (totalDays / 7) * 2;

            for (int i = 0; i < totalDays; i++)
            {
                if (IsHoliday(firstDate))
                {
                    totalDays = totalDays - 1;
                }
                firstDate = firstDate.AddDays(1);
            }

            totalDays -= numOfweekends;
            Console.WriteLine(totalDays);

            Console.ReadLine();
        }

        private static bool IsHoliday(DateTime date)
        {
            if ((int)date.Month == 1 && (int)date.Day == 1  ||
                (int)date.Month == 1 && (int)date.Day == 18 ||
                (int)date.Month == 1 && (int)date.Day == 20 ||
                (int)date.Month == 2 && (int)date.Day == 15 ||
                (int)date.Month == 3 && (int)date.Day == 31 ||
                (int)date.Month == 4 && (int)date.Day == 18 ||
                (int)date.Month == 5 && (int)date.Day == 5  ||
                (int)date.Month == 6 && (int)date.Day == 6  ||
                (int)date.Month == 10 && (int)date.Day == 11||
                (int)date.Month == 11 && (int)date.Day == 11||
                (int)date.Month == 11 && (int)date.Day == 25||
                (int)date.Month == 12 && (int)date.Day == 24)
            {
                return true;
            }
            return false;
        }
    }
}