using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ApplyManager applyManager = new ApplyManager();
            ICreditMenager credit1 = new TransportCreditManager();
            ICreditMenager credit = new MortgageCreditManager();
            ICreditMenager credit2 = new PersonalFinanceCreditManager();


            List<ICreditMenager> credits = new List<ICreditMenager>() { credit,credit1,credit2};

            ILoggerService loggerService = new EmailLoggerService();
            ILoggerService loggerService1 = new DatabaseLoggerService();
            List<ILoggerService> loggerServices = new List<ILoggerService>() {loggerService1,loggerService };
            applyManager.CreditInforming(credits,loggerServices);
            Console.ReadLine();
        }
    }
}
