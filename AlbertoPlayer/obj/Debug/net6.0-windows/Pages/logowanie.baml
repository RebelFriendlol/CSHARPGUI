   M S B A M L   `   `   `  ����H  DAlbertoPlayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:AlbertoPlayer.pagesAlbertoPlayer.pages  5      #    AlbertoPlayer.pages.logowanie   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:AlbertoPlayer.pages     5        N� Title$  	logowanie��5	       � 	Resources 5
         FocusVisual �� Property �� Value �� StrokeDashArray J� SnapsToDevicePixels  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 RoundedButtonStyle �� 
TargetType �� 
TargetType	 ��Name
 �� CornerRadius ��Name �� Triggers P� Property P� Value �� 
TargetName��%�  &	        &	 �     &	 �     &	 �     &	     &	 ?    &	 b    &	 �    &	 �    &		 �    &	
 �    7   7  7  7  7  7 	 �� 5   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$   $	 1 2R�6/   #��� ��6E   $
 true��6�   $��1��6�   5      5      5      �� 5   
   $ 	#FFDDDDDD��6;   �� 5   
   $ 	#FF707070��67   �� 5   
   $ 	#FFBEE6FD��6>   �� 5   
   $ 	#FF3C7FB1��6:   �� 5   
   $ 	#FFC4E5F6��6<   �� 5   
   $ 	#FF2C628B��68   �� 5   
   $ 	#FFF4F4F4��6=   �� 5   
   $ 	#FFADB2B5��69   �� 5   
   $ 	#FF838383��6=   �� 5   
   " ��6+   .�5      ��  �@�FocusVisualStyle8   61   �� 5       � ��8  6+   �� 5        � ��8  6,   �� 5!       � ��# � ��6+   �� 5"       � ��$ 0q�60   �� 5#       � ��$ Center=�6;   �� 5$       � ��$ Center=�69   �� 5%       � ��$ 1q�6(   �� 5&       � �� 5'      �� 5(      " ��6&   .R�5)      �� $	 border��6!   $
 5��61   #��z��6B   #��z��6l   #��z��6�   $
 true��6�   ._�5*      �� $ contentPresenter��6/   $|�False��6I   #��z��6[   #��z��6�   $
��True��6�   # z 6�   #��z��6  5+       5,      P� 5-       �@��IsDefaulted$
 true��6=   . �5.   "   �� $ border��6@   # � ��6T    � ��5/      P� 50       �@J�IsMouseOver$
 true��6=   . �51   "   �� $ border��6?    � �� �#EAB01E6S   �� 52   "   $ border��6@    � �� �#EAB01E6T   53      P� 54       � ��$
 true��6;   . �55   "   �� $ border��6?    � �� �#F1CA686S   �� 56   "   $ border��6@    � �� �#F1CA686T   57      P� 58       � {�$ false��6;   . �59   "   �� $ border��6?   8   � ��6S   �� 5:   "   $ border��6@   8   � ��6T   �� 5;   "   $ contentPresenter��6K   8   � ��6i   5<      5>      5@      5A      5B      .��5D      � ���#181818 � RowDefinitions 5E   
   �� 5F      $	��20* �6   �� 5G      $	��10* �6   �� 5H      $	��40* �6   �� 5I      $	��30* �6    � ColumnDefinitions 5K   
   �� 5L      $	��33* �6   �� 5M      $	��33* �6   �� 5N      $	��33* �6   .+�5T   
   �� $��3��6   ���#111111
���<��$��
0, 0, 0, 2q�5W      ._�5X      �� $��0��6   $��3��5Y      5Z      5[      �� 5\   
   $��0��6   $��3��5]      $��
Logowanie ��5^      
�������$��64(�5`      $��SemiBold"�5a      $��Center=�5b      $	��top=�5c      �� 5h   
   $��2��6   $��1��5i      ���#D2042D �� RadiusX$ 10��5k       �� RadiusY$ 10��5l      �� 5m   
   $��2��6   $��1��5n      .+�5o      �� $��Podaj login: ��6    �� TextAlignment$ center=�5p      $��0, 20, 130, 5q�5q      $��13(�5r      $��DemiBold"�5s      �� 5t      $��25��6   $	��200��5u      $��0, 0, 0, 10q�5v      $��Center=�5w      �� 5x      $��Podaj hasło: ��6   $ center=�5y      $��0, 0, 130, 5q�5z      $��13(�5{      $��DemiBold"�5|      G� 5}      $��25��6   $	��200��5~      $��0, 0, 0, 10q�5      $��Center=�5�      �� 5�      $��Nie posiadasz konta?��6   $ Center=�5�      $��	65,0,0,15q�5�      �� 5�      #��� 
 6   $��70��6B   $��30��6M   $��Zaloguj się��5�      $��130, 0, 0, 0q�5�      
�������
���   �$��DemiBold"�5�      $	��0.5q�5�      
���   � � Cursor$
 Hand��5�      5�      5�      5�      