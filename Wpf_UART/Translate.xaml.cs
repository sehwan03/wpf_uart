using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Wpf_UART
{
    /// <summary>
    /// Translate.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Translate : Window
    {
        public Translate()
        {
            InitializeComponent();
        }

        private void TranslateButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                TranslateButton_Click(sender, e);
                e.Handled = true; // 이벤트 버블링을 막음
            }
        }

        // 버튼 클릭 이벤트 핸들러
        private void TranslateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (AsciiRadioButton.IsChecked == true)         // bug: Can't delete space
                {
                    string ascii = AsciiTextBox.Text.Replace(" ", "");
                    string hex = "";
                    string binary = "";
                    // ASCII to Hex
                    for (int i = 0; i < ascii.Length; i++)
                    {
                        hex += ((int)ascii[i]).ToString("X") + " ";
                    }
                    hex = hex.Trim();
                    HexTextBox.Text = hex;

                    // Ascii to Binary
                    foreach (char c in ascii)
                    {
                        string temp = Convert.ToString(c, 2);
                        temp = temp.PadLeft(8, '0');
                        binary += temp + " ";
                    }
                    binary = binary.Trim();
                    BinaryTextBox.Text = binary;
                }
                else if (HexRadioButton.IsChecked == true)
                {
                    string hex = HexTextBox.Text.Replace(" ", "");

                    byte[] bytes = Enumerable.Range(0, hex.Length)
                        .Where(x => x % 2 == 0)
                        .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                        .ToArray();
                    // Hex to ASCII
                    string ascii = Encoding.ASCII.GetString(bytes);
                    AsciiTextBox.Text = ascii;
                    // Hex to Binary
                    string binary = String.Join(" ", bytes.Select(b => Convert.ToString(b, 2).PadLeft(8, '0')));
                    BinaryTextBox.Text = binary;
                }
                else if (BinaryRadioButton.IsChecked == true)
                {
                    string binary = BinaryTextBox.Text.Replace(" ", "");

                    // Binary to ASCII
                    string ascii = "";
                    for (int i = 0; i < binary.Length; i += 8)
                    {
                        ascii += (char)Convert.ToByte(binary.Substring(i, 8), 2);
                    }
                    AsciiTextBox.Text = ascii;

                    // Binary to Hex
                    string hex = "";
                    for (int i = 0; i < binary.Length; i += 8)
                    {
                        hex += Convert.ToByte(binary.Substring(i, 8), 2).ToString("X2");
                    }
                    HexTextBox.Text = hex;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
           
        }

        private void AsciiTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string text = AsciiTextBox.Text;

            // Only add a space if the text box is not empty and the last character is not already a space
            if (text.Length > 0 && text[text.Length - 1] != ' ')
            {
                text += ' ';
            }

            // Remove any non-ASCII characters
            text = new string(text.Where(c => c >= 32 && c <= 127).ToArray());    

            // Update the text box
            AsciiTextBox.Text = text;
            AsciiTextBox.CaretIndex = text.Length;
        }

        private void HexTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string text = HexTextBox.Text.Replace(" ", "");

            // Check if the text contains only hexadecimal characters
            if (!Regex.IsMatch(text, "^[0-9A-Fa-f]*$"))
            {
                // If the text contains other characters, remove them and exit the method
                HexTextBox.Text = Regex.Replace(HexTextBox.Text, "[^0-9A-Fa-f ]", "");
                HexTextBox.SelectionStart = HexTextBox.Text.Length;
                return;
            }

            // Replace any characters that are not numbers or A-F with an empty string
            text = Regex.Replace(text, "[^0-9A-Fa-f]", "");

            // Insert spaces every two characters
            for (int i = 2; i < text.Length; i += 3)
            {
                text = text.Insert(i, " ");
            }

            // Update the text box
            HexTextBox.Text = text;
            HexTextBox.CaretIndex = text.Length;
        }

        private void BinaryTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string text = BinaryTextBox.Text.Replace(" ", "");

            // Check if the text contains only 0's and 1's
            if (!Regex.IsMatch(text, "^[01]*$"))
            {
                // If the text contains other characters, remove them and exit the method
                BinaryTextBox.Text = Regex.Replace(BinaryTextBox.Text, "[^01 ]", "");
                BinaryTextBox.SelectionStart = BinaryTextBox.Text.Length;
                return;
            }

            // Insert spaces every 8 characters
            for (int i = 8; i < text.Length; i += 9)
            {
                text = text.Insert(i, " ");
            }

            // Update the text box
            BinaryTextBox.Text = text;
            BinaryTextBox.CaretIndex = text.Length;
        }

        private void AsciiGotFocus(object sender, EventArgs e)
        {
            AsciiRadioButton.IsChecked = true;
        }
        private void HexGotFocus(object sender, EventArgs e)
        {
            HexRadioButton.IsChecked = true;
        }
        private void BinaryGotFocus(object sender, EventArgs e)
        {
            BinaryRadioButton.IsChecked = true;
        }
    }
}
