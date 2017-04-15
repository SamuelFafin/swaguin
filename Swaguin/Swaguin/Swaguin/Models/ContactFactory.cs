using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Swaguin.Models
{
	public class ContactFactory
	{
		public static IList<Contact> Contacts { get; private set; }

		static ContactFactory()
		{
			Contacts = new ObservableCollection<Contact> {
				new Contact{
					FirstName = "Stéphanie",
					LastName = "Blondeau",
					Gender = false,
					Favorite = false,
					Email = "stephanie.blondeau@gmail.com",
					Birthdate = new DateTime(),
					PhoneNumber = "012",
					ImagePath = ""
				}
			};
		}
	}
}
