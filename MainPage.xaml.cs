namespace Prova
{
    public partial class MainPage : ContentPage
    {
        int dado = 0;
        public MainPage()

        {
            InitializeComponent();
        }

        private void Rolar_Clicked(object sender, EventArgs e)
        {
            dado = Convert.ToInt32((string)picker.SelectedItem);
            Random rnd = new Random();
            int calc = rnd.Next(1, dado + 1) ;
            visor.Text = calc.ToString();
        }

    }
}
