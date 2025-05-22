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
    //Lista que notifica cambios realizados en esta
    public ObservableCollection<Administrador> ListaAdministradores { get; set; }

    public TablaUsuariosViewModel(ServicioAdministradores servicio)
    {
        _servicio = servicio;
        ListaAdministradores = [];
    }

    public void RecuperarTodos()
    {
        //Actualiza la lista con todos los registros de la tabla y notifica a oyentes del cambio
        ListaAdministradores = new ObservableCollection<Administrador>(_servicio.RecuperarTodos());
        OnPropertyChanged(nameof(ListaAdministradores));
    }
    public int AgregarAdministrador(List<string> atributos)
    {
        //Crea un objeto administrador a partir de los atributos entegados de la vista,
        //genera un código de recuperacióno de 4 digitos aleatorio y encripta la contraseña
        //en un hash usando SHA-256
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
        //Retorna un hash en formato string a partir de una cadena de texto,
        //usa el algoritmo SHA-256 para generar el hash
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
        //Notifica el cambio realizado en una propiedad del ViewModel
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}