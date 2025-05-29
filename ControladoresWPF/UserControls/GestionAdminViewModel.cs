using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using AccesoDB.Modelos;
using Servicios;

namespace ControladoresWPF.UserControls;

public class GestionAdminViewModel : INotifyPropertyChanged
{
    private readonly ServicioAdministradores _servicioAdministradores;
    //Lista que notifica cambios realizados en esta
    public ObservableCollection<Administrador> ListaAdministradores { get; set; }

    public GestionAdminViewModel(ServicioAdministradores servicioAdministradores)
    {
        _servicioAdministradores = servicioAdministradores;
        ListaAdministradores = [];
    }

    public void RecuperarTodos()
    {
        //Actualiza la lista con todos los registros de la tabla y notifica a oyentes del cambio
        ListaAdministradores = new ObservableCollection<Administrador>(_servicioAdministradores.RecuperarTodos());
        OnPropertyChanged(nameof(ListaAdministradores));
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    
    protected void OnPropertyChanged([CallerMemberName] string? name = null)
    {
        //Notifica el cambio realizado en una propiedad del ViewModel
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}