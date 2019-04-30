using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee[] workers = { (new Employee { fname = "Adam", lname = "Zamboni", id = 1 }),
                                  (new Employee { fname = "Byron", lname = "Yalk", id = 2 }),
                                  (new Employee { fname = "Carlotta", lname = "Xarba", id = 3 }),
                                (new Employee { fname = "Denver", lname = "Waters", id = 4 }),
                                (new Employee { fname = "Ethel", lname = "Valte", id = 5 }),
                                (new Employee { fname = "Fatima", lname = "Usana", id = 6 }),
                                (new Employee { fname = "Grigor", lname = "Tomtom", id = 7 }),
                                (new Employee { fname = "Helena", lname = "Sassafrass", id = 8 }),
                                (new Employee { fname = "Joe", lname = "Rolfe", id = 9 }),
                                (new Employee { fname = "Joe", lname = "Quartz", id = 10 }) };

            List<Employee> joes = new List<Employee>();

            foreach(Employee emp in workers)
            {
                if(emp.fname == "Joe")
                {
                    joes.Add(emp);
                }
            }

            List<Employee> joes2 = workers.Where(x => x.fname == "Joe").ToList();
            List<Employee> high_ids = workers.Where(y => y.id > 5).ToList();


        }
    }
}
