using Xamarin.Forms;

namespace Swaguin
{
    public class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            var listPage = new ContactListePage();
            Master = new NavigationPage(listPage) { Title = listPage.Title, Icon = listPage.Icon };
            Detail = new NavigationPage(new ContactDetailPage());
        }
    }

}
