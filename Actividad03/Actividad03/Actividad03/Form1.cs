namespace Actividad03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String nombre = textBox1.Text;
                String apellido = textBox2.Text;
                String nombre_completo = nombre + " " + apellido;
                int contador;

                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Porfavor, selecciona un tipo de usuario valido");
                    return;
                }

                String tipo = comboBox1.SelectedItem.ToString();

                if (String.IsNullOrEmpty(nombre) || String.IsNullOrEmpty(apellido))
                {
                    MessageBox.Show("Ingresa algun valor en Nombre o Apellido");
                }
                else
                {
                    switch (tipo)
                    {
                        case "Administrador":
                            listBox1.Items.Add(nombre_completo);
                            contador = int.Parse(contadorAdmin.ToString()+1);
                            contadorAdmin.Text = contador.ToString();
                            textBox1.Clear();
                            textBox2.Clear();
                            break;

                        case "Usuario":
                            listBox2.Items.Add(nombre_completo);
                            textBox1.Clear();
                            textBox2.Clear();
                            break;
                    }
                }
            }
            catch (Exception er)
            {
                er.GetBaseException();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
