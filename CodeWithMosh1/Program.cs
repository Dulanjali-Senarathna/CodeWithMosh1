﻿using System;
using CodeWithMosh1.Math;

namespace CodeWithMosh1
{
    class Person
    {
        public string firstName;
        public string lastName;

        public void Introduce()
        {
            Console.WriteLine("My name is " + firstName + " " + lastName);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Demo Variables and Constants
            var number = 2;
            var count = 10;
            var totalPrice = 20.95f;
            var character = 'A';
            var firstName = "Dulanjali";
            var isWorking = true;

            const float PI = 3.14f;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            Console.WriteLine(PI);

            Console.WriteLine("{0} {1}", byte.MaxValue , byte.MinValue);
            Console.WriteLine("{0} {1}", float.MaxValue , float.MinValue);

            //Demo Type Conversion
            byte b = 1;
            int i = b;
            Console.WriteLine(i);

            int x = 2000;
            byte y = (byte)x;
            Console.WriteLine(y);

            try
            {
            
                var numberc = "1235";
                int z = Convert.ToInt32(numberc);
                Console.WriteLine(z);
                byte by = Convert.ToByte(numberc);
                Console.WriteLine(numberc);
            }
            catch (Exception)
            {

                Console.WriteLine("The number could not be coverted to the byte");
            }

            string str = "true";
            bool boo = Convert.ToBoolean(str);
            Console.WriteLine(boo);

            //Demo- Operators

            int q = 10;
            int w = 3;
            int r = 11;

            Console.WriteLine(q+w);
            Console.WriteLine(q/w);//reslut int
            Console.WriteLine((float)q/ (float)w);
            Console.WriteLine(q+w*r);//operator precedence
            Console.WriteLine(w>q);
            Console.WriteLine(w==q);
            Console.WriteLine(w!=q);
            Console.WriteLine(!(w!=q)); // ugly, so => put (w==q)
            Console.WriteLine(r>q && r>w);
            Console.WriteLine(r > q && r == w);
            Console.WriteLine(r > q || r == w);
            Console.WriteLine(!(r > q || r == w));

            Person person = new Person();
            person.firstName = "Dulanjali";
            person.lastName = "Dilshani";
            person.Introduce();

            Calculator cal = new Calculator();
            int res =cal.Add(1, 5);
            Console.WriteLine(res);

            //Demo- Arrays

            var numbers = new int[30];  //same to int[] numbers = new int[30]; because compiler identifies type of var as an array
            numbers[0] = 1;

            Console.WriteLine(numbers[0]);//output 1
            Console.WriteLine(numbers[1]);//output 0 default
            Console.WriteLine(numbers[2]);//output 0

            var flags = new bool[3];

            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

        }
    }
}
