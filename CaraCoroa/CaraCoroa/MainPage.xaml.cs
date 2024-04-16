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
        }
    }

}
