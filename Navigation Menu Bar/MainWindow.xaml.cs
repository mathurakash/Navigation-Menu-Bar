using AdvancedNotepad_CSharp;
using My_Radio_Station;
using Panguian;
using shootzombi;
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


namespace Navigation_Menu_Bar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        System.Windows.Threading.DispatcherTimer Timer = new System.Windows.Threading.DispatcherTimer();
        public MainWindow()
        {
           
            InitializeComponent();
            Timer.Tick += new EventHandler(Timer_Click);

            Timer.Interval = new TimeSpan(0, 0, 1);

            Timer.Start();

           
        }

        private void Timer_Click(object sender, EventArgs e)

        {

            DateTime d;

            d = DateTime.Now;

            label1.Content = d.Hour + " : " + d.Minute + " : " + d.Second;

            labeldate.Content = DateTime.Now.ToString("dd-MMM-yyyy");

        }
        private void Power_Click(object sender, RoutedEventArgs e)
        {
            PowerBox.Visibility = Visibility.Visible;
        }

        private void Setting_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Setting_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Map_Click(object sender, RoutedEventArgs e)
        {
            Browser browser = new Browser();
            browser.addressTextBox.Text = "https://akash700.000webhostapp.com";
                browser.Show();
        }

        private void Message_Click(object sender, RoutedEventArgs e)
        {
            WPFChatExample chat = new WPFChatExample();
            chat.Show();
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            Home home = new Home();
            home.Show();
        }

        private void Contact_Click(object sender, RoutedEventArgs e)
        {
            Contact contact = new Contact();
            contact.Show();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            PowerBox.Visibility = Visibility.Hidden;
        }

        private void ShutDown_Click(object sender, RoutedEventArgs e)
        {
            ShutDown shutdown = new ShutDown();
            
            shutdown.Show();
            
        }

        private void Calulator_Click(object sender, RoutedEventArgs e)
        {
            
            Calculator calc = new Calculator();
            Tg_Btn.IsChecked = false;
            calc.Show();
        }

        private void Music_Click(object sender, RoutedEventArgs e)
        {
            Music music = new Music();
            Tg_Btn.IsChecked = false;
            music.Show();
        }

        private void Notepad_Click(object sender, RoutedEventArgs e)
        {
            MainForm notepad = new MainForm();
            Tg_Btn.IsChecked = false;
            notepad.Show();
        }

        private void Browser_Click(object sender, RoutedEventArgs e)

        {
            Browser web = new Browser();
            Tg_Btn.IsChecked = false;
            web.Show();
        }

        private void Sleep_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Disk_Click(object sender, RoutedEventArgs e)
        {
            SystemInfo si = new SystemInfo();
            Tg_Btn.IsChecked = false;
            si.Show();
        }

        private void Paint_Click(object sender, RoutedEventArgs e)
        {
            Paint paint = new Paint();
            Tg_Btn.IsChecked = false;
            paint.Show();
        }

        private void ZombiGame_Click(object sender, RoutedEventArgs e)
        {
            Form1 zombi = new Form1();
            Tg_Btn.IsChecked = false;
            zombi.Show();
        }

        private void CoinCollection_Click(object sender, RoutedEventArgs e)
        {
            CoinCollection coinColection = new CoinCollection();
            Tg_Btn.IsChecked = false;
            coinColection.Show();
        }

        private void TextToSpeech_Click(object sender, RoutedEventArgs e)
        {
            Text_To_Speech texttospeech = new Text_To_Speech();
            Tg_Btn.IsChecked = false;
            texttospeech.Show();
        }

        private void AlarmButton_Click(object sender, RoutedEventArgs e)
        {
            //Alarm alarm = new Alarm();
            //alarm.Show();
        }

        private void Radio_Click(object sender, RoutedEventArgs e)
        {
            Radio radio = new Radio();
            Tg_Btn.IsChecked = false;
            radio.Show();
        }
    }
}
