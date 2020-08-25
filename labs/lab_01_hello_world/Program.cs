using Microsoft.Extensions.Configuration;
using System;
using System.Configuration;

namespace lab_01_hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World from Phil!");
        }
    }

    // Interfaces : everything PUBLIC BY DEFAULT (NOT DECLARED BUT IMPLIED)
    interface IDoThis {
        void DoThis();  // NO BODY
    }

    abstract class Holiday{
        
        // regular method
        void TravelPlans() { }

        public abstract void Accommodation();

        public virtual void ViewSights() { }

    }

    class DoingSomething : Holiday, IDoThis
    {
        private string _hideme;  // encapsulated

        public void DoThis() { }  // BODY

        public override void Accommodation() { }

        // optional override
        public override void ViewSights()  {   }
    }


}
