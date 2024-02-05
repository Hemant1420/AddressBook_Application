using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Address
   
    {
        static List<User> users = new List<User>();
        public void listadd(User obj) {

            users.Add(obj);

        }

        public void AddContact()
        {
            Console.WriteLine("Enter your Name: ");
            string Name = Console.ReadLine();
            
            Console.WriteLine("Enter your email: ");
            string Emailid = Console.ReadLine();

            Console.WriteLine("Enter your city: ");
            string City = Console.ReadLine();

            Console.WriteLine("Enter your State: ");
            string State = Console.ReadLine(); 

            Console.WriteLine("Enter your ZipCode: ");
            int  Zip = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your Contact : ");
            double Contact = Convert.ToDouble(Console.ReadLine());



            User u1 = new User(Name, Emailid, City, State, Zip,Contact);

            listadd(u1);
         }



        static void Main()
        {
            int Optionnum;
            do
            {
                Console.WriteLine("Press the following No to select an option: ");
                Console.WriteLine("1 : Add new Contacts");
                Console.WriteLine("2 : Show details Of a Contact ");
                Console.WriteLine("3 : Edit a Contact ");
                Console.WriteLine("4 : Delete a Contact ");
                Console.WriteLine("5 : View All Contacts for a State or City ");
                Console.WriteLine("6 : Get Count Of Contacts Grouped by State and then Cities ");
                Console.WriteLine("7 : Exit");
                Console.WriteLine();
                Console.WriteLine("Enter the option number you want to select: ");
                Optionnum = Convert.ToInt32(Console.ReadLine());



                if (Optionnum == 1)
                {
                    AddContact();
                }
                

                
            }
            while (Optionnum != 7);

    }


        

    }
}
