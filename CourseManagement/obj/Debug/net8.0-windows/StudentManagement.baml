   M S B A M L   `   `   `  ����K  GCourseManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:CourseManagementCourseManagement  5   	   (    "CourseManagement.StudentManagement   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:CourseManagement     5   	     � Title$  StudentManagement��5   	   $	��450��6#   $	��874��60   .��5	      � $��	10,0,10,0q�6    � ColumnDefinitions 5
   
   �� 5      $	��19* �6   �� 5      $
��141* �6   .+�5   
   �� $��Students��6   $��Center=�6#   $��32��6@   $	��Top=�6L   $��78��6d   �� 5   
   $��Search: ��6   $
��Left=�6#   $��32��6>   $��	79,16,0,0q�6J   $	��Top=�6]   $��51��6u   $��2��6�   �� 5   
   -   5         ��Name$ txtSearchName��5      $��1��6)   $
��Left=�69   $��33��6T   $��	30,13,0,0q�6`    �� TextWrapping$
 Wrap=�6s   $�� ��6�   $	��Top=�6�   $��92��6�   6�   �� 5   
   $��1��6   $��Gender:��6    $
��Left=�62   $��27��6M   $��
122,16,0,0q�6Y   $	��Top=�6m   $��62��6�   �� 5   
   -   5         ��Name$ 	cboGender��5      $��1��6@   $
��Left=�6P   $��29��6k   $��
184,14,0,0q�6w   $	��Top=�6�   $��79��6�   �� 5   
   $��1��6   $��Department: ��6    $
��Left=�67   $��27��6R   $��
425,16,0,0q�6^   $	��Top=�6r   $��88��6�    J� RenderTransformOrigin$ -0.306,0.521&�6�   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ -0.487Q�6&   T� 5       T� X$ 0.007Q�6)    T� Y$ 0.603Q�63   5      5      �� 5   
   -   5        $ cboDepartment��5      $��1��6D   $
��Left=�6T   $��28��6o   $��
510,16,0,0q�6{   $	��Top=�6�   $��82��6�   �� 5   
   $��1��6   $��	Country: ��6    $
��Left=�64   $��25��6O   $��
268,14,0,0q�6[   $	��Top=�6o   $��64��6�   $ 0.073,0.669&�6�   �� 5   
   -   5        $ 
cboCountry��5      $��1��6A   $
��Left=�6Q   $��28��6l   $��
337,18,0,0q�6x   $	��Top=�6�   $��75��6�   $ 0.028,0.524&�6�   &   System.Windows.Controls.DataGrid  5    
   -   5        	  Name$	 dgData��5       $��2��6#   $
��Left=�67   $	��355��6R   $��	10,69,0,0q�6_   $	��Top=�6r   $	��826��6�   
   AutoGenerateColumns$
 False��6�      Columns 5!      0  *System.Windows.Controls.DataGridTextColumn  5"      ,  &System.Windows.Controls.DataGridColumn   Header$ 	StudentID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 68   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6B   �� *Id+  5#      $ StudentName��6%   $ * 6:    6D   �� *Name+  5$      $ 	BirthDate��6%   $ * 68    6B   �� *	Birthdate+  5%      $ Gender��6%   $ * 65    6?   �� *Gender+  5&      $ Address��6%   $ * 66    6@   �� *	Address+  5'      $
 city��6%   $ * 63    6=   �� *City+  5(      $ country��6%   $ * 66    6@   �� *	Country+  5)      $ 
Department��6%   $ * 69    6C   �� *
Department+5+      �� 5,   
   -   5        $��1��5,      $��Clear Filter��6!   $
��Left=�68   $��24��6S   $��
609,18,0,0q�6_   $	��Top=�6s   $��69��6�   6�   �� 5-   
   -   5        $��Add Student��5-      $
��Left=�6'   $��25��6B   $��0,39,0,0q�6N   $	��Top=�6`   $��74��6x   6�   5/      50      