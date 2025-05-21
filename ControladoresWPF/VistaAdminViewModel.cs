using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using AccesoDB.Modelos;
using Servicios;

namespace ControladoresWPF;

public class VistaAdminViewModel : INotifyPropertyChanged
{
    private readonly ServicioAdministradores _servicio;
    public ObservableCollection<Administrador> ListaAdministradores { get; set; }

    public VistaAdminViewModel(ServicioAdministradores servicio)
    {
        _servicio = servicio;
        ListaAdministradores = [];
    }

    public void RecuperarTodos()
    {
        ListaAdministradores = new ObservableCollection<Administrador>(_servicio.RecuperarTodos());
        OnPropertyChanged(nameof(ListaAdministradores));
    }
    public void AgregarAdministrador(Administrador admin)
    {
        
    }
    public event PropertyChangedEventHandler? PropertyChanged;
    
    protected void OnPropertyChanged([CallerMemberName] string? name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}