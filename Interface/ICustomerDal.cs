using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();

    }

    class SqlCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql Added");
        }

        public void Update()
        {
            Console.WriteLine("Sql Update");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Delete");
        }
    }

    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Update");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Delete");
        }
    }

    class CustomerManager
    {
        public void Add(ICustomerDal iCustomerDal)
        {
            iCustomerDal.Add();
        }
    }
}
