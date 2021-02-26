using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddressBookDay13
{
    public class Program
    {
        Validation validation = new Validation();
         List<ContactDetails> contactDetailsList;
        private Dictionary<string, ContactDetails> contactDetailsMap;
        private Dictionary<string, Dictionary<string, ContactDetails>> multipleAddressBookMap;

        public Program()
        {
            contactDetailsList = new List<ContactDetails>();
            contactDetailsMap = new Dictionary<string, ContactDetails>();
            multipleAddressBookMap = new Dictionary<string, Dictionary<string, ContactDetails>>();

        }
        public void ContactlistEntry()
        {
            ContactDetails personEntered = new ContactDetails();
            Console.WriteLine("Enter First name");
            string firstName = Console.ReadLine();
            validation.FirstName(firstName);
            personEntered.firstName = Console.ReadLine();
           
            Console.WriteLine("Enter Last name");
            string lastName = Console.ReadLine();
            validation.LastName(lastName);
            personEntered.lastName = Console.ReadLine();
           
            if (contactDetailsList.Find(i => personEntered.Equals(i)) != null)
            {
                Console.WriteLine("Person already Exists, enter new person!");
                return;
            }
            Console.WriteLine("Enter Address");
            string address = Console.ReadLine();
             validation.Address(address);
            personEntered.address = Console.ReadLine();
            Console.WriteLine("Enter City");
            personEntered.city = Console.ReadLine();
            Console.WriteLine("Enter State");
            personEntered.state = Console.ReadLine();
            Console.WriteLine("Enter Zip");
            int zip = Convert.ToInt32(Console.ReadLine());
            string zipString = zip.ToString();
            validation.Zip(zipString);
            personEntered.zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter phoneNumber");
            long phoneNumber = Convert.ToInt32(Console.ReadLine());
            string phoneNumberString = phoneNumber.ToString();
            validation.MobileNumber(phoneNumberString);
            personEntered.phoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Email");
            string email = Console.ReadLine();
            validation.EmailAddress(email);
            personEntered.email = Console.ReadLine();
            contactDetailsList.Add(personEntered);
        }
        public List<ContactDetails> AddDetails(string addressBook, string firstName, string LastName, string address, string city, string state, int zip, long phoneNumber, string email)
        {
            ContactDetails contactDetails = new ContactDetails(addressBook, firstName, LastName, address, city, state, zip, phoneNumber, email);
            contactDetailsList.Add(contactDetails);

            return contactDetailsList;

        }

        // Create Nested Dictionary
        public void AddressBook(string addressBook)
        {
            multipleAddressBookMap.Add(addressBook, contactDetailsMap);
        }



        //Searching a Person
        public Dictionary<string, ContactDetails> Search()
        {
            Console.WriteLine(" Enter state ");
            string state = Console.ReadLine();
            var stateCheck = contactDetailsList.FindAll(x => x.state == state);
            Console.WriteLine(" Enter city ");
            string city = Console.ReadLine();
            var cityCheck = stateCheck.FindAll(x => x.city == city);
            Console.WriteLine(" Find Person ");
            string firstName = Console.ReadLine();
            var person = cityCheck.Where(x => x.firstName == firstName).FirstOrDefault();
            if (person != null)
            {
                Console.WriteLine(firstName + " is  in " + city);
            }
            else
            {
                Console.WriteLine(firstName + " is not  in " + city);
            }
            Dictionary<string, ContactDetails> detailCity = new Dictionary<string, ContactDetails>();
            Dictionary<string, ContactDetails> detailState = new Dictionary<string, ContactDetails>();
            detailCity.Add(city, person);
            detailState.Add(state, person);
            foreach (KeyValuePair<string, ContactDetails> i in detailCity)
            {
                Console.WriteLine("City: {0}  {1}", i.Key, i.Value.toString());
            }

            foreach (KeyValuePair<string, ContactDetails> i in detailState)
            {
                Console.WriteLine("State: {0}  {1}", i.Key, i.Value.toString());
            }

            Console.WriteLine(detailCity.Count());
            return detailCity;
        }

        public void Count()
        {
            Console.WriteLine(" Enter state ");
            string state = Console.ReadLine();
            var stateCheck = contactDetailsList.FindAll(x => x.state == state);
            Console.WriteLine(" No of contacts from the state: " + state + " are " + stateCheck.Count);
        }
        public void ComputeDetails()
        {
            foreach (ContactDetails book in contactDetailsList)
            {
                Console.WriteLine(book.toString());
            }
        }


    }
}