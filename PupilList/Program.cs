using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PupilList
{
    class Program
    {
        enum Gender
        {
            Male,
            Female,
            Other,
        }
        enum House
        {
            Bassett,
            Berwick,
            Compton,
            Winterbourne,
            Wootton,
        }
        struct Pupil
        {
            public string name;
            public int age;
            public Gender gender;
            public House house;         
        }
        static void Main(string[] args)
        {
            Console.WriteLine("How many pupils do you want to enter?");
            string x = Console.ReadLine();
            int result;
            Int32.TryParse(x, out result);
            Pupil[] pupils = new Pupil[result];
            
            for (int z = 0; z < result; z++)
            {
                Console.WriteLine("Enter Name: ");
                pupils[z].name = Console.ReadLine();
                Console.WriteLine("Enter Age: ");
                Int32.TryParse(Console.ReadLine(), out pupils[z].age);
                Console.WriteLine("Enter Gender (M/F/O): ");
                switch (Console.ReadLine().ToUpper())
                {

                    case "M": { pupils[z].gender = Gender.Male; break; }
                    case "F": { pupils[z].gender = Gender.Female; break; }
                    case "O": { pupils[z].gender = Gender.Other; break; }
                }
                Console.WriteLine("Enter House: (Ba/Be/Co/Wi/Wo)");
                switch (Console.ReadLine().ToUpper())
                {

                    case "Ba": { pupils[z].house = House.Bassett; break; }
                    case "Be": { pupils[z].house = House.Berwick; break; }
                    case "Co": { pupils[z].house = House.Compton; break; }
                    case "Wi": { pupils[z].house = House.Winterbourne; break; }
                    case "Wo": { pupils[z].house = House.Wootton; break; }
                }
            }
            int n = 1;
            foreach (Pupil item in pupils)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Pupil " + (n) + " - ");
                Console.WriteLine("Name: " + item.name);
                Console.WriteLine("Age: " + item.age);
                Console.WriteLine("Gender: " + item.gender);
                Console.WriteLine("House: " + item.house);
                n=n+1;
            }
            Console.ReadLine();
        }
    }
}
