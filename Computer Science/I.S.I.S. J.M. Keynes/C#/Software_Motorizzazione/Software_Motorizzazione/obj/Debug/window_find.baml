   M S B A M L   `   `   `  ����R  NSoftware_Motorizzazione, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Software_MotorizzazioneSoftware_Motorizzazione  5   	   )    #Software_Motorizzazione.window_find   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:Software_Motorizzazione     5   	   -   5          � Title$  window_find��5   	   $	��450��6   $	��800��6*   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��0.3* �6   �� 5      $
��0.2* �6   �� 5      $
��0.2* �6   �� 5      $��1* �6    � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   .+�5   
   �� $��Search��6   $��1��6!   $��0��61   $��Center=�6>   $��Center=�6Y   &   System.Windows.Controls.DataGrid  5   
   -   5        $��datagrid��5      $��0��6#   $��3��63   $��3��6@   $��Center=�6U   $��Center=�6p   $	��212��6�   $	��700��6�   $��46,10,46,24q�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Targa:��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 1* 65   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6@   �� *targa+  5      $ Marca:��6%   $ 1* 65    6@   �� *marca+  5      $ Modello:��6%   $ 1* 67    6B   �� *	modello+  5      $ Colore:��6%   $ 1* 66    6A   �� *colore+  5       $ Nominativo:��6%   $ 1* 6:    6E   �� *
nominativo+5"      	� 5#   
   -   5        $��rd_nominativo��5#   <   $��
Nominativo��6    d� 	IsChecked$
 TrueY�6+   $��1��6Q   $��Center=�6a   $��1��6   $��Center=�6�    J� RenderTransformOrigin$ -0.245,0.418&�6�   $��74,28,110,8q�6�   	� 5$   
   -   5        $��rd_targa��5$   &   $��Targa��6   $��1��66   $��Center=�6F   $��1��6c   $��Center=�6p   $ 1.574,0.498&�6�   $��160,28,58,8q�6�   �� 5%   
   -   5        $��	tb_search��5%   "   $��1��6   $
��Left=�63   $��23��6N   $��	74,16,0,0q�6Z   $��2��6m   	 �� TextWrapping$
	 Wrap=�6z   $�� ��6�   $	��Top=�6�   $	��132��6�   6�   �� 5&   
   $��Type:��6   $��1��6    $
��Left=�60   $��	116,2,0,0q�6K   $��1��6^   $	��Top=�6k   5(      5)      