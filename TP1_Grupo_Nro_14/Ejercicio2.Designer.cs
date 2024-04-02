
namespace TP1_Grupo_Nro_14
{
    partial class Ejercicio2
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
            this.gbIngDat = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gbElementos = new System.Windows.Forms.GroupBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.lbElementos = new System.Windows.Forms.ListBox();
            this.gbIngDat.SuspendLayout();
            this.gbElementos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbIngDat
            // 
            this.gbIngDat.Controls.Add(this.btnAgregar);
            this.gbIngDat.Controls.Add(this.tbApellido);
            this.gbIngDat.Controls.Add(this.tbNombre);
            this.gbIngDat.Controls.Add(this.lblApellido);
            this.gbIngDat.Controls.Add(this.lblNombre);
            this.gbIngDat.Location = new System.Drawing.Point(26, 33);
            this.gbIngDat.Name = "gbIngDat";
            this.gbIngDat.Size = new System.Drawing.Size(277, 334);
            this.gbIngDat.TabIndex = 0;
            this.gbIngDat.TabStop = false;
            this.gbIngDat.Text = "Ingreso de Datos";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(75, 245);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(120, 36);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(111, 180);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(133, 20);
            this.tbApellido.TabIndex = 3;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(111, 124);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(133, 20);
            this.tbNombre.TabIndex = 2;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(22, 179);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(72, 18);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(19, 123);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 18);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // gbElementos
            // 
            this.gbElementos.Controls.Add(this.btnBorrar);
            this.gbElementos.Controls.Add(this.lbElementos);
            this.gbElementos.Location = new System.Drawing.Point(353, 33);
            this.gbElementos.Name = "gbElementos";
            this.gbElementos.Size = new System.Drawing.Size(277, 334);
            this.gbElementos.TabIndex = 1;
            this.gbElementos.TabStop = false;
            this.gbElementos.Text = "Elementos";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(97, 299);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 1;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // lbElementos
            // 
            this.lbElementos.FormattingEnabled = true;
            this.lbElementos.Location = new System.Drawing.Point(17, 30);
            this.lbElementos.Name = "lbElementos";
            this.lbElementos.Size = new System.Drawing.Size(238, 251);
            this.lbElementos.Sorted = true;
            this.lbElementos.TabIndex = 0;
            // 
            // Ejercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.gbElementos);
            this.Controls.Add(this.gbIngDat);
            this.Name = "Ejercicio2";
            this.Text = "Nombre y Apellido";
            this.gbIngDat.ResumeLayout(false);
            this.gbIngDat.PerformLayout();
            this.gbElementos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbIngDat;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox gbElementos;
        private System.Windows.Forms.ListBox lbElementos;
        private System.Windows.Forms.Button btnBorrar;
    }
}