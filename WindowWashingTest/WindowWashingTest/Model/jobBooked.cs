using System;
using System.Collections.Generic;
using System.Text;

namespace WindowWashingTest.Model
{
    class jobBooked
    {
        public string Id { get; set; }
        public string PropertyName { get; set; }
        public string Email { get; set; }
        public string ThisAddress { get; set; }
        public string PostalCode { get; set; }
        public string PropertyOwner { get; set; }
        public string Services { get; set; }
        public DateTime ServiceDate { get; set; }
        public string PrimaryResident { get; set; }
    }
}
