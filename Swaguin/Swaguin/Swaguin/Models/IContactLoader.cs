using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swaguin.Models
{
    public interface IContactLoader
    {
        IEnumerable<Contact> Load();
        void Save(IEnumerable<Contact> contacts);
    }
}
