   M S B A M L   `   `   `  ����K  GCourseManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:CourseManagementCourseManagement  5   	       CourseManagement.Window1   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:CourseManagement     5   	     � Title$  Window1��5   	   $	��450��6   $	��800��6&   .��5	      � ���	#FF74F4DD.+�5
   
    � -   5          �Name$ frMain��5
      $&�� Click Button to see page content��6    $	��Top=�5        � NavigationUIVisibility$ Visible=�6   $	��475��5      $��-20,-41,0,0q�6   �� 5   
   -   5        $��btnbacktomain��5      $��Back to Main��6&   $
��Left=�6=   $��26��6X   $��450,330,0,0q�6d   $	��Top=�6y   $��72��6�   6�   �� 5   
   $��Department Manage��6   $��Center=�6,   $��0,22,0,0q�6I   $	��Top=�6[   $	��342��6s   $��36(�6   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgDepartment��5         AutoGenerateColumns$ False��6)   $��10,92,487,10q�6E   ���	#FFF1A619   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Code��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6L   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *Code+6L     5      $
 Name��6%   $ * 6L    63   �� *Name+6L   5      �� 5   
   -   5        $��btnSave��5   �   $
��Save��6   $
��Left=�6    $��36��6;   $��430,181,0,0q�6G   $	��Top=�6\   $	��112��6t   ���	#FF2D56D7���	#FFF6F0F06�   �� 5   
   -   5        	 ��Name$	 btnReset��5   �   $��Reset��6   $
��Left=�6!   $��36��6<   $��430,240,0,0q�6H   $	��Top=�6]   $	��112��6u   ���	#FFF40A0A���	#FFFFFBFB6�   �� 5   
   -   5        
 ��Name$
 txtCode��5      $
��Left=�6$   $��37��6?   $��352,127,0,0q�6K    �� TextWrapping$
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��117��6�   �� 5   
   -   5        $
 txtName��5      $
��Left=�6#   $��37��6>   $��510,127,0,0q�6J   $
 Wrap=�6_   $�� ��6s   $	��Top=�6{   $	��118��6�   �� 5   
   $
��Code��6   $��Center=�6   $��30��6<   $��0,92,0,0q�6H   $	��Top=�6Z   $��95��6r   �� 5   
   $
��Name��6   $
��Left=�6   $��30��6:   $��
518,92,0,0q�6F   $	��Top=�6Z   $��96��6r   5      5      