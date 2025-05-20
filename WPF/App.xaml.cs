using System.Windows;
using AccesoDB;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace WPF
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            DatabaseFacade facade = new(new ContextoDb());
            facade.EnsureCreated();
        }
    }

}
