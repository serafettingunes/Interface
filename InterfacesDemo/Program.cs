using System;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorked[] iWorkeds = new IWorked[3]
            {
                new Robot(),
                new Manager(),
                new Worker()
            };

            foreach (var item  in iWorkeds)
            {
                item.Work();
            }
        }
    }

    interface IWorked
    {
         void Work();



    }

    interface IEated
    {
         void Eat();



    }

    interface ISalary
    {
        void Salary();




    }

    class Robot : IWorked
    {
        public void Work()
        {
            
        }
    }

    class Worker: IWorked,ISalary,IEated
    {
        public void Work()
        {
            
        }

        public void Salary()
        {
            
        }

        public void Eat()
        {

        }
    }

    class Manager:IWorked,ISalary,IEated
    {
        public void Work()
        {

        }

        public void Salary()
        {
            
        }

        public void Eat()
        {
            
        }
    }
}
