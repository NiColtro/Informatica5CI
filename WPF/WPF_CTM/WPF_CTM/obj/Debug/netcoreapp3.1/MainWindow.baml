   M S B A M L   `   `   `  ����B  >WPF_CTM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WPF_CTMWPF_CTM  5   	       WPF_CTM.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WPF_CTM     5   	     � Title$  Catch the Minion!��5   	   $	��900��6#   $	��800��60    � 	Resources 5
         NoMouseOverButtonTemplate �� 
TargetType �� Triggers P� Property P� Value �� Value �� Property��%2  &	        �� 5   
   " ��5      .R�5      �� #��z��6   #��z��5      #��z��5      ._�5      �� #��z��6#   #��z��5      5       5      P� 5       � {�$ False��5      . �5      �� # Z�5       � ���� 5      # Z�5       � ��5      5      5      .��5!      � -   5        $��mainGrid��5!       � ColumnDefinitions 5"   
   �� 5#      $��1* �6   6,   �� 5$      $��1* �6   6,   	 � RowDefinitions	 5'   
   �� 5)      $��50 �6   6*   �� 5+      $��50 �6   6*   �� 5-      $��* �6   6)   .+�50   
   �� $��Catch the Minion!��6   $��2��51      $��Stretch=�52      $��Center=�6.   $��30(�53      
����������#f7af7c$��0��54      $��0��6    6/   �� 56   
   -   5        $��Points��56      $��Punti: 0��6   $��Stretch=�57      $��Center=�6.   $��30(�58      
����������#f79b59$��1��59      $��0��6   �� 5<   
   -   5        $��Clicks��5<      $��	Clicks: 0��6   $��Stretch=�5=      $��Center=�6.   $��30(�5>      
����������#f79b59$��1��5?      $��1��6   � 5C   
   -   5        $��gameGrid��5C   0   $��2��6   $��2��6    5D      �� 5E      $��1* �6#   60   �� 5F      $��1* �6#   60   �� 5G      $��1* �6#   60   	 5J      �� 5K      $��1* �6    6.   �� 5L      $��1* �6    6.   �� 5M      $��1* �6    6.   5O      �� 5R   
   -   5        $��WinMsg��5R      $��
HAI VINTO!��6   ���#5fd972
�������$��Stretch=�5S      $��Center=�62   $��Stretch=�5T      $��Center=�60   $��80(�5U      $��0��5V      $��2��6$   $��3��5W      $��3��6(   $y�Hidden=�5X      5[      5\      