   M S B A M L   `   `   `  ����A  =Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Client.ViewClient.View  5   	   $    Client.View.ChangeShopInfoVIew   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Client.View     5   	     � Title$  ChangeShopInfoVIew��5   	   $	��450��6$   $	��800��61    � 
ResizeMode$ NoResize=�6=    � WindowStartupLocation$ CenterScreen=�6S    � 	Resources 5	         TextBoxBaseControlTemplate �� 
TargetType ��Name �� CornerRadius ��Name �� Triggers	 P� Property
 P� Value �� Value �� 
TargetName �� Property��%�  &	        �� 5
   
   " ��6=   .R�5      �� $ Bd��5      #��z��5      ���	#FF252323#��z��5      $ 5��6E   ._�5      �� $ PART_ContentHost��6   5       5      P� 5      	 � {�
 .  . �5      �� # � ��63   $ Bd��6u    � ���� 5      # � ��63    � ��5      P� 5      	 � ��$

 Auto��6+   . �5      ��  � ��$	 100��61   5      P� 5      	 � ��$

 Auto��6,   . �5      ��  � ��$ 20��62   5      5      5      .��5       � ���	#FF373737.+�5!   
   �� $��View and change Shop��6   $��Center=�6/   $
��Left=�6S   $��66��6n   $��
186,10,0,0q�6z   $	��Top=�6�   $	��419��6�   $��28(�6�   $��Segoe UI)�6�   ���	#FFFBFB9F6�   �� 5#   
   #��[  6   $
��Left=�6I   $��37��6d   $��290,122,0,0q�6p    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��315��6�   ���	#FF2E2E2E���	#FFA7A9A8$��22(�6  ��6�   �� *CurrentShop.Name+6  �� 5$   
   $
��Name��6   $
��Left=�6   $��37��6:   $��160,122,0,0q�6F   $	��Top=�6[   $	��126��6s   $��Segoe UI)�6   ���	#FFFBFB9F$��22(�6�   �� 5%   
   $��Change��6   $
��Left=�6L   $��61��6g   $��160,348,0,0q�6s   $	��Top=�6�   $	��445��6�   $��Segoe UI)�6�   ���	#FFFBFB9F
������ 
�������$��22(�6  ��6"   �� *ChangeThisShopCommand+6  �� 5&   
   #��[  6   $
��Left=�6I   $��37��6d   $��290,164,0,0q�6p   $
 Wrap=�6�   $	��Top=�6�   $	��315��6�   ���	#FF2E2E2E���	#FFA7A9A8$��22(�6  ��6�   �� *CurrentShop.Address+6  �� 5'   
   $��Address��6   $
��Left=�6"   $��37��6=   $��160,164,0,0q�6I   $	��Top=�6^   $	��126��6v   $��Segoe UI)�6�   ���	#FFFBFB9F$��22(�6�   �� 5(   
   #��[  6   $
��Left=�6I   $��37��6d   $��290,206,0,0q�6p   $
 Wrap=�6�   $	��Top=�6�   $	��315��6�   ���	#FF2E2E2E���	#FFA7A9A8$��22(�6  ��6�   �� *CurrentShop.PhoneNumber+6  �� 5)   
   $��
Ph. Number��6   $
��Left=�6%   $��37��6@   $��160,206,0,0q�6L   $	��Top=�6a   $	��126��6y   $��Segoe UI)�6�   ���	#FFFBFB9F$��22(�6�   5,      5-      