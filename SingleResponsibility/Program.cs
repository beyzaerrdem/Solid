using System;

namespace SingleResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }


    class Customer //Tek Sorumluluk
    {
        public string name { get; set; }
    }

    class CustomerValidator  //Validasyonlar ayrı classta olmalı
    {
        public bool ValidateName(string name)
        {
            return !string.IsNullOrEmpty(name);
        }
    }

    class CustomerManager //işlemler ayrı classta
    {
        public void SayHello(string name)
        {
            Console.WriteLine("Hello" + name);
        }
    }
}

