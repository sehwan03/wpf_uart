# WPF_UART
## Project Overview
A development tool for serial communication protocols.
Function:
 - Basic serial communication (9600, 57600, 115200 Baudrate)
 - Ascii-Hex-Binary converter + XOR operator

## Features
#### 1. Home
![image](https://github.com/sehwan03/wpf_uart/assets/102276311/faa15a64-090f-44c1-b49f-fa89ce6c90ee)

**COM(N)**: It represents a port connected to a computer. You can select that port for communication.

**Select**: After setting the baudrate on the right and configuring the COM port, proceed to the next page, the UART window, by clicking 'Select' with the provided information(port, baudrate).

**Refresh**: The computer is manually searching for the connected port.

**Smartphone**: You can directly open the Translate window using the private button.

#### 2. UART
![image](https://github.com/sehwan03/wpf_uart/assets/102276311/71539003-4acd-4d1c-b83f-6dc3b656bee3)

**File**: There are Open, Save, and Exit functionalities available.
 - Open: The previously saved text file is retrieved to recover the communication logs.
 - Save: The communication logs are saved as a text file.
 - Exit: Exit the program.

**Edit**: There are Back, and Clear Communication functionalities available.
 - Back: Go back to the previous page, which is Home.
 - Clear Communication: Reset the communication logs.

**Tools**: There is Converter functionalities available.
 - Converter: Open the Translate window.

**Help**: There is About functionalities available.
 - About: Open the About window.

**Hex Send**: Send the hex values written on the left to the COM port.

**UART Tx**: Display the sent hex values.

**UART Rx**: Display the received hex values.

#### 3. Translate
![image](https://github.com/sehwan03/wpf_uart/assets/102276311/a2ca38e4-99d7-4848-b255-204915982fbe)

If you select one of Ascii, Hex, and Binary and enter the value, the other two are automatically converted and the value is entered. 
Then, the xor operation is performed on the value, and it is entered into the XOR box.

#### 4. About
![image](https://github.com/sehwan03/wpf_uart/assets/102276311/998d4a53-0981-471e-af85-793daf250481)

## Examples
### 1. Initial state
![image](https://github.com/sehwan03/wpf_uart/assets/102276311/444935d5-6475-4a5b-a678-6fc3af902fe1)

HW: Two USB to TTL converters are cross-connected with Rx and Tx.
SW: This program is connected to COM port 5, while Docklight is connected to COM port 6. The baud rate is set to 9600.

### 2. Tx state
![image](https://github.com/sehwan03/wpf_uart/assets/102276311/a5cf57e9-0032-40d6-a2da-8d6e1d90ccea)
 -> Enter the hex value and click on 'Hex send'
![image](https://github.com/sehwan03/wpf_uart/assets/102276311/e1388919-6547-4bb1-a7e5-bdaabeec02e8)

### 3. Rx state
![image](https://github.com/sehwan03/wpf_uart/assets/102276311/139efcae-52a6-48af-8d90-25b044110c29)
![image](https://github.com/sehwan03/wpf_uart/assets/102276311/0ca9e688-b79a-4490-a627-3d682af90290)


