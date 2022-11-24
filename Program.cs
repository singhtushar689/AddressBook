using System;
using static AddressBook.Contact;


namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
             bool flag = true;
            Contact contact = new Contact();
            AddressBook addressBook = new AddressBook();
            while (flag)
            {
                Console.WriteLine("Welcome to AddressBook");
                Console.WriteLine("Enter what you want to do : \n 1. Create Contacts \n 2. Add Contacts \n 3. Edit Contacts \n 4. Delete Contacts \n 5. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter the Contact details of FirstName, LastName, Address, City, State, Zip, Mobilenumber, Email");
                        Contact  con= new Contact()
                        {
                            FirstName = Console.ReadLine(),
                            LastName = Console.ReadLine(),
                            Address = Console.ReadLine(),
                            City = Console.ReadLine(),
                            State = Console.ReadLine(),
                            Zip = Console.ReadLine(),
                            MobileNumber= Console.ReadLine(),
                            Email = Console.ReadLine(),
                        };
                        break;
                    case 2:
                        Console.WriteLine("Enter the Contact Information to Add in phoneBook in form of FirstName, LastName, Addr, City, State, Zip, Ph.No, Email.");
                        Console.WriteLine("Enter the Contact to Add: ");
                        AddressBook addressbook = new AddressBook();
                        Contact cont = new Contact()
                        {
                            FirstName = Console.ReadLine(),
                            LastName = Console.ReadLine(),
                            Address = Console.ReadLine(),
                            City = Console.ReadLine(),
                            State = Console.ReadLine(),
                            Zip = Console.ReadLine(),
                            MobileNumber = Console.ReadLine(),
                            Email = Console.ReadLine(),
                        };
                        addressbook.AddContact(cont);
                        addressbook.Display();
                        break;
                    case 3:
                        Console.WriteLine("Enter the Contact Name to  Edit: ");
                        string name = Console.ReadLine();
                        addressBook.EditContact(name);
                        Console.WriteLine("Contact is Edited Sucsessfully");
                        addressBook.Display();
                        break;
                    case 4:
                        Console.WriteLine("Enter the contact you want to delete :");
                        string detail = Console.ReadLine();
                        //  Contact cont = new Contact();
                        AddressBook delete = new AddressBook();

                        delete.DeleteContact(detail);
                        delete.Display();
                        break;
                    case 5:
                        flag = false;
                        break;
                }
            }
        }
        
    }
}