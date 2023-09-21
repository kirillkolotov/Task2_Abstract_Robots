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
    /// Interaction logic for UcWorker.xaml
    /// </summary>
    public partial class UcWorker : UserControl
    {
        public UcWorker(Worker worker)
        {
            InitializeComponent();
            this.DataContext = worker; //binding👍😊😊😊😊😊😊😊😊😊😊😊🐸😒👌😘😂💕💕😍❤️😁👍👿
            lbID.Content = worker.GetId();
            lbBDay.Content = worker.GetBirthDate().ToShortDateString();
            DateTime today = DateTime.Now;
            DateTime birthdate = worker.GetBirthDate();
            if (birthdate.Month == today.Month && birthdate.Day == today.Day)
            {
                lbBDay.Content = lbBDay.Content + "🎂";
            }
            if (worker is GeneralManager)
            {
                lbRole.Content = "Big BOSS😎";
                this.Background = Brushes.Yellow;
            }
            else if (worker is OperationManager)
            {
                lbRole.Content = "Small BOSS😜";
                this.Background = Brushes.Orange;
            }

            else
                lbRole.Content = "worker💩";


        }
    }
}
