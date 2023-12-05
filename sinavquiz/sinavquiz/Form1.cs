using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinavquiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> notlar = new List<int>();
        private void button1_Click(object sender, EventArgs e)
        {
            List<int> notlar = new List<int>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            notlar.Sort();
            listBox1.DataSource = notlar.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            notlar.Sort();
            notlar.Reverse();

            listBox1.DataSource = notlar.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (notlar.Contains(100) == true)
            {
                MessageBox.Show("100 alan öğrenci var.");
            }
            else
            {
                MessageBox.Show("100 alan öğrenci yok.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int gecenSayisi = 0;
            for (int i = 0; i < notlar.Count; i++)
            {
                if (notlar[i] >= 50)
                {
                    gecenSayisi++;
                }
            }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
    }
}
