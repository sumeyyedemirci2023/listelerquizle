using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datagredwiev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Ogrenci ogrenci;
        private void Form1_Load(object sender, EventArgs e)
        {
            List<Ogrenci> ogrenciListe = new list<Ogrenci>();


            ogrenciListe.Add(new Ogrenci(56, "kevser Ramazanoğlu,10/A,54425454145"));
            ogrenciListe.Add(new Ogrenci(65, "medine kanat.10/A,574334534534367"));
        }
    }
}
