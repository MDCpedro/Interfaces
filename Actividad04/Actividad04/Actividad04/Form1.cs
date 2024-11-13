namespace Actividad04
{
    using System;
    using System.Threading;

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private static int contador = 5;
        private static Timer temporizador;
        private static Random numRandom;

        private void button1_Click(object sender, EventArgs e)
        {
            botonReinicio.Enabled = false;
            button1.Enabled = false;
            temporizador = new Timer(ActualizarContador, null, 0, 1000);
            numerosAleatorio(sender, e);
        }

        private void ActualizarContador(object state)
        {
            if (contador > 1)
            {
                contador--;
                contadorText.BeginInvoke((Action)(() =>
                    contadorText.Text = contador.ToString()));
            }
            else
            {
                temporizador.Dispose();
                contadorText.BeginInvoke((Action)(() =>
                {
                    contadorText.Text = "Se acabó!";
                    contadorText.ForeColor = Color.Red;
                    botonReinicio.Enabled = true;
                }));
            }
        }

        private void botonReinicio_Click(object sender, EventArgs e)
        {
            contador = 60;
            button1.Enabled = true;
            contadorText.ForeColor = Color.Black;
            contadorText.BeginInvoke(new Action(() =>
            {
                contadorText.Text = "60";
            }));
        }

        private void numerosAleatorio(object sender, EventArgs e) 
        {
            numRandom = new Random();
            suma1.Text = numRandom.Next(0, 300).ToString();
            suma2.Text = numRandom.Next(0, 300).ToString();
            
            multip1.Text = numRandom.Next(0, 300).ToString();
            multip2.Text = numRandom.Next(0, 300).ToString();

            int numResta1 = numRandom.Next(0, 300);
            int numResta2 = numRandom.Next(0, 300);
            resta1.Text = Math.Max(numResta1, numResta2).ToString();
            resta2.Text = Math.Min(numResta1, numResta2).ToString();

            int numDiv1 = numRandom.Next(0, 300);
            int numDiv2 = numRandom.Next(0, 300);
            division1.Text = Math.Max(numDiv1, numDiv2).ToString();
            division2.Text = Math.Min(numDiv1, numDiv2).ToString();

        }
    }
}
