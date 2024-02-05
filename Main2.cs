using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Main2
    {
        static void Main()
        {
            int Optionnum;
            do
            {
                Console.WriteLine(" ");
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

                AddressBook1 newuser = new AddressBook1();

                if (Optionnum == 1)
                {
                    newuser.AddContact();
                }

                else if (Optionnum == 2)
                {
                    newuser.ViewDetails();
                }






            }
            while (Optionnum != 7);

        }
    }
    }

