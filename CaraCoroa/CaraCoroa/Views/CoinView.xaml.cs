using CaraCoroa.Models;
using CaraCoroa.ViewModels;


namespace CaraCoroa.Views;

public partial class CoinView : ContentPage
{
	public CoinView()
	{
		InitializeComponent();
		this.BindingContext = new CoinViewModel();
	}


    private void ButtonHeadTails_Clicked(object sender, EventArgs e)
    {
		string ladoEscolhido = Picker.SelectedItem.ToString();
		Coin coin = new Coin();

		string Resultado = coin.Jogar(ladoEscolhido);

        ResultHeadTail.Text = Resultado;
		ImgHeadTails.Source = $"moeda_{coin.Lado}.png";

    }
}