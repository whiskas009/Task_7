using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во людей в очереди");
            int peopleInQueue = int.Parse(Console.ReadLine());

            int minuteInHoures = 60;
            int waitingTime = 10;
            int timeHour = (peopleInQueue * waitingTime) / minuteInHoures;
            int timeMinute = (peopleInQueue * waitingTime) % minuteInHoures;

            Console.WriteLine($"Вы должны отстоять в очереди {timeHour} часа и {timeMinute} минут.");
        }
    }
}
