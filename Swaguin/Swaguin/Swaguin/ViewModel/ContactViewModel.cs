using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Swaguin.Models;
using XamarinUniversity.Infrastructure;

namespace Swaguin.ViewModel
{
    public class ContactViewModel : SimpleViewModel
    {
        readonly Contact contact;

        public int Id
        {
            get { return contact.Id; }
            set
            {
                if (contact.Id != value)
                {
                    contact.Id = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string FirstName
        {
            get { return contact.FirstName; }
            set
            {
                if (contact.FirstName != value)
                {
                    contact.FirstName = value;
                    RaisePropertyChanged();
                    RaisePropertyChanged(() => Author);
                }
            }
        }

        public string LastName
        {
            get { return contact.LastName; }
            set
            {
                if (contact.LastName != value)
                {
                    contact.LastName = value;
                    RaisePropertyChanged();
                    RaisePropertyChanged(() => Author);
                }
            }
        }

        public string Author
        {
            get { return contact.FirstName + " " + contact.LastName; }
        }

        public Boolean Gender
        {
            get { return contact.Gender; }
            set
            {
                if (contact.Gender != value)
                {
                    contact.Gender = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string Email
        {
            get { return contact.Email; }
            set
            {
                if (contact.Email != value)
                {
                    contact.Email = value;
                    RaisePropertyChanged();
                }
            }
        }
        public DateTime Birthdate
        {
            get { return contact.Birthdate; }
            set
            {
                if (contact.Birthdate != value)
                {
                    contact.Birthdate = new DateTime();
                    RaisePropertyChanged();
                }
            }
        }

        public int PhoneNumber
        {
            get { return contact.PhoneNumber; }
            set
            {
                if (contact.PhoneNumber != value)
                {
                    contact.PhoneNumber = value;
                    RaisePropertyChanged();
                }
            }
        }

        public String ImagePath
        {
            get { return contact.ImagePath; }
            set
            {
                if (contact.ImagePath != value)
                {
                    contact.ImagePath = value;
                    RaisePropertyChanged();
                }
            }
        }

        internal Contact Models
        {
            get { return contact; }
        }

        public ContactViewModel()
            : this(new Contact())
        {
            Email = "Enter some amazing saying here.";
        }

        public ContactViewModel(Contact contact)
        {
            this.contact = contact;
        }



    }
}
