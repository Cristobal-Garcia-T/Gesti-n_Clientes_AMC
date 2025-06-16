using AccesoDB.Modelos;
using Servicios;

namespace ControladoresWPF.UserControls;

public class LoginViewModel
{
    private readonly ServicioLogin _servicioLogin;
    public LoginViewModel(ServicioLogin servicioLogin)
    {
        _servicioLogin = servicioLogin;
    }

    public Usuario? Login(string rut, string? pass, string? tipo)
    {
        return _servicioLogin.Login(rut, pass, tipo);
    }

    public void Logout()
    {
        _servicioLogin.Logout();
    }
}