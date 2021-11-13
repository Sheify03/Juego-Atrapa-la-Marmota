using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }
        int N = 0;
        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start(); //inicia el timer
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //metodo tick del timer a 100 milisegundo = 0.2 segundos
            N = N + 1; //contador
            label2.Text = N.ToString();
            progressBar1.Value = N; //valor para el progresbar

            if (N==100) //el valor maximo del preogresbar es de 100
            {
                timer1.Stop(); //detiene el timer para que se detenga el contador

                this.Hide();
                Form1 formu1 = new Form1();
                formu1.ShowDialog();
            }
        }
    }
}
