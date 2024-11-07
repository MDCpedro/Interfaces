namespace Actividad01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String numhorasST = textBox1.Text;
                int numhoras = int.Parse(numhorasST);

                String costohoraST = textBox2.Text;
                float costohora = float.Parse(costohoraST);


                float sueldototal = numhoras * costohora;
                label5.Text = sueldototal+ " €";
                Refresh();
            }
            catch (Exception ex)
            {
                label5.Text = "Error (Valores incompatibles)";
            }

        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
