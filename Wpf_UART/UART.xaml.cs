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
using System.Windows.Threading;
using System.Threading;

namespace Wpf_UART
{
    /// <summary>
    /// Interaction logic for UART.xaml
    /// </summary>
    public partial class UART : Page
    {
        private SerialPort serial;

        public UART(SerialPort rxPort)
        {
            InitializeComponent();

            serial = rxPort;
            //set serial recieve function
            serial.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(Receive);
            serial.Open();
            // Loaded 이벤트에 대한 이벤트 핸들러 등록
            Loaded += UART_Loaded;
        }

        private void UART_Loaded(object sender, RoutedEventArgs e)
        {
            // TextBox에 포커스 설정
            uartTxTextBox.Focus();
        }

        private void uartTxTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string text = uartTxTextBox.Text.Replace(" ", "");

            // Insert spaces every two characters
            for (int i = 2; i < text.Length; i += 3)
            {
                text = text.Insert(i, " ");
            }

            // Update the text box
            uartTxTextBox.Text = text;
            uartTxTextBox.CaretIndex = text.Length;
        }

        private void uartTxTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                btnSend_Click(sender, e);
                e.Handled = true; // 이벤트 버블링을 막음
            }
        }

        private void MenuItem_Translate_Click(object sender, EventArgs e)
        {

        }
        private void MenuItem_ClearCommunication_Click(object sender, EventArgs e)
        {
            txListBox.Items.Clear();
            rxListBox.Items.Clear();
        }

        private void MenuItem_Exit_Click(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl))
            {
                if (e.Key == Key.W)
                {
                    MenuItem_ClearCommunication_Click(sender, e);
                }
            }
        }

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            //get data from text box
            String data = uartTxTextBox.Text.ToString();
            if(!string.IsNullOrEmpty(data))
            {
                Send(data);
            }   

            uartTxTextBox.Text = "";
            uartTxTextBox.Focus();
        }
        //send serial data
        private void Send(String data)
        {
            if (serial.IsOpen)
            {
                try
                {           
#if false
                    // Send the binary data out the port
                    byte[] hexstring = Encoding.ASCII.GetBytes(data);
                    foreach (byte hexval in hexstring)
                    {
                        byte[] _hexval = new byte[] { hexval };     // need to convert byte 
                                                                    // to byte[] to write
                        serial.Write(_hexval, 0, 1);
                        Thread.Sleep(1);
                    }
                    txListBox.Items.Add(data);  //add to data sent.
#else
                    // Convert input string to byte array in hex format
                    byte[] hexBytes = data
                        .Split(' ')
                        .Where(x => !string.IsNullOrWhiteSpace(x))
                        .Select(x => Convert.ToByte(x, 16))
                        .ToArray();

                    // Send the binary data out the port
                    serial.Write(hexBytes, 0, hexBytes.Length);
                    txListBox.Items.Add(data); // Add to data sent.
#endif
                }
                catch (Exception ex)
                {
                    /*para.Inlines.Add("Failed to SEND" + data + "\n" + ex + "\n");
                    mcFlowDoc.Blocks.Add(para);
                    Commdata.Document = mcFlowDoc;*/
                }
            }
        }

        //recieve data thread
        private void Receive(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
#if false
            // Collecting the characters received to our 'buffer' (string).
            var recieved_data = serial.ReadExisting();
            //dispatcher to the UI thread
            Dispatcher.Invoke(() =>
            { 
                // update text box
                rxListBox.Items.Add(recieved_data);
            });
#else
            // Collecting the characters received to our 'buffer' (string).
            var recieved_data = serial.ReadExisting();
            // Converting the received data to hex string format.
            var hex_data = BitConverter.ToString(Encoding.Default.GetBytes(recieved_data)).Replace("-", " ");
            //dispatcher to the UI thread
            Dispatcher.Invoke(() =>
            {
                // update text box with hex values
                rxListBox.Items.Add(hex_data);
            });
#endif
        }
    }

}
