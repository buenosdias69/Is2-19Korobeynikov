using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_1
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Zad_4 j = new Zad_4();
            j.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zad_1 j = new Zad_1();
            j.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Zad_2 j = new Zad_2();
            j.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Zad_3 j = new Zad_3();
            j.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Zad_5 j = new Zad_5();
            j.Show();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
