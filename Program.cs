using System;

namespace AdvancedDotNetEventsExercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            var clock = new Clock(new DateTime(2022, 9, 15, 20, 43, 25));

            clock.Alarm += Clock_Alarm;

            void Clock_Alarm(object sender, EventArgs e)
            {
                Console.WriteLine("Alarm goes off;");
            }

            Console.ReadKey();
        }
    }
}
