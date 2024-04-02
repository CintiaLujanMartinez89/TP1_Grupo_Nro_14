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
    public partial class Ejercicio1 : Form
    {


        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            string nombre = txtbNom.Text.Trim();

            //Valida que no se ingresen valores en blanco. 
            if (txtbNom.Text == "")
            {
                MessageBox.Show("Ingrese un nombre", "Atención");
                txtbNom.Clear();
                return;
            }



            /* Valida que no se ingresen
            nombres repetidos, incluso con letras mayúsculas, es decir: Carlos, carlos o 
            CarLos, los tres casos se consideran un mismo nombre repetido. transformando en string
            cada item que esta en la lista y los recorre con un foreach*/
            foreach (var item in lbNombres.Items)
            {
                if (string.Equals(item.ToString(), nombre, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("El nombre ya ha sido agregado.", "Atencion");
                    txtbNom.Clear();
                    return;
                }

            }

            // Agregar el nombre a la lista
            lbNombres.Items.Add(nombre);
            txtbNom.Clear();
        }

        private void btnMayorA_Click(object sender, EventArgs e)
        {
            /*al seleccionar un ítem de la lista y hacer
            clic en el botón con el signo > se pasará el ítem de la lista de nombres a la lista
            de la derecha.En caso de no haber seleccionado ningún ítem de la lista y hacer 
            clic en el signo > indicar con un cartel aclaratorio que debe haber una selección.*/
           
            
            try {lbNombresDer.Items.Add(lbNombres.SelectedItem); }

            // Verificar si se ha seleccionado un ítem en la lista izquierda

           catch(Exception)
            {
                MessageBox.Show("Por favor seleccione un nombre.", "Atención");
                return;
            }

        }






        private void btnMayorMayorA_Click(object sender, EventArgs e)
        {
            /*Al seleccionar el botón con el signo >> se pasarán todos los ítems a la lista
             de la derecha, eliminando los de la lista de la izquierda.
             */

            //usamos AddRange para agregar todos los elementos de la lista izquierda a la lista derecha
            lbNombresDer.Items.AddRange(lbNombres.Items.Cast<string>().ToArray());


            lbNombres.Items.Clear();


        }

    }
}