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

namespace tarwatch
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();

        // long Realtime = 0;
        // long Tarkovtime = 0;
        DateTime tarkovtime;
        


        public MainWindow()
        {
            InitializeComponent();
            tarkovtime = DateTime.Now;
            dispatcherTimer.Tick += new EventHandler(Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();


        }

        private void Tick(object sender, EventArgs e)
        {
           Realtimetext.Content = DateTime.Now.ToString("HH:mm:ss");
            tarkovtime=tarkovtime.AddSeconds(7);
            Tarkovtimetext.Content = tarkovtime.ToString("HH:mm:ss");
            Tarkovtime12text.Content = tarkovtime.AddHours(12).ToString("HH:mm:ss");

        }
        private void Refresh()
        {
            Realtimetext.Content = DateTime.Now.ToString("HH:mm:ss");
            //tarkovtime = tarkovtime.AddSeconds(7);
            Tarkovtimetext.Content = tarkovtime.ToString("HH:mm:ss");
            Tarkovtime12text.Content = tarkovtime.AddHours(12).ToString("HH:mm:ss");

        }








        private void hour_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            //int i = e.Delta;
            if (e.Delta > 0)
            {
                tarkovtime = tarkovtime.AddHours(1);
            }
            else if (e.Delta < 0)
            {
                tarkovtime = tarkovtime.Subtract(TimeSpan.FromHours(1));
            }
            Refresh();
            e.Handled = false;
        }

        private void minute_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            if (e.Delta > 0)
            {
                tarkovtime = tarkovtime.AddMinutes(1);
            }
            else if (e.Delta < 0)
            {
                tarkovtime = tarkovtime.Subtract(TimeSpan.FromMinutes(1));
            }
            Refresh();
        }

        private void secound_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            if (e.Delta > 0)
            {
                tarkovtime = tarkovtime.AddSeconds(1);
            }
            else if (e.Delta < 0)
            {
                tarkovtime = tarkovtime.Subtract(TimeSpan.FromSeconds(1));
            }
            Refresh();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void Window_Deactivated(object sender, EventArgs e)
        {
            Window window = (Window)sender;
            window.Topmost = true;
        }
    }
    
}
