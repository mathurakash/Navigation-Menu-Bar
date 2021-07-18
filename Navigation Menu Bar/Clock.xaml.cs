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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Navigation_Menu_Bar
{
    /// <summary>
    /// Interaction logic for Clock.xaml
    /// </summary>
    public partial class Clock : Window
    {
        public Clock()
        {
            InitializeComponent();
            sj.Content = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
        }

        DispatcherTimer tim = new DispatcherTimer();
        // animation
        Storyboard donghua = new Storyboard();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tim.Interval = new TimeSpan(0, 0, 1);
            tim.Tick += Tim_Tick;
            tim.Start();
            // actual time
            double miao = DateTime.Now.Second * 6;
            double fen = DateTime.Now.Minute * 6;
            double shi = (DateTime.Now.Hour * 30) + (DateTime.Now.Minute * 0.5);
            #region  Clock picture background
            Image bg = new Image();
            bg.Source = new BitmapImage(new Uri("clipart524030.png", UriKind.RelativeOrAbsolute));
            ImageBrush brush = new ImageBrush();
            brush.ImageSource = bg.Source;
            BG.Background = brush;
            #endregion
            // seconds, minutes, hours
            Shijian(miao, Miao, 1);
            Shijian(fen, Fen, 60);
            Shijian(shi, Shi, 720);
        }

        private void Tim_Tick(object sender, EventArgs e)
        {
            NewTimer.Header = DateTime.Now.ToString();
            sj.Content = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
        }

        /// <summary>
        /// Time method
        /// </summary>
        /// <param name="miao">Current time</param>
        /// <param name="shijian">Hours, minutes, and seconds arbitrary pointers</param>
        /// <param name="x">execution time</param>
        private void Shijian(double miao, Border shijian, int x)
        {
            DoubleAnimation miaoanim = new DoubleAnimation(miao, 360 + miao, new Duration(TimeSpan.FromMinutes(x)));
            Storyboard.SetTarget(miaoanim, shijian);
            Storyboard.SetTargetProperty(miaoanim, new PropertyPath("RenderTransform.Angle"));
            miaoanim.RepeatBehavior = RepeatBehavior.Forever;
            donghua.Children.Add(miaoanim);
            RotateTransform rotate = new RotateTransform();
            shijian.RenderTransform = rotate;
            shijian.RenderTransformOrigin = new Point(1, 1);
            donghua.Begin();
        }

        private void SetAlarm_Click(object sender, RoutedEventArgs e)
        {
            //AlarmmClock newwin = new AlarmmClock();
            //newwin.Show();
        }
    }
}
