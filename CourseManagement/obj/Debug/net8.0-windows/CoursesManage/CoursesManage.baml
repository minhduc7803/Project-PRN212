   M S B A M L   `   `   `  ����K  GCourseManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:CourseManagement.CoursesManageCourseManagement.CoursesManage  5   	   2    ,CourseManagement.CoursesManage.CoursesManage   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >local,clr-namespace:CourseManagement.CoursesManage     5   	     � Title$  CoursesManage��5   	   $	��500��6   $
��1028��6,    � 	Resources 5	      &   System.Windows.Controls.DataGrid �� 
TargetType �� Property �� Value��%�   '        �� 5
   
   "  6   .�5      ��  � ��$ 14(�6)   �� 5       �@ ColumnHeaderHeight$ 40Q�63   �� 5       �@ 	RowHeight$ 30Q�6*   �� 5       � ��$ 10q�6'   5      5      .��5      � 
�������$��0,0,42,0q�6%    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $	��54* �6   �� 5      $
��371* �6   .+�5   
   �� $��0��6   $��COURSE MANAGE��6   
���  ��$��0,0,0,9q�6F   $��Center=�6W   $��Center=�6t   $
��Bold"�6�   �� 5   
   $��1��6   $��0��6"    �� Orientation$ Vertical=�62   .+�5      �� -   5        $��btnHome��5      $
��Home��6$   $��5q�6I   $��40��6T   �� 5      -   5        $��
btnCourses��5      $��Courses��6'   $��5q�6R   $��40��6]   �� 5      -   5        $��btnStudents��5      $��Students��6(   $��5q�6U   $��40��6`   �� 5       -   5        $��btnDepartments��5       $��Departments��6+   $��5q�6^   $��40��6i   �� 5!      -   5        $��btnSemesters��5!      $��	Semesters��6)   $��5q�6X   $��40��6c   �� 5"      -   5        $��btnEnrollment��5"      $��
Enrollment��6*   $��5q�6[   $��40��6f   5#      �� 5$   
   $ 
Horizontal=�6   $��0��6.   $��1��6;   $��
10,10,0,10q�6K   .+�5%      �� $��Filter by Title:��6   $��5q�60   �� 5&      -   5        $��cbFilterTitle��5&      $	��200��6,   $��5q�68   6C   �� 5'      $��Filter by Credits:��6   $��5q�62   �� 5(      -   5        $��cboFilterCredits��5(      $��40��6/   $��5q�6:   6E   �� 5)      -	   5        $��btnClearFilter��5)      $��Clear Filter��6+   $
��Bold"�6B   $��5q�6q   $��70��6|   �� 5*      -
   5        $��btnAddCourse��5*      $��
ADD COURSE��6)   
������$	��100��6V   $
��Bold"�6}   $��5q�6�   �� 5+      -   5        $��btnUpdateCourse��5+      $��UPDATE COURSE��6,   
����� �$	��100��6V   $
��Bold"�6�   $��5q�6�   �� 5,      -   5        $��btnViewAssessments��5,      $��VIEW ASSESSMENTS��6/   
����ح�$	��120��6a   $
��Bold"�6�   $��5q�6�   5-      �� 5.   
   -   5        $��	btnLogout��5.      $��2��6   $��Log Out��60   $��5q�6Z   $��40��6e   $
��Bold"�6q   
����� �6�     5/   
   -   5        $��	dgCourses��5/      $��1��6$   $��1��61      AutoGenerateColumns$ False��6A   	   CanUserAddRows$	 False��6]   
   CanUserDeleteRows$
 False��6t   $��10,10,10,10q�6�      Columns 50      0  *System.Windows.Controls.DataGridTextColumn  51      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6H   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+6H     52      $
 Code��6%   $ * 6L    63   �� *Code+6L     53      $ Title��6%   $ * 6N    64   �� *Title+6N     54      $ Credits��6%   $ * 6R    66   �� *	Credits+6R   56      57      58      