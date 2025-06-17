using AccesoDB.Modelos;

namespace Servicios.Mensajes;

public class MensajeSolicitarClienteSeleccionado
{
    public Action<Cliente> Respuesta { get; }

    public MensajeSolicitarClienteSeleccionado(Action<Cliente> respuesta)
    {
        Respuesta = respuesta;
    }
}