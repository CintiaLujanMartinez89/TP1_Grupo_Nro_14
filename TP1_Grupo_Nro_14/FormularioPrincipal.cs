using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_Grupo_Nro_14
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }


        //por cada boton creo una instancia de cada formulario y luego la invoco
        private void btnEjercicio1_Click(object sender, EventArgs e)
        {
            Ejercicio1 ej1 = new Ejercicio1();
            ej1.Show();
            return;        }

        private void btnEjercicio2_Click(object sender, EventArgs e)
        {
            Ejercicio2 ej2 = new Ejercicio2();
            ej2.Show();
            return;
        }

        private void btnEjercicio3_Click(object sender, EventArgs e)
        {
            Ejercicio3 ej3 = new Ejercicio3();
            ej3.Show();
            return;
        }
    }
}
