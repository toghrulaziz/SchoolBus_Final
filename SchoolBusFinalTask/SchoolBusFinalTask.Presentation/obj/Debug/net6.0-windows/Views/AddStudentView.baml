   M S B A M L   `   `   `  ����Z  VSchoolBusFinalTask.Presentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:SchoolBusFinalTask.Presentation.Views%SchoolBusFinalTask.Presentation.Views  5   	   :    4SchoolBusFinalTask.Presentation.Views.AddStudentView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Elocal3clr-namespace:SchoolBusFinalTask.Presentation.Views     5   	     � Title$  New Student��5   	   $	��450��6   $	��800��6*   .��5	      �  � ColumnDefinitions 5   
   �� 5      �� 5      $
��3.5* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��First Name:��6   $��10q�6'   �� 5   
   $��0��6   $��1��6   $��10q�6/   
��� �����6P   �� *	FirstName+ �� Mode$ TwoWay=��� 5   
   $��1��6   $��
Last Name:��6!   $��10q�63   �� 5   
   $��1��6   $��1��6   $��10q�6/   
��� �����6P   �� *
LastName+$ TwoWay=��� 5    
   $��2��6   $��Parent:��6!   $��10q�60   �� 5!   
   $��2��64   $��1��6A   $��10q�6Q   
��� �����6   �� *	Parents+ �� SelectedItem 6r   �� *Parent+$ TwoWay=��� 5$   
   $��3��6   $��Class:��6!   $��10q�6/   �� 5%   
   $��3��64   $��1��6A   $��10q�6Q   
��� �����6   �� *	Classes+ 6r   �� *Class+$ TwoWay=��� 5(   
   $��4��6   $��Home Address:��6!   $��10q�66   �� 5)   
   $��4��6   $��1��6   $��10q�6/   
��� �����6P   �� *HomeAddress+$ TwoWay=��� 5+   
   $��5��6   $��Other Address:��6!   $��10q�67   �� 5,   
   $��5��6   $��1��6   $��10q�6/   
��� �����6P   �� *OtherAddress+$ TwoWay=��� 5.   
   $��6��6   $��Create��6   $��10q�6/   $��2��6;   
��� ���$	��100��6c   ��6o   �� *SubmitCommand+52      53      