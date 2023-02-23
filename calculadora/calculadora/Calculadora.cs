using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    
    public partial class Calculadora : Form
    {
        double primero;
        double segundo;
        String operador;
        public Calculadora()
        {
            InitializeComponent();
        }
        // Llamar las clases creadas 
        Clase.ClsSuma objeto = new Clase.ClsSuma();
        Clase.ClsResta objeto2 = new Clase.ClsResta();
        Clase.ClsDivision objeto3 = new Clase.ClsDivision();
        Clase.ClsMultiplicacion objeto4 = new Clase.ClsMultiplicacion();

        private void btn0_Click(object sender, EventArgs e)
        {
            txtDevuelve.Text = txtDevuelve.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtDevuelve.Text = txtDevuelve.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtDevuelve.Text = txtDevuelve.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtDevuelve.Text = txtDevuelve.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtDevuelve.Text = txtDevuelve.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtDevuelve.Text = txtDevuelve.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtDevuelve.Text = txtDevuelve.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtDevuelve.Text = txtDevuelve.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtDevuelve.Text = txtDevuelve.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtDevuelve.Text = txtDevuelve.Text + "9";
        }

        private void buttonPunto_Click(object sender, EventArgs e)
        {
            txtDevuelve.Text = txtDevuelve.Text + ".";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(txtDevuelve.Text);
            txtDevuelve.Clear();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(txtDevuelve.Text);
            txtDevuelve.Clear();
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(txtDevuelve.Text);
            txtDevuelve.Clear();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(txtDevuelve.Text);
            txtDevuelve.Clear();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(txtDevuelve.Text);
            double sum, res, div, mult;

            if (operador == "+")
            {
                sum = objeto.Sumar((primero), (segundo));
                txtDevuelve.Text = sum.ToString();
            }
            else
                if (operador == "-")
            {
                res = objeto2.Restar((primero), (segundo));
                txtDevuelve.Text = res.ToString();
            }
            else
                if (operador == "*")
            {
                mult = objeto4.Multiplicar((primero), (segundo));
                txtDevuelve.Text = mult.ToString();
            }
            else
            if (operador == "/") {
                div = objeto3.Dividir((primero), (segundo));
                txtDevuelve.Text = div.ToString();
                    }

        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            txtDevuelve.Clear();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo,MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
            else
            {
                this.btnBorrarTodo.Focus();
            }
        }

        private void txtDevuelve_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
