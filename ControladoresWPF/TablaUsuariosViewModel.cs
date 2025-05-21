using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using AccesoDB.Modelos;
using Servicios;

namespace ControladoresWPF;

public class TablaUsuariosViewModel : INotifyPropertyChanged
{
    private readonly ServicioAdministradores _servicio;
    public ObservableCollection<Administrador> ListaAdministradores { get; set; }

    public TablaUsuariosViewModel(ServicioAdministradores servicio)
    {
        _servicio = servicio;
        ListaAdministradores = [];
    }

    public void RecuperarTodos()
    {
        ListaAdministradores = new ObservableCollection<Administrador>(_servicio.RecuperarTodos());
        OnPropertyChanged(nameof(ListaAdministradores));
    }
    public int AgregarAdministrador(List<string> atributos)
    {
        var codigoRecuperacion = new Random().Next(1000, 9999);
        _servicio.AgregarAdministrador(new Administrador
        {
            Id = atributos[0],
            Nombres = atributos[1],
            Apellidos = atributos[2],
            Contrasena = Encriptar(atributos[3]),
            Correo = atributos[4],
            Telefono = atributos[5],
            CodigoRecuperación = codigoRecuperacion
        });
        return codigoRecuperacion;
    }
    
    private string Encriptar(string txt)
    {
        string hash = String.Empty;
        byte[] encriptado = SHA256.HashData(Encoding.UTF8.GetBytes(txt));
        foreach (byte b in encriptado)
        {
            hash += b.ToString("x2");
        }
        return hash;
    }
    public event PropertyChangedEventHandler? PropertyChanged;
    
    protected void OnPropertyChanged([CallerMemberName] string? name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}