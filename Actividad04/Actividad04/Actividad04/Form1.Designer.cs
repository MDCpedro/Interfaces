namespace Actividad04
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
            label1 = new Label();
            label2 = new Label();
            contadorText = new Label();
            suma1 = new Label();
            label5 = new Label();
            label8 = new Label();
            label11 = new Label();
            label14 = new Label();
            label16 = new Label();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            numericUpDown4 = new NumericUpDown();
            resta1 = new Label();
            suma2 = new Label();
            multip1 = new Label();
            division1 = new Label();
            resta2 = new Label();
            multip2 = new Label();
            division2 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            button1 = new Button();
            botonReinicio = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(292, 23);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "Calculman";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(290, 85);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 1;
            label2.Text = "Time Left";
            // 
            // contadorText
            // 
            contadorText.AutoSize = true;
            contadorText.Font = new Font("Segoe UI", 14F);
            contadorText.ForeColor = Color.Black;
            contadorText.Location = new Point(302, 109);
            contadorText.Name = "contadorText";
            contadorText.Size = new Size(32, 25);
            contadorText.TabIndex = 2;
            contadorText.Text = "60";
            contadorText.Click += label3_Click;
            // 
            // suma1
            // 
            suma1.AutoSize = true;
            suma1.Font = new Font("SF Pro Text", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            suma1.Location = new Point(198, 177);
            suma1.Name = "suma1";
            suma1.Size = new Size(20, 23);
            suma1.TabIndex = 3;
            suma1.Text = "?";
            suma1.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SF Pro Text", 12F, FontStyle.Bold);
            label5.Location = new Point(237, 177);
            label5.Name = "label5";
            label5.Size = new Size(20, 19);
            label5.TabIndex = 4;
            label5.Text = "+";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("SF Pro Text", 12F, FontStyle.Bold);
            label8.Location = new Point(237, 231);
            label8.Name = "label8";
            label8.Size = new Size(17, 19);
            label8.TabIndex = 7;
            label8.Text = "-";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("SF Pro Text", 12F, FontStyle.Bold);
            label11.Location = new Point(236, 276);
            label11.Name = "label11";
            label11.Size = new Size(18, 19);
            label11.TabIndex = 10;
            label11.Text = "x";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("SF Pro Text", 12F, FontStyle.Bold);
            label14.Location = new Point(237, 317);
            label14.Name = "label14";
            label14.Size = new Size(14, 19);
            label14.TabIndex = 13;
            label14.Text = "/";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("SF Pro Text", 12F, FontStyle.Bold);
            label16.Location = new Point(319, 180);
            label16.Name = "label16";
            label16.Size = new Size(20, 19);
            label16.TabIndex = 15;
            label16.Text = "=";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(362, 178);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 19;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(362, 231);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 20;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(362, 277);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(120, 23);
            numericUpDown3.TabIndex = 21;
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(362, 320);
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(120, 23);
            numericUpDown4.TabIndex = 22;
            // 
            // resta1
            // 
            resta1.AutoSize = true;
            resta1.Font = new Font("SF Pro Text", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resta1.Location = new Point(198, 227);
            resta1.Name = "resta1";
            resta1.Size = new Size(20, 23);
            resta1.TabIndex = 23;
            resta1.Text = "?";
            // 
            // suma2
            // 
            suma2.AutoSize = true;
            suma2.Font = new Font("SF Pro Text", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            suma2.Location = new Point(278, 177);
            suma2.Name = "suma2";
            suma2.Size = new Size(20, 23);
            suma2.TabIndex = 24;
            suma2.Text = "?";
            suma2.Click += label7_Click;
            // 
            // multip1
            // 
            multip1.AutoSize = true;
            multip1.Font = new Font("SF Pro Text", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            multip1.Location = new Point(198, 272);
            multip1.Name = "multip1";
            multip1.Size = new Size(20, 23);
            multip1.TabIndex = 25;
            multip1.Text = "?";
            // 
            // division1
            // 
            division1.AutoSize = true;
            division1.Font = new Font("SF Pro Text", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            division1.Location = new Point(198, 316);
            division1.Name = "division1";
            division1.Size = new Size(20, 23);
            division1.TabIndex = 26;
            division1.Text = "?";
            division1.Click += label10_Click;
            // 
            // resta2
            // 
            resta2.AutoSize = true;
            resta2.Font = new Font("SF Pro Text", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resta2.Location = new Point(278, 227);
            resta2.Name = "resta2";
            resta2.Size = new Size(20, 23);
            resta2.TabIndex = 27;
            resta2.Text = "?";
            // 
            // multip2
            // 
            multip2.AutoSize = true;
            multip2.Font = new Font("SF Pro Text", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            multip2.Location = new Point(278, 271);
            multip2.Name = "multip2";
            multip2.Size = new Size(20, 23);
            multip2.TabIndex = 28;
            multip2.Text = "?";
            // 
            // division2
            // 
            division2.AutoSize = true;
            division2.Font = new Font("SF Pro Text", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            division2.Location = new Point(278, 314);
            division2.Name = "division2";
            division2.Size = new Size(20, 23);
            division2.TabIndex = 29;
            division2.Text = "?";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("SF Pro Text", 12F, FontStyle.Bold);
            label17.Location = new Point(319, 231);
            label17.Name = "label17";
            label17.Size = new Size(20, 19);
            label17.TabIndex = 30;
            label17.Text = "=";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("SF Pro Text", 12F, FontStyle.Bold);
            label18.Location = new Point(319, 276);
            label18.Name = "label18";
            label18.Size = new Size(20, 19);
            label18.TabIndex = 31;
            label18.Text = "=";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("SF Pro Text", 12F, FontStyle.Bold);
            label19.Location = new Point(319, 317);
            label19.Name = "label19";
            label19.Size = new Size(20, 19);
            label19.TabIndex = 32;
            label19.Text = "=";
            // 
            // button1
            // 
            button1.Location = new Point(286, 41);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 33;
            button1.Text = "Empezar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // botonReinicio
            // 
            botonReinicio.Enabled = false;
            botonReinicio.Location = new Point(286, 388);
            botonReinicio.Name = "botonReinicio";
            botonReinicio.Size = new Size(75, 23);
            botonReinicio.TabIndex = 34;
            botonReinicio.Text = "Reiniciar";
            botonReinicio.UseVisualStyleBackColor = true;
            botonReinicio.Click += botonReinicio_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 450);
            Controls.Add(botonReinicio);
            Controls.Add(button1);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(division2);
            Controls.Add(multip2);
            Controls.Add(resta2);
            Controls.Add(division1);
            Controls.Add(multip1);
            Controls.Add(suma2);
            Controls.Add(resta1);
            Controls.Add(numericUpDown4);
            Controls.Add(numericUpDown3);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(label16);
            Controls.Add(label14);
            Controls.Add(label11);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(suma1);
            Controls.Add(contadorText);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label contadorText;
        private Label suma1;
        private Label label5;
        private Label label8;
        private Label label11;
        private Label label14;
        private Label label16;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown4;
        private Label resta1;
        private Label suma2;
        private Label multip1;
        private Label division1;
        private Label resta2;
        private Label multip2;
        private Label division2;
        private Label label17;
        private Label label18;
        private Label label19;
        private Button button1;
        private Button botonReinicio;
    }
}
