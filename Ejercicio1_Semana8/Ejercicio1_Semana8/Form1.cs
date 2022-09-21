using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1_Semana8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(textBox1.Text);
            double numero2 = Convert.ToDouble(textBox2.Text);
            double suma = numero1 + numero2;
            textBox3.Text = suma.ToString();
        }
        private double sumar(double numero1, double numero2)
        {
            double suma = numero1 + numero2;
            return suma;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(textBox1.Text);
            double numero2 = Convert.ToDouble(textBox2.Text);
            double resta = numero1 - numero2;
            textBox3.Text = resta.ToString();
        }
        private double restar(double numero1, double numero2)
        {
            double resta = numero1 - numero2;
            return resta;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(textBox1.Text);
            double numero2 = Convert.ToDouble(textBox2.Text);
            double divicion = numero1 / numero2;
            textBox3.Text = divicion.ToString();
        }
        private double dividir(double numero1, double numero2)
        {
            double divicion = numero1 / numero2;
            return divicion;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(textBox1.Text);
            double numero2 = Convert.ToDouble(textBox2.Text);
            double multiplicacion = numero1 * numero2;
            textBox3.Text = multiplicacion.ToString();
        }
        private double multiplicar(double numero1, double numero2)
        {
            double multiplicacion = numero1 * numero2;
            return multiplicacion;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
