using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookTSQL.Models
{
    public class AddAddressofContact_Model
    {
        public int PersonId { get; set; }
        public int AddressId { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string Country { get; set; }
    }
}

