   M S B A M L   `   `   `  ����A  =Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Client.ViewClient.View  5   	   %    Client.View.AddNewTelephoneView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Client.View     5   	     � Title$  AddNewTelephoneView��5   	   $	��450��6%   $	��800��62    � 
ResizeMode$ NoResize=�6>    � WindowStartupLocation$ CenterScreen=�6T    � 	Resources 5	         TextBoxBaseControlTemplate �� 
TargetType ��Name �� CornerRadius ��Name �� Triggers	 P� Property
 P� Value �� Value �� 
TargetName �� Property��%�  &	        �� 5
   
   " ��6=   .R�5      �� $ Bd��5      #��z��5      ���	#FF252323#��z��5      $ 5��6E   ._�5      �� $ PART_ContentHost��6   5       5      P� 5      	 � {�
 .  . �5      �� # � ��63   $ Bd��6u    � ���� 5      # � ��63    � ��5      P� 5      	 � ��$

 Auto��6+   . �5      ��  � ��$	 100��61   5      P� 5      	 � ��$

 Auto��6,   . �5      ��  � ��$ 20��62   5      5      5      .��5       � ���	#FF373737 � ColumnDefinitions 5!   
   �� 5"      $
��331* �6   �� 5#      $
��461* �6   .+�5%   
   �� $��New Telephone��6   $��Center=�6(   $��Center=�6L   $��66��6i   $��
10,10,10,0q�6u   $	��Top=�6�   $	��772��6�   $��34(�6�   $��Segoe UI)�6�   ���	#FFFBFB9F$��2��6�   �� 5'   
   #��[  6   $
��Left=�6I   $
��Left=�6d   $��Center=�6�   $��49��6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6  $	��285��6(  $��
265,81,0,0q�64  ���	#FF2E2E2E���	#FFA7A9A8$��22(�6v  $��2��6�  ��6�   �� *NewTelephone.Name+ �� UpdateSourceTrigger$ PropertyChanged=�6�  �� 5(   
   $
��Name��6   $
��Left=�6    $��49��6;   $��
106,81,0,0q�6G   $	��Top=�6[   $	��154��6s   $��Segoe UI)�6   ���	#FFFBFB9F$��27(�6�   �� 5)   
   $	��Add��6   
������ $��Segoe UI)�6d   ���	#FFFBFB9F$
��Left=�6�   $	��Top=�6�   $	��158��6�   $��292.873,364,0,0q�6�   $��45��6�   
�������$��22(�6	  $��1��6  ��6   �� *AddThisTelephoneCommand+6  �� 5*   
   #��[  6   $
��Left=�6I   $
��Left=�6d   $��Center=�6�   $��49��6�   $
 Wrap=�6�   $	��Top=�6  $	��285��6(  $��265,135,0,0q�64  ���	#FF2E2E2E���	#FFA7A9A8$��22(�6w  $��2��6�  ��6�   �� *NewTelephone.Year+$ PropertyChanged=�6�  �� 5+   
   $
��Year��6   $
��Left=�6    $��49��6;   $��106,135,0,0q�6G   $	��Top=�6\   $	��154��6t   $��Segoe UI)�6�   ���	#FFFBFB9F$��27(�6�   �� 5,   
   #��[  6   $
��Left=�6I   $
��Left=�6d   $��Center=�6�   $��49��6�   $
 Wrap=�6�   $	��Top=�6  $	��285��6)  $��265,189,0,0q�65  ���	#FF2E2E2E���	#FFA7A9A8$��22(�6x  $��2��6�  ��6�   �� *NewTelephone.Price+$ PropertyChanged=�6�  �� 5-   
   $��Price��6   $
��Left=�6!   $��49��6<   $��106,189,0,0q�6H   $	��Top=�6]   $	��154��6u   $��Segoe UI)�6�   ���	#FFFBFB9F$��27(�6�   �� 5.   
   #��[  6   $
��Left=�6I   $
��Left=�6d   $��Center=�6�   $��49��6�   $
 Wrap=�6�   $	��Top=�6  $	��285��6/  $��265,243,0,0q�6;  ���	#FF2E2E2E���	#FFA7A9A8$��22(�6~  $��2��6�  ��6�   �� *NewTelephone.Description+$ PropertyChanged=�6�  �� 5/   
   $��Description��6   $
��Left=�6'   $��49��6B   $��106,243,0,0q�6N   $	��Top=�6c   $	��154��6{   $��Segoe UI)�6�   ���	#FFFBFB9F$��27(�6�   �� 50   
   #��[  6   $
��Left=�6I   $
��Left=�6d   $��Center=�6�   $��49��6�   $
 Wrap=�6�   $	��Top=�6  $	��285��6,  $��265,297,0,0q�68  ���	#FF2E2E2E���	#FFA7A9A8$��22(�6{  $��2��6�  ��6�   �� *NewTelephone.Diagonal+$ PropertyChanged=�6�  �� 51   
   $��Diagonal��6   $
��Left=�6$   $��49��6?   $��106,297,0,0q�6K   $	��Top=�6`   $	��154��6x   $��Segoe UI)�6�   ���	#FFFBFB9F$��27(�6�   �� 52   
   $��	Shop Name��6   $
��Left=�6%   $��49��6@   $��106,357,0,0q�6L   $	��Top=�6a   $	��154��6y   $��Segoe UI)�6�   ���	#FFFBFB9F$��27(�6�   �� 53   
    �� DisplayMemberPath$
 Name��56      $��265,364,0,0q�6,   $	��Top=�6A   $
��Left=�6Y   $	��285��6t   $��2��6�   $��28��6�   ��53      ��  �� Path$ Shops� �� SelectedItem 54      �� $ SShop� �� Text 55      �� *NewTelephone.ShopName+$ PropertyChanged=�56   �   58      59      