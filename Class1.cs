using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_book_2
{
    public class User
    {
        public string Name;
        public string City;
        public string State;
        public string Email;
        public string Zip_code;
        public string Contact_no;

        public User(string name, string city, string state, string email, string zip_code, string contact_no )
        {
            Name = name;
            City = city;
            State = state; 
            Email = email;
            Zip_code = zip_code;
            Contact_no = contact_no;
        }
    }
}
