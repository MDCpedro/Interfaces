namespace Examen01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String seleccion = eventoTipoCombo.SelectedItem.ToString();

            if (seleccion.Equals("banquete"))
            {
                banqueteToggle(true);

                congresoToggle(false);
            }
            else if (seleccion.Equals("congreso"))
            {
                congresoToggle(true);

                banqueteToggle(false);
            }
            else if (seleccion.Equals("jornada"))
            {
                banqueteToggle(false);

                congresoToggle(false);
            }
        }

        private void banqueteToggle(Boolean toggle)
        {
            infoBanquete.Enabled = toggle;
            tipoMesa.Enabled = toggle;
            tipoMesaCombo.Enabled = toggle;
            comensalesMesa.Enabled = toggle;
            comensalesMesaContador.Enabled = toggle;
        }

        private void congresoToggle(Boolean toggle)
        {
            infoCongreso.Enabled = toggle;
            numJornadas.Enabled = toggle;
            numJornadasContador.Enabled = toggle;
            checkBoxHabitaciones.Enabled = toggle;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
