   M S B A M L   `   `   `  ����Z  VSchoolBusFinalTask.Presentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:SchoolBusFinalTask.Presentation.Views%SchoolBusFinalTask.Presentation.Views  5   	   7    1SchoolBusFinalTask.Presentation.Views.EditCarView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Elocal3clr-namespace:SchoolBusFinalTask.Presentation.Views     5   	     � Title$  EditCarView��5   	   $	��200��6   $	��600��6*   .��5	      �  � ColumnDefinitions 5   
   �� 5      �� 5      $
��3.5* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��Name:��6   $��10q�6!   �� 5   
   $��0��6   $��1��6   $��10q�6/   
��� �����6P   �� *Name+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� 5   
   $��1��6   $��Number:��6!   $��10q�60   �� 5   
   $��1��6   $��1��6   $��10q�6/   
��� �����6P   �� *	CarNumber+$ TwoWay=��� 5   
   $��2��6   $��Seat Count:��6!   $��10q�64   �� 5   
   $��2��6   $��1��6   $��10q�6/   
��� �����6Q   �� *	SeatCount+$ TwoWay=��� 5"   
   $��3��6   $
��Edit��6   $��10q�6-   $��2��69   
��� ���$	��100��6a   ��6m   �� *EditCarCommand+5%      5&      