using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace MbmStore.Models
{
    public class Customer
    {
        private DateTime birthDate;
        private readonly int age;
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime BirthDate
        {
            set
            {
                if (age >= 120)
                {
                    throw new Exception("Age not accepted");
                }
                else
                {
                    birthDate = value;
                }
            }
            get { return birthDate; }
        }
        public int Age
        {
            get
            {
                DateTime now = DateTime.Now;
                int age;

                age = now.Year - birthDate.Year;

                if (now.Month < birthDate.Month || (now.Month == birthDate.Month && now.Day < birthDate.Day))
                {
                    age--;
                }
                return age;
            }
        }
        public ICollection<Invoice> Invoices { get; set; }
        public ICollection<Phone> PhoneNumbers { get; set; }
        public Customer()
        {

        }

        public Customer(int customerId, string firstnavn, string lastnavn, string address, string zip, string city, DateTime birthDate)
        {
            CustomerId = customerId;
            FirstName = firstnavn;
            LastName = lastnavn;
            Address = address;
            Zip = zip;
            City = city;
            BirthDate = birthDate;
        }

        //public Customer(string firstnavn, string lastnavn, string address, string zip, string city, List<string> phoneNumber)
        //{
        //    FirstName = firstnavn;
        //    LastName = lastnavn;
        //    Address = address;
        //    Zip = zip;
        //    City = city;
        //    PhoneNumbers = phoneNumber;
        //}
        public void AddInvoice(Invoice invoice)
        {

        }
        // method 
        public void AddPhone(Phone phone)
        {
            PhoneNumbers.Add(phone);

        }
    }

}