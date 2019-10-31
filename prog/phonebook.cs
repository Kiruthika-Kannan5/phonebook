using System;
using System.Collections.Generic;


namespace phonebookapplication
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> name = new List<string>();
            List<int> phonenumber = new List<int>();
            Console.WriteLine("Welcome to Phone book application:");
            Console.WriteLine("Enter Your options:");
            Console.WriteLine("1. Add a contact in phone book:");
            Console.WriteLine("2. Delect a contact");
            int options = Convert.ToInt32(Console.ReadLine());
            switch(options)
            {
                case '1': AddPhoneBook(name,phonenumber);
                          break;
                
                case '2': DeletePhoneBook();
                          break;
            }
        }

        public static void AddPhoneBook(List<string> name ,List<int> phonenumber)
        {
             Console.WriteLine("enter name:");
             name.Add(Console.ReadLine());
             Console.WriteLine("enter phone number:");
             phonenumber.Add(Convert.ToInt32(Console.ReadLine())); 
        }
        public static void DeletePhoneBook()
        {
            Console.WriteLine("Want to delete:");

        }
    }
}