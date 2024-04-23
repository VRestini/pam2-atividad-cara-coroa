using CaraCoroa.Models;

namespace CaraCoroa.Views;

public partial class CoinView : ContentPage
{
	public CoinView()
	{
		InitializeComponent();
	}

    private void ButtonHeadTails_Clicked(object sender, EventArgs e)
    {
		string ladoEscolhido = Picker.SelectedItem.ToString();
		Coin coin = new Coin();

		string result = coin.Jogar(ladoEscolhido);

        ResultHeadTail.Text = result;
		//ImgHeadTails.Source = $"moeda_{coin.Lado}.png";

    }
}