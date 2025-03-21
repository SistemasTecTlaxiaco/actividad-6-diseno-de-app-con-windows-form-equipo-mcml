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
    public partial class Form2 : Form
    {
        private AgendaTareas agenda;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Usuario__TextChanged(object sender, EventArgs e)
        {

        }

        private void Contrasena__TextChanged(object sender, EventArgs e)
        {

        }

        private void Contrasena2__TextChanged(object sender, EventArgs e)
        {

        }

        private void Continuar_Click(object sender, EventArgs e)
        {
            try
            {
                string resultado = agenda.RegistrarUsuario(Usuario.Text, Contrasena.Text);
                MessageBox.Show(resultado, "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
