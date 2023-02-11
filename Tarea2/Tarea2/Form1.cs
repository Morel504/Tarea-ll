using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (N1textBox1.Text == "")
            {
                errorProvider1.SetError(N1textBox1, "Ingrese un número");
                return;
            }else if (N2textBox2.Text == "")
            {
                errorProvider1.SetError(N2textBox2, "Ingrese un número");
                return;
            }else if (N3textBox3.Text == "")
            {
                errorProvider1.SetError(N3textBox3, "Ingrese un número");
                return;
            }else if (N4textBox4.Text == "")
            {
                errorProvider1.SetError(N4textBox4, "Ingrese un número");
                return;
            }

            errorProvider1.Clear();

            float N1 = float.Parse(N1textBox1.Text);
            float N2 = float.Parse(N2textBox2.Text);
            float N3 = float.Parse(N3textBox3.Text);
            float N4 = float.Parse(N4textBox4.Text);

            float avarage = await CalcularPromedioAsync(N1, N2, N3, N4);

            RtextBox5.Text = avarage.ToString();
            Limpiar();
        }

        private async System.Threading.Tasks.Task<float> CalcularPromedioAsync(float Nota1, float Nota2, float Nota3, float Nota4)
        {
            return (Nota1 + Nota2 + Nota3 + Nota4) / 4;
        }

        private void Limpiar()
        {
            N1textBox1.Clear();
            N2textBox2.Clear(); 
            N3textBox3.Clear();
            N4textBox4.Clear();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
