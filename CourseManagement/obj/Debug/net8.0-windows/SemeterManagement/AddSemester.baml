   M S B A M L   `   `   `  ����K  GCourseManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:CourseManagement.SemeterManagement"CourseManagement.SemeterManagement  5   	   4    .CourseManagement.SemeterManagement.AddSemester   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Blocal0clr-namespace:CourseManagement.SemeterManagement     5   	   -   5          � Title$  AddSemester��5      $	��450��6   $	��500��6&   .��5	      � 
������� � RowDefinitions 5
   
   �� 5      $��50 �6   �� 5      $��* �6   �� 5      $��70 �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��0��6.   $��Center=�6;   $��Center=�6X   .+�5      �� $��Add New Semester��6   $��30(�6/   $
��Bold"�6=   
���z���6O   5      �� 5   
   $ Vertical=�6   $��30,20q�6,   $��1��6;   .+�5      �� $ 
Horizontal=�6   .+�5      �� $
��Id :��6   $
��Bold"�6'   $��20(�69   $��0,0,10,0q�6H   �� 5      -   5         ��Name$ txtId��5      $
��Bold"�6+   $��20(�6=   $��0,5,0,0q�6K   5      �� 5      $
��Code��6   �� 5      -   5         ��Name$ txtCode��5      $��25��6'   63   �� 5      $
��Year��6   �� 5      -   5        $ txtYear��5      $��25��6S   �� 5      $��
Begin Date��6   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ txtStartDate��5      $��25��6f   �� 5      $��End Date��6     5      -   5        $ 
txtEndDate��5      $��25��6b   5       �� 5!   
   $ 
Horizontal=�6   $��2��6.   $��Center=�6;   $��Center=�6X   .+�5"      �� -   5         ��Name$ btnAdd��5"      $	��Add��6%   $	��150��6H   $��40��6T   $��26(�6`   
������6n   �� 5#      -   5        $ 	btnCancel��5#      $��Cancel��6(   $��10,0,0,0q�6Q   $	��150��6c   $��40��6o   $��26(�6{   
�������6�   5$      5%      5&      