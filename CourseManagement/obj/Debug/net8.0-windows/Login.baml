   M S B A M L   `   `   `  ����K  GCourseManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:CourseManagementCourseManagement  5   	       CourseManagement.Login   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:CourseManagement     5   	     � Title$  Login��5   	   $	��450��6   $	��800��6$   ���	#FFEEEEEE.��5	      �  � RowDefinitions 5
   
   �� 5      $	��100 �6   �� 5      $	��100 �6   �� 5      $	��100 �6   �� 5      $	��100 �6    � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5      $	��100 �6   �� 5      $	��100 �6   �� 5      $	��100 �6   �� 5      $	��100 �6   �� 5      $	��200 �6   .+�5   
   �� -   5         ��Name$ lblLogin��5      $��Login��6"   $��0��62   $��2��6?   $��2��6O   $��Center=�6c   $��Center=�6�   
���  ��$��50(�6�   �� 5   
   $��
User Name:��6   $��1��6%   $��1��62   $��Center=�5      $��0,0,0,10q�6+   $��16(�5      ���#3333336   �� 5!   
   -   5         ��Name$ txtUserName��5!      $��1��6'   $��2��64   $	��200��5"      $��30��6   $��	10,0,0,10q�6*   $��16(�5#      $��5q�6    ���#AAAAAA$��1q�6B   
����������#333333$��3��5$   :   �� 5'   
   $��	Password:��6   $��2��6$   $��1��61   $��Center=�5(      $��0,0,0,10q�6+   $��16(�5)      ���#3333336   G� 5,   
   -   5         G�Name$ txtPassword��5,      $��2��6+   $��2��68   $	��200��5-      $��30��6"   $��	10,0,0,10q�6.   $��16(�5.      $��5q�6$   ���#AAAAAA$��1q�6F   
����������#333333$��3��5/   >   �� 52   
   -   5        $��Login��52      $��3��6!   $��2��6.   $	��100��53      $��35��6   $��	10,10,0,0q�6)   $��16(�54      $��5q�6   ���#2196F3
����������#1976D2$��1q�55   '   $��Center=�56      $��2��6C   57      58      