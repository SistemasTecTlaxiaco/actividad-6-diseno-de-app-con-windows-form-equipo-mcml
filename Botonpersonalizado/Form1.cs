using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaAgendaTareas;

namespace Botonpersonalizado
{
    public partial class Form1 : Form
    {
        private AgendaTareas agenda;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //TextChanged

        }

        private void rjTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void rjTextBox7__TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("text Changed");
        }

        private void rjTextBox5__TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        // Método para validar que los campos no estén vacíos
        private bool ValidarDatos()
        {
            return !string.IsNullOrWhiteSpace(rjTextBox1.Text) && !string.IsNullOrWhiteSpace(rjTextBox5.Text);
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                // Llamar a la biblioteca para iniciar sesión
                string resultado = agenda.IniciarSesion(rjTextBox1.Text, rjTextBox5.Text);

                if (resultado.StartsWith("Inicio de sesión exitoso")) // Verifica que el inicio sea exitoso
                {
                    // Mostrar mensaje de confirmación
                    DialogResult result = MessageBox.Show("Los datos son correctos. ¿Deseas continuar?",
                                                          "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Abrir Form3 y ocultar el Form1
                        Form3 form3 = new Form3();
                        form3.Show();
                        this.Hide();
                    }
                }
                else
                {
                    // Mostrar mensaje de error devuelto por la biblioteca
                    MessageBox.Show(resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    rjTextBox1.Focus(); // Enfocar el campo para corrección
                }
            }
            else
            {
                // Mensaje de error si los campos están vacíos
                MessageBox.Show("Por favor, ingresa tu correo y contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rjTextBox1.Focus();
            }
        }

        private void rjButton2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
