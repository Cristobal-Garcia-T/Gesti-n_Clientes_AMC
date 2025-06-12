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

    public Usuario? Login(string? id, string? pass, string? tipo)
    {
        return _servicioLogin.Login(id, pass, tipo);
    }

    public void Logout()
    {
        _servicioLogin.Logout();
    }
}