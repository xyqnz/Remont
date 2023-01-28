using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsApp1
{

    public partial class F_Menu : System.Windows.Forms.Form
    {
       

        public F_Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Exit(object sender, EventArgs e)
        {
            Close();
        }

        private void OpenSotr(object sender, EventArgs e)
        {
            Form2 f1 = new Form2();
            f1.ShowDialog();           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void OpenPriceList(object sender, EventArgs e)
        {
            Form3 f2 = new Form3();
            f2.ShowDialog();
        }

        private void ремонтToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void автомобилиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f3 = new Form4();
            f3.ShowDialog();
        }

        private void списокСотрудниковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f4 = new Form5();
            f4.ShowDialog();
        }

        private void выполнениеУслугЗаПериодToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f5 = new Form6();
            f5.ShowDialog();
        }

        private void рейтингУслугToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 f6 = new Form7();
            f6.ShowDialog();
        }
    }
}
