   M S B A M L   `   `   `  ����Z  VSchoolBusFinalTask.Presentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:SchoolBusFinalTask.Presentation.Views%SchoolBusFinalTask.Presentation.Views  5      :    4SchoolBusFinalTask.Presentation.Views.CreateRideView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Elocal3clr-namespace:SchoolBusFinalTask.Presentation.Views     5      .��5	      �   � ColumnDefinitions  5   
   �� 5      �� 5      $
��2.5* �6    � RowDefinitions 5   
   �� 5      �� 5      .+�5   
   � $��2��6     5      �� 5      �� 5      $
��1.5* �6#    5      �� 5      $
��Auto �6    �� 5       $
��Auto �6    �� 5!      $
��Auto �6    �� 5"      $
��Auto �6    �� 5#      $
��Auto �6    �� 5$      $
��Auto �6    �� 5%      $
��Auto �6    .+�5(      �� $��	Fullname:��6   $��10q�6)   �� 5)      $��0��6   $��1��6#   $��10q�63   
��� �����6T   �� *SelectedDriver.FirstName+ �� Mode$ TwoWay=��� 5+      $��1��6   $��	Car Name:��6%   $��10q�66   �� 5,      $��1��6   $��1��6#   $��10q�63   
��� �����6T   �� *SelectedDriver.Car.Name+$ TwoWay=��� 5.      $��2��6   $��Car Number:��6%   $��10q�68   �� 5/      $��2��6   $��1��6#   $��10q�63   
��� �����6T   �� *SelectedDriver.Car.CarNumber+$ TwoWay=��� 51      $��3��6   $��Students Attend:��6%   $��10q�6=   �� 52      $��3��6   $��1��6#   $��10q�63   
��� �����6T   �� *StudentsAttend+$ TwoWay=��� 54      $��4��6   $��
Max Seats:��6%   $��10q�67   �� 55      $��4��6   $��1��6#   $��10q�63   
��� �����6T   �� *SelectedDriver.Car.SeatCount+$ TwoWay=��� 57      $��5��6   $��Driver:��6%   $��10q�64   �� 58      $��5��68   $��1��6E   $��10q�6U   
��� �����6   �� *	Drivers+ �� SelectedItem 6v   �� *SelectedDriver+$ TwoWay=��� 5<      $��6��6   $��Create��6"   $��10q�63   $��2��6?   
��� ���$	��100��6g   ��6s   �� *CreateRideCommand+5>      � 5C   
   $��1��6   .+�5E      �� -   5        $��Student_List��5E   M   $��1��6@    6   �� *SelectedStudent+��6a   �� *
Students+��5F      �� 5G       �� 
TargetType" ��6   .�5H      ��  �� Property � �� �� Value$ Center=�6G   �� 5I       � ��$ 20(�65   �� 5J       � ��$ DemiBold"�67   5K       �� View 5M      �� 5N      .P�5O      �� $��	FirstName��6T    �� Width$	 180��6g   	 �� DisplayMemberBinding	 6)   �� *	FirstName+6u   �� 5P      $��LastName��6S   $	 180��6e   	 6)   �� *
LastName+6s   �� 5Q      $��Parent��6[   $	 180��6k   	 6)   �� *Parent.FirstName+6y   �� 5R      $��Class��6U   $	 180��6d   	 6)   �� *
Class.Name+6r   �� 5S      $	��Add��6)   $	 110��66   
 �� CellTemplate
 5T      �� 5U   "   .R�5V   &   ��  �� Orientation$ 
Horizontal=�61   .+�5W   *   ��  ��Name$ AddStudent_Btn��5X   (   $��10q�5[   )   $��30��5]   )   $��30��5^   )   
���W�.�{�5Y   (   ��  �� Path$ 
IsSelected� �� RelativeSource �� *FindAncestor+ �� AncestorType" ����5\   )   �� *DataContext.AddStudentCommand+ �� ElementName$ Student_List��.��5a   .   �� $9��3https://www.pngmart.com/files/21/Add-Button-PNG.png��64   5b   +   5d   '   5e   #   5g      5h      5j      5k      � 5u   
   $��1��6   $��1��6   .+�5w      �� -   5        $��AttendStudent_List��5w   K   $��1��6>    6   �� *AttendStudent+��6e   �� *AttendStudents+��5x      �� 5y      " ��6   .�5z      ��  � ��$ Center=�6G   �� 5{       � ��$ 20(�65   �� 5|       � ��$ DemiBold"�67   5}       5      �� 5�      .P�5�      �� $��	FirstName��6T   $	 180��6g   	 6)   �� *	FirstName+6u   �� 5�      $��LastName��6S   $	 180��6e   	 6)   �� *
LastName+6s   �� 5�      $��Parent��6[   $	 180��6k   	 6)   �� *Parent.FirstName+6y   �� 5�      $��Class��6U   $	 180��6d   	 6)   �� *
Class.Name+6r   �� 5�      $	��Add��6)   $	 110��66   
 5�      �� 5�   "   .R�5�   &   �� $ 
Horizontal=�61   .+�5�   *   �� $ RemoveStudent_Btn��5�   (   $��10q�5�   )   $��30��5�   )   $��30��5�   )   
���W�.�{�5�   (   �� $ 
IsSelected� �� *FindAncestor+" ����5�   )   �� *" DataContext.RemoveStudentCommand+$ AttendStudent_List��.��5�   .   �� $;��5https://static.thenounproject.com/png/4143606-200.png��64   5�   +   5�   '   5�   #   5�      5�      5�      5�      5�      5�      