using System;
using System.Collections.Generic;

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

            tal[4] = 0;
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

            Console.WriteLine("Udskrivning af navne tabellen vha. for");
            for (int i = 0; i < navne.Length; i++)
            {
                Console.WriteLine($"På index {i} ligger {navne[i]}");
            }
            Console.WriteLine("Udskrivning af navne tabellen vha. while");

            int t = 0;
            while (t<navne.Length)
            {
                Console.WriteLine($"På index {t} ligger {navne[t]}");
                t++;
            }
            Console.WriteLine("Udskrivning af navne tabellen vha. foreach");

            int h = 0;
            foreach (string value in navne)
            {
                Console.WriteLine($"På index {h} ligger {value}");
                h++;
            }

            //Udskriv alle navne i Students
            Console.WriteLine("Udskriv alle navne i Students");
            foreach (Student student in students)
            {
                Console.WriteLine(student.Navn);
            }

            //Erklæring af en List
            List<int> myList = new List<int>();
            myList.Add(123);
            myList.Add(56);
            myList.Add(99);
            myList.Add(95);
            myList.Add(19);

            myList.Insert(2,45);

            myList.RemoveAt(3);
            myList[2] = 77;
            Console.WriteLine("Udskrivning af Liste vha. for");
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine($"På index {i} ligger {myList[i]}");
            }

            //myList.Sort();
            //myList.Reverse();

            Console.WriteLine("Udskrivning af Liste vha. foreach efter sortering");
            foreach (int value in myList)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine("Udskrivning af Liste vha. for efter sortering ");
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine($"På index {i} ligger {myList[i]}");
            }


            //Find et tal i listen
            int searchTal = 95;
            int l = 0;
            bool found = false;
            while (!found && l< myList.Count)
            {
                //searchTal == myList
                if (searchTal  == myList[l])
                {
                    found = true;
                    //break;
                }
                l++;
             
            }

            if (found)
            {
                Console.WriteLine("Ja tallet findes i listen");
            }
            



            //Console.WriteLine("Hello world!");

            // The LAST line of code should be ABOVE this line
        }
    }

    
}