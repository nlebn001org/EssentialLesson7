using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialLesson7Task2
{
    struct Train
    {

        string place;
        int trainNumber;
        TimeSpan time;

        public string Place { get { return place; } }
        public int TrainNumber { get { return trainNumber; } }
        public TimeSpan Time { get { return time; } }


        public Train(string place, int trainNumber, TimeSpan time)
        {
            this.place = place;
            this.trainNumber = trainNumber;
            this.time = time;
        }

        public void Show()
        {
            Console.WriteLine($"Place: {place}, Number: {trainNumber}, time: {time.ToString()}");
        }

    }
}
