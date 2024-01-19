using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class User
    {
        public string Name;
        public string Email;
        public string City;
        public string State;
        public int Zipcode;
        public double Contact;

        public User( string N1,string E1,String C1,String S1,int Z1,double C2)
        {
            Name = N1;
            Email = E1;
            City = C1;
            State = S1;
            Zipcode = Z1;
            Contact = C2;
        }
                    

     }

 }

    

