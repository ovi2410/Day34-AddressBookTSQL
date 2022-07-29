using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookTSQL.Models
{
    public class AddNewBook_Model
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string BookType { get; set; }
        public DateTime DateofBookCreation { get; set; }

    }
}

