using System;

namespace EssentialLesson7Task1
{
    struct Notebook
    {

        string model;
        string manufacturer;
        double price;

        public Notebook(string model, string manufacturer, double price)
        {

            this.model = model;
            this.manufacturer = model;
            this.price = price;

        }

        public void ShowAll()
        {
            Console.WriteLine($"Model is: {model}, manufacturer is: {manufacturer}, price is {price}");
        }
    }
}
