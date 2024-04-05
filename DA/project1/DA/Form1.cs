using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ficha2
{
    public partial class Form1 : Form
    {
        private DateTime contadorTempo;
        private DateTime contadorMiliseconds;

        private Boolean isRunning;

        public Form1()
        {
            contadorTempo = new DateTime(0);
            contadorMiliseconds = new DateTime(0);

            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelHora.Text = DateTime.Now.ToLongTimeString();

           // contadorTempo = contadorTempo.Add(new TimeSpan(0, 0, 1));

            contadorTempo.ToString("HH:mm:ss:fff");

            toolStripStatusLabelContador.Text = contadorTempo.ToLongTimeString();
        }

        private void buttonToggleTimer(object sender, EventArgs e)
        {
            if (isRunning)
            {
                button1.Text = "Start";
                label1.Text = "Tempo parado";
                timer1.Stop();
                isRunning = false;
            }
            else
            {
                button1.Text = "Stop";
                label1.Text = "Tempo decorrendo";
                timer1.Start();
                isRunning = true;
            }
        }
        private void buttonReset(object sender, EventArgs e)
        {
            contadorTempo = new DateTime(0);
            toolStripStatusLabelContador.Text = contadorTempo.ToString("HH:mm:ss:fff");
        }

        
        private void timerMiliseconds_Tick(object sender, EventArgs e)
        {
            contadorTempo = contadorTempo.Add(new TimeSpan(0, 0, 0, 0, timerMiliseconds.Interval));

            toolStripStatusLabelContador.Text = contadorTempo.ToString("HH:mm:ss:fff");
        }
    }
}
