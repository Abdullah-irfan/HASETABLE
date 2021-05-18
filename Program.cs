using System;
using System.Collections;

namespace hasetableconcept
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable employee = new Hashtable();
            employee.Add(1, "irfan");
            employee.Add(2, "raja");
            employee.Add(3, "thiru");
            foreach (DictionaryEntry list in employee)
            {
                Console.WriteLine("Key = {0}, Value = {1}", list.Key, list.Value);

            }
            Console.WriteLine("Key 2: {0}", employee.ContainsKey(2));


            Calculator calc = new Calculator(15, +25);

            calc = -calc;
            Console.WriteLine("Number1 = " + calc.value1);
            Console.WriteLine("Number2 = " + calc.value2);


            Console.ReadKey();
        }
    }

    class Calculator
    {

        public int value1, value2;
        public Calculator(int num1, int num2)
        {
            value1 = num1;
            value2 = num2;
        }

        public static Calculator operator -(Calculator c1)
        {
            c1.value1 = -c1.value1;
            c1.value2 = -c1.value2;
            return c1;
        }

       
    }

    
}

    


