   M S B A M L   `   `   `  ����  UART_Monitor    Wpf_UART.Home   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5        N� ShowsNavigationUI  .  $	��400��5      $	��700��6    N� Title$
 Home��5	      .��5      � -   5        $��
10,0,10,10q�5       � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5      $	��300 �6   �� 5      $	��200 �6    � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      $��35 �6   �� 5      $	��205 �6   �� 5      $��40 �6   �� 5      $��20 �6   .+�5   
   �� $��1��6   $��Center=�6    $��Center=�6=   $��Trebuchet MS)�6X   $
��Bold"�6r   $��26(�6�   ���#000000$��UART Monitor��6�   $��40��6�   $	��176��6�   �� 5   
   $��1��6   $��1��6!    �� Padding$ 5q�6.   ���#59C2C9 �� CornerRadius$ 5,5,0,0��6O   $��36��6f   $��Center=�6r   ._�5      �� $��Center=�6   
�������$��Trebuchet MS)�6D   $��16(�6^   $��	0,-2,0,-3q�6l   $
��Bold"�6   .��6�   Ports6�   5      �� 5   
   -   5        $��portsListBox��5   C   $��1��6W   $��2��6g   $��0,0,0,1q�6t   �� 5"   
   -   5        $��	btnSelect��5"      $��1��6"   $��3��62   $��0,12,0,2q�6?   $	��125��6Q   $
��Left=�6]   {�.     HoverButton#��[  6�   .��6�   Select6�   �� 5#   
   -   5        $��baudsComboBox��5#      $��1��6(   $��3��68   $��0,12,0,2q�6E   $	��125��6W   $��Right=�6c   .@�5$      ��  �� 
IsSelected . .��6-   960063   �� 5%      .��6   576006"   �� 5&      .��6   1152006#   5'      �� 5(   
   -   5        $��2��5(      $�� ��6!   $
��Left=�6,   $��74��6G   $��	65,46,0,0q�6S   $��2��6f   $	��Top=�6s   $��39��6�     NoHoverButton#��[ 6�   �� 5)   
   -   5        $��Refresh��5)      $
��Left=�6#   $��26��6>   $��Center=�6J   $��52��6e   $��5,0,0,0q�6p     RefreshButton#��[ 6�   $��Trebuchet MS)�6�   $��1��6�   $��1��6�   ��5+   
   �� 5,       �� ImageSource$ .\Media\Images\laptop.png��6   5/      50      