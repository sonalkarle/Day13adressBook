using NUnit.Framework;
using AddressBookDay13;

namespace NUnitTestProject
{
    public class Tests
    {
        Validation validation;
        Program program;


        [SetUp]
        public void Setup()
        {
            validation = new Validation();
            program = new Program();
        }



        /// <summary>
        /// TC-1 Throw Custom Exception for Invalid FirstName
        /// </summary>

        [TestCase("Sonal")]
        [TestCase("So")]
        public void Given_firstName_Expecting_ThrowCustomException(string patternFirstName)
        {

            try
            {
                string actual = validation.FirstName(patternFirstName);
            }
            catch (ValidationCustomException exception)
            {
                Assert.AreEqual("FirstName is not valid", exception.Message);
            }
        }

        /// <summary>
        /// TC-2 Throw Custom Exception for Invalid LastName
        /// </summary>
        [TestCase("Karle")]
        [TestCase("Ka")]
        public void Given_lastName_Expecting_ThrowCustomException(string patternLastName)
        {

            try
            {
                string actual = validation.LastName(patternLastName);
            }
            catch (ValidationCustomException exception)
            {
                Assert.AreEqual("LastName is not valid", exception.Message);
            }
        }

        /// <summary>
        /// TC-3 Throw Custom Exception for Invalid Address
        /// </summary>
        [TestCase("Gopal nagar")]
        [TestCase(" pantnagar")]
        public void Given_address_Expecting_ThrowCustomException(string patternAddress)
        {

            try
            {
                string actual = validation.Address(patternAddress);
            }
            catch (ValidationCustomException exception)
            {
                Assert.AreEqual("Address is not valid", exception.Message);
            }
        }

        /// <summary>
        /// TC-4 Throw Custom Exception for Zip
        /// </summary>
        [TestCase("400015")]
        [TestCase("400018")]
        public void Given_Zip_Expecting_ThrowCustomException(string patternZip)
        {

            try
            {
                string actual = validation.Zip(patternZip);
            }
            catch (ValidationCustomException exception)
            {
                Assert.AreEqual("Zip is not valid", exception.Message);
            }
        }

        /// <summary>
        /// TC-5 Throw Custom Exception for Invalid Mobile Number
        /// </summary>
        [TestCase("8806184088")]
        [TestCase("97024%754")]
        public void Given_MobileNumber_Expecting_ThrowCustomException(string patternMobileNumber)
        {

            try
            {
                string actual = validation.MobileNumber(patternMobileNumber);
            }
            catch (ValidationCustomException exception)
            {
                Assert.AreEqual("Mobile Number is not valid", exception.Message);
            }
        }


        /// <summary>
        /// TC-6 Throw Custom Exception for Invalid Email
        /// </summary>
        [TestCase("sonalkarle01@gmail.com")]
        [TestCase("Sonalkarlgmailcom")]
        public void Given_Email_Expecting_ThrowCustomException(string sampleEmail)
        {


            try
            {
                string actual = validation.EmailAddress(sampleEmail);
            }
            catch (ValidationCustomException exception)
            {
                Assert.AreEqual("Email is not valid", exception.Message);
            }
        }







    }
}