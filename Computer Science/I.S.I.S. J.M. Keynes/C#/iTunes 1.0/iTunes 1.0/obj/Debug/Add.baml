   M S B A M L   `   `   `  ����E  AiTunes 1.0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:iTunes_1._0iTunes_1._0  5          iTunes_1._0.Add   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:iTunes_1._0     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6    � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   .+�5   
   �� -   5        $��	bt_img_up��5      $��Upload��6"   $��Center=�63   $��Center=�6N   $��75��6k   $��1��6v   6�   �� 5   
   $��0��6   $��Image��6    $��Center=�60   $��Center=�6M   �� 5   
   $��0��6   $��Artist��6    $��Center=�61   $��Center=�6N   $��1��6i   �� 5   
   $��0��6   $��Title��6!   $��Center=�61   $��Center=�6N   $��2��6i   �� 5   
   $��0��6   $��Genere��6    $��Center=�61   $��Center=�6N   $��3��6i   �� 5    
   $��
File audio��6   $��Center=�6%   $��Center=�6B   $��4��6]   �� 5!   
   -   5        $��bt_file_add��5!      $��Upload��6$   $��1��65   $��Center=�6E   $��Center=�6b   $��4��6}   $��75��6�   6�   �� 5&   
   -   5        $��lb_image_path��5&      $
��Path��6%   $��2��64   $��Center=�6D   $��Center=�6b   �� 5'   
   -   5        $��lb_file_path��5'      $
��Path��6$   $��4��63   $��2��6@   $��Center=�6P   $��Center=�6n   �� 5(   
   -   5        $��	tb_artist��5(      $��1��6#   $��Center=�63   $��22��6P   $��1��6\    �� TextWrapping$
 Wrap=�6i   $��TextBox��6}   $��Center=�6�   $	��120��6�   �� 5)   
   -   5        $��tb_title��5)      $��1��6"   $��Center=�62   $��22��6O   $��2��6[   $
 Wrap=�6h   $��TextBox��6|   $��Center=�6�   $	��120��6�   �� 5*   
   -   5        $��	tb_genere��5*      $��1��6#   $��Center=�63   $��22��6P   $��3��6\   $
 Wrap=�6i   $��TextBox��6}   $��Center=�6�   $	��120��6�   �� 5-   
   -   5        $��bt_add��5-      $��Add song��6   $��2��62   $��5��6B   $��Center=�6O   $��Center=�6j   6�   52      53      