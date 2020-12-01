using System.Collections.Generic;

namespace AddressBook
{
    public class AddressBook
    {
        public Dictionary<string, Contact> ContactList { get; set; }


        public AddressBook()
        {
            ContactList = new Dictionary<string, Contact>();
        }
        // adding a new contact
        public void AddContact(Contact NewContact)
        {
            ContactList.Add(NewContact.Email, NewContact);

        }
        // getting contact by email
        public Contact GetByEmail(string email)
        {
            return ContactList[email];

        }
    }
}



