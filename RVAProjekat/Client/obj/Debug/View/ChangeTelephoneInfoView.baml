   M S B A M L   `   `   `  ����A  =Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Client.ViewClient.View  5   	   )    #Client.View.ChangeTelephoneInfoView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Client.View     5   	     � Title$  ChangeTelephoneInfoView��5   	   $	��450��6)   $	��800��66    � 
ResizeMode$ NoResize=�6B    � WindowStartupLocation$ CenterScreen=�6X    � 	Resources 5	         TextBoxBaseControlTemplate �� 
TargetType ��Name �� CornerRadius ��Name �� Triggers	 P� Property
 P� Value �� Value �� 
TargetName �� Property��%�  &	        �� 5
   
   " ��6=   .R�5      �� $ Bd��5      #��z��5      ���	#FF252323#��z��5      $ 5��6E   ._�5      �� $ PART_ContentHost��6   5       5      P� 5      	 � {�
 .  . �5      �� # � ��63   $ Bd��6u    � ���� 5      # � ��63    � ��5      P� 5      	 � ��$

 Auto��6+   . �5      ��  � ��$	 100��61   5      P� 5      	 � ��$

 Auto��6,   . �5      ��  � ��$ 20��62   5      5      5      .��5       � ���	#FF373737.+�5!   
   �� $��View and change Telephone��6   $��Center=�64   $
��Left=�6X   $��66��6s   $��
186,10,0,0q�6   $	��Top=�6�   $	��419��6�   $��28(�6�   $��Segoe UI)�6�   ���	#FFFBFB9F6�   �� 5#   
   #��[  6   $
��Left=�6I   $��37��6d   $��
290,76,0,0q�6p    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��315��6�   ���	#FF2E2E2E���	#FFA7A9A8$��22(�66  ��6�   �� *CurrentTelephone.Name+ �� UpdateSourceTrigger$ PropertyChanged=�66  �� 5$   
   $
��Name��6   $
��Left=�6   $��37��6:   $��
164,76,0,0q�6F   $	��Top=�6Z   $	��126��6r   $��Segoe UI)�6~   ���	#FFFBFB9F$��22(�6�   �� 5%   
   $��Change��6   $
��Left=�6Q   $��61��6l   $��160,348,0,0q�6x   $	��Top=�6�   $	��445��6�   $��Segoe UI)�6�   ���	#FFFBFB9F
������ 
�������$��22(�6  ��6"   �� *ChangeThisTelephoneCommand+6  �� 5&   
   #��[  6   $
��Left=�6I   $��37��6d   $��290,118,0,0q�6p   $
 Wrap=�6�   $	��Top=�6�   $	��315��6�   ���	#FF2E2E2E���	#FFA7A9A8$��22(�68  ��6�   �� *CurrentTelephone.Price+$ PropertyChanged=�68  �� 5'   
   $��Price��6   $
��Left=�6    $��37��6;   $��164,118,0,0q�6G   $	��Top=�6\   $	��126��6t   $��Segoe UI)�6�   ���	#FFFBFB9F$��22(�6�   �� 5(   
   #��[  6   $
��Left=�6I   $��37��6d   $��290,160,0,0q�6p   $
 Wrap=�6�   $	��Top=�6�   $	��315��6�   ���	#FF2E2E2E���	#FFA7A9A8$��22(�67  ��6�   �� *CurrentTelephone.Year+$ PropertyChanged=�67  �� 5)   
   $
��Year��6   $
��Left=�6   $��37��6:   $��164,160,0,0q�6F   $	��Top=�6[   $	��126��6s   $��Segoe UI)�6   ���	#FFFBFB9F$��22(�6�   �� 5*   
   #��[  6   $
��Left=�6I   $��37��6d   $��290,202,0,0q�6p   $
 Wrap=�6�   $	��Top=�6�   $	��315��6  ���	#FF2E2E2E���	#FFA7A9A8$��22(�6>  ��6�   �� *CurrentTelephone.Description+$ PropertyChanged=�6>  �� 5+   
   $��Description��6   $
��Left=�6&   $��37��6A   $��164,202,0,0q�6M   $	��Top=�6b   $	��126��6z   $��Segoe UI)�6�   ���	#FFFBFB9F$��22(�6�   �� 5,   
   #��[  6   $
��Left=�6I   $��37��6d   $��290,244,0,0q�6p   $
 Wrap=�6�   $	��Top=�6�   $	��315��6  ���	#FF2E2E2E���	#FFA7A9A8$��22(�6;  ��6�   �� *CurrentTelephone.Diagonal+$ PropertyChanged=�6;  �� 5-   
   $��Diagonal��6   $
��Left=�6#   $��41��6>   $��164,244,0,0q�6J   $	��Top=�6_   $	��126��6w   $��Segoe UI)�6�   ���	#FFFBFB9F$��22(�6�   50      51      