   M S B A M L   `   `   `  ����   PongProject    PongProject.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -     �Name$
  main��
���   �$
��1000��$	��800�� � Title$ 	Ping-Pong�� � WindowState$ 	Maximized=� � 
ResizeMode$ NoResize=� � Icon$ Resources/Pong_Logo.png�� � WindowStyle$
 None=�.��]� -   $
��dock��$��Stretch=�$��Stretch=�.+�� -   $��
grid_title��$��Stretch=�$��Stretch=� � RowDefinitions �� $	��40* ��� $
��187* �.+��� -    ��Name$ bt_close��$��X��$��Center=�$��Center=�$��20��$��0��$��20�����	#FFFFFBFB
���   �
�������$��1170,10,10,111q��� -   $ bt_minimize��$��_��$��Center=�$��Center=�$��20��$��0��$��20�����	#FFFFFBFB
���   �
�������$��1145,10,35,111q�� -   $��grid_MainWindow��$��2��$��1��$��Stretch=�$��Stretch=� �� $��1* ��� $��1* � � ColumnDefinitions �� $��1* ��� $��1* ��� $��1* �.+��� -   $ bt_login��$��Login��$��1��$��Center=�$��Center=�$	��100��$��24�����	#FFFFFBFB
���   �
�������$��117,110,117,114q��� -   $ 
bt_offline��$��Offline��$��1��$��Center=�$��Center=�$	��100��$��1��$��26��
�������
�������
���   �$��117,10,117,213q�