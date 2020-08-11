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


namespace ChronometerSocket
{
    public partial class Form1 : Form
    {


        Stopwatch stopWatch = new Stopwatch(); 
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtMiliseconds_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            stopWatch.Reset();


            txtMiliseconds.Text = "000";
            txtMinutes.Text = "00";
            txtSeconds.Text = "00";

            timer1.Enabled = false;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            stopWatch.Start();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = new TimeSpan(0,0,0,0,(int)stopWatch.ElapsedMilliseconds);

            txtMiliseconds.Text = ts.Milliseconds.ToString();
            txtSeconds.Text = ts.Seconds.ToString().Length < 2 ? "0" + ts.Seconds.ToString() : ts.Seconds.ToString();
            txtMinutes.Text = ts.Minutes.ToString().Length < 2 ? "0" + ts.Minutes.ToString() : ts.Seconds.ToString();
            txtHours.Text = ts.Hours.ToString().Length < 2 ? "0" + ts.Hours.ToString() : ts.Hours.ToString();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            stopWatch.Stop();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
