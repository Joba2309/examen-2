using System.Collections.Generic;

namespace Capa_Datos
{
    public interface IDataAccessLayer
    {
        void AgregarEquipo(Equipo equipo);
        void AgregarTecnico(Tecnico tecnico);
        void AgregarUsuario(Usuario usuario);
        void BorrarEquipo(int equipoId);
        void BorrarTecnico(int tecnicoId);
        void BorrarUsuario(int usuarioId);
        List<Equipo> ConsultarEquiposPorEstado(string estado);
        void ModificarDescripcionEquipo(int equipoId, string nuevaDescripcion);
    }
}