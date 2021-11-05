using System;

namespace EssentialLesson7Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Train[] trains = new Train[8];
            string[] places = { "DENVER", "BOGOTA", "BERLIN" };
            string str;
            string place;
            int trainNum;
            TimeSpan time;
            int hour;
            int min;


            Console.WriteLine("Input info about 8 trains.");

            for (int i = 0; i < trains.Length; i++)
            {
                Console.WriteLine($"Input place for {i + 1} train.");
                while (true)
                {
                    str = Console.ReadLine();
                    str = str.ToUpper();

                    if (str.Contains(places[0]) || str.Contains(places[1]) || str.Contains(places[2]))
                    {
                        place = str;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("This place does not exist, try again");
                        continue;
                    }
                }

                Console.WriteLine($"Input number for {i + 1} train.");
                while (true)
                {
                    str = Console.ReadLine();
                    if (int.TryParse(str, out trainNum))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("It is not a number, try again");
                        continue;
                    }
                }

                Console.WriteLine($"Input time for {i + 1} train in this format '00:00'.");
                while (true)
                {
                    string[] minSec;

                    str = Console.ReadLine();

                    if (str.Length == 5)
                    {
                        if (str[2] != ':')
                        {
                            Console.WriteLine("It is not validated time format, try again");
                            continue;
                        }
                    }

   
                    minSec = str.Split(':');

                    if ((int.TryParse(minSec[0], out hour) && (int.TryParse(minSec[1], out min))))
                    {
                        if (hour < 24 && min < 60)
                        {
                            time = new TimeSpan(hour, min, 0);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Validation is unsuccessfull, try again.");
                            continue;
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("It is not validated time format, try again");
                        continue;
                    }
                }

                Train train = new Train(place, trainNum, time);
                trains[i] = train;
            }



            while (true)
            {
                Console.WriteLine("Ipnut number of the exact train which are in the array.");
                str = Console.ReadLine();

                if (int.TryParse(str, out trainNum))
                {
                    if (trainNum >= 0 && trainNum < trains.Length)
                    {
                        trains[trainNum].Show();
                    }
                    else
                    {
                        Console.WriteLine("We dont have this number of the train.");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine($"{str} is not a number, try again.");
                    continue;
                }
            }
        }
    }
}
