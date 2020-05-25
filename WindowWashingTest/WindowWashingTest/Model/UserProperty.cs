using System;
using System.Collections.Generic;
using System.Text;

namespace WindowWashingTest.Model
{
    public class UserProperty
        //property definitions
    {
        public string Id { get; set; }
        public string UserID { get; set; }
        public string PropertyName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string Owner { get; set; }
        public string PrimaryResident { get; set; }


        public bool IsPostalCode(string p)
        {
            if (string.IsNullOrEmpty(p))
            {
                return false;
            }

            try
            {
                if (p.Length == 7)
                {
                    PostalCode = p;
                    return true;
                }
                if (p.Length == 6)
                {
                    string str = p.Substring(0, 3);
                    string str2 = p.Substring(p.Length - 3);
                    PostalCode = str + " " + str2;
                    return true;
                }
                else { return false; }



            }
            catch (FormatException)
            {
                return false;
            }
            return false;
        }
    }


}
