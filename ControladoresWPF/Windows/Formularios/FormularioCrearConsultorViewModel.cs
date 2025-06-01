using AccesoDB.Modelos;
using CommunityToolkit.Mvvm.Messaging;
using ControladoresWPF.Mensajes;
using Servicios;

namespace ControladoresWPF.Windows.Formularios;

public class FormularioCrearConsultorViewModel
{
    private readonly ServicioConsultores _servicioConsultores;
    private readonly IMessenger _messenger;
    public Consultor NuevoConsultor { get; set; } = new();
    public RelayCommand AgregarCommand => new(_ => AgregarConsultor());

    public FormularioCrearConsultorViewModel(ServicioConsultores servicioConsultores, IMessenger messenger)
    {
        _messenger = messenger;
        _servicioConsultores = servicioConsultores;
    }
    public void AgregarConsultor()
    {
        _servicioConsultores.AgregarConsultor(NuevoConsultor);
        _messenger.Send(new MensajeNuevoConsultor(NuevoConsultor));
    }
}