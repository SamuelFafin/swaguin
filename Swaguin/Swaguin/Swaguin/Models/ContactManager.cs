using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Swaguin.Models
{
    public static class ContactManager
    {
        public static IEnumerable<Contact> Load()
        {
            IContactLoader loader = DependencyService.Get<IContactLoader>();
            if (loader == null)
                throw new Exception("Missing contactt loader from platform.");

            return loader.Load();
        }

        public static void Save(IEnumerable<Contact> quotes)
        {
            IContactLoader loader = DependencyService.Get<IContactLoader>();
            if (loader == null)
                throw new Exception("Missing contact loader from platform.");

            loader.Save(quotes);
        }
    }
}
