   M S B A M L   `   `   `  ����J  FHandCricket 2.0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:HandCricket_2._0HandCricket_2._0  5   	   T PMahApps.Metro, Version=1.2.4.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5   	   !    HandCricket_2._0.MainWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:HandCricket_2._0     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	     � Title$%  HandCricket 2.0 - Input Details��5	   	    � WindowStartupLocation$ CenterScreen=�61    � 
ResizeMode$ CanMinimize=�6V   $��333.75��6o   $	��340��6      AccentColorBrush#���   5
   	   $��1q�5      .��5      � $��0q�6   .+�5   
   �� -   5         ��Name$ textBlock_Copy2��5      $
��Left=�6-   $��26��6H   $��	28,28,0,0q�6T   $
��Wrap=�6g   $��Number of Wickets:��6{   $	��Top=�6�   $	��132��6�   $��14(�6�   �� 5   
   -   5         ��Name$ proceed��5      $��Proceed��6#   $
��Left=�65   $��28��6P   $��194,254,0,0q�6\   $	��Top=�6q   $	��114��6�   6�   *  $MahApps.Metro.Controls.NumericUpDown  5   
   -   5        $��wickets��5   !      Minimum$ 1Q�60      Maximum$ 10Q�6<      Interval$ 1Q�6I      InterceptManualEnter .  $
��Left=�6s   $��22��6�   $��
176,28,0,0q�6�   $	��Top=�6�   $	��132��6�   	   TextAlignment$	 Center=�6�   $��13(�6�   �� 5   
   -   5        
 ��Name$
 	groupBox1��5      $��Choose your Option:��6&   $
��Left=�6C   $��88��6^   $��
28,141,0,0q�6j   $	��Top=�6~   $	��280��6�   .��5      � .+�5      	� -   5         	�Name$ fieldf��5      $��FIELD First��6.   $
��Left=�6D   $��22��6_   $��	10,10,0,0q�6k   $	��Top=�6~   $	��107��6�   	� 5      -   5        $
 batf��5      $��	BAT First��6,   $
��Left=�6@   $��22��6[   $��
170,10,0,0q�6g   $	��Top=�6{   $��88��6�   5      5      �� 5   
   -   5        $ textBlock_Copy��5      $
��Left=�6,   $��26��6G   $��	28,59,0,0q�6S   $
��Wrap=�6f   $��Select Your Team:��6z   $	��Top=�6�   $	��132��6�   $��14(�6�   �� 5   
   -   5        $ textBlock_Copy1��5      $
��Left=�6-   $��26��6H   $��	28,90,0,0q�6T   $
��Wrap=�6g   $��Select Rival Team:��6{   $	��Top=�6�   $	��132��6�   $��14(�6�   �� 5   
   -	   5         ��Name$ team1��5      $
��Left=�6"   $��26��6=   $��
176,59,0,0q�6I   $	��Top=�6]   $	��132��6u   .@�5      ��  �� 
IsSelected . .��6-   IND62   �� 5      .��6   ENG6    �� 5      .��6   AUS6    �� 5      .��6   SA6   5      �� 5   
   -
   5        $ team2��5      $
��Left=�6"   $��26��6=   $��
176,90,0,0q�6I   $	��Top=�6]   $	��132��6u   .@�5       �� .��6   IND6    �� 5!       . .��6-   ENG62   �� 5"      .��6   AUS6    �� 5#      .��6   SA6   5$      �� 5%   
   -   5        $ button��5%      $��?   |   About��6!   $
��Left=�69   $��28��6T   $��
28,254,0,0q�6`   $	��Top=�6t   $	��114��6�   6�   5'      5(      