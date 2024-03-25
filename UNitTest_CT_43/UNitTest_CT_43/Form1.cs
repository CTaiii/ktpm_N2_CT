using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNitTest_CT_43
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, kq;
            a = int.Parse(tb1.Text);
            b = int.Parse(tb2.Text);
            Calc_CT_43 c = new Calc_CT_43(a, b);
            kq = c.X_CT_43("+");
            tb3.Text = kq.ToString();
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            int a, b, kq;
            a = int.Parse(tb1.Text);
            b = int.Parse(tb2.Text);
            Calc_CT_43 c = new Calc_CT_43(a, b);
            kq = c.X_CT_43("-");
            tb3.Text = kq.ToString();
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            int a, b, kq;
            a = int.Parse(tb1.Text);
            b = int.Parse(tb2.Text);
            Calc_CT_43 c = new Calc_CT_43(a, b);
            kq = c.X_CT_43("*");
            tb3.Text = kq.ToString();
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            int a, b, kq;
            a = int.Parse(tb1.Text);
            b = int.Parse(tb2.Text);
            Calc_CT_43 c = new Calc_CT_43(a, b);
            kq = c.X_CT_43("/");
            tb3.Text = kq.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb3_TextChanged(object sender, EventArgs e)
        {

        }

      
    }
}
