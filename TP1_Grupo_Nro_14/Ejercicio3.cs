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
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

            /*El usuario deberá elegir entre estas opciones y luego al apretar el 
             botón “Mostrar lo que se seleccionó” se mostrará todos los elementos 
            seleccionados por el usuario a través de un Label.  */
            string resultado = (string)(rbFemenino.Checked ? "Femenino" : "Masculino");
           resultado = "Usted selecciono los siguientes elementos: "+"\r\n";
            resultado+= "Sexo: " + (string)(rbFemenino.Checked ? "Femenino" :  "Masculino") + "\r\n";
            resultado+="Estado Civil: "+ (string)(rbCasado.Checked ? "Casado" : "Soltero") + "\r\n";
            resultado+= "Oficio:" + "\r\n";

          
            foreach (var item in chlbProfesion.CheckedItems)
            {
                resultado += "-" + item.ToString() + "\r\n";
            }
                lblMensaje.Text = resultado;
        }

        //Las opciones seleccionadas no deben desactivarse luego de hacer clic en el botón
       // Mostrar.


        // Por defecto estará seleccionado la opción Femenino y Casado(lo  hacemos con la propiedad
        //del radiobutton que se llama CHECKED lo ponemos es TRUE


    }
}
