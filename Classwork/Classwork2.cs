using System;

namespace Classwork
{
    public class Classwork2
    {
        public static void Task1()
        {
            Random rnd = new Random();
            int l = rnd.Next(3, 10);
            int[] arr = new int[l];
            for (int i = 0; i < l; i++)
            {
                arr[i] = i % 2;
            }
        }

        public static void Task2()
        {
            Random rnd = new Random();
            int l = rnd.Next(3, 10);
            int[] arr = new int[l];
            for (int i = 0; i < l; i++)
            {
                arr[i] = i * i;
            }
        }

        public static void Task3()
        {
            Random rnd = new Random();
            int l = rnd.Next(3, 10);
            int[] arr = new int[l * 3];
            int c = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 3 == 0)
                {
                    c = rnd.Next(1, 1000);
                }

                arr[i] = c;
            }
        }

        public static void Task4()
        {
            Random rnd = new Random();
            int l = rnd.Next(3, 10);
            int[] arr = new int[l];
            int[] indx = {rnd.Next(0, l), rnd.Next(0, l)};
            while (indx[0] == indx[1])
            {
                indx[1] = rnd.Next(0, l);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (Array.Find(indx, el => el == i) > -1)
                {
                    arr[i] = 1;
                }
                else
                {
                    arr[i] = rnd.Next(2, 100);
                }
            }
        }

        public static void Task5()
        {
            Random rnd = new Random();
            int l = rnd.Next(1, 20);
            int[] arr = new int[l];
            int[] count = {0, 0};
            for (int i = 0; i < l; i++)
            {
                int c = rnd.Next(1, 101) % 2;
                arr[i] = c;
                count[c] += 1;
            }

            while (count[1] <= count[0])
            {
                arr[Array.Find(arr, item => item == 0)] = 1;
            }
        }

        public static void Task6()
        {
            Random rnd = new Random();
            int l = rnd.Next(1, 20);
            int[] arr = new int[l];
            int count = 0;
            for (int i = 0; i < l; i++)
            {
                int c = rnd.Next(1, 101);
                arr[i] = c;
                count += c % 2;
            }

            Console.WriteLine(count);
        }

        public static void Task7()
        {
            Random rnd = new Random();
            int l = rnd.Next(1, 20);
            int[] arr = new int[l];
            int count = 0;
            for (int i = 0; i < l; i++)
            {
                int c = rnd.Next(1, 101);
                arr[i] = c;
                count += (c % 3 == 0 && c % 7 != 0) ? 1 : 0;
            }

            Console.WriteLine(count);
        }

        public static void Task8()
        {
            Random rnd = new Random();
            int l = rnd.Next(1, 20);
            int[] arr = new int[l];
            int[] count = {0, 0};
            for (int i = 0; i < l; i++)
            {
                int c = rnd.Next(1, 101);
                arr[i] = c;
            }

            foreach (var i in arr)
            {
                if (i % arr[0] == 0)
                {
                    count[0] += 1;
                }

                if (i % arr[^1] == 0)
                {
                    count[1] += 1;
                }
            }

            Console.WriteLine(count[0] > count[1] ? "первый" : "второй");
        }

        public static void Task9()
        {
            Random rnd = new Random();
            int l = rnd.Next(1, 20);
            int[] arr = new int[l];
            int count = 0;
            for (int i = 0; i < l; i++)
            {
                int c = rnd.Next(1, 101);
                arr[i] = c;
                count += (c % 2 == 0) ? 1 : 0;
            }

            Console.WriteLine(count);
        }

        public static void Task10()
        {
            Random rnd = new Random();
            int l = rnd.Next(1, 20);
            int[] arr = new int[l];
            int count = 0;
            for (int i = 0; i < l; i++)
            {
                int c = rnd.Next(1, 101);
                arr[i] = c;
                count += (c % 2 != 0) ? 1 : 0;
            }

            Console.WriteLine(count);
        }

        public static void Task11()
        {
            Random rnd = new Random();
            int l = rnd.Next(1, 20);
            int[] arr = new int[l];
            int count = 0;
            for (int i = 0; i < l; i++)
            {
                int c = rnd.Next(1, 101);
                arr[i] = c;
                count += (i % 2 == 0) ? c : 0;
            }

            Console.WriteLine(count);
        }

        public static void Task12()
        {
            Random rnd = new Random();
            int l = rnd.Next(1, 20);
            int[] arr = new int[l];
            int count = 0;
            for (int i = 0; i < l; i++)
            {
                int c = rnd.Next(1, 101);
                arr[i] = c;
                count += (c == 0) ? 1 : 0;
            }

            if (count == arr.Length)
            {
                Console.WriteLine(arr.Length);
            }
            else
            {
                if(count == arr.Length - 1)
                {
                    Console.WriteLine(1);
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }

        public static void Task13()
        {
            Random rnd = new Random();
            int l = rnd.Next(1, 20);
            int[] arr = new int[l];
            bool count = false;
            for (int i = 0; i < l; i++)
            {
                int c = rnd.Next(1, 101);
                arr[i] = c;
            }

            for (int i = 0; i > arr.Length + 1; i++)
            {
                if (Array.Find(arr, item => item == i) > -1)
                {
                    count = true;
                }
                else
                {
                    count = false;
                    break;
                }
            }

            Console.WriteLine(count);
        }
    }
}