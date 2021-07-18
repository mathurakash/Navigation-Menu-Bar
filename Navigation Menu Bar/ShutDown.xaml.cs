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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Navigation_Menu_Bar
{
    /// <summary>
    /// Interaction logic for ShutDown.xaml
    /// </summary>
    public partial class ShutDown : Window
    {
        DispatcherTimer dT = new DispatcherTimer();
        public ShutDown()
        {
            InitializeComponent();
            dT.Tick += new EventHandler(dT_Tick);
            dT.Interval = new TimeSpan(0, 0, 5);
            dT.Start();
        }

        private void dT_Tick(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
            dT.Stop();
            this.Close();
        }
    }
}
