   M S B A M L   `   `   `  ����K  GCourseManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:CourseManagement.CoursesManageCourseManagement.CoursesManage  5   	   3    -CourseManagement.CoursesManage.ViewAssessment   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >local,clr-namespace:CourseManagement.CoursesManage     5   	     � Title$  ViewAssessment��5   	   $	��450��6    $	��800��6-    � 	Resources 5	      &   System.Windows.Controls.DataGrid �� 
TargetType �� Property �� Value��%z  '        '�� �     �� 5
   
   "  6   .�5      ��  � ��$ 14(�6)   �� 5       �@ RowHeaderWidth$ 0Q�6/   �� 5       �@ ColumnHeaderHeight$ 40Q�63   �� 5       � ��$ 10q�6'   5      �� 5   
   " ��6   .�5      ��  � ��$ 14(�6)   �� 5       � ��$
 10,5q�6(   �� 5       � ��$ 5q�6'   5      5      .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��ASSESSMENT LIST��6   
���  ��$��16(�6;   $
��Bold"�6I   $��10q�6[   $��Center=�6g     5   
   -   5        $��dgAssessments��5         AutoGenerateColumns$ False��6(      CanUserAddRows$ False��6D      CanUserDeleteRows$ False��6[   $��1��6u   	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$

 Type��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6L   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *Type+6L     5       $

 Name��6%   $ * 6L    63   �� *Name+6L     5!      $
 Percent��6%   $
 Auto 6R    66   �� *	Percent+6R   5#      �� 5$   
   -   5        $��btnAddAssessment��5$   *   $��Add Assessment��6   $	��130��6B   $��35��6N   $��Right=�6Z   $��Bottom=�6v   $��10q�6�   $��2��6�   6�   5%      5&      