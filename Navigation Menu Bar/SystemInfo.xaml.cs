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
using System.Management;
using System.IO;

namespace Navigation_Menu_Bar
{
    /// <summary>
    /// Interaction logic for SystemInfo.xaml
    /// </summary>
    public partial class SystemInfo : Window
    {


        public SystemInfo()
        {
            InitializeComponent();
            List<string> Type = new List<string>();
            foreach (DriveInfo di in DriveInfo.GetDrives())
            {
                Type.Add(di.Name);
                cboDrive.SelectedIndex = 1;
            }

            cboDrive.ItemsSource = Type;

        }

        //Make a list of drives.
        //private void SysytemInfo_Load(object sender, EventArgs e)
        //{
        //    foreach (DriveInfo di in DriveInfo.GetDrives())
        //    {
        //        cboDrive.Items.Add(di.Name);
        //        cboDrive.SelectedIndex = 0;
        //    }
        //}


        // Display information about the selected drive.
        //private void cboDrive_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    string drive_letter = cboDrive.Text.Substring(0, 1);
        //    DriveInfo di = new DriveInfo(drive_letter);
        //    lblIsReady.Text = di.IsReady.ToString();
        //    lblDriveType.Text = di.DriveType.ToString();
        //    lblName.Text = di.Name;
        //    lblRootDirectory.Text = di.RootDirectory.Name;
        //    if (di.IsReady)
        //    {
        //        lblDriveFormat.Text = di.DriveFormat;
        //        lblAvailableFreeSpace.Text = di.AvailableFreeSpace.ToString();
        //        lblTotalFreeSize.Text = di.TotalFreeSpace.ToString();
        //        lblTotalSize.Text = di.TotalSize.ToString();
        //        lblVolumeLabel.Text = di.VolumeLabel;
        //    }
        //    else
        //    {
        //        lblDriveFormat.Text = "";
        //        lblAvailableFreeSpace.Text = "";
        //        lblTotalFreeSize.Text = "";
        //        lblTotalSize.Text = "";
        //        lblVolumeLabel.Text = "";
        //    }
        //}
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            
            this.Close();
        }
        private void cboDrive_SelectionChanged(object sender, EventArgs e)
        {
            //string drive_letter = cboDrive.Text.Substring(0, 1);
            string drive_letter = cboDrive.SelectedItem.ToString();
            DriveInfo di = new DriveInfo(drive_letter);
            lblIsReady.Text = di.IsReady.ToString();
            lblDriveType.Text = di.DriveType.ToString();
            lblName.Text = di.Name;
            lblRootDirectory.Text = di.RootDirectory.Name;
            if (di.IsReady)
            {
                lblDriveFormat.Text = di.DriveFormat;
                lblAvailableFreeSpace.Text = di.AvailableFreeSpace.ToString();
                lblTotalFreeSize.Text = di.TotalFreeSpace.ToString();
                lblTotalSize.Text = di.TotalSize.ToString();
                lblVolumeLabel.Text = di.VolumeLabel;
                
            }
            else
            {
                lblDriveFormat.Text = "";
                lblAvailableFreeSpace.Text = "";
                lblTotalFreeSize.Text = "";
                lblTotalSize.Text = "";
                lblVolumeLabel.Text = "";
            }
        }




    }
}
