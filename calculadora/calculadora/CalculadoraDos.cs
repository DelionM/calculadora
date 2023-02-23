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
    public partial class CalculadoraDos : Form
    {
        double primero;
        double segundo;
        String operador;
        public CalculadoraDos()
        {
            InitializeComponent();
        }
        Clase.ClsSuma objeto = new Clase.ClsSuma();
        Clase.ClsResta objeto2 = new Clase.ClsResta();
        Clase.ClsDivision objeto3 = new Clase.ClsDivision();
        Clase.ClsMultiplicacion objeto4 = new Clase.ClsMultiplicacion();

        private void CalculadoraDos_Load(object sender, EventArgs e)
        {

        }

        private void cmbFigura_SelectedIndexChanged(object sender, EventArgs e)
        {
            segundo = double.Parse(txtPantalla.Text);
            double sum, res, div, mult;

            if (operador == "Suma")
            {
                sum = objeto.Sumar((primero), (segundo));
                txtPantalla.Text = sum.ToString();
            }
            else
                if (operador == "Resta")
            {
                res = objeto2.Restar((primero), (segundo));
                txtPantalla.Text = res.ToString();
            }
            else
                if (operador == "Multiplicación")
            {
                mult = objeto4.Multiplicar((primero), (segundo));
                txtPantalla.Text = mult.ToString();
            }
            else
            if (operador == "División")
            {
                div = objeto3.Dividir((primero), (segundo));
                txtPantalla.Text = div.ToString();
            }
           
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {
            //Regresa los valores a:
        }
    }
    }

