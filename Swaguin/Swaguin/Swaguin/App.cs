using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Swaguin
{
    public class App : Application
    {
        public App(String dbpath)
        {
            MainPage = new NavigationPage(new ContactListePage());
        }
    }
}
