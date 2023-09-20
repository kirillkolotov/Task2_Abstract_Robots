using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public class OperationalWorker : Worker
    {
        private double hours;
        private double Hourlypay;
        //2. השלימות את התכונות החסרות

        public OperationalWorker(string name, string id, DateTime bDate, string pass, double Hourlypay, double hours)
            : base(name, id, bDate, pass)
        {
            //3. השלימו את הקוד החסר לשמירת שכר בתכונה המתאימה
            // ?האם נדרשים פרמטרים נוספים
            this.hours = hours;
            this.Hourlypay = Hourlypay;
        }

        public override double Salary()
        {
            return hours * Hourlypay;
        }
        //4. כתבו פעולה דורסת לחישוב שכר
    }
}
