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

            float[] fee = {0,0,0};
            string sFee = Console.ReadLine();
            if (sFee is not null)
            {
                int i = 0;
                foreach (var el in sFee.Split())
                {
                    fee[i] = Convert.ToSingle(el);
                    i++;
                }
            }


            //Display


        }

        private List<float> CalcPrice(Product product, int shopLevel, int[] fee)
        {
            List<float> Price = new List<float>();

            float pCost = product.PersonalCost;
            float bCost = product.b2bCost;
            switch (shopLevel)
            {
                case 0:
                    pCost *= 0.95f;
                    bCost *= 0.95f;
                    break;
                case 1:
                    pCost *= 0.90f;
                    bCost *= 0.90f;
                    break;
                case 2:
                    pCost *= 0.85f;
                    bCost *= 0.85f;
                    break;
            }

            Price.AddRange(new float[] {pCost, bCost, pCost, bCost});
            switch (product.Cat)
            {
                case 0:
                    Price[0] *= 0.95f;
                    Price[1] *= 0.98f;
                    Price[2] *= 0.94f;
                    Price[3] *= 0.97f;
                    break;
                case 1:
                    Price[0] *= 0.93f;
                    Price[1] *= 0.96f;
                    Price[2] *= 0.93f;
                    Price[3] *= 0.95f;
                    break;
                case 2:
                    Price[0] *= 0.90f;
                    Price[1] *= 0.95f;
                    Price[2] *= 0.89f;
                    Price[3] *= 0.94f;
                    break;
            }
            
            Price.AddRange(new float[] {Price[2] * 0.95f, Price[3]* 0.98f, Price[3] * 0.97f, Price[3] * 0.95f});
            Price[3] = Price[2] * 0.97f;
            Price[2] *= 0.98f;
            for (int i = 0; i < Price.Count; i++)
            {
                Price[i] += fee[product.Cat];
            }
            

            return Price;
        }
    }
}