namespace Botonpersonalizado
{
    partial class Form4
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
            this.Titulo = new Botonpersonalizado.RJTextBox();
            this.Descrpcion = new Botonpersonalizado.RJTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Categorias = new System.Windows.Forms.Label();
            this.Fecha = new Botonpersonalizado.RJTextBox();
            this.GuardarTareas = new CustomControls.RJControls.RJButton();
            this.IrAgregarCategoria = new CustomControls.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.BackColor = System.Drawing.SystemColors.Window;
            this.Titulo.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.Titulo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Titulo.BorderSize = 2;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.DimGray;
            this.Titulo.Location = new System.Drawing.Point(193, 99);
            this.Titulo.Multiline = false;
            this.Titulo.Name = "Titulo";
            this.Titulo.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Titulo.PasswordChar = false;
            this.Titulo.Size = new System.Drawing.Size(204, 37);
            this.Titulo.TabIndex = 0;
            this.Titulo.Texts = "Titulo";
            this.Titulo.UnderlinedStyle = false;
            this.Titulo._TextChanged += new System.EventHandler(this.rjTextBox1__TextChanged);
            // 
            // Descrpcion
            // 
            this.Descrpcion.BackColor = System.Drawing.SystemColors.Window;
            this.Descrpcion.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.Descrpcion.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Descrpcion.BorderSize = 2;
            this.Descrpcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descrpcion.ForeColor = System.Drawing.Color.DimGray;
            this.Descrpcion.Location = new System.Drawing.Point(193, 158);
            this.Descrpcion.Multiline = false;
            this.Descrpcion.Name = "Descrpcion";
            this.Descrpcion.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Descrpcion.PasswordChar = false;
            this.Descrpcion.Size = new System.Drawing.Size(204, 37);
            this.Descrpcion.TabIndex = 1;
            this.Descrpcion.Texts = "Descripcion";
            this.Descrpcion.UnderlinedStyle = false;
            this.Descrpcion._TextChanged += new System.EventHandler(this.rjTextBox2__TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Agenta de tarreas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Titulo de la tarea";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Categorias
            // 
            this.Categorias.AutoSize = true;
            this.Categorias.Location = new System.Drawing.Point(231, 275);
            this.Categorias.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Categorias.Name = "Categorias";
            this.Categorias.Size = new System.Drawing.Size(86, 20);
            this.Categorias.TabIndex = 4;
            this.Categorias.Text = "Categorias";
            this.Categorias.Click += new System.EventHandler(this.Categorias_Click);
            // 
            // Fecha
            // 
            this.Fecha.BackColor = System.Drawing.SystemColors.Window;
            this.Fecha.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.Fecha.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Fecha.BorderSize = 2;
            this.Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha.ForeColor = System.Drawing.Color.DimGray;
            this.Fecha.Location = new System.Drawing.Point(193, 211);
            this.Fecha.Multiline = false;
            this.Fecha.Name = "Fecha";
            this.Fecha.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Fecha.PasswordChar = false;
            this.Fecha.Size = new System.Drawing.Size(204, 37);
            this.Fecha.TabIndex = 5;
            this.Fecha.Texts = "Fecha";
            this.Fecha.UnderlinedStyle = false;
            this.Fecha._TextChanged += new System.EventHandler(this.rjTextBox3__TextChanged);
            // 
            // GuardarTareas
            // 
            this.GuardarTareas.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.GuardarTareas.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.GuardarTareas.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.GuardarTareas.BorderRadius = 0;
            this.GuardarTareas.BorderSize = 0;
            this.GuardarTareas.FlatAppearance.BorderSize = 0;
            this.GuardarTareas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuardarTareas.ForeColor = System.Drawing.Color.White;
            this.GuardarTareas.Location = new System.Drawing.Point(235, 306);
            this.GuardarTareas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GuardarTareas.Name = "GuardarTareas";
            this.GuardarTareas.Size = new System.Drawing.Size(112, 32);
            this.GuardarTareas.TabIndex = 6;
            this.GuardarTareas.Text = "Guardar";
            this.GuardarTareas.TextColor = System.Drawing.Color.White;
            this.GuardarTareas.UseVisualStyleBackColor = false;
            this.GuardarTareas.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // IrAgregarCategoria
            // 
            this.IrAgregarCategoria.BackColor = System.Drawing.Color.GhostWhite;
            this.IrAgregarCategoria.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.IrAgregarCategoria.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.IrAgregarCategoria.BorderRadius = 0;
            this.IrAgregarCategoria.BorderSize = 0;
            this.IrAgregarCategoria.FlatAppearance.BorderSize = 0;
            this.IrAgregarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IrAgregarCategoria.ForeColor = System.Drawing.Color.White;
            this.IrAgregarCategoria.Image = global::Botonpersonalizado.Properties.Resources.Captura_de_pantalla_2025_03_20_205858;
            this.IrAgregarCategoria.Location = new System.Drawing.Point(321, 275);
            this.IrAgregarCategoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IrAgregarCategoria.Name = "IrAgregarCategoria";
            this.IrAgregarCategoria.Size = new System.Drawing.Size(36, 20);
            this.IrAgregarCategoria.TabIndex = 7;
            this.IrAgregarCategoria.TextColor = System.Drawing.Color.White;
            this.IrAgregarCategoria.UseVisualStyleBackColor = false;
            this.IrAgregarCategoria.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.IrAgregarCategoria);
            this.Controls.Add(this.GuardarTareas);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.Categorias);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Descrpcion);
            this.Controls.Add(this.Titulo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form4";
            this.Text = "agregar tarea ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJTextBox Titulo;
        private RJTextBox Descrpcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Categorias;
        private RJTextBox Fecha;
        private CustomControls.RJControls.RJButton GuardarTareas;
        private CustomControls.RJControls.RJButton IrAgregarCategoria;
    }
}