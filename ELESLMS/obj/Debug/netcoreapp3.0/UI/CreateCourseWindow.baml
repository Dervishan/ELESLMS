   M S B A M L   `   `   `  ����B  >ELESLMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:ELESLMS.UI
ELESLMS.UI  5   	   #    ELESLMS.UI.CreateCourseWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:ELESLMS.UI     5   	     � Title$  CreateCourseWindow��5   	   $	��450��6$   $	��350��61   .��5	      � $��10q�6    � RowDefinitions 5
   
   �� 5      $��60 �6   6*   �� 5      $��60 �6   6*   �� 5      $��60 �6   6*   �� 5      $��60 �6   6*   �� 5      $��* �6   6)   �� 5      $��60 �6   6*   .+�5   
   �� $��0��6   $��1q�6!   $��30(�6,   $��Right=�6:   $��Center=�6V   Create Course6�   �� 5   
   $��1��6   $��1q�6!   $��30(�6,   $
��Left=�6:   $��Center=�6U   Course Name:6~   �� 5   
   -   5         ��Name$ txtName��5      $��2��6#   $��1q�60   $��30(�6;   $��Center=�6I   $��Center=�6d   6�   �� 5   
   $��3��6   $��1q�6!   $��30(�6,   $
��Left=�6:   $��Center=�6U   Definition:6}   �� 5   
   -   5        $ txtDefinition��5      $��4��6)   $��1,0,1,0q�66   $��30(�6G   $��Center=�6U   $��Center=�6p    �� AcceptsReturn$
 True��6�    �� TextWrapping$
 Wrap=�6�   $	��114��6�   6�   �� 5   
   -   5         ��Name$ 	btnCancel��5      $��Cancel��6$   $��5��65   $	��140��6B   $��10q�6N   $
��Left=�6Z   6�   �� 5   
   -   5        $ 
btnConfirm��5      $��Confirm��6%   $��5��67   $	��140��6D   $��10q�6P   $��Right=�6\   6�   �� 5   
   $��1��6   $��5��6   $��1q�6/   6E   5      5      