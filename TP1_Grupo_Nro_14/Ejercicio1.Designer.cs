
namespace TP1_Grupo_Nro_14
{
    partial class Ejercicio1
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
            this.lbNombres = new System.Windows.Forms.ListBox();
            this.lbNombresDer = new System.Windows.Forms.ListBox();
            this.btnMayorA = new System.Windows.Forms.Button();
            this.btnMayorMayorA = new System.Windows.Forms.Button();
            this.lblIngNom = new System.Windows.Forms.Label();
            this.txtbNom = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNombres
            // 
            this.lbNombres.FormattingEnabled = true;
            this.lbNombres.Location = new System.Drawing.Point(47, 158);
            this.lbNombres.Name = "lbNombres";
            this.lbNombres.Size = new System.Drawing.Size(240, 290);
            this.lbNombres.TabIndex = 0;
            // 
            // lbNombresDer
            // 
            this.lbNombresDer.FormattingEnabled = true;
            this.lbNombresDer.Location = new System.Drawing.Point(407, 158);
            this.lbNombresDer.Name = "lbNombresDer";
            this.lbNombresDer.Size = new System.Drawing.Size(240, 290);
            this.lbNombresDer.TabIndex = 1;
            // 
            // btnMayorA
            // 
            this.btnMayorA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMayorA.Location = new System.Drawing.Point(310, 220);
            this.btnMayorA.Name = "btnMayorA";
            this.btnMayorA.Size = new System.Drawing.Size(75, 23);
            this.btnMayorA.TabIndex = 2;
            this.btnMayorA.Text = ">";
            this.btnMayorA.UseVisualStyleBackColor = true;
            this.btnMayorA.Click += new System.EventHandler(this.btnMayorA_Click);
            // 
            // btnMayorMayorA
            // 
            this.btnMayorMayorA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMayorMayorA.Location = new System.Drawing.Point(310, 292);
            this.btnMayorMayorA.Name = "btnMayorMayorA";
            this.btnMayorMayorA.Size = new System.Drawing.Size(75, 23);
            this.btnMayorMayorA.TabIndex = 3;
            this.btnMayorMayorA.Text = ">>";
            this.btnMayorMayorA.UseVisualStyleBackColor = true;
            this.btnMayorMayorA.Click += new System.EventHandler(this.btnMayorMayorA_Click);
            // 
            // lblIngNom
            // 
            this.lblIngNom.AutoSize = true;
            this.lblIngNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngNom.Location = new System.Drawing.Point(47, 48);
            this.lblIngNom.Name = "lblIngNom";
            this.lblIngNom.Size = new System.Drawing.Size(139, 18);
            this.lblIngNom.TabIndex = 4;
            this.lblIngNom.Text = "Ingrese un nombre: ";
            // 
            // txtbNom
            // 
            this.txtbNom.Location = new System.Drawing.Point(202, 49);
            this.txtbNom.Name = "txtbNom";
            this.txtbNom.Size = new System.Drawing.Size(252, 20);
            this.txtbNom.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(513, 47);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Ejercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 491);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtbNom);
            this.Controls.Add(this.lblIngNom);
            this.Controls.Add(this.btnMayorMayorA);
            this.Controls.Add(this.btnMayorA);
            this.Controls.Add(this.lbNombresDer);
            this.Controls.Add(this.lbNombres);
            this.Name = "Ejercicio1";
            this.Text = "Formulario Ejercicio 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbNombres;
        private System.Windows.Forms.ListBox lbNombresDer;
        private System.Windows.Forms.Button btnMayorA;
        private System.Windows.Forms.Button btnMayorMayorA;
        private System.Windows.Forms.Label lblIngNom;
        private System.Windows.Forms.TextBox txtbNom;
        private System.Windows.Forms.Button btnAgregar;
    }
}