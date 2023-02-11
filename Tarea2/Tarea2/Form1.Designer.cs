namespace Tarea2
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
            this.components = new System.ComponentModel.Container();
            this.N1textBox1 = new System.Windows.Forms.TextBox();
            this.N2textBox2 = new System.Windows.Forms.TextBox();
            this.N3textBox3 = new System.Windows.Forms.TextBox();
            this.N4textBox4 = new System.Windows.Forms.TextBox();
            this.RtextBox5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // N1textBox1
            // 
            this.N1textBox1.Location = new System.Drawing.Point(560, 119);
            this.N1textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.N1textBox1.Name = "N1textBox1";
            this.N1textBox1.Size = new System.Drawing.Size(204, 26);
            this.N1textBox1.TabIndex = 0;
            // 
            // N2textBox2
            // 
            this.N2textBox2.Location = new System.Drawing.Point(560, 185);
            this.N2textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.N2textBox2.Name = "N2textBox2";
            this.N2textBox2.Size = new System.Drawing.Size(204, 26);
            this.N2textBox2.TabIndex = 1;
            // 
            // N3textBox3
            // 
            this.N3textBox3.Location = new System.Drawing.Point(560, 247);
            this.N3textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.N3textBox3.Name = "N3textBox3";
            this.N3textBox3.Size = new System.Drawing.Size(204, 26);
            this.N3textBox3.TabIndex = 2;
            // 
            // N4textBox4
            // 
            this.N4textBox4.Location = new System.Drawing.Point(560, 313);
            this.N4textBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.N4textBox4.Name = "N4textBox4";
            this.N4textBox4.Size = new System.Drawing.Size(204, 26);
            this.N4textBox4.TabIndex = 3;
            // 
            // RtextBox5
            // 
            this.RtextBox5.Location = new System.Drawing.Point(561, 452);
            this.RtextBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RtextBox5.Name = "RtextBox5";
            this.RtextBox5.Size = new System.Drawing.Size(204, 26);
            this.RtextBox5.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(478, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 45);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ejecutar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ingrese Su 1ra Nota:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ingrese Su 2da Nota";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(371, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ingrese su 3ra Nota";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(364, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Imgrese Su 4ta Nota";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(389, 458);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Su Promedio es:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(409, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(324, 37);
            this.label6.TabIndex = 11;
            this.label6.Text = "Calcular su Promedio";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 595);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RtextBox5);
            this.Controls.Add(this.N4textBox4);
            this.Controls.Add(this.N3textBox3);
            this.Controls.Add(this.N2textBox2);
            this.Controls.Add(this.N1textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox N1textBox1;
        private System.Windows.Forms.TextBox N2textBox2;
        private System.Windows.Forms.TextBox N3textBox3;
        private System.Windows.Forms.TextBox N4textBox4;
        private System.Windows.Forms.TextBox RtextBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

