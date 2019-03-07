using System;

namespace Sandbox
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line
            //int [] tal = new int[5];
            //tal[0] = 10;
            //tal[1] = 2;
            //tal[2] = -5;
            //tal[3] = 17;
            //tal[4] = 25;

            int[] tal = new int[] {10, 2, -5, 17, 25, 32, 45};
            int mitTal = tal[3];
            //Console.WriteLine($"På plads 3 ligger {tal[3]}");
            //int pl = tal[5];

            string[] navne = new string[]  {"Vibeke", "Mohammed", "Peter" };

            Student [] students = new Student[]{ new Student("Peter"), new Student("Vibeke")};

            Console.WriteLine("For loop");
            for (int i = 0; i < tal.Length; i++)
            {
                Console.WriteLine( tal[i]);
            }

            Console.WriteLine("While loop");
            int j = 0;
            while (j < tal.Length)
            {
                Console.WriteLine(tal[j]);
                j++;
            }

            Console.WriteLine("Foreach");

            //Læber hele tabellen igennem
            foreach (int value in tal)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine("Udskriv range fra index 2 til 4");
            int k = 2;
            while (k <= 4)
            {
                Console.WriteLine(tal[k]);
                k++;
            }

            Console.WriteLine("Udskriv tabel bagfra");
            for (int i = tal.Length-1; i >= 0; i--)
            {
                Console.WriteLine(tal[i]);   
            }



            //Console.WriteLine("Hello world!");

            // The LAST line of code should be ABOVE this line
        }
    }

    
}