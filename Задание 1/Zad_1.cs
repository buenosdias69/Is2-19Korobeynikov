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
    public partial class Zad_1 : Form
    {
        public Zad_1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         

        }

        private static void label3_Click(object sender, EventArgs e)
        {

        }
        abstract class Accessories<k>
        {
            protected string price;
            protected string year;
            protected string articyl;
            public Accessories(string Price1, string Year1, string Articyl1)
            {
                price = Price1;
                year = Year1;
                articyl = Articyl1;
            }
            public abstract void Display(ListBox listBox);
        }
        class Cpu : Accessories<string>
        {
            public string chastota1;
            public string yadro1;
            public string potoki1;
            public Cpu(string Price1, string Year1, string Articyl1, string chastota1, string yadro1, string potoki1)
            : base(Price1, Year1, Articyl1)
            {
                chastota = chastota1;
                yadro = yadro1;
                potoki = potoki1;
            }
            public string chastota { get { return chastota1; } set { chastota1 = value; } }
            public string yadro { get { return yadro1; } set { yadro1 = value; } }
            public string potoki { get { return potoki1; } set { potoki1 = value; } }
            public override void Display(ListBox listBox1)
            {
                listBox1.Items.Add($"Цена {price}, Год выпуска {year}, Частота {chastota}, Количество ядер {yadro}, Количество потоков {potoki}, Артикул {articyl}");
            }
        }
        class Videocard : Accessories<string>
        {
            public string chastotaGPU1;
            public string proizvod1;
            public string pam1;
            public Videocard(string Price1, string Year1, string Articyl1, string chastotaGPU1, string proizvod1, string pam1)
            : base(Price1, Year1, Articyl1)
            {
                chastotaGPU = chastotaGPU1;
                proizvod = proizvod1;
                pam = pam1;
            }
            public string chastotaGPU { get { return chastotaGPU1; } set { chastotaGPU1 = value; } }
            public string proizvod { get { return proizvod1; } set { proizvod1 = value; } }
            public string pam { get { return pam1; } set { pam1 = value; } }
            public override void Display(ListBox listBox1)
            {
                listBox1.Items.Add($"Цена {price}, Год выпуска {year}, Частота процессора  {chastotaGPU}, Производительность {proizvod}, Объем памяти {pam}, Артикул {articyl}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string prise = Convert.ToString(textBox1.Text);
            string year = Convert.ToString(textBox2.Text);
            string chastota = Convert.ToString(textBox3.Text);
            string yadro = Convert.ToString(textBox4.Text);
            string potoki = Convert.ToString(textBox5.Text);
            string aticyl = Convert.ToString(textBox6.Text);
            Cpu cp1 = new Cpu(prise, year, aticyl, chastota, yadro, potoki);
            cp1.Display(listBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string prise = Convert.ToString(textBox1.Text);
            string year = Convert.ToString(textBox2.Text);
            string chastotaGPU = Convert.ToString(textBox3.Text);
            string proizvod = Convert.ToString(textBox4.Text);
            string pam = Convert.ToString(textBox5.Text);
            string articyl = Convert.ToString(textBox6.Text);
            Videocard vd1 = new Videocard(prise, year, articyl, chastotaGPU, proizvod, pam);
            vd1.Display(listBox1);
        }
    }
}
