using AccesoDB.Modelos;
using CommunityToolkit.Mvvm.Messaging;
using Servicios;
using Servicios.Mensajes;

namespace ControladoresWPF.Windows.Formularios;

public class FormularioActualizarConsultorViewModel
{
    private IServicio<Consultor> _servicio;
    public RelayCommand EditarCommand => new(_ => EditarConsultor());
    public Consultor ConsultorSeleccionado { get; set; } = new Consultor
    {
        Id = 0,
        Rut = "",
        Nombre = "",
        Contrasena = "",
        Correo = "",
        Telefono = 0,
        NumeroClientes = 0,
        NumeroCasos = 0
    };
    
    public Consultor NuevoConsultor { get; set; } = new Consultor
    {
        Id = 0,
        Rut = "",
        Nombre = "",
        Contrasena = "",
        Correo = "",
        Telefono = 0,
        NumeroClientes = 0,
        NumeroCasos = 0
    };

    public FormularioActualizarConsultorViewModel(IServicio<Consultor> servicio, IMessenger mensaje)
    {
        _servicio = servicio;
        mensaje.Send(new MensajeSolicitarConsultorSeleccionado(respuesta =>
        {
            ConsultorSeleccionado = respuesta;
            NuevoConsultor = respuesta;
        }));
    }

    public void EditarConsultor()
    {
        _servicio.Editar(ConsultorSeleccionado.Id, NuevoConsultor);
    }
}