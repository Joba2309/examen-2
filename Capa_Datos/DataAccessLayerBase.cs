using System.Collections.Generic;

namespace Capa_Datos
{
    public class DataAccessLayerBase
    {
        // Métodos para Equipos
        public void AgregarEquipo(Equipo equipo) { /* Lógica para agregar un equipo a la base de datos */ }
        // Y así sucesivamente para las operaciones de usuarios...

        // Métodos para Técnicos
        public void AgregarTecnico(Tecnico tecnico) { /* Lógica para agregar un técnico a la base de datos */ }

        // Métodos para Usuarios
        public void AgregarUsuario(Usuario usuario) { /* Lógica para agregar un usuario a la base de datos */ }
        public void BorrarEquipo(int equipoId) { /* Lógica para borrar un equipo de la base de datos por ID */ }
        public void BorrarTecnico(int tecnicoId) { /* Lógica para borrar un técnico de la base de datos por ID */ }
        public void BorrarUsuario(int usuarioId) { /* Lógica para borrar un usuario de la base de datos por ID */ }
        public List<Equipo> ConsultarEquiposPorEstado(string estado) { /* Lógica para consultar equipos por estado */ }
        public void ModificarDescripcionEquipo(int equipoId, string nuevaDescripcion) { /* Lógica para modificar la descripción de un equipo por su ID */ }
    }
}