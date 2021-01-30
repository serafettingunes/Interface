using System;

namespace Kalitim
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Person{Ad = "Kaan"},
                new Customer{Ad = "Şerafettin",CustomerOzellik = "Yönetici",Id = 4,Soyad = "Güneş"},
                new Student{Ad = "Ali"}
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.Ad);
            }
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

    }

    class Student : Person
    {
        public string Departman { get; set; }
        
    }

    class Customer : Person
    {
        public string CustomerOzellik { get; set; }
    }


}
