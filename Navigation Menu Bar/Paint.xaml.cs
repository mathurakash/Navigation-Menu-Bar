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

namespace Navigation_Menu_Bar
{
    /// <summary>
    /// Interaction logic for Paint.xaml
    /// </summary>
    public partial class Paint : Window
    {
        public Paint()
        {
            InitializeComponent();
        }
        private void inkCanvas1_Gesture(object sender, InkCanvasGestureEventArgs e)
        {
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.inkCanvas1.Strokes.Clear();
            //MessageBox.Show("you have press the clear button");
        }
        private void button2_Click(object sender, RoutedEventArgs e)
        {
           // MessageBox.Show("Now the window will be closed thanx for using InkPad");
            this.Close();
        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
