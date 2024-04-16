namespace CaraCoroa
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        Random rdn = new Random();

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_ClickedHeadTails(object sender, EventArgs e)
        {
            String verif = Convert.ToString(Picker.SelectedItem);
            ResultHeadTail.Text = verif;
            int imag = rdn.Next(0, 1 + 1);
            if (imag == 0)
            {
                ResultHeadTail.Text = "Cara";
                ImgHeadTails.Source = "moeda_cara.jpeg";
            }
            else
            {
                ResultHeadTail.Text = "Coroa";
                ImgHeadTails.Source = "moeda_coroa.jpg";
            }
        }
    }

}
