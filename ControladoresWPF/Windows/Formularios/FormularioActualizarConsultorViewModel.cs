using AccesoDB.Modelos;
using CommunityToolkit.Mvvm.Messaging;
using Servicios;
using Servicios.Mensajes;

namespace ControladoresWPF.Windows.Formularios;

public class FormularioActualizarConsultorViewModel
{
    private IMessenger _messenger;
    public RelayCommand EditarCommand => new(_ => EditarConsultor());
    public Consultor ConsultorSeleccionado { get; set; } = new();

    public FormularioActualizarConsultorViewModel(IMessenger mensaje)
    {
        _messenger = mensaje;
        _messenger.Send(new MensajeSolicitarConsultorSeleccionado(respuesta =>
        {
            ConsultorSeleccionado = new Consultor
            {
                Id = respuesta.Id,
                Rut = respuesta.Rut,
                Nombre = respuesta.Nombre,
                Contrasena = respuesta.Contrasena,
                Correo = respuesta.Correo,
                Telefono = respuesta.Telefono,
                NumeroCasos = respuesta.NumeroCasos,
                NumeroClientes = respuesta.NumeroClientes,
                Casos = respuesta.Casos,
                Clientes = respuesta.Clientes
            };
        }));
    }

    public void EditarConsultor()
    {
        _messenger.Send(new MensajeNuevoConsultor(ConsultorSeleccionado));
    }
}   