using System;
using System.Collections.Generic;

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
            public float Personal_cost;
            public float b2b_cost;

            public Product(string name, string type, int cat, List<string> pars, float personalCost, float b2bCost)
            {
                this.Name = name;
                this.Type = type;
                this.Cat = cat;
                this.Params = pars;
                this.Personal_cost = personalCost;
                this.b2b_cost = b2bCost;
            }
        }

        struct Shop
        {
            public string Name;
            public List<List<Product>> Racks;
        }

        public void PopulateAndCalc()
        {
            int num_shops = Convert.ToInt32(Console.ReadLine());

            List<Shop> shops = new List<Shop> ();
            for (int i = 0; i < num_shops; i++)
            {
                Shop tmp = new Shop();
                tmp.Name = Console.ReadLine();
                
            }
        }
    }
}