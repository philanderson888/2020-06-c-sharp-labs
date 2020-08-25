using System;

namespace lab_31_oop_events
{
    class Program
    {
        static void Main(string[] args)
        {

            // goal : annual event (triggered by calendar) - have birthday party
            var james = new Child("James");

            // events ==> not reachable externally so have to call from a method in the class
            for (int i = 0; i < 20; i++) {
                james.AnotherYearOlder();
            }

        }
    }

    class Child
    {
        public string Name { get; set; }
        public int Age { get; set; }

        delegate void BirthdayDelegate(int age);

        event BirthdayDelegate BirthdayEvent;  // null right now

        public Child(string name)
        {
            // new person => allocate name but age = 0
            this.Name = name;
            this.Age = 0;
            // fill event
            BirthdayEvent += Celebrate; // event no longer null
        }

        public void AnotherYearOlder()
        {
            this.Age++;
            BirthdayEvent(this.Age);
        }


        // method
        void Celebrate(int age)
        {
            Console.WriteLine($"Congratulations !!!  You have reached the age of {age}");
        }
    
    }









}
