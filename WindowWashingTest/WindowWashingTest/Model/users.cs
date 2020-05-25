using System;
using System.Collections.Generic;
using System.Text;

namespace WindowWashingTest.Model
{
    public class Users
        //app user definitions

    {
      
        public string Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Passcode { get; set; }
        public long PhoneNumber { get; set; }
        public string Prefix { get; set; }

        public bool GoodEmail(string email)
        //checks if email is valid, must contain @ and .
        {
            try
            {
                return (email.Contains($"@") & email.Contains($"."));
            }
            catch (ArgumentNullException)
            {
                return false;
            }
        }

        public bool goodPhoneNumber(string number)
        //checks if phone nummmber is valid, must be at least 10 characters long
        {

            try
            {
                long result = long.Parse(number);
                if (result >= 1000000000)
                {

                    return true;
                }
            }
            catch (FormatException)
            {
                return false;
            }
            return true;
        }

    }
}
