using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Address_book_2
{
    public class Methods
    {
        public List<User> newList = new List<User>();
        public void Add_contacts()
        {

            Regex regexName = new Regex(pattern: "^[A-Z][a-z]{2,}$");
            Regex regexCity = new Regex(pattern: "^[A-Z][a-z]{2,}$");
            Regex regexState = new Regex(pattern: "^[A-Z][a-z]{2,}$");
            Regex regexEmail = new Regex(pattern: "^[A-Za-z0-9]{1,}[@][A-Za-z0-9.]{2,}[a-z]{2,3}$");
            Regex regexZip = new Regex(pattern: "^[1-9][0-9]{5}$");
            Regex regexContact = new Regex(pattern: "^[6-9][0-9]{9}$");

            bool value = true;
            string name = "";
            string city = "";
            string state = "";
            string email = "";
            string zip_code = "";
            string contact_no = "";

         while(value)
         { 
            while (value)
            {
                Console.WriteLine("Enter your Name: ");
                name = Console.ReadLine();

                value = !regexName.IsMatch(name);
            }
            value = true;


            while (value)
            {
                Console.WriteLine("Enter your City: ");
                city = Console.ReadLine();

                value = !regexCity.IsMatch(city);



            }
            value = true;


            while (value)
            {
                Console.WriteLine("Enter your State: ");
                state = Console.ReadLine();

                value = !regexState.IsMatch(state);



            }
            value = true;

            while (value)
            {
                Console.WriteLine("Enter your Email: ");
                email = Console.ReadLine();

                value = !regexEmail.IsMatch(email);



            }
            value = true;

            while (value)
            {
                Console.WriteLine("Enter your Zip_code: ");
                zip_code = Console.ReadLine();

                value = !regexZip.IsMatch(zip_code);



            }
            value = true;

            while (value)
            {
                Console.WriteLine("Enter your contact_no: ");
                contact_no = Console.ReadLine();

                value = !regexContact.IsMatch(contact_no);



            }
         }
            User newUser = new User(name, city, state, email, zip_code, contact_no);

            newList.Add(newUser);

        }

        public void View_contacts()
        {
            Console.WriteLine("Enter your Contact details: ");
            string contact = Console.ReadLine();

            int temp = 0;

            for (int i = 0; i < newList.Count; i++)
            {
                if (contact == newList[i].Contact_no)
                {
                    Console.WriteLine(newList[i].Name);
                    Console.WriteLine(newList[i].City);
                    Console.WriteLine(newList[i].State);
                    Console.WriteLine(newList[i].Email);
                    Console.WriteLine(newList[i].Zip_code);
                    Console.WriteLine(newList[i].Contact_no);
                }
                else
                {
                    temp++;
                }

                if (temp == newList.Count)
                {
                    Console.WriteLine("No records found");
                }
            }
        }


        public string Update(string input1, string input2)
        {
            if (input2 == "\n")
            {
                return input2;
            }
            return input1; 

        }
        public void Edit_Contacts()
        {
            Console.WriteLine("Enter your Contact details: ");
            string contact = Console.ReadLine();

            for (int i = 0; i < newList.Count; i++)
            {
                if (contact == newList[i].Contact_no)
                {

                    
                    Console.WriteLine($"Old Name : {newList[i].Name} , New Name : ");
                    newList[i].Name = Update(Console.ReadLine(), newList[i].Name);

                    Console.WriteLine($"Old City : {newList[i].City} , New City : ");
                    newList[i].City = Update(Console.ReadLine(), newList[i].City);

                    Console.WriteLine($"Old State : {newList[i].State} , New State : ");
                    newList[i].State = Update(Console.ReadLine(), newList[i].State);

                    Console.WriteLine($"Old Email : {newList[i].Email} , New Email : ");
                    newList[i].Email = Update(Console.ReadLine(), newList[i].Email);

                    Console.WriteLine($"Old Zip_code : {newList[i].Zip_code} , New Zip_code : ");
                    newList[i].Zip_code = Update(Console.ReadLine(), newList[i].Zip_code);

                    Console.WriteLine($"Old Contact_no : {newList[i].Contact_no} , New Contact_no : ");
                    newList[i].Contact_no = Update(Console.ReadLine(), newList[i].Contact_no);



                }
            }
        }

        public void Delete()
        {

            Console.WriteLine("Enter your Contact details: ");
            string contact = Console.ReadLine();

            for (int i = 0; i < newList.Count; i++)
            {
                if (newList[i].Contact_no == contact)
                {
                    newList.Remove(newList[i]);
                }
            }
        }

        public void Find_details()
        {
            Console.WriteLine("Enter your State or City: ");
            string Input = Console.ReadLine();

            for (int i = 0; i < newList.Count; i++)
            {
                if (newList[i].State == Input || newList[i].City == Input)
                {
                    Console.WriteLine(newList[i].Name);
                    Console.WriteLine(newList[i].City);
                    Console.WriteLine(newList[i].State);
                    Console.WriteLine(newList[i].Email);
                    Console.WriteLine(newList[i].Zip_code);
                    Console.WriteLine(newList[i].Contact_no);
                }
            }

        }

        
    }
}
