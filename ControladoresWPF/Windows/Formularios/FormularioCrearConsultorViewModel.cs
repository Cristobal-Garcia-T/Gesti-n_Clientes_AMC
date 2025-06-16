using AccesoDB.Modelos;
using CommunityToolkit.Mvvm.Messaging;
using Servicios.Mensajes;

namespace ControladoresWPF.Windows.Formularios;

public class FormularioCrearConsultorViewModel
{
    private readonly IMessenger _messenger;
    public Consultor NuevoConsultor { get; set; } = new();
    public RelayCommand AgregarCommand => new(_ => AgregarConsultor());

    public FormularioCrearConsultorViewModel(IMessenger messenger)
    {
        _messenger = messenger;
    }
    public void AgregarConsultor()
    {
        _messenger.Send(new MensajeNuevoConsultor(NuevoConsultor));
    }
}