using AccesoDB.Modelos;
using Servicios;

namespace ControladoresWPF.Windows.Formularios;

public class FormularioCrearConsultorViewModel
{
    private readonly ServicioConsultores _servicioConsultores;
    public Consultor NuevoConsultor { get; set; } = new();
    public RelayCommand AgregarCommand => new(_ => AgregarConsultor());

    public FormularioCrearConsultorViewModel(ServicioConsultores servicioConsultore)
    {
        _servicioConsultores = servicioConsultore;
    }
    public void AgregarConsultor()
    {
        _servicioConsultores.AgregarConsultor(NuevoConsultor);
    }
}