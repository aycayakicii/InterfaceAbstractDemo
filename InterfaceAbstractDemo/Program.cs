using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concreate;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Customer {DateOfBirth = new DateTime(1997,6,14), FirstName="Ayca", LastName="Yakıcı", NationalityId="123456789"});
            Console.ReadLine();
        }
    }
}
