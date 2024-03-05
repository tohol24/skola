using System;
using System.Windows.Forms;

namespace FormsApp
{
    public partial class Form1 : Form
    {
        int STB = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new System.Uri("https://www.gymvod.cz/", System.UriKind.Absolute); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new System.Uri("https://cibulka.net/\r\n", System.UriKind.Absolute); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new System.Uri(" https://spd.cz/\r\n", System.UriKind.Absolute); 

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Hide();
            Random random = new Random();
            STB = random.Next(5000,120000) ;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Show();
            Random randomVolba = new Random();
            int volba = randomVolba.Next(1,3);
            switch (volba)
            {
                case 1:
                    STB -= 1;
                    label3.Text="Ubyl jeden estébák";
                    break;
                case 2:
                    STB += 1;
                    label3.Text = "Přibyl jeden estébák";
                    break;
            }
            label2.Text = STB.ToString();
            label2.Refresh();
        }
    }
}
