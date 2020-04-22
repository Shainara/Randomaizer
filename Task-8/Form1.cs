using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Task_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEat_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int idx = random.Next(1, 3);
            string fileName = "dbEat.xml";
            GenerateGood(fileName, idx);
        }

        private void btnMetal_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int idx = random.Next(1, 7);
            string fileName = "dbMetal.xml";
            GenerateGood(fileName, idx);
        }

        private void btnTools_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int idx = random.Next(1, 4);
            string fileName = "dbTool.xml";
            GenerateGood(fileName, idx);
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int idx = random.Next(1, 6);
            string fileName = "dbItem.xml";
            GenerateGood(fileName, idx);
        }

        private void GenerateGood(string fileName, int idx)
        {
            Repository group = new Repository();
            group.LoadDB(fileName);
            string[] name = group.GetName(idx - 1);
            string[] cost = group.GetCost(idx - 1);
            string[] quantity = group.GetQuantity(idx - 1);
            string[] region = group.GetRegion(idx - 1);
            
            Goods good = new Goods();
            good.GetGood(name, cost, quantity, region);
            tbGoods.Text += good.GetTextGood(good);
            tbCost.Text += good.GetTextCost(good);
        }

        private void btmClear_Click(object sender, EventArgs e)
        {
            tbGoods.Clear();
            tbCost.Clear();
        }
    }
}