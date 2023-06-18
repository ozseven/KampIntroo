using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class ApplyManager
    {
        public void Apply(ICreditMenager creditMenager ,ILoggerService loggerService)
        {
            creditMenager.Calculate();
            loggerService.Log();
        }
        public void CreditInforming(List<ICreditMenager> credits ,List<ILoggerService> loggerService)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
                foreach (var log in loggerService)
                {
                    log.Log();
                }
            }
        }
    }
}
