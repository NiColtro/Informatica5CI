   M S B A M L   `   `   `  ����K  GWPF_MixIsDown_V2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:WPF_MixIsDown_V2WPF_MixIsDown_V2  5   	   !    WPF_MixIsDown_V2.MainWindow   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:WPF_MixIsDown_V2     5   	     � Title$  
MainWindow��5   	   $	��553��6   $	��843��6)   .��5	      �  � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   �� 5      $��2* �6   6,   .+�5   
   �� $��Cognome��6   $	��100��6"   $��30��6.   $��0��6:   $��56,23,44,381q�6J   6b   �� 5   
   -   5         ��Name$ 
TB_Cognome��5      $	��100��6&   $��30��62   $��0��6>   $��56,53,44,351q�6N   6f   �� 5   
   $
��Nome��6   $	��100��6   $��30��6+   $��0��67   $��56,93,44,311q�6G   6_   �� 5   
   -   5        $ TB_Nome��5      $	��100��6#   $��30��6/   $��0��6;   $��56,123,44,281q�6K   6d   �� 5   
   $
��Foto��6   $	��180��6!   $	��200��6-   $��10,188,10,46q�6:   .��5      �� -   5         ��Name$ IMG_Foto��5      $	��150��6&   $	��200��62   6A   5      �� 5   
   -   5         ��Name$ PB_CaricaImg��5      $��Carica Immagine��6'   $	��100��6A   $��30��6M   $��0��6Y   $��50,358,50,46q�6�   �� 5   
   -   5        $��
PB_SelVoce��5      $��Selezione file Voce��6#   $	��100��6A   $��30��6M   $��0��6Y   $��50,388,50,16q�6�   �� 5   
   -   5        $��PB_Aggiungi��5   !   $��1��6   $��Aggiungi��6N   $	��100��6a   $��30��6m   6{   �� 5    
   -   5         ��Name$ 
LV_Persona��5       $��2��6'   $
��Left=�67   $	��Top=�6R    �� View 5!      �� 5"      P�5#      �� 5$      $��Cognome��6)    �� Width$	 100��6:    �� DisplayMemberBinding 6F   �� 	 �� Path$	 Cognome�6v   �� 5%      $
��Nome��6)   $	 100��67    6C   �� $
	 Nome�6p   �� 5&      $
��Foto��6)   $	 200��67   
 �� CellTemplate
 5'      �� 5(   "   .R�5)   &   �� $	��200��6,   ��68   �� $
	 Foto�6W   5*   #   5,      5.      50      51      52      