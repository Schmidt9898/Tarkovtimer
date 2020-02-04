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
        //DateTime tarkovtime;
        
        DateTime origin;
        DateTime currentTime;
        TimeSpan offsetTime;
        TimeSpan elapsedSpan;
        long elapsedTicks;


        public MainWindow()
        {
            InitializeComponent();
            //tarkovtime = DateTime.Now;

            try
            {
                byte[] f=System.IO.File.ReadAllBytes("save.f");
                origin = new DateTime(BitConverter.ToInt64(f, 0));
                offsetTime = new TimeSpan(BitConverter.ToInt64(f, 8));

            }catch(System.IO.FileNotFoundException)
            {
                origin = DateTime.Now;
                offsetTime = new TimeSpan(1000, 0, 0, 0, 0);
            }
            catch(Exception e)
            {
                origin = DateTime.Now;
                offsetTime = new TimeSpan(1000, 0, 0, 0, 0);
            }



            dispatcherTimer.Tick += new EventHandler(Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0,0,100);
            dispatcherTimer.Start();


        }

        private void Tick(object sender, EventArgs e)
        {

            currentTime = DateTime.Now;
            elapsedTicks = (currentTime.Ticks - origin.Ticks) * 7 + offsetTime.Ticks;
            elapsedSpan = TimeSpan.FromTicks(elapsedTicks);
            

            Realtimetext.Content = currentTime.ToString("HH:mm:ss");

            Tarkovtimetext.Content =  elapsedSpan.ToString("hh':'mm':'ss");
            Tarkovtime12text.Content = elapsedSpan.Add(TimeSpan.FromHours(12)).ToString("hh':'mm':'ss");


        }
        private void Refresh()
        {

            elapsedTicks = (currentTime.Ticks - origin.Ticks) * 7 + offsetTime.Ticks;
            elapsedSpan = TimeSpan.FromTicks(elapsedTicks);

            Realtimetext.Content = currentTime.ToString("HH:mm:ss");

            Tarkovtimetext.Content = elapsedSpan.ToString("hh':'mm':'ss");
            Tarkovtime12text.Content = elapsedSpan.Add(TimeSpan.FromHours(12)).ToString("hh':'mm':'ss");

        }








        private void hour_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            //int i = e.Delta;
            if (e.Delta > 0)
            {
                offsetTime = offsetTime.Add(TimeSpan.FromHours(1));
            }
            else if (e.Delta < 0)
            {
                offsetTime = offsetTime.Subtract(TimeSpan.FromHours(1));
            }
            Refresh();
        }

        private void minute_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            if (e.Delta > 0)
            {
                offsetTime = offsetTime.Add(TimeSpan.FromMinutes(1));
            }
            else if (e.Delta < 0)
            {
                offsetTime = offsetTime.Subtract(TimeSpan.FromMinutes(1));
            }
            Refresh();
        }

        private void secound_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            if (e.Delta > 0)
            {
                offsetTime = offsetTime.Add(TimeSpan.FromSeconds(1));
            }
            else if (e.Delta < 0)
            {
                offsetTime = offsetTime.Subtract(TimeSpan.FromSeconds(1));
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

        private void resetbtn_Click(object sender, RoutedEventArgs e)
        {
            origin = DateTime.Now;
            offsetTime = new TimeSpan(1000,0,0, 0, 0);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            byte[] o = BitConverter.GetBytes(origin.Ticks);
            byte[] s = BitConverter.GetBytes(offsetTime.Ticks);
            
            System.IO.Stream stream = System.IO.File.OpenWrite("save.f");
            stream.Write(o, 0, 8);
            stream.Write(s, 0, 8);
            stream.Flush();
            stream.Close();

        }
    }
    
}
