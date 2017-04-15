using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using System;
using Swaguin.Models;
using Swaguin.ViewModel;
using XamarinUniversity.Interfaces;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Swaguin
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactListePage : ContentPage
    {
        public ContactListePage()
        {
            InitializeComponent();

        }
    
        public async void OnContactTapped(object sender)
        {
            await DependencyService.Get<INavigationService>()
                .NavigateAsync(AppPages.Detail);
        }

        async void OnAddContact(object sender, EventArgs e)
        {
            await DependencyService.Get<MainViewModel>().OnAddContact();
        }

        async void OnDeleteContact(object sender, EventArgs e)
        {
            var mi = (MenuItem)sender;
            ContactViewModel contact = (ContactViewModel)mi.BindingContext;
            await DependencyService.Get<MainViewModel>().OnDeleteContact(contact);
        }

        async void OnEditContact(object sender, EventArgs e)
        {
            var mi = (MenuItem)sender;
            ContactViewModel contact = (ContactViewModel)mi.BindingContext;
            await DependencyService.Get<MainViewModel>().OnEditContact(contact);
        }

    }

}
