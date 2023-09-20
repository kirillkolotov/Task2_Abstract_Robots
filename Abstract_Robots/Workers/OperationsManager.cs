using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public class OperationManager : Worker
    {
        //1. השלימות את התכונות החסרות
        private double hours;
        private double Hourlypay;
        private int missionsDone;
        public OperationManager(string name, string id, DateTime bDate, string pass, double hours, double Hourlypay, int missionsDone)
            : base(name, id, bDate, pass)
        {
            this.hours = hours;
            this.missionsDone = missionsDone;
            this.Hourlypay = Hourlypay;
            //2. השלימו את הקוד החסר לשמירת שכר בתכונה המתאימה
        }

        public override double Salary()
        {
            double wage = (hours * Hourlypay);
            return wage + (wage * 0.03) * missionsDone;
        }

        //3. כתבו פעולה דורסת לחישוב שכר

    }
}
