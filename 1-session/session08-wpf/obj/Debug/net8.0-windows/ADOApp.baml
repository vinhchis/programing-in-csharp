   M S B A M L   `   `   `  ����H  Dsession08_wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:session08_wpfsession08_wpf  5   	       session08_wpf.ADOApp   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:session08_wpf     5   	     � Title$  ADOApp��5   	   $	��450��6   $	��800��6%   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��9* �6   �� 5      $
��151* �6   .+�5   
   �� $��Item Management System��6   $
��Left=�61   $��
116,65,0,0q�6L   $	��Top=�6`   $��48(�6x   $
��Bold"�6�   ���	#FF6B2F56$��1��6�   $��74��6�   $	��601��6�   ��6�   Z� 6�   �� 5   
   $��Code:��6   $��42,182,641,226q�6    $��1��68   �� 5   
   $��Name:��6   $��32,246,641,162q�6    $��1��68   �� 5   
   $��Price:��6   $��32,309,641,99q�6!   $��1��68   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgItem��5      $��325,199,0,107q�6N      AutoGenerateColumns$ False��6e   $��1��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Code��6?      Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 6M   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *ICode+6M     5      $
 Name��6B   $	 100 6P    6%   �� *
ItemName+6P     5      $ Price��6>   $	 100 6M    6%   �� *Rate+6M   5      �� 5   
   -   5         ��Name$ txtCode��5      $
��Left=�6#   $��114,201,0,0q�6>   	 �� TextWrapping$
	 Wrap=�6S   $	��Top=�6h   $	��120��6�   $��1��6�   $��18��6�   �� 5   
   -   5        $ txtName��5      $
��Left=�6#   $��138,259,0,0q�6>   $
	 Wrap=�6S   $	��Top=�6g   $	��120��6   $��1��6�   $��18��6�   �� 5   
   -   5        $ txtPrice��5      $
��Left=�6$   $��138,322,0,0q�6?   $
	 Wrap=�6T   $	��Top=�6h   $	��120��6�   $��1��6�   $��18��6�   �� 5   
   -   5        
 ��Name$
 	btnInsert��5   "   $��Insert��6   $
��Left=�65   $��448,359,0,0q�6P   $	��Top=�6f   $��1��6~   6�   �� 5   
   -   5        $
 	btnUpdate��5   "   $��Update��6   $
��Left=�65   $��153,368,0,0q�6P   $	��Top=�6e   $��1��6}   $��20��6�   $��42��6�   �� 5   
   -   5        $
 	btnDelete��5   "   $��Delete��6   $
��Left=�65   $��252,364,0,0q�6P   $	��Top=�6e   $��1��6}   $��20��6�   $��38��6�   5"      5#      