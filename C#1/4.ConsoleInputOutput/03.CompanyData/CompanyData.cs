//A company has name, address, phone number, fax number, web site and manager. 
//The manager has first name, last name, age and a phone number. Write a program 
//that reads the information about a company and its manager and prints them on the console.

using System;

namespace _03.CompanyData
{

    class Company
    {
        public string name;
        public string address;
        public string phoneNumber;
        public string faxNumber;
        public string webSite;
        public string manager;

        public Company(string name, string address, string phoneNumber, string fax, string web, string manager)
        {
            this.name = name;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.faxNumber = fax; 
            this.webSite = web;
            this.manager = manager;
        }

        public void PrintCompany()
        {
            Console.WriteLine("{0} is based in {1}.The manager is:{2}", name, address, manager);
            Console.WriteLine("Contacts: \nPhone: {0} \nFax: {1} \nWeb site: {2}",phoneNumber,faxNumber,webSite);
        }
    }

    class manager
    {
        public string name;
        public string age;
        public string phoneNumber;

        public manager(string name, string age, string phoneNumber)
        {
            this.name = name;
            this.age = age;
            this.phoneNumber = phoneNumber;
        }

        public void PrintManager()
        {
            Console.WriteLine("{0} is {1} years old.", name, age);
            Console.WriteLine("Phone: {0} ", phoneNumber);
        }

    }

    class CompanyData
    {
        static void Main()
        {
            Console.WriteLine("Input company data: Name, Address, Phone, Fax, Web, Manager");
            Company company1 = new Company(Console.ReadLine(),Console.ReadLine(),Console.ReadLine(),Console.ReadLine(),Console.ReadLine(),Console.ReadLine());
            Console.WriteLine("Input manager's details: Name, Age, Phone");
            manager manager1 = new manager(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
            
            Console.WriteLine("The fist company is:");
            company1.PrintCompany();
            Console.WriteLine("Manager's details:");
            manager1.PrintManager();
        }
    }
}
