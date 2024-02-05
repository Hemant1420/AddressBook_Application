using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBook1 
    {

        static List<User> users = new List<User>();
        public List<string> str = new List<string>();
        public void listadd(User obj)
        {
            //Console.WriteLine(obj);
            users.Add(obj);

        }

        public void AddContact()
        {
            Console.WriteLine("Enter your Name: ");
            string Name = Console.ReadLine();

            Console.WriteLine("Enter your Email: ");
            string Emailid = Console.ReadLine();

            Console.WriteLine("Enter your City: ");
            string City = Console.ReadLine();

            Console.WriteLine("Enter your State: ");
            string State = Console.ReadLine();

            Console.WriteLine("Enter your ZipCode: ");
            string Zip = Console.ReadLine();

            Console.WriteLine("Enter your Contact : ");
            string Contact = Console.ReadLine();
            



            User u1 = new User(Name, Emailid, City, State, Zip, Contact);
         
            listadd(u1);
          
            
        }

        public void ViewDetails()
        {
            Console.WriteLine("Enter Your Contact detail: ");
            string contact = Console.ReadLine();

            

            foreach (User i in users)
            {
              
               
               
                // Convert i.Contact to string for comparison
                if (i.Contact == contact)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Name : " + i.Name);
                    Console.WriteLine("Email : " + i.Email);
                    Console.WriteLine("City : " + i.City);
                    Console.WriteLine("State : " + i.State);
                    Console.WriteLine("ZipCode : " + i.Zipcode);
                    Console.WriteLine("Contact : " + i.Contact);
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("No Records Found with the following Contact Number");
                }
            }
        }














    }

}
