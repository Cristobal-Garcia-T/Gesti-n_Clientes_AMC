using AccesoDB.Modelos;
using CommunityToolkit.Mvvm.Messaging;
using Servicios.Mensajes;

namespace ControladoresWPF.Windows.Formularios;

public class FormularioActualizarClienteViewModel
{
    private IMessenger _messenger;
    public RelayCommand EditarCommand => new(_ => EditarCliente());
    public Cliente ClienteSeleccionado { get; set; } = new();

    public FormularioActualizarClienteViewModel(IMessenger mensaje)
    {
        _messenger = mensaje;
        _messenger.Send(new MensajeSolicitarClienteSeleccionado(respuesta =>
        {
            ClienteSeleccionado = new Cliente()
            {
                Id = respuesta.Id,
                Rut = respuesta.Rut,
                Nombre = respuesta.Nombre,
                Correo = respuesta.Correo,
                Direccion = respuesta.Direccion,
                Telefono = respuesta.Telefono,
                NumeroCasos = respuesta.NumeroCasos,
                Tipo = respuesta.Tipo,
                Actividad = respuesta.Actividad,
                Casos = respuesta.Casos,
                ConsultorId = respuesta.ConsultorId,
                Consultor = respuesta.Consultor,
            };
        }));
    }

    public void EditarCliente()
    {
        _messenger.Send(new MensajeNuevoCliente(ClienteSeleccionado));
    }
}