   M S B A M L   `   `   `  ����Z  VSchoolBusFinalTask.Presentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:SchoolBusFinalTask.Presentation.Views%SchoolBusFinalTask.Presentation.Views  5   	   g8clr-namespace:SchoolBusFinalTask.Presentation.ViewModels*SchoolBusFinalTask.Presentation.ViewModels  5   	   6    0SchoolBusFinalTask.Presentation.Views.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Elocal3clr-namespace:SchoolBusFinalTask.Presentation.Views     5   	   N	viewModel8clr-namespace:SchoolBusFinalTask.Presentation.ViewModels     5   	     � Title$  
School Bus��5
   	   $	��450��6   $	��800��6)   .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��6* �6   .+�5   
   �  � RowDefinitions 5      �� 5      $
��2.5* �6    �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5      �� $��/Images/SchoolBus2.png��6   �� 5       $��Create Ride��6   $��1��6+   
������ $	��5,8q�6Q   
��� �����6s   �� *CreateRideCommand+�� 5!      $��Rides��6   $��2��6%   
������ $	��5,8q�6K   
��� �����6m   �� *RidesViewCommand+�� 5"      $��Class��6   $��3��6%   
������ $	��5,8q�6K   
��� �����6m   �� *ClassViewCommand+�� 5#      $��Student��6   $��4��6'   
������ $	��5,8q�6M   
��� �����6o   �� *StudentViewCommand+�� 5$      $��Parent��6   $��5��6&   
������ $	��5,8q�6L   
��� �����6n   �� *ParentViewCommand+�� 5%      $��Driver��6   $��6��6&   
������ $	��5,8q�6L   
��� �����6n   �� *DriverViewCommand+�� 5&      $	��Car��6   $��7��6#   
������ $	��5,8q�6I   
��� �����6k   �� *CarViewCommand+�� 5'      $��Holidays��6   $��8��6(   
������ $	��5,8q�6N   
��� �����6p   �� *HolidaysViewCommand+5)      �� 5+   
   $��1��6   ��6)   �� *CurrentViewModel+5-      5.      