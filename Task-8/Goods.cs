using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Task_8
{
    public class Goods
    {
        private string name;
        private string cost;
        private string quantity;
        private string region;

        public void GetGood(string[] name, string[] cost, string[] quantity, string[] region)
        {
            Random rnd = new Random();
            
            this.name = name[rnd.Next(0, name.Length - 1)];
            this.cost = cost[rnd.Next(0, cost.Length - 1)];
            this.quantity = quantity[rnd.Next(0, quantity.Length - 1)];
            this.region = region[rnd.Next(0, region.Length - 1)];
        }

        public string GetTextGood(object good)
        {
            string text = $"\"{this.name}\" ({this.region}) - {this.quantity} штук\r\n";
            return text;
        }

        public string GetTextCost(object good)
        {
            string text = $"{this.cost}\r\n";
            return text;
        }
    }
}