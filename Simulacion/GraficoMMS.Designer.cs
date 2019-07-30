using System.Windows.Forms;

namespace Simulacion
{
    partial class GraficoMMS
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
        private void InitializeComponent()
        {
            this.label1MMS = new System.Windows.Forms.Label();
            this.label2MMS = new System.Windows.Forms.Label();
            this.label3MMS = new System.Windows.Forms.Label();
            this.textBox1MMS = new System.Windows.Forms.TextBox();
            this.textBox2MMS = new System.Windows.Forms.TextBox();
            this.textBox3MMS = new System.Windows.Forms.TextBox();
            this.textBox4MMS = new System.Windows.Forms.TextBox();
            this.label4MMS = new System.Windows.Forms.Label();
            this.label5MMS = new System.Windows.Forms.Label();
            this.label6MMS = new System.Windows.Forms.Label();
            this.label7MMS = new System.Windows.Forms.Label();
            this.label8MMS = new System.Windows.Forms.Label();
            this.label9MMS = new System.Windows.Forms.Label();
            this.TotalAbandonoMMS = new System.Windows.Forms.Label();
            this.label11MMS = new System.Windows.Forms.Label();
            this.TmaxColaMMS = new System.Windows.Forms.Label();
            this.TMinColaMMS = new System.Windows.Forms.Label();
            this.TPromColaMMS = new System.Windows.Forms.Label();
            this.TPromServMMS = new System.Windows.Forms.Label();
            this.TMinServMMS = new System.Windows.Forms.Label();
            this.TMaxServMMS = new System.Windows.Forms.Label();
            this.label12MMS = new System.Windows.Forms.Label();
            this.Aband10MMMS = new System.Windows.Forms.Label();
            this.Aband6MMMS = new System.Windows.Forms.Label();
            this.label10MMS = new System.Windows.Forms.Label();
            this.label13MMS = new System.Windows.Forms.Label();
            this.textBox5MMS = new System.Windows.Forms.TextBox();
            this.textBox6MMS = new System.Windows.Forms.TextBox();
            this.textBox7MMS = new System.Windows.Forms.TextBox();
            this.textBox8MMS = new System.Windows.Forms.TextBox();
            this.label14MMS = new System.Windows.Forms.Label();
            this.label15MMS = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1MMS
            // 
            this.label1MMS.AutoSize = true;
            this.label1MMS.Location = new System.Drawing.Point(24, 25);
            this.label1MMS.Name = "label1MMS";
            this.label1MMS.Size = new System.Drawing.Size(177, 13);
            this.label1MMS.TabIndex = 0;
            this.label1MMS.Text = "Tiempo Maximo de Espera en Cola: ";
            this.label1MMS.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2MMS
            // 
            this.label2MMS.AutoSize = true;
            this.label2MMS.Location = new System.Drawing.Point(24, 71);
            this.label2MMS.Name = "label2MMS";
            this.label2MMS.Size = new System.Drawing.Size(182, 13);
            this.label2MMS.TabIndex = 1;
            this.label2MMS.Text = "Tiempo Promedio de Espera en Cola:";
            // 
            // label3MMS
            // 
            this.label3MMS.AutoSize = true;
            this.label3MMS.Location = new System.Drawing.Point(382, 25);
            this.label3MMS.Name = "label3MMS";
            this.label3MMS.Size = new System.Drawing.Size(73, 13);
            this.label3MMS.TabIndex = 2;
            this.label3MMS.Text = "Inicia Servicio";
            // 
            // textBox1MMS
            // 
            this.textBox1MMS.Location = new System.Drawing.Point(346, 48);
            this.textBox1MMS.Name = "textBox1MMS";
            this.textBox1MMS.Size = new System.Drawing.Size(28, 20);
            this.textBox1MMS.TabIndex = 3;
            this.textBox1MMS.Text = "0";
            this.textBox1MMS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1MMS.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2MMS
            // 
            this.textBox2MMS.Location = new System.Drawing.Point(380, 48);
            this.textBox2MMS.Name = "textBox2MMS";
            this.textBox2MMS.Size = new System.Drawing.Size(28, 20);
            this.textBox2MMS.TabIndex = 4;
            this.textBox2MMS.Text = "8";
            this.textBox2MMS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3MMS
            // 
            this.textBox3MMS.Location = new System.Drawing.Point(427, 48);
            this.textBox3MMS.Name = "textBox3MMS";
            this.textBox3MMS.Size = new System.Drawing.Size(28, 20);
            this.textBox3MMS.TabIndex = 5;
            this.textBox3MMS.Text = "0";
            this.textBox3MMS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4MMS
            // 
            this.textBox4MMS.Location = new System.Drawing.Point(461, 48);
            this.textBox4MMS.Name = "textBox4MMS";
            this.textBox4MMS.Size = new System.Drawing.Size(28, 20);
            this.textBox4MMS.TabIndex = 6;
            this.textBox4MMS.Text = "0";
            this.textBox4MMS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4MMS
            // 
            this.label4MMS.AutoSize = true;
            this.label4MMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4MMS.Location = new System.Drawing.Point(412, 48);
            this.label4MMS.Name = "label4MMS";
            this.label4MMS.Size = new System.Drawing.Size(13, 20);
            this.label4MMS.TabIndex = 7;
            this.label4MMS.Text = ":";
            // 
            // label5MMS
            // 
            this.label5MMS.AutoSize = true;
            this.label5MMS.Location = new System.Drawing.Point(24, 111);
            this.label5MMS.Name = "label5MMS";
            this.label5MMS.Size = new System.Drawing.Size(140, 13);
            this.label5MMS.TabIndex = 8;
            this.label5MMS.Text = "Tiempo Maximo de Servicio:";
            // 
            // label6MMS
            // 
            this.label6MMS.AutoSize = true;
            this.label6MMS.Location = new System.Drawing.Point(21, 136);
            this.label6MMS.Name = "label6MMS";
            this.label6MMS.Size = new System.Drawing.Size(137, 13);
            this.label6MMS.TabIndex = 9;
            this.label6MMS.Text = "Tiempo Minimo de Servicio:";
            // 
            // label7MMS
            // 
            this.label7MMS.AutoSize = true;
            this.label7MMS.Location = new System.Drawing.Point(21, 159);
            this.label7MMS.Name = "label7MMS";
            this.label7MMS.Size = new System.Drawing.Size(148, 13);
            this.label7MMS.TabIndex = 10;
            this.label7MMS.Text = "Tiempo Promedio de Servicio:";
            // 
            // label8MMS
            // 
            this.label8MMS.AutoSize = true;
            this.label8MMS.Location = new System.Drawing.Point(24, 200);
            this.label8MMS.Name = "label8MMS";
            this.label8MMS.Size = new System.Drawing.Size(154, 13);
            this.label8MMS.TabIndex = 11;
            this.label8MMS.Text = "Abandonan Despues de 6 Min:";
            this.label8MMS.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9MMS
            // 
            this.label9MMS.AutoSize = true;
            this.label9MMS.Location = new System.Drawing.Point(24, 225);
            this.label9MMS.Name = "label9MMS";
            this.label9MMS.Size = new System.Drawing.Size(160, 13);
            this.label9MMS.TabIndex = 12;
            this.label9MMS.Text = "Abandonan Despues de 10 Min:";
            // 
            // TotalAbandonoMMS
            // 
            this.TotalAbandonoMMS.AutoSize = true;
            this.TotalAbandonoMMS.Location = new System.Drawing.Point(24, 247);
            this.TotalAbandonoMMS.Name = "TotalAbandonoMMS";
            this.TotalAbandonoMMS.Size = new System.Drawing.Size(86, 13);
            this.TotalAbandonoMMS.TabIndex = 13;
            this.TotalAbandonoMMS.Text = "Total Abandono:";
            // 
            // label11MMS
            // 
            this.label11MMS.AutoSize = true;
            this.label11MMS.Location = new System.Drawing.Point(24, 48);
            this.label11MMS.Name = "label11MMS";
            this.label11MMS.Size = new System.Drawing.Size(171, 13);
            this.label11MMS.TabIndex = 14;
            this.label11MMS.Text = "Tiempo Minimo de Espera en Cola:";
            // 
            // TmaxColaMMS
            // 
            this.TmaxColaMMS.AutoSize = true;
            this.TmaxColaMMS.Location = new System.Drawing.Point(227, 25);
            this.TmaxColaMMS.Name = "TmaxColaMMS";
            this.TmaxColaMMS.Size = new System.Drawing.Size(16, 13);
            this.TmaxColaMMS.TabIndex = 15;
            this.TmaxColaMMS.Text = "...";
            // 
            // TMinColaMMS
            // 
            this.TMinColaMMS.AutoSize = true;
            this.TMinColaMMS.Location = new System.Drawing.Point(227, 48);
            this.TMinColaMMS.Name = "TMinColaMMS";
            this.TMinColaMMS.Size = new System.Drawing.Size(16, 13);
            this.TMinColaMMS.TabIndex = 16;
            this.TMinColaMMS.Text = "...";
            // 
            // TPromColaMMS
            // 
            this.TPromColaMMS.AutoSize = true;
            this.TPromColaMMS.Location = new System.Drawing.Point(227, 71);
            this.TPromColaMMS.Name = "TPromColaMMS";
            this.TPromColaMMS.Size = new System.Drawing.Size(16, 13);
            this.TPromColaMMS.TabIndex = 17;
            this.TPromColaMMS.Text = "...";
            // 
            // TPromServMMS
            // 
            this.TPromServMMS.AutoSize = true;
            this.TPromServMMS.Location = new System.Drawing.Point(227, 157);
            this.TPromServMMS.Name = "TPromServMMS";
            this.TPromServMMS.Size = new System.Drawing.Size(16, 13);
            this.TPromServMMS.TabIndex = 20;
            this.TPromServMMS.Text = "...";
            // 
            // TMinServMMS
            // 
            this.TMinServMMS.AutoSize = true;
            this.TMinServMMS.Location = new System.Drawing.Point(227, 134);
            this.TMinServMMS.Name = "TMinServMMS";
            this.TMinServMMS.Size = new System.Drawing.Size(16, 13);
            this.TMinServMMS.TabIndex = 19;
            this.TMinServMMS.Text = "...";
            // 
            // TMaxServMMS
            // 
            this.TMaxServMMS.AutoSize = true;
            this.TMaxServMMS.Location = new System.Drawing.Point(227, 111);
            this.TMaxServMMS.Name = "TMaxServMMS";
            this.TMaxServMMS.Size = new System.Drawing.Size(16, 13);
            this.TMaxServMMS.TabIndex = 18;
            this.TMaxServMMS.Text = "...";
            // 
            // label12MMS
            // 
            this.label12MMS.AutoSize = true;
            this.label12MMS.Location = new System.Drawing.Point(227, 246);
            this.label12MMS.Name = "label12MMS";
            this.label12MMS.Size = new System.Drawing.Size(16, 13);
            this.label12MMS.TabIndex = 23;
            this.label12MMS.Text = "...";
            // 
            // Aband10MMMS
            // 
            this.Aband10MMMS.AutoSize = true;
            this.Aband10MMMS.Location = new System.Drawing.Point(227, 223);
            this.Aband10MMMS.Name = "Aband10MMMS";
            this.Aband10MMMS.Size = new System.Drawing.Size(16, 13);
            this.Aband10MMMS.TabIndex = 22;
            this.Aband10MMMS.Text = "...";
            // 
            // Aband6MMMS
            // 
            this.Aband6MMMS.AutoSize = true;
            this.Aband6MMMS.Location = new System.Drawing.Point(227, 200);
            this.Aband6MMMS.Name = "Aband6MMMS";
            this.Aband6MMMS.Size = new System.Drawing.Size(16, 13);
            this.Aband6MMMS.TabIndex = 21;
            this.Aband6MMMS.Text = "...";
            // 
            // label10MMS
            // 
            this.label10MMS.AutoSize = true;
            this.label10MMS.Location = new System.Drawing.Point(399, 111);
            this.label10MMS.Name = "label10MMS";
            this.label10MMS.Size = new System.Drawing.Size(56, 13);
            this.label10MMS.TabIndex = 24;
            this.label10MMS.Text = "Inicia Cola";
            this.label10MMS.Click += new System.EventHandler(this.label10_Click);
            // 
            // label13MMS
            // 
            this.label13MMS.AutoSize = true;
            this.label13MMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13MMS.Location = new System.Drawing.Point(412, 133);
            this.label13MMS.Name = "label13MMS";
            this.label13MMS.Size = new System.Drawing.Size(13, 20);
            this.label13MMS.TabIndex = 29;
            this.label13MMS.Text = ":";
            // 
            // textBox5MMS
            // 
            this.textBox5MMS.Location = new System.Drawing.Point(461, 133);
            this.textBox5MMS.Name = "textBox5MMS";
            this.textBox5MMS.Size = new System.Drawing.Size(28, 20);
            this.textBox5MMS.TabIndex = 28;
            this.textBox5MMS.Text = "0";
            this.textBox5MMS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6MMS
            // 
            this.textBox6MMS.Location = new System.Drawing.Point(427, 133);
            this.textBox6MMS.Name = "textBox6MMS";
            this.textBox6MMS.Size = new System.Drawing.Size(28, 20);
            this.textBox6MMS.TabIndex = 27;
            this.textBox6MMS.Text = "0";
            this.textBox6MMS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7MMS
            // 
            this.textBox7MMS.Location = new System.Drawing.Point(380, 133);
            this.textBox7MMS.Name = "textBox7MMS";
            this.textBox7MMS.Size = new System.Drawing.Size(28, 20);
            this.textBox7MMS.TabIndex = 26;
            this.textBox7MMS.Text = "8";
            this.textBox7MMS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8MMS
            // 
            this.textBox8MMS.Location = new System.Drawing.Point(346, 133);
            this.textBox8MMS.Name = "textBox8MMS";
            this.textBox8MMS.Size = new System.Drawing.Size(28, 20);
            this.textBox8MMS.TabIndex = 25;
            this.textBox8MMS.Text = "0";
            this.textBox8MMS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14MMS
            // 
            this.label14MMS.AutoSize = true;
            this.label14MMS.Location = new System.Drawing.Point(382, 181);
            this.label14MMS.Name = "label14MMS";
            this.label14MMS.Size = new System.Drawing.Size(83, 13);
            this.label14MMS.TabIndex = 30;
            this.label14MMS.Text = "Decision Logica";
            this.label14MMS.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15MMS
            // 
            this.label15MMS.AutoSize = true;
            this.label15MMS.Location = new System.Drawing.Point(424, 209);
            this.label15MMS.Name = "label15MMS";
            this.label15MMS.Size = new System.Drawing.Size(16, 13);
            this.label15MMS.TabIndex = 31;
            this.label15MMS.Text = "...";
            // 
            // GraficoMMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 338);
            this.Controls.Add(this.label15MMS);
            this.Controls.Add(this.label14MMS);
            this.Controls.Add(this.label13MMS);
            this.Controls.Add(this.textBox5MMS);
            this.Controls.Add(this.textBox6MMS);
            this.Controls.Add(this.textBox7MMS);
            this.Controls.Add(this.textBox8MMS);
            this.Controls.Add(this.label10MMS);
            this.Controls.Add(this.label12MMS);
            this.Controls.Add(this.Aband10MMMS);
            this.Controls.Add(this.Aband6MMMS);
            this.Controls.Add(this.TPromServMMS);
            this.Controls.Add(this.TMinServMMS);
            this.Controls.Add(this.TMaxServMMS);
            this.Controls.Add(this.TPromColaMMS);
            this.Controls.Add(this.TMinColaMMS);
            this.Controls.Add(this.TmaxColaMMS);
            this.Controls.Add(this.label11MMS);
            this.Controls.Add(this.TotalAbandonoMMS);
            this.Controls.Add(this.label9MMS);
            this.Controls.Add(this.label8MMS);
            this.Controls.Add(this.label7MMS);
            this.Controls.Add(this.label6MMS);
            this.Controls.Add(this.label5MMS);
            this.Controls.Add(this.label4MMS);
            this.Controls.Add(this.textBox4MMS);
            this.Controls.Add(this.textBox3MMS);
            this.Controls.Add(this.textBox2MMS);
            this.Controls.Add(this.textBox1MMS);
            this.Controls.Add(this.label3MMS);
            this.Controls.Add(this.label2MMS);
            this.Controls.Add(this.label1MMS);
            this.Name = "GraficoMMS";
            this.Text = "Grafico MMS";
            this.Load += new System.EventHandler(this.GraficoMMS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1MMS;
        private System.Windows.Forms.Label label2MMS;
        private System.Windows.Forms.Label label3MMS;
        private System.Windows.Forms.TextBox textBox1MMS;
        private System.Windows.Forms.TextBox textBox2MMS;
        private System.Windows.Forms.TextBox textBox3MMS;
        private System.Windows.Forms.TextBox textBox4MMS;
        private System.Windows.Forms.Label label4MMS;
        private System.Windows.Forms.Label label5MMS;
        private System.Windows.Forms.Label label6MMS;
        private System.Windows.Forms.Label label7MMS;
        private System.Windows.Forms.Label label8MMS;
        private System.Windows.Forms.Label label9MMS;
        private System.Windows.Forms.Label TotalAbandonoMMS;
        private System.Windows.Forms.Label label11MMS;
        private System.Windows.Forms.Label TmaxColaMMS;
        private System.Windows.Forms.Label TMinColaMMS;
        private System.Windows.Forms.Label TPromColaMMS;
        private System.Windows.Forms.Label TPromServMMS;
        private System.Windows.Forms.Label TMinServMMS;
        private System.Windows.Forms.Label TMaxServMMS;
        private System.Windows.Forms.Label label12MMS;
        private System.Windows.Forms.Label Aband10MMMS;
        private System.Windows.Forms.Label Aband6MMMS;
        private System.Windows.Forms.Label label10MMS;
        private System.Windows.Forms.Label label13MMS;
        private System.Windows.Forms.TextBox textBox5MMS;
        private System.Windows.Forms.TextBox textBox6MMS;
        private System.Windows.Forms.TextBox textBox7MMS;
        private System.Windows.Forms.TextBox textBox8MMS;
        private System.Windows.Forms.Label label14MMS;
        private System.Windows.Forms.Label label15MMS;

        public Label Label1MMS
        {
            get
            {
                return label1MMS;
            }

            set
            {
                label1MMS = value;
            }
        }

        public Label Label2MMS
        {
            get
            {
                return label2MMS;
            }

            set
            {
                label2MMS = value;
            }
        }

        public Label Label3MMS
        {
            get
            {
                return label3MMS;
            }

            set
            {
                label3MMS = value;
            }
        }

        public TextBox TextBox1MMS
        {
            get
            {
                return textBox1MMS;
            }

            set
            {
                textBox1MMS = value;
            }
        }

        public TextBox TextBox2MMS
        {
            get
            {
                return textBox2MMS;
            }

            set
            {
                textBox2MMS = value;
            }
        }

        public TextBox TextBox3MMS
        {
            get
            {
                return textBox3MMS;
            }

            set
            {
                textBox3MMS = value;
            }
        }

        public TextBox TextBox4MMS
        {
            get
            {
                return textBox4MMS;
            }

            set
            {
                textBox4MMS = value;
            }
        }

        public Label Label4MMS
        {
            get
            {
                return label4MMS;
            }

            set
            {
                label4MMS = value;
            }
        }

        public Label Label5MMS
        {
            get
            {
                return label5MMS;
            }

            set
            {
                label5MMS = value;
            }
        }

        public Label Label6MMS
        {
            get
            {
                return label6MMS;
            }

            set
            {
                label6MMS = value;
            }
        }

        public Label Label7MMS
        {
            get
            {
                return label7MMS;
            }

            set
            {
                label7MMS = value;
            }
        }

        public Label Label8MMS
        {
            get
            {
                return label8MMS;
            }

            set
            {
                label8MMS = value;
            }
        }

        public Label Label9MMS
        {
            get
            {
                return label9MMS;
            }

            set
            {
                label9MMS = value;
            }
        }

        public Label TotalAbandonoMMS1
        {
            get
            {
                return TotalAbandonoMMS;
            }

            set
            {
                TotalAbandonoMMS = value;
            }
        }

        public Label Label11MMS
        {
            get
            {
                return label11MMS;
            }

            set
            {
                label11MMS = value;
            }
        }

        public Label TmaxColaMMS1
        {
            get
            {
                return TmaxColaMMS;
            }

            set
            {
                TmaxColaMMS = value;
            }
        }

        public Label TMinColaMMS1
        {
            get
            {
                return TMinColaMMS;
            }

            set
            {
                TMinColaMMS = value;
            }
        }

        public Label TPromColaMMS1
        {
            get
            {
                return TPromColaMMS;
            }

            set
            {
                TPromColaMMS = value;
            }
        }

        public Label TPromServMMS1
        {
            get
            {
                return TPromServMMS;
            }

            set
            {
                TPromServMMS = value;
            }
        }

        public Label TMinServMMS1
        {
            get
            {
                return TMinServMMS;
            }

            set
            {
                TMinServMMS = value;
            }
        }

        public Label TMaxServMMS1
        {
            get
            {
                return TMaxServMMS;
            }

            set
            {
                TMaxServMMS = value;
            }
        }

        public Label Label12MMS
        {
            get
            {
                return label12MMS;
            }

            set
            {
                label12MMS = value;
            }
        }

        public Label Aband10MMMS1
        {
            get
            {
                return Aband10MMMS;
            }

            set
            {
                Aband10MMMS = value;
            }
        }

        public Label Aband6MMMS1
        {
            get
            {
                return Aband6MMMS;
            }

            set
            {
                Aband6MMMS = value;
            }
        }

        public Label Label10MMS
        {
            get
            {
                return label10MMS;
            }

            set
            {
                label10MMS = value;
            }
        }

        public Label Label13MMS
        {
            get
            {
                return label13MMS;
            }

            set
            {
                label13MMS = value;
            }
        }

        public TextBox TextBox5MMS
        {
            get
            {
                return textBox5MMS;
            }

            set
            {
                textBox5MMS = value;
            }
        }

        public TextBox TextBox6MMS
        {
            get
            {
                return textBox6MMS;
            }

            set
            {
                textBox6MMS = value;
            }
        }

        public TextBox TextBox7MMS
        {
            get
            {
                return textBox7MMS;
            }

            set
            {
                textBox7MMS = value;
            }
        }

        public TextBox TextBox8MMS
        {
            get
            {
                return textBox8MMS;
            }

            set
            {
                textBox8MMS = value;
            }
        }

        public Label Label14MMS
        {
            get
            {
                return label14MMS;
            }

            set
            {
                label14MMS = value;
            }
        }

        public Label Label15MMS
        {
            get
            {
                return label15MMS;
            }

            set
            {
                label15MMS = value;
            }
        }
    }
}