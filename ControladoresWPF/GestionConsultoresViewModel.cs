using AccesoDB.Modelos;
using Servicios;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace ControladoresWPF
{
    public class GestionConsultoresViewModel : INotifyPropertyChanged
    {
        private readonly ServicioConsultores _servicio = new ServicioConsultores();

        public ObservableCollection<Consultor> Consultores { get; set; }
        private Consultor? _consultorSeleccionado;
        public Consultor? ConsultorSeleccionado
        {
            get => _consultorSeleccionado;
            set { _consultorSeleccionado = value; OnPropertyChanged(nameof(ConsultorSeleccionado)); }
        }

        public ICommand CrearCommand { get; }
        public ICommand ActualizarCommand { get; }
        public ICommand EliminarCommand { get; }

        public GestionConsultoresViewModel()
        {
            Consultores = new ObservableCollection<Consultor>(_servicio.ObtenerTodos());

            CrearCommand = new RelayCommand(_ => Crear());
            ActualizarCommand = new RelayCommand(_ => Actualizar(), _ => ConsultorSeleccionado != null);
            EliminarCommand = new RelayCommand(_ => Eliminar(), _ => ConsultorSeleccionado != null);
        }

        private void Crear()
        {
            var nuevo = new Consultor { NombreUsuario = "nuevo", Contrasena = "1234" };
            _servicio.Crear(nuevo);
            Consultores.Add(nuevo);
        }

        private void Actualizar()
        {
            if (ConsultorSeleccionado != null)
{
    _servicio.Actualizar(ConsultorSeleccionado);
}

        }

        private void Eliminar()
        {
if (ConsultorSeleccionado?.Id != null)
{
     _servicio.Eliminar(ConsultorSeleccionado.Id);
     Consultores.Remove(ConsultorSeleccionado);
}

        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string nombre) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));
    }
}
