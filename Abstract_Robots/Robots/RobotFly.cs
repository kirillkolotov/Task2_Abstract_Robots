using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    //כתבו את המחלקה על פי המחלקות הקודמות
    //שימו לב שעליכם להתייחס גם לתעופה
    class RobotFly : RobotSpy
    {
        public RobotFly(DateTime creationDate) : base("Robofly", creationDate)
        { }
        

        public override void MoveBackward()
        {
            for (int i = 0; i < 6; i++)
                this.MoveLeg(i, -1);
        }

        public override void MoveForward()
        {
            for (int i = 0; i < 6; i++)
                this.MoveLeg(i, 1);
        }

        public override void TurnLeft()
        {
            for (int i = 0; i < 3; i++)
                this.MoveLeg(i, 1);
            for (int i = 2; i < 3; i++)
                this.MoveLeg(i, -1);
        }

        public override void TurnRight()
        {
            for (int i = 0; i < 3; i++)
                this.MoveLeg(i, -1);
            for (int i = 2; i < 3; i++)
                this.MoveLeg(i, 1);
        }

        public void fly()
        {
            BatteryStatus -= 1.5;
        }

        private void MoveLeg(int legId, int dir)
        {
            BatteryStatus -= 2;
        }
    }
}
