using Servicios;

namespace ControladoresWPF;

public class MainWindowViewModel
{
    private readonly ServicioAdministradores _servicioAdministradores;
    
    public MainWindowViewModel(ServicioAdministradores servicioAdministradores)
    {
        _servicioAdministradores = servicioAdministradores;
    }

    //Indica que no hay administradores registrados
    public bool AdminNoExistente() => _servicioAdministradores.TablaVacia();
    
}