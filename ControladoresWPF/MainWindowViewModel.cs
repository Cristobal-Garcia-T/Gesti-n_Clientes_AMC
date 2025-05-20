using AccesoDB.Modelos;
using Servicios;

namespace ControladoresWPF;

public class MainWindowViewModel
{
    private readonly ServicioAdministradores _servicioAdministradores;
    
    public MainWindowViewModel(ServicioAdministradores servicioAdministradores)
    {
        _servicioAdministradores = servicioAdministradores;
    }

    public bool AdminNoExistente() => _servicioAdministradores.TablaVacia();
    
}