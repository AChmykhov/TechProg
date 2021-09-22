using System;

// Classwork 22.09
namespace Classwork
{
    public class Classwork1
    {
        public static void Task1()
        {
            //lab1 task 1
            Console.WriteLine("Enter your gender: ");
            var g = Console.ReadLine();
            Console.WriteLine("Enter your height: ");
            var h = Convert.ToInt32(Console.ReadLine());
            if (g == "M")
            {
                Console.WriteLine((h - 100) * 1.15);
            }
            else
            {
                Console.WriteLine((h - 110) * 1.15);
            }
        }

        public static void Task2()
        {
            //lab1 task 2
            var s = Console.ReadLine();
            var l = s.Length;
            string res = "";
            for (int i = 0; i < l; i++)
            {
                res = s[i] + res;
            }

            Console.WriteLine(res);
        }

        public static void Task3()
        {
            //lab0 task 3
            for (int z = 1; z < 10; z++)
            {
                for (int t = 0; t < 10; t++)
                {
                    for (int y = 0; y < 10; y++)
                    {
                        for (int r = 1; r < 10; r++)
                        {
                            for (int s = 1; s < 10; s++)
                            {
                                var a = z * 100 + t * 10 + y;
                                var b = r * 1001 + z * 100 + y * 10;
                                var c = s * 1000 + z * 101 + r * 10;
                                if (a + b == c)
                                {
                                    Console.WriteLine($"z = {z}, t = {t}, y = {y}, r = {r}, s = {s}, {a}+{b}={c}");
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Task4()
        {
            //lab0 task 2
            var x = Convert.ToDouble(Console.ReadLine());
            var y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine((1.0 - x / y) * 100);
        }

        public static void Task5()
        {
            // guess number
            Random rnd = new Random();
            var x = rnd.Next(1, 101);
            var n = 5;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Guess number 1 - 100");
                var a = Convert.ToInt32(Console.ReadLine());
                var c = n - 1 - i;
                if (a == n)
                {
                    Console.WriteLine("Excellent!");
                    break;
                }

                if (a > n)
                {
                    Console.WriteLine($"It's less then your guess. Numbers of tries left: {c}");
                    break;
                }

                if (a < n)
                {
                    Console.WriteLine($"It's greater then your guess. Numbers of tries left: {c}");
                    break;
                }
            }
        }

        public static void Task6()
        {
            //lab1 num 3
            Console.WriteLine("enter array max");
            int arrLen = int.Parse(Console.ReadLine());
            int[] arr = new int[arrLen];
            for (int i = 0; i < arrLen; i++)
            {
                var number = int.Parse(Console.ReadLine());
                arr[i] = number;
            }
            Console.WriteLine(IsThreeInLine(arr) ? "найдено" : "не найдено");
        }

        static bool IsThreeInLine(int[] arr)
        {
            bool res = false;
            for (int i = 2; i < arr.Length; i++)
            {
                res = arr[i - 2] + 1 == arr[i - 1] && arr[i - 1] + 1 == arr[i];
            }

            return res;
        }

        public static void Task7()
        {
            Console.WriteLine("enter array max");
            int arrLen = int.Parse(Console.ReadLine());
            int[] arr = new int[arrLen];
            for (int i = 0; i < arrLen; i++)
            {
                var number = int.Parse(Console.ReadLine());
                arr[i] = number;
            }
            
        }

        static int SumExcept(int[] arr)
        {
            int summ = 0;
            var i1 = Array.FindIndex(arr, item => item == 6);
            var i2 = Array.FindIndex(arr, item => item == 7);
            if (i1 != -1 && i2 != -1)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (!(i >= i1 && i <= i2))
                    {
                        summ += arr[i];
                    }
                }

                return summ;
            }

            
            return -1;
        }

        public static void Task8()
        {
            // lab1 ex 5
            var size = 1195;
            var res = 1;
            for (int i = 3; i <= size; i += 2)
            {
                res += 4 * i * i - 6 * (i - 1);
            }

            Console.WriteLine(res);
        }
        
    }
}