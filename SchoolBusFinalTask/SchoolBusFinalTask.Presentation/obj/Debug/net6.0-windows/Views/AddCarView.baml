   M S B A M L   `   `   `  ����Z  VSchoolBusFinalTask.Presentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:SchoolBusFinalTask.Presentation.Views%SchoolBusFinalTask.Presentation.Views  5   	   6    0SchoolBusFinalTask.Presentation.Views.AddCarView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Elocal3clr-namespace:SchoolBusFinalTask.Presentation.Views     5   	     � Title$  
AddCarView��5   	   $	��200��6   $	��600��6)   .��5	      �  � ColumnDefinitions 5   
   �� 5      �� 5      $
��3.5* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��Name:��6   $��10q�6!   �� 5   
   -   5        $��CarNameTextBox��5   P   $��0��6   $��1��6   $��10q�6/   
��� �����6f   �� *Name+ �� Mode$ TwoWay=��� 5   
   $��1��6   $��Number:��6!   $��10q�60   �� 5   
   -   5        $��CarNumberTextBox��5   P   $��1��6   $��1��6   $��10q�6/   
��� �����6h   �� *	CarNumber+$ TwoWay=��� 5   
   $��2��6   $��Seat Count:��6!   $��10q�64   �� 5   
   -   5        $��CarSeatCountTextBox��5   P   $��2��6   $��1��6   $��10q�6/   
��� �����6k   �� *	SeatCount+$ TwoWay=��� 5"   
   $��3��6   $��Create��6   $��10q�6/   $��2��6;   
��� ���$	��100��6c   ��6o   �� *SubmitCommand+5%      5&      