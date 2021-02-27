using System;

namespace AddressBookDay13
{
    class program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" Welcome to Address Book System ");
           Program studentBook = new Program();
            Program ScrapBook = new Program();

            
              //Address book created  for student
              studentBook.AddDetails("Student", "Ajinkya", " Patil ", " Pant nagar ", "Mumbai", "Maharashtra", 400025, 8806184085, " patil@gmail.com ");
              studentBook.AddDetails("Student", "Prachi", " Kadam ", " Shivaji Chowk ", "Mumbai", "Maharashtra", 400011, 880664052, " kadam@gmail.com ");
              studentBook.AddDetails("Student", "Priya", " Deshmukh ", " Gokhale nagar ", "Pune", "Maharashtra", 400017, 88060214103, " deshmukh@gmail.com ");
              studentBook.AddDetails("Student", "Sachin", " Gore ", " Swami chowk ", "Banglore", "Karnataka", 400517, 8875811103, " gore@gmail.com ");
              studentBook.AddDetails("Student", "Sheetal", " Patel ", " Gandhi nagar ", "Ahmdabad", "Gujrat", 400017, 8806154783, " pawar@gmail.com ");
              
             
             

            Console.WriteLine("Welcome to address book system");
            Console.WriteLine("Enter Choice:");
            Console.WriteLine("1) Display All Entries");
            Console.WriteLine("2) Insert new Entry");
            Console.WriteLine("3) Search person in city or state");
            Console.WriteLine("4) List by state or city");
            Console.WriteLine("5) View Count by state or city");
            Console.WriteLine("Enter choice want to perform:");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Enter Book name : ");
            string addressBook = Console.ReadLine();
            if (addressBook.Equals(ScrapBook))
            {
                ScrapBook.AddressBook(addressBook);
                addressBook = Console.ReadLine();
                ScrapBook.AddressBook(addressBook);
               

            }
            else
            {
                studentBook.AddressBook(addressBook);
                addressBook = Console.ReadLine();
                studentBook.AddressBook(addressBook);
                studentBook.ComputeDetails();

                studentBook.Search();
                studentBook.Count();


            }
            switch (choice)
            {
                case 1:
                    ScrapBook.ComputeDetails();
                    break;
                case 2:
                    ScrapBook.ContactlistEntry();
                    ScrapBook.ComputeDetails();
                    break;
                case 3:
                    ScrapBook.Search();
                    break; 
                case 4:
                    ScrapBook.Search();
                    break;
                case 5:
                    ScrapBook.Search();
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;

            }
            while (choice != 5) ;
           
            
           

            


        }
    }
}