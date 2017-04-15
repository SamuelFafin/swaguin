using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Swaguin.Models
{
	public class ContactFactory
	{
		public static List<Contact> Contacts { get; private set; }

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
					PhoneNumber = 6616984830,
					ImagePath = ""
				}
			};
		}
	}
}
