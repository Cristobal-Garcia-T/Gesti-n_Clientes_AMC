using System.Collections.ObjectModel;
using System.ComponentModel;
using AccesoDB.Modelos;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using Servicios;
using Servicios.Mensajes;

namespace ControladoresWPF.UserControls
{
    public partial class GestionConsultoresViewModel : ObservableObject
    {
        private readonly ServicioConsultores _servicioConsultores;
        private readonly IMessenger _messenger;
        [ObservableProperty]
        private Consultor? _consultorSeleccionado;
        public ObservableCollection<Consultor> Consultores { get; set; }
        public RelayCommand EliminarCommand => new(_ => Eliminar(), _ => ConsultorSeleccionado != null);
        public bool PuedeEditarConsultor => ConsultorSeleccionado != null;

        public GestionConsultoresViewModel(ServicioConsultores servicioConsultores, IMessenger messenger)
        {
            _messenger = messenger;
            _servicioConsultores = servicioConsultores;
            Consultores = new ObservableCollection<Consultor>(_servicioConsultores.RecuperarTodos());
            
            _messenger.Register<MensajeNuevoConsultor>(this, (receptor, manipulador) =>
            {
                Consultores.Add(manipulador.Value);
            });
            
            _messenger.Register<MensajeSolicitarConsultorSeleccionado>(this, (receptor, manipulador) =>
            {
                manipulador.Respuesta?.Invoke(ConsultorSeleccionado!);
            });
        }

        private void Eliminar()
        {
            _servicioConsultores.Eliminar(ConsultorSeleccionado!.Id);
            Consultores.Remove(ConsultorSeleccionado!);
        }

        partial void OnConsultorSeleccionadoChanged(Consultor? value)
        {
            OnPropertyChanged(nameof(PuedeEditarConsultor));
        }
    }
}
