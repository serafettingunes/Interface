using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //NewMethod();

            //NewMethod1();


            ICustomerDal[] iCustomerDals = new ICustomerDal[2]
            {
                new OracleCustomerDal(),
                new SqlCustomerDal()

            };

            foreach (var itemCustomerDal in iCustomerDals)
            {
                itemCustomerDal.Add();
            }
        }

        private static void NewMethod1()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());
        }

        private static void NewMethod()
        {
            PersonManager personManager = new PersonManager();
            personManager.Add(new Student() { Id = 4, Ad = "Enes", Soyad = "Güneş", Not = 100 });
            personManager.Add(new Worker() { Id=5,Ad="Halil",Soyad="Güneş", });
        }
    }
    interface IPerson
    {
        int Id { get; set; }
        string Ad { get; set; }
        string Soyad { get; set; }


    }

    class Student : IPerson
    {
      public  int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Not { get; set; }


    }
    class Musteri : IPerson
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Para { get; set; }
    }

    class Worker : IPerson
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.Ad+" "+person.Soyad);
        }
    }
}