using AccesoDB.Modelos;
using Servicios;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace ControladoresWPF
{
    public class GestionConsultoresViewModel : INotifyPropertyChanged
    {
        private readonly ServicioConsultores _servicioConsultores;
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

        public GestionConsultoresViewModel(ServicioConsultores servicioConsultores)
        {
            _servicioConsultores = servicioConsultores;
            Consultores = new ObservableCollection<Consultor>(_servicioConsultores.ObtenerTodos());
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
