using AccesoDB.Modelos;
using Servicios;

namespace ControladoresWPF.Windows.Formularios;

public class FormularioCrearAdminViewModel
{
    private readonly ServicioAdministradores _servicioAdministradores;

    public Administrador NuevoAdministrador { get; set; } = new Administrador
    {
        Id = "",
        Nombre = "",
        Contrasena = "",
        Correo = "",
        Telefono = 0,
        CodigoRecuperación = 0
    };

    public RelayCommand AgregarCommand => new(_ => AgregarAdministrador());
    public FormularioCrearAdminViewModel(ServicioAdministradores servicioAdministradores)
    {
        _servicioAdministradores = servicioAdministradores;
    }

    public void AgregarAdministrador()
    {
        NuevoAdministrador.CodigoRecuperación = new Random().Next(1000, 9999);
        _servicioAdministradores.AgregarAdministrador(NuevoAdministrador);
    }
}