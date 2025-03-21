using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BibliotecaAgendaTareas
{   //Proyecto 
    public class AgendaTareas // Clase principal que gestiona las tareas y usuarios.
    {
        private List<Tarea> tareas; // Lista para almacenar las tareas.
        private List<Usuario> usuarios; // Lista para almacenar los usuarios.
        private int contadorId; // Contador para asignar un ID único a cada tarea.

        public AgendaTareas() // Constructor de la clase AgendaTareas.
        {
            tareas = new List<Tarea>(); // Inicializa la lista de tareas.
            usuarios = new List<Usuario>(); // Inicializa la lista de usuarios.
            contadorId = 1; // Inicializa el contador de ID de tareas.
        }

        // Clase interna que representa a un usuario.
        private class Usuario
        {
            public string NombreUsuario { get; set; } // Propiedad para el nombre de usuario.
            public string Contrasena { get; set; } // Propiedad para la contraseña.

            public Usuario(string nombreUsuario, string contrasena) // Constructor de Usuario.
            {
                NombreUsuario = nombreUsuario; // Asigna el nombre de usuario.
                Contrasena = contrasena; // Asigna la contraseña.
            }
        }

    }
}
