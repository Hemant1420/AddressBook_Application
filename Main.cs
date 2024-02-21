using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Address_book_2
{
    public class MainTest
    {

       
        static void Main()
        {
            
                Methods methods = new Methods();
                int Option;



                do
                {

                    Console.WriteLine("Select the Option.no from Below to perform Operations \n");
                    Console.WriteLine("1-> Add Contacts");
                    Console.WriteLine("2-> View Contacts");
                    Console.WriteLine("3-> Edit Contacts");
                    Console.WriteLine("4-> Delete Contacts");
                    Console.WriteLine("5-> Get Contacts from specific state or city");
                    Console.WriteLine("6-> Exit \n");

                    Console.WriteLine("Select the Option.no from Below to perform Operations ");
                    Option = Convert.ToInt32(Console.ReadLine());




                    switch (Option)
                    {
                        case 1:
                            methods.Add_contacts();
                            break;

                        case 2:
                            methods.View_contacts();
                            break;

                        case 3:
                            methods.Edit_Contacts();
                            break;

                        case 4:
                            methods.Delete();
                            break;

                        case 5:
                            methods.Find_details();
                            break;


                    }

                } while (Option != 6);
        }
            

                

        
        

    }
 }



