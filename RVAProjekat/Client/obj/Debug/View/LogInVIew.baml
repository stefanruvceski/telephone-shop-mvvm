   M S B A M L   `   `   `  ����A  =Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Client.ViewClient.View  5   	       Client.View.LogInVIew   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Client.View     5   	     � Title$  	LogInVIew��5   	   $��322.5��6   $	��629��6*    � 
ResizeMode$ NoResize=�66    � WindowStartupLocation$ CenterScreen=�6L    � 	Resources 5	         TextBoxBaseControlTemplate �� 
TargetType ��Name �� CornerRadius ��Name �� Triggers	 P� Property
 P� Value �� Value �� 
TargetName �� Property��%�  &	        �� 5
   
   " ��6=   .R�5      �� $ Bd��5      #��z��5      ���	#FF252323#��z��5      $ 5��6E   ._�5      �� $ PART_ContentHost��6   5       5      P� 5      	 � {�
 .  . �5      �� # � ��63   $ Bd��6u    � ���� 5      # � ��63    � ��5      P� 5      	 � ��$

 Auto��6+   . �5      ��  � ��$	 100��61   5      P� 5      	 � ��$

 Auto��6,   . �5      ��  � ��$ 20��62   5      5      5      .��5      � ���	#FF373737.+�5    
   �� $��Log in��6   $��Center=�6!   $��66��6E   $��248,10,246,0q�6Q   $	��Top=�6g   $��26(�6�   $��Segoe UI)�6�   ���	#FFFBFB9F6�   �� 5!   
   $��	Username:��6   $
��Left=�6$   $
��Left=�6F   $��34��6a   $��
116,95,0,0q�6m   $	��Top=�6�   $	��102��6�   $��Segoe UI)�6�   ���	#FFFBFB9F$��20(�6�   �� 5"   
   $��	Password:��6   $
��Left=�6$   $
��Left=�6F   $��38��6a   $��121,135,0,0q�6m   $	��Top=�6�   $��97��6�   $��Segoe UI)�6�   ���	#FFFBFB9F$��20(�6�   �� 5#   
   #��[  6   $
��Left=�6I   $
��Left=�6d   $��Center=�6�   $��Khmer UI)�6�   $��20(�6�    �� TextWrapping$
 Wrap=�6  $	��244��6   $��
258,90,0,0q�6,  ���	#FF2E2E2E���	#FF282829���	#FFA7A9A8$��39��6�  $	��Top=�6�  ��6�   �� *
UserName+ �� UpdateSourceTrigger$ PropertyChanged=�6�  �� 5$   
   #��[  6   $
��Left=�6I   $
��Left=�6e   $��Center=�6�   $��Khmer UI)�6�   $��20(�6�   $
 Wrap=�6  $	��243��6   $��257,134,0,0q�6,  ���	#FF2E2E2E���	#FF282829���	#FFA7A9A8$��39��6�  $	��Top=�6�  ��6�   �� *
Password+$ PropertyChanged=�6�  �� 5&   
   $��Log in��6   $
��Left=�6D   $��19(�6`   $	��Top=�6n   $��90��6�   $��408,220,0,0q�6�   $��34��6�    J� RenderTransformOrigin$ 0.769,0.381&�6�   $��Segoe UI)�6�   
������ 
����������	#FFFBFB9F��6#   �� *LogInCommand+6  5(      5)      