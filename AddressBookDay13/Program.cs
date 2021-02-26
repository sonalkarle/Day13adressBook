using System;

namespace AddressBookDay13
{
    class program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" Welcome to Address Book System ");
            Program studentBook = new Program();


            //Address book created  for student
            studentBook.AddDetails("Student", "Ajinkya", " Patil ", " Pant nagar ", "Mumbai", "Maharashtra", 400025, 8806184085, " patil@gmail.com ");
            studentBook.AddDetails("Student", "Prachi", " Kadam ", " Shivaji Chowk ", "Mumbai", "Maharashtra", 400011, 880664052, " kadam@gmail.com ");
            studentBook.AddDetails("Student", "Priya", " Deshmukh ", " Gokhale nagar ", "Pune", "Maharashtra", 400017, 88060214103, " deshmukh@gmail.com ");
            studentBook.AddDetails("Student", "Sachin", " Gore ", " Swami chowk ", "Banglore", "Karnataka", 400517, 8875811103, " gore@gmail.com ");
            studentBook.AddDetails("Student", "Sheetal", " Patel ", " Gandhi nagar ", "Ahmdabad", "Gujrat", 400017, 8806154783, " pawar@gmail.com ");
            Console.WriteLine(" Enter stored Book Name : ");
            string addressBook = Console.ReadLine();
            studentBook.AddressBook(addressBook);
            studentBook.ComputeDetails();

            studentBook.Search();
            studentBook.Count();





        }
    }
}