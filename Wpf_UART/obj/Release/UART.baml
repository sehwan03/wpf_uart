   M S B A M L   `   `   `  ����   UART_Monitor    Wpf_UART.UART   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     $	��400��$	��700��  N� Title$
  UART��.��� -   $�� 10,0,10,10q�����  �� Color$ #94A4A5�� � ColumnDefinitions �� $��35 ��� $	��300 ��� $��20 ��� $	��300 ��� $��35 � � RowDefinitions �� $��60 ��� $��30 ��� $	��235 ��� $��45 ��� $��30 �.+��� $��1��$��35�� �� Padding$ 5q����#59C2C9$	��Top=�$��0,55,0,0q�$��2�� �� CornerRadius$ 5,5,0,0��._��� $��Center=�$��Trebuchet MS)�
�������$��Center=�$
��Bold"�.��	UART Tx�� -   $��	txListBox��$��4��$��1��$��2��$��0,0,0,0q��� -   $��6��$��3��$��3��$	��125��$
��Left=�$��
175,10,0,6q�   HoverButton#��[  .��
Hex Send�� -   $��uartTxTextBox��$��5��$��1��$��3��$��3��$
��Left=�$��Center=� �� TextWrapping$
 Wrap=�$�� ��$	��480��$��0,10,0,6q��� $��3��$��35��$ 5q����#59C2C9$	��Top=�$��0,55,0,0q�$��2��$ 5,5,0,0��._��� $��Center=�$��Trebuchet MS)�
�������$��Center=�$
��Bold"�.��	UART Rx�� -   $��	rxListBox��$��3��$��2��$��0,0,0,0q�o� $��0��$��5��$��0,0,0,40q�
�������.@�m� $
��File��$��0��.@�m� -   $
��Open�� m� InputGestureText$ Ctrl+O��m� -   $
��Save��$ Ctrl+S��m� -   $
��Exit��$ Alt+F4��m� $
��Edit��$��1��.@�m� -	   $
��Back��$ Ctrl+B��m� -
   $��Clear Communication��$ Ctrl+W��m� $��Tools��$��2��.@�m� -   $��	Converter��$ Ctrl+T��m� $
��Help��$��3��.@�m� -   $��About��