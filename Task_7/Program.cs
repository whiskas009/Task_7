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
            int waitingTimeGrandma = 10;
            int allWaitingTime = peopleInQueue * waitingTimeGrandma;

            int waitingTime = allWaitingTime / minuteInHoures;
            Console.Write($"Вы должны отстоять в очереди {waitingTime} часа и ");

            waitingTime = allWaitingTime % minuteInHoures;
            Console.WriteLine($"{waitingTime} минут.");
        }
    }
}
