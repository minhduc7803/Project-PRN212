   M S B A M L   `   `   `  ����K  GCourseManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:CourseManagement.CoursesManageCourseManagement.CoursesManage  5   	   2    ,CourseManagement.CoursesManage.AddAssessment   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >local,clr-namespace:CourseManagement.CoursesManage     5   	     � Title$  AddAssessment��5   	   $	��450��6   $	��800��6,    � 	Resources 5	       �� 
TargetType �� Property �� Value��%T  '��       '�� �     '�� *    '�� �    �� 5
   
   " ��6   .�5      ��  � ��$ 14(�6)   �� 5       � ��$ 5q�6(   �� 5       � ��$ 0,0,0,10q�6'   5      �� 5   
   " ��6   .�5      ��  � ��$ 14(�6)   �� 5       � ��$ 5q�6(   �� 5       � ��$ 0,0,0,10q�6'   5      �� 5   
   " ��6   .�5      ��  � ��$ 14(�6)   �� 5       � ��$ 0,0,0,5q�6'   5      �� 5   
   " ��6   .�5      ��  � ��$ 14(�6)   �� 5       � ��$
 10,5q�6(   �� 5       � ��$ 5q�6'   5      5      .��5      �  � RowDefinitions 5   
   �� 5       $
��Auto �6   �� 5!      $��* �6   .+�5#   
   �� $��ADD NEW ASSESSMENT��6   
���  ��$��16(�6>   $
��Bold"�6L   $��10q�6^   $��Center=�6j   �� 5$   
   
�������$��1q�6$    �� CornerRadius$ 5��68    �� Padding$ 20q�6I   $��10q�6V   $��1��6b   ._�5%      �� .+�5&      �� $��Type:��6   �� 5'      -   5         ��Name$ cmbType��5'      .@�5(      �� $	��Lab��6#   �� 5)      $
��Quiz��6#   �� 5*      $��
Assignment��6#   �� 5+      $��Class Participation��6#   �� 5,      $��Practical Exam��6#   �� 5-      $��
Final Exam��6#   5.      �� 5/      $��Name:��6   �� 50      -   5        	 ��Name$	 txtName��50      �� 51      $��Percent:��6   �� 52      -   5        $	 
txtPercent��52      �� 53      -   5        $	��Add��53      $	��100��6'   63   54      55      56      57      