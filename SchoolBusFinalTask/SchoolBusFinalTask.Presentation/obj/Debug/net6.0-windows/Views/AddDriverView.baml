   M S B A M L   `   `   `  ����Z  VSchoolBusFinalTask.Presentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:SchoolBusFinalTask.Presentation.Views%SchoolBusFinalTask.Presentation.Views  5   	   9    3SchoolBusFinalTask.Presentation.Views.AddDriverView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Elocal3clr-namespace:SchoolBusFinalTask.Presentation.Views     5   	     � Title$  
New Driver��5   	   $	��380��6   $	��600��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5      $
��3.5* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��First Name:��6   $��10q�6'   �� 5   
   -   5        $��FirstNameTextBox��5   P   $��0��6   $��1��6   $��10q�6/   
��� �����6h   �� *	FirstName+ �� Mode$ TwoWay=��� 5   
   $��1��6   $��
Last Name:��6!   $��10q�63   �� 5    
   -   5        $��LastNameTextBox��5    P   $��1��6   $��1��6   $��10q�6/   
��� �����6g   �� *
LastName+$ TwoWay=��� 5"   
   $��2��6   $��Phone:��6!   $��10q�6/   �� 5#   
   -   5        $��PhoneTextBox��5#   P   $��2��6   $��1��6   $��10q�6/   
��� �����6d   �� *Phone+$ TwoWay=��� 5%   
   $��3��6   $��	Username:��6!   $��10q�62   �� 5&   
   -   5        $��UserNameTextBox��5&   P   $��3��6   $��1��6   $��10q�6/   
��� �����6g   �� *
UserName+$ TwoWay=��� 5(   
   $��4��6   $��	Password:��6!   $��10q�62   �� 5)   
   -   5        $��PasswordTextBox��5)   P   $��4��6   $��1��6   $��10q�6/   
��� �����6g   �� *
Password+$ TwoWay=��� 5+   
   $��5��6   $
��Car:��6!   $��10q�6-   �� 5,   
   -   5        $��CarComboBox��5,   o   $��5��61   $��1��6>   $��10q�6N   
��� �����6   �� *Cars+ �� SelectedItem 6�   �� *Car+$ TwoWay=��� 5/   
   $��6��6   $��Home Address:��6!   $��10q�66   �� 50   
   -   5        $��HomeAddressTextBox��50   P   $��6��6   $��1��6   $��10q�6/   
��� �����6j   �� *HomeAddress+$ TwoWay=��� 52   
   $��7��6   $��License Agreement:��6!   $��10q�6;   �� 53   
   -   5        $��LicenseCheckBox��53   Q   $��7��6   $��1��6    $��10q�60   
��� ��� d� 	IsChecked 6h   �� *	License+$ TwoWay=��� 55   
   $��8��6   $��Create��6   $��10q�6/   $��2��6;   
��� ���$	��100��6c   ��6o   �� *SubmitCommand+57      58      