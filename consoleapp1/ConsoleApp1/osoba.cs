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

        private string surname;
        public string Surname

        {
            private set
            {
                if (value != "")
                    surname = value;
            }

            get
            {
                return surname;
            }
        }

        private int age;
        public int Age
        {
            get
            {
                return age;
            }


        }

        public float Height { get; set;  }


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


        public void SetSurname(string new_surname);
        {
          if (Newsurname !="")
        
            surname =newSurname; 
        

    }

      
    
      // throw new Excaption("Nazwisko zakazane");
    
   }


 public string Getsurname();
 return surname;



