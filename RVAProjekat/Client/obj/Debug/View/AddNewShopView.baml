   M S B A M L   `   `   `  ����A  =Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Client.ViewClient.View  5   	        Client.View.AddNewShopView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Client.View     5   	     � Title$  AddNewShopView��5   	   $	��450��6    $	��800��6-    � 
ResizeMode$ NoResize=�69    � WindowStartupLocation$ CenterScreen=�6O    � 	Resources 5	         TextBoxBaseControlTemplate �� 
TargetType ��Name �� CornerRadius ��Name �� Triggers	 P� Property
 P� Value �� Value �� 
TargetName �� Property��%�  &	        �� 5
   
   " ��6=   .R�5      �� $ Bd��5      #��z��5      ���	#FF252323#��z��5      $ 5��6E   ._�5      �� $ PART_ContentHost��6   5       5      P� 5      	 � {�
 .  . �5      �� # � ��63   $ Bd��6u    � ���� 5      # � ��63    � ��5      P� 5      	 � ��$

 Auto��6+   . �5      ��  � ��$	 100��61   5      P� 5      	 � ��$

 Auto��6,   . �5      ��  � ��$ 20��62   5      5      5      .��5       � ���	#FF373737.+�5!   
   �� $��New Shop��6   $��Center=�6#   $��Center=�6G   $��66��6d   $��
10,10,10,0q�6p   $	��Top=�6�   $	��772��6�   $��34(�6�   $��Segoe UI)�6�   ���	#FFFBFB9F6�   �� 5#   
   #��[  6   $
��Left=�6I   $
��Left=�6d   $��Center=�6�   $��49��6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6  $	��285��6#  $��267,106,0,0q�6/  ���	#FF2E2E2E���	#FFA7A9A8$��22(�6r  ��6�   �� *NewShop.Name+ �� UpdateSourceTrigger$ PropertyChanged=�6r  �� 5$   
   $
��Name��6   $
��Left=�6    $��49��6;   $��108,106,0,0q�6G   $	��Top=�6\   $	��154��6t   $��Segoe UI)�6�   ���	#FFFBFB9F$��27(�6�   �� 5%   
   $	��Add��6   $
��Left=�6F   $	��Top=�6a   $	��158��6y   $��556,321,0,0q�6�   $��45��6�   $��Segoe UI)�6�   ���	#FFFBFB9F
������ 
�������$��22(�6   ��6   �� *AddThisShopCommand+6   �� 5&   
   #��[  6   $
��Left=�6I   $
��Left=�6d   $��Center=�6�   $��49��6�   $
 Wrap=�6�   $	��Top=�6  $	��285��6&  $��267,160,0,0q�62  ���	#FF2E2E2E���	#FFA7A9A8$��22(�6u  ��6�   �� *NewShop.Address+$ PropertyChanged=�6u  �� 5'   
   $��Address��6   $
��Left=�6#   $��49��6>   $��108,160,0,0q�6J   $	��Top=�6_   $	��154��6w   $��Segoe UI)�6�   ���	#FFFBFB9F$��27(�6�   �� 5(   
   #��[  6   $
��Left=�6I   $
��Left=�6d   $��Center=�6�   $��49��6�   $
 Wrap=�6�   $	��Top=�6  $	��285��6*  $��267,214,0,0q�66  ���	#FF2E2E2E���	#FFA7A9A8$��22(�6y  ��6�   �� *NewShop.PhoneNumber+$ PropertyChanged=�6y  �� 5)   
   $��
Ph. Number��6   $
��Left=�6&   $��49��6A   $��108,214,0,0q�6M   $	��Top=�6b   $	��154��6z   $��Segoe UI)�6�   ���	#FFFBFB9F$��27(�6�   5+      5,      