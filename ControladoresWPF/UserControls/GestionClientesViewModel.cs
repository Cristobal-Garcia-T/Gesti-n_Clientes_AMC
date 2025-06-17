using System.Collections.ObjectModel;
using AccesoDB.Modelos;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using Servicios;
using Servicios.Mensajes;

namespace ControladoresWPF.UserControls;

public partial class GestionClientesViewModel : ObservableObject
{
    private readonly ServicioClientes _servicioClientes;

    [ObservableProperty]
    private Cliente? _clienteSeleccionado;

    private readonly int _usuarioActual;
    public RelayCommand EliminarCommand => new(_ => EliminarCliente(), _ => ClienteSeleccionado != null);
    public bool PuedeEditarCliente => ClienteSeleccionado != null;
    
    public ObservableCollection<Cliente> Clientes { get; set; }
    public GestionClientesViewModel(ServicioClientes servicioClientes, int usuarioLogueadoId, IMessenger messenger)
    {
        _usuarioActual = usuarioLogueadoId;
        _servicioClientes = servicioClientes;
        Clientes = new ObservableCollection<Cliente>(_servicioClientes.RecuperarTodos().Where(c => c.ConsultorId == _usuarioActual).ToList());
        
        messenger.Register<MensajeNuevoCliente>(this, (receptor, manipulador) =>
        {
            if (Clientes.Contains(manipulador.Value))
                EditarCliente(manipulador.Value);
            else
                AgregarCliente(manipulador.Value);
        });
            
        messenger.Register<MensajeSolicitarClienteSeleccionado>(this, (receptor, manipulador) =>
        {
            manipulador.Respuesta.Invoke(ClienteSeleccionado!);
        });
    }
    
    private void AgregarCliente(Cliente cliente)
    {
        cliente.ConsultorId = _usuarioActual;
        Clientes.Add(cliente);
        _servicioClientes.Agregar(cliente);
    }

    private void EditarCliente(Cliente cliente)
    {
        Clientes.Remove(cliente);
        Clientes.Add(cliente);
        _servicioClientes.Editar(cliente);
    }

    public void EliminarCliente()
    {
        _servicioClientes.Eliminar(ClienteSeleccionado!.Id);
        Clientes.Remove(ClienteSeleccionado!);
    }
    
    partial void OnClienteSeleccionadoChanged(Cliente? value)
    {
        OnPropertyChanged(nameof(PuedeEditarCliente));
    }
}