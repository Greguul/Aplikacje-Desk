using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person

{
    class person
    {
        private string name;
        private string surname ;
        private int age;


        public person()
        {
            name = "Adam";
            surname = "Suchanowski";
            age = 16;


        }



        public person(string n, string s, int w)

        {
            name = n;
            surname = s;
            age = w;

        }

        public void ShowInfo()
        {
            Console.WriteLine("***************************************");
            Console.WriteLine($"Imie:  {name}");
            Console.WriteLine($"Nazwisko:  {surname}");
            Console.WriteLine($"wiek:  {age}");
            Console.WriteLine("***************************************");

        }

    }
}
