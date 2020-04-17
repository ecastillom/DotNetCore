using System;
using System.Collections.Generic;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var p = new Program();
            p.Test();

            string full = p.FullName("Efren","Castillo");
            Console.WriteLine(full);

            p.Exc1();
        }

        void Exc1(){
            List<int> numbers =  new List<int>();

            for(int x=0; x<100; x++){
                numbers.Add(x *10);

            }
 
            Console.WriteLine(numbers);

            int Sum = 0;

            foreach(int num in numbers){
                if(num >40){
                    Sum += num;
                }
            }

            // for(int y=0; y< numbers.Count; y++){
            //     Sum += numbers[y];
            // }

            System.Console.WriteLine("Total: " + Sum);

            NoReturns();
        }

        void NoReturns(){
            System.Console.WriteLine("Test");

            string Name = "Efren";
            int Age = 99;
            bool Found = false;
            float F = 123.12f;
            decimal D = 123.123m;

            string [] Names = new string[10];

            Names[0] = "asdasd";
            Names[1] = "231";
            Names[6] = "fhfds";

            List<string> list = new List<string>();

            list.Add("asdkjsdlasd");

            System.Console.WriteLine("From Array:" + Names[0]);
            System.Console.WriteLine("From List:" + list[0]);

        }

        string FullName(string First, string Last){
            return First + " " + Last;
        }

        int Test(){
            Console.WriteLine("First Method");
            return 1;
        }
    }
}
