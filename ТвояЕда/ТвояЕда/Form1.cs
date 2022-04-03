using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ТвояЕда
{
    public partial class Form1 : Form
    {
        public List<string> products = new List<string>();
        public void ClientMethod(Burger factory)
        {
            var productA = factory.CreateProductA();
            var productB = factory.CreateProductB();
            var productC = factory.CreateProductC();
            var productD = factory.CreateProductD();
            var productE = factory.CreateProductE();

            products.Add(productA);
            products.Add(productB);
            products.Add(productC);
            products.Add(productD);
            products.Add(productE); 
        }
        public void ClientMain(Burger factory)
        {
            textBox1.Clear();
            products.Clear();
            ClientMethod(factory);

            for (int i = 0; i < products.Count; i++)
            {
                textBox1.Text += Convert.ToString(products[i]) + Environment.NewLine;
            }
        }
        public Form1() => InitializeComponent();

        private void button1_Click(object sender, EventArgs e) => ClientMain(new SqrHumburger());
        private void button2_Click(object sender, EventArgs e) => ClientMain(new RoundHumburger());
        private void button3_Click(object sender, EventArgs e) => ClientMain(new BigMac());
        private void button4_Click(object sender, EventArgs e) => ClientMain(new TexasBurger());
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = "Приятного вам аппетита!";
        }
    }
}
