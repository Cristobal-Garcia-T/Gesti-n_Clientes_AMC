using System.Collections.ObjectModel;
using AccesoDB.Modelos;
using Servicios;

namespace ControladoresWPF.UserControls;

public class GestionClientesViewModel
{
    private readonly ServicioClientesNaturales _servicioClientesNaturales;
    private readonly ServicioEmpresas _servicioEmpresas;
    
    public ObservableCollection<ClienteNatural> ClientesNaturales { get; set; }
    public ObservableCollection<Empresa> Empresas { get; set; }
    public GestionClientesViewModel(ServicioClientesNaturales servicioClientesNaturales, ServicioEmpresas servicioEmpresas)
    {
        _servicioClientesNaturales = servicioClientesNaturales;
        _servicioEmpresas = servicioEmpresas;
    }
}