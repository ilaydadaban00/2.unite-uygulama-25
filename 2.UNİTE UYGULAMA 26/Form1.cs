using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2.UNİTE_UYGULAMA_26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            for(int  i = 0; i < 5; i++)
            {
                double kuvvet=Math.Pow(10,i);
                listBox1.Items.Add(kuvvet);
            }
        }
    }
}
