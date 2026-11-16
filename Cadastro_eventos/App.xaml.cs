
using Cadastro_eventos.Models;
using Cadastro_eventos.Views;
using Microsoft.Extensions.DependencyInjection;

namespace Cadastro_eventos
{
    public partial class App : Application
    {
        public static List<Festas> lista_festas = new List<Festas>
        {
            new Festas()
            {
                Descricao = "Casamento",
                ValorAdulto = 160.0,
                ValorCrianca = 80.0
            },
            new Festas()
            {
                Descricao = "Festa de Aniversário Infantil",
                ValorAdulto = 85.0,
                ValorCrianca = 42.5
            },
            new Festas()
            {
                Descricao = "Churrasco de Confraternização",
                ValorAdulto = 65.0,
                ValorCrianca = 32.5
            },
            new Festas()
            {
                Descricao = "Festa Corporativa de Fim de Ano",
                ValorAdulto = 120.0,
                ValorCrianca = 60.0
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