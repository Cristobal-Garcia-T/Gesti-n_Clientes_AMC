using AccesoDB.Modelos;
using Servicios;

namespace ControladoresWPF;

public class FormularioCrearAdminViewModel
{
    private readonly ServicioAdministradores _servicioAdministradores;
        
    public FormularioCrearAdminViewModel(ServicioAdministradores servicioAdministradores)
    {
        _servicioAdministradores = servicioAdministradores;
    }

    public void AgregarAdministrador(Administrador administrador)
    {
        _servicioAdministradores.AgregarAdministrador(administrador);
    }
}