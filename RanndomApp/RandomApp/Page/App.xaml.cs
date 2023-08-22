using AudioUnit;
using Microsoft.Maui.Controls;
namespace RandomApp
{
    public partial class App : Application
    {
        public INavigation CurrentNavigation => ((MainPage)Current.MainPage).Navigation;
        public Microsoft.Maui.Controls.Page CurrentPage => ((MainPage)Current.MainPage).Navigation.NavigationStack[((MainPage)Current.MainPage).Navigation.NavigationStack.Count - 1];

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }
    }
}