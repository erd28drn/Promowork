using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WIA;
using System.IO;
using System.Windows.Media.Imaging;


namespace Promowork.Escanear
{
    public partial class Escanear : Form
    {
        public Escanear()
        {
            InitializeComponent();
        }

        private void Escanear_Load(object sender, EventArgs e)
        {


            lbDevices.Items.Clear();
            var deviceManager = new DeviceManager();
            for (int i = 1; i <= deviceManager.DeviceInfos.Count; i++)
            {
                if (deviceManager.DeviceInfos[i].Type != WiaDeviceType.ScannerDeviceType)
                {
                    return;
                }
                lbDevices.Items.Add(new Scanner(deviceManager.DeviceInfos[i]));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var device = lbDevices.SelectedItem as Scanner;
            if (device == null)
            {
                MessageBox.Show("Please select a device.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var image = device.Scan();
            var path = @"C:\Users\USUARIO2\Pictures\scan.jpeg";
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            try
            {
                image.SaveFile(path);
                BitmapImage BImage = new BitmapImage(new Uri(path, UriKind.Absolute));
               // pbVistaPrevia.DrawToBitmap(BImage, new Rectangle());
                //img.Source = BImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Utilidades.ConvertirPDF();
        }
    }
}
