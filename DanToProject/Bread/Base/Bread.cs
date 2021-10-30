using System;
using System.Collections.Generic;

namespace DanToProject
{
    public abstract class Bread
    {
        protected string name;
        protected string sauce;
        protected List<string> toppings = new List<string>();

        protected List<string> vegetables = new List<string>();

        public void Prepare()
        {
            Console.WriteLine("Preparing " + name);
            Console.WriteLine("Adding sauce..." + sauce);
            Console.WriteLine("Adding toppings:");
            foreach (string topping in toppings)
            {
                Console.WriteLine("\t" + topping);
            }
            Console.WriteLine("Vegetables:");
            foreach (string vegetable in vegetables)
            {
                Console.WriteLine("\t" + vegetable);
            }

        }

        public void Bake()
        {
            Console.WriteLine("Baking " + name + "in few mins");
        }

        public void Pack()
        {
            Console.WriteLine("Packing " + name);
        }


    }
}