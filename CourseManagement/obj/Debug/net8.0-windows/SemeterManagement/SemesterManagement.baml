   M S B A M L   `   `   `  ����K  GCourseManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:CourseManagement.SemeterManagement"CourseManagement.SemeterManagement  5   	   ;    5CourseManagement.SemeterManagement.SemesterManagement   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Blocal0clr-namespace:CourseManagement.SemeterManagement     5   	   -   5          � Title$  SemesterManagement��5	      $	��600��6    $
��1000��6-   .��5
      � 
������� � ColumnDefinitions 5   
   �� 5      $	��150 �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��50 �6   �� 5      �� 5      $��0 �6   .+�5   
   �� $��2��6   $��0��6"    �� Orientation$ Vertical=�62   .+�5      �� -   5        $��btnHome��5      $
��Home��6$   $��5q�6N   $��40��6Y   �� 5      -   5        $��
btnCourses��5      $��Courses��6'   $��5q�6R   $��40��6]   �� 5      -   5        $��btnStudents��5      $��Students��6(   $��5q�6U   $��40��6`   �� 5      -   5        $��btnDepartments��5      $��Departments��6+   $��5q�6^   $��40��6i   �� 5      -   5        $��btnSemesters��5      $��	Semesters��6)   $��5q�6X   $��40��6c   �� 5      -   5        $��btnEnrollment��5      $��
Enrollment��6*   $��5q�6[   $��40��6f   5      �� 5   
   $��1��6   $��0��6%   .+�5       �� $��Semester Management��6   $��30(�62   $��10q�6@   $
��Bold"�6L   
���z���$��Center=�6w   $��Center=�6�   5!      �� 5"   
   $��1��6   $��1��6%   $��Center=�62   $��Center=�6O   .+�5#      �� $ 
Horizontal=�6   $��Center=�62   $��Center=�6M   .+�5$      �� $ 
Horizontal=�6   .+�5%      �� $��Filter by Year��6   �� 5&      -   5         ��Name$ YearComboBox��5&      $��60��65   $��25��6A   $
��10,0q�6M   6[   5'      �� 5(      $ 
Horizontal=�6   .+�5)      �� $��Filter by Date:��6   (  "System.Windows.Controls.DatePicker  5*      -	   5          Name$ 	StartDate��5*   !   $��25��64   $
��10,0q�6@   6N   �� 5+      $��to��6     5,      -
   5        $ EndDate��5,   !   $��25��62   $
��10,0q�6>   6L   5-      �� 5.      $ 
Horizontal=�6   .+�5/      �� -   5         ��Name$ Clear��5/      
���i��$��Clear��6X   $
��10,0q�6h   $��25��6v   $��70��6�   50      �� 51      $ 
Horizontal=�6   .+�52      �� -   5        $	 Add��52      $	��Add��6*   $��70��68   $��25��6C   
������$
��10,0q�6g   6u   53      �� 54      $ 
Horizontal=�6   .+�55      �� -   5        $
 Edit��55      $
��Edit��6+   $��70��6M   $��25��6X   
����ح�6d   56      57      58      &   System.Windows.Controls.DataGrid  59   
   -   5          Name$ semesterData��59      $��1��6)   $��2��69      AutoGenerateColumns$ False��6F   	   CanUserAddRows$	 False��6b   
   Columns
 5:      0  *System.Windows.Controls.DataGridTextColumn  5;      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6H   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+6H     5<      $
 Code��6%   $ * 6L    63   �� *Code+6L     5=      $
 Year��6%   $	 100 6L    63   �� *Year+6L     5>      $ 
Begin Date��6%   $	 108 6W    69   �� *	BeginDate+6W     5?      $ End Date��6%   $	 100 6S    67   �� *	EndDate+6S   5A      5B      5C      