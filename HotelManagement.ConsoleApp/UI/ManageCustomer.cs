using System;
using System.Collections.Generic;
using HotelManagement.Data;
using HotelManagement.Repository;

namespace HotelManagement.ConsoleApp.UI
{
    class ManageCustomer : MainScreen
    {
        IRepository<Customer> CustomerRepository;
        public ManageCustomer()
        {
            CustomerRepository = new CustomerRepository();
        }

        void AddCustomer()
        {
            Customer c = new Customer();
            Console.Write("Enter Room Number = ");
            c.RoomNO = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name = ");
            c.CName = Console.ReadLine();
            Console.Write("Enter Address = ");
            c.Address = Console.ReadLine();
            Console.Write("Enter Phone = ");
            c.Phone = Console.ReadLine();
            Console.Write("Enter Email = ");
            c.Email = Console.ReadLine();
            Console.Write("Enter Checkin Date = ");
            c.Checkin = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Enter Total Number of Persons = ");
            c.TotalPersons = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Booking Days = ");
            c.BookingDays = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Advance Deposit = ");
            c.Advance = Convert.ToInt32(Console.ReadLine());
            if (CustomerRepository.Insert(c) > 0)
            {
                Console.WriteLine("Customer has been added successfully");
            }
            else
                Console.WriteLine("Some error has occurred...");
        }

        void UpdateCustomer()
        {

        }

        void PrintAllCustomer()
        {
            IEnumerable<Customer> customers = CustomerRepository.GetAll();
            foreach (var item in customers)
            {
                Console.WriteLine(item.Id + "\t" + item.RoomNO + "\t" + item.CName);
            }
        }

        void PrintCustomerById()
        {

        }
        
        void DeleteCustomer()
        {
            Console.Write("Enter Id = ");
            int id = Convert.ToInt32(Console.ReadLine());
            if (CustomerRepository.Delete(id) > 0)
                Console.WriteLine("Customer Deleted");
            else
                Console.WriteLine("Some error has occurred...");
        }

        public override void Run()
        {
            int choice = 0;
            do
            {
                Console.Clear();
                Menu m = new Menu();
                choice = m.Print(typeof(Operations));
                switch (choice)
                {
                    case (int)Operations.Add:
                        AddCustomer();
                        break;
                    case (int)Operations.Update:
                        UpdateCustomer();
                        break;
                    case (int)Operations.Delete:
                        DeleteCustomer();
                        break;
                    case (int)Operations.PrintAll:
                        PrintAllCustomer();
                        break;
                    case (int)Operations.PrintById:
                        PrintCustomerById();
                        break;
                    case (int)Operations.Exit:
                        Console.WriteLine("Thanks for visit!!!");
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
                Console.WriteLine("Press Enter to continue.....");
                Console.ReadLine();
            } while (choice != (int)Operations.Exit);
        }
    }
}
