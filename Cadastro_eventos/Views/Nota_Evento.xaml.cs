using Cadastro_eventos.Models;

namespace Cadastro_eventos.Views;

public partial class Nota_Evento : ContentPage
{
	public Nota_Evento(Dados_Festa dados)
	{
		InitializeComponent();
        BindingContext = dados;
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            await Navigation.PushAsync(new NewPage1());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "Ok");
        }
    }
}