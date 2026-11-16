using Cadastro_eventos.Models;

namespace Cadastro_eventos.Views;

public partial class NewPage1 : ContentPage
{
    App PropriedadesApp;

    public NewPage1()
	{
		InitializeComponent();

        pck_festas.ItemsSource = App.lista_festas;

        PropriedadesApp = (App)Application.Current;

        dtpck_checkin.MinimumDate = DateTime.Now;

        dtpck_checkin.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

        dtpck_check_out.MinimumDate = dtpck_checkin.Date?.AddDays(1);
        dtpck_check_out.MaximumDate = dtpck_checkin.Date?.AddMonths(6);
    }
    private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
    {
        DatePicker elemento = sender as DatePicker;

        DateTime data_selecionada_checkin = elemento.Date.GetValueOrDefault(DateTime.Today);

        dtpck_check_out.MinimumDate = data_selecionada_checkin.AddDays(1);
        dtpck_check_out.MaximumDate = data_selecionada_checkin.AddMonths(6);
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            var dados = new Dados_Festa
            {
                FestasSelecionada = (Festas)pck_festas.SelectedItem,
                Inicio = dtpck_checkin.Date ?? DateTime.Today,
                Termino = dtpck_check_out.Date ?? DateTime.Today,
                QuantidadeAdultos = int.TryParse(AdultosEntry.Text, out var a) ? a : 0,
                QuantidadeCriancas = int.TryParse(CriancaEntry.Text, out var c) ? c : 0
            };
            await Navigation.PushAsync(new Nota_Evento(dados));
        }catch(Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "Ok");
        }
    }
    private void OnCampoAlterado(object sender, EventArgs e)
    {
        btn_avancar.IsEnabled = CamposPreenchidos();
    }

    private bool CamposPreenchidos()
    {
        return pck_festas.SelectedIndex != -1
            && !string.IsNullOrWhiteSpace(AdultosEntry.Text)
            && !string.IsNullOrWhiteSpace(CriancaEntry.Text);
    }

}
