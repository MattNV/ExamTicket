using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    using System;
    {
        enum Company
        {Apple, Google, Facebook};

        class Worker
        {
            public Company DesiredCompany { get; set; }

            public Worker(Company company)
            {
                DesiredCompany = company;
            }

            public int GetSalary()
            {
                switch (DesiredCompany)
                {
                    case Company.Apple:
                        return 5000;
                    case Company.Google:
                        return 6000;
                    case Company.Facebook:
                        return 5500;
                    default:
                        return 0;
                }
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Worker worker1 = new Worker(Company.Apple);
                Worker worker2 = new Worker(Company.Google);
                Worker worker3 = new Worker(Company.Facebook);

                Console.WriteLine($"{worker1.DesiredCompany} зарплата: {worker1.GetSalary()}");
                Console.WriteLine($"{worker2.DesiredCompany} зарплата: {worker2.GetSalary()}");
                Console.WriteLine($"{worker3.DesiredCompany} зарплата: {worker3.GetSalary()}");

                Console.ReadLine();
            }
        }
    }

