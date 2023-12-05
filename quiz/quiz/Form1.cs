using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> notlar = new List<int>();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            notlar.Clear();
            Random rnd = new Random();
            for (int i = 1; i <= 38; i++)
            {
                notlar.Add(rnd.Next(0, 101));
            }
            listBox1.DataSource = notlar.ToList();
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

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
