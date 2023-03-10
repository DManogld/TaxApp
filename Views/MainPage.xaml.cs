using System.Globalization;
using TaxApp.Model;
using TaxApp.ViewModel;

namespace TaxApp.Views;

public partial class MainPage : ContentPage
{
    private TaxCalcViewModel _viewModel;

    public MainPage()
    {
        InitializeComponent();
        _viewModel = new TaxCalcViewModel();
        BindingContext = _viewModel;
    }



    private async void GoToSecondPage_Clicked(object sender, EventArgs e)
    {

        if (_viewModel.Ergebnis.IsNetto != true && Picker.SelectedItem != null)
        {
            if (_viewModel.Ergebnis.BetragUst == 8.00)
            {
                _viewModel.Ergebnis.BetragBrutto = (float)Math.Round(_viewModel.Ergebnis.Betrag, 2);
                _viewModel.Ergebnis.BetragNetto = (float)Math.Round(_viewModel.Ergebnis.Betrag * 1.08f, 2);
            }
            else if(_viewModel.Ergebnis.BetragUst == 3.5)
            {
                _viewModel.Ergebnis.BetragBrutto = (float)Math.Round(_viewModel.Ergebnis.Betrag * 1.035f);
            }
            else if (_viewModel.Ergebnis.BetragUst == 2.5)
            {
                _viewModel.Ergebnis.BetragBrutto = (float)Math.Round(_viewModel.Ergebnis.Betrag * 1.25f);
            }
        }
        else
        {
            if (_viewModel.Ergebnis.BetragUst == 8.00)
            {
                _viewModel.Ergebnis.BetragBrutto = (float)Math.Round(_viewModel.Ergebnis.Betrag * 0.8, 2);
            }
            else if (_viewModel.Ergebnis.BetragUst == 3.5)
            {
                _viewModel.Ergebnis.BetragBrutto = (float)Math.Round(_viewModel.Ergebnis.Betrag * 0.35 ,2);
            }
            else if (_viewModel.Ergebnis.BetragUst == 2.5)
            {
                _viewModel.Ergebnis.BetragBrutto = (float)Math.Round(_viewModel.Ergebnis.Betrag * 0.25, 2);
            }
        }
        

        await Navigation.PushAsync(new ResultPage { BindingContext = _viewModel });
    }

}

