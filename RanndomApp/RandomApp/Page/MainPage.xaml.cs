using RandomApp.Page;

namespace RandomApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        public void teste()
        {
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewPage1());
        }
    }
}