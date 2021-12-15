using System;

namespace Classwork
{
    public class Classwork3
    {
        static char[] alp =
        {
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u',
            'v', 'w', 'x', 'y', 'z'
        };

        static char[] spec = {'#', '@', '?', '!'};
        static char[] dig = {'1', '2', '3', '4', '5', '6', '7', '8', '9', '0'};
        static Random random = new Random();
        static string[] local = {"com", "org", "ru", "de", "us", "net"};

        static char[] alp_sog =
        {
            'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'z'
        };

        static char[] alp2_gla = {'a', 'e', 'i', 'o', 'u', 'y'};


        public static string Task1(int _min = 8, int _max = 33)
        {
            int count = random.Next(_min, _max);
            string result = "";

            for (int i = 0; i < count; i++)
            {
                switch (random.Next(0, 3))
                {
                    case 0:
                        result += random.Next(0, 2) % 2 == 0
                            ? alp[random.Next(0, alp.Length - 1)]
                            : char.ToUpper(alp[random.Next(0, alp.Length - 1)]);
                        break;
                    case 1:
                        result += spec[random.Next(0, spec.Length - 1)];
                        break;
                    case 2:
                        result += dig[random.Next(0, dig.Length - 1)];
                        break;
                }
            }

            return result;
        }

        static string Task2()
        {
            string name = GenString(random.Next(5, 11));
            string domen = GenString(random.Next(3, 7));
            string _local = local[random.Next(0, local.Length - 1)];
            return $"{name}@{domen}.{_local}";
        }

        static string GenString(int count)
        {
            string result = "";
            for (int i = 0; i < count; i++)
            {
                if (i % 2 == 0) result += alp_sog[random.Next(0, alp_sog.Length - 1)];
                else result += alp2_gla[random.Next(0, alp2_gla.Length - 1)];
            }

            return result;
        }
    }
}