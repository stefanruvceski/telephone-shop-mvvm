   M S B A M L   `   `   `  ����A  =Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Client.ViewClient.View  5   	       Client.View.AddUserView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Client.View     5   	     � Title$  AddUserView��5   	   $	��450��6   $	��800��6*    � 
ResizeMode$ NoResize=�66    � WindowStartupLocation$ CenterScreen=�6L    � 	Resources 5	         TextBoxBaseControlTemplate �� 
TargetType ��Name �� CornerRadius ��Name �� Triggers	 P� Property
 P� Value �� Value �� 
TargetName �� Property��%�  &	        �� 5
   
   " ��6=   .R�5      �� $ Bd��5      #��z��5      ���	#FF252323#��z��5      $ 5��6E   ._�5      �� $ PART_ContentHost��6   5       5      P� 5      	 � {�
 .  . �5      �� # � ��63   $ Bd��6u    � ���� 5      # � ��63    � ��5      P� 5      	 � ��$

 Auto��6+   . �5      ��  � ��$	 100��61   5      P� 5      	 � ��$

 Auto��6,   . �5      ��  � ��$ 20��62   5      5      5      .��5       � ���	#FF373737.+�5!   
   �� $��New user��6   $��Center=�6#   $
��Left=�6G   $��66��6b   $��
235,10,0,0q�6n   $	��Top=�6�   $	��299��6�   $��28(�6�   $��Segoe UI)�6�   ���	#FFFBFB9F6�   �� 5#   
   #��[  6   $
��Left=�6I   $��39��6d    �� TextWrapping$
 Wrap=�6p   $	��Top=�6�   $	��227��6�   $��
325,81,0,0q�6�   ���	#FF2E2E2E���	#FFA7A9A8$��22(�6-  ��6�   �� *NewUser.Name+ �� UpdateSourceTrigger$ PropertyChanged=�6-  �� 5$   
   #��[  6   $
��Left=�6I   $��39��6d   $��325,125,0,0q�6p   $
 Wrap=�6�   $	��Top=�6�   $	��227��6�   ���	#FF2E2E2E���	#FFA7A9A8$��22(�62  ��6�   �� *NewUser.LastName+$ PropertyChanged=�62  �� 5%   
   #��[  6   $
��Left=�6I   $��39��6d   $��325,169,0,0q�6p   $
 Wrap=�6�   $	��Top=�6�   $	��227��6�   ���	#FF2E2E2E���	#FFA7A9A8$��22(�62  ��6�   �� *NewUser.Username+$ PropertyChanged=�62  �� 5&   
   #��[  6   $
��Left=�6I   $��39��6d   $��325,213,0,0q�6p   $
 Wrap=�6�   $	��Top=�6�   $	��227��6�    J� RenderTransformOrigin$ 0.476,0.506&�6  ���	#FF2E2E2E���	#FFA7A9A8$��22(�6V  ��6�   �� *NewUser.Password+$ PropertyChanged=�6V  �� 5'   
   $��Name:��6   $
��Left=�6!   $��33��6<   $��
172,81,0,0q�6H   $	��Top=�6\   $	��148��6t   $��Segoe UI)�6�   ���	#FFFBFB9F$��22(�6�   �� 5(   
   $��	Lastname:��6   $
��Left=�6%   $��33��6@   $��172,125,0,0q�6L   $	��Top=�6a   $	��148��6y   $��Segoe UI)�6�   ���	#FFFBFB9F$��22(�6�   �� 5)   
   $��	Username:��6   $
��Left=�6%   $��33��6@   $��172,172,0,0q�6L   $	��Top=�6a   $	��148��6y   $��Segoe UI)�6�   ���	#FFFBFB9F$��22(�6�   �� 5*   
   $��	Password:��6   $
��Left=�6%   $��33��6@   $��172,219,0,0q�6L   $	��Top=�6a   $	��148��6y   $��Segoe UI)�6�   ���	#FFFBFB9F$��22(�6�   �� 5+   
   $	��Add��6   $
��Left=�6B   $	��Top=�6]   $	��158��6u   $��599,350,0,0q�6�   $��45��6�   $��Segoe UI)�6�   ���	#FFFBFB9F
������ 
�������$��22(�6�   ��6   �� *AddUserCommand+6�   �� 5,   
   $��Segoe UI)�6   ���	#FFFBFB9F$��Admin��6@   $
��Left=�6�   $��45��6�   $��325,283,0,0q�6�   $	��Top=�6�   $��95��6�   $��24(�6�   ���	#FFFBFB9F���	#FF1F5076 d� 	IsChecked 6P   �� *Admin+$ PropertyChanged=�6  5.      5/      