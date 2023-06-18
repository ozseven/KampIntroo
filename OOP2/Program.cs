using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer = new IndividualCustomer{  customerNo = "123654", id = 0, name = "Ahmet", surname = "özseven" };
            CoorporateCustomer customer1 = new CoorporateCustomer() { CompanyName = "ABC", customerNo = "123456", id = 1, name = "Emirhan", surname = "Özseven", taxNo = "654165" };


            Customer customer2 = new IndividualCustomer();
            Customer customer3 = new CoorporateCustomer();
        }
    }
}
