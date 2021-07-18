using System;
using System.Windows;
using System.Windows.Threading;

namespace Navigation_Menu_Bar
{
    /// <summary>
    /// Interaction logic for SplashScreen.xaml
    /// </summary>
    /// 
    public partial class SplashScreen : Window
    {
        DispatcherTimer dT = new DispatcherTimer();
        public SplashScreen()
        {
            InitializeComponent();
            dT.Tick += new EventHandler(dT_Tick);
            dT.Interval = new TimeSpan(0, 0, 5);
            dT.Start();
        }


        private void dT_Tick(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();

            dT.Stop();
            this.Close();
        }
    }
}
