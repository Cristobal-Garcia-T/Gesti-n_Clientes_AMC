using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using AccesoDB.Modelos;
using Servicios;

namespace ControladoresWPF;

public class VistaAdminViewModel
{
    private readonly ServicioAdministradores _servicio;
    public ObservableCollection<Administrador> ListaAdministradores { get; set; }

    public VistaAdminViewModel(ServicioAdministradores servicio)
    {
        _servicio = servicio;
        ListaAdministradores = new ObservableCollection<Administrador>(servicio.RecuperarTodos());
    }
}