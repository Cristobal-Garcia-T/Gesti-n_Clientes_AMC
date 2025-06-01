using System.Collections.ObjectModel;
using System.ComponentModel;
using AccesoDB.Modelos;
using CommunityToolkit.Mvvm.Messaging;
using ControladoresWPF.Mensajes;
using Servicios;

namespace ControladoresWPF.UserControls
{
    public class GestionConsultoresViewModel : INotifyPropertyChanged
    {
        private readonly ServicioConsultores _servicioConsultores;
        private readonly IMessenger _messenger;
        private Consultor? _consultorSeleccionado;
        public Consultor? ConsultorSeleccionado
        {
            get => _consultorSeleccionado;
            set
            {
                _consultorSeleccionado = value; 
                OnPropertyChanged(nameof(ConsultorSeleccionado));
            }
        }
        public ObservableCollection<Consultor> Consultores { get; set; }
        public RelayCommand ActualizarCommand => new(_ => Actualizar(), _ => ConsultorSeleccionado != null);
        public RelayCommand EliminarCommand => new(_ => Eliminar(), _ => ConsultorSeleccionado != null);

        public GestionConsultoresViewModel(ServicioConsultores servicioConsultores, IMessenger messenger)
        {
            _messenger = messenger;
            _servicioConsultores = servicioConsultores;
            Consultores = new ObservableCollection<Consultor>(_servicioConsultores.ObtenerTodos());
            
            _messenger.Register<MensajeNuevoConsultor>(this, (receptor, manipulador) =>
            {
                Consultores.Add(manipulador.Value);
            });
        }
        
        private void Actualizar()
        {
            _servicioConsultores.Actualizar(ConsultorSeleccionado!);
        }

        private void Eliminar()
        {
            _servicioConsultores.Eliminar(ConsultorSeleccionado?.Id);
            Consultores.Remove(ConsultorSeleccionado!);
        }
        
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string nombre) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));
    }
}
