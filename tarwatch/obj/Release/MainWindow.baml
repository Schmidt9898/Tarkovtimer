   M S B A M L   `   `   `  ���� C  ?tarwatch, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:tarwatchtarwatch      tarwatch.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     (localclr-namespace:tarwatch     -     � Title$  
TarkovTime��$	��120��$	��300�� � AllowsTransparency . 
���   � � WindowStyle$
 None=� � Icon$ exit.bmp�� � 
ResizeMode$ CanResizeWithGrip=�$	��250��$��50�� � 	Resources    zold �� ImageSource j� Stretch  	reseticon  FocusVisual �� Property	 �� Value
 J� SnapsToDevicePixels �� StrokeDashArray  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border 	 Button.Disabled.Background 
 Button.Disabled.Border  Button.Disabled.Foreground  ButtonStyle1 �� 
TargetType �� 
TargetType ��Name ��Name �� Triggers P� Property P� Value �� 
TargetName  ButtonStyle2��%�  &	        &	 $     &	 E     &	 �     &	 �     &	 �     &	 �     &	 �     &	 �     &		     &	
 &    &	 ;    &	 P    7  7  7  7   7  7  7  7 	 7 
 7  &	 '    7  7  7  7  7  7 	 7 
 7  �� $ 
/exit2.bmp��$ Uniform=��� $ 
/reset.png��$
 Fill=��� .���  � ��	 �� .R��� $��2q�
 . #��� ��$��1��$	 1 2R��� $ 	#FFDDDDDD���� $ 	#FF707070���� $ 	#FFBEE6FD���� $ 	#FF3C7FB1���� $ 	#FFC4E5F6���� $ 	#FF2C628B���� $ 	#FFF4F4F4���� $ 	#FFADB2B5���� $ 	#FF838383���� " ��.���  �@�FocusVisualStyle8	   ��  � ��8	  ��  � ��8	  ��  � ��#	 � ����  � ��$	 1q���  � ��$	 Center=���  � ��$	 Center=���  � ��$	 1q���  � ��	 �� " ��.R��� $ border��#��z��#��z��#��z��
 . ._��� $ contentPresenter��|�.  #��z��#��z����. #
 z
 #��z�� P�  �@��IsDefaulted . . ��� $ border��#	 � �� � ��P�  �@J�IsMouseOver . . ��� $ border��8	   � ���� $ border��8	   � ��P�  � �� . . ��� $ border��8	   � ���� $ border��8	   � ��P�  � {� .  . ��� $ border��8	   � ���� $ border��8	   � ���� $ contentPresenter��8	 	  � ���� " ��.���  �@�FocusVisualStyle8	   ��  � ��	 Z� ��  � ��	 Z� ��  � ��#	 � ����  � ��$	 1q���  � ��$	 Center=���  � ��$	 Center=���  � ��$	 1q���  � ��	 �� " ��.R��� $ border��#��z��#��z��#��z��
 . ._��� $ contentPresenter��|�.  #��z��#��z����. #
 z
 #��z�� P�  �@��IsDefaulted . . ��� $ border��#	 � �� � ��P�  �@J�IsMouseOver . . ��� $ border��8	   � ���� $ border��8	   � ��P�  � �� . . ��� $ border��8	   � ���� $ border��8	   � ��P�  � {� .  . ��� $ border��8	   � ���� $ border��8	   � ���� $ contentPresenter��8	   � ��.��� ���� $ back.jpg��$ UniformToFill=� �� RelativeTransform V� .~���  �� CenterY$	 0.5Q� �� CenterX$	 0.5Q���  �� CenterY$	 0.5Q� �� CenterX$	 0.5Q���  �� CenterY$	 0.5Q� �� CenterX$	 0.5Q�T� .+��� -    ��Name$ resetbtn��$	��125��$��40��$
��Left=�$	��Top=�#���  ���� ]� $	��120����.  $	��Top=�.+��� .+��� -    ��Name$ lblrealtime��$��	RealTime:�� J� IsHitTestVisible .  $	��Top=�$��25(�
�������$��Arial)��� -   $ Realtimetext�� .  $��00:00:00��$	��Top=�$��25(�$��Arial)�
�������$��Center=��� -    ��Name$ Tarkovpanel��$��Right=�.+��� -   $ lblTarkotime��$��TarkovTime:��$	��Top=�$��25(�
�������$��Arial)�� .+���   �� Orientation$  
Horizontal=�.+��� -   ! ��Name$
! hour��$��55��|�. ���� $ 	#FFFF0005������ " ��.���  �@J�Opacity$	 0Q�" �� Triggers" P�  �@J�IsMouseOver . . ���  �@J�Opacity$	 50Q��� -   $! minute��$��35��|�. ���� $ 	#FFFF0005������ " ��.���  �@J�Opacity$	 0Q�" P�  �@J�IsMouseOver . . ���  �@J�Opacity$	 50Q��� -	   $! secound��$��50��|�. ���� $ 	#FFFF0005������ " ��.���  �@J�Opacity$	 0Q�" P�  �@J�IsMouseOver . . ���  �@J�Opacity$	 50Q��� -
   $ Tarkovtimetext�� .  $��00:00:00��$��Center=�$	��Top=�$��25(�$��Right=�
�������$��Arial)�
���   ��� -   $ Tarkovtime12text��$��00:00:00��$��Center=�$	��Top=�$��25(�$��Right=�
�������$��Arial)�
���   ����	#00000000�� -   $
 Exit��$��40��$��40��$��0,0,1,1q�#���  $��Bottom=�$
��Left=����� $ exit.bmp��$ Uniform=�