using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

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
            //BindingContext = new ContentPageViewModel();
        }
    }

    class ContactListePageViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName]string propertyName = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    }
}
