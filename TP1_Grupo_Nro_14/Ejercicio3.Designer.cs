
namespace TP1_Grupo_Nro_14
{
    partial class Ejercicio3
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
            this.gbEstCivil = new System.Windows.Forms.GroupBox();
            this.rbCasado = new System.Windows.Forms.RadioButton();
            this.rbSoltero = new System.Windows.Forms.RadioButton();
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.chlbProfesion = new System.Windows.Forms.CheckedListBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.gbEstCivil.SuspendLayout();
            this.gbSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEstCivil
            // 
            this.gbEstCivil.Controls.Add(this.rbCasado);
            this.gbEstCivil.Controls.Add(this.rbSoltero);
            this.gbEstCivil.Location = new System.Drawing.Point(369, 34);
            this.gbEstCivil.Name = "gbEstCivil";
            this.gbEstCivil.Size = new System.Drawing.Size(234, 129);
            this.gbEstCivil.TabIndex = 0;
            this.gbEstCivil.TabStop = false;
            this.gbEstCivil.Text = "Estado Civil";
            // 
            // rbCasado
            // 
            this.rbCasado.AutoSize = true;
            this.rbCasado.Checked = true;
            this.rbCasado.Location = new System.Drawing.Point(25, 80);
            this.rbCasado.Name = "rbCasado";
            this.rbCasado.Size = new System.Drawing.Size(61, 17);
            this.rbCasado.TabIndex = 1;
            this.rbCasado.TabStop = true;
            this.rbCasado.Text = "Casado";
            this.rbCasado.UseVisualStyleBackColor = true;
            // 
            // rbSoltero
            // 
            this.rbSoltero.AutoSize = true;
            this.rbSoltero.Location = new System.Drawing.Point(25, 35);
            this.rbSoltero.Name = "rbSoltero";
            this.rbSoltero.Size = new System.Drawing.Size(58, 17);
            this.rbSoltero.TabIndex = 0;
            this.rbSoltero.Text = "Soltero";
            this.rbSoltero.UseVisualStyleBackColor = true;
            // 
            // gbSexo
            // 
            this.gbSexo.Controls.Add(this.rbMasculino);
            this.gbSexo.Controls.Add(this.rbFemenino);
            this.gbSexo.Location = new System.Drawing.Point(44, 34);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Size = new System.Drawing.Size(234, 129);
            this.gbSexo.TabIndex = 1;
            this.gbSexo.TabStop = false;
            this.gbSexo.Text = "Sexo";
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(26, 80);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbMasculino.TabIndex = 1;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Checked = true;
            this.rbFemenino.Location = new System.Drawing.Point(26, 35);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(71, 17);
            this.rbFemenino.TabIndex = 0;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // chlbProfesion
            // 
            this.chlbProfesion.CheckOnClick = true;
            this.chlbProfesion.FormattingEnabled = true;
            this.chlbProfesion.Items.AddRange(new object[] {
            "Data Entry",
            "Operador de Pc",
            "Programador",
            "Operador de PC",
            "Tester"});
            this.chlbProfesion.Location = new System.Drawing.Point(247, 198);
            this.chlbProfesion.Name = "chlbProfesion";
            this.chlbProfesion.Size = new System.Drawing.Size(171, 139);
            this.chlbProfesion.TabIndex = 2;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(247, 369);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(171, 23);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "Mostrar lo que seleccionó";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(92, 428);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 20);
            this.lblMensaje.TabIndex = 4;
            // 
            // Ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 591);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.chlbProfesion);
            this.Controls.Add(this.gbSexo);
            this.Controls.Add(this.gbEstCivil);
            this.Name = "Ejercicio3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 3";
            this.gbEstCivil.ResumeLayout(false);
            this.gbEstCivil.PerformLayout();
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEstCivil;
        private System.Windows.Forms.GroupBox gbSexo;
        private System.Windows.Forms.RadioButton rbCasado;
        private System.Windows.Forms.RadioButton rbSoltero;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.CheckedListBox chlbProfesion;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label lblMensaje;
    }
}