using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Map
{
    public partial class TretiuStart : Form
    {
        public TretiuStart()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chekpoint1_Click(object sender, EventArgs e)
        {
            Naimenovanie.Text = "Checkpoint 1";
            Nazvanie.Text = "MCK Luzniki";
            PictureDrinks.Visible = true; NadpisDrink.Visible = true;
            PictureEnergyBars.Visible = true; NadpisEnergyBars.Visible = true;
            PictureToilets.Visible = false; NadpisToilets.Visible = false;
            PictureInf.Visible = false; NadpisInf.Visible = false;
            PictureMedical.Visible = false; NadpisMedical.Visible = false;
        }

        private void chekpoint2_Click(object sender, EventArgs e)
        {
            Naimenovanie.Text = "Checkpoint 2";
            Nazvanie.Text = "Novodevichie Monostur";
            PictureDrinks.Visible = true; NadpisDrink.Visible = true;
            PictureEnergyBars.Visible = true; NadpisEnergyBars.Visible = true;
            PictureToilets.Visible = true; NadpisToilets.Visible = true;
            PictureInf.Visible = true; NadpisInf.Visible = true;
            PictureMedical.Visible = true; NadpisMedical.Visible = true;
        }

        private void chekpoint3_Click(object sender, EventArgs e)
        {
            Naimenovanie.Text = "Checkpoint 3";
            Nazvanie.Text = "Metro Kievskay";
            PictureDrinks.Visible = true; NadpisDrink.Visible = true;
            PictureEnergyBars.Visible = true; NadpisEnergyBars.Visible = true;
            PictureToilets.Visible = true; NadpisToilets.Visible = true;
            PictureInf.Visible = false; NadpisInf.Visible = false;
            PictureMedical.Visible = false; NadpisMedical.Visible = false;
        }

        private void chekpoint4_Click(object sender, EventArgs e)
        {
            Naimenovanie.Text = "Checkpoint 4";
            Nazvanie.Text = "MID";
            PictureDrinks.Visible = true; NadpisDrink.Visible = true;
            PictureEnergyBars.Visible = true; NadpisEnergyBars.Visible = true;
            PictureToilets.Visible = true; NadpisToilets.Visible = true;
            PictureInf.Visible = false; NadpisInf.Visible = false;
            PictureMedical.Visible = true; NadpisMedical.Visible = true;
        }

        private void chekpoint5_Click(object sender, EventArgs e)
        {
            Naimenovanie.Text = "Checkpoint 5";
            Nazvanie.Text = "Park Gorkogo";
            PictureDrinks.Visible = true; NadpisDrink.Visible = true;
            PictureEnergyBars.Visible = true; NadpisEnergyBars.Visible = true;
            PictureToilets.Visible = true; NadpisToilets.Visible = true;
            PictureInf.Visible = true; NadpisInf.Visible = true;
            PictureMedical.Visible = false; NadpisMedical.Visible = false;
        }

        private void chekpoint6_Click(object sender, EventArgs e)
        {
            Naimenovanie.Text = "Checkpoint 6";
            Nazvanie.Text = "Zdanie RAN";
            PictureDrinks.Visible = true; NadpisDrink.Visible = true;
            PictureEnergyBars.Visible = true; NadpisEnergyBars.Visible = true;
            PictureToilets.Visible = true; NadpisToilets.Visible = true;
            PictureInf.Visible = false; NadpisInf.Visible = false;
            PictureMedical.Visible = false; NadpisMedical.Visible = false;
        }

        private void chekpoint7_Click(object sender, EventArgs e)
        {
            Naimenovanie.Text = "Checkpoint 7";
            Nazvanie.Text = "Metro Vorobiovy gori";
            PictureDrinks.Visible = true; NadpisDrink.Visible = true;
            PictureEnergyBars.Visible = true; NadpisEnergyBars.Visible = true;
            PictureToilets.Visible = true; NadpisToilets.Visible = true;
            PictureInf.Visible = true; NadpisInf.Visible = true;
            PictureMedical.Visible = true; NadpisMedical.Visible = true;
        }

        private void chekpoint8_Click(object sender, EventArgs e)
        {
            Naimenovanie.Text = "Checkpoint 8";
            Nazvanie.Text = "Stadion Luzniki";
            PictureDrinks.Visible = true; NadpisDrink.Visible = true;
            PictureEnergyBars.Visible = true; NadpisEnergyBars.Visible = true;
            PictureToilets.Visible = true; NadpisToilets.Visible = true;
            PictureInf.Visible = true; NadpisInf.Visible = true;
            PictureMedical.Visible = true; NadpisMedical.Visible = true;
        }

        private void PervuyStart_Click(object sender, EventArgs e)
        {
            Naimenovanie.Text = "Race Start";
            Nazvanie.Text = "Samba Full Marathone";
            PictureDrinks.Visible = false; NadpisDrink.Visible = false;
            PictureEnergyBars.Visible = false; NadpisEnergyBars.Visible = false;
            PictureToilets.Visible = false; NadpisToilets.Visible = false;
            PictureInf.Visible = false; NadpisInf.Visible = false;
            PictureMedical.Visible = false; NadpisMedical.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Naimenovanie.Text = "Race Start";
            Nazvanie.Text = "Capoeira 5km Fun Run";
            PictureDrinks.Visible = false; NadpisDrink.Visible = false;
            PictureEnergyBars.Visible = false; NadpisEnergyBars.Visible = false;
            PictureToilets.Visible = false; NadpisToilets.Visible = false;
            PictureInf.Visible = false; NadpisInf.Visible = false;
            PictureMedical.Visible = false; NadpisMedical.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Naimenovanie.Text = "Race Start";
            Nazvanie.Text = "Jongo Half Marathone";
            PictureDrinks.Visible = false; NadpisDrink.Visible = false;
            PictureEnergyBars.Visible = false; NadpisEnergyBars.Visible = false;
            PictureToilets.Visible = false; NadpisToilets.Visible = false;
            PictureInf.Visible = false; NadpisInf.Visible = false;
            PictureMedical.Visible = false; NadpisMedical.Visible = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Naimenovanie.Text = "Race Start";
            Nazvanie.Text = "Samba Full Marathone";
            PictureDrinks.Visible = false; NadpisDrink.Visible = false;
            PictureEnergyBars.Visible = false; NadpisEnergyBars.Visible = false;
            PictureToilets.Visible = false; NadpisToilets.Visible = false;
            PictureInf.Visible = false; NadpisInf.Visible = false;
            PictureMedical.Visible = false; NadpisMedical.Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Naimenovanie.Text = "Race Start";
            Nazvanie.Text = "Jongo Half MarathoneCapoeira 5km Fun Run";
            PictureDrinks.Visible = false; NadpisDrink.Visible = false;
            PictureEnergyBars.Visible = false; NadpisEnergyBars.Visible = false;
            PictureToilets.Visible = false; NadpisToilets.Visible = false;
            PictureInf.Visible = false; NadpisInf.Visible = false;
            PictureMedical.Visible = false; NadpisMedical.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Naimenovanie.Text = "Race Start";
            Nazvanie.Text = "Capoeira 5km Fun Run";
            PictureDrinks.Visible = false; NadpisDrink.Visible = false;
            PictureEnergyBars.Visible = false; NadpisEnergyBars.Visible = false;
            PictureToilets.Visible = false; NadpisToilets.Visible = false;
            PictureInf.Visible = false; NadpisInf.Visible = false;
            PictureMedical.Visible = false; NadpisMedical.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Naimenovanie.Text = "Finish";
            Nazvanie.Visible = false;
            PictureDrinks.Visible = false; NadpisDrink.Visible = false;
            PictureEnergyBars.Visible = false; NadpisEnergyBars.Visible = false;
            PictureToilets.Visible = false; NadpisToilets.Visible = false;
            PictureInf.Visible = false; NadpisInf.Visible = false;
            PictureMedical.Visible = false; NadpisMedical.Visible = false;
        }
    }
}
