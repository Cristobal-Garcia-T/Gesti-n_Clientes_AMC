using AccesoDB.Modelos;
using CommunityToolkit.Mvvm.Messaging.Messages;

namespace ControladoresWPF.Mensajes;

public class MensajeNuevoConsultor : ValueChangedMessage<Consultor>
{
    public MensajeNuevoConsultor(Consultor consultor) : base(consultor) { }
}