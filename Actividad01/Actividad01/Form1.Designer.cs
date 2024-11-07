namespace Actividad01
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(275, 308);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SF Pro Text", 12F);
            label1.Location = new Point(206, 151);
            label1.Name = "label1";
            label1.Size = new Size(97, 19);
            label1.TabIndex = 1;
            label1.Text = "Num Horas";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SF Pro Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(206, 197);
            label2.Name = "label2";
            label2.Size = new Size(98, 19);
            label2.TabIndex = 2;
            label2.Text = "Costo Hora";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SF Pro Text", 24F, FontStyle.Bold);
            label3.Location = new Point(132, 81);
            label3.Name = "label3";
            label3.Size = new Size(369, 38);
            label3.TabIndex = 3;
            label3.Text = "Calculadora de Sueldo";
            label3.Click += label3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(311, 151);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(311, 199);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SF Pro Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(233, 250);
            label4.Name = "label4";
            label4.Size = new Size(68, 19);
            label4.TabIndex = 6;
            label4.Text = "Sueldo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SF Pro Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(311, 250);
            label5.Name = "label5";
            label5.Size = new Size(20, 19);
            label5.TabIndex = 7;
            label5.Text = "0";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("SF Pro Text", 8F, FontStyle.Bold);
            label6.Location = new Point(332, 225);
            label6.Name = "label6";
            label6.Size = new Size(61, 13);
            label6.TabIndex = 8;
            label6.Text = "utilizar \",\"";
            label6.Click += label6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(626, 446);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
