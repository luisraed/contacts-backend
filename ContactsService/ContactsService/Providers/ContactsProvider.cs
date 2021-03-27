using System.Collections.Generic;

namespace ContactsService.Providers
{
    public interface IContactsProvider
    {
        IEnumerable<Contact> GetContacts();
    }
    public class ContactsProvider : IContactsProvider
    {
        public IEnumerable<Contact> GetContacts()
        {
            return new List<Contact>
            {
                new Contact { Salutation = "Mr.", FirstName = "John", LastName = "Snow", AddressLine1 = "Main St", AddressLine2 = "XYZ", City = "Mendoza", State = "Mendoza", EmailAddress = "mrjohnsnow@snow.net", TelephoneNumber = "+5492615549", ZipCode = "5000" },
                new Contact { Salutation = "Dr.", FirstName = "Peter", LastName = "House", AddressLine1 = "Another", AddressLine2 = "Place", City = "Philadelpia", State = "Pensilvania", EmailAddress = "house.peter@theemail.net", TelephoneNumber = "+00178454", ZipCode = "123454" },
                new Contact { Salutation = "Eng.", FirstName = "Matt", LastName = "Cow", AddressLine1 = "I don't", AddressLine2 = "know", City = "Dallas", State = "Texas", EmailAddress = "matt.cow@anywhere.com", TelephoneNumber = "+00124564", ZipCode = "3214545" }
            };
        }
    }
}
