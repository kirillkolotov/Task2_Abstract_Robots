using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Robots_inc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Worker> workers; //אוסף עובדים 
        List<Mission> activeMissions;//אוסף משימות פעילות
        List<RobotSpy> activeRobots; //אוסף רובוטים פעילים

        public MainWindow()
        {
            InitializeComponent();
            workers = GetWorkers();
            activeRobots = GetRobots();
            activeMissions = GetMissions();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Have a robotic day (-:", "Good bye", MessageBoxButton.OK);
            this.Close();
        }



        //משימה 1
        // : כתבו פעולה המחזירה אוסף של 6 עובדים 
        //מנכ"ל אחד, 2 מנהלי תפעול ו-4 עובדי תפעול
        //כתבו זימון לפעולה שכתבתם בפעולה הבונה של החלון
        private List<Worker> GetWorkers()
        {
            List<Worker> list = new List<Worker>();
            list.Add(new GeneralManager("michael", "214", DateTime.Parse("10.5.2002"), "123", 15000, true));
            list.Add(new OperationManager("dima", "215", DateTime.Parse("11.5.2002"), "123", 40, 40, 35));
            list.Add(new OperationManager("anton", "216", DateTime.Parse("12.5.2002"), "123", 40, 40, 35));
            list.Add(new OperationalWorker("abdul", "331", DateTime.Parse("13.5.2002"), "123", 30, 40));
            list.Add(new OperationalWorker("mohamad", "332", DateTime.Parse("14.5.2002"), "123", 30, 40));
            list.Add(new OperationalWorker("mahmud", "333", DateTime.Parse("15.5.2002"), "123", 30, 40));
            list.Add(new OperationalWorker("xingxong", "334", DateTime.Parse("16.5.2002"), "123", 30, 40));

            return list;
        }

        //משימה 2
        //כתבו פעולה המחזירה אוסף של 8 רובוטים
        //כתבו זימון לפעולה שכתבתם בפעולה הבונה של החלון
        private List<RobotSpy> GetRobots()
        {
            List<RobotSpy> list = new List<RobotSpy>();
            list.Add(new RobotQuad(DateTime.Parse("11.9.2000")));
            list.Add(new RobotQuad(DateTime.Parse("12.9.2000")));
            list.Add(new RobotQuad(DateTime.Parse("13.9.2000")));
            list.Add(new RobotQuad(DateTime.Parse("14.9.2000")));
            list.Add(new RobotQuad(DateTime.Parse("15.9.2000")));
            list.Add(new RobotQuad(DateTime.Parse("16.9.2000")));
            list.Add(new RobotQuad(DateTime.Parse("17.9.2000")));
            list.Add(new RobotQuad(DateTime.Parse("18.9.2000")));

            return list;
        }

        //משימה 3
        //כתבו פעולה המחזירה אוסף של 5 משימות
        //כתבו זימון לפעולה שכתבתם בפעולה הבונה של החלון       
        private List<Mission> GetMissions()
        {
            List<Mission> list = new List<Mission>();
            list.Add(new Mission(DateTime.Parse("18.9.2034"), "help xingxong fight the samurais for his homeland"));
            list.Add(new Mission(DateTime.Parse("18.9.2033"), "give anton some water hes thirsty"));
            list.Add(new Mission(DateTime.Parse("18.9.2032"), "give the manager some water hes thirsty"));
            list.Add(new Mission(DateTime.Parse("18.9.2031"), "give the manager some hamburgers hes hungry"));
            list.Add(new Mission(DateTime.Parse("18.9.2030"), "give the fat manager french fries hes hungry"));

            return list;
        }

        //משימה 4
        //login כתבו פעולה המגיבה לללחיצה על כפתור 
        //אם הפרטים לא תואמים לעובד הקיים באוסף העובדים - תוצג הודעה מתאימה
        //WndMain אם כן, יש ליצור מופע של חלון 
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            foreach (Worker worker in workers)
            {
                if (worker.GetId().Equals(tbxID.Text) && worker.GetPassword().Equals(tbxPassword.Password))
                {
                    WndMain main = new WndMain(worker, activeMissions, activeRobots, workers);
                    main.ShowDialog();
                    return;
                }
            }
        }
    }
}
