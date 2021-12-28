using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;

namespace Classwork
{
    public class Zachet
    {
        private const string Glas = "уеыаоэяиюёЁУЕЫАОЭЯИЮeyuioaEYUIOA";

        public struct Human
        {
            public string Name;
            public string Surname;
            public string SecName;
            public string Adress;
            public string email;
            public string Tel;
            public DateTime DR;
            public int Num;

            public void Print()
            {
                Console.WriteLine(
                    $"{this.Surname} {this.Name} {this.SecName}\n\tNumber: {this.Num}\n\tDate of birth: {this.DR}\n\t Address: {this.Adress}\n\tEmail: {this.email}");
            }

            public Human(string name, string surname, string secName, string adress, string email, string tel,
                DateTime dr, int num)
            {
                Name = name;
                Surname = surname;
                SecName = secName;
                Adress = adress;
                this.email = email;
                DR = dr;
                Num = num;
                this.Tel = tel;
            }
        }

        public static void Task1()
        {
            var s = Console.ReadLine()!.ToLower();
            string res = "";
            foreach (var ch in s)
            {
                if (Glas.IndexOf(ch) != -1)
                {
                    res = res + ch.ToString().ToUpper() + ch.ToString().ToUpper();
                }
                else
                {
                    res = res + ch.ToString();
                }
            }

            Console.WriteLine(res);
        }

        public static void Task2()
        {
            List<Human> people = new List<Human>();
            
            people.Add(new Human("Alex", "Test1", "Test1", "Test1", "Test@test.org", "+78004346789",
                new DateTime(2003, 10, 08), 10));
            people.Add(new Human("Alexa", "Test2", "Test1", "Test1", "Test@test.org", "+78004346789",
                new DateTime(2003, 01, 08), 10));
            people.Add(new Human("Alexы", "Test3", "Test1", "Test1", "Test@test.org", "+78004346789",
                new DateTime(2003, 05, 08), 10));
            people.Add(new Human("Alexe", "Test4", "Test1", "Test1", "Test@test.org", "+78004346789",
                new DateTime(2003, 12, 08), 10));
            people.Add(new Human("AlexМ", "Test5", "Test1", "Test1", "Test@test.org", "+78004346789",
                new DateTime(2003, 11, 08), 10));
            foreach (var human in people)
            {
                if (Glas.IndexOf(human.Name[^1]) != -1)
                {
                    human.Print();
                }
            }
        }

        public static void Task3()
        {
            var month = Console.ReadLine()!.Split();
            var d = new DateTime(Convert.ToInt32(month[1]), Convert.ToInt32(month[0]), 01);
            Console.WriteLine(d.DayOfWeek);
        }
    }
}