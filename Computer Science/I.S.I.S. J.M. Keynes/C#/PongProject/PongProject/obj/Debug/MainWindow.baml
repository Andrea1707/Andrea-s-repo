   M S B A M L   `   `   `  ����  PongProject    PongProject.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -   5          �Name$
  main��5   	   
���   �$
��1000��5   -   $	��800��6:    � Title$ 	Ping-Pong��5   	    � WindowState$ 	Maximized=�6    � 
ResizeMode$ NoResize=�63    � Icon$ Resources/Pong_Logo.png��6I    � WindowStyle$
 None=�6h   .��5      ]� -   5        $
��dock��5   J   $��Stretch=�6   $��Stretch=�6,   .+�5   
   � -   5        $��
grid_title��5      $��Stretch=�6!   $��Stretch=�6=    � RowDefinitions 5      �� 5      $	��40* �6    �� 5      $
��187* �6    .+�5      �� -   5         ��Name$ bt_close��5      $��X��6'   $��Center=�63   $��Center=�6Q   $��20��6l   $��0��6w   $��20��6�   ���	#FFFFFBFB
���   �
�������$��1170,10,10,111q�6�   6�   �� 5      -   5        $ bt_minimize��5      $��_��6*   $��Center=�66   $��Center=�6T   $��20��6o   $��0��6z   $��20��6�   ���	#FFFFFBFB
���   �
�������$��1145,10,35,111q�6�   6�   � 5      -   5        $��grid_MainWindow��5      $��2��6J   $��1��6[   $��Stretch=�6h   $��Stretch=�6�    5      �� 5      $��1* �6$   �� 5      $��1* �6$    � ColumnDefinitions 5      �� 5       $��1* �6'   �� 5!      $��1* �6'   �� 5"      $��1* �6'   .+�5&      �� -   5        $ bt_login��5&      $��Login��6+   $��1��6;   $��Center=�6K   $��Center=�6i   $	��334��6�   $��94��6�   
���   �
�������$��
0,151,0,85q�6�   $��Showcard Gothic)�6�   $��72(�6
  $��0q�6  	 J� RenderTransformOrigin$	 0.5,0.5&�6,  
 � Cursor$

 Hand��6m  |�.  ��6{  Z� 6�  �� 5'      -   5        $ 
bt_offline��5'      $��Offline��6-   $��1��6?   $��Center=�6O   $��Center=�6l   $	��334��6�   $��1��6�   $��96��6�   
�������
�������
���   �$��
0,40,0,193q�6�   $��0q�6  $��72(�6'  $��Showcard Gothic)�65  $

 Hand��6R  5+      5,      5-      5.      