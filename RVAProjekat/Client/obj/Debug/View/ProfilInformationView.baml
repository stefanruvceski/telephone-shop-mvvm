   M S B A M L   `   `   `  ����A  =Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Client.ViewClient.View  5   	   '    !Client.View.ProfilInformationView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Client.View     5   	     � Title$  ProfilInformationView��5   	   $	��450��6'   $	��800��64    � 
ResizeMode$ NoResize=�6@    � WindowStartupLocation$ CenterScreen=�6V    � 	Resources 5	         TextBoxBaseControlTemplate �� 
TargetType ��Name �� CornerRadius ��Name �� Triggers	 P� Property
 P� Value �� Value �� 
TargetName �� Property��%�  &	        �� 5
   
   " ��6=   .R�5      �� $ Bd��5      #��z��5      ���	#FF252323#��z��5      $ 5��6E   ._�5      �� $ PART_ContentHost��6   5       5      P� 5      	 � {�
 .  . �5      �� # � ��63   $ Bd��6u    � ���� 5      # � ��63    � ��5      P� 5      	 � ��$

 Auto��6+   . �5      ��  � ��$	 100��61   5      P� 5      	 � ��$

 Auto��6,   . �5      ��  � ��$ 20��62   5      5      5      .��5       � ���	#FF373737.+�5!   
   �� $��Profil Information��6   $��Center=�6-   $
��Left=�6Q   $��66��6l   $��
186,10,0,0q�6x   $	��Top=�6�   $	��419��6�   $��Segoe UI)�6�   ���	#FFFBFB9F$��28(�6�   �� 5#   
   #��[  6   $��Center=�6I   $
��Left=�6k   $
��Left=�6�   $��51��6�   $��330,113,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��258��6  ���	#FF2E2E2E���	#FFA7A9A8$��22(�6Q  ��6�   �� *CurrentUser.Name+6Q  �� 5$   
   #��[  6   $��Center=�6J   $
��Left=�6l   $
��Left=�6�   $��51��6�   $��330,169,0,0q�6�   $
 Wrap=�6�   $	��Top=�6  $	��258��6  ���	#FF2E2E2E���	#FFA7A9A8$��22(�6V  ��6�   �� *CurrentUser.LastName+6V  �� 5%   
   $��Name:��6   $
��Left=�6    $��51��6;   $��160,116,0,0q�6G   $	��Top=�6\   $	��152��6t   $��Segoe UI)�6�   ���	#FFFBFB9F$��22(�6�   �� 5&   
   $��	Lastname:��6   $
��Left=�6$   $��51��6?   $��160,173,0,0q�6K   $	��Top=�6`   $	��152��6x   $��Segoe UI)�6�   ���	#FFFBFB9F$��22(�6�   �� 5'   
   $��Change��6   $
��Left=�6N   $��61��6i   $��160,313,0,0q�6u   $	��Top=�6�   $	��445��6�   $��Segoe UI)�6�   ���	#FFFBFB9F
������ 
�������$��22(�6  ��6"   �� *ChangeProfilInfoCommand+6  5*      5+      