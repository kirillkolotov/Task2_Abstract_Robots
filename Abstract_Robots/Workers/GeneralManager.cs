using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public class GeneralManager : Worker
    {
        private bool More30;
        private double monthlySalary;
        //1. השלימות את התכונות החסרות

        public GeneralManager(string name, string id, DateTime bDate, string pass, double monthlySalary, bool More30)
            : base(name, id, bDate, pass)
        {
            this.More30 = More30;
            this.monthlySalary = monthlySalary;
            //2. השלימו את הקוד החסר לשמירת שכר בתכונה המתאימה
        }

        public override double Salary()
        {
            double wage = monthlySalary;
            if (More30 == true)
            {
                return monthlySalary + (monthlySalary * 0.15);
            }
            else
            {
                return monthlySalary;
            }
        }

        //3. כתבו פעולה דורסת לחישוב שכר

    }
}
