using AccesoDB.Modelos;
using CommunityToolkit.Mvvm.Messaging.Messages;

namespace Servicios.Mensajes;

public class MensajeNuevoConsultor : ValueChangedMessage<Consultor>
{
    public MensajeNuevoConsultor(Consultor consultor) : base(consultor) { }
}