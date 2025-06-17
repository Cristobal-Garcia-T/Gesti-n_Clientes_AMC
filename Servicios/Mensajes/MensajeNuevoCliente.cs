using AccesoDB.Modelos;
using CommunityToolkit.Mvvm.Messaging.Messages;

namespace Servicios.Mensajes;

public class MensajeNuevoCliente : ValueChangedMessage<Cliente>
{
    public MensajeNuevoCliente(Cliente cliente) : base(cliente) { }
}