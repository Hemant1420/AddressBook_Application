using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBook1 
    {

        public List<User> users = new List<User>();
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
            Console.WriteLine(Contact);



            User u1 = new User(Name, Emailid, City, State, Zip, Contact);
            Console.WriteLine(u1.Name);
            listadd(u1);
            string name1 = "someone";
            str.Add(name1);
            string ele = str[0];
            Console.WriteLine(ele);
            
        }

        











    }

}
