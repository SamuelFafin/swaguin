using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinUniversity.Infrastructure;
using XamarinUniversity.Interfaces;

namespace Swaguin.ViewModel
{
    public class MainViewModel : SimpleViewModel
    {

        public IList<ContactViewModel> Contacts { get; private set; }
        public ICommand AddContact { get; private set; }
        public ICommand DeleteContact { get; private set; }
        public ICommand EditContact { get; private set; }
        public ICommand ShowContactDetail { get; private set; }
        IDependencyService serviceLocator;

        ContactViewModel selectedContact;
        public ContactViewModel SelectedContact
        {
            get
            {
                return selectedContact;
            }
            set
            {
                SetPropertyValue(ref selectedContact, value);
            }
        }

        public MainViewModel() : this(new XamarinUniversity.Services.DependencyServiceWrapper())
        {
        }

        public MainViewModel(IDependencyService serviceLocator)
        {
            this.serviceLocator = serviceLocator;
            Contacts = new ObservableCollection<ContactViewModel>(ContactManager.Load()
                            .Select(c => new ContactViewModel(c)));

            SelectedContact = Contacts.FirstOrDefault();
            AddContact = new Command(async () => await OnAddContact());
            DeleteContact = new Command<ContactViewModel>(async vm => OnDeleteContact(vm));
            EditContact = new Command<ContactViewModel>(async vm => OnEditContact(vm));
            ShowContactDetail = new Command<ContactViewModel>(async vm => OnShowContactDetails(vm));
        }

        public async Task OnAddContact()
        {
            var newContact = new ContactViewModel();
            Contacts.Add(newContact);
            SelectedContact = newContact;

            if (!DependencyService.Get<INavigationService>().CanGoBack)
            {
                await DependencyService.Get<INavigationService>()
                                   .NavigateAsync(AppPages.Edit, newContact);
            }
        }

        public async Task OnEditContact(ContactViewModel contact)
        {
            SelectedContact = contact;
            await DependencyService.Get<INavigationService>()
                .NavigateAsync(AppPages.Edit, contact);
        }

        public async Task OnDeleteContact(ContactViewModel contact)
        {
            bool result = await DependencyService.Get<IMessageVisualizerService>()
                .ShowMessage("Are you sure?",
                    "Are you sure you want to delete this quote from " + contact.Author + "?",
                    "Yes", "No");

            if (result == true)
            {
                int pos = Contacts.IndexOf(contact);
                Contacts.Remove(contact);
                if (SelectedContact == contact)
                {
                    if (pos > Contacts.Count - 1)
                        pos = Contacts.Count - 1;
                    SelectedContact = Contacts[pos];
                }
            }
        }

        private async Task OnShowContactDetails(ContactViewModel cvm)
        {
            SelectedContact = cvm;
            await DependencyService.Get<INavigationService>()
                .NavigateAsync(AppPages.Detail);
        }
    }
}
