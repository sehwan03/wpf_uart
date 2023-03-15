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
using System.IO.Ports;
using static System.Net.Mime.MediaTypeNames;

namespace Wpf_UART
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        private SerialPort serial;  //serial port to send to uart page

        public Home()
        {
            InitializeComponent();
            serial = new SerialPort();

            try
            {
                //show list of valid com ports
                if (SerialPort.GetPortNames().Length != 0)
                {
                    btnSelect.IsEnabled = true;
                    foreach (string s in SerialPort.GetPortNames())
                    {
                        portsListBox.Items.Add(s);
                    }
                    //generate ports list
                }
                else
                {
                    throw new Exception("No serial ports found");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
                
        }

        private void portsListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                // 해당 포트 선택
                btnSelect_Click(sender, e);
            }
            catch(Exception ex )
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnSelect_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // set serial
                serial_init();
                //change page
                UART uartPage = new UART(serial);
                this.NavigationService.Navigate(uartPage);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }

        //setup serial port. should probably do this somewhere else.
        private void serial_init()
        {
            string selectedPort = portsListBox.SelectedItem.ToString();
            Int32 baudRate = Convert.ToInt32(baudsComboBox.Text);
            serial.PortName = selectedPort; //Com Port Name                
            serial.BaudRate = baudRate; //COM Port Sp
            serial.Handshake = System.IO.Ports.Handshake.None;
            serial.Parity = Parity.None;
            serial.DataBits = 8;
            serial.StopBits = StopBits.One;
            serial.ReadTimeout = 200;
            serial.WriteTimeout = 50;
        }
    }
}
