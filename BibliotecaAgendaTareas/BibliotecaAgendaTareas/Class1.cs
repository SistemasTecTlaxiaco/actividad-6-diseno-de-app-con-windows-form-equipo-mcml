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
        // Clase interna para Tarea
        private class Tarea // Define una clase privada interna llamada Tarea.
        {
            public int Id { get; set; } // Propiedad pública para el ID de la tarea.
            public string Titulo { get; set; } // Propiedad pública para el título de la tarea.
            public string Descripcion { get; set; } // Propiedad pública para la descripción de la tarea.
            public DateTime FechaVencimiento { get; set; } // Propiedad pública para la fecha de vencimiento de la tarea.
            public string Categoria { get; set; } // Propiedad pública para la categoría de la tarea.
            public bool Completada { get; set; } // Propiedad pública para el estado de la tarea (completada o no).
            public Tarea(int id, string titulo, string descripcion, DateTime fechaVencimiento, string categoria) // Constructor para inicializar una tarea.
            {
                Id = id; // Asigna el ID de la tarea.
                Titulo = titulo; // Asigna el título de la tarea.
                Descripcion = descripcion; // Asigna la descripción de la tarea.
                FechaVencimiento = fechaVencimiento; // Asigna la fecha de vencimiento.
                Categoria = categoria; // Asigna la categoría de la tarea.
                Completada = false; // Inicializa el estado de la tarea como no completada.
            }
        }
        // Registro de usuario
        public string RegistrarUsuario(string nombreUsuario, string contraseña) // Método para registrar un nuevo usuario.
        {
            if (usuarios.Any(u => u.NombreUsuario == nombreUsuario)) // Verifica si el nombre de usuario ya está en uso.
            {
                return "Error: El nombre de usuario ya está en uso."; // Si el nombre de usuario ya existe, devuelve un mensaje de error.
            }

            usuarios.Add(new Usuario(nombreUsuario, contraseña)); // Si el nombre no está en uso, agrega un nuevo usuario a la lista.
            return "Registro exitoso. Ahora puedes iniciar sesión."; // Devuelve un mensaje indicando que el registro fue exitoso.
        }

        // Inicio de sesión
        public string IniciarSesion(string nombreUsuario, string contraseña) // Método para iniciar sesión con un usuario y contraseña.
        {
            Usuario usuario = usuarios.FirstOrDefault(u => u.NombreUsuario == nombreUsuario && u.Contraseña == contraseña); // Busca el usuario que coincida con el nombre y contraseña.

            if (usuario != null) // Si el usuario existe.
            {
                return $"Inicio de sesión exitoso. Bienvenido, {nombreUsuario}."; // Devuelve un mensaje de bienvenida.
            }
            else
            {
                return "Error: Nombre de usuario o contraseña incorrectos."; // Si no se encuentra el usuario o la contraseña es incorrecta, devuelve un mensaje de error.
            }
        }

        // Agregar tarea con confirmación
        public string AgregarTarea(string titulo, string descripcion, DateTime fechaVencimiento, string categoria) // Método para agregar una nueva tarea.
        {
            Tarea nuevaTarea = new Tarea(contadorId++, titulo, descripcion, fechaVencimiento, categoria); // Crea una nueva tarea con un ID único y los datos proporcionados.
            tareas.Add(nuevaTarea); // Agrega la nueva tarea a la lista de tareas.
            return $"Tarea '{titulo}' agregada exitosamente."; // Devuelve un mensaje confirmando que la tarea fue agregada.
        }
        // Eliminar tarea con mensaje de confirmación
        public string EliminarTarea(int id) // Método para eliminar una tarea según su ID.
        {
            int eliminadas = tareas.RemoveAll(t => t.Id == id); // Elimina todas las tareas que coincidan con el ID.
            return eliminadas > 0 ? $"Tarea con ID {id} eliminada." : "Error: No se encontró la tarea."; // Si se eliminó una tarea, devuelve un mensaje de confirmación. Si no se encontró, devuelve un mensaje de error.
        }

        // Marcar tarea como completada con confirmación
        public string MarcarTareaComoCompletada(int id) // Método para marcar una tarea como completada.
        {
            Tarea tarea = tareas.FirstOrDefault(t => t.Id == id); // Busca la tarea que coincida con el ID.
            if (tarea != null) // Si se encuentra la tarea.
            {
                tarea.Completada = true; // Marca la tarea como completada.
                return $"Tarea '{tarea.Titulo}' marcada como completada."; // Devuelve un mensaje confirmando que la tarea fue marcada como completada.
            }
            return "Error: No se encontró la tarea."; // Si no se encuentra la tarea, devuelve un mensaje de error.
        }


    }

}

