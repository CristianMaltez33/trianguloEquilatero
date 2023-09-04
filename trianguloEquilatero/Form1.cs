using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trianguloEquilatero
{
    /// <summary>
    /// Diseño del front-end para la vista de los usuarios
    /// </summary>
    /// <author>Autor: Juan Diego Chichas </author>
    public partial class FrmEquilatero : Form
    {
        Calculos calculos = new Calculos();

        /// <summary>
        /// programación de lo controles de la pantalla y validación de datos
        /// </summary>
        /// <author>Autor: Madison Ariadna Acosta Artiga </author>
        public FrmEquilatero()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

            bool convertido = false;
            double ladoA = 0;
            double ladoB = 0;
            double ladoC = 0;

            convertido = double.TryParse(txtLadoA.Text, out ladoA);

            if (!convertido)
                MessageBox.Show("El valor ingresado {0}, no es un valor númericoo es un dato vacio, por favor vuelva a intentarlo", txtLadoA.Text);

            convertido = double.TryParse(txtLadoB.Text, out ladoB);

            if (!convertido)
                MessageBox.Show("El valor ingresado {0}, no es un valor númericoo es un dato vacio, por favor vuelva a intentarlo", txtLadoB.Text);

            convertido = double.TryParse(txtLadoC.Text, out ladoC);

            if (!convertido)
                MessageBox.Show("El valor ingresado {0}, no es un valor númerico o es un dato vacio, por favor vuelva a intentarlo", txtLadoC.Text);

            txtResultado.Text = calculos.calcularEquilatero(ladoA, ladoB, ladoC);

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                    c.Text = "";

            }

        }

        private void FrmEquilatero_Load(object sender, EventArgs e)
        {

        }

        private void txtLadoA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
