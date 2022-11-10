namespace WindowsFormsApplication2
{
    partial class Form1
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
            this.nombre = new System.Windows.Forms.TextBox();
            this.Grados = new System.Windows.Forms.Label();
            this.CaF = new System.Windows.Forms.RadioButton();
            this.FaC = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.contLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(413, 36);
            this.nombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(244, 26);
            this.nombre.TabIndex = 9;
            // 
            // Grados
            // 
            this.Grados.AutoSize = true;
            this.Grados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grados.Location = new System.Drawing.Point(239, 25);
            this.Grados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Grados.Name = "Grados";
            this.Grados.Size = new System.Drawing.Size(123, 37);
            this.Grados.TabIndex = 10;
            this.Grados.Text = "Grados";
            // 
            // CaF
            // 
            this.CaF.AutoSize = true;
            this.CaF.Location = new System.Drawing.Point(413, 89);
            this.CaF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CaF.Name = "CaF";
            this.CaF.Size = new System.Drawing.Size(170, 24);
            this.CaF.TabIndex = 11;
            this.CaF.TabStop = true;
            this.CaF.Text = "Celsius a Farenheit";
            this.CaF.UseVisualStyleBackColor = true;
            // 
            // FaC
            // 
            this.FaC.AutoSize = true;
            this.FaC.Location = new System.Drawing.Point(413, 123);
            this.FaC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FaC.Name = "FaC";
            this.FaC.Size = new System.Drawing.Size(179, 24);
            this.FaC.TabIndex = 12;
            this.FaC.TabStop = true;
            this.FaC.Text = "Fahrenheit a Celsius";
            this.FaC.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(413, 157);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 13;
            this.button2.Text = "Enviar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(33, 89);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(270, 89);
            this.button4.TabIndex = 14;
            this.button4.Text = "¿Cuántos servicios?";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // contLbl
            // 
            this.contLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contLbl.Location = new System.Drawing.Point(49, 183);
            this.contLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contLbl.Name = "contLbl";
            this.contLbl.Size = new System.Drawing.Size(221, 140);
            this.contLbl.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 399);
            this.Controls.Add(this.contLbl);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.FaC);
            this.Controls.Add(this.CaF);
            this.Controls.Add(this.Grados);
            this.Controls.Add(this.nombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.RadioButton CaF;
        private System.Windows.Forms.RadioButton FaC;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label Grados;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label contLbl;
    }
}

