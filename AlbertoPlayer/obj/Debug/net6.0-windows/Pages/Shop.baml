   M S B A M L   `   `   `  ����H  DAlbertoPlayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:AlbertoPlayer.pagesAlbertoPlayer.pages  5          AlbertoPlayer.pages.Shop   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:AlbertoPlayer.pages     5        N� Title$
  Shop��5	      .��5      � ���#181818 � RowDefinitions 5   
   �� 5      $	��30* �6   �� 5      $	��10* �6   �� 5      $	��60* �6    � ColumnDefinitions 5   
   �� 5      $	��33* �6   �� 5      $	��33* �6   �� 5      $	��33* �6   .+�5   
   �� -   5         ��Name$ imageCanvas��5      $��0��6&   $��0��63   $��3��6C   $
}�True��6W   .+�5      (�  � DataContext 6   ��  �� ElementName$ imageCanvas��.��5      �� .+�5      �� -   5         ��Name$ firstRectangle��5       $
��1920��68   $
��1080��6E   ��5       �� 5!       �� ImageSource$ /assets/Alberto1.png��6)    j� Stretch$
 None=�6L   	 j� 
AlignmentX$	 Center=�6[   
 j� 
AlignmentY$
 Center=�6o   z�5#      T� 5$       T� X$
 -350Q�61    T� Y$
 -300Q�6:   5'      �� 5(      $��Alberto��6    
���   �$��Center=�6B   $	��Top=�6_   5)      5*      (� 5-      .��5.      �� .+�5/      �� -   5         ��Name$ newImage��5/      $��/assets/Belmondo.jpg��6.   $
��1280��6L   $	��600��6Y   $y�Hidden=�6f   $��UniformToFill=�50   E    � Triggers 51      :� 52       :� RoutedEvent$ Image.Loaded��6+   .[�53   "   �� .��54   &   �� .��55   *   W�  �� 
TargetName$ newImage��56   %    �� TargetProperty$ Opacity�57   %    W� From 058   %   	 W� To 16.    g� Duration$ 0:0:1D�65   W� 59   *   $ newImage��5:   %   $8 2(UIElement.RenderTransform).(TranslateTransform.X)�5;   %    05<   %    06.   $ 0:0:1D�65   W� 5=   *   $ newImage��5>   %   $8 2(UIElement.RenderTransform).(TranslateTransform.Y)�5?   %    05@   %    -1006.   $ 0:0:1D�68   5A   '   5B   #   5C      z�5E      T� 5F      $ 0Q�61   $ 0Q�67   5H      �� 5I      $��Belmondo��6    
�������$��Center=�6C   $	��Top=�6`    J� Opacity$ 0Q�6x   ��5J      �� 5K       �� 
TargetType" ��6$    �� Triggers 5L   "   �� 5M   &    �� Binding 62   �� $ newImage�� �� Path$ 
Visibility� �� Value Visible6l   .a�5N   *   ��  �� Property �@J�Opacity �� Value$ 1Q�6D   5O   '   �� 5P   &    62   �� $ newImage��$ 
Visibility�
 Hidden6l   .a�5Q   *   ��  �@J�Opacity$ 0Q�6D   5R   '   5T      5V      5W      5X      5Y      �� 5_   
   $��1��6   $��0��5`      $��3��5a      ���#1115b      �� 5d   
   -   5         ��Name$ SearchTermTextBox��5f      $��1��5d      $��0��5e      $��24(�5g       �� TextAlignment$
 left=�5h      $��center=�5i      $��15q�5j      �� 5k   
   $��1��6   $��0��5l       J� IsHitTestVisible$ False��5m      $��Co chcesz kupić?��5n      $��20(�5o      $��Center=�5p      $
��Left=�5q      $��20,0,0,0q�5r      
���������5t      �� 5u      " ��6   .�5v      ��  � y�$ 	Collapsed=�63    5w      �� 5x       6&   �� *Text+$ SearchTermTextBox��  6^   .a�5y      ��  � y�$ Visible=�6;   5z      5|      5~      �� 5�   
   -   5        $��1��5�      $��1��5�        �� SelectedValue  5�      �� *SelectedSort+! �� Mode$! TwoWay=���5�      �� *sort+6(   �� 5�   
   $��1��6   $��2��5�      $��koszyk��5�      ���#fff5�      5�      5�      