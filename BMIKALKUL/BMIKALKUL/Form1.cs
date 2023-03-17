using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMIKALKUL
{
    public partial class Form1 : Form
    {
        float i;
        float z, x;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pb1.BorderStyle = BorderStyle.FixedSingle;
            pb1.BackColor = Color.LightGray;

            pb2.BorderStyle = BorderStyle.None;
            pb2.BackColor = Color.WhiteSmoke;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            rost.Text = null;
            ves.Text = null;
            verh.Text = null;
            zna.Text = null;
            trackBar1.Value = 0;
            pb1.BorderStyle = BorderStyle.None;
            pb1.BackColor = Color.WhiteSmoke;
            pb2.BorderStyle = BorderStyle.None;
            pb2.BackColor = Color.WhiteSmoke;
            pb3.Visible = false;
            pb4.Visible = true;
            pb5.Visible = false;
            pb6.Visible = false;

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void pb2_Click(object sender, EventArgs e)
        {
            pb2.BorderStyle = BorderStyle.FixedSingle;
            pb2.BackColor = Color.LightGray;

            pb1.BorderStyle = BorderStyle.None;
            pb1.BackColor = Color.WhiteSmoke;
        }

        private void pb6_Click(object sender, EventArgs e)
        {

        }

        private void pb4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            x = float.Parse(rost.Text);
            z = float.Parse(ves.Text);
            x /= 100;
            i = z / (x * x);
            verh.Text = i.ToString();
            trackBar1.Value = (int)i;
            pb3.Visible = false;
            pb4.Visible = false;
            pb5.Visible = false;
            pb6.Visible = false;

            if (i < 18.5)
            {
                pb3.Visible = true;
                zna.Text = "Недостаточный вес";
            }

            if (i >= 18.5 && i <= 24.9)
            {
                pb4.Visible = true;
                zna.Text = "Здоровый вес";
            }


            if (i >= 25 && i < 29.9)
            {
                pb5.Visible = true;
                zna.Text = "Избыточный вес";
            }


            if (i >= 30)
            {
                pb6.Visible = true;
                zna.Text = "Ожирение";
            }
        }
    }
}
