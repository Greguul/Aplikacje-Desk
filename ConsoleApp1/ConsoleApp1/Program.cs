using System;

namespace person
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");





            person firstPerson = new person();

            firstPerson.ShowInfo();


            person secondPerson = firstPerson;
           secondPerson.ShowInfo(); //kopiuje wskaznik 


            person thirdPerson = new person("Ala , Kowalska ", 18);
            thirdPerson.ShowInfo();

            secondPerson = thirdPerson;
            secondPerson.ShowInfo();

            thirdPerson.Setsurname("");
            thirdPerson.ShowInfo();

            thirdPerson.Setsurname("Nowakowska");
            thirdPerson.ShowInfo();


            string dana = thirdPerson.GetSurname();
            

   
        }
    }
}
