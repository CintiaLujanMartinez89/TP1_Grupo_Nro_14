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
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            /*Se deben completar el TextBox Nombre y el TextBox Apellido y luego al dar
             clic en el botón agregar se irán agregando a una lista de elementos  */
            string nombre = tbNombre.Text.Trim();
            string apellido = tbApellido.Text.Trim();

            //Valida que no se ingresen valores en blanco. 
            if (tbNombre.Text == "")
            {
                MessageBox.Show("Ingrese un nombre", "Atención");
                tbNombre.Clear();
                return;
            }

            if (tbApellido.Text == "")
            {
                MessageBox.Show("Ingrese un apellido", "Atención");
                tbApellido.Clear();
                return;
            }

            string nombreCompleto = tbNombre.Text + " " + tbApellido.Text; //concateno nombre + apellido


            // No se podrá agregar el mismo nombre y apellido, validando mayúsculas y
            //minúsculas, es decir Carlos Pérez y carlos pérez, son elementos repetidos.
            foreach (var item in lbElementos.Items)
            {
                if (string.Equals(item.ToString(), nombreCompleto, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("El nombre ya ha sido agregado.", "Atencion");
                    tbNombre.Clear();
                    tbApellido.Clear();
                    return;
                }

            }



            // Los elementos deben aparecer ordenados alfabéticamente en la lista, aunque
            //el operador los ingrese desordenados(lo hicimos con la propiedad SORTED en TRUE)


            // Agregar el nombre a la lista
            lbElementos.Items.Add(nombreCompleto);
            tbNombre.Clear();
            tbApellido.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            /* El botón Borrar, eliminara el elemento seleccionado. En caso de no haber
             seleccionado ningún ítem de la lista y hacer clic en el botón Borrar indicar
            con un cartel aclaratorio que debe haber una selección. */


            try { lbElementos.Items.RemoveAt(lbElementos.SelectedIndex); }

            // Verificar si se ha seleccionado un ítem en la lista izquierda

            catch (Exception )
            {            
            MessageBox.Show("Por favor seleccione un nombre para borrar.", "Atención");
                return;
            }
        }
    }
}
