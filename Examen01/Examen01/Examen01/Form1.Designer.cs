namespace Examen01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tituloHabana = new Label();
            infoPersona = new Label();
            nombrePersona = new Label();
            telefonoPersona = new Label();
            campoNombre = new TextBox();
            campoTelefono = new TextBox();
            contadorHoraEvent = new NumericUpDown();
            horeEvento = new Label();
            eventoTipo = new Label();
            eventoTipoCombo = new ComboBox();
            infoEvento = new Label();
            numPersonasEvento = new Label();
            contadorPersonas = new NumericUpDown();
            tipoCocinaEvento = new Label();
            cocinaEventoCombo = new ComboBox();
            infoCongreso = new Label();
            numJornadas = new Label();
            numJornadasContador = new NumericUpDown();
            checkBoxHabitaciones = new CheckBox();
            infoBanquete = new Label();
            tipoMesa = new Label();
            comensalesMesa = new Label();
            tipoMesaCombo = new ComboBox();
            comensalesMesaContador = new NumericUpDown();
            panelPersona = new Panel();
            panelEvento = new Panel();
            panelCongreso = new Panel();
            panelBanquete = new Panel();
            ((System.ComponentModel.ISupportInitialize)contadorHoraEvent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)contadorPersonas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numJornadasContador).BeginInit();
            ((System.ComponentModel.ISupportInitialize)comensalesMesaContador).BeginInit();
            panelCongreso.SuspendLayout();
            SuspendLayout();
            // 
            // tituloHabana
            // 
            tituloHabana.AutoSize = true;
            tituloHabana.Font = new Font("SF Pro Text", 18F, FontStyle.Bold);
            tituloHabana.Location = new Point(288, 26);
            tituloHabana.Name = "tituloHabana";
            tituloHabana.Size = new Size(176, 29);
            tituloHabana.TabIndex = 0;
            tituloHabana.Text = "Salon Habana";
            // 
            // infoPersona
            // 
            infoPersona.AutoSize = true;
            infoPersona.Font = new Font("SF Pro Text", 12F, FontStyle.Bold);
            infoPersona.Location = new Point(58, 96);
            infoPersona.Name = "infoPersona";
            infoPersona.Size = new Size(170, 19);
            infoPersona.TabIndex = 1;
            infoPersona.Text = "Persona que reserva";
            // 
            // nombrePersona
            // 
            nombrePersona.AutoSize = true;
            nombrePersona.Font = new Font("SF Pro Text", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nombrePersona.Location = new Point(38, 135);
            nombrePersona.Name = "nombrePersona";
            nombrePersona.Size = new Size(54, 14);
            nombrePersona.TabIndex = 2;
            nombrePersona.Text = "Nombre";
            // 
            // telefonoPersona
            // 
            telefonoPersona.AutoSize = true;
            telefonoPersona.Font = new Font("SF Pro Text", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            telefonoPersona.Location = new Point(37, 177);
            telefonoPersona.Name = "telefonoPersona";
            telefonoPersona.Size = new Size(57, 14);
            telefonoPersona.TabIndex = 3;
            telefonoPersona.Text = "Telefono";
            // 
            // campoNombre
            // 
            campoNombre.Location = new Point(99, 132);
            campoNombre.Name = "campoNombre";
            campoNombre.Size = new Size(100, 23);
            campoNombre.TabIndex = 4;
            // 
            // campoTelefono
            // 
            campoTelefono.Location = new Point(99, 174);
            campoTelefono.Name = "campoTelefono";
            campoTelefono.Size = new Size(100, 23);
            campoTelefono.TabIndex = 5;
            // 
            // contadorHoraEvent
            // 
            contadorHoraEvent.Location = new Point(346, 142);
            contadorHoraEvent.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            contadorHoraEvent.Name = "contadorHoraEvent";
            contadorHoraEvent.Size = new Size(43, 23);
            contadorHoraEvent.TabIndex = 6;
            contadorHoraEvent.Tag = "";
            contadorHoraEvent.ThousandsSeparator = true;
            contadorHoraEvent.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // horeEvento
            // 
            horeEvento.AutoSize = true;
            horeEvento.Font = new Font("SF Pro Text", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            horeEvento.Location = new Point(305, 144);
            horeEvento.Name = "horeEvento";
            horeEvento.Size = new Size(35, 14);
            horeEvento.TabIndex = 7;
            horeEvento.Text = "Hora";
            // 
            // eventoTipo
            // 
            eventoTipo.AutoSize = true;
            eventoTipo.Font = new Font("SF Pro Text", 9F);
            eventoTipo.Location = new Point(305, 185);
            eventoTipo.Name = "eventoTipo";
            eventoTipo.Size = new Size(94, 14);
            eventoTipo.TabIndex = 8;
            eventoTipo.Text = "Tipo de evento";
            eventoTipo.Click += label6_Click;
            // 
            // eventoTipoCombo
            // 
            eventoTipoCombo.FormattingEnabled = true;
            eventoTipoCombo.Items.AddRange(new object[] { "banquete", "jornada", "congreso" });
            eventoTipoCombo.Location = new Point(305, 203);
            eventoTipoCombo.Name = "eventoTipoCombo";
            eventoTipoCombo.Size = new Size(121, 23);
            eventoTipoCombo.TabIndex = 9;
            eventoTipoCombo.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // infoEvento
            // 
            infoEvento.AutoSize = true;
            infoEvento.Font = new Font("SF Pro Text", 12F, FontStyle.Bold);
            infoEvento.Location = new Point(288, 96);
            infoEvento.Name = "infoEvento";
            infoEvento.Size = new Size(188, 19);
            infoEvento.TabIndex = 10;
            infoEvento.Text = "Informacion del evento";
            // 
            // numPersonasEvento
            // 
            numPersonasEvento.AutoSize = true;
            numPersonasEvento.Font = new Font("SF Pro Text", 9F);
            numPersonasEvento.Location = new Point(305, 250);
            numPersonasEvento.Name = "numPersonasEvento";
            numPersonasEvento.Size = new Size(110, 14);
            numPersonasEvento.TabIndex = 11;
            numPersonasEvento.Text = "Num de Personas";
            // 
            // contadorPersonas
            // 
            contadorPersonas.Location = new Point(305, 268);
            contadorPersonas.Name = "contadorPersonas";
            contadorPersonas.Size = new Size(120, 23);
            contadorPersonas.TabIndex = 12;
            // 
            // tipoCocinaEvento
            // 
            tipoCocinaEvento.AutoSize = true;
            tipoCocinaEvento.Font = new Font("SF Pro Text", 9F);
            tipoCocinaEvento.Location = new Point(305, 312);
            tipoCocinaEvento.Name = "tipoCocinaEvento";
            tipoCocinaEvento.Size = new Size(92, 14);
            tipoCocinaEvento.TabIndex = 13;
            tipoCocinaEvento.Text = "Tipo de cocina";
            // 
            // cocinaEventoCombo
            // 
            cocinaEventoCombo.FormattingEnabled = true;
            cocinaEventoCombo.Items.AddRange(new object[] { "bufé", "carta", "pedir cita a chef", "no precisa" });
            cocinaEventoCombo.Location = new Point(305, 330);
            cocinaEventoCombo.Name = "cocinaEventoCombo";
            cocinaEventoCombo.Size = new Size(121, 23);
            cocinaEventoCombo.TabIndex = 14;
            // 
            // infoCongreso
            // 
            infoCongreso.AutoSize = true;
            infoCongreso.Enabled = false;
            infoCongreso.Font = new Font("SF Pro Text", 12F, FontStyle.Bold);
            infoCongreso.Location = new Point(25, 20);
            infoCongreso.Name = "infoCongreso";
            infoCongreso.Size = new Size(185, 19);
            infoCongreso.TabIndex = 15;
            infoCongreso.Text = "Informacion Congreso";
            // 
            // numJornadas
            // 
            numJornadas.AutoSize = true;
            numJornadas.Enabled = false;
            numJornadas.Font = new Font("SF Pro Text", 9F);
            numJornadas.Location = new Point(24, 53);
            numJornadas.Name = "numJornadas";
            numJornadas.Size = new Size(92, 14);
            numJornadas.TabIndex = 16;
            numJornadas.Text = "Num Jornadas";
            // 
            // numJornadasContador
            // 
            numJornadasContador.Enabled = false;
            numJornadasContador.Location = new Point(117, 50);
            numJornadasContador.Name = "numJornadasContador";
            numJornadasContador.Size = new Size(44, 23);
            numJornadasContador.TabIndex = 18;
            // 
            // checkBoxHabitaciones
            // 
            checkBoxHabitaciones.AutoSize = true;
            checkBoxHabitaciones.Enabled = false;
            checkBoxHabitaciones.Font = new Font("SF Pro Text", 9F);
            checkBoxHabitaciones.Location = new Point(25, 83);
            checkBoxHabitaciones.Name = "checkBoxHabitaciones";
            checkBoxHabitaciones.Size = new Size(198, 18);
            checkBoxHabitaciones.TabIndex = 19;
            checkBoxHabitaciones.Text = "Habitaciones para asistentes";
            checkBoxHabitaciones.UseVisualStyleBackColor = true;
            // 
            // infoBanquete
            // 
            infoBanquete.AutoSize = true;
            infoBanquete.Enabled = false;
            infoBanquete.Font = new Font("SF Pro Text", 12F, FontStyle.Bold);
            infoBanquete.Location = new Point(532, 245);
            infoBanquete.Name = "infoBanquete";
            infoBanquete.Size = new Size(182, 19);
            infoBanquete.TabIndex = 20;
            infoBanquete.Text = "Informacion Banquete";
            // 
            // tipoMesa
            // 
            tipoMesa.AutoSize = true;
            tipoMesa.Enabled = false;
            tipoMesa.Font = new Font("SF Pro Text", 9F);
            tipoMesa.Location = new Point(532, 288);
            tipoMesa.Name = "tipoMesa";
            tipoMesa.Size = new Size(68, 14);
            tipoMesa.TabIndex = 21;
            tipoMesa.Text = "Tipo mesa";
            // 
            // comensalesMesa
            // 
            comensalesMesa.AutoSize = true;
            comensalesMesa.Enabled = false;
            comensalesMesa.Font = new Font("SF Pro Text", 9F);
            comensalesMesa.Location = new Point(533, 324);
            comensalesMesa.Name = "comensalesMesa";
            comensalesMesa.Size = new Size(137, 14);
            comensalesMesa.TabIndex = 22;
            comensalesMesa.Text = "Comensales por mesa";
            // 
            // tipoMesaCombo
            // 
            tipoMesaCombo.Enabled = false;
            tipoMesaCombo.FormattingEnabled = true;
            tipoMesaCombo.Items.AddRange(new object[] { "Rectangular", "Redonda" });
            tipoMesaCombo.Location = new Point(602, 285);
            tipoMesaCombo.Name = "tipoMesaCombo";
            tipoMesaCombo.Size = new Size(121, 23);
            tipoMesaCombo.TabIndex = 23;
            // 
            // comensalesMesaContador
            // 
            comensalesMesaContador.Enabled = false;
            comensalesMesaContador.Location = new Point(676, 321);
            comensalesMesaContador.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            comensalesMesaContador.Name = "comensalesMesaContador";
            comensalesMesaContador.Size = new Size(47, 23);
            comensalesMesaContador.TabIndex = 24;
            // 
            // panelPersona
            // 
            panelPersona.Location = new Point(28, 79);
            panelPersona.Name = "panelPersona";
            panelPersona.Size = new Size(227, 147);
            panelPersona.TabIndex = 25;
            // 
            // panelEvento
            // 
            panelEvento.Location = new Point(264, 79);
            panelEvento.Name = "panelEvento";
            panelEvento.Size = new Size(233, 302);
            panelEvento.TabIndex = 26;
            // 
            // panelCongreso
            // 
            panelCongreso.Controls.Add(checkBoxHabitaciones);
            panelCongreso.Controls.Add(infoCongreso);
            panelCongreso.Controls.Add(numJornadas);
            panelCongreso.Controls.Add(numJornadasContador);
            panelCongreso.Location = new Point(508, 79);
            panelCongreso.Name = "panelCongreso";
            panelCongreso.Size = new Size(246, 128);
            panelCongreso.TabIndex = 27;
            // 
            // panelBanquete
            // 
            panelBanquete.Location = new Point(508, 226);
            panelBanquete.Name = "panelBanquete";
            panelBanquete.Size = new Size(246, 155);
            panelBanquete.TabIndex = 28;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comensalesMesaContador);
            Controls.Add(tipoMesaCombo);
            Controls.Add(comensalesMesa);
            Controls.Add(tipoMesa);
            Controls.Add(infoBanquete);
            Controls.Add(cocinaEventoCombo);
            Controls.Add(tipoCocinaEvento);
            Controls.Add(contadorPersonas);
            Controls.Add(numPersonasEvento);
            Controls.Add(infoEvento);
            Controls.Add(eventoTipoCombo);
            Controls.Add(eventoTipo);
            Controls.Add(horeEvento);
            Controls.Add(contadorHoraEvent);
            Controls.Add(campoTelefono);
            Controls.Add(campoNombre);
            Controls.Add(telefonoPersona);
            Controls.Add(nombrePersona);
            Controls.Add(infoPersona);
            Controls.Add(tituloHabana);
            Controls.Add(panelPersona);
            Controls.Add(panelEvento);
            Controls.Add(panelCongreso);
            Controls.Add(panelBanquete);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)contadorHoraEvent).EndInit();
            ((System.ComponentModel.ISupportInitialize)contadorPersonas).EndInit();
            ((System.ComponentModel.ISupportInitialize)numJornadasContador).EndInit();
            ((System.ComponentModel.ISupportInitialize)comensalesMesaContador).EndInit();
            panelCongreso.ResumeLayout(false);
            panelCongreso.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tituloHabana;
        private Label infoPersona;
        private Label nombrePersona;
        private Label telefonoPersona;
        private TextBox campoNombre;
        private TextBox campoTelefono;
        private NumericUpDown contadorHoraEvent;
        private Label horeEvento;
        private Label eventoTipo;
        private ComboBox eventoTipoCombo;
        private Label infoEvento;
        private Label numPersonasEvento;
        private NumericUpDown contadorPersonas;
        private Label tipoCocinaEvento;
        private ComboBox cocinaEventoCombo;
        private Label infoCongreso;
        private Label numJornadas;
        private NumericUpDown numJornadasContador;
        private CheckBox checkBoxHabitaciones;
        private Label infoBanquete;
        private Label tipoMesa;
        private Label comensalesMesa;
        private ComboBox tipoMesaCombo;
        private NumericUpDown comensalesMesaContador;
        private Panel panelPersona;
        private Panel panelEvento;
        private Panel panelCongreso;
        private Panel panelBanquete;
    }
}
