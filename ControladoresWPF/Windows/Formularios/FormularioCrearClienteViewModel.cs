using AccesoDB.Modelos;
using CommunityToolkit.Mvvm.Messaging;
using Servicios.Mensajes;

namespace ControladoresWPF.Windows.Formularios;

public class FormularioCrearClienteViewModel
{
    private readonly IMessenger _messenger;
    public Cliente NuevoCliente { get; set; } = new();
    public RelayCommand AgregarCommand => new(_ => AgregarCliente());

    public FormularioCrearClienteViewModel(IMessenger messenger)
    {
        _messenger = messenger;
    }
    public void AgregarCliente()
    {
        _messenger.Send(new MensajeNuevoCliente(NuevoCliente));
    }
}