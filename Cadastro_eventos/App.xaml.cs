
using Cadastro_eventos.Models;
using Microsoft.Extensions.DependencyInjection;

namespace Cadastro_eventos
{
    public partial class App : Application
    {
        public List<Festas> lista_festas = new List<Festas>
        {
            new Festas()
            {
                Descricao = "Casamento"
            },
            new Festas()
            {
                Descricao = "Festa de Aniversário Infantil"
            },
            new Festas()
            {
                Descricao = "Churrasco de Confraternização"
            },
            new Festas()
            {
                Descricao = "Casamento"
            }
        };


        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new Views.NewPage1());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 600;

            return window;
        }
    }
}