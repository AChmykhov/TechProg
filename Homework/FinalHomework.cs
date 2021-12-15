using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Homework
{
    public class FinalHomework
    {
        struct Product
        {
            public string Name;
            public string Type;
            public int Cat;
            public List<string> Params;
            public float PersonalCost;
            public float b2bCost;

            public Product(string name, string type, int cat, List<string> pars, float personalCost, float b2bCost)
            {
                this.Name = name;
                this.Type = type;
                this.Cat = cat;
                this.Params = pars;
                this.PersonalCost = personalCost;
                this.b2bCost = b2bCost;
            }
        }

        struct Shop
        {
            public string Name;
            public int Level;
            public List<List<Product>> Racks;
        }

        public void PopulateAndCalc()
        {
            
            List<Shop> shops = new List<Shop>();

            
            // Populate
            /*
             * Формат ввода:
             * Число_магазинов
             *      Имя_магазина Уровень_магазина Число_стоек
             *          Число_товаров
             *              Строка_товара
             */
            int numShops = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numShops; i++)
            {
                Shop tmp = new Shop();
                string[] str = Console.ReadLine()!.Split();
                tmp.Name = str[0];
                tmp.Level = Convert.ToInt32(str[1]);
                int numRacks = Convert.ToInt32(str[2]);
                tmp.Racks = new List<List<Product>>();
                for (int j = 0; j < numRacks; j++)
                {
                    List<Product> currRack = new List<Product>();
                    int numProducts = Convert.ToInt32(Console.ReadLine());
                    for (int k = 0; k < numProducts; k++)
                    {
                        string[] s = Console.ReadLine()!.Split();
                        currRack.Add(new Product(s[0], s[1], Convert.ToInt32(s[2]), s[3].Split('_').ToList(),
                            Convert.ToSingle(s[4]), Convert.ToSingle(s[5])));
                    }

                    tmp.Racks.Add(currRack);
                }
                shops.Add(tmp);
            }
            
            //Display
            
        }
    }
}