using AccesoDB.Modelos;

namespace Servicios.Mensajes;

public class MensajeSolicitarConsultorSeleccionado
{
    public Action<Consultor> Respuesta { get; }

    public MensajeSolicitarConsultorSeleccionado(Action<Consultor> respuesta)
    {
        Respuesta = respuesta;
    }
}