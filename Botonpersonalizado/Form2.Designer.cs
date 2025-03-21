namespace Botonpersonalizado
{
    partial class Form2
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
            this.Usuario = new Botonpersonalizado.RJTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Continuar = new CustomControls.RJControls.RJButton();
            this.Contrasena2 = new Botonpersonalizado.RJTextBox();
            this.Contrasena = new Botonpersonalizado.RJTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Usuario
            // 
            this.Usuario.BackColor = System.Drawing.SystemColors.Window;
            this.Usuario.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.Usuario.BorderFocusColor = System.Drawing.Color.Navy;
            this.Usuario.BorderSize = 2;
            this.Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario.ForeColor = System.Drawing.Color.DimGray;
            this.Usuario.Location = new System.Drawing.Point(18, 32);
            this.Usuario.Margin = new System.Windows.Forms.Padding(4);
            this.Usuario.Multiline = false;
            this.Usuario.Name = "Usuario";
            this.Usuario.Padding = new System.Windows.Forms.Padding(7);
            this.Usuario.PasswordChar = false;
            this.Usuario.Size = new System.Drawing.Size(250, 39);
            this.Usuario.TabIndex = 0;
            this.Usuario.Texts = "";
            this.Usuario.UnderlinedStyle = false;
            this.Usuario._TextChanged += new System.EventHandler(this.Usuario__TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.Continuar);
            this.panel1.Controls.Add(this.Contrasena2);
            this.panel1.Controls.Add(this.Contrasena);
            this.panel1.Controls.Add(this.Usuario);
            this.panel1.Location = new System.Drawing.Point(263, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 274);
            this.panel1.TabIndex = 1;
            // 
            // Continuar
            // 
            this.Continuar.BackColor = System.Drawing.Color.RoyalBlue;
            this.Continuar.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.Continuar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Continuar.BorderRadius = 0;
            this.Continuar.BorderSize = 0;
            this.Continuar.FlatAppearance.BorderSize = 0;
            this.Continuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Continuar.ForeColor = System.Drawing.Color.White;
            this.Continuar.Location = new System.Drawing.Point(68, 200);
            this.Continuar.Name = "Continuar";
            this.Continuar.Size = new System.Drawing.Size(150, 40);
            this.Continuar.TabIndex = 3;
            this.Continuar.Text = "Continuar";
            this.Continuar.TextColor = System.Drawing.Color.White;
            this.Continuar.UseVisualStyleBackColor = false;
            this.Continuar.Click += new System.EventHandler(this.Continuar_Click);
            // 
            // Contrasena2
            // 
            this.Contrasena2.BackColor = System.Drawing.SystemColors.Window;
            this.Contrasena2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.Contrasena2.BorderFocusColor = System.Drawing.Color.Navy;
            this.Contrasena2.BorderSize = 2;
            this.Contrasena2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contrasena2.ForeColor = System.Drawing.Color.DimGray;
            this.Contrasena2.Location = new System.Drawing.Point(18, 126);
            this.Contrasena2.Margin = new System.Windows.Forms.Padding(4);
            this.Contrasena2.Multiline = false;
            this.Contrasena2.Name = "Contrasena2";
            this.Contrasena2.Padding = new System.Windows.Forms.Padding(7);
            this.Contrasena2.PasswordChar = true;
            this.Contrasena2.Size = new System.Drawing.Size(250, 39);
            this.Contrasena2.TabIndex = 2;
            this.Contrasena2.Texts = "";
            this.Contrasena2.UnderlinedStyle = false;
            this.Contrasena2._TextChanged += new System.EventHandler(this.Contrasena2__TextChanged);
            // 
            // Contrasena
            // 
            this.Contrasena.BackColor = System.Drawing.SystemColors.Window;
            this.Contrasena.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.Contrasena.BorderFocusColor = System.Drawing.Color.Navy;
            this.Contrasena.BorderSize = 2;
            this.Contrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contrasena.ForeColor = System.Drawing.Color.DimGray;
            this.Contrasena.Location = new System.Drawing.Point(18, 79);
            this.Contrasena.Margin = new System.Windows.Forms.Padding(4);
            this.Contrasena.Multiline = false;
            this.Contrasena.Name = "Contrasena";
            this.Contrasena.Padding = new System.Windows.Forms.Padding(7);
            this.Contrasena.PasswordChar = false;
            this.Contrasena.Size = new System.Drawing.Size(250, 39);
            this.Contrasena.TabIndex = 1;
            this.Contrasena.Texts = "";
            this.Contrasena.UnderlinedStyle = false;
            this.Contrasena._TextChanged += new System.EventHandler(this.Contrasena__TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Registro de usuario";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RJTextBox Usuario;
        private System.Windows.Forms.Panel panel1;
        private CustomControls.RJControls.RJButton Continuar;
        private RJTextBox Contrasena2;
        private RJTextBox Contrasena;
    }
}