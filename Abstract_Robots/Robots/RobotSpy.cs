using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
	public abstract class RobotSpy
	{
		private string model;
		private DateTime creationDate;
		private double batteryStatus; 

		//1. עדכנו את הפעולה הבונה כך שתקבל פרמטרים בהתאם לתכונות
		public RobotSpy(string model, DateTime creationDate)
		{
			this.model = model;
			this.creationDate = creationDate;
			batteryStatus = 100; 

        }
        //2. השלימו פעולות מאחזרות עבור התכונות הנוספות
        //3. הוסיפו פעולה המעדכנת את מצב הסוללה
        public string GetModel() { 	return this.model; }
        public DateTime CreationDate { get { return creationDate; }}
        public double BatteryStatus { get { return batteryStatus; } set { batteryStatus = value; } }
        
        public abstract void MoveForward();
		public abstract void MoveBackward();
		public abstract void TurnLeft();
		public abstract void TurnRight();

		public void TakePicture() { batteryStatus -= 5; } //4. הוסיפו התייחסות למצב סוללה
		
		public void ChargeBattery() { this.batteryStatus = 100.0; } //5. עדכנו את מצב הסוללה ל-100
	
	}
}
