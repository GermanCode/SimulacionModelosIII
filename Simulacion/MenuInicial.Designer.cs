namespace Simulacion
{
    partial class MenuInicial
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuInicial));
            this.MM2 = new System.Windows.Forms.Button();
            this.DosCanales = new System.Windows.Forms.Button();
            this.MM1 = new System.Windows.Forms.Button();
            this.Simultaneos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MM2
            // 
            this.MM2.Location = new System.Drawing.Point(117, 263);
            this.MM2.Name = "MM2";
            this.MM2.Size = new System.Drawing.Size(75, 23);
            this.MM2.TabIndex = 0;
            this.MM2.Text = "MM2";
            this.MM2.UseVisualStyleBackColor = true;
            this.MM2.Click += new System.EventHandler(this.button1_Click);
            // 
            // DosCanales
            // 
            this.DosCanales.Location = new System.Drawing.Point(225, 263);
            this.DosCanales.Name = "DosCanales";
            this.DosCanales.Size = new System.Drawing.Size(75, 23);
            this.DosCanales.TabIndex = 1;
            this.DosCanales.Text = "2Canales1S";
            this.DosCanales.UseVisualStyleBackColor = true;
            this.DosCanales.Click += new System.EventHandler(this.button2_Click);
            // 
            // MM1
            // 
            this.MM1.Location = new System.Drawing.Point(11, 263);
            this.MM1.Name = "MM1";
            this.MM1.Size = new System.Drawing.Size(75, 23);
            this.MM1.TabIndex = 2;
            this.MM1.Text = "MM1";
            this.MM1.UseVisualStyleBackColor = true;
            this.MM1.Click += new System.EventHandler(this.btnMM1);
            // 
            // Simultaneos
            // 
            this.Simultaneos.Location = new System.Drawing.Point(117, 298);
            this.Simultaneos.Name = "Simultaneos";
            this.Simultaneos.Size = new System.Drawing.Size(75, 23);
            this.Simultaneos.TabIndex = 3;
            this.Simultaneos.Text = "Simultaneos";
            this.Simultaneos.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Generar Aleatorios";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(43, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 191);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 333);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Simultaneos);
            this.Controls.Add(this.MM1);
            this.Controls.Add(this.DosCanales);
            this.Controls.Add(this.MM2);
            this.Name = "Form1";
            this.Text = "Menu Inicial";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MM2;
        private System.Windows.Forms.Button DosCanales;
        private System.Windows.Forms.Button MM1;
        private System.Windows.Forms.Button Simultaneos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

