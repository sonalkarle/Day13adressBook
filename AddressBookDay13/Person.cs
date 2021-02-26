using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
namespace AddressBookDay13
{
    public class ContactDetails
    {
        public string firstName;
        public string lastName;
        public string address;
        public string city;
        public string state;
        public int zip;
        public long phoneNumber;
        public string email;
        public string addressBook;

        public ContactDetails()
        {
        }

        public ContactDetails(string addressBook, string firstName, string lastName, string address, string city, string state, int zip, long phoneNumber, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.addressBook = addressBook;
        }
        public string toString()
        {
            return "Address Book: " + addressBook + "\n"
                                   + "" + " Details of " + firstName + " " + lastName + " are: " + " Address: " + address + "  City: " + city + "\n"
                                    + "                               " + " State: " + state + "  Zip: " + zip + "\n"
                                    + "                               " + " PhoneNumber: " + phoneNumber + "\n"
                                    + "                               " + " Email: " + email;

        }
    }
}
