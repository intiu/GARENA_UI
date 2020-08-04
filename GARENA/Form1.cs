using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace GARENA
{
    public partial class Form1 : Form
    {
        private int ImageNumber = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Slider()
        {
            if (ImageNumber == 5)
            {
                ImageNumber = 1;
            }
            pictureBox1.ImageLocation = string.Format(@"Images\{0}.jpg", ImageNumber);
            ImageNumber++;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Slider();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var a1 = new ProcessStartInfo("msedge.exe");
            a1.Arguments = "https://napthe.vn/info/smsotp";
            Process.Start(a1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            var a2 = new ProcessStartInfo("msedge.exe");
            a2.Arguments = "https://sso.garena.com/ui/register?redirect_uri=https%3A%2F%2Fsso.garena.com%2Fui%2Flogin%3Fapp_id%3D10100%26redirect_uri%3Dhttps%253A%252F%252Faccount.garena.com%252F%253Flocale_name%253DVN%26locale%3Dvi-VN&locale=vi-VN";
            Process.Start(a2);
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            var a3 = new ProcessStartInfo("msedge.exe");
            a3.Arguments = "https://account.garena.com/recovery#/";
            Process.Start(a3);
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            /*if (!panel4.Controls.Contains(UCNgonngu.Instance))
            {
                panel4.Controls.Add(UCNgonngu.Instance);
                UCNgonngu.Instance.Dock = DockStyle.Fill;
                UCNgonngu.Instance.BringToFront();
            }
            else
                UCNgonngu.Instance.BringToFront();*/
        }
    }
}
