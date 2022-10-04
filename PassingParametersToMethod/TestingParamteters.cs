using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingParametersToMethod
{
    class TestingParamteters
    {
        #region Przekazywanie typów prostych 

        public void Test1()
        {
            byte number = 15;
            Console.WriteLine("Zmienna number = " + number);

            ChangeValuev2(ref number);
            Console.WriteLine("Zmienna number = " + number);

            int random = GetRandomNumber();

            GetRandomNumber(out random);

            Console.WriteLine("Liczba losowa =" + random);
        }

         public void changevalue(byte value)
        {
            Console.WriteLine("Parametr value = " +value);
            value = (byte)(value + 10);
            Console.WriteLine("Parametr value = " + value);

        }

        private void ChangeValuev2 (ref byte value)
        {
            Console.WriteLine("Parametr value =" + value);
            value = (byte)(value + 10);
            Console.WriteLine("Parametr value =" + value);
        }

        private int GetRandomNumber()
        {
            return new Random().Next(); 
        }


        private void GetRandomNumber (out int value)
        {
            value = new Random().Next();
        }
        //ref wymaga wartosci 
        //out nie wymaga wartosci 
        #endregion

        #region Przekazywanie Typów referencyjnych 

        public void test2()
        {
            preson preson = new Person();
            Person.ShowInfo(); 
        }
        #endregion



    }




}
