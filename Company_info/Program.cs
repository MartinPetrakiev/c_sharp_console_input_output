using System;

namespace MyProject
{
    class Program
    {
        string companyName = "";
        string companyAddress = "";
        string companyPhoneNumber = "";
        string webSite = "";
        string faxNumber = "";
        string managerFirstName = "";
        string managerLastName = "";
        int managerAge = 0;
        string managerPhoneNumber = "";
        
        static void Main(string[] args)
        {           
            Program company = new Program();
            company.companyName = Console.ReadLine();
            company.companyAddress = Console.ReadLine();
            company.companyPhoneNumber = Console.ReadLine();
            company.webSite = Console.ReadLine();
            var fax = Console.ReadLine();
            company.faxNumber = String.IsNullOrEmpty(fax) ? fax : "(no fax)";
            company.managerFirstName = Console.ReadLine();
            company.managerLastName = Console.ReadLine();   
            company.managerAge = int.Parse(Console.ReadLine());
            company.managerPhoneNumber = Console.ReadLine();

            Console.WriteLine(company.companyName);
            Console.WriteLine("Address: " + company.companyAddress);
            Console.WriteLine("Tel." + company.companyPhoneNumber);
            Console.WriteLine("Web Site: " + company.webSite, unicodeString);
            Console.WriteLine("Fax: " + company.faxNumber);
            Console.WriteLine("Manager: " + company.managerFirstName + " " + company.managerLastName + " (age: " + company.managerAge + ", tel. " + company.managerPhoneNumber + ")");
        }
    }
}