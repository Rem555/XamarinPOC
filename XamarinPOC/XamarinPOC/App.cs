using Xamarin.Forms;
using FreshMvvm;

namespace XamarinPOC
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            FreshIOC.Container.Register<IDatabaseService, DatabaseService>();

            var masterDetailNav = new FreshMasterDetailNavigationContainer();
            masterDetailNav.Init("Menu", "Menu.png");
            masterDetailNav.AddPage<ContactListPageModel>("Contacts", null);
            masterDetailNav.AddPage<QuoteListPageModel>("Quotes", null);
            MainPage = masterDetailNav;

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
