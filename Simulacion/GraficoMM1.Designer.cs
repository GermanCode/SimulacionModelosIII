using System.Windows.Forms;

namespace Simulacion
{
    partial class GraficoMM1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            Label1 = new System.Windows.Forms.Label();
            Label2 = new System.Windows.Forms.Label();
            Label3 = new System.Windows.Forms.Label();
            TextBox1 = new System.Windows.Forms.TextBox();
            TextBox2 = new System.Windows.Forms.TextBox();
            TextBox3 = new System.Windows.Forms.TextBox();
            TextBox4 = new System.Windows.Forms.TextBox();
            Label4 = new System.Windows.Forms.Label();
            Label5 = new System.Windows.Forms.Label();
            Label6 = new System.Windows.Forms.Label();
            Label7 = new System.Windows.Forms.Label();
            Label8 = new System.Windows.Forms.Label();
            Label9 = new System.Windows.Forms.Label();
            TotalAbandono1 = new System.Windows.Forms.Label();
            Label11 = new System.Windows.Forms.Label();
            TmaxCola1 = new System.Windows.Forms.Label();
            TMinCola1 = new System.Windows.Forms.Label();
            TPromCola1 = new System.Windows.Forms.Label();
            TPromServ1 = new System.Windows.Forms.Label();
            TMinServ1 = new System.Windows.Forms.Label();
            TMaxServ1 = new System.Windows.Forms.Label();
            Label12 = new System.Windows.Forms.Label();
            Aband10M1 = new System.Windows.Forms.Label();
            Aband6M1 = new System.Windows.Forms.Label();
            Label10 = new System.Windows.Forms.Label();
            Label13 = new System.Windows.Forms.Label();
            TextBox5 = new System.Windows.Forms.TextBox();
            TextBox6 = new System.Windows.Forms.TextBox();
            TextBox7 = new System.Windows.Forms.TextBox();
            TextBox8 = new System.Windows.Forms.TextBox();
            Label14 = new System.Windows.Forms.Label();
            Label15 = new System.Windows.Forms.Label();
            //TextBox9 = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(24, 25);
            this.Label1.Name = "label1";
            this.Label1.Size = new System.Drawing.Size(177, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Tiempo Maximo de Espera en Cola: ";
            this.Label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(24, 71);
            this.Label2.Name = "label2";
            this.Label2.Size = new System.Drawing.Size(182, 13);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Tiempo Promedio de Espera en Cola:";
            // 
            // label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(382, 25);
            this.Label3.Name = "label3";
            this.Label3.Size = new System.Drawing.Size(73, 13);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "Inicia Servicio";
            // 
            // textBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(346, 48);
            this.TextBox1.Name = "textBox1";
            this.TextBox1.Size = new System.Drawing.Size(28, 20);
            this.TextBox1.TabIndex = 3;
            this.TextBox1.Text = "0";
            this.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(380, 48);
            this.TextBox2.Name = "textBox2";
            this.TextBox2.Size = new System.Drawing.Size(28, 20);
            this.TextBox2.TabIndex = 4;
            this.TextBox2.Text = "8";
            this.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.TextBox3.Location = new System.Drawing.Point(427, 48);
            this.TextBox3.Name = "textBox3";
            this.TextBox3.Size = new System.Drawing.Size(28, 20);
            this.TextBox3.TabIndex = 5;
            this.TextBox3.Text = "0";
            this.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.TextBox4.Location = new System.Drawing.Point(461, 48);
            this.TextBox4.Name = "textBox4";
            this.TextBox4.Size = new System.Drawing.Size(28, 20);
            this.TextBox4.TabIndex = 6;
            this.TextBox4.Text = "0";
            this.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(412, 48);
            this.Label4.Name = "label4";
            this.Label4.Size = new System.Drawing.Size(13, 20);
            this.Label4.TabIndex = 7;
            this.Label4.Text = ":";
            // 
            // label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(24, 111);
            this.Label5.Name = "label5";
            this.Label5.Size = new System.Drawing.Size(140, 13);
            this.Label5.TabIndex = 8;
            this.Label5.Text = "Tiempo Maximo de Servicio:";
            // 
            // label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(21, 136);
            this.Label6.Name = "label6";
            this.Label6.Size = new System.Drawing.Size(137, 13);
            this.Label6.TabIndex = 9;
            this.Label6.Text = "Tiempo Minimo de Servicio:";
            // 
            // label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(21, 159);
            this.Label7.Name = "label7";
            this.Label7.Size = new System.Drawing.Size(148, 13);
            this.Label7.TabIndex = 10;
            this.Label7.Text = "Tiempo Promedio de Servicio:";
            // 
            // label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(24, 200);
            this.Label8.Name = "label8";
            this.Label8.Size = new System.Drawing.Size(154, 13);
            this.Label8.TabIndex = 11;
            this.Label8.Text = "Abandonan Despues de 6 Min:";
            this.Label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(24, 225);
            this.Label9.Name = "label9";
            this.Label9.Size = new System.Drawing.Size(160, 13);
            this.Label9.TabIndex = 12;
            this.Label9.Text = "Abandonan Despues de 10 Min:";
            // 
            // TotalAbandono
            // 
            this.TotalAbandono1.AutoSize = true;
            this.TotalAbandono1.Location = new System.Drawing.Point(24, 247);
            this.TotalAbandono1.Name = "TotalAbandono";
            this.TotalAbandono1.Size = new System.Drawing.Size(86, 13);
            this.TotalAbandono1.TabIndex = 13;
            this.TotalAbandono1.Text = "Total Abandono:";
            // 
            // label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(24, 48);
            this.Label11.Name = "label11";
            this.Label11.Size = new System.Drawing.Size(171, 13);
            this.Label11.TabIndex = 14;
            this.Label11.Text = "Tiempo Minimo de Espera en Cola:";
            // 
            // TmaxCola
            // 
            this.TmaxCola1.AutoSize = true;
            this.TmaxCola1.Location = new System.Drawing.Point(227, 25);
            this.TmaxCola1.Name = "TmaxCola";
            this.TmaxCola1.Size = new System.Drawing.Size(16, 13);
            this.TmaxCola1.TabIndex = 15;
            this.TmaxCola1.Text = "...";
            // 
            // TMinCola
            // 
            this.TMinCola1.AutoSize = true;
            this.TMinCola1.Location = new System.Drawing.Point(227, 48);
            this.TMinCola1.Name = "TMinCola";
            this.TMinCola1.Size = new System.Drawing.Size(16, 13);
            this.TMinCola1.TabIndex = 16;
            this.TMinCola1.Text = "...";
            // 
            // TPromCola
            // 
            this.TPromCola1.AutoSize = true;
            this.TPromCola1.Location = new System.Drawing.Point(227, 71);
            this.TPromCola1.Name = "TPromCola";
            this.TPromCola1.Size = new System.Drawing.Size(16, 13);
            this.TPromCola1.TabIndex = 17;
            this.TPromCola1.Text = "...";
            // 
            // TPromServ
            // 
            this.TPromServ1.AutoSize = true;
            this.TPromServ1.Location = new System.Drawing.Point(227, 157);
            this.TPromServ1.Name = "TPromServ";
            this.TPromServ1.Size = new System.Drawing.Size(16, 13);
            this.TPromServ1.TabIndex = 20;
            this.TPromServ1.Text = "...";
            // 
            // TMinServ
            // 
            this.TMinServ1.AutoSize = true;
            this.TMinServ1.Location = new System.Drawing.Point(227, 134);
            this.TMinServ1.Name = "TMinServ";
            this.TMinServ1.Size = new System.Drawing.Size(16, 13);
            this.TMinServ1.TabIndex = 19;
            this.TMinServ1.Text = "...";
            // 
            // TMaxServ
            // 
            this.TMaxServ1.AutoSize = true;
            this.TMaxServ1.Location = new System.Drawing.Point(227, 111);
            this.TMaxServ1.Name = "TMaxServ";
            this.TMaxServ1.Size = new System.Drawing.Size(16, 13);
            this.TMaxServ1.TabIndex = 18;
            this.TMaxServ1.Text = "...";
            // 
            // label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(227, 246);
            this.Label12.Name = "label12";
            this.Label12.Size = new System.Drawing.Size(16, 13);
            this.Label12.TabIndex = 23;
            this.Label12.Text = "...";
            // 
            // Aband10M
            // 
            this.Aband10M1.AutoSize = true;
            this.Aband10M1.Location = new System.Drawing.Point(227, 223);
            this.Aband10M1.Name = "Aband10M";
            this.Aband10M1.Size = new System.Drawing.Size(16, 13);
            this.Aband10M1.TabIndex = 22;
            this.Aband10M1.Text = "...";
            // 
            // Aband6M
            // 
            this.Aband6M1.AutoSize = true;
            this.Aband6M1.Location = new System.Drawing.Point(227, 200);
            this.Aband6M1.Name = "Aband6M";
            this.Aband6M1.Size = new System.Drawing.Size(16, 13);
            this.Aband6M1.TabIndex = 21;
            this.Aband6M1.Text = "...";
            // 
            // label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(399, 111);
            this.Label10.Name = "label10";
            this.Label10.Size = new System.Drawing.Size(56, 13);
            this.Label10.TabIndex = 24;
            this.Label10.Text = "Inicia Cola";
            this.Label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.Location = new System.Drawing.Point(412, 133);
            this.Label13.Name = "label13";
            this.Label13.Size = new System.Drawing.Size(13, 20);
            this.Label13.TabIndex = 29;
            this.Label13.Text = ":";
            // 
            // textBox5
            // 
            this.TextBox5.Location = new System.Drawing.Point(461, 133);
            this.TextBox5.Name = "textBox5";
            this.TextBox5.Size = new System.Drawing.Size(28, 20);
            this.TextBox5.TabIndex = 28;
            this.TextBox5.Text = "0";
            this.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.TextBox6.Location = new System.Drawing.Point(427, 133);
            this.TextBox6.Name = "textBox6";
            this.TextBox6.Size = new System.Drawing.Size(28, 20);
            this.TextBox6.TabIndex = 27;
            this.TextBox6.Text = "0";
            this.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.TextBox7.Location = new System.Drawing.Point(380, 133);
            this.TextBox7.Name = "textBox7";
            this.TextBox7.Size = new System.Drawing.Size(28, 20);
            this.TextBox7.TabIndex = 26;
            this.TextBox7.Text = "8";
            this.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.TextBox8.Location = new System.Drawing.Point(346, 133);
            this.TextBox8.Name = "textBox8";
            this.TextBox8.Size = new System.Drawing.Size(28, 20);
            this.TextBox8.TabIndex = 25;
            this.TextBox8.Text = "0";
            this.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Location = new System.Drawing.Point(382, 181);
            this.Label14.Name = "label14";
            this.Label14.Size = new System.Drawing.Size(83, 13);
            this.Label14.TabIndex = 30;
            this.Label14.Text = "Decision Logica";
            this.Label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Location = new System.Drawing.Point(424, 209);
            this.Label15.Name = "label15";
            this.Label15.Size = new System.Drawing.Size(16, 13);
            this.Label15.TabIndex = 31;
            this.Label15.Text = "...";
            // 
            // textBox9
            // 
            //this.TextBox9.Location = new System.Drawing.Point(273, 247);
            //this.TextBox9.Name = "textBox9";
            //this.TextBox9.Size = new System.Drawing.Size(100, 20);
            //this.TextBox9.TabIndex = 32;
            // 
            // GraficoMM1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 338);
            this.Controls.Add(this.TextBox9);
            this.Controls.Add(this.Label15);
            this.Controls.Add(this.Label14);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.TextBox5);
            this.Controls.Add(this.TextBox6);
            this.Controls.Add(this.TextBox7);
            this.Controls.Add(this.TextBox8);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.Aband10M1);
            this.Controls.Add(this.Aband6M1);
            this.Controls.Add(this.TPromServ1);
            this.Controls.Add(this.TMinServ1);
            this.Controls.Add(this.TMaxServ1);
            this.Controls.Add(this.TPromCola1);
            this.Controls.Add(this.TMinCola1);
            this.Controls.Add(this.TmaxCola1);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.TotalAbandono1);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.TextBox4);
            this.Controls.Add(this.TextBox3);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "GraficoMM1";
            this.Text = "Grafico MM1";
            this.Load += new System.EventHandler(this.GraficoMM1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label TotalAbandono;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label TmaxCola;
        private System.Windows.Forms.Label TMinCola;
        private System.Windows.Forms.Label TPromCola;
        private System.Windows.Forms.Label TPromServ;
        private System.Windows.Forms.Label TMinServ;
        private System.Windows.Forms.Label TMaxServ;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label Aband10M;
        private System.Windows.Forms.Label Aband6M;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox9;

        public Label Label1
        {
            get
            {
                return label1;
            }

            set
            {
                label1 = value;
            }
        }

        public Label Label2
        {
            get
            {
                return label2;
            }

            set
            {
                label2 = value;
            }
        }

        public Label Label3
        {
            get
            {
                return label3;
            }

            set
            {
                label3 = value;
            }
        }

        public TextBox TextBox1
        {
            get
            {
                return textBox1;
            }

            set
            {
                textBox1 = value;
            }
        }

        public TextBox TextBox2
        {
            get
            {
                return textBox2;
            }

            set
            {
                textBox2 = value;
            }
        }

        public TextBox TextBox3
        {
            get
            {
                return textBox3;
            }

            set
            {
                textBox3 = value;
            }
        }

        public TextBox TextBox4
        {
            get
            {
                return textBox4;
            }

            set
            {
                textBox4 = value;
            }
        }

        public Label Label4
        {
            get
            {
                return label4;
            }

            set
            {
                label4 = value;
            }
        }

        public Label Label5
        {
            get
            {
                return label5;
            }

            set
            {
                label5 = value;
            }
        }

        public Label Label6
        {
            get
            {
                return label6;
            }

            set
            {
                label6 = value;
            }
        }

        public Label Label7
        {
            get
            {
                return label7;
            }

            set
            {
                label7 = value;
            }
        }

        public Label Label8
        {
            get
            {
                return label8;
            }

            set
            {
                label8 = value;
            }
        }

        public Label Label9
        {
            get
            {
                return label9;
            }

            set
            {
                label9 = value;
            }
        }

        public Label TotalAbandono1
        {
            get
            {
                return TotalAbandono;
            }

            set
            {
                TotalAbandono = value;
            }
        }

        public Label Label11
        {
            get
            {
                return label11;
            }

            set
            {
                label11 = value;
            }
        }

        public Label TmaxCola1
        {
            get
            {
                return TmaxCola;
            }

            set
            {
                TmaxCola = value;
            }
        }

        public Label TMinCola1
        {
            get
            {
                return TMinCola;
            }

            set
            {
                TMinCola = value;
            }
        }

        public Label TPromCola1
        {
            get
            {
                return TPromCola;
            }

            set
            {
                TPromCola = value;
            }
        }

        public Label TPromServ1
        {
            get
            {
                return TPromServ;
            }

            set
            {
                TPromServ = value;
            }
        }

        public Label TMinServ1
        {
            get
            {
                return TMinServ;
            }

            set
            {
                TMinServ = value;
            }
        }

        public Label TMaxServ1
        {
            get
            {
                return TMaxServ;
            }

            set
            {
                TMaxServ = value;
            }
        }

        public Label Label12
        {
            get
            {
                return label12;
            }

            set
            {
                label12 = value;
            }
        }

        public Label Aband10M1
        {
            get
            {
                return Aband10M;
            }

            set
            {
                Aband10M = value;
            }
        }

        public Label Aband6M1
        {
            get
            {
                return Aband6M;
            }

            set
            {
                Aband6M = value;
            }
        }

        public Label Label10
        {
            get
            {
                return label10;
            }

            set
            {
                label10 = value;
            }
        }

        public Label Label13
        {
            get
            {
                return label13;
            }

            set
            {
                label13 = value;
            }
        }

        public TextBox TextBox5
        {
            get
            {
                return textBox5;
            }

            set
            {
                textBox5 = value;
            }
        }

        public TextBox TextBox6
        {
            get
            {
                return textBox6;
            }

            set
            {
                textBox6 = value;
            }
        }

        public TextBox TextBox7
        {
            get
            {
                return textBox7;
            }

            set
            {
                textBox7 = value;
            }
        }

        public TextBox TextBox8
        {
            get
            {
                return textBox8;
            }

            set
            {
                textBox8 = value;
            }
        }

        public Label Label14
        {
            get
            {
                return label14;
            }

            set
            {
                label14 = value;
            }
        }

        public Label Label15
        {
            get
            {
                return label15;
            }

            set
            {
                label15 = value;
            }
        }

        public TextBox TextBox9
        {
            get
            {
                return textBox9;
            }

            set
            {
                textBox9 = value;
            }
        }
    }
}