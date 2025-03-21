namespace Botonpersonalizado
{
    partial class Form5
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
            this.Trabajo = new CustomControls.RJControls.RJButton();
            this.Personal = new CustomControls.RJControls.RJButton();
            this.Metas = new CustomControls.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // Trabajo
            // 
            this.Trabajo.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Trabajo.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Trabajo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Trabajo.BorderRadius = 0;
            this.Trabajo.BorderSize = 0;
            this.Trabajo.FlatAppearance.BorderSize = 0;
            this.Trabajo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Trabajo.ForeColor = System.Drawing.Color.White;
            this.Trabajo.Location = new System.Drawing.Point(23, 12);
            this.Trabajo.Name = "Trabajo";
            this.Trabajo.Size = new System.Drawing.Size(150, 40);
            this.Trabajo.TabIndex = 0;
            this.Trabajo.Text = "Trabajo";
            this.Trabajo.TextColor = System.Drawing.Color.White;
            this.Trabajo.UseVisualStyleBackColor = false;
            this.Trabajo.Click += new System.EventHandler(this.Trabajo_Click);
            // 
            // Personal
            // 
            this.Personal.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Personal.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Personal.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Personal.BorderRadius = 0;
            this.Personal.BorderSize = 0;
            this.Personal.FlatAppearance.BorderSize = 0;
            this.Personal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Personal.ForeColor = System.Drawing.Color.White;
            this.Personal.Location = new System.Drawing.Point(23, 78);
            this.Personal.Name = "Personal";
            this.Personal.Size = new System.Drawing.Size(150, 40);
            this.Personal.TabIndex = 1;
            this.Personal.Text = "Personal";
            this.Personal.TextColor = System.Drawing.Color.White;
            this.Personal.UseVisualStyleBackColor = false;
            this.Personal.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // Metas
            // 
            this.Metas.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Metas.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Metas.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Metas.BorderRadius = 0;
            this.Metas.BorderSize = 0;
            this.Metas.FlatAppearance.BorderSize = 0;
            this.Metas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Metas.ForeColor = System.Drawing.Color.White;
            this.Metas.Location = new System.Drawing.Point(23, 141);
            this.Metas.Name = "Metas";
            this.Metas.Size = new System.Drawing.Size(150, 40);
            this.Metas.TabIndex = 2;
            this.Metas.Text = "Meta";
            this.Metas.TextColor = System.Drawing.Color.White;
            this.Metas.UseVisualStyleBackColor = false;
            this.Metas.Click += new System.EventHandler(this.Metas_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 210);
            this.Controls.Add(this.Metas);
            this.Controls.Add(this.Personal);
            this.Controls.Add(this.Trabajo);
            this.Name = "Form5";
            this.Text = "Categoria";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RJControls.RJButton Trabajo;
        private CustomControls.RJControls.RJButton Personal;
        private CustomControls.RJControls.RJButton Metas;
    }
}