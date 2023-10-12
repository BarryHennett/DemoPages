using MauiTask2.Pages;
using MauiTask2.Pages.FlyOutPageDemo;
using MauiTask2.Pages.NavPageDemo;
using MauiTask2.Pages.TabbedPageDemo;

namespace MauiTask2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new DemoContentPage1();

            //var navigationPage = new NavigationPage(new NavContentPage1());
            //navigationPage.BarBackgroundColor = Colors.Firebrick;
            //navigationPage.BarTextColor = Colors.Black;
            //MainPage = navigationPage;

            //MainPage = new DemoFlyoutPage1();

            MainPage = new DemoTabbedPage1();
        }
    }
}