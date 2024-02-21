using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Data.SqlClient; 

namespace Address_book_2
{
    public class Methods
    {
        
        string connect = " DATA SOURCE = LAPTOP-JD3L417L\\SQLEXPRESS ; Initial Catalog = AddressBook; Integrated Security = true";
        SqlConnection con = null;


        public void Add_contacts()
        {
            try
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

               

                while (value)
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

                //Connection Establishment
                try
                {
                    using (con = new SqlConnection(connect))
                    {
                        string query = $"INSERT INTO Info VALUES ('{name}', '{city}', '{state}', '{email}', {zip_code}, '{contact_no}') ";
                        SqlCommand cmd = new SqlCommand(query, con);

                        con.Open();
                        int a = cmd.ExecuteNonQuery();

                        if (a > 0)
                        {
                            Console.WriteLine("Data Entered Successfully");
                        }
                        else
                        {
                            Console.WriteLine("Error While Entering data, Please try again!");
                        }


                    }
                }
                catch (Exception ex) 
                {
                    Console.WriteLine($" {ex.Message} \nPlease enter the record again with a different contact Number");
                }
                finally
                {
                    con.Close();
                }

                 

            }
            catch(Exception ex) 
            {
                Console.WriteLine("Unexpexted Error ocurred" + ex.Message);
            }

        }

        public void View_contacts()
        {
            try
            {
                Console.WriteLine("1 -> View full Table");
                Console.WriteLine("2-> View your presonal detail Table");
                Console.WriteLine("Select the options from above: ");
                int opt = Convert.ToInt32(Console.ReadLine());
                string contact = "";

                using (con = new SqlConnection(connect))
                {
                    con.Open();
                    
                    

                    if (opt == 1)
                    {
                        string query1 = "SELECT * FROM Info";
                        SqlCommand cmd = new SqlCommand(query1, con);
                        SqlDataReader obj = cmd.ExecuteReader();
                        while (obj.Read())
                        {
                            Console.WriteLine($"Name : {obj["Name"]} City : {obj["City"]} State : {obj["State"]} Email : {obj["Email"]} Zip_code : {obj["Zip_code"]} Contact : {obj["Contact"]} ");
                        }

                    }
                    else if (opt == 2)
                    {
                        Console.WriteLine("Enter your Contact details: ");
                        contact = Console.ReadLine();

                        string query2 = $"SELECT * FROM Info WHERE Contact = '{contact}' ";
                        SqlCommand cmd = new SqlCommand(query2, con);
                        SqlDataReader obj = cmd.ExecuteReader();

                       
                        obj.Read();

                        Console.WriteLine($"Name : {obj["Name"]} City : {obj["City"]} State : {obj["State"]} Email : {obj["Email"]} Zip_code : {obj["Zip_code"]} Contact : {obj["Contact"]} ");

                    }


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected Error Ocurred" + ex.Message);
            }
        }


        public string Update(string input1, string input2)
        {
           
            if (input1 == "\n" || input1=="")
            {
                return input2;
            }
            return input1; 

        }
        public void Edit_Contacts()
        {
            try
            {
                using (con = new SqlConnection(connect))
                {
                    Console.WriteLine("Enter your Contact details: ");
                    string contact = Console.ReadLine();
                    string query1 = $"SELECT * FROM Info WHERE Contact = '{contact}' ";

                    SqlCommand cmd = new SqlCommand(query1,con);
                    con.Open();

                    SqlDataReader obj = cmd.ExecuteReader();
                    obj.Read();
                    Console.WriteLine($"old_Name : {obj["Name"]}");
                    Console.WriteLine($"old_City : {obj["City"]}" );
                    Console.WriteLine($"old_State : {obj["State"]}" );
                    Console.WriteLine($"old_email : {obj["Email"]}" );
                    Console.WriteLine($"old_Zip_code : {obj["Zip_code"]}" );
                    Console.WriteLine($"old_contact : {obj["Contact"]}" );
                    Console.WriteLine("Leave blank if no changes");
                    

                    
                    
                    Console.WriteLine("Enter new Name : ");
                    string name = Update( Console.ReadLine(), Convert.ToString(obj["Name"]));
                    Console.WriteLine(obj["Name"]);
                    Console.WriteLine("Enter new City : ");
                    string city = Update(Console.ReadLine(), Convert.ToString(obj["City"]));
                    Console.WriteLine("Enter new State : ");
                    string state = Update( Console.ReadLine(), Convert.ToString(obj["State"]));
                    Console.WriteLine("Enter new Email : ");
                    string email = Update( Console.ReadLine(), Convert.ToString(obj["Email"]));
                    Console.WriteLine("Enter new Zip_code : ");
                    string zip_code = Update( Console.ReadLine(), Convert.ToString(obj["Zip_code"]));
                    Console.WriteLine("Enter new Contact : ");
                    string newcontact = Update( Console.ReadLine(), Convert.ToString(obj["Contact"]));

                    con.Close();
                    Console.WriteLine("Entering");
                    string query2 = $"UPDATE Info SET Name = '{name}', City = '{city}' , State = '{state}', Email = '{email}', Zip_code = '{zip_code}', Contact = '{newcontact}' where Contact = '{contact}' ";
                    Console.WriteLine("Exit");

                    con.Open();
                    SqlCommand cmd1 = new SqlCommand(query2, con);
                    int a = cmd1.ExecuteNonQuery(); 

                    if(a > 0)
                    {
                        Console.WriteLine("Details Updated Succesfully");
                    }
                    else
                    {
                        Console.WriteLine("Details Updation Failed!!");

                    }
                }
                 

                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected Error Ocurred" + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void Delete()
        {
            try
            {
                using(con =new SqlConnection(connect))
                {
                    Console.WriteLine("Enter your Contact details: ");
                    string contact = Console.ReadLine();

                    string query = $"DELETE FROM Info WHERE Contact = '{contact}' ";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    int a = cmd.ExecuteNonQuery();

                    if(a > 0)
                    {
                        Console.WriteLine("Record Deleted Succesfully");
                    }
                    else
                    {
                        Console.WriteLine("Error Deleting the Record");

                    }

                }
                

               
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected Error Ocurred" + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void Find_details()
        {
            try
            {
                using (con = new SqlConnection(connect))
                {
                    Console.WriteLine("Enter your State or City: ");
                    string Input = Console.ReadLine();

                    string query1 = $"SELECT * FROM Info WHERE City = '{Input}' or State = '{Input}'";
                   

                    con.Open();
                    SqlCommand cmd = new SqlCommand(query1, con);
                    SqlDataReader obj = cmd.ExecuteReader();

                   
                        while (obj.Read())
                        {
                            Console.WriteLine($"Name : {obj["Name"]} City : {obj["City"]} State : {obj["State"]} Email : {obj["Email"]} Zip_code : {obj["Zip_code"]} Contact : {obj["Contact"]} ");
                        }
                    
                   
                }
            }




            catch (Exception ex)
            {
                Console.WriteLine("Unexpected Error Ocurred" + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        
    }
}
